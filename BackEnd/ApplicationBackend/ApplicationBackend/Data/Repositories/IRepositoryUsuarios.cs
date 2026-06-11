using ApplicationBackend.Models;

namespace ApplicationBackend.Data.Repositories
{
    public interface IRepositoryUsuarios
    {
        Usuarios ValidarUsuario();
        void Agregar(Usuarios usuario);
        void Actualizar(Usuarios usuario);
        void Eliminar(Usuarios usuario);
        IList<Usuarios> Lista();
    }
}
