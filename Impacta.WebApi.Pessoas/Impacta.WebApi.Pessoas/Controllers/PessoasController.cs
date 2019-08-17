using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Impacta.WebApi.Pessoas.Models;

namespace Impacta.WebApi.Pessoas.Controllers
{
	public class PessoasController : ApiController
	{
		static List<Pessoa> pessoas = new List<Pessoa>();
		private string nomeDaPessoa;

		public PessoasController()
		{

		}

		public List<Pessoa> Get()
		{
			return pessoas;
		}

		public void Post(string nomeDaPassoa)
		{
			if (!string.IsNullOrEmpty(nomeDaPessoa))
			{
				pessoas.Add(new Pessoa { Nome = nomeDaPassoa });
			}
		}

		public void post(Pessoa pessoa)
		{
			if (pessoa != null)
			{
				pessoas.Add(pessoa);
			}
		}
	}
}
