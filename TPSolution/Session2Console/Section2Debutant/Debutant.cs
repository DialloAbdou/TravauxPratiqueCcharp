using System;

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

        var myIntConverted =  int.Parse(myInt);
        var myBoolConverted =   bool.Parse(myBool);
        var myStringConverted =  myString.ToString();

        return new Tuple<int, bool, string>
            (myIntConverted, myBoolConverted, myStringConverted);
    }

    public static string CheckAge(int age)
    {
        // Ne pas toucher cette ligne.
        string message = "";
        if(age<18)
        {
            message = "Vous êtes mineure";
        }else if(age< 20 )
        {
            message = "Vous êtes tout juste majeur";
        }else
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
     
        if(valeur %3 == 0)
        {
            resultat+= "Fizz";
        }
        if (valeur % 5 == 0)
        {
            resultat+= "Buzz";

        }
        if(string.IsNullOrEmpty(resultat)) 
        {
            resultat = resultat += valeur.ToString();
        }
        return resultat;
       
      
    }
}
