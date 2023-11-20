using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Dtos.IdentityDtos;
using CoreLayer.Models.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.DbContexts
{
	public class HealthDbContext:IdentityDbContext<AppUser,IdentityRole<int>,int>
	{
		public HealthDbContext(DbContextOptions options):base(options)
		{
		}


	}
}
