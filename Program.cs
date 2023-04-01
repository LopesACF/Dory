Console.WriteLine("Converse com a Dory!");

string texto = Console.ReadLine()!;

texto = texto.Replace("a", "aaa");
texto = texto.Replace("e", "eee");
texto = texto.Replace("i", "iii");
texto = texto.Replace("o", "ooo");
texto = texto.Replace("u", "uuu");

Console.WriteLine("\nEm baleiês: " + texto);
