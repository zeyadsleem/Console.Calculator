using Calculator;

Menu menu = new();

DateTime date = DateTime.UtcNow;

string name = GetName();

menu.ShowMenu(name, date);

static string GetName()
{
    Console.WriteLine("Please type your name");
    string? name = Console.ReadLine();
    return name;
}
