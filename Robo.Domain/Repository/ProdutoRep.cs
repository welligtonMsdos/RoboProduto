using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robo.Domain.Interfaces;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Robo.Domain.Models;

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
                {
                    //List<Produto> produto = JsonConvert.DeserializeObject<List<Produto>>(resultContent);

                    dt = (DataTable)JsonConvert.DeserializeObject(resultContent, (typeof(DataTable)));
                }
                else
                {
                    throw new Exception("Erro no método GetByDepartamentoId");
                }
            }

            return dt;
        }
    }
}
