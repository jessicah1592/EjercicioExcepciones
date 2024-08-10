using System;

namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Seleccione una operación:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");

                string opcion = Console.ReadLine();

                try
                {
                    switch (opcion)
                    {
                        case "1":
                            Console.WriteLine("Ingrese el primer número:");
                            double a1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número:");
                            double b1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Resultado: " + operaciones.Sumar(a1, b1));
                            break;

                        case "2":
                            Console.WriteLine("Ingrese el primer número:");
                            double a2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número:");
                            double b2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Resultado: " + operaciones.Restar(a2, b2));
                            break;

                        case "3":
                            Console.WriteLine("Ingrese el primer número:");
                            double a3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número:");
                            double b3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Resultado: " + operaciones.Multiplicar(a3, b3));
                            break;

                        case "4":
                            Console.WriteLine("Ingrese el primer número:");
                            double a4 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número:");
                            double b4 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Resultado: " + operaciones.Dividir(a4, b4));
                            break;

                        case "5":
                            continuar = false;
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Entrada no válida. Asegúrese de ingresar un número.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }

                Console.WriteLine();
            }
        }
    }
}
