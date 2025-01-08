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
        public List<string> ListarCodigos()
        {
            List<string> codigos = new List<string>();
            AccesoBaseDatos db = new AccesoBaseDatos();
            try
            {
                db.SetConsulta("SELECT CodigoVoucher FROM Vouchers");
                db.Lectura();
                while (db.Reader.Read())
                {
                    codigos.Add((string)db.Reader["CodigoVoucher"]);
                }
                return codigos;
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
        public List<string> ListarCodigosUsados()
        {
            List<string> listaCodigosUsados = new List<string>();
            AccesoBaseDatos db = new AccesoBaseDatos();
            try
            {
                db.SetConsulta("SELECT CodigoVoucher FROM Vouchers WHERE IdCliente IS NULL AND Nombre IS NULL AND FechaCanje IS NULL AND IdArticulo IS NULL");
                db.Lectura();
                while (db.Reader.Read())
                {
                    listaCodigosUsados.Add((string)db.Reader["CodigoVoucher"]);
                }
                return listaCodigosUsados;
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
