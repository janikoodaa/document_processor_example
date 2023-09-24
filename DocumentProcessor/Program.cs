using Classes;

string document = "This is an easy test document. Nothing special here. Except the fact, that the year 2023 is special.";

DocumentProcessor docProc = new();
Stats stats = docProc.Analyze(document);

Console.WriteLine(stats.ToString());

