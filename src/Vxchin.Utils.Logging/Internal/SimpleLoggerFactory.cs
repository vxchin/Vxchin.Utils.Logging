using System;
using Microsoft.Extensions.Logging;

namespace Vxchin.Utils.Logging.Internal
{
    /// <summary>
    /// 使用单个 <see cref="ILoggerProvider"/> 的实例创建 <see cref="ILogger"/> 的 <see cref="ILoggerFactory"/> 实现。
    /// </summary>
    internal class SimpleLoggerFactory : ILoggerFactory
    {
        private readonly ILoggerProvider _provider;

        private SimpleLoggerFactory(ILoggerProvider provider)
        {
            _provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// 使用给定的 <see cref="ILoggerProvider"/> 实例创建一个 <see cref="ILoggerFactory"/> 对象。
        /// </summary>
        /// <param name="provider">给定的 <see cref="ILoggerProvider"/> 实例。</param>
        /// <returns></returns>
        public static ILoggerFactory Create(ILoggerProvider provider) => new SimpleLoggerFactory(provider);

        public ILogger CreateLogger(string categoryName)
        {
            return _provider.CreateLogger(categoryName);
        }

        public void AddProvider(ILoggerProvider provider)
        {
            throw new NotSupportedException(
                $"不支持为 {nameof(SimpleLoggerFactory)} 添加新的 provider。请使用其他类型的 ILoggerFactory 对象");
        }

        public void Dispose()
        {
            _provider.Dispose();
        }
    }
}