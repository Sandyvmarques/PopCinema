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
		public int Id { get; set; }
		[Required]
		public string NomeAtor { get; set; }
		[Required]
		public String Biografia { get; set; }
		public String Sexo { get; set; }
		public String Nacionalidade { get; set; }
		public DateTime DataNascimento { get; set; }
		[Required]
		public String FotoAtor { get; set; }
		//Relacao M-N
		// 1 Ator participa em n Filmes
		public virtual ICollection<Filmes> Filmes { get; set; }

	}
}