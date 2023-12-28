Console.WriteLine("Input the first number: ");
var userText = Console.ReadLine();
var number1 = int.Parse(userText);

Console.WriteLine("Input the Second number: ");
var userText2 = Console.ReadLine();
var number2 = int.Parse(userText2);

Console.WriteLine("what do you want to do?");

Console.WriteLine("[A]dd a number");
Console.WriteLine("[S]numbers");
Console.WriteLine("[M]ultiply numbers");
var choice = Console.ReadLine();

if (EqualsCaseInsensitive(choice, "A"))
{
    var result = number1 + number2;
    PrintFinalEquation(number1, number2, result, "+");
}
else if (EqualsCaseInsensitive(choice, "S"))
{
    var result = number1 - number2;
    PrintFinalEquation(number1, number2, result, "-");
}
else if (EqualsCaseInsensitive(choice, "M"))
{
    var result = number1 * number2;
    PrintFinalEquation(number1, number2, result, "*");
}

else
{
    Console.WriteLine("type a valid number!");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

void PrintFinalEquation(int number1, int number2, int result, string @operator)
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
}
    
