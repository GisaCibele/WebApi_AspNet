using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.MOD
{
	public class Endereco
	{
		public int Id { get; set; }
		public String Logradouro { get; set; }
		public int Numero { get; set; }
		public String Complemento { get; set; }
		public String Cep { get; set; }
		public String Municipio { get; set; }
		public String UF { get; set; }

	}
}
