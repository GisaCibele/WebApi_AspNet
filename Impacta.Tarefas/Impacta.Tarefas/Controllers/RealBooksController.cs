using Impacta.MOD;
using Impacta.Tarefas.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Impacta.Tarefas.Controllers
{

	
	public class RealBooksController : Controller
    {
        // GET: RealBooks
        public ActionResult Index()
			
        {
			return View();
			//criar um objeto do tipo business
			EditoraBUS editoraBus = new EditoraBUS();

			var listaEditora = editoraBus.ListarEditoras();
			//Retornamos a lista para a view que estara tipada para
			//receber uma lista de Editoras
            return View(listaEditora);
        }

		public ActionResult ListarNovasEditora()

		{
			try

			{
				EditoraBUS editoraBus = new EditoraBUS();

				var listaEditora = editoraBus.ListarEditoras();
				//Retornamos a lista para a view que estara tipada para
				//receber uma lista de Editoras
				return View(listaEditora);

			}

			catch (Exception)
			{
				throw;
			}


		}
			
		

		// GET: RealBooks/Details/5
		public ActionResult Details(int id)
        {
            return View();
        }
		[Authorize]
        // GET: RealBooks/Create
        public ActionResult Create()
        {

            return View();
        }
		[Authorize]
        // POST: RealBooks/Create
        [HttpPost]
        public ActionResult Create(Editora collection)
        {
            try
            {
				EditoraBUS editoraBus = new EditoraBUS();

				editoraBus.Salvar(collection);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

		// GET: RealBooks/Edit/5
		public ActionResult Edit(int id)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					ModelState.AddModelError("Editora", "Editora Invalida");
				}
				EditoraBUS objEditora = new EditoraBUS();
				var lst = objEditora.BuscarEditora(id);
				return View();
			}
			catch
			{
				return View();
			}
		}

        // POST: RealBooks/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Editora collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RealBooks/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RealBooks/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
