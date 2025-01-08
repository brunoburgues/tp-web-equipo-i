using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace BaseDatos
{
    public class ClienteDB
    {
        public List<Cliente> ListarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            AccesoBaseDatos db = new AccesoBaseDatos();
            try
            {
                db.SetConsulta("SELECT Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP FROM Clientes");
                db.Lectura();
                while (db.Reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = (int)db.Reader["Id"];
                    cliente.Documento = (string)db.Reader["Documento"];
                    cliente.Nombre = (string)db.Reader["Nombre"];
                    cliente.Apellido = (string)db.Reader["Apellido"];
                    cliente.Email = (string)db.Reader["Email"];
                    cliente.Direccion = (string)db.Reader["Direccion"];
                    cliente.Ciudad = (string)db.Reader["Ciudad"];
                    cliente.CP = (string)db.Reader["CP"];
                    listaClientes.Add(cliente);
                }
                return listaClientes;
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
