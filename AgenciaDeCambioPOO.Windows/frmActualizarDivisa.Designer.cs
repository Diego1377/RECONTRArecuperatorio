namespace AgenciaDeCambioPOO.Windows
{
    partial class frmActualizarDivisa
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
            btnCancelar = new Button();
            btnOK = new Button();
            txtCantidad = new TextBox();
            label5 = new Label();
            txtVenta = new TextBox();
            label4 = new Label();
            txtCompra = new TextBox();
            label3 = new Label();
            txtAbreviatura = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cboDivisas = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            txtDivisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_24px;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(263, 195);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 47);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.ImageAlign = ContentAlignment.TopCenter;
            btnOK.Location = new Point(35, 195);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 47);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.TextAlign = ContentAlignment.BottomCenter;
            btnOK.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(110, 148);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(71, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 151);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 3;
            label5.Text = "Cantidad:";
            // 
            // txtVenta
            // 
            txtVenta.Location = new Point(110, 119);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(71, 23);
            txtVenta.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 122);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Venta:";
            // 
            // txtCompra
            // 
            txtCompra.Location = new Point(110, 90);
            txtCompra.Name = "txtCompra";
            txtCompra.Size = new Size(71, 23);
            txtCompra.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 93);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Compra:";
            // 
            // txtAbreviatura
            // 
            txtAbreviatura.Location = new Point(110, 61);
            txtAbreviatura.Name = "txtAbreviatura";
            txtAbreviatura.ReadOnly = true;
            txtAbreviatura.Size = new Size(71, 23);
            txtAbreviatura.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 64);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 6;
            label2.Text = "Abreviatura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 35);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 7;
            label1.Text = "Divisa:";
            // 
            // cboDivisas
            // 
            cboDivisas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDivisas.FormattingEnabled = true;
            cboDivisas.Location = new Point(110, 32);
            cboDivisas.Name = "cboDivisas";
            cboDivisas.Size = new Size(196, 23);
            cboDivisas.TabIndex = 15;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtDivisa
            // 
            txtDivisa.Enabled = false;
            txtDivisa.Location = new Point(110, 32);
            txtDivisa.Name = "txtDivisa";
            txtDivisa.ReadOnly = true;
            txtDivisa.Size = new Size(196, 23);
            txtDivisa.TabIndex = 16;
            txtDivisa.Visible = false;
            // 
            // frmActualizarDivisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 261);
            Controls.Add(txtDivisa);
            Controls.Add(cboDivisas);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtCantidad);
            Controls.Add(label5);
            Controls.Add(txtVenta);
            Controls.Add(label4);
            Controls.Add(txtCompra);
            Controls.Add(label3);
            Controls.Add(txtAbreviatura);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmActualizarDivisa";
            Text = "frnActualizarDivisa";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOK;
        private TextBox txtCantidad;
        private Label label5;
        private TextBox txtVenta;
        private Label label4;
        private TextBox txtCompra;
        private Label label3;
        private TextBox txtAbreviatura;
        private Label label2;
        private Label label1;
        private ComboBox cboDivisas;
        private ErrorProvider errorProvider1;
        private TextBox txtDivisa;
    }
}