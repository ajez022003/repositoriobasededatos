namespace CrudDefensa.Clases
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnTipoProducto = new System.Windows.Forms.Button();
            this.btnTienda = new System.Windows.Forms.Button();
            this.proveedor = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.marca = new System.Windows.Forms.Button();
            this.Inventario = new System.Windows.Forms.Button();
            this.Empleados = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conexion Base de datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.conexion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnUbicacion);
            this.groupBox1.Controls.Add(this.btnTipoProducto);
            this.groupBox1.Controls.Add(this.btnTienda);
            this.groupBox1.Controls.Add(this.proveedor);
            this.groupBox1.Controls.Add(this.Producto);
            this.groupBox1.Controls.Add(this.marca);
            this.groupBox1.Controls.Add(this.Inventario);
            this.groupBox1.Controls.Add(this.Empleados);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(93, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Location = new System.Drawing.Point(23, 140);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(75, 23);
            this.btnUbicacion.TabIndex = 11;
            this.btnUbicacion.Text = "Ubicacion";
            this.btnUbicacion.UseVisualStyleBackColor = true;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // btnTipoProducto
            // 
            this.btnTipoProducto.Location = new System.Drawing.Point(330, 98);
            this.btnTipoProducto.Name = "btnTipoProducto";
            this.btnTipoProducto.Size = new System.Drawing.Size(110, 23);
            this.btnTipoProducto.TabIndex = 10;
            this.btnTipoProducto.Text = "Tipo producto";
            this.btnTipoProducto.UseVisualStyleBackColor = true;
            this.btnTipoProducto.Click += new System.EventHandler(this.btnTipoProducto_Click);
            // 
            // btnTienda
            // 
            this.btnTienda.Location = new System.Drawing.Point(230, 98);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(75, 23);
            this.btnTienda.TabIndex = 9;
            this.btnTienda.Text = "Tienda";
            this.btnTienda.UseVisualStyleBackColor = true;
            this.btnTienda.Click += new System.EventHandler(this.btnTienda_Click);
            // 
            // proveedor
            // 
            this.proveedor.Location = new System.Drawing.Point(128, 98);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(75, 23);
            this.proveedor.TabIndex = 8;
            this.proveedor.Text = "proveedor";
            this.proveedor.UseVisualStyleBackColor = true;
            this.proveedor.Click += new System.EventHandler(this.proveedor_Click);
            // 
            // Producto
            // 
            this.Producto.Location = new System.Drawing.Point(23, 98);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(75, 23);
            this.Producto.TabIndex = 7;
            this.Producto.Text = "Producto";
            this.Producto.UseVisualStyleBackColor = true;
            this.Producto.Click += new System.EventHandler(this.Producto_Click);
            // 
            // marca
            // 
            this.marca.Location = new System.Drawing.Point(230, 140);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(75, 23);
            this.marca.TabIndex = 6;
            this.marca.Text = "Marca";
            this.marca.UseVisualStyleBackColor = true;
            this.marca.Click += new System.EventHandler(this.marca_Click);
            // 
            // Inventario
            // 
            this.Inventario.Location = new System.Drawing.Point(230, 57);
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(75, 23);
            this.Inventario.TabIndex = 5;
            this.Inventario.Text = "Inventario";
            this.Inventario.UseVisualStyleBackColor = true;
            this.Inventario.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // Empleados
            // 
            this.Empleados.Location = new System.Drawing.Point(128, 57);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(75, 23);
            this.Empleados.TabIndex = 4;
            this.Empleados.Text = "Empleados";
            this.Empleados.UseVisualStyleBackColor = true;
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(23, 57);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "boton";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "factura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(453, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "detalle factura";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(330, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Producto vendedor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(337, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "tipo empleado";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Button btnTipoProducto;
        private System.Windows.Forms.Button btnTienda;
        private System.Windows.Forms.Button proveedor;
        private System.Windows.Forms.Button Producto;
        private System.Windows.Forms.Button marca;
        private System.Windows.Forms.Button Inventario;
        private System.Windows.Forms.Button Empleados;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}