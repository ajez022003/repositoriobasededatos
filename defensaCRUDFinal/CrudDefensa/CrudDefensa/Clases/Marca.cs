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
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
            CargarDatosMarca();
        }
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";
        private void CargarDatosMarca()
        {
            // Cadena de conexión
            

            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM marca";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    bdMarca.DataSource = dt;
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
            int nuevoIdMarca;
            if (!int.TryParse(textidmarca.Text, out nuevoIdMarca))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para id marca.");
                return;
            }
            
            string nuevoNombre = textnombre.Text;

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Configurar el comando para el procedimiento almacenado
                    using (var cmd = new NpgsqlCommand("agregar_marca", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios para la inserción
                        cmd.Parameters.AddWithValue("id_marca", nuevoIdMarca);
                        cmd.Parameters.AddWithValue("nombre", nuevoNombre);

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Marca registrada exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar la marca: " + ex.Message);
                }
            }

            // Recargar el DataGridView para reflejar los nuevos datos
            bdMarcaLoad();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el nuevo valor del TextBox
            string nuevoNombre = textnombre.Text;

            // Suponiendo que tienes una clave primaria en la tabla para identificar la fila a actualizar
            int nuevaIdMarca = Convert.ToInt32(bdMarca.CurrentRow.Cells["id_marca"].Value);

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (var cmd = new NpgsqlCommand("modificar_marca", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("id_marca_m", nuevaIdMarca);
                        cmd.Parameters.AddWithValue("nombre_m", nuevoNombre);



                        // Ejecutar la actualización
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Marca modificada exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al modificar marca: " + ex.Message);
                }
            }

            // Actualizar el DataGridView para reflejar los cambios
            bdMarcaLoad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (bdMarca.CurrentRow != null)
            {
                // Obtener el valor del idinventario de la fila seleccionada
                int idmarca = Convert.ToInt32(bdMarca.CurrentRow.Cells["id_marca"].Value);

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
                            using (var cmd = new NpgsqlCommand("eliminar_marca", connection))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Agregar el parámetro necesario para la eliminación
                                cmd.Parameters.AddWithValue("id_marca_m", idmarca);

                                // Ejecutar el procedimiento almacenado
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Marca eliminada exitosamente.");
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al eliminar marca: " + ex.Message);
                        }
                    }

                    // Recargar el DataGridView para reflejar los cambios
                    bdMarcaLoad();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una marca para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bdMarcaLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM marca", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    bdMarca.DataSource = dataTable;
                }
            }
        }
    }
}
