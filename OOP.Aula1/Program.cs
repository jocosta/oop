using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 19;
            string nome = "Ovidio";

            Pessoa aluno;
            aluno = new Pessoa();

            aluno.Nome = "Ovidio";
            aluno.Idade = 20;

            aluno.Falar();

            Console.ReadKey();
        }
    }
}
