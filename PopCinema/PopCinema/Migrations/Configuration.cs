namespace PopCinema.Migrations
{
	using PopCinema.Models;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<PopCinema.Models.PopCinemaDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PopCinema.Models.PopCinemaDB context)
        {
			//*********************************************************************
			// adiciona Filmes
			var filmes = new List<Filmes> {
			new Filmes {ID=1, Titulo="Avengers: Endgame",Ano=2019, Sinopse="TaniaVieira.jpg" ,  Capa="Avengers: Endgame.jpg",Trailer="Avengers: EndgameVID"},
			new Filmes {ID=2, Titulo="Captain Marvel",   Ano=2019, Sinopse="AntonioRocha.jpg" , Capa="Captain Marvel.jpg",  Trailer="Captain MarvelVID"},
			new Filmes {ID=3, Titulo="Glass ",           Ano=2019, Sinopse="AndreSilveira.jpg" ,Capa="Glass .jpg",          Trailer="Glass VID"},
			new Filmes {ID=4, Titulo="Shazam",           Ano=2019, Sinopse="LurdesVieira.jpg" , Capa="Shazam.jpg",          Trailer="ShazamVID"},
			new Filmes {ID=5, Titulo="Hellboy",         Ano=2019, Sinopse="ClaudiaPinto.jpg" ,  Capa="Hellboy.jpg",         Trailer="HellboyVID"},
			new Filmes {ID=6, Titulo="Aquaman",         Ano=2018, Sinopse="RuiVieira.jpg" ,     Capa="Aquaman.jpg",         Trailer="AquamanVID"},
			new Filmes {ID=7, Titulo="Escape Room",     Ano=2019, Sinopse="PauloVieira.jpg" ,   Capa="Escape Room.jpg",     Trailer="Escape RoomVID"},
			new Filmes {ID=8, Titulo="Greta",           Ano=2019, Sinopse="AugustoCarvalho.jpg",Capa="Greta.jpg",           Trailer="GretaVID"},
			new Filmes {ID=9, Titulo="The Hustle",      Ano=2019, Sinopse="BeatrizPinto.jpg" ,  Capa="The Hustle.jpg",      Trailer="The HustleVID"},
			new Filmes {ID=10,Titulo="The Favourite",   Ano=2018, Sinopse="JoseAlves.jpg" ,     Capa="The Favourite.jpg",   Trailer="The FavouriteVID"},
		};
			filmes.ForEach(aa => context.Filmes.AddOrUpdate(a => a.Titulo, aa));
			context.SaveChanges();


			//*********************************************************************
			// adiciona Categorias
			var categorias = new List<Categorias> {
		   new Categorias {ID=1,    Nome="Comedy"},
		   new Categorias {ID=2,    Nome="Horror"},
		   new Categorias {ID=3,    Nome="Action"},
		   new Categorias {ID=4,    Nome="Drama"},
		   new Categorias {ID=5,    Nome="Thriler"},
		};
			categorias.ForEach(aa => context.Categorias.AddOrUpdate(a => a.Nome, aa));
			context.SaveChanges();


			//*********************************************************************
			// adiciona Utilizadores
			var utilizadores = new List<Utilizadores> {
		   new Utilizadores {ID=1, Nome="TaniaVieira",    Username="  TaniaVieira123",    DataNascimento="13/06/1981", Email="  TaniaVieira@hotmail.com",   Foto="  TaniaVieira.jpg"},
		   new Utilizadores {ID=2, Nome="AntonioRocha",   Username="  AntonioRocha123",   DataNascimento="30/06/1998" ,     Email="  AntonioRocha@hotmail.com",  Foto="  AntonioRocha.jpg"},
		   new Utilizadores {ID=3, Nome="AndreSilveira",  Username="  AndreSilveira123",  DataNascimento="21/12/1948", Email="  AndreSilveira@hotmail.com", Foto="  AndreSilveira.jpg"},
		   new Utilizadores {ID=4, Nome="LurdesVieira",   Username="  LurdesVieira123",   DataNascimento="30/06/1998" ,    Email="  LurdesVieira@hotmail.com",  Foto="  LurdesVieira.jpg"},
		};
			utilizadores.ForEach(aa => context.Utilizadores.AddOrUpdate(a => a.Nome, aa));
			context.SaveChanges();

			//*********************************************************************
			// adiciona Atores
			var atores = new List<Atores> {
			new Atores {ID=1,  Nome="Chris Evans ",
						Biografia ="Christopher Robert Evans is an American actor. Evans is known for his superhero roles as the Marvel Comics characters Captain America in the Marvel Cinematic Universe and Human Torch in Fantastic Four (2005) and its 2007 sequel.",
						Sexo="Masculino",   Nacionalidade="Washington, D.C., U.S.",
						DataNascimento="21/12/1948",FotoAtor ="  Samuel L. Jackson .jpg"},
			new Atores {ID=2,  Nome="Chris Hemsworth ",
						Biografia ="Christopher Hemsworth is an Australian actor. He rose to prominence playing Kim Hyde in the Australian TV series Home and Away (2004–07). Hemsworth has also appeared in the science fiction action film Star Trek (2009), the thriller(2013). ",
						Sexo="Masculino",   Nacionalidade="Washington, D.C., U.S.",
						DataNascimento ="21/12/1948",FotoAtor ="  Samuel L. Jackson .jpg"},
			new Atores {ID=3,  Nome="Samuel L. Jackson ",
						Biografia ="Samuel Leroy Jackson (born December 21, 1948) is an American actor and film producer. A recipient of critical acclaim and numerous accolades and awards, Jackson is the actor whose films have made the highest total gross revenue.arantino ",
						Sexo="Masculino",   Nacionalidade="Washington, D.C., U.S.",
						DataNascimento="21/12/1948", FotoAtor ="  Samuel L. Jackson .jpg"},
			new Atores {ID=4,  Nome="Brie Larson ",
						Biografia ="Brianne Sidonie Desaulniers (born October 1, 1989), known professionally as Brie Larson, is an American actress and filmmaker. Noted for her supporting work in comedies when a teenager, she has since expanded to leading roles in independent019.",
						Sexo="Masculino",   Nacionalidade="Washington, D.C., U.S.",
						DataNascimento="21/12/1948",FotoAtor ="  Samuel L. Jackson .jpg"},
			new Atores {ID=5,  Nome="James McAvoy ",
						Biografia ="James McAvoy (/ˈmækəvɔɪ/; born 21 April 1979) is a Scottish actor. He made his acting debut as a teen in The Near Room (1995) and made mostly television appearances until 2003, when his feature film career began. His notable television workistmas. ",
						Sexo="Masculino",   Nacionalidade="Glasgow, Scotland[1",
						DataNascimento="21/04/1979",FotoAtor ="  James McAvoy .jpg"},
			new Atores {ID=6,  Nome="Bruce Willis ",
						Biografia ="Walter Bruce Willis (born March 19, 1955) is an American actor, producer, and singer. Born to a German mother and American father in Idar-Oberstein, Germany, he moved to the United States with his family in 1957. His career began on the Off-–2013), aoles. ",
						Sexo="Masculino",   Nacionalidade="Idar-Oberstein, Rhineland-Palatinate, West Germany",
						DataNascimento="19/03/1955",FotoAtor ="  Bruce Willis .jpg"},
			new Atores {ID=7,  Nome="Zachary Levi",
						Biografia ="Zachary Levi (born Zachary Levi Pugh; September 29, 1980)[1] is an American actor and singer. He received critical acclaim for starring as Cheived a Tony Award nomination. He voiced Flynn Rider in the 2010 animated film Tangled, in which he performed the duet ",
						Sexo="Masculino",   Nacionalidade="Lake Charles, Louisiana, U.S",
						DataNascimento ="29/09/1980",FotoAtor ="  Zachary Levi.jpg"},
			new Atores {ID=8,  Nome="Asher Angel",
						Biografia ="Asher Dov Angel[1] (born September 6, 2002[2]) is an American actor. He began his career as a child actor in the 2008 film Jolene, starring Jessica Chastain. He is known for his role aerse film Shazam! ",
						Sexo="Masculino",   Nacionalidade="Phoenix, Arizona, U.S.",
						DataNascimento ="29/09/1980",FotoAtor ="  Zachary Levi.jpg"},
			new Atores {ID=9,  Nome="Ron Perlman",
						Biografia ="Ronald Perlman (born April 13, 1950) is an American actor and voice actor. He played the role of Vincent on the television series Beauty and the Beast (1987–1990), for which he won a Golden Globe Award, the comic book character Hellboy in both Hellboy (2004).",
						Sexo="Masculino",Nacionalidade="Washington Heights, New York, U.S.",
						DataNascimento ="13/04/1950",FotoAtor="  Ron Perlman.jpg"},
			new Atores {ID=10, Nome="Selma Blair",
						Biografia ="Selma Blair Beitner (born June 23, 1972) is an American actress. She played a number of small roles in films and on television before obtaining recognition for her leading role in the film Brown's Requiem (1998). Her breakthrough came when she",
						Sexo="Feminino",Nacionalidade="Southfield, Michigan, U.S.",
						DataNascimento ="23/06/1972",FotoAtor="  Selma Blair.jpg"},
			new Atores {ID=11, Nome="Jason Momoa",
						Biografia ="Joseph Jason Namakaeha Momoa (born August 1, 1979) is an American actor. He played Aquaman in the DC Extended Universe, beginning with the 2016 superhero film e CBC series Frontier (2016–present).",
						Sexo="Masculino",Nacionalidade="Nānākuli, Honolulu, Hawaii, U.S.",
						DataNascimento ="28863",     FotoAtor="  Jason Momoa.jpg"},
			new Atores {ID=12, Nome="Amber Heard",
						Biografia ="Joseph Jason Namakaeha Momoa (born August 1, 1979) is an American actor. He played Aquaman in the DC Extended Universe, beginning with the 2016 superhero film Batman v Superman: Dawn of Justice, and in the 2e CBC series Frontier (2016–present).",
						Sexo="Masculino",Nacionalidade="Washington, D.C., U.S.",
						DataNascimento ="21/12/1948",FotoAtor="  Samuel L. Jackson .jpg"},
			new Atores {ID=13, Nome="Taylor Russell",
						Biografia ="Taylor Russell (born July 18, 1994) is a Canadian actress. She is known for her recurring roles in the television series Strange Empire and Falling Skies.[1] As of 2018, she stars as Judy Robinson in Lost in Space, the Netfli ",
						Sexo="Feminino",Nacionalidade="Vancouver, British Columbia, Canada",
						DataNascimento ="18/07/1994",FotoAtor="  Taylor Russell.jpg"},
			new Atores {ID=14, Nome="Logan Miller",
						Biografia ="Logan Miller (born c. 1992) is an American actor.",
						Sexo="Feminino",Nacionalidade="Vancouver, British Columbia, Canada",
						DataNascimento ="18/07/1994",FotoAtor="  Taylor Russell.jpg"},
			new Atores {ID=15, Nome="Chloë Grace Moretz",
						Biografia ="Chloë Grace Moretz (/məˈrɛts/;[2] born February 10, 1997) is an American actress and model. She began acting at age six, with early roles in the supernatural horror film The Amityville Horror (2005), the drama series Desperate Housewives (2006–07),), ",
						Sexo="Feminino",Nacionalidade="Atlanta, Georgia, U.S.",
						DataNascimento ="36134",     FotoAtor="  Chloë Grace Moretz.jpg"},
			new Atores {ID=16, Nome="Isabelle Huppert ",
						Biografia ="Isabelle Anne Madeleine Huppert (French pronunciation: ​[izabɛl yˈpɛʁ]; born 16 March 1953) is a French actress who has appeared in more than 120 films since her debut in 1971. She is the most nominated actress for the d was promoted to Officer in 2009",
						Sexo="Feminino",Nacionalidade="Paris, France",
						DataNascimento ="23/06/1940",FotoAtor="  Isabelle Huppert .jpg"},
			new Atores {ID=17, Nome="Anne Hathaway",
						Biografia ="Anne Jacqueline Hathaway (born November 12, 1982) is an American actress and singer. One of the world's highest-paid actresses in 2015, she has received multiple awards, including an Academy Award, a Golden Globe, a British Academy Film ",
						Sexo="Feminino",Nacionalidade="Paris, France",
						DataNascimento ="23/06/1979",FotoAtor="  Anne Hathaway.jpg"},
			new Atores {ID=18, Nome="Rebel Wilson.",
						Biografia ="Isabelle Anne Madeleine Huppert (French pronunciation: ​[izabɛl yˈpɛʁ]; born 16 March 1953) is a French actress who has appeared in more than 120 films since her debut in 1971. She is the most nominated actress for the César Award, with 16 ",
						Sexo="Feminino",Nacionalidade="Paris, France",
						DataNascimento ="23/06/1980",FotoAtor="  Rebel Wilson..jpg"},
			new Atores {ID=19, Nome="Olivia Colman",
						Biografia ="Anne Jacqueline Hathaway (born November 12, 1982) is an American actress and singer. One of the world's highest-paid actresses in 2015, she has received multiple awards, including an Academy Award, a Golden Globe, a British Academy . ",
						Sexo="Feminino",Nacionalidade="Paris, France",
						DataNascimento ="23/06/1981",FotoAtor="  Olivia Colman.jpg"},
			new Atores {ID=20, Nome="Emma Stone",
						Biografia ="Isabelle Anne Madeleine Huppert (French pronunciation: ​[izabɛl yˈpɛʁ]; born 16 March 1953) is a French actress who has appeared in more than 120 films since her debut in 1971. She is the most nominated actress for the César Award, with",
						Sexo="Feminino",Nacionalidade="Paris, France",
						DataNascimento ="23/06/1982",FotoAtor="  Emma Stone.jpg"},
		};
			atores.ForEach(aa => context.Atores.AddOrUpdate(a => a.Nome, aa));
			context.SaveChanges();


		}
	}
}
