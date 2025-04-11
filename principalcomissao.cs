using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comissao;


namespace principal
{
    public class principalcomissao

    {
        public static void Main(string[] args)
        {
            comissao c1
                = new comissao();
            Console.WriteLine("Qual seu nome?\n");
            c1.setnome(Console.ReadLine());
            Console.WriteLine("Qual seu salário atual?\n");
            c1.setsalarioBase(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Qual foi o valor da venda?\n");
                double valorVendido = Convert.ToDouble(Console.ReadLine());
            c1.contacomissao(valorVendido);
          
        }

    }
}
