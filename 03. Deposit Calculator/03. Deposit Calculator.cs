namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            double months = double.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine())/100;

            //сума = депозирана сума + срок на депозита *((депозирана сума* годишен лихвен процент ) / 12)
            double sum = deposit + months * ((deposit * interest) / 12);
            Console.WriteLine($"{sum:F2}");

            
        }
    }
}