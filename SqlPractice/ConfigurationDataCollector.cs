using Microsoft.Extensions.Configuration;

namespace SqlPractice
{
    public class ConfigurationDataCollector
    {
        private readonly IConfiguration _config;
        
        public ConfigurationDataCollector()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _config = builder.Build();
        }

        public string GetSqlServerConnection()
            => _config["ConnectionString:SqlServer"];
    }
}
