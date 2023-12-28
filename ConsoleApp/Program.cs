using System;
using System.Reflection;

var todos = new List<string>();

bool selectedExit = false;
while (selectedExit == false)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODO's");
    Console.WriteLine("[A]dd a new TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");


    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "S":
        case "s":
            SeeAllTodos();
            Console.WriteLine("See All TODOs");
            break;

        case "A":
        case "a":
            Console.WriteLine("Add a TODO");
            AddTodo();
            break;

        case "R":
        case "r":
            Console.WriteLine("Remove a TODO");
            RemoveTodo();
            break;

        case "E":
        case "e":
            Console.WriteLine("Exit");
            selectedExit = true;
            break;
    }
}

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }

    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }

}
void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter the TODO description: ");
        description = Console.ReadLine();

    } while (!isDescriptionValid(description));

    todos.Add(description);
}

void RemoveTodo()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }

    SeeAllTodos();
    int index;
    do
    {
        Console.WriteLine("Choose an index to remove the todo");

    } while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index - 1);
}

void RemoveTodoAtIndex(int index)
{
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("TODO  removed: " + todoToBeRemoved);
}

bool isDescriptionValid(string description)
{

    if (description == "")
    {
        Console.Write("TODO's can't be empty");
        return false;
    }
    else if (todos.Contains(description))
    {
        Console.WriteLine("The description must be unique");
        return false;
    }
    else return true;

}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.Write("Index cannot be empty.");
        return false;
    }
    if (int.TryParse(userInput, out index) && index >= 1 && index <= todos.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid");
    return false;
}

static void ShowNoTodosMessage()
{
    Console.WriteLine("there's no TODOs registered");
}


