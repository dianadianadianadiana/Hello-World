using System;
using System.Collections.Generic;

namespace ATSPEK_ZODI
{
    class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Sveiki prisijungę prie ATSPEK ZODI");
            Console.WriteLine("Pasirinkite viena is triju temu:");
            Console.WriteLine("\t1 - Upes");
            Console.WriteLine("\t2 - Sostines");
            Console.WriteLine("\t3 - Valstybes");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Jus pasirinkote tema UPES");
                    Console.WriteLine();
                    string[] listwords1 = new string[5];
                    listwords1[0] = "NILAS";
                    listwords1[1] = "AMAZONE";
                    listwords1[2] = "MISISIPE";
                    listwords1[3] = "ELBE";
                    listwords1[4] = "JENISIEJUS";
                    Random randGen = new Random();
                    int idx = randGen.Next(0, 4);
                    string guessWord = listwords1[idx];
                    char[] guess = new char[guessWord.Length];
                    Console.WriteLine($"Zodis susideda is {guessWord.Length}simboliu.");
                    Console.Write("Įrašykite raide:");
                    for (int p = 0; p < guessWord.Length; p++)
                        guess[p] = '*';
                        
                    while (true)
                    {
                        char playerGuess = char.Parse(Console.ReadLine());
                        for (int j = 0; j < guessWord.Length; j++)
                            if (playerGuess == guessWord[j])
                                guess[j] = playerGuess;
                        Console.WriteLine(guess);
                    }
                    
                case "2":
                    Console.WriteLine("Jus pasirinkote tema SOSTINES");
                    Console.WriteLine();
                    String[] listwords2 = new string[5];
                    listwords2[0] = "VIENA";
                    listwords2[1] = "BRIUSELIS";
                    listwords2[2] = "NIKOSIJA";
                    listwords2[3] = "KOPENHAGA";
                    listwords2[4] = "TALINAS";
                    Random randGen2 = new Random();
                    int idx2 = randGen2.Next(0, 4);
                    string guessWord2 = listwords2[idx2];
                    char[] guess2 = new char[guessWord2.Length];
                    Console.WriteLine($"Pirmasis zodis susideda is {guessWord2.Length}simboliu.");
                    Console.Write("Įveskite pirmaja raide:");
                    for (int p = 0; p < guessWord2.Length; p++)
                        guess2[p] = '*';
                    while (true)
                    {
                        char playerGuess = char.Parse(Console.ReadLine());
                        for (int j = 0; j < guessWord2.Length; j++)
                            if (playerGuess == guessWord2[j])
                                guess2[j] = playerGuess;
                        Console.WriteLine(guess2);
                    }
                case "3":
                    Console.WriteLine("Jus pasirinkote tema VALSTYBES");
                    Console.WriteLine();
                    String[] listwords3 = new string[5];
                    listwords3[0] = "AUSTRIJA";
                    listwords3[1] = "BELGIJA";
                    listwords3[2] = "BULGARIJA";
                    listwords3[3] = "KIPRAS";
                    listwords3[4] = "DANIJA";
                    Random randGen3 = new Random();
                    int idx3 = randGen3.Next(0, 4);
                    string guessWord3 = listwords3[idx3];
                    char[] guess3 = new char[guessWord3.Length];
                    Console.WriteLine($"Zodis susideda is {guessWord3.Length}simboliu.");
                    Console.Write("Įrašykite raide:");
                    for (int p = 0; p < guessWord3.Length; p++)
                        guess3[p] = ('*');

                    while (true)
                    {
                        char playerGuess = char.Parse(Console.ReadLine());
                        for (int j = 0; j < guessWord3.Length; j++)
                            if (playerGuess == guessWord3[j])
                                guess3[j] = playerGuess;
                        Console.WriteLine(guess3);
                    }
                default:
                    Console.WriteLine("Klaida. Prašome pasirinkti skaičių nuo 1 iki 3");
                    break;
            }
        }
    }
}
