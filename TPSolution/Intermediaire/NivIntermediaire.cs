using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Intermediaire
{

    public class Score
    {
        public int userId { get; set; }
        public int scoreValue { get; set; }

        public Score(int _userId, int _scoreValue)
        {
            userId = _userId;
            scoreValue = _scoreValue;
        }
    }

    public class ScoreManager
    {
        private Score[] _scores;

        public ScoreManager(List<Score> scores)
        {
            this._scores = scores.ToArray();
        }

        public List<Score> GetScores()
        {
            return _scores.ToList();
        }

        public int GetLastScore()
        {
            var valeurMax = _scores.Last().scoreValue;
            return valeurMax;
        }
        public int GetHighScore()
        {
            return _scores.Max(comparer => comparer.scoreValue);
        }
        //GetHighScore

        public List<int> GetTop3OfUser(int id)
        {
            var myScore = _scores
                .Where(s => s.userId == id)
                .Take(3)
                .Select(v => v.scoreValue).
                OrderByDescending(c => c)
                .ToList();
            return myScore;
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

    public class NivIntermediaire
    {
        [Flags]
        enum Names
        {
            Albert = 1,
            Alice =2,
            Robert =3,
            David =4,
            Cynthia =5
        }
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
            SwitchString(ref s1, ref s2);

            return $"{s1} {s2}";
        }

        private static void SwitchString(ref string s1, ref string s2)
        {
            string m = s1;
            s1 = s2;
            s2 = m;

        }

        public static bool IsPalindome(string word)
        {

            var wordSplit = word.Split(' ', ',');
            var wordTab = string.Join("", wordSplit);
            var firstWord = wordTab.Substring(0, wordTab.Length / 2).ToUpper();

            // secondPartie
            var reversWord = wordTab.Reverse().ToArray();
            var reversWordString = new String(reversWord);
            var secondPartie = reversWordString.Substring(0, reversWordString.Length / 2).ToUpper();
            Console.WriteLine(secondPartie);
            return firstWord.Equals(secondPartie);
        }

        /// <summary>
        /// elle permet de compter 
        /// nombre d'occurence dans un tableau 
        /// pour  nous retourner un dictionnaire
        /// </summary>
        /// <param name="tabOCc"></param>
        /// <returns></returns>
        public static Dictionary<int, int> StoreAndCount(int[] tabOCc)
        {
            int j = 0; int nbre = 0; int i = 0;
            Dictionary<int, int> StoreDico = new Dictionary<int, int>();
            while (j < tabOCc.Length)
            {

                while (i < tabOCc.Length)
                {
                    if (tabOCc[j] == tabOCc[i])
                    {
                        nbre++;
                    }
                    i++;
                }
                if (i == tabOCc.Length)
                {
                    if (!StoreDico.ContainsKey(tabOCc[j]))
                    {
                        StoreDico.Add(tabOCc[j], nbre);
                    }
                    i = 0;
                    nbre = 0;
                }
                j++;
            }

            return StoreDico;
        }

        /// <summary>
        /// elle retourne un dictionnaire en comptant les nombre d'occurence
        /// dans le tableau 
        /// </summary>
        /// <param name="tabOCc"></param>
        /// <returns></returns>
        public static Dictionary<int, int> StoreAndCountLInq(int[] tabOCc)
        {
            var resLinq = tabOCc.ToLookup(x => x, x => tabOCc.Count(y => y == x));
            return resLinq.ToDictionary(x => x.Key, x => x.First()); ;
        }

        /// <summary>
        /// Elle retourne une date
        /// sous la forme "Shorte Date"
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string ToShortDate(DateTime d)
        {
            DateTime date = d.Date;
            return date.ToString("d");
        }

        /// <summary>
        /// elle retour une date sour forme logue
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string ToFrenchFullDate(DateTime d)
        {
            DateTime date = d.Date;
            return date.ToString("MM/dd/yyyy HH:mm");
        }
        public static void getValeur()
        {
            var name =  Names.Alice | Names.Robert;

            Console.WriteLine(name);
        }

        public static void CleanPhoneNumber(string sentence)
        {
            string pattern = @"(0|\\+33|0033)[1-9][0-9]{8}";

            Regex defaultRegex = new Regex(pattern, RegexOptions.Compiled);

            var matches = defaultRegex.Replace(sentence, string.Empty);

            Console.WriteLine($"{matches}");

        }

        public static int[] GiveChange(int x, int y)
        {
            int[] tableauEchange = new int[] { 100, 50, 20, 10, 5, 2, 1 };
            List<int> tableauRendu = new List<int>();
            int i = 0; int rest = 0; int j = 0;
            if(x==y)
            {
                return tableauEchange;
            }
            if(y > x)
            {
                rest = y - x;
                while(i< tableauEchange.Length && rest!=0)
                {
                    if (tableauEchange[i] <= rest)
                    {
                        rest = rest - tableauEchange[i];
                        tableauRendu.Add(tableauEchange[i]);
                         
                    }
                    i++ ; 

                }
            }

            return tableauRendu.ToArray();
        }
    }


}
