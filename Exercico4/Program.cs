using System;

namespace Exercico4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }       
    }
    public abstract class Forma
    {
        public abstract double CalculaPerimetro();
        public virtual double Perimetro()
        {
            return this.CalculaPerimetro();
        }
    }
    public class Retangulo : Forma
    {
        public double Lado { get; set; }
        public double Altura { get; set; }
        public override double CalculaPerimetro()
        {
            return Lado * Altura;
        }

    }
}
