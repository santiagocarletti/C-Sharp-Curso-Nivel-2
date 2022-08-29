using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace U6Proyecto1
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
                comando.CommandText = "Select Titulo as Nombre, FechaLanzamiento as AsuncionPresidente, CantidadCanciones as HabitantesKm2, UrlImagenTapa as ImagenMapa, IdEstilo as IdMoneda, IdTipoEdicion as IdIdioma From DISCOS";
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
                    aux.IdMoneda = (int)lector["IdMoneda"];
                    aux.IdIdioma = (int)lector["IdIdioma"];

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
