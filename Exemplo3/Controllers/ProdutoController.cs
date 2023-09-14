using Exemplo3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Exemplo3.Controllers
{
    public class ProdutoController : Controller
    {
        public Context context; //instancia um contexto, sessão do BD

        public ProdutoController(Context ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            //retornar todos os produtos cadastrados
            return View(context.Produtos
                .Include(f => f.Fabricante));//carrega a associação com fabricantes
        }

        public IActionResult Create()
        {
            //viewbag é usada para enviar dados para a view
            ViewBag.FabricanteID = new SelectList(context.Fabricantes.OrderBy(f => f.Nome), "FabricanteID", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Produto produto)
        {
            context.Add(produto);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
