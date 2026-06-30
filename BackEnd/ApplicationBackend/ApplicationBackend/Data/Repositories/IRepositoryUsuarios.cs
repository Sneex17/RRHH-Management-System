using ApplicationBackend.DTOs;
using ApplicationBackend.Models;
using Microsoft.AspNetCore.Identity.Data;

namespace ApplicationBackend.Data.Repositories
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
