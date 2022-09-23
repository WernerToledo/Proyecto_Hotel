using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Clases
{
    internal class Categoria
    {

        private int id_categoria;
        private string nombre;
        private int estrellas;


        //propiedades

        public int IdCategoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Estrellas
        {
            get { return estrellas; }
            set { estrellas = value; }
        }

        //contructores

        public Categoria()
        {

        }

        public Categoria(int p_id_categoria, string p_nombre, int p_estrellas)
        {
            this.id_categoria = p_id_categoria;
            this.nombre = p_nombre;
            this.estrellas = p_estrellas;
        }


        //  métodos de la db


    }
}
