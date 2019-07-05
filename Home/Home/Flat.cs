using System;
using System.Collections.Generic;
using System.Text;

namespace Home
{
    class Flat
    {
        private int floor;
        private string numberOfRooms;
        private string homeOwner;
        private bool furnishedOrNot;
        private int price;

        public int getFloor() {
            return floor;
        }
        public void setFloor(int floor) {
            this.floor = floor;
        }

        public string getNumberOfRooms() {
            return numberOfRooms;
        }
        public void setNumberOfRooms(string numberOfRooms) {
            this.numberOfRooms = numberOfRooms;
        }

        public string gethomeOwner() {
            return homeOwner;
        }
        public void setHomeOwner(string homeOwner) {
            this.homeOwner = homeOwner;
        }
        public bool getFurnishedOrNot() {
            return furnishedOrNot;
        }
        public void setFurnishedOrNot(bool furnishedOrNot) {
            this.furnishedOrNot = furnishedOrNot;
        }
        public int getPrice() {
            return price;
        }
        public void setPrice(int price) {
            this.price = price;
        }


    }
}
