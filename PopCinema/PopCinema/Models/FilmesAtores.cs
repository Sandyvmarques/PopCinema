using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PopCinema.Models
{
    public class FilmesAtores
    {
        //chave primária
        [Key]
        public int ID { get; set; }

        //Foreign Keys
        [ForeignKey("Filmes")]
        public int FilmesFK { get; set; }
        public virtual Filmes Filmes { get; set; }

        [ForeignKey("Atores")]
        public int AtoresFK { get; set; }
        public virtual Atores Atores { get; set; }

        //atributos 
        [Required(ErrorMessage = "{0} required field! ")]
        public string Personagem { get; set; }


    }
}