using System;
using Aula02RH.Models;
using Aula02RH.Models.Enuns;

namespace Aula02RH
{
    public class Program
    {
        static void Main(string[] args)
        {
            // sempre eu for instanciar um objeto
           /* Funcionario f  = new Funcionario();
            f.Id = 10;
            f.Nome = "Lucas";
            f.Cpf = "12378965428";
            f.DataAdmissao = DateTime.Parse("03/03/2012");
            f.Salario = 1200.00M;
            f.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;

            String mensagem = f.ExibirPeriodoExperiencia();
            Console.WriteLine(mensagem);*/

            Funcionario func = new Funcionario();

            Console.WriteLine("Digite o ID do funcionário: ");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionário: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do funcionário: ");
            func.Cpf = Console.ReadLine();
            
            Console.WriteLine("Digite a Data de Admissão do funcionário: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Salário do funcionário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o Tipo de Contrato do Funcionário: 1 - CLT ou 2 - Aprendiz");
            int opcao = int.Parse(Console.ReadLine());

            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();
            decimal valorDescontoVT = func.CalcularDescontoVT(6);

            Console.WriteLine("=================================");
            Console.WriteLine($"O Salário reajustado é {func.Salario}.\n");
            Console.WriteLine($"O Desconto do VT é {valorDescontoVT}.\n");
            Console.WriteLine("=================================");

        }
    }
}