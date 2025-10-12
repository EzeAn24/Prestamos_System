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
    public partial class ReportesForm : Form
    {
        public ReportesForm(decimal capitalActivo, decimal gananciasHistoricas)
        {
            InitializeComponent();

            // Usamos el formato "C2" para mostrar los valores como moneda.
            capitalActivoLabel.Text = capitalActivo.ToString("C2");
            gananciasLabel.Text = gananciasHistoricas.ToString("C2");
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
