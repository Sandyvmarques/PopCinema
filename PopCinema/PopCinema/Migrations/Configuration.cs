namespace PopCinema.Migrations
{
	using PopCinema.Models;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<PopCinema.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

        }

        protected override void Seed(PopCinema.Models.ApplicationDbContext context)
        {
            
                //*********************************************************************
                // adiciona Filmes
                var filmes = new List<Filmes> {
                    new Filmes {Titulo="Avengers:Endgame",    Ano=2019, Sinopse="After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe." ,	Capa="AvengersEndgame.jpg",Trailer="https://www.youtube.com/embed/TcMBFSGVi1c"},
                    new Filmes {Titulo="Captain Marvel",      Ano=2019, Sinopse="Carol Danvers becomes one of the universe's most powerful heroes when Earth is caught in the middle of a galactic war between two alien races." ,																							Capa="CaptainMarvel.jpg",  Trailer="https://www.youtube.com/embed/Z1BCujX3pw8"},
                    new Filmes {Titulo="Glass ",              Ano=2019, Sinopse="Security guard David Dunn uses his supernatural abilities to track Kevin Wendell Crumb, a disturbed man who has twenty-four personalities." ,																								Capa="Glass.jpg",          Trailer="https://www.youtube.com/embed/95ghQs5AmNk"},
                    new Filmes {Titulo="Shazam",              Ano=2019, Sinopse="We all have a superhero inside us, it just takes a bit of magic to bring it out. In Billy Batson's case, by shouting out one word - SHAZAM. - this streetwise fourteen-year-old foster kid can turn into the grown-up superhero Shazam." ,	Capa="Shazam.jpg",         Trailer="https://www.youtube.com/embed/go6GEIrcvFY"},
                    new Filmes {Titulo="Hellboy",             Ano=2019, Sinopse="Based on the graphic novels by Mike Mignola, Hellboy, caught between the worlds of the supernatural and human, battles an ancient sorceress bent on revenge." ,																			Capa="Hellboy.jpg",        Trailer="https://www.youtube.com/embed/JKwEXCgROtc"},
                    new Filmes {Titulo="Aquaman",             Ano=2018, Sinopse="Arthur Curry, the human-born heir to the underwater kingdom of Atlantis, goes on a quest to prevent a war between the worlds of ocean and land." ,																							Capa="Aquaman.jpg",        Trailer="https://www.youtube.com/embed/WDkg3h8PCVU"},
                    new Filmes {Titulo="Escape Room",         Ano=2019, Sinopse="Six strangers find themselves in a maze of deadly mystery rooms and must use their wits to survive." ,																																		Capa="EscapeRoom.jpg",     Trailer="https://www.youtube.com/embed/6dSKUoV0SNI"},
                    new Filmes {Titulo="Greta",               Ano=2019, Sinopse="A young woman befriends a lonely widow who's harboring a dark and deadly agenda toward her.",																																				Capa="Greta.jpg",          Trailer="https://www.youtube.com/embed/WAEoJkL_8zU"},
                    new Filmes {Titulo="The Hustle",          Ano=2019, Sinopse="Anne Hathaway and Rebel Wilson star as female scam artists, one low rent and the other high class, who team up to take down the men who have wronged them." ,																				Capa="TheHustle.jpg",      Trailer="https://www.youtube.com/embed/_j5hwooOHVE"},
                    new Filmes {Titulo="The Favourite",       Ano=2018, Sinopse="In early 18th century England, a frail Queen Anne occupies the throne and her close friend, Lady Sarah, governs the country in her stead. When a new servant, Abigail, arrives, her charm endears her to Sarah." ,							Capa="TheFavourite.jpg",   Trailer="https://www.youtube.com/embed/SYb-wkehT1g"},
                };                                                                                                                                                                                                                                                                                                                           
                filmes.ForEach(aa => context.Filmes.AddOrUpdate(a => a.ID, aa));
                context.SaveChanges();


                //*********************************************************************
                // adiciona Categorias
                var categorias = new List<Categorias> {
                   new Categorias {Nome="Comedy",    ListaFilmes= new List<Filmes>{ filmes[3], filmes[8]}},
                   new Categorias {Nome="Horror",    ListaFilmes= new List<Filmes>{ filmes[6] } },
                   new Categorias {Nome="Action",	 ListaFilmes= new List<Filmes>{ filmes[0], filmes[1], filmes[3], filmes[4], filmes[5], filmes[6] } },
				   new Categorias {Nome="Drama",	 ListaFilmes= new List<Filmes>{ filmes[2], filmes[7], filmes[9] } },
                   new Categorias {Nome="Adventure", ListaFilmes= new List<Filmes>{ filmes[0], filmes[1], filmes[3], filmes[4], filmes[5], filmes[6]}},
                   new Categorias {Nome="Biography" ,ListaFilmes= new List<Filmes>{ filmes[9]}},
                   new Categorias {Nome="Crime" ,	 ListaFilmes= new List<Filmes>{ filmes[8]}},
                   new Categorias {Nome="History",   ListaFilmes= new List<Filmes>{ filmes[9]}},
                   new Categorias {Nome="Fantasy",   ListaFilmes= new List<Filmes>{filmes[4], filmes[5] } },
                   new Categorias {Nome="Mystery",   ListaFilmes= new List<Filmes>{ filmes[7]}},
                   new Categorias {Nome="Thriller",  ListaFilmes= new List<Filmes>{ filmes[2], filmes[7]}},
                };
                categorias.ForEach(aa => context.Categorias.AddOrUpdate(a => a.Nome, aa));
                context.SaveChanges();


                //*********************************************************************
                // adiciona Utilizadores
                var utilizadores = new List<Utilizadores> {
				   new Utilizadores {Nome="Administrator",      Username="  admin",             DataNascimento=new DateTime(1995,7,2),		    Email="  admin@mail.pt"},
				   new Utilizadores {Nome="Utilizador1",        Username="  util1",             DataNascimento=new DateTime(1995,7,2) ,         Email="  util1@mail.pt"},
				   new Utilizadores {Nome="Utilizador2",        Username="  util2",             DataNascimento=new DateTime(1995,7,2),		    Email="  util2@mail.pt"},
				   new Utilizadores {Nome="Utilizador3",        Username="  util3",             DataNascimento=new DateTime(1995,7,2) ,         Email="   util3@mail.pt"},
				};
                utilizadores.ForEach(aa => context.Utilizadores.AddOrUpdate(a => a.ID, aa));
                context.SaveChanges();

           /* var storeR = new RoleStore<IdentityRoles>(context);
            var managerR = new RoleManager<IdentityRoles>(storeR);

            if (!managerR.Roles.Any(r => r.Name == "Admin")) {

                var role = new IdentityRole { Name = "Admin" };

                managerR.Create(role);

            }

            if (!managerR.Roles.Any(r.Name == "Viewer")) {

                var role = new IdentityRole { Name = "Viewr" };

                managerR.Create(role);
            }

            /////////////////////////// USERS ///////////////////////////////////
            ///
            var store = new UseStore<ApplicationUser>(context);
            var manager = new UserManager<ApplicationUser>(store);

            /////////////////////////// ADMIN ///////////////////////////////////
            ///
            var us = utilizadores[0]; //Primeiro utilizador do seed da tabela de Users 
            if (!context.Utilizadores.Any(u => u.UserName == us.Email)) {

                var u = new ApplicationUser
                {

                    UserName = us.Email,
                    Email = us.Email
                };

                manager.Create(u, "123Querty#"); //Palavra passe do admin
                manager.AddToRole(u.Id, "Admin");

            }

            //Os restantes users são views da aplicação web 
            for (int i = 1; i < utilizadores.Count(); i++) {
                var us2 = utilizadores[i];
                if (!context.Utilizadores.Any(u => u.UserName == us2.Email)) {
                    var u = new ApplicationUser
                    {
                        UserName = us2.Email,
                        Email = us2.Email
                    };

                    manager.Create(u, "123Querty#");
                    manager.AddToRole(u.Id, "Viewer");
                }

            }

    */






            //*********************************************************************
            // adiciona Atores
            var atores = new List<Atores> {
					new Atores {ID=0,
								Nome ="Chris Evans",
								Biografia ="Christopher Robert Evans is an American actor. Evans is known for his superhero roles as the Marvel Comics characters Captain America in the Marvel Cinematic Universe and Human Torch in Fantastic Four (2005) and its 2007 sequel.",
								Sexo="Masculino",
								Nacionalidade ="Washington, D.C., U.S.",
								DataNascimento="21/12/1948",
								FotoAtor ="ChrisEvans.jpg"},
					new Atores {ID=1,
								Nome ="Chris Hemsworth",
								Biografia ="Christopher Hemsworth is an Australian actor. He rose to prominence playing Kim Hyde in the Australian TV series Home and Away (2004–07). Hemsworth has also appeared in the science fiction action film Star Trek (2009), the thriller(2013). ",
								Sexo="Masculino",
								Nacionalidade ="Washington, D.C., U.S.",
								DataNascimento ="21/12/1948",
								FotoAtor ="ChrisHemsworth.jpg"},
					new Atores {ID=2,
								Nome ="Samuel L. Jackson",
								Biografia ="Samuel Leroy Jackson (born December 21, 1948) is an American actor and film producer. A recipient of critical acclaim and numerous accolades and awards, Jackson is the actor whose films have made the highest total gross revenue.arantino ",
								Sexo="Masculino",
								Nacionalidade ="Washington, D.C., U.S.",
								DataNascimento="21/12/1948",
								FotoAtor ="SamuelLJackson.jpg"},
					new Atores {ID=3,
								Nome ="Brie Larson",
								Biografia ="Brianne Sidonie Desaulniers (born October 1, 1989), known professionally as Brie Larson, is an American actress and filmmaker. Noted for her supporting work in comedies when a teenager, she has since expanded to leading roles in independent019.",
								Sexo="Masculino",
								Nacionalidade ="Washington, D.C., U.S.",
								DataNascimento="21/12/1948",
								FotoAtor ="BrieLarson.jpg"},
					new Atores {ID=4,
								Nome ="James McAvoy",
								Biografia ="James McAvoy (/ˈmækəvɔɪ/; born 21 April 1979) is a Scottish actor. He made his acting debut as a teen in The Near Room (1995) and made mostly television appearances until 2003, when his feature film career began. His notable television workistmas. ",
								Sexo="Masculino",
								Nacionalidade ="Glasgow, Scotland[1",
								DataNascimento="21/04/1979",
								FotoAtor ="JamesMcAvoy.jpg" },
					new Atores {ID=5,
								Nome ="Bruce Willis ",
								Biografia ="Walter Bruce Willis (born March 19, 1955) is an American actor, producer, and singer. Born to a German mother and American father in Idar-Oberstein, Germany, he moved to the United States with his family in 1957. His career began on the Off-–2013), aoles. ",
								Sexo="Masculino",
								Nacionalidade ="Idar-Oberstein, Rhineland-Palatinate, West Germany",
								DataNascimento="19/03/1955",
								FotoAtor ="BruceWillis.jpg" },
					new Atores {ID=6,
								Nome ="Zachary Levi",
								Biografia ="Zachary Levi (born Zachary Levi Pugh; September 29, 1980)[1] is an American actor and singer. He received critical acclaim for starring as Cheived a Tony Award nomination. He voiced Flynn Rider in the 2010 animated film Tangled, in which he performed the duet ",
								Sexo="Masculino",
								Nacionalidade ="Lake Charles, Louisiana, U.S",
								DataNascimento ="29/09/1980",
								FotoAtor ="ZacharyLevi.jpg"},
					new Atores {ID=7,
								Nome ="Asher Angel",
								Biografia ="Asher Dov Angel[1] (born September 6, 2002[2]) is an American actor. He began his career as a child actor in the 2008 film Jolene, starring Jessica Chastain. He is known for his role aerse film Shazam! ",
								Sexo="Masculino",
								Nacionalidade ="Phoenix, Arizona, U.S.",
								DataNascimento ="29/09/1980",
								FotoAtor ="AsherAngel.jpg"},
					new Atores {ID=8,
								Nome ="Ron Perlman",
								Biografia ="Ronald Perlman (born April 13, 1950) is an American actor and voice actor. He played the role of Vincent on the television series Beauty and the Beast (1987–1990), for which he won a Golden Globe Award, the comic book character Hellboy in both Hellboy (2004).",
								Sexo="Masculino",
								Nacionalidade ="Washington Heights, New York, U.S.",
								DataNascimento ="13/04/1950",
								FotoAtor ="RonPerlman.jpg"},
					new Atores {ID=9,
								Nome ="Selma Blair",
								Biografia ="Selma Blair Beitner (born June 23, 1972) is an American actress. She played a number of small roles in films and on television before obtaining recognition for her leading role in the film Brown's Requiem (1998). Her breakthrough came when she",
								Sexo="Feminino",
								Nacionalidade ="Southfield, Michigan, U.S.",
								DataNascimento ="23/06/1972",
								FotoAtor ="SelmaBlair.jpg"},
					new Atores {ID=10,
								Nome ="Jason Momoa",
								Biografia ="Joseph Jason Namakaeha Momoa (born August 1, 1979) is an American actor. He played Aquaman in the DC Extended Universe, beginning with the 2016 superhero film e CBC series Frontier (2016–present).",
								Sexo="Masculino",
								Nacionalidade ="Nānākuli, Honolulu, Hawaii, U.S.",
								DataNascimento ="28863",
								FotoAtor ="JasonMomoa.jpg"},
					new Atores {ID=11,
								Nome ="Amber Heard",
								Biografia ="Joseph Jason Namakaeha Momoa (born August 1, 1979) is an American actor. He played Aquaman in the DC Extended Universe, beginning with the 2016 superhero film Batman v Superman: Dawn of Justice, and in the 2e CBC series Frontier (2016–present).",
								Sexo="Masculino",
								Nacionalidade ="Washington, D.C., U.S.",
								DataNascimento ="21/12/1948",
								FotoAtor ="AmberHeard.jpg"},
					new Atores {ID=12,
								Nome ="Taylor Russell",
								Biografia ="Taylor Russell (born July 18, 1994) is a Canadian actress. She is known for her recurring roles in the television series Strange Empire and Falling Skies.[1] As of 2018, she stars as Judy Robinson in Lost in Space, the Netfli ",
								Sexo="Feminino",
								Nacionalidade ="Vancouver, British Columbia, Canada",
								DataNascimento ="18/07/1994",
								FotoAtor ="TaylorRussell.jpg"},
					new Atores {ID=13,
								Nome ="Logan Miller",
								Biografia ="Logan Miller (born c. 1992) is an American actor.",
								Sexo="Feminino",
								Nacionalidade ="Vancouver, British Columbia, Canada",
								DataNascimento ="18/07/1994",
								FotoAtor ="LoganMiller.jpg"},
					new Atores {ID=14,
								Nome ="Chloë Grace Moretz",
								Biografia ="Chloë Grace Moretz (/məˈrɛts/;[2] born February 10, 1997) is an American actress and model. She began acting at age six, with early roles in the supernatural horror film The Amityville Horror (2005), the drama series Desperate Housewives (2006–07),), ",
								Sexo="Feminino",
								Nacionalidade ="Atlanta, Georgia, U.S.",
								DataNascimento ="36134",
								FotoAtor ="ChloëMoretz.jpg"},
					new Atores {ID=15,
								Nome ="Isabelle Huppert ",
								Biografia ="Isabelle Anne Madeleine Huppert (French pronunciation: ​[izabɛl yˈpɛʁ]; born 16 March 1953) is a French actress who has appeared in more than 120 films since her debut in 1971. She is the most nominated actress for the d was promoted to Officer in 2009",
								Sexo="Feminino",
								Nacionalidade ="Paris, France",
								DataNascimento ="23/06/1940",
								FotoAtor ="IsabelleHuppert.jpg"},
					new Atores {ID=16,
								Nome ="Anne Hathaway",
								Biografia ="Anne Jacqueline Hathaway (born November 12, 1982) is an American actress and singer. One of the world's highest-paid actresses in 2015, she has received multiple awards, including an Academy Award, a Golden Globe, a British Academy Film ",
								Sexo="Feminino",
								Nacionalidade ="Paris, France",
								DataNascimento ="23/06/1979",
								FotoAtor ="AnneHathaway.jpg"},
					new Atores {ID=17,
								Nome ="Rebel Wilson.",
								Biografia ="Isabelle Anne Madeleine Huppert (French pronunciation: ​[izabɛl yˈpɛʁ]; born 16 March 1953) is a French actress who has appeared in more than 120 films since her debut in 1971. She is the most nominated actress for the César Award, with 16 ",
								Sexo="Feminino",
								Nacionalidade ="Paris, France",
								DataNascimento ="23/06/1980",
								FotoAtor ="RebelWilson.jpg"},
					new Atores {ID=18,
								Nome ="Olivia Colman",
								Biografia ="Anne Jacqueline Hathaway (born November 12, 1982) is an American actress and singer. One of the world's highest-paid actresses in 2015, she has received multiple awards, including an Academy Award, a Golden Globe, a British Academy . ",
								Sexo="Feminino",
								Nacionalidade ="Paris, France",
								DataNascimento ="23/06/1981",
								FotoAtor ="OliviaColman.jpg"},
					new Atores {ID=19,
								Nome ="Emma Stone",
								Biografia ="Isabelle Anne Madeleine Huppert (French pronunciation: ​[izabɛl yˈpɛʁ]; born 16 March 1953) is a French actress who has appeared in more than 120 films since her debut in 1971. She is the most nominated actress for the César Award, with",
								Sexo="Feminino",
								Nacionalidade ="Paris, France",
								DataNascimento ="23/06/1982",
								FotoAtor ="EmmaStone.jpg"},
				};
                atores.ForEach(aa => context.Atores.AddOrUpdate(a => a.ID, aa));
                context.SaveChanges();


                var filmesAtores = new List<FilmesAtores>
                   {
					new FilmesAtores {Ator=atores[0],  Filme=filmes[0], Personagem="Captain America"},
					new FilmesAtores {Ator=atores[1],  Filme=filmes[0], Personagem="Thor"},
					new FilmesAtores {Ator=atores[2],  Filme=filmes[0], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[3],  Filme=filmes[0], Personagem="Captain Marvel"},
					new FilmesAtores {Ator=atores[3],  Filme=filmes[1], Personagem="Captain Marvel"},
					new FilmesAtores {Ator=atores[2],  Filme=filmes[1], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[2],  Filme=filmes[2], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[4],  Filme=filmes[2], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[5],  Filme=filmes[2], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[6],  Filme=filmes[3], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[7],  Filme=filmes[3], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[8],  Filme=filmes[4], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[9],  Filme=filmes[4], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[10], Filme=filmes[5], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[11], Filme=filmes[5], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[12], Filme=filmes[6], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[13], Filme=filmes[6], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[14], Filme=filmes[7], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[15], Filme=filmes[7], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[16], Filme=filmes[8], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[17], Filme=filmes[8], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[18], Filme=filmes[9], Personagem="Nick Furry"},
					new FilmesAtores {Ator=atores[19], Filme=filmes[9], Personagem="Nick Furry"}
                 };
			   filmesAtores.ForEach(fa => context.FilmesAtores.AddOrUpdate(p => p.ID, fa));
				context.SaveChanges();

        }
	}
}
