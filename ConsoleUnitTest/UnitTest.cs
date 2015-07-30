﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using log4net;
using log4net.Config;


namespace ConsoleUnitTest
{
    [TestClass]
    public class UnitTest
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UnitTest));

        //if Properties -> AssemblyInfo.cs加入
        //[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config",Watch = true)]
        //then 可以不用寫此段程式碼
        /*[AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("./log4net.config"));
        }*/

        [TestMethod]
        public void TestMethod1()
        {
            
            IPerson Jane = new Taiwanese("婷婷");

            
            log.Debug("123");

            Jane.Age = 40;
            var varifying = "中華台北";

            Assert.AreEqual(Jane.Nationality,varifying);
            Assert.AreEqual(Jane.Age, 40);
        }


    }
}
