using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGuide
{
    class FitnessWorkout
    {
        public static string fitnessGoal;
        private string workoutOption;
        private string numOfReps;

        public void ExecuteWorkout()
        {
            WelcomeMessage();
            GetFitnessGoal();
            EndingFitnessWorkout();
        }
        public void WelcomeMessage()
        {
            Console.WriteLine("WELCOME TO TODAY'S FITNESS WORKOUK GENERATOR!");
            Console.WriteLine("Your user input will determine what is on the agenda for today's workout.");
        }
        public string GetUserInput(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }
        public void GetFitnessGoal()
        {
            fitnessGoal = GetUserInput("What is your fitness goal for today? Enter Bulk, Tone, or Lose Weight?");

            switch (fitnessGoal)
            {
                case "Bulk":
                    Console.WriteLine("Oh so you want to work on getting some muscles? I think I can help you.");
                    GetWorkoutOption();
                    break;

                case "Tone":
                    Console.WriteLine("So you want to work on staying lean and toning your muscles? I think I can help you.");
                    GetWorkoutOption();
                    break;
                case "Lose Weight":
                    Console.WriteLine("So you want to work on losing some weight before the big vacation/holiday? I think I can help you.");
                    GetWorkoutOption();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        public void GetWorkoutOption()
        {
            Console.WriteLine("Choose one of the following workout options");
            Console.WriteLine("1. Upper Body");
            Console.WriteLine("2. Lower Body");
            workoutOption = GetUserInput("Enter the number below");
            if (workoutOption == "1")
            {
                DisplayUpperBodyWorkout();
            } else if (workoutOption == "2")
            {
                DisplayLowerBodyWorkout();
            }
        }         
        public void GetNumberOfReps()
        {
            switch (fitnessGoal)
            {
                case "Bulk":
                    numOfReps = "8-10 Reps:";
                    break;
                case "Tone":
                    numOfReps = "10-15 Reps:";
                    break;
                case "Lose Weight":
                    numOfReps = "Max Reps:";
                    break;
            }
        }       
        public void DisplayUpperBodyWorkout()
        {
            GetNumberOfReps();
            Console.WriteLine("Warm-Up \n. {0} Dumbbell Chest Press \n. {0} Incline Dummbell Fly \n. {0} Incline Dummbell Press \n. {0} Close Grip Press \n. {0} Partial Chest Fly \n. {0} Decline Push-Ups \n. {0} Tricep Extension \n. {0} Single Arm Kickback \n. {0} Tricep Push-Up", numOfReps);
        }
        public void DisplayLowerBodyWorkout()
        {
            GetNumberOfReps();
            Console.WriteLine("Warm-Up \n. {0} Sumo Squat \n. {0} Alternating Lunge \n. {0} Step-Up to Reverse Lunge \n. {0} Parallel Squat \n. {0} Bulgarian Squat \n. {0} Straight Leg Deadlift \n. {0} Single Leg Calf Raise \n. {0} Seated Calf Raise", numOfReps);
        }
        public void EndingFitnessWorkout()
        {
            Console.WriteLine("PRESS ENTER TO CONTINUE TO YOUR NUTRITION");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
