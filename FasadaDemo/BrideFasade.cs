namespace FasadaDemo
{
    public class BrideFasade
    {
        public double WeddingCosts = 0;

        public string MakeWedding(int guests, int bandMembers)
        {
            Restaurant restaurant= new Restaurant();
            Band band = new Band();
            FlowerShop flowerShop = new FlowerShop();

            
            WeddingCosts += restaurant.EstimateCosts(guests);
            WeddingCosts += band.EstimateCosts(bandMembers);
            WeddingCosts += flowerShop.EstimateCosts();

            // Restaurant prepary
            restaurant.BuyIngredients(guests);
            bool hasDishes = restaurant.GetDishes(guests);


            flowerShop.MakeFlowers();
            band.MakeAConcert();

            if (hasDishes)
            {
                return $"Wedding is ready?? Total costs: {WeddingCosts}";
            }

            return "Wedding is not ready!!";

        }
    }
}
