
using ConsoleApp1;


for (int i = 0; i < 1000; i++)
{
    var generatedCode = Algorithms.GeneratorCode();
    var isValid = Algorithms.CheckCode(generatedCode);
    Console.WriteLine($"Code: {generatedCode} - isValid: {isValid}");
}
