using System;
using System.Collections.Generic;
using System.Text;
using Basket.OrientedObject.Domain;
using Basket.OrientedObject.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basket.OrientedObject
{
    namespace Basket
    {
        public class BasketOperation
        {
            private readonly Infrastructure.BasketService _basketService;
            public BasketOperation(Infrastructure.BasketService basketService)
            {
                _basketService = basketService;
            }
            public double CalculateAmout(IList<BasketLineArticle> basketLineArticles)
            {
                Domain.Panier basket =
                    _basketService.GetBasket(basketLineArticles);
                return basket.CalculateAmount();
            }

            
        }
    }
}
