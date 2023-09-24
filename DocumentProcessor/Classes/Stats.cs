namespace Classes;
public class Stats
{
    // Total number of all words in the document
    public int NumberOfAllWords { get; set; }

    // Returns number of words that consist only from digits e.g. 13455, 98374
    public int NumberOfWordsThatContainOnlyDigits { get; set; }

    // Returns number of words that start with a lower letter e.g. a, d, z
    public int NumberOfWordsStartingWithSmallLetter { get; set; }

    // Returns number of words that start with a capital letter e.g. A, D, Z
    public int NumberOfWordsStartingWithCapitalLetter { get; set; }

    // Returns the first longest word in the document
    public string TheLongestWord { get; set; } = string.Empty;

    // Returns the first shortest word in the document
    public string TheShortestWord { get; set; } = string.Empty;

    // Prints out the stats object
    public override string ToString()
    {
        string result = $"Number of all words in the document: {NumberOfAllWords}\n" +
                        $"The shortest word in the document is \"{TheShortestWord}\"\n" +
                        $"The longest word in the document is \"{TheLongestWord}\"\n" +
                        $"Number of words containing only digits: {NumberOfWordsThatContainOnlyDigits}\n" +
                        $"Number of words starting with a capital letter: {NumberOfWordsStartingWithCapitalLetter}\n" +
                        $"Number of words starting with a small letter: {NumberOfWordsStartingWithSmallLetter}";
        return result;
    }
}