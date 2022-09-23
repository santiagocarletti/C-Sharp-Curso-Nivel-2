using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class EdicionDatos
    {
        List<Edicion> lista = new List<Edicion>();
        AccesoDatos datos = new AccesoDatos();

        public List<Edicion> listar()
        {
            try
            {
                datos.SetearConsulta("Select Id, Descripcion From TIPOSEDICION");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Edicion aux = new Edicion();
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
