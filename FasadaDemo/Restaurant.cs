using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasadaDemo
{
    public class Restaurant
    {
        private int ingredients = 0;

        public double EstimateCosts(int guest) 
        {
            return guest * 180;
        }

        public void BuyIngredients(int guest)
        {
            ingredients = guest;
        }

        public bool GetDishes(int guest)
        {
            if (ingredients >= guest)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
