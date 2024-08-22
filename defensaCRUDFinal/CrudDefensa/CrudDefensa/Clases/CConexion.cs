using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CrudDefensa.Clases
{
    class CConexion
    {
        NpgsqlConnection  conex = new NpgsqlConnection();

        static String servidor = "proyecto-aws.c2htk24uoh9j.us-east-1.rds.amazonaws.com";
        static String bd = "Proyecto";
        static String Usuario = "postgres";
        static String Contrasena = "bases123456789";
        static String Puerto = "5432";

        String cadenaConexion = "Host=" + servidor + ";" +
                        "Port=" + Puerto + ";" +
                        "Username=" + Usuario + ";" +
                        "Password=" + Contrasena + ";" +
                        "Database=" + bd + ";";


        public NpgsqlConnection establecerConexion()
        {

            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conecto correctamente a la base de datos");
                

            }
            catch (NpgsqlException ex) {
               MessageBox.Show("No se conecto correctamente a la base de datos" + ex.ToString());

            }

            return conex;
        }

        public void cerrarConexion()
        {

            conex.Close();
        }
    }
}
