using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proyecto_Hotel
{
    public partial class Form1 : Form
    {
        //clase para usar las instrucciones de la bd
        query.query consulta = new query.query();
        //Clase para la conexion a la bd
        //Solo se puede llamar 1 vez o data error
        Conexion.Conexion connex = new Conexion.Conexion();
        //para la insercion a la bd
        query_DML.DML bddml = new query_DML.DML();
        //varaible que se carga con la clase de conexion
        SqlConnection conex = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
            conex = connex.establecerConex();
        }

        private void butt_Agg_Click(object sender, EventArgs e)
        {
            String nombre, direccion, tel;

            nombre = this.textBox_name.Text;
            direccion = this.textBox_direcc.Text;
            tel = this.textBox_tel.Text;

            bddml.agg_Data_empleado(conex, nombre, direccion, tel, consulta.agg_empleado());

        }
    }
}
