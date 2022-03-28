#if M_E_DI
using Microsoft.Extensions.DependencyInjection;
#endif
using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Infrastructure;

namespace Vxchin.Utils.Logging.Log4Net
{
    /// <summary>
    /// The log4net extensions class.
    /// </summary>
    public static class Log4NetExtensions
    {
        /// <summary>
        /// Uses the log4net.
        /// </summary>
        /// <param name="configurator">The configurator.</param>
        /// <returns>The <see cref="ILogConfigurator"/> with added Log4Net provider</returns>
        public static ILogConfigurator UseLog4Net(this ILogConfigurator configurator)
            => configurator.UseLog4Net(new Log4NetProviderOptions());

        /// <summary>
        /// Uses the log4net.
        /// </summary>
        /// <param name="configurator">The configurator.</param>
        /// <param name="log4NetConfigFile">The log4net Config File.</param>
        /// <returns>The <see cref="ILogConfigurator"/> after adding the log4net provider.</returns>
        public static ILogConfigurator UseLog4Net(this ILogConfigurator configurator, string log4NetConfigFile)
            => configurator.UseLog4Net(log4NetConfigFile, false);

        /// <summary>
        /// Uses the log4net logging provider.
        /// </summary>
        /// <param name="configurator">The configurator.</param>
        /// <param name="log4NetConfigFile">The log4 net configuration file.</param>
        /// <param name="watch">if set to <c>true</c> [watch].</param>
        /// <returns>The <see cref="ILogConfigurator"/> after adding the log4net provider.</returns>
        public static ILogConfigurator UseLog4Net(this ILogConfigurator configurator, string log4NetConfigFile, bool watch)
            => configurator.UseLog4Net(new Log4NetProviderOptions(log4NetConfigFile, watch));

        /// <summary>
        /// Uses the log4net logging provider.
        /// </summary>
        /// <param name="configurator">The logger configurator.</param>
        /// <param name="options">The options for log4net provider.</param>
        /// <returns>The <see cref="ILogConfigurator"/> after adding the log4net provider.</returns>
        public static ILogConfigurator UseLog4Net(this ILogConfigurator configurator, Log4NetProviderOptions options)
        {
            configurator.Advanced().UseProvider(new Log4NetProvider(options));
            return configurator;
        }

#if !NETCOREAPP1_1 && M_E_DI
        /// <summary>
        /// Uses the log4net logging provider.
        /// </summary>
        /// <param name="builder">The logging builder instance.</param>
        /// <returns>The <see ref="ILoggingBuilder" /> passed as parameter with the new provider registered.</returns>
        public static ILoggingBuilder UseLog4Net(this ILoggingBuilder builder)
        {
            var options = new Log4NetProviderOptions();
            return builder.UseLog4Net(options);
        }

        /// <summary>
        /// Uses the log4net logging provider.
        /// </summary>
        /// <param name="builder">The logging builder instance.</param>
        /// <param name="log4NetConfigFile">The log4net Config File.</param>
        /// <returns>The <see ref="ILoggingBuilder" /> passed as parameter with the new provider registered.</returns>
        public static ILoggingBuilder UseLog4Net(this ILoggingBuilder builder, string log4NetConfigFile)
        {
            var options = new Log4NetProviderOptions(log4NetConfigFile);
            return builder.UseLog4Net(options);
        }

        /// <summary>
        /// Uses the log4net logging provider.
        /// </summary>
        /// <param name="builder">The logging builder instance.</param>
        /// <param name="log4NetConfigFile">The log4net Config File.</param>
        /// <param name="watch">if set to <c>true</c>, the configuration will be reloaded when the xml configuration file changes.</param>
        /// <returns>
        /// The <see ref="ILoggingBuilder" /> passed as parameter with the new provider registered.
        /// </returns>
        public static ILoggingBuilder UseLog4Net(this ILoggingBuilder builder, string log4NetConfigFile, bool watch)
        {
            var options = new Log4NetProviderOptions(log4NetConfigFile, watch);
            return builder.UseLog4Net(options);
        }

        /// <summary>
        /// Uses the log4net logging provider.
        /// </summary>
        /// <param name="builder">The logging builder instance.</param>
        /// <param name="log4NetConfigFile">The log4net Config File.</param>
        /// <returns>The <see ref="ILoggingBuilder" /> passed as parameter with the new provider registered.</returns>
        public static ILoggingBuilder UseLog4Net(this ILoggingBuilder builder, Log4NetProviderOptions options)
        {
            builder.Services.AddSingleton<ILoggerProvider>(new Log4NetProvider(options));
            return builder;
        }
#endif
    }
}