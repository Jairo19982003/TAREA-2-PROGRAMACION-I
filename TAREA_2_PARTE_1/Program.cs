namespace Edad_aparente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos años tienes? ");
            byte edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("No aparentas" + " " + edad + " " + "años.");
        }
    }
}