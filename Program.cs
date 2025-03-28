Console.Clear();
String Cebolinha;
// frase do Cebolinha
Console.WriteLine("ola eu sou o cebolinha sela que voce podelia me ajuda a escleve uma flase:");
Console.WriteLine();
Cebolinha=Console.ReadLine()! .Replace("r","l") .ToUpper();
Console.WriteLine("===============================");
Console.ForegroundColor =ConsoleColor.Yellow;
Console.WriteLine($"// {Cebolinha} //");
Console.ResetColor();
Console.WriteLine();