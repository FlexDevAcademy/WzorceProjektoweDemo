using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace FasadaDemo
{
    public class BrideFasade
    {

        public double WeddingCosts = 0;

        public string MakeWedding()
        {
            Restaurant restaurant = new Restaurant();
            Band band = new Band();
            FloverShop flovershop = new FloverShop();

            WeddingCosts += restaurant.EstimateCosts(guests);
            WeddingCosts += band.EstimateCosts(members);
            WeddingCosts += flovershop.EstimateCosts();
            
            restaurant.BuyIngredients(guests);
            flovershop.MakeFlovers();
            band.MakeAConcert();

            bool isDishesReady = restaurant.GetDishes(guests);
            if (isDishesReady)
            {
                return "Wedding is ready";
            }
            return "Wedding is not ready";
        }
    }
}
