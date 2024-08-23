namespace CrudDefensa.Clases
{
    partial class factura
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
            this.bdfactura = new System.Windows.Forms.DataGridView();
            this.DatosFactura = new System.Windows.Forms.GroupBox();
            this.textIdCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textIdFactura = new System.Windows.Forms.TextBox();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.textSubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdfactura)).BeginInit();
            this.DatosFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdfactura
            // 
            this.bdfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdfactura.Location = new System.Drawing.Point(580, 68);
            this.bdfactura.Name = "bdfactura";
            this.bdfactura.Size = new System.Drawing.Size(325, 284);
            this.bdfactura.TabIndex = 7;
            // 
            // DatosFactura
            // 
            this.DatosFactura.Controls.Add(this.textIdCliente);
            this.DatosFactura.Controls.Add(this.label9);
            this.DatosFactura.Controls.Add(this.btnModificar);
            this.DatosFactura.Controls.Add(this.btnGuardar);
            this.DatosFactura.Controls.Add(this.textIdFactura);
            this.DatosFactura.Controls.Add(this.textFecha);
            this.DatosFactura.Controls.Add(this.textSubTotal);
            this.DatosFactura.Controls.Add(this.label6);
            this.DatosFactura.Controls.Add(this.label3);
            this.DatosFactura.Controls.Add(this.label2);
            this.DatosFactura.Controls.Add(this.label1);
            this.DatosFactura.Location = new System.Drawing.Point(49, 50);
            this.DatosFactura.Margin = new System.Windows.Forms.Padding(2);
            this.DatosFactura.Name = "DatosFactura";
            this.DatosFactura.Padding = new System.Windows.Forms.Padding(2);
            this.DatosFactura.Size = new System.Drawing.Size(433, 346);
            this.DatosFactura.TabIndex = 6;
            this.DatosFactura.TabStop = false;
            this.DatosFactura.Text = "Datos Factura";
            // 
            // textIdCliente
            // 
            this.textIdCliente.Location = new System.Drawing.Point(113, 171);
            this.textIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textIdCliente.Name = "textIdCliente";
            this.textIdCliente.Size = new System.Drawing.Size(93, 20);
            this.textIdCliente.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Id Cliente";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(307, 36);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(68, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(283, 160);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textIdFactura
            // 
            this.textIdFactura.Location = new System.Drawing.Point(111, 18); 
            this.textIdFactura.Margin = new System.Windows.Forms.Padding(2);
            this.textIdFactura.Name = "textIdFactura";
            this.textIdFactura.Size = new System.Drawing.Size(93, 20);
            this.textIdFactura.TabIndex = 10;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(111, 50); 
            this.textFecha.Margin = new System.Windows.Forms.Padding(2);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(93, 20);
            this.textFecha.TabIndex = 9;
            // 
            // textSubTotal
            // 
            this.textSubTotal.Location = new System.Drawing.Point(111, 74);
            this.textSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.textSubTotal.Name = "textSubTotal";
            this.textSubTotal.Size = new System.Drawing.Size(93, 20);
            this.textSubTotal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            
            // 
            // label4
            // 
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SubTotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id factura";
            // 
            // factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.bdfactura);
            this.Controls.Add(this.DatosFactura);
            this.Name = "factura";
            this.Text = "factura";
            ((System.ComponentModel.ISupportInitialize)(this.bdfactura)).EndInit();
            this.DatosFactura.ResumeLayout(false);
            this.DatosFactura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bdfactura;
        private System.Windows.Forms.GroupBox DatosFactura;
        private System.Windows.Forms.TextBox textIdCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textIdFactura;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.TextBox textSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}