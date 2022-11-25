using Data.Data;
using Data.Model;
using Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class EtapeRepository : IEtapeRepository
    {
        private ApplicationDbContext DbContext { get; }
        public EtapeRepository(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public Etape CreateEtape(Etape etape)
        {
            DbContext.Etapes.Add(etape);
            DbContext.SaveChanges();
            return etape;
            
        }
        /// <summary>
        /// retourne la liste des étapes pour une recette passé en paramétre
        /// </summary>
        /// <param name="recetteId"></param>
        /// <returns></returns>

        public IEnumerable<Etape> GetEtape(int recetteId)
        {
            return DbContext.Etapes.ToList().OrderBy(x => x.EtapeId).Where(x => x.IdRecette == recetteId); ;
        }

        public Etape GetEtapeById(int etapeId)
        {
            return DbContext.Etapes.FirstOrDefault(x => x.EtapeId == etapeId);

        }
    }
}
