namespace Vxchin.Utils.Logging.Infrastructure
{
    /// <summary>
    /// 用于维护日志系统自身生命周期的工具。
    /// </summary>
    public interface ILogLifetimeManager
    {
        /// <summary>
        /// 关闭日志系统，对资源进行必要的清理。
        /// </summary>
        void Shutdown();
    }
}
