using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;


namespace AppSettingsManager
{
    public static class ConfigurationExtention
    {
        public static void AddConfiguration<T>(IConfiguration configuration){
         new ConfigureFromConfigurationOptions<T>(configuration.GetSection(configuration));
        }
    }
}