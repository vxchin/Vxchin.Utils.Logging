using Microsoft.Extensions.Logging;

namespace Vxchin.Utils.Logging.SimpleConsole
{
    /// <summary>
    /// Provides a very simple console logger that does not require a reference to Microsoft.Extensions.Logging.dll
    /// </summary>
    internal class SimpleConsoleLoggerFactory : ILoggerFactory
    {
        private readonly SimpleConsoleOptions _options;

        public SimpleConsoleLoggerFactory(SimpleConsoleOptions options)
        {
            _options = options;
        }

        /// <summary>
        /// The console logger is built-in here
        /// </summary>
        /// <param name="provider">Argument is ignored</param>
        public void AddProvider(ILoggerProvider provider)
        {
        }

        /// <inheritdoc/>
        public ILogger CreateLogger(string categoryName)
        {
            return new SimpleConsoleLogger(categoryName, _options);
        }

        /// <inheritdoc />
        public void Dispose()
        {
        }
    }
}