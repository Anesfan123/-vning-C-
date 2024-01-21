using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖV1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region uppgift 1
            double värde1 = 5.90;
            double värde2 = 5.80;
            double värde3 = värde1 * värde2;
            Console.WriteLine(värde3);

            //variablernas värde
            int num_1 = 6;
            int num_2 = 9;
            //Använder Math.Max för att få högsta värdet
            int maxNum = Math.Max(num_1, num_2);

            //Skriver ut det högsta värdet
            Console.WriteLine(maxNum);

            //Tilldelar den femte varibalen det högsta värdet
            int num_3 = maxNum;

            //skriver ut nummrets värde 
            Console.WriteLine(num_3);
            #endregion

            #region Uppgift 2
            //variabel för radie med tilldelat värde
            double radie = 3.14; //Värdet kan förändras för olika svar 
            //Varibale som tar värdet av radie och skriver ut Arean
            double area = Math.PI * Math.Pow(radie,2);

            //Skriver ut värdet av radien 
            Console.WriteLine("När radien är " + radie);
            //Skriver ut Värdet av Arean 
            Console.WriteLine("så är Arean" + area);

            #endregion

        }
    }
}
