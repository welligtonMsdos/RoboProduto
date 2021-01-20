using Newtonsoft.Json;
using Robo.Domain.Interfaces;
using Robo.Domain.Models;
using System;
using System.Data;
using System.Net.Http;
using System.Text;
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
                var result = httpClient.GetAsync("https://localhost:44361/api/Departamento").GetAwaiter().GetResult();

                var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    dynamic objResponse = JsonConvert.DeserializeObject(resultContent);

                    if (objResponse.success == true)
                    {
                        var jsonContent = JsonConvert.SerializeObject(objResponse.data);
                        dt = (DataTable)JsonConvert.DeserializeObject(jsonContent, (typeof(DataTable)));
                    }
                    else
                        throw new Exception(objResponse.data);
                }
                else
                    throw new Exception("Erro no método GetAll");
            }

            return dt;
        }

        public DataTable GetById(int id)
        {
            DataTable dt = new DataTable();

            using (var httpClient = new HttpClient())
            {
                var result = httpClient.GetAsync("https://localhost:44361/api/Departamento/GetById/" + id).GetAwaiter().GetResult();

                var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    dynamic objResponse = JsonConvert.DeserializeObject(resultContent);

                    if (objResponse.success == true)
                    {
                        var jsonContent = JsonConvert.SerializeObject(objResponse.data);
                        dt = (DataTable)JsonConvert.DeserializeObject(jsonContent, (typeof(DataTable)));
                    }
                    else
                        throw new Exception(objResponse.data);
                }
                else
                    throw new Exception("Erro no método GetById");
            }

            return dt;
        }

        public bool Update(Departamento obj)
        {
            throw new NotImplementedException();
        }

        Departamento IRepository<Departamento>.Insert(Departamento obj)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var jsonContent = JsonConvert.SerializeObject(obj);

                    var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    var result = httpClient.PostAsync("https://localhost:44361/api/Departamento/", contentString).GetAwaiter().GetResult();

                    var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        dynamic data = JsonConvert.DeserializeObject(resultContent);

                        if (data.success == true)
                        {
                            obj.id = data.data.id;                            
                        }
                        else
                            throw new Exception(data.data);
                    }
                    else
                        throw new Exception("Erro no método Insert");

                    return obj;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
