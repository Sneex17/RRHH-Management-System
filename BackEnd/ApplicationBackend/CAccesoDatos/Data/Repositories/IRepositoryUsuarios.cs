using CAccesoDatos.DTOs;
using CEntidades.Models;


namespace CAccesoDatos.Data.Repositories
{
    public interface IRepositoryUsuarios
    {
        string ValidarUsuario(LoginUsuarioDTO usuarioJson);
        void Agregar(Usuarios usuario);
        void Actualizar(Usuarios usuario);
        void Eliminar(Usuarios usuario);
        IList<Usuarios> Lista();
    }
}
