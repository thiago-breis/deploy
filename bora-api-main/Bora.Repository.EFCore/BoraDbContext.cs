﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Bora.Repository
{
    public class BoraDbContext(DbContextOptions<BoraDbContext> options) : DbContext(options)
	{
		protected override void OnModelCreating(ModelBuilder builder)
        {
            var thisAssembly = Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(thisAssembly);
        }
    }
}
