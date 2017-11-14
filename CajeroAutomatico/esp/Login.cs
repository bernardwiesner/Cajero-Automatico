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
    public partial class Login : Form
    {
        public Login()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            //NumPad embeddedForm = new NumPad(textBoxPin);
            //embeddedForm.TopLevel = false;
            //embeddedForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //Controls.Add(embeddedForm);
            //embeddedForm.Show();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MainFrame m = new MainFrame();
            m.Show();
        }
    }
}
