using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.meal_planer_generator
{
    internal interface IMealPlan
    {
        string MealName { get; }
        int Calories { get; }

        void Prepare();
    }
}
