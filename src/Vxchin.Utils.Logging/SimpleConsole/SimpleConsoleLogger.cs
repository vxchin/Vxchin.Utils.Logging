using System;
using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Internal;

namespace Vxchin.Utils.Logging.SimpleConsole
{
    /// <summary>
    /// A simple console logger - logs all incoming log messages to the console
    /// </summary>
    internal class SimpleConsoleLogger : ILogger
    {
        /// <summary>
        /// Name of the logger
        /// </summary>
        private readonly string _loggerName;

        private readonly SimpleConsoleOptions _options;

        /// <summary>
        /// Creates console output with color support
        /// </summary>
        public SimpleConsoleLogger(string loggerName, SimpleConsoleOptions options)
        {
            _options = options;
            _loggerName = loggerName;
        }

        /// <inheritdoc />
        public void Log<TState>(
            LogLevel logLevel, EventId eventId, TState state, Exception exception,
            Func<TState, Exception, string> formatter)
        {
            var previousForeColor = Console.ForegroundColor;
            var previousBackColor = Console.BackgroundColor;
            switch (logLevel)
            {
                case LogLevel.Critical:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogLevel.Debug:
                case LogLevel.Trace:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }

            var msg = formatter(state, exception);
            Console.WriteLine($"[{Format(logLevel)}] {_loggerName} - {msg}");
            if (exception != null)
            {
                Console.WriteLine($"{exception.GetType().FullName}: {exception.Message}");
                if (_options.PrintStackTrace) Console.WriteLine(exception.StackTrace);
            }
            Console.ForegroundColor = previousForeColor;
            Console.BackgroundColor = previousBackColor;
        }

        /// <inheritdoc />
        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel >= _options.MinimumLogLevel;
        }

        /// <inheritdoc />
        public IDisposable BeginScope<TState>(TState state)
        {
            return NullDisposable.Instance;
        }

        private string Format(LogLevel logLevel)
        {
            return _options.LogLevelConverter.Convert(logLevel);
        }
    }
}