using System;

namespace W3_Throw_Error
{

    //The throw statement allows you to create a custom error.

    //The throw statement is used together with an exception class. There are many exception 
    //classes available in C#: ArithmeticException, FileNotFoundException, IndexOutOfRangeException etc

    class Program
    {
        class Verify
        {
            public int checkAge()
            {
                if ( < 18)
                {
                    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
                }
                else
                {
                    Console.WriteLine("Access granted - You are old enough!");
                }
                //            set { phone = value; Console.WriteLine(phone); }

            }
        }

        static void Main(string[] args)
        {
             
            //checkAge = Console.ReadLine();
        }
    }
}
