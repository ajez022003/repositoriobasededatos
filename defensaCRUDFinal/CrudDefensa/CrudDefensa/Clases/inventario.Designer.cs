namespace CrudDefensa.Clases
{
    partial class inventario
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
            this.bdinventario = new System.Windows.Forms.DataGridView();
            this.DatosInventario = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textidinventario = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textIdProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventario)).BeginInit();
            this.DatosInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdinventario
            // 
            this.bdinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdinventario.Location = new System.Drawing.Point(391, 76);
            this.bdinventario.Margin = new System.Windows.Forms.Padding(2);
            this.bdinventario.Name = "bdinventario";
            this.bdinventario.RowHeadersWidth = 51;
            this.bdinventario.RowTemplate.Height = 24;
            this.bdinventario.Size = new System.Drawing.Size(368, 300);
            this.bdinventario.TabIndex = 3;
            // 
            // DatosInventario
            // 
            this.DatosInventario.Controls.Add(this.btnEliminar);
            this.DatosInventario.Controls.Add(this.btnModificar);
            this.DatosInventario.Controls.Add(this.btnGuardar);
            this.DatosInventario.Controls.Add(this.textidinventario);
            this.DatosInventario.Controls.Add(this.textStock);
            this.DatosInventario.Controls.Add(this.textIdProducto);
            this.DatosInventario.Controls.Add(this.label6);
            this.DatosInventario.Controls.Add(this.label5);
            this.DatosInventario.Controls.Add(this.label4);
            this.DatosInventario.Controls.Add(this.label3);
            this.DatosInventario.Location = new System.Drawing.Point(42, 75);
            this.DatosInventario.Margin = new System.Windows.Forms.Padding(2);
            this.DatosInventario.Name = "DatosInventario";
            this.DatosInventario.Padding = new System.Windows.Forms.Padding(2);
            this.DatosInventario.Size = new System.Drawing.Size(314, 256);
            this.DatosInventario.TabIndex = 2;
            this.DatosInventario.TabStop = false;
            this.DatosInventario.Text = "Datos Inventario";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(100, 206);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(66, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(14, 206);
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
            this.btnGuardar.Location = new System.Drawing.Point(188, 206);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textIdProducto
            // 
            this.textIdProducto.Location = new System.Drawing.Point(200, 135);
            this.textIdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.textIdProducto.Name = "textidinventario";
            this.textIdProducto.Size = new System.Drawing.Size(93, 20);
            this.textIdProducto.TabIndex = 10;
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(200, 106);
            this.textStock.Margin = new System.Windows.Forms.Padding(2);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(93, 20);
            this.textStock.TabIndex = 9;
            // 
            // textidinventario
            // 
            this.textidinventario.Location = new System.Drawing.Point(200, 74);
            this.textidinventario.Margin = new System.Windows.Forms.Padding(2);
            this.textidinventario.Name = "textIdProducto";
            this.textidinventario.Size = new System.Drawing.Size(93, 20);
            this.textidinventario.TabIndex = 8;
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
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Inventario";
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bdinventario);
            this.Controls.Add(this.DatosInventario);
            this.Name = "inventario";
            this.Text = "Datos Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.bdinventario)).EndInit();
            this.DatosInventario.ResumeLayout(false);
            this.DatosInventario.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView bdinventario;
        private System.Windows.Forms.GroupBox DatosInventario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textIdProducto;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textidinventario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        }
}