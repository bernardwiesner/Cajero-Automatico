using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.eng
{
    public partial class Recibo_retiro_eng : Form
    {
        public Recibo_retiro_eng()
        {
            InitializeComponent();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            TomeDinero_eng dinero = new TomeDinero_eng();
            dinero.Show();
            this.Hide();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            TomeDinero_eng dinero = new TomeDinero_eng();
            dinero.Show();
            this.Hide();
        }
    }
}
