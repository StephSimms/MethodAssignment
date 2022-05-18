using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number: 10, 20, 30, 40, 50, 60");
            int userInp = Convert.ToInt32(Console.ReadLine());

            Class1 obj1 = new Class1();

            Console.WriteLine("Your number quintupled is " + obj1.intquintuple(userInp));
            Console.WriteLine("Your number sextupled is " + obj1.intsextuple(userInp));
            Console.WriteLine("Your number septupled is " + obj1.intseptuple(userInp));
            Console.ReadLine();

        }
    }
}
