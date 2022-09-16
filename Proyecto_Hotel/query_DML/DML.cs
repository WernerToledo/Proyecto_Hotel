using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Hotel.query_DML
{
    internal class DML
    {

        public String agg_Data_empleado(SqlConnection conn, String pNombre, String pDireccion, String ptelefono, String query) {
            String msj = "";
            try
            {
                SqlCommand insercion = new SqlCommand(String.Format(query, pNombre, pDireccion, ptelefono), conn);
                insercion.ExecuteNonQuery();
                MessageBox.Show("Se logrooooXD");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return msj;
        }
    }
}
