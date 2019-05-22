using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PopCinema.Models
{
	public class Atores
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public string Nome { get; set; }
		[Required]
		public String Biografia { get; set; }
		public String Sexo { get; set; }
		public String Nacionalidade { get; set; }
		public string DataNascimento { get; set; }
		[Required]
		public String FotoAtor { get; set; }
		//Relacao M-N
		// 1 Ator participa em n Filmes
		public virtual ICollection<Filmes> Filmes { get; set; }

	}
}