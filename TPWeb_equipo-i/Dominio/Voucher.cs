﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public string CodigoVoucher { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCanje { get; set; }
        public Articulo Articulo { get; set; }
        
    }
}
