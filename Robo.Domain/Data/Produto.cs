using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robo.Domain.Interfaces;
using Robo.Domain.Enum;
using System.Net.Http;
using Newtonsoft.Json;

namespace Robo.Domain.Data
{
    public class Produto : IPesquisa
    {
        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
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
