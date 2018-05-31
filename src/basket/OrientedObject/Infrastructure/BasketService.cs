using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using basket;
using Basket.OrientedObject.Domain;
using Newtonsoft.Json;

namespace Basket.OrientedObject.Infrastructure
{
    public class BasketService
    {
        public Domain.Panier GetBasket(IList<BasketLineArticle>
            basketLineArticles)
        {

            
            IList<LignePanier> lignePaniers = new List<LignePanier>();
            foreach (var basketLineArticle in basketLineArticles)
            {
                var articleId = basketLineArticle.Id;
                var article = GetArticleDatabase(articleId);

                lignePaniers.Add(new LignePanier(new Article(article.Label, article.Category, article.Price),basketLineArticle.Number));
            }
            //1: cahrger objet en bdd

            //2: instancier panier

            return new Panier(lignePaniers);
            
        }

        private static ArticleDatabase GetArticleDatabase(string articleId)
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uri.Path);
            var assemblyDirectory = Path.GetDirectoryName(path);
            var jsonPath = Path.Combine(assemblyDirectory, "article-database.json");

            IList<ArticleDatabase> articleDatabases =
                JsonConvert.DeserializeObject<List<ArticleDatabase>>(File.ReadAllText(jsonPath));
            var article = articleDatabases.First(articleDatabase =>
                articleDatabase.Id == articleId);
            return article;
        }
    }
}

