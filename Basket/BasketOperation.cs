using System;
using System.Collections.Generic;
using System.Text;

namespace Basket
{
    public class BasketOperation
    {
        private readonly OrientedObject.Infrastructure.BasketService _basketService;
        public BasketOperation(OrientedObject.Infrastructure.BasketService basketService)
        {
            _basketService = basketService;
        }
        public int CalculateAmout(IList<BasketLineArticle> basketLineArticles)
        {
            OrientedObject.Domain.Basket basket =
                _basketService.GetBasket(basketLineArticles);
            return basket.CalculateAmount();
        }
    }
}
