using System;

public class Debutant
{
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

}
