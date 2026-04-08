using Collections.collection_csharp_practice.gcr_codebase.generics.meal_planer_generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.meal_planer_generator
{
    internal class MealUtility
    {
        private Meal<VegetarianMeal> vegetarianMeals = new();
        private Meal<VeganMeal> veganMeals = new();
        private Meal<KetoMeal> ketoMeals = new();
        private Meal<HighProteinMeal> highProteinMeals = new();

        // Generic METHOD with constraint
        public void GenerateMeal<T>(Meal<T> mealStore, T meal) where T : IMealPlan
        {
            mealStore.AddMeal(meal);
            Console.WriteLine("Meal plan generated successfully.");
        }

        // ONE display method 
        public void DisplayMeals(IEnumerable<IMealPlan> meals)
        {
            bool found = false;

            foreach (IMealPlan meal in meals)
            {
                meal.Prepare(); // polymorphism
                found = true;
            }

            if (!found)
            {
                Console.WriteLine("No meals available.");
            }
        }

        // Accessors only
        public Meal<VegetarianMeal> GetVegetarianMeals() { return vegetarianMeals; }
        public Meal<VeganMeal> GetVeganMeals() { return veganMeals; }
        public Meal<KetoMeal> GetKetoMeals() { return ketoMeals; }
        public Meal<HighProteinMeal> GetHighProteinMeals() { return highProteinMeals; }
    }
}


    