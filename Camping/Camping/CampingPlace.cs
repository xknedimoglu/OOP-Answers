using System;
using System.Collections.Generic;
using System.Text;

namespace Camping
{
    class CampingPlace
    {
        private string name;
        private string location;
        private int sizeOfCampsite;
        private double priceForEachTent;

        public string getName() {
            return name;
        }
        public void setName(string name) {
            this.name = name;
        }
        public string getLocation()
        {
            return location;
        }
        public void setLocation(string location) {
            this.location = location;
        }
        public int getSizeOfCampsite() {
            return sizeOfCampsite;
        }
        public void setSizeOfCampsite(int sizeOfCampsite) {
            this.sizeOfCampsite = sizeOfCampsite;
        }
        public double getPriceForEachTent() {
            return priceForEachTent;
        }
        public void setPriceForEachTent(double priceForEachTent) {
            this.priceForEachTent = priceForEachTent;
        }
    }
}
