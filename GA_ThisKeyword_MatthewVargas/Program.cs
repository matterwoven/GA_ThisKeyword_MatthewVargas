using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace GA_ThisKeyword_MatthewVargas
{
    internal class Program
    {
        //Matthew Vargas
        //1.19.2024
        static void Main(string[] args)
        {
            Console.WriteLine("Checking employee databases, displaying data");
            Person.Test();
            Console.WriteLine("----");
            Console.WriteLine("Thank you for using this service");
        }
    }
}
