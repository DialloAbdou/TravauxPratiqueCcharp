// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veillez Saisir un chiffre!");
//var chaine = Console.ReadLine();

//if(chaine is not null)
//{
//    var nbre = int.Parse(chaine);
//    Debutant.DisplayTriangle(nbre);
//}

//var arr= new[] {1,2,3,4,5,6,7};
//var valeu = Debutant.CountLessThan(arr, 2);
//Console.WriteLine(valeu);
//Debutant.Fibonacci(5);
//Debutant.DisplayInformation(5);

List<int?> elem = new List<int?>()
            {
                0,
                5,
                null,
                48,
                31,
                null,
                91,
                77,
                12,
                21,
                null
            };
Debutant.DisplayInfos(elem);
Console.ReadLine();


