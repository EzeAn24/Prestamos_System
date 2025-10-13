using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public enum EstadoCuota
    {
        Pendiente,
        Pagada
    }

    // Le decimos a la clase que puede "notificar cambios en sus propiedades"
    public class Cuota : INotifyPropertyChanged
    {
        // Campos privados para almacenar los valores
        private int _id;
        private int _prestamoId;
        private int _numeroCuota;
        private decimal _monto;
        private EstadoCuota _estado;
        private DateTime _fechaVencimiento;
        private DateTime? _fechaDePago;

        // Propiedades públicas que el DataGridView usa
        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        public int PrestamoId
        {
            get { return _prestamoId; }
            set { _prestamoId = value; OnPropertyChanged(); }
        }

        public int NumeroCuota
        {
            get { return _numeroCuota; }
            set { _numeroCuota = value; OnPropertyChanged(); }
        }

        public decimal Monto
        {
            get { return _monto; }
            set { _monto = value; OnPropertyChanged(); }
        }

        public EstadoCuota Estado
        {
            get { return _estado; }
            set { _estado = value; OnPropertyChanged(); } // <-- Cuando esto cambie, avisará a la grilla
        }

        public DateTime FechaVencimiento
        {
            get { return _fechaVencimiento; }
            set { _fechaVencimiento = value; OnPropertyChanged(); }
        }

        public DateTime? FechaDePago
        {
            get { return _fechaDePago; }
            set { _fechaDePago = value; OnPropertyChanged(); } // <-- Y cuando esto cambie, también
        }

        public Cuota()
        {
            Estado = EstadoCuota.Pendiente;
        }

        // --- LÓGICA DE NOTIFICACIÓN ---
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}