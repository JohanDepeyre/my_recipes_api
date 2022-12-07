using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace Data.Data
{
    public class RecetteContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            

            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "Setting", "appsetting.json"));
            IConfigurationRoot configurationRoot = configurationBuilder.Build();
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();

            builder.UseSqlServer(configurationRoot.GetConnectionString("DefaultConnection"));
            ApplicationDbContext context = new ApplicationDbContext(builder.Options);
            return context;
        }

        
    }
}
