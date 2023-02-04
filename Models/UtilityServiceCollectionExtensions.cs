using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class UtilityServiceCollectionExtensions
    {
        public static IServiceCollection AddUtilityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            Helper.LoadConfigurations(configuration);
            return services;
        }

    }
}