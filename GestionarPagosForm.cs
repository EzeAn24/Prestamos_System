using System;
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

        private void ActualizarGrillaCuotas()
        {
         //Asignamos la lista de cuotas del préstamo a nuestra grilla.
            cuotasDataGridView.DataSource = null;
            cuotasDataGridView.DataSource = _prestamoActual.PlanDePagos;
        }

        

        // --- EVENTO CLICK DEL BOTÓN "PAGAR CUOTA" ---
        private void pagarCuotaBtn_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que haya una fila seleccionada.
            if (cuotasDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una cuota para pagar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtenemos el objeto 'Cuota' completo de la fila seleccionada.
            Cuota cuotaSeleccionada = cuotasDataGridView.CurrentRow.DataBoundItem as Cuota;

            // 3. Verificamos si la cuota ya está pagada.
            if (cuotaSeleccionada.Estado == EstadoCuota.Pagada)
            {
                MessageBox.Show("Esta cuota ya ha sido pagada.", "Operación no válida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 4. Pedimos confirmación al usuario.
            string mensaje = $"¿Confirma el pago de la cuota N° {cuotaSeleccionada.NumeroCuota} por un monto de ${cuotaSeleccionada.Monto:N2}?";
            DialogResult confirmacion = MessageBox.Show(mensaje, "Confirmar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // 5. Actualizamos el estado y la fecha de pago.
                cuotaSeleccionada.Estado = EstadoCuota.Pagada;
                cuotaSeleccionada.FechaDePago = DateTime.Now;

                // 6. ¡LÍNEA ELIMINADA! Ya no es necesaria.
                // cuotasDataGridView.Refresh(); 

                MessageBox.Show("¡Pago registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}