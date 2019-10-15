using System;
using Castle.Windsor;
using Richiban.CommandLine;

namespace SqlDeployer.CmdClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            var config = CommandLineConfiguration.GetDefault();

            config.ObjectFactory = container.Resolve;

            CommandLine.Execute(config, args);
        }
    }
}
