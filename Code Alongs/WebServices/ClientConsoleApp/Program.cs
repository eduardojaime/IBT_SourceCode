using ClientConsoleApp.WCFContactsService;
using ClientConsoleApp.WCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactsServiceClient service = new ContactsServiceClient();
            Console.WriteLine(service.DoWork());
            Console.ReadKey();

            ServiceClient service1 = new ServiceClient();
            CompositeType myCompositeType = new CompositeType();
            myCompositeType.StringValue = "testing";
            service1.GetDataUsingDataContract(myCompositeType);

        }
    }
}
