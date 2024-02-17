using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student information = new Student();

            information.Input();
            information.Output();
            Console.ReadKey();
        }
    }
}
