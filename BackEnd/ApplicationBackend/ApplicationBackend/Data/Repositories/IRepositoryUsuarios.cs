using ApplicationBackend.Models;

namespace ApplicationBackend.Data.Repositories
{
    public interface IRepositoryUsuarios
    {
        Usuarios ValidarUsuario(string usarname, string pass);
        void Agregar(Usuarios usuario);
        void Actualizar(Usuarios usuario);
        void Eliminar(Usuarios usuario);
        IList<Usuarios> Lista();
    }
}
