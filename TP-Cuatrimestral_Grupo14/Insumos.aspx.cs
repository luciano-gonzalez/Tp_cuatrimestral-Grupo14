using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TP_Cuatrimestral_Grupo14
{
    public partial class About : Page
    {
        AccesoDatos datos;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarStockInsumos();
                CargarStockPlatos();
                CargarStockBebidas();
            }
        }

        private void CargarStockInsumos()
        {
            RestoNegocio negocio = new RestoNegocio();
            List<Insumo> stockInsumos = negocio.listarInsumo();

            // Crear un nuevo DataTable con las columnas deseadas
            DataTable dtInsumos = new DataTable();
            dtInsumos.Columns.Add("Nombre", typeof(string));
            dtInsumos.Columns.Add("Stock", typeof(int));

            // Recorrer la lista de insumos y agregar los datos al DataTable
            foreach (Insumo insumo in stockInsumos)
            {
                string nombre = insumo.Nombre;
                int stock = insumo.CantidadStock;

                dtInsumos.Rows.Add(nombre, stock);
            }

            gvStockInsumos.DataSource = dtInsumos;
            gvStockInsumos.DataBind();
        }

        private void CargarStockPlatos()
        {
            datos = new AccesoDatos();
            datos.setearConsulta("SELECT p.NombrePlato, SUM(pi.Cantidad) AS StockTotalPlato " +
                                 "FROM plato p " +
                                 "INNER JOIN platoInsumo pi ON p.IDPlato = pi.IDPlato " +
                                 "GROUP BY p.NombrePlato");
            datos.ejecutarLectura();

            DataTable dtStockPlatos = new DataTable();
            dtStockPlatos.Load(datos.Lector);
            datos.cerrarConexion();

            gvStockPlatos.DataSource = dtStockPlatos;
            gvStockPlatos.DataBind();
        }

        private void CargarStockBebidas()
        {
            datos = new AccesoDatos();
            datos.setearConsulta("SELECT i.Nombre, SUM(i.Stock) AS StockTotalBebidas " +
                                 "FROM Insumo i " +
                                 "WHERE i.IDTipoinsumo = 2 " +
                                 "GROUP BY i.Nombre");
            datos.ejecutarLectura();

            DataTable dtStockBebidas = new DataTable();
            dtStockBebidas.Load(datos.Lector);
            datos.cerrarConexion();

            gvStockBebidas.DataSource = dtStockBebidas;
            gvStockBebidas.DataBind();
        }
    }
}
