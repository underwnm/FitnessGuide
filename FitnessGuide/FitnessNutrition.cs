using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGuide
{
    class FitnessNutrition
    {
        private string activityLevel;
        private string userGender;
        private double activityLevelMultiplier;
        private double userWeight;
        private double genderCalorieBonus;
        private double fitnessGoalCalorieAdjustment;
        private double totalCalories;

        public void ExecuteNutrition()
        {
            WelcomeMessage();
            GetUserWeight();
            GetUserGender();
            GetActivityLevel();
            GetFitnessGoalCalorieAdjustment();
            GetGenderCalorieBonus();
            CalculateTotalCalories();
            DisplayTotalCalories(); 
        }
        public void WelcomeMessage()
        {
            Console.WriteLine("WELCOME TO YOUR NUTRITION CALORIE CALCULATOR!");
            Console.WriteLine("Your user input will determine what your total daily calories should be.");
        }
        public string GetUserInput(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }
        public void GetActivityLevel()
        {
            activityLevel = GetUserInput("What is your Activity Level? Enter High, Moderate, or Sedentary");
            CalculateActivityLevel();          
        }
        public void CalculateActivityLevel()
        {
            switch (activityLevel)
            {
                case "High":
                    activityLevelMultiplier = 1.6;
                    break;
                case "Moderate":
                    activityLevelMultiplier = 1.4;
                    break;
                case "Sedentary":
                    activityLevelMultiplier = 1.2;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        public void GetUserWeight()
        {
            userWeight = Convert.ToDouble(GetUserInput("What is your current weight? Enter in lbs."));
        }
        public void GetUserGender()
        {
            userGender = GetUserInput("What is your gender? Enter Male or Female.");
        }
        public void GetGenderCalorieBonus()
        {
            if (userGender == "Male")
            {
                genderCalorieBonus = 400;
            } else if (userGender == "Female")
            {
                genderCalorieBonus = 300;
            }
        }
        public void GetFitnessGoalCalorieAdjustment()
        {
            if (FitnessWorkout.fitnessGoal == "Bulk")
            {
                fitnessGoalCalorieAdjustment = 300;
            } else if (FitnessWorkout.fitnessGoal == "Tone") {
                fitnessGoalCalorieAdjustment = 0;
            } else if (FitnessWorkout.fitnessGoal == "Lose Weight") {
                fitnessGoalCalorieAdjustment = -1000;
            }
        }
        public void CalculateTotalCalories()
        {
            totalCalories = (userWeight * 10) * activityLevelMultiplier + fitnessGoalCalorieAdjustment + genderCalorieBonus;
        }
        public void DisplayTotalCalories()
        {
            Console.WriteLine("The total calories you should take in each day is {0}", totalCalories);
        }
    }
}
