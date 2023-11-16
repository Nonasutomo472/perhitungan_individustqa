using System;
using System.Collections.Generic;
using System.Text;

namespace perhitungan
{
    public class perhitungan1
    {
        
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Subtract(int a, int b)
            {
                return a - b;
            }

            public int Multiply(int a, int b)
            {
                return a * b;
            }

            public double Divide(int a, int b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return 0;
                }
                return (double)a / b;
            }
        }

       
    }


