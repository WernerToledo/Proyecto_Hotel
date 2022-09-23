using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Clases
{
    internal class Reserva
    {
		//Atributos
		private int _id_reserva;
		private string _fecha_inicio;
		private string _fecha_fin;
		private string _huesped;
		private float _total;
		private string _id_habitacion;
		private int _id_cliente;
		private int _id_empleado;

		//Propiedades
		public int id_reserva
		{
			get
			{
				return _id_reserva;
			}
			set
			{
				if (value > 0)
					_id_reserva = value;
				else
					_id_reserva = 0;
			}
		}

		public string fecha_inicio
		{
			get
			{
				return _fecha_inicio;
			}
			set
			{
				if (value.Trim().Length > 0)
					this._fecha_inicio = value.Trim();
				else
					this._fecha_inicio = "No registrado";
			}
		}

		public string fecha_fin
		{
			get
			{
				return _fecha_fin;
			}
			set
			{
				if (value.Trim().Length > 0)
					this._fecha_fin = value.Trim();
				else
					this._fecha_fin = "No registrado";
			}
		}

		public string huesped
		{
			get
			{
				return _huesped;
			}
			set
			{
				if (value.Trim().Length > 0)
					this._huesped = value.Trim();
				else
					this._huesped = "No registrado";
			}
		}

		public string id_habitacion
		{
			get
			{
				return _id_habitacion;
			}
			set
			{
				if (value.Trim().Length > 0)
					this._id_habitacion = value.Trim();
				else
					this._id_habitacion = "No registrado";
			}
		}

		public float total
		{
			get
			{
				return _total;
			}
			set
			{
				if (value > 0)
					_total = value;
				else
					_total = 0;
			}
		}

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

		public int id_empleado
		{
			get
			{
				return _id_empleado;
			}
			set
			{
				if (value > 0)
					_id_empleado = value;
				else
					_id_empleado = 0;
			}
		}

		public Reserva(int idReserva, string fechaInicio, string fechaFin, string huespedReserva, float totalReserva, string idHabitacion, int idCliente, int idEmpleado)
		{
			this._id_reserva = idReserva;
			this._fecha_inicio = fechaInicio;
			this._fecha_fin = fechaFin;
			this._huesped = huespedReserva;
			this._total = totalReserva;
			this._id_habitacion = idHabitacion;
			this._id_cliente = idCliente;
			this._id_empleado = idEmpleado;
		}
	}
}
