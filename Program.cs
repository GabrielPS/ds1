using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace contaCorrente
{
    public class ContaCorrente
    {
        private string nome;
        private string cpf;
        private double limiteCredito;
        private double saldo;
        private bool negativado;

        public string getNome()
        {
            return nome;    
        }

        public void setnome(string nome)
        {
            this.nome = nome;
        }

        public string getcpf()
        {
            return cpf;
        }
            public void setcpf(string cpf)
        {
            this.cpf = cpf;
        }

        public double getlimiteCredito()
        {
            return limiteCredito;   
        }

        public void setlimiteCredito(double limiteCredito)
        {
            this.limiteCredito = limiteCredito;

        }

        public double getsaldo()
        {
            return saldo;
        }

        public void setsaldo(double saldo)
        {
            this.saldo = saldo; 

        }

        public bool getnegativado()
        {
            return negativado;  
        }

        public void setnegativado(bool negativado)
        {
            this.negativado = negativado;
        }

        public double depositar(double valor)
        {
            saldo += valor;
            return saldo;
        }



        public double sacar(double saque, double limite)

        {
         
            if (saque <= saldo)
            {
                saldo -= saque;
                Console.WriteLine("Saque no valor de " + saque + " foi realizado!");
                return saldo;
            }



            else

            {
                Console.WriteLine("O seu saldo é insuficientte para esse saque!");
                negativado = true;

                limite -= saque;
                limite += saldo;

                limiteCredito = limite;

                return limiteCredito;

            }


        }
        

           

        
            




        public void verSaldo()
        {
            Console.WriteLine("O saldo atual é " + saldo);


        }

       
    }
}
