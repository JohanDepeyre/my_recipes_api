using Data.Data;
using Data.Model;
using Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

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
         
            DbContext.Entry(etape.recette).State =EntityState.Unchanged;

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
            return DbContext.Etapes.Include(x=>x.recette).ToList().OrderBy(x => x.EtapeId).Where(x => x.RecetteId == recetteId); ;
        }

        public Etape GetEtapeById(int etapeId)
        {
            return DbContext.Etapes.FirstOrDefault(x => x.EtapeId == etapeId);

        }
    }
}
