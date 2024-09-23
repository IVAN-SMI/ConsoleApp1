Console.WriteLine("Введите свое имя");
string? per1 = Console.ReadLine();

Console.WriteLine("Введите свою фамилию");
string? per2 = Console.ReadLine();

Console.WriteLine("Введите свое отчество");
string? per3 = Console.ReadLine();

string? text = $"Здравствуйте {per1} {per2} {per3}!";
Console.WriteLine(text);

Console.ReadKey();