using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Domain
{
    public class Basket
    {
        
        private IList<BasketLineArticle> listArticles { get; set; }

        public Basket(IList<BasketLineArticle> listArticles)
        {
            this.listArticles = listArticles;
        }


    }
}
