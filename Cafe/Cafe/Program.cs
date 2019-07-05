using System;

namespace Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Gisdo gisdo = new Gisdo();
            
            gisdo.setNargileOrNot(true);
            gisdo.setLocation("Ataşehir");
            gisdo.setNumberOfEmployee(25);
            gisdo.setPlayingFieldOrNot(true);

            Console.WriteLine(gisdo.getNarghileOrNot());
            Console.WriteLine(gisdo.getLocation());
            Console.WriteLine(gisdo.getNumberOfEmployees());
            Console.WriteLine(gisdo.getPlayingFieldOrNot());
            Console.ReadLine();
        }
    }
}
