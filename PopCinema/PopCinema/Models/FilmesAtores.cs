﻿using System;
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
        [Display(Name = "Movie")]
        [ForeignKey("Filme")]
        public int FilmeFK { get; set; }
        public virtual Filmes Filme { get; set; }

        [ForeignKey("Ator")]
        [Display(Name = "Actor")]
        public int AtorFK { get; set; }
        public virtual Atores Ator { get; set; }

        //atributos 
        [Display(Name = "Character")]
        [Required(ErrorMessage = "{0} required field! ")]
        public string Personagem { get; set; }


    }
}