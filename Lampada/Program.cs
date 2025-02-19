using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada
{
    public class Lampada
    {
        public int lampadaNro;
        public string comodo;
        public bool status;

        public void provarExistencia()
        {
            Console.WriteLine("Oi eu existo! ");

        }
        

        public static void Main(string[] args)
        {
            Lampada  l1 = new Lampada();

            l1.provarExistencia();
            l1.lampadaNro = 1;
            l1.comodo = "quarto";
            l1.status = true;

            Console.WriteLine(l1.lampadaNro);
            Console.WriteLine(l1.comodo);
            Console.WriteLine(l1.status);

            Lampada l2 = new Lampada();
            l2.provarExistencia();
            l2.lampadaNro = 2;
            l2.comodo = "sala";
            l2.status = true;

            Console.WriteLine(l2.lampadaNro);
            Console.WriteLine(l2.comodo);
            Console.WriteLine(l2.status);




        }
    }
}
