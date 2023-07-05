using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class RestoNegocio
    {
        public List<Insumo> listarInsumo()
        {
            List<Insumo> lista = new List<Insumo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Nombre, Stock, IDInsumo, IDTipoinsumo, Descripcion, ImagenUrl, Precio FROM Insumo where IDTipoinsumo = 1");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Insumo aux = new Insumo();
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.CantidadStock = (int)datos.Lector["Stock"];
                    aux.IdTipoInsumo = (int)datos.Lector["IDTipoinsumo"];
                    aux.Precio = (float)datos.Lector.GetDecimal(6);
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.IdInsumo = (int)datos.Lector["IDInsumo"];
                    lista.Add(aux);
                }

                return lista;
            }

            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Insumo> listarBebidas()
        {
            List<Insumo> lista = new List<Insumo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Nombre, Stock, IDInsumo, IDTipoinsumo, Descripcion, ImagenUrl, Precio FROM Insumo where IDTipoinsumo = 2");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Insumo aux = new Insumo();
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.CantidadStock = (int)datos.Lector["Stock"];
                    aux.IdTipoInsumo = (int)datos.Lector["IDTipoinsumo"];
                    aux.Precio = (float)datos.Lector.GetDecimal(6);
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.IdInsumo = (int)datos.Lector["IDInsumo"];
                    lista.Add(aux);
                }

                return lista;
            }

            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }

}
