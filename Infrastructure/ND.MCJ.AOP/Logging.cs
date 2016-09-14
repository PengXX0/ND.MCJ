using NLog;
using NLog.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace ND.MCJ.AOP
{
    /// <summary>
    /// 全局日志类
    /// 1、使用NLog记录日志
    /// 2、简化日志记录层级，只包括DEBUG，INFO，ERROR三个层级
    /// 3、简化日志操作
    /// </summary>
    public static class Logging
    {
        private static ILogger log;

        public static void Initialize(string filePath)
        {
            LogManager.Configuration = new XmlLoggingConfiguration("../../" + filePath);
            log = LogManager.GetLogger("GlobalLog");
        }

        public static ILogger GetLogger(string typeName)
        {
            return LogManager.GetLogger(typeName);
        }

        public static ILogger GetLogger(Type type)
        {
            return LogManager.GetCurrentClassLogger(type);
        }

        public static bool IsDebugEnabled
        {
            get { return log.IsDebugEnabled; }
        }

        public static void Debug(object message)
        {
            log.Debug(message);
        }

        public static void DebugFormat(string format, params object[] args)
        {
            log.Debug(format, args);
        }

        public static void Error(object message)
        {
            log.Error(message);
        }

        public static void Error(Exception exception, string message, params object[] args)
        {
            log.Error(message, exception, args);
        }

        public static void ErrorFormat(string format, params object[] args)
        {
            log.Error(format, args);
        }

        public static void Info(object message)
        {
            log.Info(message);
        }

        public static void InfoFormat(string format, params object[] args)
        {
            log.Info(format, args);
        }
    }
}
