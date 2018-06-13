using System;
using System.Collections.Generic;
using System.Text;
using Basket = Basket.OrientedObject.Domain.Basket;

namespace Basket.OrientedObject.Infrastructure
{
    public class BasketService
    {

        private ArticleDatabaseMock articleDBMock;
        public BasketService() { }

        public BasketService(ArticleDatabaseMock articleDBMock)
        {
            this.articleDBMock = articleDBMock;
        }

        public Domain.Basket GetBasket(IList<BasketLineArticle>
            basketLineArticles)
        {
            Domain.Basket basket = new Domain.Basket(basketLineArticles);
            return basket;
        }
    }
}
 