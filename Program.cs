namespace AquaticPetShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fish fish = new Fish();
            FishUtility fishes = new FishUtility();
            Console.WriteLine("Enter The Species To Buy");
            fishes.Species = Console.ReadLine();
            Console.WriteLine("Enter The Price Per Fish");
            fishes.PricePerFish = Convert.ToDouble(Console.ReadLine());
            fishes.AddFish(fishes.Species, fishes.PricePerFish);
            if (fishes.BuyFish())
            {
                Console.WriteLine("Enter The Number Of You Fishes To Buy");
                int numberOfFishes = Convert.ToInt32(Console.ReadLine());
                double totalCost = fishes.CalculatePrice(numberOfFishes);
                Console.WriteLine($"Total COst is {totalCost}");
            }
            else
            {
                Console.WriteLine($"{fishes.Species} species Not Found");
            }
        }

    }
}
