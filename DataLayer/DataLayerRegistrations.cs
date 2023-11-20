using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.IdentityModels;
using DataLayer.DbContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer
{
	public static class DataLayerRegistrations
	{
		public static void AddDataLayerRegistration(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<HealthDbContext>(i =>
			{
				i.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), opt =>
				{
					opt.MigrationsAssembly("DataLayer");
				});
			});
			//builder.Services.AddDbContext<HealthDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("ApiLayer")));
			//builder.Services.AddAuthorization();

			//services.AddIdentityApiEndpoints<AppUser,IdentityRole>().AddEntityFrameworkStores<HealthDbContext>();
			//services.AddIdentity<AppUser, AppRole>(opt =>
			//{
			//	opt.User.RequireUniqueEmail = true;
			//	opt.Password.RequireDigit = false;
			//	opt.Password.RequireLowercase = false;
			//	opt.Password.RequireUppercase = false;
			//	opt.Password.RequireNonAlphanumeric = false;
			//	opt.Password.RequiredLength = 5;
			//	opt.Password.RequiredUniqueChars = 3;
			//}).AddEntityFrameworkStores<HealthDbContext>().AddDefaultTokenProviders();

		}
		
	}
}
