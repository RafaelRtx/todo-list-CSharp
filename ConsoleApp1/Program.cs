Console.WriteLine("Provide a number.");
int number = Console.ReadLine();
int parsedNumber = int.Parse(number);

Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODO's");
Console.WriteLine("[A]dd a new TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("Hweloelo");

var userChoice = Console.ReadLine();

if (userChoice == "S")
{
    PrintSelectdOption("See all TODOs");
}
else if (userChoice == "A")
{
    PrintSelectdOption("Add a TODO");
}

else if (userChoice == "R")
{
    PrintSelectdOption("Remove a TODO");
}
else
{
    PrintSelectdOption("Exit");
}

Console.ReadKey();


void PrintSelectdOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}
