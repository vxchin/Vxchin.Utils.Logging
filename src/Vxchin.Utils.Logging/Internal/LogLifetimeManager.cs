using Vxchin.Utils.Logging.Infrastructure;

namespace Vxchin.Utils.Logging.Internal
{
    internal class LogLifetimeManager : ILogLifetimeManager
    {
        private readonly LogOptions _options;

        public LogLifetimeManager(LogOptions options)
        {
            _options = options;
        }

        public void Shutdown()
        {
            _options.LoggerFactory.Dispose();
        }
    }
}