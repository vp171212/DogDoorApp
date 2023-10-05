using DogDoor.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoor
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int returnBeforeDoorClose = 2000;
            int returnAfterDoorClose = 10000;
            bool ownersResponsive = true;


            DogDoorSimulator.DogDoorTestPath(returnBeforeDoorClose, ownersResponsive);
        
            DogDoorSimulator.DogDoorTestPath(returnAfterDoorClose, ownersResponsive);


            DogDoorSimulator.DogDoorTestPath(returnBeforeDoorClose, !ownersResponsive);
        
            DogDoorSimulator.DogDoorTestPath(returnAfterDoorClose, !ownersResponsive);

            Console.WriteLine("\nTest passed! Press any key to continue.\n");

            Console.ReadKey();
        }
    }
}