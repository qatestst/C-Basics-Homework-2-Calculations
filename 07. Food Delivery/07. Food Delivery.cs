namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());

            double chickenMenusPrice = 10.35;
            double fishMenusPrice = 12.40;
            double vegetarianMenusPrice = 8.15;
            
            double priceForAllMenus = (chickenMenus*chickenMenusPrice) + (fishMenus*fishMenusPrice) + (vegetarianMenus*vegetarianMenusPrice);

            double dessert = priceForAllMenus * 0.2;

            double deliveryExpense = 2.5;

            double totalPrice = priceForAllMenus + dessert + deliveryExpense;
            Console.WriteLine(totalPrice);
        }
    }
}