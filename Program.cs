using System;

namespace SC
{
    class simplecalculator

    {
        static void Main(string[] args)

        {
            //Instruction to use simple calculator

            Console.WriteLine("\t\t\tSimple Calculator");
            Console.WriteLine("\t\t\t + , - , * , / , % ");
            int val = 0;

            //Val is a variable that holds the calculated value
            val = Convert.ToInt32(Console.ReadLine());

            //Infinite Loop start
            for (; ; )
            {
                
                //to perform operations
                int add,mul,div,mod,sub;
                
                // to enter operator op variable is used
                char op;
                op = Convert.ToChar(Console.ReadLine());

                // To stop the infinite loop
                if (op == 'N')
                {
                    Console.WriteLine("Stopped");
                    break;
                }


                // Using switch the all the arithmetic operations are done
                switch (op)
                {
                    case '+':
                        add = Convert.ToInt32(Console.ReadLine());
                        val = val + add;
                        Console.WriteLine("\t\t" + val);

                        break;
                    case '-':
                        sub = Convert.ToInt32(Console.ReadLine());
                        val = val - sub;
                        Console.WriteLine("\t\t" + val);
                        break;
                    case '*':
                        mul = Convert.ToInt32(Console.ReadLine());
                        val = val * mul;
                        Console.WriteLine("\t\t" + val);
                        break;
                    case '/':
                        div = Convert.ToInt32(Console.ReadLine());
                        val = val / div;
                        Console.WriteLine("\t\t" + val);
                        break;
                    case '%':
                        mod = Convert.ToInt32(Console.ReadLine());
                        val = val % mod;
                        Console.WriteLine("\t\t" + val);
                        break;
                    
                    default:

                        Console.WriteLine("\t\t\tEnter proper operator");
                        break;

                       
                }
               


            }
        }
    }
}
