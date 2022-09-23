using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Clases
{
    internal class Empleado
    {
        private int _id_empleado;
        private string _nombre, _direccion, _telefono;

        public int Id_empleado
        {
            get { return _id_empleado; }
            set
            {
                if (value > 0)
                    this._id_empleado = value;
                else
                    this._id_empleado = 0;
            }
        }
        public string Nombre
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
        public string Direccion
        {
            get { return _direccion; }
            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length < 151)
                    this._direccion = value;
                else
                    this._direccion = "N/E";
            }
        }
        public string Telefono
        {
            get { return _telefono; }
            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length < 16)
                    this._telefono = value;
                else
                    this._telefono = "N/E";
            }
        }

        public Empleado() { }

        public Empleado(int id_cliente, string nombre, string direccion, string telefono)
        {
            Id_empleado = id_cliente;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
