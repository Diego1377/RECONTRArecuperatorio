namespace AgenciaDeCambioPOO.Windows
{
    partial class frmDivisaAE
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
            label1 = new Label();
            txtDivisa = new TextBox();
            label2 = new Label();
            txtAbreviatura = new TextBox();
            label3 = new Label();
            txtCompra = new TextBox();
            label4 = new Label();
            txtVenta = new TextBox();
            label5 = new Label();
            txtCantidad = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Divisa:";
            // 
            // txtDivisa
            // 
            txtDivisa.Location = new Point(104, 25);
            txtDivisa.Name = "txtDivisa";
            txtDivisa.Size = new Size(228, 23);
            txtDivisa.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 57);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 0;
            label2.Text = "Abreviatura:";
            // 
            // txtAbreviatura
            // 
            txtAbreviatura.Location = new Point(104, 54);
            txtAbreviatura.Name = "txtAbreviatura";
            txtAbreviatura.Size = new Size(71, 23);
            txtAbreviatura.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 86);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 0;
            label3.Text = "Compra:";
            // 
            // txtCompra
            // 
            txtCompra.Location = new Point(104, 83);
            txtCompra.Name = "txtCompra";
            txtCompra.Size = new Size(71, 23);
            txtCompra.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 115);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "Venta:";
            // 
            // txtVenta
            // 
            txtVenta.Location = new Point(104, 112);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(71, 23);
            txtVenta.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 144);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 0;
            label5.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(104, 141);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(71, 23);
            txtCantidad.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.ImageAlign = ContentAlignment.TopCenter;
            btnOK.Location = new Point(29, 188);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 47);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.TextAlign = ContentAlignment.BottomCenter;
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_24px;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(257, 188);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 47);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmDivisaAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 259);
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
            Controls.Add(txtDivisa);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmDivisaAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDivisaAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDivisa;
        private Label label2;
        private TextBox txtAbreviatura;
        private Label label3;
        private TextBox txtCompra;
        private Label label4;
        private TextBox txtVenta;
        private Label label5;
        private TextBox txtCantidad;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}