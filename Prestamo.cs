using System;
using System.Linq;
using System.ComponentModel; // <-- PASO 1: AÑADIR ESTA LÍNEA

namespace WindowsFormsApp1
{
    public class Prestamo
    {
        // --- Propiedades ---
        public decimal MontoPrestado { get; set; }
        public int CantidadCuotas { get; set; }
        public DateTime FechaInicio { get; set; }
        public decimal TasaInteres { get; set; }
        public Persona Cliente { get; set; }

        // --- PASO 2: CAMBIAR List<Cuota> A BindingList<Cuota> ---
        public BindingList<Cuota> PlanDePagos { get; set; }

        // --- Propiedades Calculadas ---
        public string NombreCliente
        {
            get { return Cliente.ToString(); }
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

        // --- Constructor ---
        public Prestamo(decimal monto, int cuotas, DateTime fechaInicio, Persona cliente)
        {
            this.MontoPrestado = monto;
            this.CantidadCuotas = cuotas;
            this.FechaInicio = fechaInicio;
            this.Cliente = cliente;
            this.TasaInteres = 0.50m;

            // --- PASO 3: CAMBIAR LA INICIALIZACIÓN DE LA LISTA ---
            this.PlanDePagos = new BindingList<Cuota>();

            GenerarPlanDePagos();
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