using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GA_ThisKeyword_MatthewVargas
{
    internal class Person
    {
        private string Name;
        private int Wagehourly;

        public Person(string name, int wagehourly)
        {
            this.Name = name;
            this.Wagehourly = wagehourly;
        }
        public void Info()
        {
            Console.WriteLine($"Name: {this.Name} - Wage: ${this.Wagehourly}/hr"); //With multiple string and int values avaliable at once in the same class objects are more adaptable and flexible
        }

        public static void Test()
        {
            Person[] employees = new Person[2];

            employees[0] = new Person("Jesse", 24);
            employees[1] = new Person("Matthew", 17);
            
            foreach (Person employee in employees)
            {
                employee.Info();
            }
        }



    }
}
