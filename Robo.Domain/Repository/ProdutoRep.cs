using Newtonsoft.Json;
using Robo.Domain.Interfaces;
using System;
using System.Data;
using System.Net.Http;

namespace Robo.Domain.Repository
{
    public class ProdutoRep : IProdutoRep
    {
        public ProdutoRep()
        {

        }
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (var httpClient = new HttpClient())
            { 
                var result = httpClient.GetAsync("https://localhost:44361/api/Produto/GetByDepartamentoId/1").GetAwaiter().GetResult();
                
                var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    dt = (DataTable)JsonConvert.DeserializeObject(resultContent, (typeof(DataTable)));
                else
                    throw new Exception("Erro no método GetByDepartamentoId");
            }

            return dt;
        }
    }
}
