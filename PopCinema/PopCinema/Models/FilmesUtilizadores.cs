﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PopCinema.Models
{
    public class FilmesUtilizadores
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Comment")]
        public string Comentario { get; set; }


        //public DateTime Data { get; set; }
        [Display(Name = "Movie")]
        [ForeignKey("Filme")]
        public int FilmeFK { get; set; }
        public virtual Filmes Filme { get; set; }

        [Display(Name = "User")]
        [ForeignKey("Utilizador")]
        public int UtilizadorFK { get; set; }
        public virtual Utilizadores Utilizador { get; set; }




    }
}