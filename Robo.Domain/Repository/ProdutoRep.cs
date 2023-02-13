using Newtonsoft.Json;
using Robo.Domain.Interfaces;
using Robo.Domain.Models;
using System;
using System.Data;
using System.Net.Http;

namespace Robo.Domain.Repository
{
    public class ProdutoRep : IProdutoRep
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (var httpClient = new HttpClient())
            {
                var result = httpClient.GetAsync("https://localhost:44361/api/Produto/GetAllByRobo").GetAwaiter().GetResult();

                var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    dt = (DataTable)JsonConvert.DeserializeObject(resultContent, (typeof(DataTable)));

                else
                    throw new Exception("Erro no método GetByDepartamentoId");
            }

            return dt;
        }

        public DataTable GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Produto obj)
        {
            throw new NotImplementedException();
        }

        public Produto ObterDados(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Produto obj)
        {
            throw new NotImplementedException();
        }

        public bool Validacao(Produto obj)
        {
            throw new NotImplementedException();
        }       
    }
}
