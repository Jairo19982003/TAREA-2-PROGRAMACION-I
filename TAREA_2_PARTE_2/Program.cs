using System;

namespace Multiplicar_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce el primer numero de dos cifras: ");
            byte num_1 = Convert.ToByte(Console.ReadLine());


            Console.WriteLine("Por favor introduce el segundo numero de dos cifras");
            byte num_2 = Convert.ToByte(Console.ReadLine());

            ushort resultados = (ushort)(num_1 * num_2);

            Console.WriteLine("El resultado de la multiplicacion es: " + num_1 + " y " + num_2 + " es " + resultados);
        }
    }
}