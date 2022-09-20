using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Classes
{
    internal class Habitacion
    {
        //atributos
        private string _id_habitacion; //varchar de 5
        private int _piso, _num_puerta;
        private Tipo_habitacion _id_tipo_habitacion;
        private Hotel _id_hotel;
        private float _precio_dia;

        //propiedades
        public string Id_habitacion
        {
            get { return _id_habitacion; }
            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length < 6)
                    this._id_habitacion = value;
                else
                    this._id_habitacion = "N/E";
            }
        }
        public int Piso
        {
            get { return _piso; }
            set
            {
                if (value > 0)
                    this._piso = value;
                else
                    this._piso = 0;
            }
        }
        public int Num_puerta
        {
            get { return _num_puerta; }
            set
            {
                if (value > 0)
                    this._num_puerta = value;
                else
                    this._num_puerta = 0;
            }
        }
        public Tipo_habitacion Id_tipo_habitacion
        {
            get { return _id_tipo_habitacion; }
            set
            {
                if (value != null)
                    this._id_tipo_habitacion = value;
                else
                    this._id_tipo_habitacion = null;
            }
        }
        public Hotel Id_hotel
        {
            get { return _id_hotel; }
            set
            {
                if (value != null)
                    this._id_hotel = value;
                else
                    this._id_hotel = null;
            }
        }
        public float Precio_dia
        {
            get { return _precio_dia; }
            set
            {
                if (value > 0)
                    this._precio_dia = value;
                else
                    this._precio_dia = 0;
            }
        }

        //constructor
        public Habitacion() { }

        public Habitacion(string id_habitacion, int piso, int num_puerta,
            Tipo_habitacion id_tipo_hab, Hotel id_hotel, float precio_dia)
        {
            Id_habitacion = id_habitacion;
            Piso = piso;
            Num_puerta = num_puerta;
            Id_tipo_habitacion = id_tipo_hab;
            Id_hotel = id_hotel;
            Precio_dia = precio_dia;
        }
    }
}
