using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using log4net.Config;
using log4net;

namespace ConsoleApp
{
    class ConsoleUI
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ConsoleUI));

        static void Main(string[] args)
        {
            //if Properties -> AssemblyInfo.cs加入
            //[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config",Watch = true)]
            //then 可以不用寫此段程式碼
            //XmlConfigurator.Configure(new System.IO.FileInfo("./log4net.config"));
            log.Debug("123");

            IPerson Tom = new Taiwanese("阿忠");
            Tom.Age = 25;
            Console.WriteLine("{0} comes from {1}.", Tom.Name, Tom.Nationality);
            Console.WriteLine("How old is he/she? {0} Did he/she get married? {1}", Tom.Age, Tom.Married(Tom.Age));

            Console.WriteLine();

            IPerson Joe = new Taiwanese("忠忠");
            Joe.Age = 25;
            Console.WriteLine("{0} comes from {1}.", Joe.Name, Joe.Nationality);
            Console.WriteLine("How old is he/she? {0} Did he/she get married? {1}", Joe.Age, Joe.Married(Joe.Age));

            Console.ReadKey();


        }
    }
}
