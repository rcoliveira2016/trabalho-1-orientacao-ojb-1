using System;

namespace Exercicio2
{
    public abstract class Imovel
    {
        public string Endereco { get; set; }
        public double Preco { get; set; }
        public abstract string ImprimirValor();
    }
    public class Nova : Imovel
    {
        public double PrecoAdicional { get; set; }
        public override string ImprimirValor()
        {
            return $"Valor imovel: {Preco + PrecoAdicional}";
        }

        public string ImprimirAdicional()
        {
            return $"Preço adicional: {PrecoAdicional}";
        }
    }
    public class Velho : Imovel
    {
        public double Desconto { get; set; }
        public override string ImprimirValor()
        {
            return $"Valor imovel: {Preco - Desconto}";
        }

        public string ImprimirDesconto()
        {
            return $"Deseconto: {Desconto}";
        }
    }
}
