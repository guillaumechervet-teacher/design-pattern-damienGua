using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Domain
{
    public class Panier
    {
        private IList<LignePanier> lignePanier;

        
        public Panier(IList<LignePanier> lignePanier)
        {
            this.lignePanier = lignePanier;
        }

        public IList<LignePanier> GetLignePaniers()
        {
            return this.lignePanier;
        }

        public int CalculateAmount()
        {
            int total=0;
            foreach (var ligne in lignePanier)
            {
               total += ligne.getArticle().getPrix() * ligne.getNbArticle();
            }
            return total;
        }

    }
}
