using System.Data;

namespace Robo.Domain.Interfaces
{
    public interface IRepository<T> where T: class
    {
        DataTable GetAll();
        DataTable GetById(int id);
        void Insert(T obj);   
        void Update(T obj);
        bool Delete(int id);
        bool Validacao(T obj);
        T ObterDados(int id);
    }
}
