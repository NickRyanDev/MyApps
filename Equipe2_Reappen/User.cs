using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class User
    {
        List<String> dadoString = new List<String>();

        string nome { get; set; }
        string plantacao { get; set; }
        int cnpj { get; set; }
        string usuario { get; set; }
        string senha { get; set; }
        int tamTerra { get; set; }
        int ID { get; set; }

        public User(string nome, string plantacao, int cnpj, string usuario, string senha, int tamTerra)
        {
            this.nome = nome;
            this.plantacao = plantacao;
            this.cnpj = cnpj;
            this.usuario = usuario;
            this.senha = senha;
            this.tamTerra = tamTerra;
            this.ID = ID;

        }

        public bool VerificarDados(string nome, string plantacao, int cnpj, string usuario, string senha, int tamTerra, int ID)
        {
            bool validacao = true;
            dadoString.Add(nome);
            dadoString.Add(plantacao);
            dadoString.Add(usuario);
            dadoString.Add(senha);

            /*
            foreach (var item in dadoString)
            {
                if (item==null)
                {
                    public bool validar = false;
                }
            } */

            return validacao;

        }

            
        public void SalvarDados (string name, string plantacao, int cnpj, string usuario, string senha, int tamTerra, int ID)
        {
            bool confirmar = VerificarDados(nome, plantacao, cnpj, usuario, senha, tamTerra, ID);
            if (confirmar == true)
            {
                Console.WriteLine("Dados Salvos com sucesso");
                Console.Clear();
                Console.WriteLine("Bem vindo" + nome);

            }
        }
        public void Error(int cnpj, string usuario)
        {
            if (cnpj < 10000000000)
            {
                Console.WriteLine("Faltam dados, tente novamente!");
            }
        }
        public void Login(string usuario, string senha)
        {
            Console.Clear();
            bool manterloop = true;
            while (manterloop == true)
            {
                Console.Write("Usuário: ");
                string user = Console.ReadLine();
                Console.Write("Senha: ");
                string pass = Console.ReadLine();
                if (user == usuario && pass == senha)
                {
                    Console.Clear();
                    Console.WriteLine("Bem vindo, " + dadoString.Contains(nome));
                    manterloop = false;
                }
                else
                {
                    Console.WriteLine("Algo deu errado tente novamente!");
                }
            }
        }

    }
}