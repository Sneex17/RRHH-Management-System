using ApplicationBackend.Models;
using Npgsql;

namespace ApplicationBackend.Data.Repositories
{
    public class RepositoryUsuarios : IRepositoryUsuarios
    {
        public void Actualizar(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public IList<Usuarios> Lista()
        {
            throw new NotImplementedException();
        }

        public Usuarios ValidarUsuario()
        {
            var user = new Usuarios();
            try
            {
                
                using (var acceso = new NpgsqlConnection(ConexionBD.connection()))
                {
                    acceso.Open();
                    string c = $"select * from Usuarios where UsuarioId = 1";
                    var comando = new NpgsqlCommand(c);
                    var reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        user = new Usuarios()
                        {
                            UserId = reader.GetInt32(0),
                            EmpleadoId = reader.GetString(1),
                            Username = reader.GetString(2),
                            EstadoId = reader.GetInt32(6)
                        };
                    }
                    reader.Close();
                    acceso.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return user;
        }
    }
}
