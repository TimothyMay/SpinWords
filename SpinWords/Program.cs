using System;

namespace SpinWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sentence:");

            var sentence = Console.ReadLine();
            Console.WriteLine(SpinWords(sentence));
            Console.ReadLine();
        }

        public static string SpinWords(string sentence)
        {
            string x = string.Empty;

            var parts = sentence.Split(' ');
            foreach (var part in parts)
            {
                var y = string.Empty;
                if (part.Length > 4)
                {
                    y = ReverseWord(part) + " ";
                }
                else
                {
                    y = part + " ";
                }
                x += y;
            }
            return x.Trim(' ');
        }

        public static string ReverseWord(string word)
        {
            char[] letters = word.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}
