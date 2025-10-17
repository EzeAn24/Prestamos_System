using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Préstamo_System : Form
    {
        // Esta lista ahora actúa como un "caché" en memoria de los datos de la base de datos.
        private List<Persona> listaDeClientes = new List<Persona>();

        // --- CONSTRUCTOR ---
        public Préstamo_System()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            tipoCuotaComboBox.DataSource = Enum.GetValues(typeof(TipoDeCuota));

            // Al iniciar el programa, llamamos a nuestro método centralizado 
            // para cargar toda la información desde la base de datos.
            CargarDatosCompletosDesdeDB();
        }

        // --- MÉTODO CENTRALIZADO PARA CARGAR Y REFESCAR DATOS ---
        private void CargarDatosCompletosDesdeDB()
        {
            // 1. Cargamos todas las listas desde la base de datos.
            listaDeClientes = DatabaseManager.GetPersonas();
            List<Prestamo> todosLosPrestamos = DatabaseManager.GetPrestamos();
            List<Cuota> todasLasCuotas = DatabaseManager.GetCuotas();

            // 2. "Armamos el rompecabezas" en memoria para conectar los objetos.
            foreach (var prestamo in todosLosPrestamos)
            {
                prestamo.PlanDePagos = new BindingList<Cuota>(todasLasCuotas.Where(c => c.PrestamoId == prestamo.Id).ToList());
                prestamo.Cliente = listaDeClientes.FirstOrDefault(p => p.Id == prestamo.PersonaId);
            }

            foreach (var cliente in listaDeClientes)
            {
                cliente.Prestamos = todosLosPrestamos.Where(p => p.PersonaId == cliente.Id).ToList();
            }

            // 3. Actualizamos los controles de la interfaz con los datos frescos.
            ActualizarComboBoxClientes();
            ActualizarGrillaPrestamos();
        }

        // --- MÉTODOS DE ACTUALIZACIÓN DE UI (Sin cambios) ---
        private void ActualizarComboBoxClientes()
        {
            // Guardamos el cliente seleccionado actualmente para no perder la selección.
            object clienteSeleccionado = comboBox1.SelectedItem;

            comboBox1.DataSource = null;
            comboBox1.DataSource = listaDeClientes;

            // Si había un cliente seleccionado, intentamos volver a seleccionarlo.
            if (clienteSeleccionado != null && listaDeClientes.Contains(clienteSeleccionado))
            {
                comboBox1.SelectedItem = clienteSeleccionado;
            }
            else
            {
                comboBox1.Text = "Seleccione un cliente...";
            }
        }

        private void ActualizarGrillaPrestamos()
        {
            var todosLosPrestamos = listaDeClientes.SelectMany(cliente => cliente.Prestamos).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = todosLosPrestamos;
        }

        // --- EVENTOS DE BOTONES ---
        private void agregarClienteBtn_Click(object sender, EventArgs e)
        {
            AgregarCliente agregarClienteForm = new AgregarCliente();
            if (agregarClienteForm.ShowDialog() == DialogResult.OK)
            {
                Persona clienteAgregado = agregarClienteForm.NuevoCliente;

                // 1. Guardamos el nuevo cliente en la base de datos.
                DatabaseManager.SavePersona(clienteAgregado);

                // 2. Recargamos TODA la información para refrescar la pantalla y obtener el nuevo ID.
                CargarDatosCompletosDesdeDB();
            }
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            // --- PASO 1: VALIDACIÓN DE DATOS ---
            Persona clienteSeleccionado = comboBox1.SelectedItem as Persona;
            if (clienteSeleccionado == null) { MessageBox.Show("Por favor, seleccione un cliente de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!decimal.TryParse(montoTextBox.Text, out decimal monto)) { MessageBox.Show("Por favor, ingrese un monto a prestar válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!int.TryParse(cuotasTextBox.Text, out int cuotas) || cuotas <= 0) { MessageBox.Show("Por favor, ingrese una cantidad de cuotas válida (número entero mayor a cero).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            DateTime fechaInicio = fechaInicioPicker.Value;
            decimal tasaInteres = numericUpDown1.Value / 100;
            TipoDeCuota tipoCuotaSeleccionado = (TipoDeCuota)tipoCuotaComboBox.SelectedItem;

            // --- PASO 2: CONFIRMACIÓN DEL USUARIO ---
            string mensajeConfirmacion = $"¿Está seguro que desea registrar el siguiente préstamo?\n\nCliente: {clienteSeleccionado}\nMonto: {monto:C2}\nCuotas: {cuotas}\nTasa de Interés: {numericUpDown1.Value}%\nFecha de Inicio: {fechaInicio.ToShortDateString()}";
            DialogResult resultado = MessageBox.Show(mensajeConfirmacion, "Confirmar Préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No) return;

            // --- PASO 3: CREACIÓN Y REGISTRO DEL PRÉSTAMO ---
            Prestamo nuevoPrestamo = new Prestamo(monto, cuotas, fechaInicio, clienteSeleccionado, tasaInteres, tipoCuotaSeleccionado);
            nuevoPrestamo.PersonaId = clienteSeleccionado.Id;
            DatabaseManager.SavePrestamo(nuevoPrestamo);

            // --- PASO 4: FEEDBACK Y LIMPIEZA ---
            MessageBox.Show("¡Préstamo registrado con éxito!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Recargamos TODA la información para que el nuevo préstamo aparezca en la grilla.
            CargarDatosCompletosDesdeDB();

            montoTextBox.Clear();
            cuotasTextBox.Clear();
            comboBox1.Text = "Seleccione un cliente...";
            fechaInicioPicker.Value = DateTime.Now;
            numericUpDown1.Value = 0;
        }

        private void gestionarPagosBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) { MessageBox.Show("Por favor, seleccione un préstamo de la lista.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            Prestamo prestamoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Prestamo;
            GestionarPagosForm formGestion = new GestionarPagosForm(prestamoSeleccionado);
            formGestion.ShowDialog();

            // Cuando se cierra la ventana de gestión, recargamos todo por si se pagó una cuota.
            CargarDatosCompletosDesdeDB();
        }

        private void verReportesBtn_Click(object sender, EventArgs e)
        {
            var todosLosPrestamos = listaDeClientes.SelectMany(cliente => cliente.Prestamos).ToList();
            if (!todosLosPrestamos.Any()) { MessageBox.Show("No hay préstamos registrados para generar un reporte.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            decimal capitalActivo = todosLosPrestamos.Where(p => p.MontoAdeudado > 0).Sum(p => p.MontoPrestado);
            decimal gananciasHistoricas = 0;
            foreach (var prestamo in todosLosPrestamos)
            {
                if (prestamo.CantidadCuotas > 0)
                {
                    decimal interesPorCuota = (prestamo.MontoTotalConInteres - prestamo.MontoPrestado) / prestamo.CantidadCuotas;
                    int cuotasPagas = prestamo.PlanDePagos.Count(c => c.Estado == EstadoCuota.Pagada);
                    gananciasHistoricas += cuotasPagas * interesPorCuota;
                }
            }
            ReportesForm formReportes = new ReportesForm(capitalActivo, gananciasHistoricas);
            formReportes.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e) { }
    }
}