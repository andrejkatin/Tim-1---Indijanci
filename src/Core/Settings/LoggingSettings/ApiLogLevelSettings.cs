﻿using Serilog.Events;

namespace Bit.Core.Settings.LoggingSettings;

public class ApiLogLevelSettings : IApiLogLevelSettings
{
    public LogEventLevel Default { get; set; } = LogEventLevel.Error;
    public LogEventLevel IdentityToken { get; set; } = LogEventLevel.Fatal;
    public LogEventLevel IpRateLimit { get; set; } = LogEventLevel.Information;
}
