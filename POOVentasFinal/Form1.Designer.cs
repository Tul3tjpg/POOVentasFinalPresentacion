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
            BtnVentaCredito = new Button();
            BtnVentaContado = new Button();
            SuspendLayout();
            // 
            // BtnVentaCredito
            // 
            BtnVentaCredito.Location = new Point(592, 301);
            BtnVentaCredito.Margin = new Padding(4, 4, 4, 4);
            BtnVentaCredito.Name = "BtnVentaCredito";
            BtnVentaCredito.Size = new Size(155, 36);
            BtnVentaCredito.TabIndex = 0;
            BtnVentaCredito.Text = "Venta Credito";
            BtnVentaCredito.UseVisualStyleBackColor = true;
            BtnVentaCredito.Click += BtnVentaCredito_Click;
            // 
            // BtnVentaContado
            // 
            BtnVentaContado.Location = new Point(199, 301);
            BtnVentaContado.Margin = new Padding(4, 4, 4, 4);
            BtnVentaContado.Name = "BtnVentaContado";
            BtnVentaContado.Size = new Size(148, 36);
            BtnVentaContado.TabIndex = 0;
            BtnVentaContado.Text = "Venta Contado";
            BtnVentaContado.UseVisualStyleBackColor = true;
            BtnVentaContado.Click += BtnVentaContado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(BtnVentaContado);
            Controls.Add(BtnVentaCredito);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnVentaCredito;
        private Button BtnVentaContado;
    }
}
