using System;

namespace W3_Throw_Error
{

    //The throw statement allows you to create a custom error.

    //The throw statement is used together with an exception class. There are many exception 
    //classes available in C#: ArithmeticException, FileNotFoundException, IndexOutOfRangeException etc

    class Program
    {
        static void Main(string[] args)
        {
            var adding = true;

            while (adding)
                {
                Ages newAge = new Ages();

                Console.WriteLine("How old are you?");
                newAge.Age = (int.Parse(Console.ReadLine()));
                if (int.Parse(Console.ReadLine()) < 18)
                {
                    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
                    adding = false;
                }
                else
                {
                    Console.WriteLine("Access granted - You are old enough!");
                }
            }
        }



        class Ages
        {
            public int Age;
        }
    }
}

