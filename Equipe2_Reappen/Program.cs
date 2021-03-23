using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome = "";
            string plantacao = "";
            int cnpj = 0;
            string usuario = "";
            string senha = "";
            int tamaTerra = 0;
            int id = 0;
            Console.WriteLine("Welcome to Reappen");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Cadastro");
            int choices = int.Parse(Console.ReadLine());
            User choice = new User(nome, plantacao, cnpj, usuario, senha, tamaTerra);
            if (choices == 1)
            {
                choice.Login(usuario, senha);
            }
            if (choices == 2)
            {
                Console.Write("Seu mome: ");
                nome = Console.ReadLine();
                Console.Write("Qual a sua plantação?");
                plantacao = Console.ReadLine();
                Console.Write("Tamanho da Terra: ");
                tamaTerra = int.Parse(Console.ReadLine());
                Console.Write("CNPJ: ");
                cnpj = int.Parse(Console.ReadLine());
                Console.Write("Usuario: ");
                usuario = Console.ReadLine();
                Console.Write("Senha: ");
                senha = Console.ReadLine();
                id++;
                choice.VerificarDados(nome, plantacao, cnpj, usuario, senha, tamaTerra, id);
                choice.SalvarDados(nome, plantacao, cnpj, usuario, senha, tamaTerra, id);
            }
            Console.ReadKey();

        }
    }
}
