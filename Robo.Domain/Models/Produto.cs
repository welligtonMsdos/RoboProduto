namespace Robo.Domain.Models
{
    public class Produto
    {
        public int? id { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int estoque { get; set; }
        public int departamento_Id { get; set; }
    }
}
