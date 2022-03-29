# Vxchin.Utils.Logging

一个封装了 `Microsoft.Extensions.Logging` 通用的日志类库。

在一些应用开发场景中，类库项目不希望过多引入第三方 NuGet 包。通过在解决方案中引入本项目，类库项目可通过仅添加对本项目的依赖，实现全功能、高效的日志记录功能。

本项目内置了对控制台输出的支持，并通过 `Vxchin.Utils.Logging.Log4Net` 提供了对 log4net 的支持。

## 使用方法

> 实际用法可参见 `samples` 中的示例项目。

### 引入日志类库

1. 在解决方案中添加 `Vxchin.Utils.Logging` 的源代码。

   > - 可根据需要通过在文件中查找与替换将 `Vxchin.Utils.Logging` 替换为适合自己的命名空间。

2. 对于[非 SDK 样式](https://docs.microsoft.com/zh-cn/nuget/resources/check-project-format)的项目（如传统的 .NET Framework 项目），需要在主程序项目中添加对 NuGet 包 [`Microsoft.Extensions.Logging.Abstractions`](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions/5.0.0) 5.0.0 的引用。

3. 在进行日志记录前，调用 `Log.GlabalConfig()` 方法获取配置器，并调用在配置器上的方法对日志系统进行配置。

   > 未进行配置时，日志系统将仅在控制台输出 `Information` 及以上级别的日志信息，并且不输出异常的调用堆栈。

   ```csharp
   static void Main(string[] args) {
       Log.GlobalConfig().UseSimpleConsole(LogLevel.Trace, printStackTrace: true);
       // ...
   }
   ```

4. 在程序退出前，调用 `Log.Lifetime().Shutdown()` 方法关闭日志系统，以允许日志系统进行必要的清理工作。

   > 对于仅控制台输出的场景下，可以不调用该方法。
   
   ```csharp
   // 控制台应用
   static void Main(string[] args) {
       \\ ...
       Log.lifetime().Shutdown();
   }
   // Windows Forms 应用
   [STAThread]
   static void Main() {
       Application.ApplicationExit += OnApplicationExit;
   }
   private static void OnApplicationExit(object sender, EventArgs e) {
       Log.Lifetime().Shutdown();
   }
   ```

### 记录日志

1. 在需要记录日志的项目中添加对 `Vxchin.Utils.Logging` 项目的引用。

2. 在需要记录日志的类中调用 `Log.CreateLogger()` 方法的特定重载创建 `ILog` 的实例。

   ```csharp
   public class Calculator : ICalculator {
       private readonly ILog _logger = Log.CreateLogger<Calculator>();
   }
   ```

3. 在需要记录日志的位置调用 `ILog` 实例上的扩展方法进行日志的写入操作。

   ```csharp
   public class Calculator : ICalculator {
       private readonly ILog _logger = Log.CreateLogger<Calculator>();
       public decimal Add(decimal x, decimal y) {
           _logger.Debug("Calculating {X} {Operator} {Y}", x, '+' ,y);
           return x + y;
       }
   }
   ```
   
### 引入更多日志提供程序

对于需要更复杂日志输出的场景，可以通过调用 `Log.GlobalConfig().Advanced().UseFactory()` 方法传入任意自定义的 `ILoggerFactory` 对象。

用法详见 `samples\Vxchin.Utils.Logging.Samples.Advanced` 示例项目。