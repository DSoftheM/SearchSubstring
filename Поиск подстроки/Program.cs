using System;

namespace Поиск_подстроки
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Поиск самой длинной подстроки, состоящей из одного и того же символа:
            var word = "qwweeeqwweettttte"; // return ttttt
            var result = Search(word);
            Console.WriteLine(result);
        }

        private static string Search(string word)
        {
            var firstSymbol = word[0];
            var result = "";
            var maxCount = -1;
            var letter = word[0];
            var currentCount = 0;
            for (var i = 0; i < word.Length; i++)
            {
                if (firstSymbol == word[i])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        letter = word[i];
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 0;
                    firstSymbol = word[i];
                    result = "";
                }
            }
            for (var i = 0; i <= maxCount; i++)
                result += letter;
            return result;
        }
    }
}
