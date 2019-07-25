using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using AutoFac;
using IContainer = Autofac.IContainer;

namespace AutoFac
{
    internal class Program
    {
        private static IContainer Container { get; set; }

        private static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<VerificationCodeService>().As<IVerification>();
            builder.RegisterType<AuthenticationService>();
            Container = builder.Build();

            var authenticationService = Container.Resolve<AuthenticationService>();

            Console.WriteLine(authenticationService.Login("Guy", "i am password") ? "logged in" : "logged failed");

            Console.ReadLine();
        }
    }
}