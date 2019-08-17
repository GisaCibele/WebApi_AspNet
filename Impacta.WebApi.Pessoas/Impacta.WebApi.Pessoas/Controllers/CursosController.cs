using Impacta.WebApi.Pessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Impacta.WebApi.Pessoas.Controllers
{
    public class CursosController : ApiController
    {
		static List<Curso> ListaCursos = new List<Curso>();

		public List<Curso> GetCursos()
		{
			return ListaCursos;
		}

		public Curso GetCurso(int Id)
		{
			var consultaCurso = from c in ListaCursos
								where c.Id.Equals(Id)
								select c;

			var res = ListaCursos.Where(x => x.Id.Equals(Id)).FirstOrDefault();

			if (consultaCurso.Count() <= 0)
			{
				return null;
			}
			else
			{
				return consultaCurso.First();
				}
			}

		public void PostCurso(Curso curso)
		{
			if (curso != null)
			{
				ListaCursos.Add(curso);
			}
		}

		public void PutCurso(int id, Curso curso)
		{
			if (curso != null && id > 0)
			{
				var result = ListaCursos.Where(x => x.Id.Equals(id)).FirstOrDefault();


				result.Nome = curso.Nome;
				result.CargaHoraria = curso.CargaHoraria;

				int posicao = ListaCursos.IndexOf(result);

				ListaCursos.RemoveAt(posicao);
				ListaCursos.Insert(posicao, curso);
			}
		}

		public List<Curso> DeleteCurso(int id)
		{
			if (id > 0)
			{
				ListaCursos.RemoveAt(
					ListaCursos.IndexOf(
						ListaCursos.Where(x => x.Id.Equals(id)).FirstOrDefault()
					));
			}
			return ListaCursos;
		} 
	}
 }
