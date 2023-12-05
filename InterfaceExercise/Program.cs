using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var civic = new Car
            {
                EngineSize = 4.0,
                Make = "Honda",
                Model = "Civic",
                HasTrunk = true,
                SeatCount = 2,
                NumberOfSpeeds = 5,
                Name = "Honda",
                Logo = "H"
            };

            var f150 = new Truck
            {
                EngineSize = 4.0,
                Make = "Ford",
                Model = "F150",
                BedSize = 500,
                Is4WheelDrive = true,
                Name = "Ford",
                Logo = "Ford",
                SeatCount = 6
            };

            var explorer = new SUV
            {
                EngineSize = 3.2,
                Make = "Ford",
                Model = "Explorer",
                HasAutomaticTrunkHatch = false,
                Logo = "Ford",
                Name = "Ford",
                SeatCount = 5,
                TrunkSpace = 1000
            };

            Console.WriteLine($"Engine Size: {civic.EngineSize}, Make: {civic.Make}, Model: {civic.Model}, Has Trunk: {civic.HasTrunk}, Seat Count: {civic.SeatCount}, Number of Speeds: {civic.NumberOfSpeeds}, Company Name: {civic.Name}, Company Logo: {civic.Logo}");
            Console.WriteLine($"Engine Size: {f150.EngineSize}, Make: {f150.Make}, Model: {f150.Model}, Has 4 Wheel Drive: {f150.Is4WheelDrive}, Seat Count: {f150.SeatCount}, Bed Sizee: {f150.BedSize}, Company Name: {f150.Name}, Company Logo: {f150.Logo}");
            Console.WriteLine($"Engine Size: {explorer.EngineSize}, Make: {explorer.Make}, Model: {explorer.Model}, Trunk Size: {explorer.TrunkSpace}, Seat Count: {explorer.SeatCount}, Has Automatic Trunk: {explorer.HasAutomaticTrunkHatch}, Company Name: {explorer.Name}, Company Logo: {explorer.Logo}");
        }
    }
}
