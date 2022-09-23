using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class EstiloDatos
    {
        List<Estilo> lista = new List<Estilo>();
        AccesoDatos datos = new AccesoDatos();

        public List<Estilo> listar()
        {
            try
            {
                datos.SetearConsulta("Select Id, Descripcion From ESTILOS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Estilo aux = new Estilo();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

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
                datos.CerrarConexion();
            }
        }
    }
}
