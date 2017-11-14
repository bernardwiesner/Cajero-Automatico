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
    public partial class MainFrame_eng : Form
    {
        public MainFrame_eng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recibo_eng recibo = new Recibo_eng();
            recibo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            RetiroEfectivo_eng retiro = new RetiroEfectivo_eng();
            retiro.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            string path = @"..\..\Datos.json";
            string json = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(json))
            {
                JsonConvert.PopulateObject(json, datos);
            }
            if (datos.Monto - 1000 < 0)
            {
                FaltanFondos_eng faltan = new FaltanFondos_eng();
                faltan.Show();
                this.Hide();
            }
            else
            {
                datos.Monto -= 1000;
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
