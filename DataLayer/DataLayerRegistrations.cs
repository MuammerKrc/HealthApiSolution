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
					opt.MigrationsAssembly("ApiLayer");
				});
			});
		}
	}
}
