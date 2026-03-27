namespace ConfectioneryOrdering.Api.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public string Status { get; set; }
        public int LojaId { get; set; }
    }
}