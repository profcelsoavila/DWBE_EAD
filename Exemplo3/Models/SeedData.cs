using Microsoft.EntityFrameworkCore;


namespace Exemplo3.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app) 
        { 
            //associa os dados ao contexto
            Context context = app.ApplicationServices.GetRequiredService<Context>(); 
            //inserir os dados nas entidades do contexto
            context.Database.Migrate(); 
            //se o contexto estiver vazio
            if (!context.Produtos.Any()) 
                //inserir os produtos iniciais
            { 
                context.Produtos.AddRange(
                    new Produto { Nome = "Camiseta Oficial", Preco = 250, FabricanteID = 1 }, 
                    new Produto { Nome = "Short",  Preco = 120, FabricanteID = 1 }, 
                    new Produto { Nome = "Tênis", Preco = 540, FabricanteID = 2 });

                context.Fabricantes.AddRange(
                    new Fabricante { Nome = "Adidas" },
                    new Fabricante { Nome = "Nike" });

                context.SaveChanges(); 
            } 
        }
    }
}
