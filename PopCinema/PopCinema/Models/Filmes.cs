using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PopCinema.Models
{
	public class Filmes
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public string Titulo { get; set; }
		[Required]
		public int Ano { get; set; }
		[Required]
		public string Sinopse { get; set; }
		[Required]
		public string Capa { get; set; }
		[Required]
		public string Trailer { get; set; }
		//Relacoes M-N
		// 1 filme tem n Categorias
		public virtual ICollection<Categorias> Categorias { get; set; }
		// 1 filme tem n Atores
		public virtual ICollection<Atores> Atores { get; set; }
		// 1 filme tem n Utilizadores
		public virtual ICollection<Utilizadores> Utilizadores { get; set; }

	}
}