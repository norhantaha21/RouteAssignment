namespace FavoriteFoodApp
{
    internal class Program
    {

        enum Food
        {
            Pizza,
            Burger,
            Salad
        }

        static void Main(string[] args)
        {
                
                Console.Write("Enter your favorite food (Pizza, Burger, Salad): ");
                string input = Console.ReadLine();

                bool success = Enum.TryParse<Food>(input, true, out Food result);

                if (success)
                {
                    Console.WriteLine($"You chose: {result}");
                }
                else
                {
                    Console.WriteLine("That food is not on the menu!");
                }

            }
        }
}
