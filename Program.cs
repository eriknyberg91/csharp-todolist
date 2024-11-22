Console.WriteLine("Welcome to <Todolist>");
Console.WriteLine($"Press [1] to add a new todo!");
Console.WriteLine($"Press [2] to view all current todos!");
Console.WriteLine($"Press [3] to exit program.");

string userChoice = Console.ReadLine();
    //Add while-loop (?)
    switch (userChoice)
    {
        case "1":
        //Add Todo
        Console.WriteLine("Test");
            break;

        case "2":
            //Loop through todos
            break;
        case "3":
            //Exit program
            break;
    }




static void AddTodo ()
{
    Console.Write("What do you want to add?");
    string newToDoTitle = Console.ReadLine();
}