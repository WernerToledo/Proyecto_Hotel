using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.Query
{
    internal class Consulta
    {
        public String agg_empleado() {
            String query = "INSERT INTO empleado(nombre, direccion, telefono) " +
                "values('{0}', '{1}', '{2}');";
            return query;
        }

        public String cosulta_empleados()
        {
            String query = "select * from empleado;";
            return query;
        }
    }
}
