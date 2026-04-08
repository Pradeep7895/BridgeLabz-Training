using System;
using System.Reflection;


namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RoleAllowedAttribute : Attribute
    {
        public string Role { get; }

        public RoleAllowedAttribute(string role)
        {
            Role = role;
        }
    }

    [RoleAllowed("ADMIN")]
    public class AdminService
    {
        public void DeleteUser()
        {
            Console.WriteLine("User deleted successfully.");
        }

        public void ViewReports()
        {
            Console.WriteLine("Viewing admin reports.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Simulated logged-in user role
            string currentUserRole = "USER"; 

            Type serviceType = typeof(AdminService);

            // Read RoleAllowed attribute using reflection
            RoleAllowedAttribute roleAttribute = serviceType.GetCustomAttribute<RoleAllowedAttribute>();

            if (roleAttribute != null)
            {
                if (roleAttribute.Role == currentUserRole)
                {
                    // Role matches - allow access
                    AdminService service = new AdminService();
                    service.DeleteUser();
                    service.ViewReports();
                }
                else
                {
                    // Role mismatch - deny access
                    Console.WriteLine("Access Denied!");
                }
            }
        }
    }
}
