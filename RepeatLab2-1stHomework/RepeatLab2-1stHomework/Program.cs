using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLab2_1stHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            SportsCar myCar = new SportsCar();
            myCar.PetName = "Ethel";
            Console.WriteLine("My sports car : {0}", myCar.getPetName(), myCar.PetName);


        }
    }
}
