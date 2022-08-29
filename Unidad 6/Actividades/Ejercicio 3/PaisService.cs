using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace U6Proyecto4
{
    internal class PaisService
    {
        public List<Pais> listar()
        {
            List<Pais> lista = new List<Pais>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=PAISES_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select D.Titulo as Nombre, D.FechaLanzamiento as AsuncionPresidente, D.CantidadCanciones as HabitantesKm2, D.UrlImagenTapa as ImagenMapa, E.Descripcion as MonedaOficial, T.Descripcion as IdiomaOficial From DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pais aux = new Pais();
                    aux.Nombre = (string)lector["Nombre"];
                    aux.AsuncionPresidente = (DateTime)lector["AsuncionPresidente"];
                    aux.HabitantesKm2 = (int)lector["HabitantesKm2"];
                    aux.ImagenMapa = (string)lector["ImagenMapa"];
                    aux.IdiomaOficial = new Idioma();
                    aux.IdiomaOficial.Descripcion = (string)lector["IdiomaOficial"];
                    aux.MonedaOficial = new Moneda();
                    aux.MonedaOficial.Descripcion = (string)lector["MonedaOficial"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw;
            }


        }
    }
}
