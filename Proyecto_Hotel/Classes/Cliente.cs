using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Classes
{
    internal class Cliente
    {
        //Atributos
        private int _id_cliente;
        private string _nombre;
        private string _direccion;
        private string _telefono;

        //Propiedades
        public int id_cliente
        {
            get
            {
                return _id_cliente;
            }
            set
            {
                if (value > 0)
                    _id_cliente = value;
                else
                    _id_cliente = 0;
            }
        }

        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (value.Trim().Length > 0)
                    this._nombre = value.Trim();
                else
                    this._nombre = "No registrado";
            }
        }

        public string direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                if (value.Trim().Length > 0)
                    this._direccion = value.Trim();
                else
                    this._direccion = "No registrado";
            }
        }

        public string telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                if (value.Trim().Length > 0)
                    this._telefono = value.Trim();
                else
                    this._telefono = "No registrado";
            }
        }

        //Constructor de la clase
        public Cliente(int idCliente, string nombreCliente, string direccionCliente, string telefonoCliente)
        {
            this._id_cliente = idCliente;
            this._nombre = nombreCliente;
            this._direccion = direccionCliente;
            this._telefono = telefonoCliente;
        }
    }
}
