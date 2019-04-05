using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circumference_of_circle
{
    class Program
    {
        static void Main(string[] args)
        {
			//Variables been used in this program
			double Radius;
            double pie = Math.PI;
            double Area;
            double Cir;
            double Dia;

			//Prompts the user to input
			Console.Write("Enter radius of circle ---->");

			//this is how the program grabs the user input 
			Radius = double.Parse(Console.ReadLine());

			//Math used to calculate the circumference, area , Diammeter
			Area = pie * (Radius * Radius);
            Cir = 2 * pie * Radius;
            Dia = 2 * Radius;

			//Displays the answer...
		    Console.WriteLine("the Area-------------->" + Area);
            Console.WriteLine("the Diammeter--------->" + Dia);
            Console.WriteLine("the Circumference----->" + Cir);

            Console.ReadKey();

        }
    }
}
