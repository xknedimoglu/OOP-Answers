using System;
using System.Collections.Generic;
using System.Text;

namespace Gym
{
    class Gym
    {
        private string name;
        private int registeredPeople;
        private int numberOfSportImplements;
        private string location;
        private int numberOfWorkingTrainer;

        public string getName() {
            return name;
        }
        public void setName(string name) {
            this.name = name;
        }
        public int getRegisteredPeople() {
            return registeredPeople;
        }
        public void setRegisteredPeople(int registeredPeople)
        {
            this.registeredPeople = registeredPeople;
        }
        public int getNumberOfSportImplements() {
            return numberOfSportImplements;
        }
        public void setNumberOfSportImplements(int numberOfSportImplements) {
            this.numberOfSportImplements = numberOfSportImplements;
        }
        public string getLocation()
        {
            return location;
        }
        public void setLocation(string location) {
            this.location = location;
        }
        public int getNumberOfWorkingTrainer() {
            return numberOfWorkingTrainer;
        }
        public void setNumberOfWorkingTrainer(int numberOfWorkingTrainer) {
            this.numberOfWorkingTrainer = numberOfWorkingTrainer;
        }

    }
}
