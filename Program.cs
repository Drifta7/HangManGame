using System;
using System.Collections.Generic;

namespace HangManGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> hangManList = new List<string>();

            hangManList.Add("engine");
            hangManList.Add("gearbox");
            hangManList.Add("sparkplugs");
            hangManList.Add("transmission");
            hangManList.Add("piston");
            hangManList.Add("manual");
            hangManList.Add("brakerotors");
            hangManList.Add("windshield");
            hangManList.Add("steeringwheel");

            char charEntry = 'A';


            int low = 0; // for the random low
            int high = hangManList.Count; // for the random high

            Random rng = new Random();
            int randomList = rng.Next(low, high);

            string storeRandWord = hangManList[randomList]; // Stores the random word from the list in a variable
            char[] randomWordToChar = storeRandWord.ToCharArray(); // this will put the random word into the char array

            char[] displayLineArray = new char[storeRandWord.Length]; // this will store the array in an new instance to get the length

            int tryCounter = 0; // this will keep track of the amount of tries in the program.
            bool isSolved = false;

            for (int i = 0; i < displayLineArray.Length; i++) // this loop will display the underscores first before the word array?
            {
                displayLineArray[i] = '_';
            }


            Console.WriteLine("Input a Letter for the word"); // Prompt for input

            while (!isSolved && tryCounter < storeRandWord.Length)
            {
                Console.Clear();
                Console.Write(new string(displayLineArray)); // the new string will create an instance of the display array


                charEntry = Convert.ToChar(Console.ReadLine().ToLower()); // converts input from user to char for entry.


                bool letterfound = false;

                for (int i = 0; i < storeRandWord.Length; i++) // loops the user input char

                {
                    if (randomWordToChar[i] == charEntry)
                    {
                        displayLineArray[i] = charEntry;// this will replace the letter within the displayed array with is '_'
                        letterfound = true; // set to true 

                    }
                }
                if (!letterfound)

                {
                    tryCounter++;// if the letter isn't found this will increment it
                }
                if (new string(displayLineArray) == storeRandWord)
                {
                    isSolved = true;
                }
                Console.WriteLine("Press any key to continue....."); // this will signal to keep going
                Console.ReadKey();
            }

            if (isSolved)
            {
                Console.WriteLine("congrats! you've guessed the word: " + storeRandWord);
            }
            else
            {
                Console.WriteLine("Sorry, you've reached the max number of tries. THe word was:" + storeRandWord);
            }
        }

    }
}

