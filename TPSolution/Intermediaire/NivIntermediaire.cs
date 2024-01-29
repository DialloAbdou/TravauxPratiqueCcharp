using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediaire
{

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
                .Where(x => x % 2 == 0)
                .Select(x => x * x).ToArray();
            return res;
        }
        public static int Add(params int[] myArray)
        {
            int result = 0;

            foreach (var x in myArray)
            {
                result += x;
            }
            return result;
        }

        /// <summary>
        /// elle permet de remplacer un
        /// mmot dans une chaine 
        /// </summary>
        /// <param name="sentence"></param>
        public static void getSentence(string sentence, string mot)
        {

            var sentenceArray = sentence.Split(' ');
            sentenceArray[sentenceArray.Length - 1] = mot;
            var newSentence = string.Join(",", sentenceArray);
            Console.WriteLine(newSentence.ToString());
        }

        public static string PermuteChaine(string s1, string s2)
        {
            SwitchString( ref s1,ref  s2);

            return $"{s1} {s2}";
        }

        private static void SwitchString( ref string s1, ref string s2)
        {
            string m = s1;
            s1 = s2;
            s2 = m;

        }

        public static bool IsPalindome(string word)
        {

            var wordSplit = word.Split(' ', ',');
            var wordTab = string.Join("", wordSplit);
            var firstWord = wordTab.Substring(0, wordTab.Length/2).ToUpper();

            // secondPartie
            var reversWord = wordTab.Reverse().ToArray();
            var reversWordString = new String(reversWord);
            var secondPartie = reversWordString.Substring(0, reversWordString.Length / 2).ToUpper();
            Console.WriteLine(secondPartie);
           return firstWord.Equals(secondPartie) ;
        }

     }


}
