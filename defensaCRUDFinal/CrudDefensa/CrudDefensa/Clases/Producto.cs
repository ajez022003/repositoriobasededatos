using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudDefensa.Clases
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
            CargarDatosProducto();
        }
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";

        private void CargarDatosProducto()
        {
            // Cadena de conexión
            

            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM producto";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    bdProducto.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string upc = textID.Text; // UPC como texto
            int idMarca, idProveedor, cantidad, reorden;
            string nombre = textNombre.Text;
            string tamano = textTamano.Text;
            string embalaje = textEmbalaje.Text;
            string marca = textMarca.Text;
            decimal precio;

            // Validaciones
            if (string.IsNullOrEmpty(upc) || !upc.All(char.IsDigit) || upc.Length != 12)
            {
                MessageBox.Show("El campo UPC debe ser un texto de 12 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textIdMarca.Text, out idMarca))
            {
                MessageBox.Show("El campo ID Marca debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textIdProveedor.Text, out idProveedor))
            {
                MessageBox.Show("El campo ID Proveedor debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(tamano))
            {
                MessageBox.Show("El campo Tamaño no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(embalaje))
            {
                MessageBox.Show("El campo Embalaje no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(marca))
            {
                MessageBox.Show("El campo Marca no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textPrecio.Text, out precio))
            {
                MessageBox.Show("El campo Precio debe ser un número decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textCantidad.Text, out cantidad))
            {
                MessageBox.Show("El campo Cantidad debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textReorden.Text, out reorden))
            {
                MessageBox.Show("El campo Reorden debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (var cmd = new NpgsqlCommand("public.agregar_producto", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios
                        cmd.Parameters.AddWithValue("upc", upc); // UPC como string
                        cmd.Parameters.AddWithValue("id_marca", idMarca);
                        cmd.Parameters.AddWithValue("id_proveedor", idProveedor);
                        cmd.Parameters.AddWithValue("nombre", nombre);
                        cmd.Parameters.AddWithValue("tamano", tamano);
                        cmd.Parameters.AddWithValue("embalaje", embalaje);
                        cmd.Parameters.AddWithValue("marca", marca);
                        cmd.Parameters.AddWithValue("precio", precio);
                        cmd.Parameters.AddWithValue("cantidad", cantidad);
                        cmd.Parameters.AddWithValue("reorden", reorden);

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Producto agregado exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Recargar los datos en el DataGridView para reflejar los cambios
            bdProductoLoad();
        }
        private void DatosClientes_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (bdProducto.CurrentRow != null)
            {
                // Obtener el valor del UPC de la fila seleccionada
                string upc_p = bdProducto.CurrentRow.Cells["upc"].Value.ToString();

                // Confirmar la eliminación con el usuario
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new NpgsqlConnection(cadenaConexion))
                    {
                        try
                        {
                            connection.Open();

                            using (var cmd = new NpgsqlCommand("eliminar_producto", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregar el parámetro necesario para la eliminación
                                cmd.Parameters.AddWithValue("upc_p", upc_p);

                                // Ejecutar el procedimiento almacenado
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Producto eliminado exitosamente.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                        }
                    }

                    // Recargar el DataGridView para reflejar los cambios
                    bdProductoLoad();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bdProductoLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM producto", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    bdProducto.DataSource = dataTable;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTamano_TextChanged(object sender, EventArgs e)
        {

        }

        private void bdProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmbalaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIdMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textIdProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textIdproveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textReorden_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string upc_p = textID.Text;
            int idMarca, idProveedor, cantidad, reorden;
            string nombre = textNombre.Text;
            string tamano = textTamano.Text;
            string embalaje = textEmbalaje.Text;
            string marca = textMarca.Text;
            decimal precio;

            // Validaciones
            if (string.IsNullOrEmpty(upc_p) || !upc_p.All(char.IsDigit) || upc_p.Length != 12)
            {
                MessageBox.Show("El campo UPC debe ser un texto de 12 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textIdMarca.Text, out idMarca))
            {
                MessageBox.Show("El campo ID Marca debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textIdProveedor.Text, out idProveedor))
            {
                MessageBox.Show("El campo ID Proveedor debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(tamano))
            {
                MessageBox.Show("El campo Tamaño no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(embalaje))
            {
                MessageBox.Show("El campo Embalaje no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(marca))
            {
                MessageBox.Show("El campo Marca no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textPrecio.Text, out precio))
            {
                MessageBox.Show("El campo Precio debe ser un número decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textCantidad.Text, out cantidad))
            {
                MessageBox.Show("El campo Cantidad debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textReorden.Text, out reorden))
            {
                MessageBox.Show("El campo Reorden debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conexión a la base de datos
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (var cmd = new NpgsqlCommand("modificar_producto", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios
                        cmd.Parameters.AddWithValue("upc_p", upc_p);
                        cmd.Parameters.AddWithValue("id_marca", idMarca);
                        cmd.Parameters.AddWithValue("id_proveedor", idProveedor);
                        cmd.Parameters.AddWithValue("nombre", nombre);
                        cmd.Parameters.AddWithValue("tamano", tamano);
                        cmd.Parameters.AddWithValue("embalaje", embalaje);
                        cmd.Parameters.AddWithValue("marca", marca);
                        cmd.Parameters.AddWithValue("precio", precio);
                        cmd.Parameters.AddWithValue("cantidad", cantidad);
                        cmd.Parameters.AddWithValue("reorden", reorden);

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Producto modificado exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Recargar los datos en el DataGridView para reflejar los cambios
            bdProductoLoad();

        }
    }
}

