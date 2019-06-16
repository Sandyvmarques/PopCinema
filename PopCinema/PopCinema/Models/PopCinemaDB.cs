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

		public virtual DbSet<Atores> Atores { get; set; } // tabela Multas
		public virtual DbSet<Filmes> Filmes { get; set; } // tabela Condutores
		public virtual DbSet<Categorias> Categorias { get; set; } // tabela Agentes
		public virtual DbSet<Utilizadores> Utilizadores { get; set; } // tabela Viaturas
        public virtual DbSet<FilmesAtores> FilmesAtores { get; set; } // tabela Viaturas

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

		modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
		modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
		base.OnModelCreating(modelBuilder);
	}
	}
}