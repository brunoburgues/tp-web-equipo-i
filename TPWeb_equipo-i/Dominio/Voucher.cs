using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public string CodigoVoucher { get; set; }
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public int FechaCanje { get; set; }
        public int IdArticulo { get; set; }
        
    }
}
