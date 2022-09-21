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
            String msj = "se logro valerXD";
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

        public SqlDataAdapter consulta_empleado_tabla(SqlConnection conn, String query)
        {
            SqlDataAdapter datos = null;
            try
            {
                SqlCommand Consultar = new SqlCommand(query, conn);
                datos = new SqlDataAdapter(Consultar);
            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            return datos;
        }

        public SqlDataReader consulta_empleado_llenando_Clase(SqlConnection conn, String query)
        {
            SqlDataReader datos = null;
            try
            {
                SqlCommand Consultar = new SqlCommand(query, conn);
                datos = Consultar.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            return datos;
        }
    }
}
