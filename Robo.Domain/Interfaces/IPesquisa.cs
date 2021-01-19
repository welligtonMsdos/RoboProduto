using System.Data;

namespace Robo.Domain.Interfaces
{
    public interface IPesquisa
    {
        string GetTitle();
        DataTable GetAll();       
        void Novo();
        void Editar(int id);
        bool Excluir(int id);
    }
}
