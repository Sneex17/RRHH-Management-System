using Npgsql;
using System.Data;
using CEntidades.Models;

namespace CAccesoDatos.Data.Repositories
{
    public class RepositorySexos : IRepositoryGeneral<Sexos>
    {
        public bool Actualizar(Sexos Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(Sexos Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Sexos Objeto)
        {
            throw new NotImplementedException();
        }

        public IList<Sexos> Lista()
        {
            try
            {
                var listaSexos = new List<Sexos>();
                using (var acceso = new NpgsqlConnection(ConexionBD.connection()))
                {
                    acceso.Open();

                    var comando = new NpgsqlCommand("select * from pa_ListaSexos();", acceso);
                    var reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        listaSexos.Add(new Sexos()
                        {
                            SexoId = reader.GetInt32(0),
                            Sexo = reader.GetString(1),
                        });
                    }
                    reader.Close();
                    acceso.Close();
                }
                return listaSexos;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
