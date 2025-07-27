using System;

namespace CSharp_Code_Examples
{
    //author: ethan
    //this code formats input string by trimming and capitalizing each word

    public static class StringFormat
    {
        public static void run()
        {
            Console.WriteLine(FormatSentence("   hello   lincoln  "));
            Console.WriteLine(FormatSentence("this IS a tEsT"));
            Console.WriteLine(FormatSentence(null));   
            //this is okay as it still works                
        }

        public static string FormatSentence(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var words = input.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }

            return string.Join(' ', words);
        }
    }
}