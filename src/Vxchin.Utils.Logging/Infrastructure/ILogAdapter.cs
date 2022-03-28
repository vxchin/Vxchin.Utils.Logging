using Microsoft.Extensions.Logging;

namespace Vxchin.Utils.Logging.Infrastructure
{
    /// <summary>
    /// 表示用于从 <see cref="ILogger"/> 创建 <see cref="ILog"/> 实例的类型。
    /// </summary>
    public interface ILogAdapter
    {
        /// <summary>
        /// 使用指定的 <see cref="ILogger"/> 实例创建一个 <see cref="ILog"/> 实例。
        /// </summary>
        /// <param name="logger">用于创建 <see cref="ILog"/> 实例的 <see cref="ILogger"/> 实例。</param>
        /// <returns>创建的 <see cref="ILog"/> 实例。</returns>
        ILog Adapt(ILogger logger);
    }
}