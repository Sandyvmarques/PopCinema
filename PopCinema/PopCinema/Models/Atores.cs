using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PopCinema.Models
{
	public class Atores
	{

        public Atores() {
            ListaPersonagens = new HashSet<FilmesAtores>();
        }

		[Key]
		public int ID { get; set; }

		[Required(ErrorMessage = "The {0} is required.")]
	
		public string Nome { get; set; }

		[Required(ErrorMessage = "The {0} is required.")]
		public String Biografia { get; set; }

		[Required(ErrorMessage = "The {0} is required.")]
		public String Sexo { get; set; }

		[Required(ErrorMessage = "The {0} is required.")]
		public String Nacionalidade { get; set; }

		[Required(ErrorMessage = "The {0} is required.")]
		public string DataNascimento { get; set; }

		[Required(ErrorMessage = "The {0} is required.")]
		public String FotoAtor { get; set; }

		//Relacao M-N
		// 1 Ator participa em n Filmes
		public virtual ICollection<FilmesAtores> ListaPersonagens { get; set; }


    }
}