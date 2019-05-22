using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PopCinema.Models
{
	public class Categorias
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public string Nome { get; set; }
		//Relacao M-N
		// 1 Categoria pertence a n Filmes
		public virtual ICollection<Filmes> Filmes { get; set; }
	}
}