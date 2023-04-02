using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasadaDemo
{
    public class Restaurant
    {
        private int Ingredients = 0;

        public double EstimateCosts(int guest)
        {
            return guest * 180;
        }

        public void BuyIngredients(int guest)
        {
            Ingredients = guest;
        }

        public bool GetDishes(int guest)
        {
            if (Ingredients <= guest)
            {
                return true;
            }
            return false;
        }
    }
}
