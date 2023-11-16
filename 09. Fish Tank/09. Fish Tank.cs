namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;

            double aquariumVolume = length*width*height;
            double volumeInLiters = aquariumVolume * 0.001;

            double neededLiters = volumeInLiters - volumeInLiters * percentage;

            Console.WriteLine(neededLiters);
        }
    }
}