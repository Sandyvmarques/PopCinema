using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PopCinema.Models
{
	public class Filmes
	{
		[Key]
		//[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ID { get; set; }
		[Required(ErrorMessage = "The {0} is required.")]
		public string Titulo { get; set; }
		[Required(ErrorMessage = "The {0} is required.")]
		public int Ano { get; set; }
		[Required(ErrorMessage = "The {0} is required.")]
		public string Sinopse { get; set; }
		
		public string Capa { get; set; }
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