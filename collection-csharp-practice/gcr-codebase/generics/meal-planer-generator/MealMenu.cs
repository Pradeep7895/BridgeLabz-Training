using Collections.collection_csharp_practice.gcr_codebase.generics.meal_planer_generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.meal_planer_generator
{
    internal class MealMenu
    {
        private MealUtility utility = new MealUtility();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n==== Meal Plan Menu ====");
                Console.WriteLine("1. Add Vegetarian Meal");
                Console.WriteLine("2. Add Vegan Meal");
                Console.WriteLine("3. Add Keto Meal");
                Console.WriteLine("4. Add High Protein Meal");
                Console.WriteLine("5. View Vegetarian Meals");
                Console.WriteLine("6. View Vegan Meals");
                Console.WriteLine("7. View Keto Meals");
                Console.WriteLine("8. View High Protein Meals");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.GenerateMeal(
                            utility.GetVegetarianMeals(),
                            CreateVegetarianMeal());
                        break;

                    case 2:
                        utility.GenerateMeal(
                            utility.GetVeganMeals(),
                            CreateVeganMeal());
                        break;

                    case 3:
                        utility.GenerateMeal(
                            utility.GetKetoMeals(),
                            CreateKetoMeal());
                        break;

                    case 4:
                        utility.GenerateMeal(
                            utility.GetHighProteinMeals(),
                            CreateHighProteinMeal());
                        break;

                    case 5:
                        utility.DisplayMeals(
                            utility.GetVegetarianMeals().GetMeals());
                        break;

                    case 6:
                        utility.DisplayMeals(
                            utility.GetVeganMeals().GetMeals());
                        break;

                    case 7:
                        utility.DisplayMeals(
                            utility.GetKetoMeals().GetMeals());
                        break;

                    case 8:
                        utility.DisplayMeals(
                            utility.GetHighProteinMeals().GetMeals());
                        break;

                    case 0:
                        return;
                }
            }
        }

        // Meal creators

        private VegetarianMeal CreateVegetarianMeal()
        {
            Console.Write("Meal Name: ");
            string name = Console.ReadLine();

            Console.Write("Calories: ");
            int calories = int.Parse(Console.ReadLine());

            return new VegetarianMeal(name, calories);
        }

        private VeganMeal CreateVeganMeal()
        {
            Console.Write("Meal Name: ");
            string name = Console.ReadLine();

            Console.Write("Calories: ");
            int calories = int.Parse(Console.ReadLine());

            return new VeganMeal(name, calories);
        }
        private KetoMeal CreateKetoMeal()
        {
            Console.Write("Meal Name: ");
            string name = Console.ReadLine();

            Console.Write("Calories: ");
            int calories = int.Parse(Console.ReadLine());

            return new KetoMeal(name, calories);
        }

        private HighProteinMeal CreateHighProteinMeal()
        {
            Console.Write("Meal Name: ");
            string name = Console.ReadLine();

            Console.Write("Calories: ");
            int calories = int.Parse(Console.ReadLine());

            return new HighProteinMeal(name, calories);
        }

    }
}

    