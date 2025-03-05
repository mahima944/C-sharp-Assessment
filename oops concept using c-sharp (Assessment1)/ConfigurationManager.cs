using System;
using System.Collections.Concurrent;

public sealed class ConfigurationManager
{
    private static readonly Lazy<ConfigurationManager> _instance =
        new Lazy<ConfigurationManager>(() => new ConfigurationManager());

    private readonly ConcurrentDictionary<string, string> _settings;

    private ConfigurationManager()
    {
        _settings = new ConcurrentDictionary<string, string>();
    }

    public static ConfigurationManager Instance => _instance.Value;

    public void SetConfig(string key, string value)
    {
        _settings[key] = value;
    }

    public string GetConfig(string key)
    {
        return _settings.TryGetValue(key, out var value) ? value : null;
    }
}
