using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace BaseDatos
{
    public class VoucherDB
    {
        public List<Voucher> ListarVouchers()
        {
			List<Voucher> lista = new List<Voucher>();
            AccesoBaseDatos db = new AccesoBaseDatos();
            try
            {
                db.SetConsulta("SELECT CodigoVoucher as Codigo, V.IdCliente as Cliente, FechaCanje, A.Nombre as ArticuloDescripcion, IdArticulo FROM Vouchers V, ARTICULOS A, Clientes C WHERE V.IdCliente = C.Id AND V.IdArticulo = A.Id");
                db.Lectura(); 
                while (db.Reader.Read())
                {
                    Voucher auxVoucher = new Voucher();

                    auxVoucher.CodigoVoucher = (string)db.Reader["Codigo"];
                    auxVoucher.IdCliente = (string)db.Reader["Cliente"];
                    auxVoucher.FechaCanje = (DateTime)db.Reader["FechaCanje"];

                    auxVoucher.Articulo = new Articulo();
                    auxVoucher.Articulo.Id = (int)db.Reader["IdArticulo"];
                    auxVoucher.Articulo.Nombre = (string)db.Reader["ArticuloDescripcion"];

                    lista.Add(auxVoucher);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.CloseConexion();
            }
        }
    }
    }
}
