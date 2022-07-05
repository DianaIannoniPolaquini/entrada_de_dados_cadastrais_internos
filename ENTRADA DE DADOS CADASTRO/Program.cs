using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ENTRADA_DE_DADOS_CADASTRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade;
            double salario1, salario2;
            string nome1, nome2;
            char sexo;

            Console.Write("Digite o nome da primeira pessoa: ");
            nome1 = Console.ReadLine();
            Console.Write("Digite o salário da primeira pessoa: ");
            salario1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa: ");
            nome2 = Console.ReadLine();
            Console.Write("Digite o salário da secunda pessoa: ");
            salario2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o sexo (M/F): ");
            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("RELATÓRIO FINAL DA ENTRADA DE DADOS:");
            Console.WriteLine("NOME DA PRIMEIRA PESSOA: " + nome1 + ".");
            Console.WriteLine("SALÁRIO DA PRIMEIRA PESSOA: " + salario1.ToString("F2", CI)+ ".");
            Console.WriteLine("NOME DA SEGUNDA PESSOA: " + nome2 + ".");
            Console.WriteLine("SALÁRIO DA SEGUNDA PESSOA: " + salario2.ToString("F2", CI) + ".");


        }
    }
}
