List<Todo> todolist = new();
bool closeProgram = false;

do
{
    Console.Clear();
    Console.WriteLine("Welcome to <Todolist>");
    Console.WriteLine($"Press [1] to add a new todo!");
    Console.WriteLine($"Press [2] to view all current todos!");
    Console.WriteLine($"Press [3] to exit program.");
    string userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "1":
            //Add Todo
            AddTodo(todolist);
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("These are your current todos:");
            foreach (Todo todo in todolist)
            {
                Console.WriteLine(todo.Title);
            }
            Console.WriteLine("Press any key to return back to menu.");
            Console.ReadKey();
            break;
        case "3":
            //Exit program
            closeProgram = true;
            break;
    }
} while (closeProgram == false);




static void AddTodo (List<Todo> todolist)
{
    Console.Clear();
    Console.Write("What do you want to add?");
    string newToDoTitle = Console.ReadLine();
    
    Todo todo = new();
    todo.Title = newToDoTitle;
    todo.isCompleted = false;
    todo.Id = Guid.NewGuid().ToString();

    todolist.Add(todo);
    Console.Clear();
    Console.WriteLine("Todo added successfully! Returning to menu...");
    Thread.Sleep(2000);
}