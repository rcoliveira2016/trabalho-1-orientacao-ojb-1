using Exercicio1;
using Exercicio2;
using System;

namespace Exercicio3
{
    class Teste
    {
        static void Main(string[] args)
        {
            var tecnito = new Tecnico();
            tecnito.Nome = "Ramon Cardoso";
            tecnito.Matricula = "001";
            tecnito.BonusSalarial = 100;

            var administrativo = new Administrativo();
            administrativo.Nome = "Luis Oluiveira";
            administrativo.Matricula = "002";
            administrativo.Turno = eTurno.Dia;
            administrativo.AdicionalNoturno = 100;

            Console.WriteLine(tecnito.ExibeDados());
            Console.WriteLine(administrativo.ExibeDados());

            Console.WriteLine("digitar 1 para novo imovel e 2 para velho imovel");
            var tipo = Console.ReadLine();
            Imovel imovel = null;
            switch (tipo)
            {
                case "1":
                    imovel = new Nova()
                    {
                        Endereco = "Quadra QR 417 Conjunto L",
                        Preco = 100000,
                        PrecoAdicional = 100
                    };
                    break;
                case "2":
                    imovel = new Velho()
                    {
                        Endereco = "Rua Couto Magalhães",
                        Preco = 100000,
                        Desconto = 100
                    };
                    break;
                default:
                    Console.WriteLine("Valor não existe");
                    return;
            }

            Console.WriteLine(imovel.ImprimirValor());
        }
    }
}
