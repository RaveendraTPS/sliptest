using Microsoft.Extensions.Configuration;

namespace Models
{
    public class Helper
    {
        private static IConfiguration _configuration;
        public static string ConnectionString { get; set; }
        public static void LoadConfigurations(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = configuration.GetConnectionString("SlipTest");
        }
    }
}