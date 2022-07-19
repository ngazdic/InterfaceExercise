using System;
namespace InterfaceExercise
{
         
    public class Truck :  ICompany
    {
        public Truck()
        {
        }

        public string BedSize { get; set; }

        public int TowingCapacity { get; set; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfSeats { get ; set ; }
        public string EngineType { get  ; set ; }
        public int MaxSpeed { get  ; set  ; }
        public string Logo { get; set ; }
        public string Owner { get ; set ; }
        public string Model { get ; set ; }
        public string Make { get ; set ; }
        public int Year { get ; set ; }
    }
}

