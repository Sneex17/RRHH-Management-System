namespace CAccesoDatos.Data.Repositories
{
    public interface IRepositoryGeneral<T>
    {
        bool Agregar(T Objeto);
        bool Actualizar (T Objeto);
        bool Eliminar(T Objeto);
        IList<T> Lista();
    }
}
