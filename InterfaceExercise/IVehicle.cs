using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumOfWheels { get; set; }
        public int NumOfDoors { get; set; }
        public int NumOfSeats { get; set; }
        public bool HasAirbags { get; set; }
        public string Name { get; set; } 

    }
}
