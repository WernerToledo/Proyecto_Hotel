using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Hotel.Conexion
{
    internal class Conexion
    {
        SqlConnection conex = new SqlConnection();

        static String servidor = "localhost";
        static String bd = "hotelbd";
        static String usuario = "sa";
        static String pass = "123";
        static String port = "1433";

        String cadena_conex = "Data Source = " + servidor + ", " + port + "; " + "user id = " + usuario + "; " + "password = " + pass + "; "
                                + "Initial Catalog = " + bd + ";";

        public SqlConnection establecerConex()
        {
            try
            {
                conex.ConnectionString = cadena_conex;
                conex.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return conex;
        }
    }
}
