using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hotel.query
{
    internal class query
    {
        public String agg_empleado() {
            String query = "INSERT INTO empleado(nombre, direccion, telefono) " +
                "values('{0}', '{1}', '{2}');";
            return query;
        }
    }
}
