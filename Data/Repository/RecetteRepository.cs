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
    public class RecetteRepository : IRecetteRepository
    {
        private ApplicationDbContext DbContext { get; }
        public RecetteRepository(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
        }



        public IEnumerable<Recette> GetRecette()
        {
            return this.DbContext.Recettes;
        }

        public Recette GetRecetteById(int recetteId)
        {
            return DbContext.Recettes.FirstOrDefault(x => x.Id.Equals(recetteId));
        }

        public Recette CreateRecette(Recette recette)
        {
            this.DbContext.Recettes.Add(recette);
            this.DbContext.SaveChanges();

            return recette;
        }
    }
}
