using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        public SqlCommand comando;
        public SqlDataReader lector;
<<<<<<< HEAD

        public SqlDataReader Lector { 
            get { return lector; } 
=======
        public SqlDataReader Lector
        {
            get { return lector; }
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
        }

        public AccesoDatos()
        {
<<<<<<< HEAD
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=RestoBar; integrated security=true");
            comando = new SqlCommand();                
        }

        public void setearconsulta(string consulta)
=======
            conexion = new SqlConnection("server=.; database=RestoBar; integrated security=true");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
<<<<<<< HEAD

=======
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
<<<<<<< HEAD

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarconexion()
=======
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void cerrarConexion()
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

<<<<<<< HEAD
        public void ejecutaraccion()
=======
        public void ejecutarAccion()
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

<<<<<<< HEAD
=======
        public void setearProcedimiento(string sp)
        {
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;
        }
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
    }
}
