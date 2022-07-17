using Microsoft.Extensions.Configuration;

namespace WorkingWithDB.Configs
{
    public class ConnectionConfig
    {
        public IConfigurationRoot Build()
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("Configs//appsettings.json");

            var config = builder.Build();

            return config;
        }
    }
}
