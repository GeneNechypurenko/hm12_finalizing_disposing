using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm12_finalizing_disposing
{
    internal class Store : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public Store(string name, string address, string type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        ~Store() { Console.WriteLine($"Store {Name} destroyed"); }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Type: {Type}");
        }
        public void Dispose() { Console.WriteLine($"Store {Name} destroyed"); }
    }
}
