using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    class Gisdo
    {
        private string location;
        private bool narghileOrNot;
        private int numberOfEmployee;
        private bool playingFieldOrNot;

        public string getLocation() {
            return location;
        }
        public void setLocation(string location) {
            this.location = location;
        }

        public bool getNarghileOrNot() {
            return narghileOrNot;
        }
        public void setNargileOrNot(bool narghileOrNot) {
            this.narghileOrNot = narghileOrNot;
        }
        public int getNumberOfEmployees() {
            return numberOfEmployee;
        }
        public void setNumberOfEmployee(int numberOfEmployee) {
            this.numberOfEmployee = numberOfEmployee;
        }
        public bool getPlayingFieldOrNot() {
            return playingFieldOrNot;
        }
        public void setPlayingFieldOrNot(bool playingFieldOrNot) {
            this.playingFieldOrNot = playingFieldOrNot;
        } 
    }
}
