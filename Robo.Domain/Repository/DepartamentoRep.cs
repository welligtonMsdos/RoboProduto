using Newtonsoft.Json;
using Robo.Domain.Interfaces;
using Robo.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public void Insert(Departamento obj)
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

                        if (data.success == false)
                            throw new Exception(data.data);
                    }
                    else
                        throw new Exception("Erro no método Insert");                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Departamento ObterDados(int id)
        {
            Departamento departamento = new Departamento();

            DataTable dt = GetById(id);

            if (dt.Rows.Count > 0)
            {
                departamento.id = int.Parse(dt.Rows[0]["id"].ToString());
                departamento.descricao = dt.Rows[0]["descricao"].ToString();
            }

            return departamento;
        }

        public void Update(Departamento obj)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var jsonContent = JsonConvert.SerializeObject(obj);

                    var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    var result = httpClient.PutAsync("https://localhost:44361/api/Departamento/", contentString).GetAwaiter().GetResult();

                    var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        dynamic data = JsonConvert.DeserializeObject(resultContent);

                        if (data.success == false)
                            throw new Exception(data.data);
                    }
                    else
                        throw new Exception("Erro no método Insert");                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Validacao(Departamento obj)
        {
            bool resultado = true;

            if (obj != null)
            {
                ValidationContext context = new ValidationContext(obj, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(obj, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultado = false;
                    }
                }
            }
            else
                resultado = false;

            return resultado;
        }       
    }
}
