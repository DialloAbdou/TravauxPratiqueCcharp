using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace Intermediaire
{

    /// <summary>
    /// ===Liste D'attentes
    /// </summary>
    ///    public class WaitingList
    public class WaitingList
    {
        public Queue<string> _names;

        public WaitingList()
        {
            _names = new Queue<string>();
        }

        /// <summary>
        /// elle permet d'ajouter un ,om dans 
        /// la file d''une personne qui s'incrit
        /// </summary>
        /// <param name="name"></param>
        public void Add(string name)
        {
            _names.Enqueue(name);
        }

        /// <summary>
        /// peremet d'ajouter plusieurs nom dans la file
        /// </summary>
        /// <param name="names"></param>
        public void AddMultiple(List<string> names)
        {
            foreach (var item in names)
            {
                _names.Enqueue(item);
            }
        }

        /// <summary>
        /// retirer un nom dans la file 
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            var _liste = _names.ToList();
            if (_liste.Any(n => n.Equals(name)))
            {
                _liste.Remove(name);
            }
        }
        /// <summary>
        /// Compter le nombre de personne
        /// dans la file
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
             return _names.Count;
        }

        /// <summary>
        /// Retourner la prochaine
        /// personne à retirer
        /// </summary>
        /// <returns></returns>
        public string CheckNext()
        {
            return _names.Peek().ToString();
        }

        public string Next()
        {
            return _names.Dequeue();  

        }



        public void Reset()
        {
            this._names.Clear();
        }


    }


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
        Alice = 2,
        Robert = 3,
        David = 4,
        Cynthia = 5
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
        var name = Names.Alice | Names.Robert;

        Console.WriteLine(name);
    }

    public static void CleanPhoneNumber(string sentence)
    {
        string pattern = @"(0|\\+33|0033)[1-9][0-9]{8}";

        Regex defaultRegex = new Regex(pattern, RegexOptions.Compiled);

        var matches = defaultRegex.Replace(sentence, string.Empty);

        Console.WriteLine($"{matches}");

    }

    /// <summary>
    /// Tableau d'echange de monaie
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public static int[] GiveChange(int x, int y)
    {
        int[] tableauEchange = new int[] { 100, 50, 20, 10, 5, 2, 1 };
        List<int> tableauRendu = new List<int>();
        int i = 0; int rest = 0; int j = 0;
        if (x == y)
        {
            return tableauEchange;
        }
        if (y > x)
        {
            rest = y - x;
            while (rest != 0)
            {

                if (rest >= 100)
                {
                    rest = rest - 100;
                    tableauRendu.Add(100);
                }
                else if (rest >= 50)
                {
                    rest = rest - 50;
                    tableauRendu.Add(50);
                }
                else if (rest >= 20)
                {
                    rest = rest - 20;
                    tableauRendu.Add(20);
                }
                else if (rest >= 10)
                {
                    rest = rest - 10;
                    tableauRendu.Add(10);

                }
                else if (rest >= 5)
                {
                    rest = rest - 5;
                    tableauRendu.Add(5);
                }
                else
                {
                    rest = rest - 1;
                    tableauRendu.Add(1);
                }

            }
        }

        return tableauRendu.ToArray();
    }

    public static int[] CountFrequence(string[] words)
    {
        int j = 0; int i = 0; int nbre = 0;
        var wordtries = words.OrderBy(x => x).ToArray();
        int k = 0;
        int[] newTab = new int[wordtries.Length];
        while (j < wordtries.Length)
        {
            while (i < wordtries.Length)
            {
                if (wordtries[j].Equals(wordtries[i]))
                {
                    nbre++;
                }
                i++;

            }
            newTab[k] = nbre;
            k++;
            j++;
            nbre = 0; i = 0;
        }

        return newTab;
    }



}



}
