using Microsoft.VisualStudio.TestTools.UnitTesting;
using ND.MCJ.AOP;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ND.MCJ.AOP.Logging;

namespace ND.MCJ.AOP.Tests
{
    [TestClass]
    public class NLogTests
    {
        [TestMethod]
        public void TestNLog()
        {
            Logger.Start(ConfigurationManager.AppSettings["NLogConfig"]);
            var content = "测试测试";
            Logger.Error(content);
            Assert.IsNotNull(content);
        }
    }
}
