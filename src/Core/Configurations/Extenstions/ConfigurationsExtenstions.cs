using Microsoft.Extensions.Configuration;

namespace Core.Configurations.Extenstions;

/// <summary>
/// 
/// </summary>
public static class ConfigurationsExtenstions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static Settings GetSettings(this IConfiguration configuration)
    {
        var settings = configuration.Get<Settings>();

        return settings;
    }
}