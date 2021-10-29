using System;

namespace Exercico4
{
    class Program
    {
        static void Main(string[] args)
        {
            var retangulo = new Retangulo() { 
                Altura = 1,
                Largura = 5,
            };
            var circulo = new Circulo()
            {
                Radio = 4,
            };
            var quadrado = new Quadrado()
            {
                Altura = 5,
                Largura = 5,
            };

            Console.WriteLine($"Retangulo - Area: {retangulo.CalculaArea()}, Perimetro: {retangulo.CalculaArea()}.");
            Console.WriteLine($"Circulo - Area: {circulo.CalculaArea()}, Perimetro: {circulo.CalculaArea()}.");
            Console.WriteLine($"Quadrado - Area: {quadrado.CalculaArea()}, Perimetro: {quadrado.CalculaArea()}.");
        }       
    }
    public abstract class Forma
    {
        public abstract double CalculaPerimetro();
        public abstract double CalculaArea();
    }
    public class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double CalculaArea()
        {
            return Largura * Altura;
        }

        public override double CalculaPerimetro()
        {
            return ((2 * Largura) + (2 * Altura));
        }

    }

    public class Circulo : Forma
    {
        const double Pi = 3.14;
        public double Radio { get; set; }

        public override double CalculaArea()
        {
            return Pi * (Radio * Radio);
        }

        public override double CalculaPerimetro()
        {
            return 2 * Pi * Radio;
        }

    }

    public class Quadrado : Retangulo
    {

    }
}
