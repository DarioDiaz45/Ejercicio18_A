using System;

namespace Ejercicio18_A.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero:");
            var numero1 = int.Parse(Console.ReadLine());    
            Console.Write("inggrese otro numero:");
            var numero2=int.Parse(Console.ReadLine()); 
            

            var suma=numero1+numero2;
            var resta = numero1 - numero2;
            var producto = numero1*numero2;
            Console.WriteLine ($"el resultado de la suma es{suma}");
            Console.WriteLine($"el resultado de la resta es{resta}");
            Console.WriteLine($"el resultado de el producto es {producto}");




        }
    }
}