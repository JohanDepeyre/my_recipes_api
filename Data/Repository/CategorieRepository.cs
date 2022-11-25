using Data.Data;
using Data.Model;
using Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CategorieRepository:ICategorieRepository
    {
        private ApplicationDbContext DbContext { get; }
        public CategorieRepository(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public IEnumerable<Categorie> GetCategorie()
        {
            return DbContext.Categories.ToList();
        }
    }
}
