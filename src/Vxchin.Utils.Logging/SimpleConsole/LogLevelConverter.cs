using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Vxchin.Utils.Logging.SimpleConsole
{
    internal class LogLevelStringConverter : ILogLevelConverter<string>
    {
        private static readonly IDictionary<LogLevel, string> Mapping = new Dictionary<LogLevel, string>
        {
            [LogLevel.Trace] = "TRC",
            [LogLevel.Debug] = "DBG",
            [LogLevel.Information] = "INF",
            [LogLevel.Warning] = "WRN",
            [LogLevel.Error] = "ERR",
            [LogLevel.Critical] = "CRI",
        };

        public string Convert(LogLevel logLevel)
        {
            return Mapping.TryGetValue(logLevel, out var result) ? result : String.Empty;
        }
    }
}