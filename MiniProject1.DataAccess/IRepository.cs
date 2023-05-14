using MiniProject.Core.Interfaces;

namespace MiniProject1.DataAccess;

public interface IRepository<T> where T : IEntity
{
    void Add(T entity);

    void Update(T entity);

    void Delete(T entity);

    T? Get(int id);
    List<T> GetAll(int skip, int take);
    T? GetByName(string name);
    List<T> GetAllByName(string name);
}

