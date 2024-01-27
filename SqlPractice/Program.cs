using Microsoft.EntityFrameworkCore;
using SqlPractice.Repository;

namespace SqlPractice
{
    class Program
    {
        static void Main()
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            try
            {
                var config = new ConfigurationDataCollector();
                using var context = new EFCoreContext(config.GetSqlServerConnection());

                var data = await context.Concerns.ToListAsync();
                foreach (var item in data)
                    Console.WriteLine(item.Name);

                var spRepo = new StoredProcRepo(context);
                var vehicles = await spRepo.GetVehiclePrRecords("", 2, 10);
                foreach (var item in vehicles)
                    Console.WriteLine($"VehicleType: {item.VehicleType}, Status: {item.Status}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

