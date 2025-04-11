using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using principal;

namespace Comissao
{
    public class comissao
    {
       
        private string nome;
        private double salarioBase;
       
        

        public string getnome() { return nome; }
        
        public double getvalorVendido() { return salarioBase; }
      
        public void setnome(string nome) { this.nome = nome; }
        public void setsalarioBase(double salarioBase) { this.salarioBase = salarioBase; }
      

       public double contacomissao(double valorVendido)
        {
            valorVendido = valorVendido * (0.03 + (salarioBase * 0.00001));
            Console.WriteLine("\n A comissão é estimada no valor de R$" + valorVendido);

            return valorVendido;
        }
        


        
    }
}
