using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_management_system
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        // object reference at class level
        private Employee employee;
        private const int WorkingDays = 20;

        //method to check attendance for one day
        //and if present then mark as present in present days
        public Employee CheckAttendance()
        {
            employee = new Employee();

            Random random = new Random();
            bool attendance = random.Next(0, 2) == 1;

            employee.SetEmployeeId(1);
            employee.SetEmployeeName("Pradeep");
            employee.SetIsPresent(attendance);

            if (attendance)
                employee.SetPresentDays(1);
            else
                employee.SetPresentDays(0);

            employee.SetDailyWage(0);
            employee.SetMonthlyWage(0);


            return employee;
        }

        //method to calculate daily wages 
        public Employee CalculateDailyWage()
        {
            employee = new Employee();

            int wagePerHour = 20;
            int fullDayHour = 8;
            double dailyWage = wagePerHour * fullDayHour;

            employee.SetEmployeeId(1);
            employee.SetEmployeeName("Pradeep");
            employee.SetIsPresent(true);
            employee.SetDailyWage(dailyWage);

            return employee;
        }

        //method to calculate part time wages
        public Employee CalculatePartTimeWage()
        {
            employee = new Employee();

            int wagePerHour = 20;
            int partTimeHour = 4;   
            double partTimeWage = wagePerHour * partTimeHour;

            employee.SetEmployeeId(1);
            employee.SetEmployeeName("Pradeep");
            employee.SetIsPresent(true);
            employee.SetPartTimeWage(partTimeWage);

            return employee;
        }
        //method to calculate the total number of days employee is present
        public int GetPresentDays()
        {
            int presentDays = 0;
            Random random = new Random();

            for (int day = 1; day <= WorkingDays; day++)
            {
                bool isPresent = random.Next(0, 2) == 1;
                if (isPresent)
                    presentDays++;
            }

            return presentDays;
        }

        //method to calculate monthly wage after getting the total working days
        public Employee CalculateMonthlyWage()
        {
            employee = new Employee();

            int wagePerHour = 20;
            int fullDayHour = 8;

            double dailyWage = wagePerHour * fullDayHour;
            int presentDays = GetPresentDays();
            double monthlyWage = dailyWage * presentDays;

            employee.SetEmployeeId(1);
            employee.SetEmployeeName("Pradeep");
            employee.SetIsPresent(true);
            employee.SetDailyWage(dailyWage);
            employee.SetPresentDays(presentDays);
            employee.SetMonthlyWage(monthlyWage);

            return employee;
        }
         //method to calculate monthly wage with condition
        public Employee CalculateWageWithCondition()
        {
            employee = new Employee();

            int wagePerHour = 20;
            int fullDayHour = 8;
            int maxDays = 20;
            int maxHours = 100;

            int totalDays = 0;
            int totalHours = 0;
            double totalWage = 0;

            // Calculate until either condition is reached
            while (totalDays < maxDays && totalHours < maxHours)
            {
                totalDays++;
                totalHours += fullDayHour;

                // if hours exceed limit
                if (totalHours > maxHours)
                {
                    totalHours = maxHours;
                    break;
                }

                totalWage += fullDayHour * wagePerHour;
            }

            employee.SetEmployeeId(1);
            employee.SetEmployeeName("Pradeep");
            employee.SetPresentDays(totalDays);
            employee.SetMonthlyWage(totalWage);

            return employee;
        }
    }
}
