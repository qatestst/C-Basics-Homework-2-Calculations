namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylonArea = double.Parse(Console.ReadLine());
            double paintLiters = double.Parse(Console.ReadLine());
            double thinnerLiters = double.Parse(Console.ReadLine());
            double hoursOfWork = double.Parse(Console.ReadLine());

            double expenseWithoutWork = ((nylonArea + 2) * 1.5 ) + (paintLiters * 1.1 * 14.50) + (thinnerLiters * 5) + 0.40;
            double expensesForWork = expenseWithoutWork * 0.3 * hoursOfWork;
            double totalExpenses = expensesForWork + expenseWithoutWork;
            Console.WriteLine(totalExpenses);
        }
    }
}