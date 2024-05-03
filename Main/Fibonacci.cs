using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsModule
{
    public static class Fibonacci
    {
        public static void FibonacciSeries(int totalNumeros)
        {
            int primero = 0, segundo = 1, siguiente;
            for (int i = 0; i < totalNumeros; i++)
            {
                if (i <= 1)
                {
                    siguiente = i;
                }
                else
                {
                    siguiente = primero + segundo;
                    primero = segundo;
                    segundo = siguiente;
                }
                Console.Write(siguiente + "  ");
            }
        }
    }
}

