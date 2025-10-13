using System;
using System.ComponentModel;
using System.Linq;

namespace WindowsFormsApp1
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public decimal MontoPrestado { get; set; }
        public int CantidadCuotas { get; set; }
        public DateTime FechaInicio { get; set; }
        public decimal TasaInteres { get; set; }
        public Persona Cliente { get; set; }
        public BindingList<Cuota> PlanDePagos { get; set; }

        // --- CONSTRUCTOR VACÍO AGREGADO ---
        // Esto es lo que Dapper necesita para poder crear el objeto
        // antes de rellenar sus propiedades desde la base de datos.
        public Prestamo() { }

        // Mantenemos el constructor que ya usábamos para crear nuevos préstamos desde el formulario.
        public Prestamo(decimal monto, int cuotas, DateTime fechaInicio, Persona cliente, decimal tasaInteres)
        {
            this.MontoPrestado = monto;
            this.CantidadCuotas = cuotas;
            this.FechaInicio = fechaInicio;
            this.Cliente = cliente;
            this.TasaInteres = tasaInteres;
            this.PlanDePagos = new BindingList<Cuota>();

            GenerarPlanDePagos();
        }

        // --- Propiedades Calculadas (sin cambios) ---
        public string NombreCliente
        {
            get { return Cliente?.ToString(); } // Añadida protección por si el cliente es nulo
        }

        public decimal MontoTotalConInteres
        {
            get { return MontoPrestado * (1 + TasaInteres); }
        }

        public decimal MontoAdeudado
        {
            get
            {
                if (PlanDePagos == null) return 0;
                return PlanDePagos.Where(c => c.Estado == EstadoCuota.Pendiente).Sum(c => c.Monto);
            }
        }

        private void GenerarPlanDePagos()
        {
            if (CantidadCuotas <= 0) return;
            decimal valorCuota = Math.Round(MontoTotalConInteres / CantidadCuotas, 2);
            for (int i = 1; i <= CantidadCuotas; i++)
            {
                Cuota nuevaCuota = new Cuota
                {
                    NumeroCuota = i,
                    Monto = valorCuota,
                    FechaVencimiento = this.FechaInicio.AddDays(i)
                };
                this.PlanDePagos.Add(nuevaCuota);
            }
        }
    }
}