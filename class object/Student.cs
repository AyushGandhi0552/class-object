using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object
{
    public class Student
    {
        public int Id = 0;
        public string Name = "";
        public int sub1 = 0;
        public int sub2 = 0;
        

        public void Input()
        {
            Console.WriteLine("Please Enter ID");
            Id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Name");
            Name = Console.ReadLine();

            Console.WriteLine("Please Enter Marks of Sub1:");
            sub1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Marks of Sub2:");
            sub2=Convert.ToInt32(Console.ReadLine());
        }
        public void Output() 
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(sub1+sub2);
        }
    }
}
