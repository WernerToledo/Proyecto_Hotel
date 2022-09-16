using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Classes
{
    internal class Hotel
    {

        private int id_hotel;
        private string nombre;
        private string direccion;
        private string telefono;
        private int anio_construccion;
        private Pais id_pais;
        private Categoria id_categoria;


        //propiedades

        public int ID_hotel
        {
            get { return id_hotel; }
            set { id_hotel = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public int Anio_construccion
        {
            get { return anio_construccion; }
            set { anio_construccion = value; }
        }

        public Pais Id_pais
        {
            get { return id_pais; }
            set { id_pais = value; }
        }

        public Categoria Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }

        //constructores 


        public Hotel()
        {

        }

        public Hotel(int p_id_hotel, string p_nombre, string p_direccion, string p_telefono, int p_anio_construccion, Pais p_id_pais, Categoria p_id_categoria)
        {
            this.id_hotel = p_id_hotel;
            this.nombre = p_nombre;
            this.direccion = p_direccion;
            this.telefono = p_telefono;
            this.anio_construccion = p_anio_construccion;
            this.id_pais = p_id_pais;
            this.id_categoria = p_id_categoria;
        }



        //métodos de la db

    }
}
