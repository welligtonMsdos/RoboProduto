using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo.Domain.Interfaces
{
    public interface IPesquisa
    {
        string GetTitle();
        DataTable GetAll();
        void Novo();
        void Editar();
        void Excluir();
    }
}
