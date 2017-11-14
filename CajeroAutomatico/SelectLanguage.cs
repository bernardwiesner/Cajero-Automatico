using CajeroAutomatico.eng;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class SelectLanguage : Form
    {
        public SelectLanguage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_eng english = new Login_eng();
            english.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login spanish = new Login();
            spanish.Show();
            this.Hide();
        }
    }
}
