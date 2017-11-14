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

namespace CajeroAutomatico.eng
{
    public partial class RetiroEfectivo_eng : Form
    {
        public RetiroEfectivo_eng()
        {
            InitializeComponent();
        }

        private void button2000_Click(object sender, EventArgs e)
        {
            withdraw(2000);
        }

        private void button1000_Click(object sender, EventArgs e)
        {
            withdraw(1000);

        }

        private void button500_Click(object sender, EventArgs e)
        {
            withdraw(500);
        }

        private void button300_Click(object sender, EventArgs e)
        {
            withdraw(300);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            withdraw(100);
        }

        private void buttonOtro_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFrame_eng frame = new MainFrame_eng();
            frame.Show();
            this.Hide();
        }

        private void withdraw(int amount)
        {
            Datos datos = new Datos();
            string path = @"..\..\Datos.json";
            string json = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(json))
            {
                JsonConvert.PopulateObject(json, datos);
            }
            if (datos.Monto - amount < 0)
            {
                FaltanFondos_eng faltan = new FaltanFondos_eng();
                faltan.Show();
                this.Hide();
            }
            else
            {
                datos.Monto -= amount;
                using (StreamWriter file = File.CreateText(path))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, datos);
                }
                Recibo_retiro_eng retiro = new Recibo_retiro_eng();
                retiro.Show();
                this.Hide();
            }
        }
    }
}
