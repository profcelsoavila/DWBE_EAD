namespace Exemplo3.Models
{
    public class Fabricante
    {
        public int FabricanteID { get; set; }   
        public string Nome { get; set; } 
        public ICollection<Produto> Produtos { get; set; }   
    }
}
