// See https://aka.ms/new-console-template for more information
using Intermediaire;

//Console.WriteLine("Veillez Saisir un chiffre!");
//var chaine = Console.ReadLine();

//if (chaine is not null)
//{
//    var nbre = int.Parse(chaine);
//    Debutant.DisplayTriangle(nbre);
//}

//var arr = new[] { 1, 2, 3, 4, 5, 6, 7 };
//var valeu = Debutant.CountLessThan(arr, 2);
//Console.WriteLine(valeu);
//Debutant.Fibonacci(5);
//Debutant.DisplayInformation(5);

//List<int?> elem = new List<int?>()
//            {
//                0,
//                5,
//                null,
//                48,
//                31,
//                null,
//                91,
//                77,
//                12,
//                21,
//                null
//            };
//Debutant.DisplayInfos(elem);
////Debutant.HowManyVowels("Bonjour je m'appelle Jessy");
//Debutant.methodeJoin("Bonjour abdou");
//Debutant.methodeTest();

//// Niveau Intermediaire
//int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

////var myNewArray = NivIntermediaire.PairAndSquared(myArray);
////foreach (int i in myNewArray)
////utilisation
//var result = NivIntermediaire.Add(1, 2);

//var sentence = "Hello my name is David";
//NivIntermediaire.getSentence(sentence, "Julia");
//string s1 = "World";
//string s2 = "Hello";
//Console.WriteLine(NivIntermediaire.PermuteChaine(s1, s2));
//string word = "Engage le jeu, que je le gagne";
//Console.WriteLine(NivIntermediaire.IsPalindome(word));
//Console.WriteLine(result.ToString());
//int[] tabOCc = new int[] { 1, 2, 3, 1, 1, 1, 2, 5 };
////var dicOcc = NivIntermediaire.StoreAndCount(tabOCc);
//var dicOcc = NivIntermediaire.StoreAndCountLInq(tabOCc);
//foreach (KeyValuePair<int, int> occ in dicOcc)
//{
//    Console.WriteLine("Clé: {0}, Valeur: {1} ", occ.Key, occ.Value);
//}
// Manupulation des Dates
//DateTime date1 = new DateTime(2020, 8, 6);
//Console.WriteLine($"{NivIntermediaire.ToShortDate(date1)}");
//Console.WriteLine($"{NivIntermediaire.ToFrenchFullDate(date1)}");
//NivIntermediaire.getValeur();
//string sentence = "Bonjour, appelle moi au 0836656565";
int x = 44, y = 100;
var rendu = NivIntermediaire.GiveChange(x, y);

foreach (var item in rendu)
{
   Console.WriteLine(item);
}
//NivIntermediaire.CleanPhoneNumber(sentence);

Console.ReadLine(); 


