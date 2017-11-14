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
    public partial class Balance_eng : Form
    {
        public Balance_eng()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            MainFrame_eng frame = new MainFrame_eng();
            frame.Show();
            this.Hide();
        }
    }
}
