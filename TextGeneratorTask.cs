using System.Collections.Generic;
using System.Text;

namespace TextAnalysis
{
    static class TextGeneratorTask
    {
        public static string ContinuePhrase(Dictionary<string, string> nextWords, string phraseBeginning, int wordsCount)
        {
            var result = phraseBeginning;

            for (var i = 0; i < wordsCount; i++)
            {
                var words = result.Split(' ');
                var length = words.Length;

                if (length >= 2 && nextWords.ContainsKey(words[length - 2] + " " + words[length - 1]))
                {
                    result += " " + nextWords[words[length - 2] + " " + words[length - 1]];
                    continue;
                }

                if (nextWords.ContainsKey(words[length - 1]))
                {
                    result += " " + nextWords[words[length - 1]];
                }
            }
            return result;
        }
    }
}