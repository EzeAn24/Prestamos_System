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
    public partial class AgregarCliente : Form
    {
        // --- NUEVO: PROPIEDAD PÚBLICA ---
        // Esta propiedad guardará el nuevo cliente para que el formulario principal
        // pueda acceder a él después de que esta ventana se cierre.
        public Persona NuevoCliente { get; private set; }

        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agregarClienteBtn_Click(object sender, EventArgs e)
        {
            // Validamos que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor, complete el nombre y el apellido.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detenemos la ejecución si faltan datos
            }

            string nombre = textBox1.Text;
            string apellido = textBox2.Text;

            // Creamos el cliente y lo asignamos a nuestra propiedad pública
            this.NuevoCliente = new Persona(nombre, apellido);

            // --- CAMBIO IMPORTANTE ---
            // Le decimos al formulario que el resultado fue "OK" y esto también lo cerrará.
            this.DialogResult = DialogResult.OK;
        }
    }
}