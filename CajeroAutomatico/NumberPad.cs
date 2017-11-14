using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using CajeroAutomatico.eng;
using CajeroAutomatico.esp;

namespace CajeroAutomatico
{
    public partial class NumberPad : UserControl
    {
        public NumberPad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
            {
                (this.Parent as Login).textBoxPin.Text += "1";
            }
            else
            {
                (this.Parent as Login_eng).textBoxPin.Text += "1";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
                (this.Parent as Login).textBoxPin.Text += "2";
            else
                (this.Parent as Login_eng).textBoxPin.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
                (this.Parent as Login).textBoxPin.Text += "3";
            else
                (this.Parent as Login_eng).textBoxPin.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
                (this.Parent as Login).textBoxPin.Text += "4";
            else
                (this.Parent as Login_eng).textBoxPin.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
                (this.Parent as Login).textBoxPin.Text += "5";
            else
                (this.Parent as Login_eng).textBoxPin.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
                (this.Parent as Login).textBoxPin.Text += "6";
            else
                (this.Parent as Login_eng).textBoxPin.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
                (this.Parent as Login).textBoxPin.Text += "7";
            else
                (this.Parent as Login_eng).textBoxPin.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
                (this.Parent as Login).textBoxPin.Text += "8";
            else
                (this.Parent as Login_eng).textBoxPin.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
                (this.Parent as Login).textBoxPin.Text += "9";
            else
                (this.Parent as Login_eng).textBoxPin.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
                (this.Parent as Login).textBoxPin.Text += "0";
            else
                (this.Parent as Login_eng).textBoxPin.Text += "0";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
                (this.Parent as Login).Hide();
            else
                (this.Parent as Login_eng).Hide();
            Start s = new Start();
            s.Show();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string pin;
            if (this.Parent.Text.Equals("Login")) {
                pin = (this.Parent as Login).textBoxPin.Text;
            } else {
                pin = (this.Parent as Login_eng).textBoxPin.Text;
            }

            Datos datos = new Datos();

            string path = @"..\..\Datos.json";
            string json = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(json))
            {
                JsonConvert.PopulateObject(json, datos);
            }
            if (datos.Pin.Equals(pin))
            {
                if (this.Parent.Text.Equals("Login"))
                {
                    MainFrame frame = new MainFrame();
                    frame.Show();
                    (this.Parent as Login).Hide();
                }
                else
                {
                    MainFrame_eng frame = new MainFrame_eng();
                    frame.Show();
                    (this.Parent as Login_eng).Hide();
                }


            }else
            {
               
                    
                if (this.Parent.Text.Equals("Login"))
                {
                    PinIncorrecto pinmalo = new PinIncorrecto();
                    pinmalo.Show();
                    (this.Parent as Login).Hide();
                }else
                {
                    PinIncorrecto_eng pinmalo = new PinIncorrecto_eng();
                    pinmalo.Show();
                    (this.Parent as Login_eng).Hide();
                }
                    
                
                
            }
            

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (this.Parent.Text.Equals("Login"))
                (this.Parent as Login).textBoxPin.Text = "";
            else
                (this.Parent as Login_eng).textBoxPin.Text = "";
        }
    }
}
