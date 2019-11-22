using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CIMatela : IMatela
    {
        private BddContext bdd;

        public CIMatela()
        {
            bdd = new BddContext();
        }

        public void CreateMatela(DateTime jour, int durée)
        {
            bdd.Matelas.Add(new Matela { Jour = jour, Durée = durée });
            bdd.SaveChanges();
        }

        public List<Matela> SelectAllMatelas()
        {
            return bdd.Matelas.ToList();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}
