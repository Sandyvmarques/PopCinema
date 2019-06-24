using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PopCinema.Models
{
	public class PopCinemaDB : DbContext
{
	public PopCinemaDB() : base("PopCinemaConnectionString") { }

		public virtual DbSet<Atores> Atores { get; set; } // tabela Atores
		public virtual DbSet<Filmes> Filmes { get; set; } // tabela Filmes
		public virtual DbSet<Categorias> Categorias { get; set; } // tabela Categorias
		public virtual DbSet<Utilizadores> Utilizadores { get; set; } // tabela Utilizadores
        public virtual DbSet<FilmesAtores> FilmesAtores { get; set; } // tabela de relação Filmes-Atores (Personagem)
        public virtual DbSet<FilmesUtilizadores> FilmesUtilizadores { get; set; } // tabela de relação Filmes-Utilizadores (Classificação)

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

		modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
		modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
		base.OnModelCreating(modelBuilder);
	}
	}
}