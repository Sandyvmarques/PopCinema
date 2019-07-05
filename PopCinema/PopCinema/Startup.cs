using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Owin;
using PopCinema.Models;

namespace PopCinema
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
			inic();
		}

		private void inic()
		{
			ApplicationDbContext db = new ApplicationDbContext();

			var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
			var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

			// criar a Role 'Admin'
			if (!roleManager.RoleExists("Admin"))
			{
				// não existe a 'role'
				// então, criar essa role
				var role = new IdentityRole();
				role.Name = "Admin";
				roleManager.Create(role);
			}



			// criar um utilizador 'Admin'
			var user = new ApplicationUser();
			user.UserName = "admin@mail.pt";
			user.Email = "admin@mail.pt";
			string userPWD = "123_Asd";
			var chkUser = userManager.Create(user, userPWD);


			// criar um utilizador 'utilizador1'
			var user1 = new ApplicationUser();
			user1.UserName = "util1@mail.pt";
			user1.Email = "util1@mail.pt";
			string userPWD2 = "123_Asd";
			var chkUser1 = userManager.Create(user1, userPWD2);


			// criar um utilizador 'utilizador2'
			var user2 = new ApplicationUser();
			user2.UserName = "util2@mail.pt";
			user2.Email = "util2@mail.pt";
			string userPWD3 = "123_Asd";
			var chkUser2 = userManager.Create(user2, userPWD3);

			// criar um utilizador 'utilizador3'
			var user3 = new ApplicationUser();
			user3.UserName = "util3@mail.pt";
			user3.Email = "util3@mail.pt";
			string userPWD4 = "123_Asd";
			var chkUser3 = userManager.Create(user3, userPWD4);

			//Adicionar o Utilizador à respetiva Role-Admin
			if (chkUser.Succeeded)
			{
				var result1 = userManager.AddToRole(user.Id, "Admin");
			}
		}
	}
}
