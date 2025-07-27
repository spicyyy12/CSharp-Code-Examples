using System;

namespace CSharp_Code_Examples
{
    //authors: ethan
    //this code runs tests on StringFormat to verify sentence formatting

    public static class StringFormattesting
    {
        public static void run()
        {
            Test("   hello   world  ", "Hello World");
            Test("this IS a tEsT", "This Is A Test");
            Test(null, "");
            //again, this is okay as it still works!

        }

        static void Test(string input, string expected)
        {
            var result = StringFormat.FormatSentence(input);
            Console.WriteLine($"Input: '{input}' Result: '{result}' Pass: {result == expected}");
        }
    }
}