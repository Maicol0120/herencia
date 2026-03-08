using System;

namespace TallerHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect = new Rectangulo(5, 3);
            Cuadrado cuad = new Cuadrado(4);
            Circulo circ = new Circulo(3);

            Console.WriteLine("===== RECTANGULO =====");
            Console.WriteLine("Area: " + rect.CalcularArea());
            Console.WriteLine("Perimetro: " + rect.CalcularPerimetro());
            Console.WriteLine();

            Console.WriteLine("===== CUADRADO =====");
            Console.WriteLine("Area: " + cuad.CalcularArea());
            Console.WriteLine("Perimetro: " + cuad.CalcularPerimetro());
            Console.WriteLine();

            Console.WriteLine("===== CIRCULO =====");
            Console.WriteLine("Area: " + circ.CalcularArea());
            Console.WriteLine("Perimetro: " + circ.CalcularPerimetro());

            Console.ReadLine();
        }
    } 
} 
