using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Infrastructure;

namespace Vxchin.Utils.Logging.Internal
{
    /// <summary>
    /// <see cref="ILog"/> 接口的默认实现。
    /// </summary>
    internal class DefaultLogImpl : ILog, ILoggerWrapper
    {
        private readonly ILogger _logger;

        public DefaultLogImpl(ILogger logger)
        {
            _logger = logger;
        }

        ILogger ILoggerWrapper.Logger => _logger;
    }
}