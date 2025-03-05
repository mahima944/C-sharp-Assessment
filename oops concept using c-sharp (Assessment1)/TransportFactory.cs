using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    using System;

    interface ITransport
    {
        void DisplayInfo();
    }

    class Sedan : ITransport
    {
        public void DisplayInfo()
        {
            Console.WriteLine("This is a Sedan.");
        }
    }

    class Motorcycle : ITransport
    {
        public void DisplayInfo()
        {
            Console.WriteLine("This is a Motorcycle.");
        }
    }

    class TransportFactory
    {
        public static ITransport GetTransport(string transportType)
        {
            switch (transportType.ToLower())
            {
                case "sedan":
                    return new Sedan();
                case "motorcycle":
                    return new Motorcycle();
                default:
                    throw new ArgumentException("Invalid transport type");
            }
        }
    }

}
