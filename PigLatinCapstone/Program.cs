using System;

namespace PigLatinCapstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elcomeWay otay ethay igPay atinLay anslatorTray");

            while (true)
            {
                Console.WriteLine("Enter a line to be translated");
                string inputLine = Console.ReadLine();

                int inputLength = inputLine.Length;

                if (inputLength > 0)
                {
                    string translated = "";
                    string[] words = inputLine.Split(' ', '.', ',', '!', '?');

                    string vowels = "AEIOUaeiou";

                    foreach(string word in words)
                    {
                        int moveOnWord = 0;
                        string consonants = "";
                        //if a consonant, & haven't reached end of word yet, then add it to consonants string
                        while(vowels.Contains(word[moveOnWord]) == false && moveOnWord < word.Length)
                        {
                            consonants += word[moveOnWord];
                            moveOnWord += 1;
                        }

                        string pigWord = "";

                        while(moveOnWord < word.Length)
                        {
                            //moving down rest of word starting @ vowel
                            //putting them into pigWord
                            pigWord += word[moveOnWord];
                            moveOnWord += 1;

                        }
                        //At this point we have the consonants from the beginning of the word in the 
                        //consonant string variable and we have the remainder of the word in pigWord
                        if (consonants.Length > 0)
                        {
                            pigWord += consonants + "ay";

                        }
                        else
                        {
                            pigWord += "way";
                        }

                        translated += pigWord;
                        translated += " ";

                    }

                    Console.WriteLine(translated);

                }
                else
                {
                    Console.WriteLine("Please enter a valid input.");
                }

                Console.WriteLine("Translate another line? y/n");
                string inputContinue = Console.ReadLine();

                if (inputContinue == "n")
                {
                    break;
                }

            } 
        }
    }
}
