using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    public class Usuario
    {
        //atributos
        //modificador de acesso | tipo de dado | nome do atributo (variável)
        public string nome;
        public string email;
        public string login;
        public string senha;

        //Método especifico da classe
        public void provarExisencia()
        {
            Console.WriteLine("Oi eu existo!");
        }
        public static void Main(string[] args)
        {
            //Console.WriteLine("Olá mundo!");

            //método construtor
            // tipo do dado | nomeDainstacia | = |comando new | método Construtor()
            Usuario u1 = new Usuario();

            //Invocando o método específico da classe
            //nomeDainstacia.metodoEspeciDaclasse();

            //inserindo dados no objeto
            //nomeDainstacia.atributo = dados;

            u1.provarExisencia();
            u1.nome = "Elias";
            u1.email = "e@e";
            u1.login = "elias2";
            u1.senha = " 123 ";

            //exibindo os dados do objeto
            Console.WriteLine(u1.nome);
            Console.WriteLine(u1.email);
            Console.WriteLine(u1.login);
            Console.WriteLine(u1.senha);
            
            //Usuario 2

            Usuario u2 = new Usuario();
            u2.provarExisencia();
            u2.nome = "Gabriel";
            u2.email = "thegp@";
            u2.login = "GabrielPS";
            u2.senha = "12345";

            Console.WriteLine(u2.nome);
            Console.WriteLine(u2.email);
            Console.WriteLine(u2.login);
            Console.WriteLine(u2.senha);


        }
    }
}
