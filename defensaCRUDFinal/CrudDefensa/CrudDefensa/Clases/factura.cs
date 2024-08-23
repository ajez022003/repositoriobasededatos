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
    public partial class factura : Form
    {
        // Cadena de conexión
        string cadenaConexion = "Host=proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=bases123456789;Database=Proyecto";

        public factura()
        {
            InitializeComponent();
            CargarDatosfactura();
        }
        private void CargarDatosfactura()
        {
            
            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    // Abre la conexión
                    conexion.Open();

                    // Consulta SQL
                    string consulta = "SELECT * FROM factura";

                    // Crear un adaptador de datos
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(consulta, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dt);

                    // Asignar el DataTable como la fuente de datos del DataGridView
                    bdfactura.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nuevoIdFactura;
            if (!int.TryParse(textIdFactura.Text, out nuevoIdFactura))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la Id de Factura.");
                return;
            }
            int nuevoidCliente;
            if (!int.TryParse(textIdCliente.Text, out nuevoidCliente))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la Id de Cliente.");
                return;
            }
            decimal nuevoSubTotal;
            if(!decimal.TryParse(textSubTotal.Text, out nuevoSubTotal))
            {
                MessageBox.Show("Por favor, ingresa un número válido para el subtotal.");
                return;
            }
            decimal ISV = 0.15m;
            
            decimal nuevoISV=nuevoSubTotal*ISV;
     
            decimal nuevoTotal=nuevoSubTotal+nuevoISV;
            
            DateTime NuevaFecha;
            if (!DateTime.TryParse(textFecha.Text, out NuevaFecha))
            {
                MessageBox.Show("Por favor, ingresa una fecha válida.");
                return;
            }

            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Configurar el comando para el procedimiento almacenado
                    using (var cmd = new NpgsqlCommand("agregar_factura", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios para la inserción
                        cmd.Parameters.AddWithValue("idfactura", nuevoIdFactura);
                        cmd.Parameters.AddWithValue("fecha", NuevaFecha);
                        cmd.Parameters.AddWithValue("sub_total", nuevoSubTotal);
                        cmd.Parameters.AddWithValue("isv", nuevoISV);
                        cmd.Parameters.AddWithValue("total", nuevoTotal);
                        cmd.Parameters.AddWithValue("idcliente", nuevoidCliente);


                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Factura guardada exitosamente.");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar factura: " + ex.Message);
                }
            }

            // Recargar el DataGridView para reflejar los nuevos datos
            bdFacturaLoad();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el nuevo valor del TextBox
            decimal nuevoSubTotal;
            if (!decimal.TryParse(textSubTotal.Text, out nuevoSubTotal))
            {
                MessageBox.Show("Por favor, ingresa un número válido para el subtotal.");
                return;
            }
            decimal ISV = 0.15m;

            decimal nuevoISV = nuevoSubTotal * ISV;

            decimal nuevoTotal = nuevoSubTotal + nuevoISV;
            
            int nuevoidCliente;
            if (!int.TryParse(textIdCliente.Text, out nuevoidCliente))
            {
                MessageBox.Show("Por favor, ingresa un número entero válido para la Id de Cliente.");
                return;
            }

            DateTime NuevaFecha;
            if (!DateTime.TryParse(textFecha.Text, out NuevaFecha))
            {
                MessageBox.Show("Por favor, ingresa una fecha válida.");
                return;
            }

            // Suponiendo que tienes una clave primaria en la tabla para identificar la fila a actualizar
            int id = Convert.ToInt32(bdfactura.CurrentRow.Cells["idfactura"].Value);


            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (var cmd = new NpgsqlCommand("modificar_factura", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("idfactura_m", id);
                        cmd.Parameters.AddWithValue("fecha_m", NuevaFecha);
                        cmd.Parameters.AddWithValue("sub_total_m", nuevoSubTotal);
                        cmd.Parameters.AddWithValue("isv_m", nuevoISV);
                        cmd.Parameters.AddWithValue("total_m", nuevoTotal);
                        cmd.Parameters.AddWithValue("idcliente_m", nuevoidCliente);
                    


                        // Ejecutar la actualización
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Factura modificada exitosamente.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el inventario: " + ex.Message);
                }
                
            }

            // Actualizar el DataGridView para reflejar los cambios
            bdFacturaLoad();
        }

        private void bdFacturaLoad()
        {
            using (var connection = new NpgsqlConnection(cadenaConexion))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT * FROM factura", connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable al DataGridView
                    bdfactura.DataSource = dataTable;
                }
            }
        }
    }
}
