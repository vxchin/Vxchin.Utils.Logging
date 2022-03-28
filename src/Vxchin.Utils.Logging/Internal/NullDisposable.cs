using System;

namespace Vxchin.Utils.Logging.Internal
{
    /// <summary>
    /// 表示一个空的 <see cref="IDisposable"/> 的实例。
    /// </summary>
    internal class NullDisposable : IDisposable
    {
        private NullDisposable()
        {
        }

        public static NullDisposable Instance { get; } = new NullDisposable();

        /// <summary>
        /// 不做任何事情。
        /// </summary>
        public void Dispose()
        {
        }
    }
}