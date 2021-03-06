﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            
            Datos datos = new Datos();
            string path = @"..\..\Datos.json";
            string json = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(json))
            {
                JsonConvert.PopulateObject(json, datos);
            }
            datos.Nombre = Nombre.Text;
            datos.Apellido = Apellido.Text;
            datos.Pin = Clave.Text;
            
            datos.Monto = Decimal.Parse(Monto.Text);

            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, datos);
            }

            MessageBox.Show("Datos Actualizados");
        }

        private void Config_Load(object sender, EventArgs e)
        {

        }
    }
}
