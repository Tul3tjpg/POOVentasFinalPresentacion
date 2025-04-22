namespace POOVentasFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnVentaCredito = new Button();
            BtnVentaContado = new Button();
            SuspendLayout();
            // 
            // BtnVentaCredito
            // 
            BtnVentaCredito.BackColor = SystemColors.Menu;
            BtnVentaCredito.Image = (Image)resources.GetObject("BtnVentaCredito.Image");
            BtnVentaCredito.Location = new Point(549, 172);
            BtnVentaCredito.Margin = new Padding(4);
            BtnVentaCredito.Name = "BtnVentaCredito";
            BtnVentaCredito.Size = new Size(218, 205);
            BtnVentaCredito.TabIndex = 0;
            BtnVentaCredito.UseVisualStyleBackColor = false;
            BtnVentaCredito.Click += BtnVentaCredito_Click;
            // 
            // BtnVentaContado
            // 
            BtnVentaContado.BackColor = SystemColors.Menu;
            BtnVentaContado.Image = (Image)resources.GetObject("BtnVentaContado.Image");
            BtnVentaContado.Location = new Point(205, 172);
            BtnVentaContado.Margin = new Padding(4);
            BtnVentaContado.Name = "BtnVentaContado";
            BtnVentaContado.Size = new Size(223, 205);
            BtnVentaContado.TabIndex = 0;
            BtnVentaContado.UseVisualStyleBackColor = false;
            BtnVentaContado.Click += BtnVentaContado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(BtnVentaContado);
            Controls.Add(BtnVentaCredito);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnVentaCredito;
        private Button BtnVentaContado;
    }
}
