using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.esp
{
    public partial class Recibo_retiro : Form
    {
        public Recibo_retiro()
        {
            InitializeComponent();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            TomeDinero dinero = new TomeDinero();
            dinero.Show();
            this.Hide();
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            TomeDinero dinero = new TomeDinero();
            dinero.Show();
            this.Hide();
        }
    }
}
