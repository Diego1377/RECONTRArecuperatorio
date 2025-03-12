namespace AgenciaDeCambioPOO.Windows
{
    partial class frmCompraDivisa
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            gbPrestamo = new GroupBox();
            nudCantidad = new NumericUpDown();
            cboDivisas = new ComboBox();
            txtCotizacion = new TextBox();
            txtTotal = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtFechaOperacion = new TextBox();
            label5 = new Label();
            label9 = new Label();
            label4 = new Label();
            btnCancelar = new Button();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            gbPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // gbPrestamo
            // 
            gbPrestamo.Controls.Add(nudCantidad);
            gbPrestamo.Controls.Add(cboDivisas);
            gbPrestamo.Controls.Add(txtCotizacion);
            gbPrestamo.Controls.Add(txtTotal);
            gbPrestamo.Controls.Add(label8);
            gbPrestamo.Controls.Add(label7);
            gbPrestamo.Controls.Add(txtFechaOperacion);
            gbPrestamo.Controls.Add(label5);
            gbPrestamo.Controls.Add(label9);
            gbPrestamo.Controls.Add(label4);
            gbPrestamo.Location = new Point(28, 30);
            gbPrestamo.Name = "gbPrestamo";
            gbPrestamo.Size = new Size(399, 166);
            gbPrestamo.TabIndex = 4;
            gbPrestamo.TabStop = false;
            gbPrestamo.Text = " Detalle Operación ";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(86, 87);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(93, 23);
            nudCantidad.TabIndex = 9;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboDivisas
            // 
            cboDivisas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDivisas.FormattingEnabled = true;
            cboDivisas.Location = new Point(85, 52);
            cboDivisas.Name = "cboDivisas";
            cboDivisas.Size = new Size(190, 23);
            cboDivisas.TabIndex = 7;
            // 
            // txtCotizacion
            // 
            txtCotizacion.Location = new Point(85, 125);
            txtCotizacion.Name = "txtCotizacion";
            txtCotizacion.ReadOnly = true;
            txtCotizacion.Size = new Size(94, 23);
            txtCotizacion.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(270, 125);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(108, 23);
            txtTotal.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 128);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 3;
            label8.Text = "Cotización:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(205, 128);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 3;
            label7.Text = "Total ARS:";
            // 
            // txtFechaOperacion
            // 
            txtFechaOperacion.Location = new Point(83, 18);
            txtFechaOperacion.Name = "txtFechaOperacion";
            txtFechaOperacion.Size = new Size(96, 23);
            txtFechaOperacion.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 89);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 3;
            label5.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 55);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 0;
            label9.Text = "Divisa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 21);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 0;
            label4.Text = "Fecha:";
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_24px;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(310, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 47);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.ImageAlign = ContentAlignment.TopCenter;
            btnOK.Location = new Point(81, 215);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 47);
            btnOK.TabIndex = 16;
            btnOK.Text = "OK";
            btnOK.TextAlign = ContentAlignment.BottomCenter;
            btnOK.UseVisualStyleBackColor = true;
            // 
            // frmCompraDivisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 283);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(gbPrestamo);
            MaximumSize = new Size(485, 322);
            MinimumSize = new Size(485, 322);
            Name = "frmCompraDivisa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compra de Divisas";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            gbPrestamo.ResumeLayout(false);
            gbPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private GroupBox gbPrestamo;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txtTotal;
        private TextBox txtFechaOperacion;
        private ComboBox cboDivisas;
        private Label label9;
        private Button btnCancelar;
        private Button btnOK;
        private TextBox txtCotizacion;
        private Label label8;
        private NumericUpDown nudCantidad;
    }
}