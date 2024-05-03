using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsModule
{
    public static class Factorial
    {
        public static void FactorialGame(int usuarioNumero)
        {
            Random random = new Random();
            int computadorNumero = random.Next(3, 25);

            // Imprimir los números ingresados
            WriteLine("Número generado por el computador: " + computadorNumero);
            WriteLine("Número ingresado por el usuario: " + usuarioNumero);

            // Calcular el número mayor y asignarlo a numeroGanador
            int numeroGanador;
            if (usuarioNumero > computadorNumero)
            {
                numeroGanador = usuarioNumero;
            }
            else if (computadorNumero > usuarioNumero)
            {
                numeroGanador = computadorNumero;
            } else
            {
                WriteLine("Los números son iguales. No hay un ganador.");
                return;
            }

            WriteLine("El ganador es: " + numeroGanador);

            // Imprimir el factorial del numeroGanador  
            long factorial = CalculateFactorial(numeroGanador);
            WriteLine("El factorial de " + numeroGanador + " es " + factorial);


        }
        // Función del cálculo específico del factorial
        private static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }
    }
}
