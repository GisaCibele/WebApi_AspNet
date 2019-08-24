using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


namespace Impacta.Tarefas.ClientAPI
{
	class Program
	{
		static void Main(string[] args)
		{
			RunAsync().Wait();
		}


		static async Task RunAsync()
		{
			var formato = new MediaTypeWithQualityHeaderValue("application/json");

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("http://localhost:51317/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(formato);

				//HttpResponseMessage httpRes = new HttpResponseMessage();

				//JsonConvert

				var resposta = await client.GetAsync("api/WebApiEditora");
				var conteudo = await resposta.Content.ReadAsAsync<IEnumerable<Editora>>();
				foreach (var item in conteudo)
				{


					Console.WriteLine(
					string.Format(
						"EditoraID: {0}, Nome: {1}", item.EditoraId, item.Nome));
				}


			}

			Console.ReadLine();
		}
	}
}
 

