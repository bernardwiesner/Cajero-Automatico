using CajeroAutomatico.eng;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Recibo_eng : Form
    {
        public Recibo_eng()
        {
            InitializeComponent();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Balance_eng balance = new Balance_eng();
            Datos datos = new Datos();

            string path = @"..\..\Datos.json";
            string json = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(json))
            {
                JsonConvert.PopulateObject(json, datos);
            }
            balance.labelBlance.Text = datos.Monto.ToString("C");
            balance.Show();

            this.Hide();
        }
    }
}
