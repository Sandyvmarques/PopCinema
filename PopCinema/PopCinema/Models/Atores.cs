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
		//[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ID { get; set; }

		[Required(ErrorMessage = "The {0} is required.")]
		//[RegularExpression("[A-ZÍÉÂÁ][a-záéíóúàèìòùâêîôûãõçëüïäö]+" +
		//					"(( |'|-| e | da | dos | de | d')" +
		//					"[A-ZÍÉÂÁ][a-záéíóúàèìòùâêîôûãõçëüïäö]+){1,3}",
		//					ErrorMessage = "The {0} can only contain leters and spaces.Ex: Louis Lane")]
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
       
        /*// FK para o Filme
        [ForeignKey("Filmes")]
        public int FilmeFK { get; set; }
        public virtual Filmes Filmes { get; set; } */

    }
}