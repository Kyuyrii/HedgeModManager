﻿namespace HedgeModManager.Steam;
using System.Globalization;
using ValveKeyValue;

public static class KVExtensions
{
    public static KVObject? GetCaseInsensitive(this KVObject obj, string key)
        => obj.FirstOrDefault(x => x.Name.Equals(key, StringComparison.OrdinalIgnoreCase));

    public static string GetString(this KVObject? obj)
        => obj?.Value?.ToString(CultureInfo.InvariantCulture) ?? string.Empty;

    public static int GetInteger(this KVObject? obj, int defaultValue = 0)
        => obj?.Value?.ToInt32(CultureInfo.InvariantCulture) ?? defaultValue;
}