using System;

namespace Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            CampingPlace campingPlace = new CampingPlace();

            campingPlace.setName("Kaan's Camping");
            campingPlace.setLocation("izmir");
            campingPlace.setPriceForEachTent(50);
            campingPlace.setSizeOfCampsite(400);

            Console.WriteLine(campingPlace.getName());
            Console.WriteLine(campingPlace.getLocation());
            Console.WriteLine(campingPlace.getPriceForEachTent());
            Console.WriteLine(campingPlace.getSizeOfCampsite());
            Console.ReadLine();
        }
    }
}
