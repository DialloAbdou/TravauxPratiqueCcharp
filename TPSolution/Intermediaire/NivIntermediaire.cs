using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediaire
{
    public class NivIntermediaire
    {
        /// <summary>
        /// le moyen de filtrer les nombre paires
        /// la variable
        /// </summary>
        /// <param name="myArray"></param>
        /// <returns></returns>
        public static int[] PairAndSquared(int[] myArray)
        {
            var res = myArray
                .Where(x => x%2 == 0)
                .Select(x=>x*x).ToArray();
            return res;
        }
    }

    public static class Helper
    {
        public static string ToEuroLabelle(this int money)
        {
            return $"{money} euros";
        }

        public static void GetEuro()
        {
            Console.WriteLine(100.ToEuroLabelle());
        }

    }  
}
