using Classes;

string defaultDocument = "This is an easy test document. Nothing special here. Except the fact, that the year 2023 is special.";
string document = "";
ConsoleKey cki;

do
{
    Console.Clear();
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("This is a program to analyze a text and give you statistics about the text.");
    Console.WriteLine("Press Y or N to select, how you would like to proceed.");
    Console.WriteLine("Y = test with your own text");
    Console.WriteLine("N = test with default text");
    cki = Console.ReadKey(true).Key;
} while (cki != ConsoleKey.Y && cki != ConsoleKey.N);

if (cki == ConsoleKey.N) document = defaultDocument;

if (cki == ConsoleKey.Y)
{
    Console.WriteLine();
    Console.WriteLine("Write your own text, you'd like to analyze and press enter:");
    document += Console.ReadLine();
}

DocumentProcessor docProc = new();
Stats stats = docProc.Analyze(document);

Console.WriteLine();
Console.WriteLine($"Analyzed text was: \"{document}\"");
Console.WriteLine();
Console.WriteLine("And the text was analyzed with following results:");
Console.WriteLine(stats.ToString());
Console.WriteLine();
Console.WriteLine("************************** End of the program. ****************************");

