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
            Band band= new Band();
            int guests = 150;
            int members = 4;
            WeddingCosts += restaurant.EstimateCosts(guests);
            WeddingCosts += band.EstimateCosts(members);
            WeddingCosts += flowershop.EstimateCosts();
            restaurant.BuyIngedients(guests);
        }
    }
}
