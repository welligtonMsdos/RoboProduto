using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo.Domain.Models
{
    public class Departamento
    {
        public int? id { get; set; }
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
