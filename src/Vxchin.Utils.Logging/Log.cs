using System;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Infrastructure;
using Vxchin.Utils.Logging.Internal;

namespace Vxchin.Utils.Logging
{
    /// <summary>
    /// 提供一组与日志系统交互的静态方法。
    /// <remarks>
    ///   使用日志系统，需要遵循以下步骤：
    ///   <list type="number">
    ///   <item>
    ///       在需要记录日志消息的类中调用适当的 <see cref="CreateLogger{T}"/> 方法或其其他重载方法，创建适当的 <see cref="ILog"/> 实例。
    ///       <para>一般地，该实例是线程安全的，可以作为特定类型的成员变量或者静态成员变量保存并使用。 </para>
    ///   </item>
    ///   <item>调用 <see cref="ILog"/> 上特定扩展方法，记录日志消息。</item>
    ///   </list>
    /// </remarks>
    /// <remarks>
    ///   在整个应用程序的生命周期中：
    ///   <list type="bullet">
    ///   <item>记录日志消息前，首先调用 <see cref="Config"/> 上的方法完成对日志系统的配置。</item>
    ///   <item>在应用程序退出前，需要调用 <see cref="Lifetime"/> 上的 <see cref="ILogLifetimeManager.Shutdown"/> 方法关闭日志系统，完成必要的清理操作。</item>
    ///   </list>
    /// </remarks>
    /// </summary>
    public static class Log
    {
        private static readonly LogOptions Options = new LogOptions();
        private static readonly ILogConfigurator Configurator;
        private static readonly ILogLifetimeManager LifetimeManager;

        static Log()
        {
            Configurator = new LogConfigurator(Options);
            LifetimeManager = new LogLifetimeManager(Options);
        }

        /// <summary>
        /// 获取用于配置日志系统的配置器。
        /// </summary>
        [PublicAPI]
        public static ILogConfigurator Config() => Configurator;

        /// <summary>
        /// 获取用于管理日志系统生命周期的管理器。
        /// </summary>
        [PublicAPI]
        public static ILogLifetimeManager Lifetime() => LifetimeManager;

        /// <summary>
        /// 使用给定的类型名称创建一个新的 <see cref="ILogger"/> 实例。
        /// </summary>
        /// <param name="categoryName">记录器生成的消息的类别名称。</param>
        /// <returns>创建的 <see cref="ILog"/>。</returns>
        [PublicAPI]
        public static ILog CreateLogger(string categoryName) =>
            Options.LoggerFactory.CreateLogger(categoryName).ToLog(Options);

        /// <summary>
        /// 使用给定类型的全名创建一个新的 <see cref="ILog"/> 实例。
        /// </summary>
        /// <typeparam name="T">类型。</typeparam>
        /// <returns>创建的 <see cref="ILog"/>。</returns>
        [PublicAPI]
        public static ILog CreateLogger<T>() => CreateLogger(typeof(T));

        /// <summary>
        /// 使用给定 <paramref name="type"/> 的全名创建一个新的 <see cref="ILogger"/> 实例。
        /// </summary>
        /// <param name="type">类型。</param>
        /// <returns>创建的 <see cref="ILog"/>。</returns>
        [PublicAPI]
        public static ILog CreateLogger(Type type) => Options.LoggerFactory.CreateLogger(type).ToLog(Options);

        /// <summary>
        /// 适用当前类的全名创建一个新的 <see cref="ILogger"/> 实例。
        /// </summary>
        /// <returns>创建的 <see cref="ILog"/>。</returns>
        [Obsolete("Use CreateLogger() instead.")]
        [PublicAPI]
        public static ILog CreateCurrentClassLogger() => CreateLogger(StackTraceUtils.GetStackTraceClass());
    }
}