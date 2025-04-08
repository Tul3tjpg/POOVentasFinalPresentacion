namespace POOVentasFinal
{
    partial class FrmVenta
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
            label1 = new Label();
            label2 = new Label();
            TxtDescripcion = new TextBox();
            TxtCantidad = new TextBox();
            DgvConceptos = new DataGridView();
            label3 = new Label();
            TxtValorUnitario = new TextBox();
            BtnAgregar = new Button();
            TxtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvConceptos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 189);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Cantidad:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripción:";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(175, 28);
            TxtDescripcion.Margin = new Padding(4);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(764, 114);
            TxtDescripcion.TabIndex = 2;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(476, 191);
            TxtCantidad.Margin = new Padding(4);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(155, 31);
            TxtCantidad.TabIndex = 3;
            // 
            // DgvConceptos
            // 
            DgvConceptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConceptos.Location = new Point(41, 338);
            DgvConceptos.Margin = new Padding(4);
            DgvConceptos.Name = "DgvConceptos";
            DgvConceptos.RowHeadersWidth = 51;
            DgvConceptos.Size = new Size(1246, 399);
            DgvConceptos.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 189);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 0;
            label3.Text = "Valor unitario:";
            label3.Click += label1_Click;
            // 
            // TxtValorUnitario
            // 
            TxtValorUnitario.Location = new Point(175, 191);
            TxtValorUnitario.Margin = new Padding(4);
            TxtValorUnitario.Name = "TxtValorUnitario";
            TxtValorUnitario.Size = new Size(155, 31);
            TxtValorUnitario.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(822, 191);
            BtnAgregar.Margin = new Padding(4);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(118, 36);
            BtnAgregar.TabIndex = 5;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(962, 764);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(185, 31);
            TxtTotal.TabIndex = 6;
            TxtTotal.Text = "0.00";
            TxtTotal.TextAlign = HorizontalAlignment.Right;
            TxtTotal.TextChanged += TxtTotal_TextChanged;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 810);
            Controls.Add(TxtTotal);
            Controls.Add(BtnAgregar);
            Controls.Add(DgvConceptos);
            Controls.Add(TxtValorUnitario);
            Controls.Add(TxtCantidad);
            Controls.Add(TxtDescripcion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "FrmVenta";
            Text = "FrmVenta";
            ((System.ComponentModel.ISupportInitialize)DgvConceptos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtDescripcion;
        private TextBox TxtCantidad;
        private DataGridView DgvConceptos;
        private Label label3;
        private TextBox TxtValorUnitario;
        private Button BtnAgregar;
        private TextBox TxtTotal;
    }
}