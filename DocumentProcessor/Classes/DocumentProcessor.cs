using Interfaces;

namespace Classes;
public class DocumentProcessor : IDocumentProcessor
{
    public Stats Analyze(string document)
    {
        Stats stats = new();
        string[] split = document.Split();

        stats.NumberOfAllWords = split.Length;

        string shortestWord = "";
        int charsInShortestWord = 0;
        string longestWord = "";
        int charsInLongestWord = 0;
        int wordsWithOnlyDigits = 0;
        int wordsStartingWithSmallLetter = 0;
        int wordsStartingWithCapitalLetter = 0;

        for (int i = 0; i < stats.NumberOfAllWords; i++)
        {
            string word = split[i];
            if (i == 0)
            {
                shortestWord = word;
                charsInShortestWord = word.Length;
                longestWord = word;
                charsInLongestWord = word.Length;
            }
            else
            {
                if (charsInShortestWord > word.Length)
                {
                    shortestWord = word;
                    charsInShortestWord = word.Length;
                }
                if (charsInLongestWord < word.Length)
                {
                    longestWord = word;
                    charsInLongestWord = word.Length;
                }
            }

            if (int.TryParse(word, out int number))
            {
                wordsWithOnlyDigits++;
            }
            else if (word[0] == word.ToLower()[0])
            {
                wordsStartingWithSmallLetter++;
            }
            else
            {
                wordsStartingWithCapitalLetter++;
            }
        }

        stats.TheShortestWord = shortestWord;
        stats.TheLongestWord = longestWord;
        stats.NumberOfWordsThatContainOnlyDigits = wordsWithOnlyDigits;
        stats.NumberOfWordsStartingWithSmallLetter = wordsStartingWithSmallLetter;
        stats.NumberOfWordsStartingWithCapitalLetter = wordsStartingWithCapitalLetter;

        return stats;
    }
}