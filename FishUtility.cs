using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaticPetShop
{
    public class FishUtility : Fish
    {
        public void AddFish(string species, double pricePerFish)
        {
            Species = species;
            PricePerFish = pricePerFish;

        }
        public bool BuyFish()
        {
            if (Species == "Clownfish" || Species == "Goldfish")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CalculatePrice(int numberOfFishes)
        {
            double Additionalcharges = 0;
            if (Species == "Clownfish")
            {
                Additionalcharges = 100;
            }
            else if (Species == "Goldfish")
            {
                Additionalcharges = 150;
            }
            double totalPrice = (PricePerFish * numberOfFishes) + Additionalcharges;
            return totalPrice;
        }
    }
}
