using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            FitnessWorkout currentWorkout = new FitnessWorkout();
            currentWorkout.ExecuteWorkout();

            FitnessNutrition currentNutrition = new FitnessNutrition();
            currentNutrition.ExecuteNutrition();

            Console.WriteLine("END OF PROGRAM");
            Console.ReadKey();

        }
    }
}
