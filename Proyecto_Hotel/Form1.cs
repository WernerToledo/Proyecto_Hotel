using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Hotel.Query;
using Proyecto_Hotel.Conexion;
using Proyecto_Hotel.query_DML;
using Proyecto_Hotel.Clases;
using System.Data.SqlClient;


namespace Proyecto_Hotel
{
    public partial class Form1 : Form
    {

        //clase para usar las instrucciones de la bd
        Consulta consulta = new Consulta();
        //Clase para la conexion a la bd
        //Solo se puede llamar 1 vez o da error
        conexion connex = new conexion();

        //para la insercion a la bd
        DML bddml = new DML();
        //varaible que se carga con la clase de conexion
        SqlConnection conex = new SqlConnection();

        //Declaracion de la lista
        List<Empleado> lempleado = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
            conex = connex.establecerConex();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre, direccion, tel;

            nombre = this.textBox1.Text;
            direccion = this.textBox2.Text;
            tel = this.textBox3.Text;

            bddml.agg_Data_empleado(conex, nombre, direccion, tel, consulta.agg_empleado());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter datos;
            datos = bddml.consulta_empleado_tabla(conex, consulta.cosulta_empleados());
            datos.Fill(tabla);
            dataGridView1.DataSource = tabla;

            //cargar el objeto lempleado
            SqlDataReader datos_insert;
            datos_insert = bddml.consulta_empleado_llenando_Clase(conex, consulta.cosulta_empleados());

            while (datos_insert.Read())
            {
                Empleado empleado = new Empleado();
                //se puede por orden numerico(0,1,2..) o como lo estoy pidiendo
                empleado.Id_empleado = Convert.ToUInt16(datos_insert["id_empleado"].ToString());
                empleado.Nombre = datos_insert["nombre"].ToString();
                empleado.Direccion = datos_insert["direccion"].ToString();
                empleado.Telefono = datos_insert["telefono"].ToString();
                lempleado.Add(empleado);
            }

            //para mostrarlo 
            foreach (Empleado data in lempleado)
            {
                MessageBox.Show("id: " + data.Id_empleado.ToString() + "\n" +
                                "nombre: " + data.Nombre + "\n" +
                                "direccion: " + data.Direccion + "\n" +
                                "teledono: " + data.Telefono);
            }
        }
    }
}
