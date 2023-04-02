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

        public double EstimateCosts(int guests)
        {
            return guests * 180;

        }
        public void BuyIngredients(int guests)
        {
            Ingredients = guests;

        }
        public bool GetDishes(int guests)
        {
            if (Ingredients >= guests)
            {
                return true;
            }
            return false;
        }

    }
}
