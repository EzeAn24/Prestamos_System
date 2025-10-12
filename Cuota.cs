using System;

namespace WindowsFormsApp1
{
    // Un 'enum' es una forma genial de tener un conjunto de constantes con nombre.
    // Es mucho más claro que usar números como 0 para Pendiente y 1 para Pagada.
    public enum EstadoCuota
    {
        Pendiente,
        Pagada
    }

    public class Cuota
    {
        public int NumeroCuota { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public EstadoCuota Estado { get; set; }

        // Usamos 'DateTime?' (con ?) para indicar que puede ser nulo.
        // Una cuota pendiente no tiene fecha de pago.
        public DateTime? FechaDePago { get; set; }

        public Cuota()
        {
            // Por defecto, una cuota nueva siempre está pendiente.
            Estado = EstadoCuota.Pendiente;
        }
    }
}