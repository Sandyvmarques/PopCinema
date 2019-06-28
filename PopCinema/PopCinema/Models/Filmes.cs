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
        public Filmes() {
            ListaAtores = new HashSet<FilmesAtores>();

            ListaCategorias = new HashSet<Categorias>();

            ListaClassificacao = new HashSet<FilmesUtilizadores>();

        }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
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
        [Display(Name = "Categories")]
        public virtual ICollection<Categorias> ListaCategorias { get; set; }
        // 1 filme tem n Atores
        [Display(Name = "Cast")]
        public virtual ICollection<FilmesAtores> ListaAtores { get; set; }
        // 1 filme tem n Utilizadores
        public virtual ICollection<FilmesUtilizadores> ListaClassificacao { get; set; }
    }
}