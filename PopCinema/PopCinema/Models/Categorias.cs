using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PopCinema.Models
{
	public class Categorias
	{
		[Key]
		//[DatabaseGenerated(DatabaseGeneratedOption.None)]
		//anotador que enibe a hipótese do ID ser auto number
		public int ID { get; set; }


		[Required(ErrorMessage = "The {0} is required.")]
		[RegularExpression("[A-ZÍÉÂÁ][a-záéíóúàèìòùâêîôûãõçëüïäö]+" +
							"(( |'|-| e | da | dos | de | d')" +
							"[A-ZÍÉÂÁ][a-záéíóúàèìòùâêîôûãõçëüïäö]+){1,3}",
							ErrorMessage = "The {0} can only contain leters and spaces.Ex: Louis Lane")]
		public string Nome { get; set; }
		//Relacao M-N
		// 1 Categoria pertence a n Filmes
		public virtual ICollection<Filmes> Filmes { get; set; }
	}
}