using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.meal_planer_generator
{
    internal class HighProteinMeal : IMealPlan
    {
        public string MealName { get; private set; }
        public int Calories { get; private set; }

        public HighProteinMeal(string name, int calories)
        {
            MealName = name;
            Calories = calories;
        }

        public void Prepare()
        {
            Console.WriteLine($"[High Protein] {MealName} – {Calories} kcal");
        }
    
    }
}
