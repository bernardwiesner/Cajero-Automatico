namespace CajeroAutomatico
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.numberPad1 = new CajeroAutomatico.NumberPad();
            this.SuspendLayout();
            // 
            // textBoxPin
            // 
            this.textBoxPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPin.Location = new System.Drawing.Point(189, 236);
            this.textBoxPin.MaxLength = 4;
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.PasswordChar = '*';
            this.textBoxPin.Size = new System.Drawing.Size(164, 44);
            this.textBoxPin.TabIndex = 1;
            this.textBoxPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberPad1
            // 
            this.numberPad1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("numberPad1.BackgroundImage")));
            this.numberPad1.Location = new System.Drawing.Point(-11, 330);
            this.numberPad1.Name = "numberPad1";
            this.numberPad1.Size = new System.Drawing.Size(598, 212);
            this.numberPad1.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CajeroAutomatico.Properties.Resources.Banco_Delta_login_esp;
            this.ClientSize = new System.Drawing.Size(544, 541);
            this.Controls.Add(this.numberPad1);
            this.Controls.Add(this.textBoxPin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxPin;
        private NumberPad numberPad1;
    }
}