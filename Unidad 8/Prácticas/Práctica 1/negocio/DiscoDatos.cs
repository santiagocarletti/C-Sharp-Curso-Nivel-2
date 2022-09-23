using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class DiscoDatos
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOSDB_U7; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion EstiloDisco, T.Descripcion TipoEdicion, D.Id, D.IdTipoEdicion, D.IdEstilo From DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];

                    if (!(lector["UrlImagenTapa"] is DBNull))
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    
                    aux.EstiloDisco = new Estilo();
                    aux.EstiloDisco.Id = (int)lector["IdEstilo"];
                    aux.EstiloDisco.Descripcion = (string)lector["EstiloDisco"];
                    aux.TipoEdicion = new Edicion();
                    aux.TipoEdicion.Id = (int)lector["IdTipoEdicion"];
                    aux.TipoEdicion.Descripcion = (string)lector["TipoEdicion"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void agregar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion, UrlImagenTapa)values('" + nuevo.Titulo + "', '" + nuevo.FechaLanzamiento + "', " + nuevo.CantidadCanciones + ", @idEstilo, @idTipoEdicion, @urlImagenTapa)");
                datos.setearParametro("@idEstilo", nuevo.EstiloDisco.Id);
                datos.setearParametro("@idTipoEdicion", nuevo.TipoEdicion.Id);
                datos.setearParametro("@urlImagenTapa", nuevo.UrlImagenTapa);
                datos.ejecutarAccion();
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
        public void modificar(Disco disco)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update DISCOS set Titulo = @titulo, FechaLanzamiento = @fecha, CantidadCanciones = @canciones, UrlImagenTapa = @url, IdEstilo = @estilo, IdTipoEdicion = @edicion where Id = @id");
                datos.setearParametro("@titulo", disco.Titulo);
                datos.setearParametro("@fecha", disco.FechaLanzamiento);
                datos.setearParametro("@canciones", disco.CantidadCanciones);
                datos.setearParametro("@url", disco.UrlImagenTapa);
                datos.setearParametro("@estilo", disco.EstiloDisco.Id);
                datos.setearParametro("@edicion", disco.TipoEdicion.Id);
                datos.setearParametro("@id", disco.Id);

                datos.ejecutarAccion();
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
