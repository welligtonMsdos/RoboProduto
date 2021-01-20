using System.Data;

namespace Robo.Domain.Interfaces
{
    public interface IRepository<T> where T: class
    {
        DataTable GetAll();
        DataTable GetById(int id);
        T Insert(T obj);   
        bool Update(T obj);
        bool Delete(int id);
    }
}
