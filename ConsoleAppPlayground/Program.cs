using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppPlayground.Interfaces;
using StructureMap.Configuration.DSL;
using System.Configuration;

namespace ConsoleAppPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            var demoContainer = new Container(new DemoContainerRegistry());            
            var executor = demoContainer.GetInstance<IDemoExecutor>(ConfigurationManager.AppSettings["FeaturesToDemo"]);
            executor.ExecuteDemo();
            Console.ReadKey();
        }        
    }

    class DemoContainerRegistry : Registry
    {
        public DemoContainerRegistry()
        {
            For<IDemoExecutor>().Use<Csharp6Features.Csharp6FeaturesDemoExecutor>().Named("Csharp6Features");
            For<IDemoExecutor>().Use<OtherCsharpFeatures.OtherCsharpFeaturesDemoExecutor>().Named("OtherCsharpFeatures");
        }
    }
}

