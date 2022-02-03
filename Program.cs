using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5个数字
{
    class Program
    {
        static void Main(string[] args)
        {
            double primoNumero, secondoNumero;
            Console.WriteLine("Inserisci primo valore");
            secondoNumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci secondo valore");
            primoNumero = Convert.ToDouble(Console.ReadLine());
            if (secondoNumero < primoNumero)
            {
                secondoNumero = primoNumero;
            }
            Console.WriteLine("Inserisci terzo valore");
            primoNumero = Convert.ToDouble(Console.ReadLine());
            if (secondoNumero < primoNumero)
            {
                secondoNumero = primoNumero;
            }
            Console.WriteLine("Inserisci quart" +
                "o valore");
            primoNumero = Convert.ToDouble(Console.ReadLine());
            if (secondoNumero < primoNumero)
            {
                secondoNumero = primoNumero;
            }
            Console.WriteLine("Inserisci quindo valore");
            primoNumero = Convert.ToDouble(Console.ReadLine());
            if (secondoNumero < primoNumero)
            {
                secondoNumero = primoNumero;
            }
            Console.WriteLine("il numero piu grande :" + secondoNumero);
            Console.ReadKey();
        }
    }
}
