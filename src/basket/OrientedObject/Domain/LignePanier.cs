using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Domain
{
    public class LignePanier
    {
        private Article article;
        private int nbArticle;

        public LignePanier(Article article, int nbArticle)
        {
            this.article = article;
            this.nbArticle = nbArticle;
        }

        public Article getArticle()
        {
            return this.article;
        }

        public int getNbArticle()
        {
            return this.nbArticle;
        }
    }
}
