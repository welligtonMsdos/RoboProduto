using Robo.Domain.Enum;
using Robo.Domain.Interfaces;
using System;
using System.Data;

namespace Robo.Domain.Data
{
    public class ProdutoPesquisa : IPesquisa
    {
        private readonly IProdutoRep _produtoRep;
        public ProdutoPesquisa(IProdutoRep produtoRep)
        {
            _produtoRep = produtoRep;
        }
        public void Editar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            return _produtoRep.GetAll();
        }       

        public string GetTitle()
        {
            return ETable.PRODUTO;
        }

        public void Novo()
        {
            throw new NotImplementedException();
        }
    }
}
