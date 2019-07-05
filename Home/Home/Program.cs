using System;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat flat = new Flat();

            flat.setFloor(17);
            flat.setFurnishedOrNot(true);
            flat.setHomeOwner("Eşber");
            flat.setNumberOfRooms("1+0");
            flat.setPrice(900);

            Console.WriteLine("FLAT 1");
            Console.WriteLine(flat.getFloor());
            Console.WriteLine(flat.getFurnishedOrNot());
            Console.WriteLine(flat.gethomeOwner());
            Console.WriteLine(flat.getNumberOfRooms());
            Console.WriteLine(flat.getPrice());

            Console.ReadLine();
        }
    }
}
