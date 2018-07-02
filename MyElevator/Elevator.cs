using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyElevator
{
    public class Elevator
    {
        private int currentFloor;
        private bool doorStatus = false;
        public int CurrentFloor
        {
            get { return this.currentFloor; }
            set { this.currentFloor = value; }
        }
        public Elevator(int floor)
        {
            this.currentFloor = floor;
        }
        public bool DoorStatus
        {
            get { return this.doorStatus; }
            set { this.doorStatus = value; }
        }
    }
}
