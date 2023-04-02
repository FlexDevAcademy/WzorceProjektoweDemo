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
        public void BuyIngredients(int quest)
        {
            Ingredients = quest;

        }
        public bool GetDishes(int quest)
        {
            if (Ingredients>=quest)
            {
                return true;
            }          
                           return false;
            
        }
    }
}
