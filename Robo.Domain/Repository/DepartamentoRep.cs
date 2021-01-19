using Newtonsoft.Json;
using Robo.Domain.Interfaces;
using Robo.Domain.Models;
using System;
using System.Data;
using System.Net.Http;
using System.Windows.Forms;

namespace Robo.Domain.Repository
{
    public class DepartamentoRep : IDepartamentoRep
    {
        public bool Delete(int id)
        {
            bool resultado = false;
            try
            {
                using (var httClient = new HttpClient())
                {
                    using (var httpClient = new HttpClient())
                    {
                        var result = httpClient.DeleteAsync("https://localhost:44361/api/Departamento/" + id).GetAwaiter().GetResult();

                        var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                        resultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = false;
            }

            return resultado;
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (var httpClient = new HttpClient())
            {
                var result = httpClient.GetAsync("https://localhost:44361/api/Departamento/GetAllByRobo").GetAwaiter().GetResult();

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
            DataTable dt = new DataTable();

            using (var httpClient = new HttpClient())
            {
                var result = httpClient.GetAsync("https://localhost:44361/api/Departamento/GetByIdRobo/" + id).GetAwaiter().GetResult();

                var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (resultContent.ToString().Contains("Erro"))
                    throw new Exception("Erro no método GetById");

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    dt = (DataTable)JsonConvert.DeserializeObject(resultContent, (typeof(DataTable)));
                else
                    throw new Exception("Erro no método GetById");
            }

            return dt;
        }

        public bool Insert(Departamento obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Departamento obj)
        {
            throw new NotImplementedException();
        }
    }
}
