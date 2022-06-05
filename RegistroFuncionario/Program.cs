using System;
using System.Globalization;


namespace RegistroFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários serão registrados? ");
            int qtdFuncionario = int.Parse(Console.ReadLine());
            
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            for (int i = 1; i <= qtdFuncionario; i++)
            {
                Console.WriteLine("Funcionário #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFuncionario.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Entre com o ID do funcionário que teve aumento de salário: ");
            int idFunc = int.Parse(Console.ReadLine());

            Funcionario funcionarioBuscado = listaFuncionario.Find(x => x.Id == idFunc);
            if(funcionarioBuscado != null)
            {
                Console.WriteLine("Digite a porcentagem para aumento de salário: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarioBuscado.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Funcionário não localizado");
            }
            Console.WriteLine();

            Console.WriteLine("Lista de funcionário atualizada: ");
            foreach (Funcionario funcionario in listaFuncionario)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}