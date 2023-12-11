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
        var name = "John"
        var age =25
        var weight = (float) 78.4
        var isHuman =true
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

    public static Tuple<int, bool, string> Main()
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

}
