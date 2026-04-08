using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.company_and_departments
{
    internal class Employee
    {
        // Employee name
        public string Name { get; private set; }

        // Created by Department
        public Employee(string name)
        {
            Name = name;
        }
    }
}
