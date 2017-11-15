using System;
using System.IO;
using MorseCodeLibrary;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Morse morse = new Morse();

            Console.WriteLine("Pfad zu einer Datei einfügen: ");
            string path = Console.ReadLine();
            DecodeMessage(morse, path);

            Console.ReadKey();
        }

        public static void DecodeMessage(Morse morse, string path)
        {
            string decodedText = null;
            try
            {
                using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (BufferedStream bs = new BufferedStream(fs))
                using (StreamReader sr = new StreamReader(bs))
                {
                    string line;

                    Console.WriteLine("Dekodierter Text: ");
                    while ((line = sr.ReadLine()) != null)
                    {
                        decodedText = morse.DecodeMessage(line);
                        Console.WriteLine(decodedText);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Die angegebene Datei wurde nicht gefunden!");

            }
        }
    }
}
