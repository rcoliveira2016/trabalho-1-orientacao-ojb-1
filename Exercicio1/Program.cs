using System;

namespace Exercicio1
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public virtual string ExibeDados()
        {
            return $"Nome: {Nome}";
        }
    }

    public class Gerente
    {

    }

    public abstract class Assistente : Funcionario
    {
        public string Matricula { get; set; }
        public abstract string NomeTipoAsistente { get; }
        public override string ExibeDados()
        {
            return $"Descrição do cargo: {NomeTipoAsistente}\nNúmero de matrícula: {Matricula}\nNome: {Nome}";
        }
    }

    public class Tecnico : Assistente
    {
        public double BonusSalarial { get; set; }

        public override string NomeTipoAsistente => "Assistente Tecnico";
    }
    public enum eTurno
    {
        Noite = 1,
        Dia = 2,
    }
    public class Administrativo : Assistente
    {
        public eTurno Turno { get; set; }
        public double AdicionalNoturno { get; set; }
        public override string NomeTipoAsistente => "Assistente Administrativo";
    }
}
