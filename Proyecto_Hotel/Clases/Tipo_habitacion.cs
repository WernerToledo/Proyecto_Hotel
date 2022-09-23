using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Clases
{
    internal class Tipo_habitacion
    {
        private int _id_tipo_habitacion;
        private string _nombre;

        public int Id_tipo_habitacion
        {
            get { return _id_tipo_habitacion; }
            set
            {
                if (value > 0)
                    this._id_tipo_habitacion = value;
                else
                    this._id_tipo_habitacion = 0;
            }
        }
        public string Nombre_habitacion
        {
            get { return _nombre; }
            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length < 31)
                    this._nombre = value;
                else
                    this._nombre = "N/E";
            }
        }

        public Tipo_habitacion() { }

        public Tipo_habitacion(int id_tipo_habitacion, string nombre_habitacion)
        {
            Id_tipo_habitacion = id_tipo_habitacion;
            Nombre_habitacion = nombre_habitacion;
        }
    }
}
