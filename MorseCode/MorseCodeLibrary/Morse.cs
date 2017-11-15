using System;
using System.Collections.Generic;

namespace MorseCodeLibrary
{
    public class Morse
    {
        private Dictionary<string, char> morseCodes;

        public Morse()
        {
            this.morseCodes = new Dictionary<string, char>();
            this.InitializeMorseCodes();
        }

        private void InitializeMorseCodes()
        {
            this.morseCodes.Add(".-", 'A');
            this.morseCodes.Add("-...", 'B');
            this.morseCodes.Add("-.-.", 'C');
            this.morseCodes.Add("-..", 'D');
            this.morseCodes.Add(".", 'E');
            this.morseCodes.Add("..-.", 'F');
            this.morseCodes.Add("--.", 'G');
            this.morseCodes.Add("....", 'H');
            this.morseCodes.Add("..", 'I');
            this.morseCodes.Add(".---", 'J');
            this.morseCodes.Add("-.-", 'K');
            this.morseCodes.Add(".-..", 'L');
            this.morseCodes.Add("--", 'M');
            this.morseCodes.Add("-.", 'N');
            this.morseCodes.Add("---", 'O');
            this.morseCodes.Add(".--.", 'P');
            this.morseCodes.Add("--.-", 'Q');
            this.morseCodes.Add(".-.", 'R');
            this.morseCodes.Add("...", 'S');
            this.morseCodes.Add("-", 'T');
            this.morseCodes.Add("..-", 'U');
            this.morseCodes.Add("...-", 'V');
            this.morseCodes.Add(".--", 'W');
            this.morseCodes.Add("-..-", 'X');
            this.morseCodes.Add("-.--", 'Y');
            this.morseCodes.Add("--..", 'Z');
            this.morseCodes.Add("-----", '0');
            this.morseCodes.Add(".----", '1');
            this.morseCodes.Add("..---", '2');
            this.morseCodes.Add("...--", '3');
            this.morseCodes.Add("....-", '4');
            this.morseCodes.Add(".....", '5');
            this.morseCodes.Add("-....", '6');
            this.morseCodes.Add("--...", '7');
            this.morseCodes.Add("---..", '8');
            this.morseCodes.Add("----.", '9');
        }

        public string DecodeMessage(string message)
        {
            string solution = "";
            char[] digits = message.ToCharArray();
            int counter = 0;
            string letter = "";

            foreach(char digit in digits)
            {
                if (digit.Equals(' ') || digit.Equals('.') || digit.Equals('-'))
                {
                    if (digit.Equals(' '))
                    {
                        counter++;
                        if (!letter.Equals(""))
                        {
                            try
                            {
                                solution += this.morseCodes[letter];
                            }
                            catch (KeyNotFoundException)
                            {
                                Console.WriteLine("Fehlerhafter Morsecode!");
                            }
                            letter = "";
                        }
                        if (counter == 4)
                        {
                            solution += " ";
                            counter = 0;
                        }       
                    } else
                    {
                        letter += digit;
                        counter = 0;
                    }
                }
            }

            try
            {
                solution += this.morseCodes[letter];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Fehlerhafter Morsecode!");
            }

            return solution;
        }
    }
}
