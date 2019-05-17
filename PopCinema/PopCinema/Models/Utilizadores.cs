using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PopCinema.Models
{
	public class Utilizadores
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Nome { get; set; }

		[Required]
		public string UserName { get; set; }

		public DateTime DataNascimento { get; set; }

		[Required]
		public string Email { get; set; }

		public string FotoUtilizador { get; set; }
		//Relacoes M-N
		// 1 Utilizador classifica n Filmes
		public virtual ICollection<Filmes> Filmes { get; set; }
	}
}