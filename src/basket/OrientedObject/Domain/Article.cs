using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Domain
{
    public class Article
    {
        private String name;
        private int prix;
        private String categorie;

        public Article(String name, string categorie, int prix)
        {
            this.name = name;
            this.categorie = categorie;
            this.prix = prix;
        }

        public String getName()
        {
            return this.name;
        }

        public String getCategorie()
        {
            return this.categorie;
        }

        public int getPrix()
        {
            return this.prix;
        }

        public int Calulate()
        {
            var amount = 0;
            var articlePrice = prix;
            switch (category)
            {
                case "food":
                    amount += articlePrice * 100 + articlePrice * 12;
                    break;
                case "electronic":
                    amount += articlePrice * 100 + articlePrice * 20 + 4;
                    break;
                case "desktop":
                    amount += articlePrice * 100 + articlePrice * 20;
                    break;
            }

            return amount;
        }

        public string category { get; set; }
    }
}
