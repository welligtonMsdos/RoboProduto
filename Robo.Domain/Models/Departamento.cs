using System.ComponentModel.DataAnnotations;

namespace Robo.Domain.Models
{
    public class Departamento
    {
        public int? id { get; set; }
        [Required]        
        [MinLength(3,ErrorMessage = "Descrição tem que ter no mínimo 3 caractere")]        
        public string descricao { get; set; }

        public Departamento(int? id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }

        public Departamento()
        {
        }
    }
}
