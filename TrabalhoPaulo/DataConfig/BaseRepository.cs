using Core._02_Repository;
using Core._02_Repository.Interfaces;
using Core._03_Entidades;
using Microsoft.EntityFrameworkCore;

namespace API.DataConfig
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Adicionar(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void Remover(int id)
        {
            T entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        public void Editar(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
        public List<T> Listar()
        {
            return _dbSet.ToList();
        }
        public T BuscarPorId(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
