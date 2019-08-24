using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Impacta.Tarefas.Business;
using Impacta.MOD;

namespace Imapacta.Tarefas.Webapi.Controllers
{
	public class WebApiEditoraController : ApiController
	{
		public EditoraBUS editora { get; private set; }

		// GET: api/WebApiEditora
		public IEnumerable<Editora> Get()
		{
			EditoraBUS editora;
			editora = new EditoraBUS();
			var lista = editora.ListarEditoras();

			return lista;
		}

		// GET: api/WebApiEditora/5
		public Editora Get(int id)
		{
			editora = new EditoraBUS();
			
			var result = editora.BuscarEditora(id);

			return result;
		}

		// POST: api/WebApiEditora
		public void Post(Editora objEditora)
		{
			editora = new EditoraBUS();
			editora.Salvar(objEditora);
		}

		// PUT: api/WebApiEditora/5
		public void Put(int id, Editora objEditora)
		{
			editora = new EditoraBUS();

			editora.Salvar(objEditora);
		}

		// DELETE: api/WebApiEditora/5
		public void Delete(int id)
		{
			editora = new EditoraBUS();

			editora.Excluir(id);
		}
	}
}
