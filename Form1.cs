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
        // --- NUEVO: LISTA DE CLIENTES ---
        // Esta lista será nuestra "base de datos" temporal de clientes.
        private List<Persona> listaDeClientes = new List<Persona>();

        public Préstamo_System()
        {
            InitializeComponent();
            // Ya no necesitas la siguiente línea, la dejaremos comentada
            // comboBox1.SelectedIndex = 0; 
            dataGridView1.AutoGenerateColumns = false;
            // Sugerencia: Puedes poner un texto inicial en el ComboBox
            comboBox1.Text = "Seleccione un cliente...";
        }

        // --- NUEVO: MÉTODO PARA ACTUALIZAR EL COMBOBOX ---
        // Creamos un método para no repetir código. 
        // Su única función es refrescar los datos del ComboBox.
        private void ActualizarComboBoxClientes()
        {
            comboBox1.DataSource = null; // Limpiamos la fuente de datos anterior
            comboBox1.DataSource = listaDeClientes; // Asignamos la nueva lista actualizada
            comboBox1.Text = "Seleccione un cliente...";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void agregarClienteBtn_Click(object sender, EventArgs e)
        {
            // Creamos una instancia del formulario para agregar clientes
            AgregarCliente agregarClienteForm = new AgregarCliente();

            // --- CAMBIO IMPORTANTE ---
            // Usamos ShowDialog() para que el programa espere a que esta ventana se cierre.
            // Verificamos si el usuario presionó nuestro botón "agregar" (que devolvió DialogResult.OK)
            if (agregarClienteForm.ShowDialog() == DialogResult.OK)
            {
                // 1. Obtenemos el nuevo cliente desde la propiedad pública que creamos
                Persona clienteAgregado = agregarClienteForm.NuevoCliente;

                // 2. Lo añadimos a nuestra lista principal
                listaDeClientes.Add(clienteAgregado);

                // 3. Actualizamos el ComboBox para que muestre el nuevo cliente
                ActualizarComboBoxClientes();

                // Opcional: Seleccionamos el cliente recién agregado
                comboBox1.SelectedItem = clienteAgregado;
            }
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            // --- PASO 1: VALIDACIÓN DE DATOS ---

            // 1.1: ¿Se seleccionó un cliente?
            // El ComboBox guarda el objeto Persona completo, no solo el texto.
            Persona clienteSeleccionado = comboBox1.SelectedItem as Persona;

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución aquí
            }

            // 1.2: ¿Se ingresó un monto válido?
            // Usamos decimal.TryParse para convertir el texto a número de forma segura.
            if (!decimal.TryParse(montoTextBox.Text, out decimal monto))
            {
                MessageBox.Show("Por favor, ingrese un monto a prestar válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1.3: ¿Se ingresó una cantidad de cuotas válida?
            if (!int.TryParse(cuotasTextBox.Text, out int cuotas) || cuotas <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad de cuotas válida (número entero mayor a cero).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1.4: Obtener la fecha
            DateTime fechaInicio = fechaInicioPicker.Value;


            // --- PASO 2: CONFIRMACIÓN DEL USUARIO ---

            // Creamos un mensaje detallado para que el usuario confirme.
            string mensajeConfirmacion = $"¿Está seguro que desea registrar el siguiente préstamo?\n\n" +
                                         $"Cliente: {clienteSeleccionado.ToString()}\n" +
                                         $"Monto: ${monto:N2}\n" +
                                         $"Cuotas: {cuotas}\n" +
                                         $"Fecha de Inicio: {fechaInicio.ToShortDateString()}";

            DialogResult resultado = MessageBox.Show(mensajeConfirmacion, "Confirmar Préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario no presiona "Sí", detenemos todo.
            if (resultado == DialogResult.No)
            {
                return;
            }


            // --- PASO 3: CREACIÓN Y REGISTRO DEL PRÉSTAMO ---

            // Si llegamos aquí, todos los datos son válidos y el usuario confirmó.

            // 3.1: Creamos el nuevo objeto Prestamo con los datos del formulario.
            Prestamo nuevoPrestamo = new Prestamo(monto, cuotas, fechaInicio, clienteSeleccionado);

            // 3.2: Añadimos el préstamo a la lista de préstamos del cliente seleccionado.
            // ¡Aquí es donde ocurre la magia de la estructura que creamos!
            clienteSeleccionado.Prestamos.Add(nuevoPrestamo);


            // --- PASO 4: FEEDBACK Y LIMPIEZA ---

            // ...
            MessageBox.Show("¡Préstamo registrado con éxito!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // --- NUEVA LÍNEA ---
            ActualizarGrillaPrestamos();

            // Limpiamos los campos para el próximo registro.
            montoTextBox.Clear();
            // ... resto del código de limpieza

            // 4.2: Limpiamos los campos para el próximo registro.
            montoTextBox.Clear();
            cuotasTextBox.Clear();
            comboBox1.Text = "Seleccione un cliente...";
            fechaInicioPicker.Value = DateTime.Now; // Restablece la fecha a hoy
        }

        private void ActualizarGrillaPrestamos()
        {
            // 1. Necesitamos una única lista con TODOS los préstamos de TODOS los clientes.
            // Usamos LINQ (SelectMany) para "aplanar" la lista de listas.
            var todosLosPrestamos = listaDeClientes.SelectMany(cliente => cliente.Prestamos).ToList();

            // 2. Para evitar problemas de refresco, es buena práctica hacer esto:
            dataGridView1.DataSource = null;

            // 3. Asignamos nuestra lista de préstamos a la grilla.
            // La grilla es lo suficientemente inteligente para usar las propiedades
            // que definimos en "DataPropertyName" para llenar cada columna.
            dataGridView1.DataSource = todosLosPrestamos;
        }

        private void gestionarPagosBtn_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que haya una fila (un préstamo) seleccionada.
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un préstamo de la lista.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtenemos el objeto 'Prestamo' completo de la fila seleccionada.
            Prestamo prestamoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Prestamo;

            // 3. Creamos una instancia de nuestro nuevo formulario de gestión.
            // ¡Y le pasamos el préstamo seleccionado en su constructor!
            GestionarPagosForm formGestion = new GestionarPagosForm(prestamoSeleccionado);

            // 4. Abrimos el formulario. Usamos ShowDialog() para que el programa
            // espere aquí hasta que esta ventana se cierre.
            formGestion.ShowDialog();

            // 5. ¡PASO CLAVE! Cuando la ventana de gestión se cierra,
            // actualizamos la grilla principal porque el "Monto Adeudado" pudo haber cambiado.
            ActualizarGrillaPrestamos();
        }
    }
}