using static System.Console;
namespace OperationsModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*** FIBONACCI & FACTORIAL ***");
            int opcion = 0;
            while (opcion !=3)
            {
                WriteLine("Menu Principal");
                WriteLine("1. Serie Fibonacci");
                WriteLine("2. Juego Factorial");
                WriteLine("3. Salir de la Aplicación");
                WriteLine("Ingresar la opción deseada:");

                try
                {
                    opcion = int.Parse(ReadLine()!);
                    switch (opcion)
                    {
                        case 1:
                            WriteLine("Ingrese el total de números a mostrar de la serie Fibonacci: ");
                            int totalNumeros = int.Parse(ReadLine()!);
                            Fibonacci.FibonacciSeries(totalNumeros);
                            WriteLine();
                            break;
                        case 2:
                            WriteLine("Ingrese un número entre 3 y 25: ");
                            int usuarioNumero = int.Parse(ReadLine()!);
                            Factorial.FactorialGame(usuarioNumero);
                            WriteLine();
                            break;
                        case 3:
                            WriteLine("Saliendo del programa...");
                            break;
                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    WriteLine("Ingrese una opción válida (número entero).");
                }
                catch (OverflowException)
                {
                    WriteLine("El número ingresado es demasiado grande.");
                }
                catch (Exception ex)
                {
                    WriteLine("Error:" +  ex.Message);
                }
            }
        }
    }
}
