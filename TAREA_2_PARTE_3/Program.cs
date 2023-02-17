using System;

namespace Suma_Resta_Producto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor introduzca el primer número entero largo: ");
            long num1 = Convert.ToInt64(Console.ReadLine());

            Console.Write("Por favor introduzca el segundo número entero largo: ");
            long num2 = Convert.ToInt64(Console.ReadLine());

            long suma = num1 + num2;
            long resta = num1 - num2;
            long producto = num1 * num2;

            Console.WriteLine("La suma de " + num1 + " y " + num2 + " es " + suma);
            Console.WriteLine("La resta de " + num1 + " y " + num2 + " es " + resta);
            Console.WriteLine("El producto de " + num1 + " y " + num2 + " es " + producto);

            Console.ReadLine();
        }
    }
}