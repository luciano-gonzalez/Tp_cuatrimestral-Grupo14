﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mesa
    {
        public int IdMesa { get; set; }

        public int IdMesero { get; set; }

        public int IdPedido { get; set; }

        public int Ocupada { get; set; }
    }
}
