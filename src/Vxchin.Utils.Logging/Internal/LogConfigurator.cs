using System;
using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Infrastructure;

namespace Vxchin.Utils.Logging.Internal
{
    internal class LogConfigurator : ILogConfigurator, ILogAdvancedConfigurator
    {
        private readonly LogOptions _options;

        public LogConfigurator(LogOptions options)
        {
            _options = options;
        }

        public ILogAdvancedConfigurator UseFactory(ILoggerFactory loggerFactory)
        {
            if (_options.IsLoggerFactoryConfigured) throw new ArgumentException("请勿重复配置日志系统。");
            _options.LoggerFactory = loggerFactory;
            return this;
        }

        public ILogAdvancedConfigurator UseAdapter(ILogAdapter adapter)
        {
            _options.LogAdapter = adapter;
            return this;
        }

        public ILogAdvancedConfigurator Advanced()
        {
            return this;
        }

        ILogConfigurator ILogAdvancedConfigurator.Configurator => this;
    }
}