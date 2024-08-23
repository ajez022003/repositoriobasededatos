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
    public partial class inventario : Form
    {
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";
        public inventario()
        {
            InitializeComponent();
            CargarDatosInventario();
        }

        private void CargarDatosInventario()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM inventario";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    bdinventario.DataSource = dt;
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
            int nuevoIdInventario;
            if (!int.TryParse(textidinventario.Text, out nuevoIdInventario))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para id inventario.");
                return;
            }
            int nuevoStock;
            if (!int.TryParse(textStock.Text, out nuevoStock))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para el stock del inventario.");
                return;
            }
            string nuevoIdProducto = textIdProducto.Text;
            
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Configurar el comando para el procedimiento almacenado
                    using (var cmd = new NpgsqlCommand("agregar_inventario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios para la inserción
                        cmd.Parameters.AddWithValue("idinventario", nuevoIdInventario);
                        cmd.Parameters.AddWithValue("stock", nuevoStock);
                        cmd.Parameters.AddWithValue("idproducto", nuevoIdProducto);
                       
                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Inventario registrado exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar el inventario: " + ex.Message);
                }
            }

            // Recargar el DataGridView para reflejar los nuevos datos
            bdInventarioLoad();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el nuevo valor del TextBox
            int nuevoStock;
            if (!int.TryParse(textStock.Text, out nuevoStock))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para el stock del inventario.");
                return;
            }
            string nuevoIdProducto = textIdProducto.Text;

            // Suponiendo que tienes una clave primaria en la tabla para identificar la fila a actualizar
            int nuevoIdInventario = Convert.ToInt32(bdinventario.CurrentRow.Cells["idinventario"].Value);

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (var cmd = new NpgsqlCommand("modificar_inventario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("id_inventario", nuevoIdInventario);
                        cmd.Parameters.AddWithValue("p_stock", nuevoStock);
                        cmd.Parameters.AddWithValue("p_idproducto", nuevoIdProducto);



                        // Ejecutar la actualización
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Inventario modificado exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al modificar el inventario: " + ex.Message);
                }
            }

            // Actualizar el DataGridView para reflejar los cambios
            bdInventarioLoad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (bdinventario.CurrentRow != null)
            {
                // Obtener el valor del idinventario de la fila seleccionada
                int idinventario = Convert.ToInt32(bdinventario.CurrentRow.Cells["idinventario"].Value);

                // Confirmar la eliminación con el usuario
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este inventario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new NpgsqlConnection(cadenaConexion))
                    {
                        try
                        {
                            connection.Open();

                            // Configurar el comando para el procedimiento almacenado
                            using (var cmd = new NpgsqlCommand("eliminar_inventario", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregar el parámetro necesario para la eliminación
                                cmd.Parameters.AddWithValue("id_inventario", idinventario);

                                // Ejecutar el procedimiento almacenado
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("inventario eliminado exitosamente.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al eliminar el inventario: " + ex.Message);
                        }
                    }

                    // Recargar el DataGridView para reflejar los cambios
                    bdInventarioLoad();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un inventario para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bdInventarioLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM inventario", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    bdinventario.DataSource = dataTable;
                }
            }
        }
    }
}
