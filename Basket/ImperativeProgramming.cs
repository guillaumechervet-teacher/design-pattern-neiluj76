using System;
using System.Collections.Generic;

namespace Basket
{
    public class ImperativeProgramming
    {
        public static decimal CalculateBasketAmount(IList<BasketLineArticle>
            basketLineArticles)
        {
            decimal ladecimal = 5;
            return ladecimal;
        }

        public static ArticleDatabase GetArticleDatabase(string id)
        {
            return new ArticleDatabase();
        }

        public static ArticleDatabase GetArticleDatabaseMock(string id)
        {
            switch (id)
            {
                case "1":
                    return new ArticleDatabase {Id = "1", Price = 1, Stock = 35};
                case "2":
                    return new ArticleDatabase()
                    {
                        Id = "2",
                        Price = 500,
                        Stock = 20,
                        Label = "Fridge Electrolux",
                        Category = "eletronic"
                    };
                case "3":
                    return new ArticleDatabase()
                    {
                        Id = "3",
                        Price = 49,
                        Stock = 68,
                        Label = "Chair",
                        Category = "desktop"
                    };
                default:
                    throw new NotImplementedException();
            }
        }


    }
}