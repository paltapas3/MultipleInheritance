using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    interface Addnumber
    {
        int add(int a, int b);
    }
    interface SubNumber
    {
        int sub(int x, int y);
    }
    interface MultiNumber
    {
        int mul(int r, int s);
    }
    interface DivNumber
    {
        int div(int c, int d);
    }
    // Implemented all the interfaces 
    class MultipleInheritance : Addnumber, SubNumber, MultiNumber, DivNumber
    {
        public int result1;
        public int add(int a, int b)
        {
            return result1 = a + b;
        }
        public int result2;
        public int sub(int x, int y)
        {
            return result2 = x - y;
        }
        public int result3;
        public int mul(int r, int s)
        {
            return result3 = r * s;
        }
        public int result4;
        public int div(int c, int d)
        {
            return result4 = c / d;
        }

        static void Main(string[] args)
        {
            MultipleInheritance c = new MultipleInheritance();
            c.add(8, 2);
            c.sub(20, 10);
            c.mul(5, 2);
            c.div(20, 10);
            Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");
            Console.WriteLine("Addition Value: " + c.result1);
            Console.WriteLine("Substraction Value: " + c.result2);
            Console.WriteLine("Multiplication Value :" + c.result3);
            Console.WriteLine("Division Value: " + c.result4);
            Console.ReadKey();
        }
    }
}
