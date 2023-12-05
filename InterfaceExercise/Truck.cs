﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }

        public int BedSize { get; set; }
        public bool Is4WheelDrive { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public bool ChangeGears(bool isChanged)
        {
            Console.WriteLine("Changing Gears...");
            return isChanged;
        }

        public void Drive()
        {
            Console.WriteLine("Driving...");
        }

        public void Park()
        {
            Console.WriteLine("Parking...");
        }

        public void Reverse()
        {
            Console.WriteLine("Reversing...");
        }
    }
}