using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Tests.Features
{
  public  class ShopRater
    {
        private CoffeeShop data;

        public ShopRater(CoffeeShop data)
        {
            // TODO: Complete member initialization    
            this.data = data;
        }

        public RatingResult ComputeRating(int p)
        {
            var result = new RatingResult();
            result.Rating = 4;
            return result;
        }
    }
}
