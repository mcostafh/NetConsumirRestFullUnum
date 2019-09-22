using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TDM.sysCRM.Repositorios.Rest;
using TDM.SysCRM.AcessoADados.Entity.Context;
using TDM.SysCRM.Dominio;

namespace TDM.SysCRM.Controllers
{
    public class VeiculosController : Controller
    {


        // GET: Veiculos
        public ActionResult Index(Veiculo viewModel)
        {
            var repositorio = new VeiculoRepositorio();
            List<Veiculo> list = repositorio.Listar();

            return View(list);
        }
        // GET: Albums/Details/5
        public ActionResult Details( int? id)
        {
            var repositorio = new VeiculoRepositorio();
            Veiculo veic = repositorio.Buscar(id);

            return View(veic);
        }
        // GET: Albums/Details/5
        public ActionResult Edit(int? id)
        {
            var repositorio = new VeiculoRepositorio();
            Veiculo veic = repositorio.Buscar(id);

            return View(veic);
        }

        [HttpPost]
        public virtual ActionResult Edit(Veiculo veic)
        {
            var repositorio = new VeiculoRepositorio();
            repositorio.Salvar(veic);
            return RedirectToAction("Index");
            
        }

        // token: 01lY*G1qK7cghWpMls_7DCbHYk7rXIL0Cka_tuQR*qjxUD317zCoZVPMaxeXgXRYRQ
    }
}
