using System.Collections.Generic;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();
            var sentenseArray = text.Split('.', '!', '?', ';', ':', '(', ')');

            foreach (var e in sentenseArray)
            {
                if (e.Length == 0)
                {
                    continue;
                }
                     
                if (ParseWords(e).Count != 0)
                {
                    sentencesList.Add(ParseWords(e));
                }
            }
            return sentencesList;
        }

        public static List<string> ParseWords(string sentense)
        {
            var wordList = new List<string>();
            var listChar = new List<char>();

            for (var i = 0; i < sentense.Length; i++)
            {
                if (char.IsLetter(sentense[i]) || sentense[i] == '\'')
                {
                    continue;
                }
                else
                {
                    listChar.Add(sentense[i]);
                }  
            }
            var str = sentense.Split(listChar.ToArray());

            foreach (var e in str)
            {
                if (e.Length == 0) continue;
                wordList.Add(e.ToLower());
            }
            return wordList;
        }
    }
}

