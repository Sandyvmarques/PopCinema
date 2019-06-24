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
        public Categorias()
        {
            ListaFilmes = new HashSet<Filmes>();
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //anotador que enibe a hipótese do ID ser auto number
        [Key]
		public int ID { get; set; }


		[Required(ErrorMessage = "The {0} is required.")]
		[RegularExpression("[A-Z][a-z]+( [A-Z][a-z]+)*",
							ErrorMessage = "The {0} can only contain leters and spaces.Ex: Louis Lane")]
		public string Nome { get; set; }
		//Relacao M-N
		// 1 Categoria pertence a n Filmes
		public virtual ICollection<Filmes> ListaFilmes { get; set; }
	}
}