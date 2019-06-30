using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PopCinema.Models
{
	public class Utilizadores
	{

        public Utilizadores() {
            ListaClassificacoes = new HashSet<FilmesUtilizadores>();
        }
		[Key]
		public int ID { get; set; }

		/*[RegularExpression("[A-ZÍÉÂÁ][a-záéíóúàèìòùâêîôûãõçëüïäö]+" +
								"(( |'|-| e | da | dos | de | d')" +
								"[A-ZÍÉÂÁ][a-záéíóúàèìòùâêîôûãõçëüïäö]+){1,3}",
								ErrorMessage = "The {0} can only contain leters and spaces.Ex: Louis Lane")]
		*/public string Nome { get; set; }

		//([Required(ErrorMessage = "The {0} is required.")]
		public string Username { get; set; }

       
        public DateTime DataNascimento { get; set; }

		//[Required(ErrorMessage = "The {0} is required.")]
		public string Email { get; set; }

		
		//Relacoes M-N
		// 1 Utilizador classifica n Filmes
		public virtual ICollection<FilmesUtilizadores> ListaClassificacoes { get; set; }
	}
}