using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Infrastructure;

namespace Vxchin.Utils.Logging.Internal
{
    internal class DefaultLogAdapter : ILogAdapter
    {
        public static readonly DefaultLogAdapter Instance = new DefaultLogAdapter();

        public ILog Adapt(ILogger logger)
        {
            return new DefaultLogImpl(logger);
        }
    }
}