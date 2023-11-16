using System.Xml.Schema;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine())/100;

            double pensPrice = pens * 5.80;
            double markersPrice = markers * 7.20;
            double detergentPrice = detergent * 1.20;
            double total = pensPrice+markersPrice+detergentPrice;
            Console.WriteLine(total - total*discount);

        }
    }
}