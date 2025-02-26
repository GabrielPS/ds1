using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calcuradora1
{

    public class calcuradora1
    {
        public double n1;
        public double n2;


        public void somar()
        {
            Console.WriteLine("a soma dos numeros é" + (n1 + n2));
        }
        public void subtrair()
        {
            Console.WriteLine("a subtração dos numeros é" + (n1 - n2));
        }
        public void divisao()
        {
            Console.WriteLine("a divisão dos numeros é" + (n1 / n2));
        }
        public void multiplica()
        {
            Console.WriteLine("a multiplicação dos numeros é" + (n1 * n2));
        }
        


        static void Main(string[] args)
        {

            calcuradora1 c1 = new calcuradora1();
            
            c1.n1 = 2;
            c1.n2 = 3;

            Console.WriteLine("O primeiro número é:" + c1.n1);
            Console.WriteLine("O segundo número é:" + c1.n2);

            c1.somar();
            c1.subtrair();
            c1.divisao();
            c1.multiplica();

            Console.WriteLine("\n");


            calcuradora1 c2 = new calcuradora1();
           
            c2.n1 = 3;
            c2.n2 = 4;
            Console.WriteLine("O primeiro número é:" + c2.n1);
            Console.WriteLine("O segundo número é:" + c2.n2);

            c2.somar();
            c2.subtrair();
            c2.divisao();
            c2.multiplica();

        }
    }
}
