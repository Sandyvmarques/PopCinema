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
		public int ID { get; set; }

		[Required]
		public string Nome { get; set; }

		[Required]
		public string Username { get; set; }

		public string DataNascimento { get; set; }

		[Required]
		public string Email { get; set; }

		public string Foto { get; set; }
		//Relacoes M-N
		// 1 Utilizador classifica n Filmes
		public virtual ICollection<Filmes> Filmes { get; set; }
	}
}