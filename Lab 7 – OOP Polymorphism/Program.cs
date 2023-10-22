namespace Lab_7___OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Geometri rektangel = new Rektangel();
            Console.WriteLine($"Area Rektangel: {rektangel.Area()}");

            Geometri fyrkant = new Fyrkant();
            Console.WriteLine($"Area Fyrkant: {fyrkant.Area()}");

            Geometri cirkel = new Cirkel();
            Console.WriteLine($"Area Cirkel: {cirkel.Area()}");

            Geometri parallellogram = new Parallellogram();
            Console.WriteLine($"Area Parallellogram: {parallellogram.Area()}");

            Geometri ellips = new Ellips();
            Console.WriteLine($"Area Ellips: {ellips.Area()}");

        }
    }
}