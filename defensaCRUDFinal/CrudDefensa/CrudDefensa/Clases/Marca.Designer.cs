namespace CrudDefensa.Clases
{
    partial class Marca
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
            this.bdMarca = new System.Windows.Forms.DataGridView();
            this.DatosMarca = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textidmarca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdMarca)).BeginInit();
            this.DatosMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdMarca
            // 
            this.bdMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdMarca.Location = new System.Drawing.Point(391, 76);
            this.bdMarca.Margin = new System.Windows.Forms.Padding(2);
            this.bdMarca.Name = "bdMarca";
            this.bdMarca.RowHeadersWidth = 51;
            this.bdMarca.RowTemplate.Height = 24;
            this.bdMarca.Size = new System.Drawing.Size(368, 300);
            this.bdMarca.TabIndex = 3;
            // 
            // DatosMarca
            // 
            this.DatosMarca.Controls.Add(this.btnEliminar);
            this.DatosMarca.Controls.Add(this.btnModificar);
            this.DatosMarca.Controls.Add(this.btnGuardar);
            this.DatosMarca.Controls.Add(this.textnombre);
            this.DatosMarca.Controls.Add(this.textidmarca);
            this.DatosMarca.Controls.Add(this.label6);
            this.DatosMarca.Controls.Add(this.label2);
            this.DatosMarca.Controls.Add(this.label1);
            this.DatosMarca.Location = new System.Drawing.Point(42, 75);
            this.DatosMarca.Margin = new System.Windows.Forms.Padding(2);
            this.DatosMarca.Name = "DatosMarca";
            this.DatosMarca.Padding = new System.Windows.Forms.Padding(2);
            this.DatosMarca.Size = new System.Drawing.Size(314, 256);
            this.DatosMarca.TabIndex = 2;
            this.DatosMarca.TabStop = false;
            this.DatosMarca.Text = "Datos marca";
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
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(200, 43);
            this.textnombre.Margin = new System.Windows.Forms.Padding(2);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(93, 20);
            this.textnombre.TabIndex = 7;
            // 
            // textidmarca
            // 
            this.textidmarca.Location = new System.Drawing.Point(200, 15);
            this.textidmarca.Margin = new System.Windows.Forms.Padding(2);
            this.textidmarca.Name = "textidmarca";
            this.textidmarca.Size = new System.Drawing.Size(93, 20);
            this.textidmarca.TabIndex = 6;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Marca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bdMarca);
            this.Controls.Add(this.DatosMarca);
            this.Name = "Marca";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.bdMarca)).EndInit();
            this.DatosMarca.ResumeLayout(false);
            this.DatosMarca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bdMarca;
        private System.Windows.Forms.GroupBox DatosMarca;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textidmarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}