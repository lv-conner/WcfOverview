using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Activation;
using System.ServiceModel;
using Services;
using Interface;
using System.ServiceModel.Description;
using Autofac.Integration.Wcf;
using Autofac;

namespace Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(NameService)))
            {
                //host.AddServiceEndpoint(typeof(INameService), new BasicHttpBinding(), "http://localhost:46468/NameService");
                //host.AddServiceEndpoint(typeof(INameService), new BasicHttpBinding(), "http://localhost:9562/NameService");
                //if(host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                //{
                //    var metadataBehavior = new ServiceMetadataBehavior();
                //    metadataBehavior.HttpGetEnabled = true;
                //    metadataBehavior.HttpGetUrl =  new Uri("http://localhost:46468/NameService/meta");
                //    host.Description.Behaviors.Add(metadataBehavior);
                //    host.Opened += Host_Opened;
                //    host.Open();
                //    Console.ReadKey();
                //}
                host.Opened += Host_Opened;
                host.Open();
                ContainerBuilder containerBuilder = new ContainerBuilder();
                containerBuilder.RegisterType<Services>().As<IServices>();
                host.AddDependencyInjectionBehavior<IServices>(containerBuilder.Build());
                Console.ReadKey();
            }
            Console.WriteLine("hello word");
        }

        private static void Host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Service open press any key to close!");
        }
    }


    public interface IServices
    {
        
    }
    public class Services:IServices
    {

    }
}
