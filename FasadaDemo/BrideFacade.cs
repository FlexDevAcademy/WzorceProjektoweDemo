using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasadaDemo
{
    public class BrideFacade
    {
        public double WeddingCosts = 0;
        public string MakeWedding(int guests, int members)
        {
            Restaurant restaurant = new Restaurant();
            FlowerShop flowerShop = new FlowerShop();
            Band band = new Band();

            WeddingCosts += restaurant.EstimateCosts(guests);
            WeddingCosts += flowerShop.EstimateCosts();
            WeddingCosts += band.EstimateCosts(members);

            restaurant.BuyIngredients(guests);
            flowerShop.MakeFlowers();
            band.MakeConcert();

            bool isDishesReady = restaurant.GetDishes(guests);

            if (isDishesReady)
            {
                return "Wedding is ready";
            }
            else
            {
                return "Wedding is not ready";
            }


        }
    }
}
