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
    public partial class BajaPrestamoForm : Form
    {
        public EstadoPrestamo MotivoBaja { get; private set; }

        public BajaPrestamoForm()
        {
            InitializeComponent();
            errorRadioButton.Checked = true;
        }

        private void BajaPrestamoForm_Load(object sender, EventArgs e)
        {

        }

        private void confirmarBajaBtn_Click(object sender, EventArgs e)
        {
            // Determinar el motivo seleccionado
            if (errorRadioButton.Checked)
            {
                MotivoBaja = EstadoPrestamo.CanceladoError;
            }
            else if (deudorRadioButton.Checked)
            {
                MotivoBaja = EstadoPrestamo.CanceladoDeudor;
            }

            // Confirmar antes de cerrar
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea dar de baja este préstamo?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK; // Indicar que se confirmó
            }
            // Si dice No, simplemente no se cierra
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Indicar que se canceló
        }
    }
}
