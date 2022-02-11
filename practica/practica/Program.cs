using System;

namespace practica
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] edad = new int[4] { 26, 20, 12, 15 };
            string[] nombre = new string[4] { "Valeria", "Ana", "Luis", "Carlos" };
            int menor;
            menor = edad[0];
            for (int j = 0; j <= edad.Length - 2; j++)
            {
                for (int i = 0; i <= edad.Length - 2; i++)
                {
                    if (edad[i] < menor )
                    {
                        menor = edad[i];
                        
                    }
                }
            }
            Console.WriteLine("edad del la persona:");
            foreach (int p in edad)
                Console.Write(p + " " );
            Console.Write("la edad menor seria :" + menor + " Luis ");
            Console.ReadKey();
        }

    }
}
