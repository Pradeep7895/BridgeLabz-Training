using Collections.collection_csharp_practice.gcr_codebase.generics.smart_warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.insurance_policy_management
{
    internal class PolicyMain
    {
        static void Main()
        {
            PolicyMenu menu = new PolicyMenu();
            menu.Start();
        }
    }
}
