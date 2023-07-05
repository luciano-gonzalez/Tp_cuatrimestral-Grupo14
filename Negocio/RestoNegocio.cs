using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;
<<<<<<< HEAD
using System.Runtime.InteropServices;
using System.ComponentModel;

=======
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080

namespace Negocio
{
    public class RestoNegocio
    {
<<<<<<< HEAD

        public List<Insumo> listarcbebidas()
=======
        public List<Insumo> listarInsumo()
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
        {
            List<Insumo> lista = new List<Insumo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
<<<<<<< HEAD
                datos.setearconsulta("select i.IDInsumo,i.IDTipoinsumo,i.Nombre,i.Descripcion,i.Stock,i.Precio,i.ImagenUrl from Insumo i where i.IDTipoinsumo = 2 ");
=======
                datos.setearConsulta("SELECT Nombre, Stock, IDInsumo, IDTipoinsumo, Descripcion, ImagenUrl, Precio FROM Insumo where IDTipoinsumo = 1");
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
<<<<<<< HEAD
                    Insumo insu = new Insumo();
                    insu.IdInsumo = (int)datos.lector["IDInsumo"];
                    insu.IdTipoInsumo = (int)datos.lector["IDTipoinsumo"];
                    insu.Nombre = (string)datos.lector["Nombre"];
                    insu.Descripcion = (string)datos.lector["Descripcion"];
                    insu.CantidadStock = (int)datos.lector["Stock"];
                    insu.Precio = (float)datos.lector.GetDecimal(5);
                    insu.UrlImagen = (string)datos.lector["ImagenUrl"];

                    lista.Add(insu);
                }
                return lista;
            }



=======
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

>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
<<<<<<< HEAD
                datos.cerrarconexion();
            }

        }

        public List<Plato> listarplatos()
        {
            List<Plato> lista = new List<Plato>();
=======
                datos.cerrarConexion();
            }
        }

        public List<Insumo> listarBebidas()
        {
            List<Insumo> lista = new List<Insumo>();
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
            AccesoDatos datos = new AccesoDatos();

            try
            {
<<<<<<< HEAD
                datos.setearconsulta("select p.IDPlato,p.NombrePlato,p.Descripcion,p.Costo from plato p ");
=======
                datos.setearConsulta("SELECT Nombre, Stock, IDInsumo, IDTipoinsumo, Descripcion, ImagenUrl, Precio FROM Insumo where IDTipoinsumo = 2");
>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
<<<<<<< HEAD
                    Plato plato = new Plato();
                    plato.IDPlato = (int)datos.Lector["IDPlato"];
                    plato.NombrePlato = (string)datos.Lector["NombrePlato"];
                    plato.Descripcion = (string)datos.Lector["Descripcion"];
                    plato.Costo = (float)datos.Lector.GetDecimal(3);


                    lista.Add(plato);
                }
                return lista;
            }



=======
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

>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
<<<<<<< HEAD
                datos.cerrarconexion();
            }

        }




        public float Getprecioplatos(int idplato)
            {
            RestoNegocio resto = new RestoNegocio();

            try
            {
                List<Plato> listaplatos = resto.listarplatos();
                Plato plato = listaplatos.FirstOrDefault(p => p.IDPlato == idplato);
                if (plato != null)
                {

                    return plato.Costo;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

          return 0;

        }


        public float Getpreciobebidas(int idnsumo)
        {
            RestoNegocio resto = new RestoNegocio();

            try
            {
                List<Insumo>listarbebidas  = resto.listarcbebidas();
                Insumo bebida = listarbebidas.FirstOrDefault(p => p.IdInsumo == idnsumo );
                if (bebida != null)
                {

                    return bebida.Precio;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return 0;

        }








    }


        

        

=======
                datos.cerrarConexion();
            }
        }
    }

>>>>>>> 4cebedad6a6f5074d2d82e3b4f31dfe5f31ad080
}
