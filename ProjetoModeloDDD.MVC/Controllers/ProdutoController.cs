using AutoMapper;
using ProjetModeloDDD.Dommain.Entities;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoAppService _produtoApp;
        private readonly IClienteAppService _clienteApp;

        public ProdutoController(IProdutoAppService produtoApp, IClienteAppService clienteApp)
        {
            _produtoApp = produtoApp;
            _clienteApp = clienteApp;
        }
        // GET: Produto
        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return View(produtoViewModel);
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {

            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            return View(produtoViewModel);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.ClienteID = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome");
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDommain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Add(produtoDommain);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteID = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome", produto.ClienteID);
            return  View (produto);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            ViewBag.ClienteID = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome");

            return View(produtoViewModel);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDommain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Update(produtoDommain);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteID = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome", produto.ClienteID);
            return ViewBag(produto);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        // POST: Produto/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (true)
            {
                var produto = _produtoApp.GetById(id);
                _produtoApp.Remove(produto);

                return RedirectToAction("Index");

            }
        }
    }
}
