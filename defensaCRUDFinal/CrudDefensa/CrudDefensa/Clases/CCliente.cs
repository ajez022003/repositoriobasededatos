using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudDefensa.Clases
{
    class CCliente
    {
        public void MostrarClientes(DataGridView tablaclientes)
        {
            try
            {
                tablaclientes.DataSource = null;

               // SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Alumnos;");

            }
            catch
            {

            }

        }
    }
}
