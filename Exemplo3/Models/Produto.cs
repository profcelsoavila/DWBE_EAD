namespace Exemplo3.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public float Preco { get;set; }
        public int FabricanteID { get; set; }   
        public Fabricante Fabricante { get; set;}
    }
}
