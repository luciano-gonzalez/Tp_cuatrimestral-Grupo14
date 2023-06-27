using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Pedido
    {
        public int IdPedido { get; set; }

        public  int IdInsumo { get; set; }

        public int Cantidad { get; set; }

        public float Cuenta{ get; set; }

        public string NombreCliente { get; set; }

        public int IdMesa { get; set; }
    }
}
