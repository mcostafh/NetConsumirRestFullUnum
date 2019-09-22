using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using TDM.Repositorios.Comum;
using TDM.SysCRM.Dominio;
using TDM.SysCRM.ViewModels;

namespace TDM.SysCRM.Controllers
{
    public abstract class CrudController<TEntidade, TViewModel, TExibicaoViewModel, TFiltroViewModel> : Controller
        where TEntidade : Entidade
        where TViewModel : IViewModel
        where TExibicaoViewModel : IExibicaoViewModel
        where TFiltroViewModel : IFiltroViewModel<TExibicaoViewModel>, new()
    {
        protected readonly IRepositorioGenerico<TEntidade, long> _repository;

        protected CrudController(IRepositorioGenerico<TEntidade, long> repository)
            => _repository = repository;

        // GET: Consultor
        public virtual ActionResult Index()
            => View(new TFiltroViewModel() { Exibicao = new List<TExibicaoViewModel>() });

        public virtual ActionResult Filtrar(TFiltroViewModel filtro)
        {
            var results = _repository.Selecionar("","").ToList();
            var viewModels = Mapper.Map<List<TEntidade>, List<TExibicaoViewModel>>(results);
            return Json(viewModels, JsonRequestBehavior.AllowGet);
        }

        public virtual ActionResult Lista(IEnumerable<TExibicaoViewModel> list) 
            => PartialView("_Lista", list);

        public virtual ActionResult Details(long? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var entidade = _repository.SelecionarPorId(id.Value);
            if (entidade == null)
                return HttpNotFound();

            return View(Mapper.Map<TExibicaoViewModel>(entidade));
        }

        // GET: MotivoAcionamen/Create
        public virtual ActionResult Create()
            => View();

        // POST: MotivoAcionamen/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create(TExibicaoViewModel viewModel)
        {
            //if (ModelState.IsValid)
            //{
                var entidade = Mapper.Map<TEntidade>(viewModel);
                _repository.Inserir(entidade);
                return RedirectToAction("Index");
            //}

            return View(viewModel);
        }

        // GET: MotivoAcionamen/Edit/5
        public virtual ActionResult Edit(long? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var entidade = _repository.SelecionarPorId(id.Value);
            if (entidade == null)
                return HttpNotFound();

            return View(Mapper.Map<TEntidade, TViewModel>(entidade));
        }

        // POST: MotivoAcionamen/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit(/*[Bind(Include = "Id,Nome")]*/ TViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var motAcionamen = Mapper.Map<TViewModel, TEntidade>(viewModel);
                _repository.Alterar(motAcionamen);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: MotivoAcionamen/Delete/5
        public virtual ActionResult Delete(long? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var entidade = _repository.SelecionarPorId(id.Value);
            if (entidade == null)
                return HttpNotFound();

            return View(Mapper.Map<TEntidade, TExibicaoViewModel>(entidade));
        }

        // POST: MotivoAcionamen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual ActionResult DeleteConfirmed(long id)
        {
            _repository.ExcluirPorId(id);
            return RedirectToAction("Index");
        }
    }
}