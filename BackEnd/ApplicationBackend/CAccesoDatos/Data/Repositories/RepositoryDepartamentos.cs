using CEntidades.Models;
using Npgsql;

namespace CAccesoDatos.Data.Repositories
{
    public class RepositoryDepartamentos : IRepositoryGeneral<Departamentos>
    {
        public bool Actualizar(Departamentos Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(Departamentos Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Departamentos Objeto)
        {
            throw new NotImplementedException();
        }

        public IList<Departamentos> Lista()
        {
            try
            {
                var listaDepartamentos = new List<Departamentos>();
                using(var acceso = new NpgsqlConnection(ConexionBD.connection()))
                {
                    acceso.Open();

                    var comando = new NpgsqlCommand("select * from pa_ListaDepartamentos();", acceso);
                    var reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        listaDepartamentos.Add(new Departamentos()
                        {
                            DepartamentoId =  reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            EstadoId = reader.GetInt32(2)
                        });
                    }
                    reader.Close();
                    acceso.Close();
                }

                return listaDepartamentos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
