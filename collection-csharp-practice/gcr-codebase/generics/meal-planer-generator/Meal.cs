using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.meal_planer_generator
{
    internal class Meal<T> where T : IMealPlan
    {
        private List<T> meals = new List<T>();

        public void AddMeal(T meal)
        {
            meals.Add(meal);
        }

        // Variance-friendly
        public IEnumerable<T> GetMeals()
        {
            return meals;
        }
    }

}
