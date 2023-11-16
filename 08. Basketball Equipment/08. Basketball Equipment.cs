namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double annualTax = double.Parse(Console.ReadLine());

            double sneakers = annualTax * 0.6;
            double outfit = sneakers * 0.8;
            double ball = 0.25 * outfit;
            double accessories = 0.2 * ball;

            double totalExpenses = annualTax + sneakers + outfit + ball + accessories;
            Console.WriteLine(totalExpenses);
        }
    }
}