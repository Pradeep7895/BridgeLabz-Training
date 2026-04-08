using HealthClinic.Services;

namespace HealthClinic.Menu
{
    public class AdminMenu
    {
        private readonly AdminService service = new();

        public async Task ShowAsync()
        {
            while (true)
            {
                Console.WriteLine("\n--- System Administration ---");
                Console.WriteLine("1. Manage Specialties");
                Console.WriteLine("2. Backup Database");
                Console.WriteLine("3. View Audit Logs");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        await ManageSpecialtiesAsync();
                        break;

                    case 2:
                        await service.BackupDatabaseAsync();
                        Console.WriteLine("Backup completed.");
                        break;

                    case 3:
                        Console.Write("Table Name (or press Enter): ");
                        string table = Console.ReadLine();

                        Console.Write("Operation (INSERT/UPDATE/DELETE or press Enter): ");
                        string operation = Console.ReadLine();

                        var logs = await service.GetAuditLogsAsync(table, operation);

                        foreach (var log in logs)
                        {
                            Console.WriteLine($"{log.TableName} | {log.Operation} | Record ID: {log.RecordId} | {log.ChangedAt}");
                        }
                        break;

                    case 4:
                        return;
                }
            }
        }

        private async Task ManageSpecialtiesAsync()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. View All");

            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    Console.Write("Name: ");
                    await service.AddSpecialtyAsync(Console.ReadLine());
                    break;

                case 2:
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine()!);
                    Console.Write("New Name: ");
                    await service.UpdateSpecialtyAsync(id, Console.ReadLine());
                    break;

                case 3:
                    Console.Write("ID: ");
                    await service.DeleteSpecialtyAsync(int.Parse(Console.ReadLine()!));
                    break;

                case 4:
                    var list = await service.GetAllSpecialtiesAsync();
                    foreach (var s in list)
                        Console.WriteLine($"{s.SpecialtyId} | {s.SpecialtyName}");
                    break;
            }
        }
    }
}