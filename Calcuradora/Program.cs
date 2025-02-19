using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calcuradora
{
 
    public class Calcuradora
    {
        public double n1;
        public double n2;


        public void somar()
        {
            Console.WriteLine();
        }
        .
     
        public static void Main(string[] args)
        {
            
            Calcuradora c1 = new Calcuradora();
            c1.somar();
            c1.n1 = 2;
            c1.n2 = 3;

            Calcuradora c2 = new Calcuradora();
            c2.somar();
            c2.n1 = 3;
            c2.n2 = 4;

        }
    }
}
