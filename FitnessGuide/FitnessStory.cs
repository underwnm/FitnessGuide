using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGuide
{
    class FitnessStory
    {
        string gender;
        string fitnessGoal;
        string fitnessLevel;
        int addedCalories;
        int workoutCalories;
        double weight;
        double activityMultiplier;
        double totalCalories;

        public void Introduction()
        {
            Console.WriteLine("WELCOME TO TODAY'S RANDOM FITNESS WORKOUK!");
            Console.WriteLine("Your user input will determine what is on the agenda for today.");
            FitnessStory currentStory = new FitnessStory();
            currentStory.GetGender();
            currentStory.GetFitnessGoal();

        }

        public void GetGender()
        {
            Console.WriteLine("Let's start simple by entering some data that will help us plan towards your fitness goals.What is your gender Male or Female?");
            gender = Console.ReadLine();
        }

        public void GetFitnessGoal()
        {
            Console.WriteLine("What is your fitness goal for today? Bulk? Tone? or Lose Weight?");
            fitnessGoal = Console.ReadLine();

            switch (fitnessGoal)
            {
                case "Bulk":
                    Console.WriteLine("Oh so you want to work on getting some muscles. I think we can help you.");
                    break;
            }
        }
    }
}
