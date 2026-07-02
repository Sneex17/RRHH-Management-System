using Npgsql;
using CEntidades.Models;

namespace CAccesoDatos.Data.Repositories
{
    public class RepositoryEstados : IRepositoryGeneral<Estados>
    {
        public bool Actualizar(Estados Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(Estados Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Estados Objeto)
        {
            throw new NotImplementedException();
        }

        public IList<Estados> Lista()
        {
            try
            {
                var listaEstados = new List<Estados>();

                using(var acceso = new NpgsqlConnection(ConexionBD.connection()))
                {
                    acceso.Open();

                    var comando = new NpgsqlCommand("select * from pa_ListaEstados();", acceso);
                    var reader =  comando.ExecuteReader();

                    while (reader.Read())
                    {
                        listaEstados.Add(new Estados()
                        {
                            EstadoId = reader.GetInt32(0),
                            Estado = reader.GetString(1),
                            Descripcion = reader.GetString(2)
                        });
                    }
                    reader.Close();
                    acceso.Close();
                }
                return listaEstados;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public class RepositoryEstadosCiviles : IRepositoryGeneral<EstadosCiviles>
    {
        public bool Actualizar(EstadosCiviles Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(EstadosCiviles Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(EstadosCiviles Objeto)
        {
            throw new NotImplementedException();
        }

        public IList<EstadosCiviles> Lista()
        {
            try
            {
                var listaEstadosCiviles = new List<EstadosCiviles>();

                using(var acceso = new NpgsqlConnection(ConexionBD.connection()))
                {
                    acceso.Open();
                    var comando = new NpgsqlCommand("select * from pa_ListaEstadosCiviles()", acceso);
                    var reader =  comando.ExecuteReader();

                    while (reader.Read())
                    {
                        listaEstadosCiviles.Add(new EstadosCiviles()
                        {
                           EstadoCivilId = reader.GetInt32(0),
                           EstadoCivil= reader.GetString(1),
                           Descripcion= reader.GetString(2)
                        });
                    }
                    reader.Close();
                    acceso.Close();
                }

                return listaEstadosCiviles;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
