using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GestionarPagosForm : Form
    {
        // Guardaremos una referencia al préstamo que estamos gestionando.
        private Prestamo _prestamoActual;

        // --- CONSTRUCTOR MODIFICADO ---
        // Hacemos que el formulario OBLIGATORIAMENTE reciba un préstamo al ser creado.
        public GestionarPagosForm(Prestamo prestamoSeleccionado)
        {
            InitializeComponent();

            cuotasDataGridView.AutoGenerateColumns = false;
            // Guardamos el préstamo que nos pasaron.
            _prestamoActual = prestamoSeleccionado;
        }

        // --- EVENTO LOAD DEL FORMULARIO ---
        // Esto se ejecuta una sola vez, justo cuando el formulario se carga.
        private void GestionarPagosForm_Load(object sender, EventArgs e)
        {
            // Ponemos el nombre del cliente en el título de la ventana.
            this.Text = $"Plan de Pagos de: {_prestamoActual.Cliente.ToString()}";

            // Llamamos al método que carga las cuotas en la grilla.
            ActualizarGrillaCuotas();
        }

        //private void ActualizarGrillaCuotas()
        //{
        //Asignamos la lista de cuotas del préstamo a nuestra grilla.
        //    cuotasDataGridView.DataSource = null;
        //    cuotasDataGridView.DataSource = _prestamoActual.PlanDePagos;
        //}

        private void ActualizarGrillaCuotas()
        {
            cuotasDataGridView.Rows.Clear();
            if (_prestamoActual.PlanDePagos == null) return;

            foreach (var cuota in _prestamoActual.PlanDePagos)
            {
                // El orden aquí debe coincidir con el orden de las columnas: N° Cuota, Estado, Vencimiento, Monto
                cuotasDataGridView.Rows.Add(
                    cuota.NumeroCuota,
                    cuota.Estado.ToString(), // Convertimos el Enum a texto
                    cuota.FechaVencimiento.ToShortDateString(), // Formateamos la fecha
                    cuota.Monto
                );
            }
        }



        // --- EVENTO CLICK DEL BOTÓN "PAGAR CUOTA" ---
        private void pagarCuotaBtn_Click(object sender, EventArgs e)
        {
            if (cuotasDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una cuota para pagar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- CAMBIO CLAVE ---
            // 1. Obtenemos el número de la cuota desde la celda 0 (la primera columna)
            int numeroCuotaSeleccionada = Convert.ToInt32(cuotasDataGridView.CurrentRow.Cells[0].Value);

            // 2. Usamos LINQ para encontrar el objeto 'Cuota' real en nuestra lista
            Cuota cuotaSeleccionada = _prestamoActual.PlanDePagos
                                        .FirstOrDefault(c => c.NumeroCuota == numeroCuotaSeleccionada);

            if (cuotaSeleccionada == null)
            {
                MessageBox.Show("Error al encontrar la cuota seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // --- FIN CAMBIO CLAVE ---

            if (cuotaSeleccionada.Estado == EstadoCuota.Pagada)
            {
                MessageBox.Show("Esta cuota ya ha sido pagada.", "Operación no válida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string mensaje = $"¿Confirma el pago de la cuota N° {cuotaSeleccionada.NumeroCuota} por un monto de ${cuotaSeleccionada.Monto:N2}?";
            DialogResult confirmacion = MessageBox.Show(mensaje, "Confirmar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                cuotaSeleccionada.Estado = EstadoCuota.Pagada;
                cuotaSeleccionada.FechaDePago = DateTime.Now;

                // Actualizamos la fila visualmente
                cuotasDataGridView.CurrentRow.Cells[1].Value = EstadoCuota.Pagada.ToString(); // Celda 'Estado'

                MessageBox.Show("¡Pago registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}