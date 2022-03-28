using System;
using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Infrastructure;
using Vxchin.Utils.Logging.SimpleConsole;

namespace Vxchin.Utils.Logging.Internal
{
    internal class LogOptions
    {
        private static readonly Lazy<ILoggerFactory> DefaultLoggerFactory =
            new Lazy<ILoggerFactory>(CreateDefaultLoggerFactory);

        private ILogAdapter _logAdapter;
        private ILoggerFactory _loggerFactory;


        public ILogAdapter LogAdapter
        {
            get => _logAdapter ?? DefaultLogAdapter.Instance;
            set => _logAdapter = value;
        }

        public bool IsLoggerFactoryConfigured => _loggerFactory != null;


        public ILoggerFactory LoggerFactory
        {
            get => _loggerFactory ?? DefaultLoggerFactory.Value;
            set => _loggerFactory = value ?? throw new ArgumentNullException(nameof(value));
        }

        private static ILoggerFactory CreateDefaultLoggerFactory()
        {
            var options = new SimpleConsoleOptions
            {
                MinimumLogLevel = LogLevel.Information,
                PrintStackTrace = false
            };
            return new SimpleConsoleLoggerFactory(options);
        }
    }
}