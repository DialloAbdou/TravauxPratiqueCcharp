using System;
using System.Security.Authentication.ExtendedProtection;
using System.Transactions;

public class Debutant
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static Tuple<string, int, float, bool, string[]> Main()
    {
        // TODO
        var name = "John";
        var age = 25;
        var weight = (float)78.4;
        var isHuman = true;
        var friends = new string[] { "paul", "Sam", "David" };

        return new Tuple<string, int, float, bool, string[]>
            (name, age, weight, isHuman, friends);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public void ComputeAndDisplay(int a, int b)
    {
        var res = a % b;
        Console.WriteLine(res);
    }

    public static Tuple<int, bool, string> GetTuple()
    {
        var myInt = "17";
        var myBool = "False";
        var myString = 100;

        var myIntConverted = int.Parse(myInt);
        var myBoolConverted = bool.Parse(myBool);
        var myStringConverted = myString.ToString();

        return new Tuple<int, bool, string>
            (myIntConverted, myBoolConverted, myStringConverted);
    }

    public static string CheckAge(int age)
    {
        // Ne pas toucher cette ligne.
        string message = "";
        if (age < 18)
        {
            message = "Vous êtes mineure";
        }
        else if (age < 20)
        {
            message = "Vous êtes tout juste majeur";
        }
        else
        {
            message = "Vous êtes majeure";
        }

        // Ecrire la condition "if" qui permet de répondre à l'exercice.
        // l'âge est stockée dans la variable "age".
        // Vous devez enregistrer le message dans la variable "message".

        // Ne pas toucher ces lignes.
        Console.WriteLine(message);
        return message;
    }

    public string GetFizzBuzz(int valeur)
    {
        string resultat = string.Empty;

        if (valeur % 3 == 0)
        {
            resultat += "Fizz";
        }
        if (valeur % 5 == 0)
        {
            resultat += "Buzz";

        }
        if (string.IsNullOrEmpty(resultat))
        {
            resultat = resultat += valeur.ToString();
        }
        return resultat;

    }

    /// <summary>
    /// Elle permet de supprimer
    ///  de caractere dans une chaine 
    ///  de caractere
    /// 
    /// </summary>
    /// <param name="chaine"></param>
    /// <param name="indexe"></param>
    /// <returns></returns>
    public string RemoveAtPosition(string chaine, int indexe)
    {
        if (indexe <= 0)
        {
            return chaine.Remove(0, 1);
        }
        else if (indexe > chaine.Length - 1)
        {
            indexe = chaine.Length - 1;
            return chaine.Remove(indexe, 1);
        }
        else
        {
            return chaine.Remove(indexe, 1);
        }

    }

    public static void DisplayTriangle(int a)
    {
        int j = a;
        int k = a;

        for (int i = 1; i <= k; i++)
        {
            for (int t = 1; t <= j; t++)
            {
                Console.Write(a);
            }
            Console.WriteLine();
            j--;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public static int CountLessThan(int[] arr, int val)
    {
        var res = arr.Count(a => a < val);
        return res;
    }

    public static void Fibonacci(int n)
    {
        int a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            Console.Write(c);
            a = b;
            b = c;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="o"></param>
    public static void DisplayInformation(object o)
    {
        if (o is not null)
        {
            if (o.GetType().Equals(typeof(string)))
            {
                Console.WriteLine("C'est une String");
            }
            else if (o.GetType().Equals(typeof(int)))
            {
                Console.WriteLine("C'est un int");
            }
            else if (o.GetType().Equals(typeof(float)))
            {
                Console.WriteLine("C'est un Float");

            }
            else if (o.GetType().Equals(typeof(Boolean)))
            {
                Console.WriteLine("C'est un Boolean");

            }
            else { Console.WriteLine("je connais pas ce type"); }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public static bool? FlipCoin(int min = 0, int max = 100)
    {
        var rnd = new Random().Next(min, max);
        if (rnd < 50)
        {
            return true;
        }
        else if (rnd > 50)
        {
            return false;
        }
        else
        {
            return null;
        }
    }
    /// <summary>
    /// Utilisation Hasvalue
    /// </summary>
    /// <param name="val"></param>
    public static void DisplayInfos(List<int?> val)
    {
        foreach (var v in val)
        {
            //if (!v.HasValue)
            //{
            //    Console.WriteLine(0);

            //}
            //else
            //{
            //    Console.WriteLine(v);

            //}
            Console.WriteLine(v ?? 0);
        }


    }
    /// <summary>
    /// Compter le nmbre de voyelle
    /// dans une chaine.
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public int HowManyVowels(string word)
    {
        int cpte = 0;
        var voyelles = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
        if (!string.IsNullOrEmpty(word))
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (voyelles.Contains(word[i]))
                {
                    cpte++;
                }
            }
        }
        return cpte;

    }
    public static void methodeJoin(string word)
    {
        var motSlipt = string.Join('*', word.Split(' '));
        Console.WriteLine(motSlipt);

        //foreach(var m in motSlipt)
        //{
        //    Console.WriteLine(m);
        //}
    }
    public static void methodeTest()
    {
        List<string> words = new List<string>()
        {
            "Banane","Orange","Mangue"
        };

        var motJoin = string.Join("", words);

        Console.WriteLine(motJoin);
    }



}

