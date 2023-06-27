using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class AccesoDatos
    {
        public SqlConnection conexion;

        public SqlCommand comando;

        public SqlDataReader lector;
    }
}
