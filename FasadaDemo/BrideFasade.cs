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

        public string MakeWedding(int guests, int members)
        {
            Restaurant restaurant = new Restaurant();
            Band band = new Band();
            FlowerShop flowershop = new FlowerShop();

            WeddingCosts += restaurant.EstimateCosts(guests);
            WeddingCosts += band.EstimateCosts(members);
            bool isDishesReady = restaurant.GetDishes(guests);

            if (isDishesReady)
            {
                return "Wedding is ready";
            }
            return "Wedding is not ready";
        }
    }
}
