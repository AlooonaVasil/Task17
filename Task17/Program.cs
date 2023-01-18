using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Client<int> client1 = new Client<int>();
            client1.InputInfo();
            Console.WriteLine(client1.GetInfo());

            Client<string> client2 = new Client<string>();
            client2.InputInfo();
            Console.WriteLine(client2.GetInfo());

            Console.ReadKey();
        }
    }

}
