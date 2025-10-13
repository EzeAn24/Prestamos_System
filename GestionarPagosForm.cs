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
        // --- REEMPLAZA ESTE MÉTODO EN GestionarPagosForm.cs ---
        private void pagarCuotaBtn_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que haya una fila seleccionada.
            if (cuotasDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una cuota para pagar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtenemos la cuota usando el índice de la fila, que es el método correcto para tu caso.
            int selectedIndex = cuotasDataGridView.CurrentRow.Index;
            Cuota cuotaSeleccionada = _prestamoActual.PlanDePagos[selectedIndex];

            // 3. Verificamos si ya está pagada (leyendo el estado real del objeto).
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
                // 5. Actualizamos el objeto en memoria.
                cuotaSeleccionada.Estado = EstadoCuota.Pagada;
                cuotaSeleccionada.FechaDePago = DateTime.Now;

                // 6. Guardamos el cambio en la base de datos.
                DatabaseManager.UpdateCuota(cuotaSeleccionada);

                // --- LA SOLUCIÓN MÁGICA ---
                // 7. Le ordenamos directamente a la celda que actualice su valor visual.
                //    Asumimos que la columna "Estado" es la segunda (índice 1). Si la moviste, ajusta el número.
                cuotasDataGridView.CurrentRow.Cells[1].Value = "Pagada";

                // 8. Informamos al usuario.
                MessageBox.Show("¡Pago registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}