using System;
namespace ref_keyword ;

class Program{
    
        static void Main(string[] args)
        {
            
            int a = 10, b = 12;
            
            Console.WriteLine("Initial value of a is {0}", a);
            Console.WriteLine("Initial value of b is {0}", b);
            Console.WriteLine();
            // Ref-is gareshe methodi
            addValue(a);
            Console.WriteLine("Value of a after method: {0}", a);

            // methodis gamozaxeba Ref-it
            addValue(ref b);
            Console.WriteLine("Value of b after Ref Method: {0}", b);
        }
        public static void addValue(int a)
        {
            a += 10;
        }
        
        public static void addValue(ref int b)
        {
            b += 5;
        }
    }

