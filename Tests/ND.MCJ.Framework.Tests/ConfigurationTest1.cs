using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ND.MCJ.Framework.Tests
{
    [TestClass]
    public class ConfigurationTest1
    {
        [TestMethod]
        public void ConfigurationTest()
        {
            var config = Configuration.Get("EasemobConfig");
            //Assert.IsTrue(config == "Config/easemob.config");
            //var settings = Configuration.GetCollection(config);
            //Assert.IsTrue(settings["MachineID"].Value == "a");
            //Configuration.Set("MachineID", "b", config);
            //settings = Configuration.GetCollection(config);
            //Assert.IsTrue(settings["MachineID"].Value == "b");

            //var aa = Configuration.Get("NLogConfig");
            //Assert.IsTrue(aa == "wwwww");
            //Configuration.Set("NLogConfig", "123");
            // aa = Configuration.Get("NLogConfig");
            //Assert.IsTrue(aa == "123");

            //Configuration.Add("T1", "aaaa");
            //var bb = Configuration.Get("T1");
            //Assert.IsTrue(bb == "aaaa");
            Configuration.Add("T2", "aaa", config);
            var cc = Configuration.Get("T2", config);
            Assert.IsTrue(cc == ",aaa");
        }
    }
}
