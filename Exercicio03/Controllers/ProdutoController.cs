using Exercicio03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio03.Controllers
{
    public class ProdutoController : Controller
    {
        private FabricaBDEntities _context = new FabricaBDEntities();
        // GET: Produto
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Produto p)
        {
            _context.Produto.Add(p);
            _context.SaveChanges();
            TempData["msg"] = "Produto Cadastrado";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            List<Produto> _lista = _context.Produto.ToList();
            return View(_lista);
        }
    }
}