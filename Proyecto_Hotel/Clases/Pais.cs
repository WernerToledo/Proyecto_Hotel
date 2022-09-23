using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Clases
{
    internal class Pais
    {

        private int id_pais;
        private string nombre;
        private float iva;

        //propiedades

        public int Id_pais
        {

            get { return id_pais; }
            set { id_pais = value; }

        }


        public string NombrePais
        {
            get { return nombre; }
            set { nombre = value.Trim(); }
        }


        public float Iva
        {
            get { return iva; }
            set { iva = value; }
        }



        //contructores


        public Pais()
        {

        }

        public Pais(int p_id_pais, string p_nombre, float p_iva)
        {
            this.id_pais = p_id_pais;
            this.nombre = p_nombre;
            this.iva = p_iva;

        }

        // métodos de la db

    }
}
