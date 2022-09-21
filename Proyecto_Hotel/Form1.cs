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
using System.Collections;

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

        //Declaracion de la lista
        List<Classes.Empleado> lempleado = new List<Classes.Empleado>();

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

        private void butt_consulta_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter datos;
            datos = bddml.consulta_empleado_tabla(conex, consulta.cosulta_empleados());
            datos.Fill(tabla);
            dgv_Empleado.DataSource = tabla;

            //cargar el objeto lempleado
            SqlDataReader datos_insert;
            datos_insert = bddml.consulta_empleado_llenando_Clase(conex, consulta.cosulta_empleados());

            while (datos_insert.Read())
            {
                Classes.Empleado empleado = new Classes.Empleado();
                //se puede por orden numerico(0,1,2..) o como lo estoy pidiendo
                empleado.Id_empleado = Convert.ToUInt16(datos_insert["id_empleado"].ToString());
                empleado.Nombre = datos_insert["nombre"].ToString();
                empleado.Direccion = datos_insert["direccion"].ToString();
                empleado.Telefono = datos_insert["telefono"].ToString();
                lempleado.Add(empleado);
            }

            //para mostrarlo 
            foreach (Classes.Empleado data in lempleado)
            {
                MessageBox.Show("id: "+data.Id_empleado.ToString()+"\n"+
                                "nombre: "+data.Nombre+"\n"+
                                "direccion: "+data.Direccion+"\n"+
                                "teledono: "+data.Telefono);
            }
        }

        //por si borran lo que esta dentro de los bontones
        //este el codigo guia para realizar consultas, cargar tablas y cargar objetos

        /*
        DataTable tabla = new DataTable();
        SqlDataAdapter datos;
        datos = bddml.consulta_empleado_tabla(conex, consulta.cosulta_empleados());
            datos.Fill(tabla);
            dgv_Empleado.DataSource = tabla;

            //cargar el objeto lempleado
            SqlDataReader datos_insert;
        datos_insert = bddml.consulta_empleado_llenando_Clase(conex, consulta.cosulta_empleados());

            while (datos_insert.Read())
            {
                Classes.Empleado empleado = new Classes.Empleado();
        //se puede por orden numerico(0,1,2..) o como lo estoy pidiendo
        empleado.Id_empleado = Convert.ToUInt16(datos_insert["id_empleado"].ToString());
                empleado.Nombre = datos_insert["nombre"].ToString();
        empleado.Direccion = datos_insert["direccion"].ToString();
        empleado.Telefono = datos_insert["telefono"].ToString();
        lempleado.Add(empleado);
            }

            //para mostrarlo 
            foreach (Classes.Empleado data in lempleado)
            {
                MessageBox.Show("id: "+data.Id_empleado.ToString()+"\n"+
                                "nombre: "+data.Nombre+"\n"+
                                "direccion: "+data.Direccion+"\n"+
                                "teledono: "+data.Telefono);
            }
        */
    }
}
