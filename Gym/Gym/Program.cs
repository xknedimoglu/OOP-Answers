using System;

namespace Gym
{
    class Program
    {
        static void Main(string[] args)
        {
            Gym gym = new Gym();

            gym.setName("MACFIT");
            gym.setLocation("Ataşehir");
            gym.setNumberOfSportImplements(80);
            gym.setNumberOfWorkingTrainer(25);
            gym.setRegisteredPeople(1000);


            Console.WriteLine(gym.getName());
            Console.WriteLine(gym.getLocation());
            Console.WriteLine(gym.getNumberOfSportImplements());
            Console.WriteLine(gym.getNumberOfWorkingTrainer());
            Console.WriteLine(gym.getRegisteredPeople());
            Console.ReadLine();
        }
    }
}
