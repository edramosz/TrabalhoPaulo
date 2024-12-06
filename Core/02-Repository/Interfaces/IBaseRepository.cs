using Core._03_Entidades;

namespace Core._02_Repository.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Adicionar(T entity);
        void Remover(int id);
        void Editar(T entity);
        List<T> Listar();
        T BuscarPorId(int id);
    }
}
