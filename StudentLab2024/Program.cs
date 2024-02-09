using StudentLab2024;

Student student1 = new Student("Jacob", "Detroit", "Mac n Cheese");
Student student2 = new Student("Jim", "Dallas", "Pizza");
Student student3 = new Student("Simeon", "Seattle", "Toast");

Student[] students = { student1, student2, student3 };
while (true)
{
    Console.Write("Welcome! Which student do you want to learn about? (1 - 3) ");

    if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 1 && userInput <= students.Length)
    {
        while(true) {
            
        Console.Clear();

        Console.WriteLine("You chose -  ");
        Console.WriteLine("\nName: " + students[userInput - 1].name);
        Console.WriteLine("\nWhat information would you like to see about " + students[userInput - 1].name + "?");
        Console.WriteLine("1. Hometown");
        Console.WriteLine("2. Favorite food");

        
            if (int.TryParse(Console.ReadLine(), out int infoChoice))
            {
                if (infoChoice <= 2 && infoChoice >= 1)
                {
                    if (infoChoice == 1)
                    {
                        Console.WriteLine(students[userInput - 1].name + "'s hometown is: " + students[userInput - 1].hometown);
                        break;
                    }
                    else if (infoChoice == 2)
                    {
                        Console.WriteLine(students[userInput - 1].name + "'s favorite food is: " + students[userInput - 1].favoriteFood);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid choice. please try again");
                        Thread.Sleep(1500);
                        Console.Clear();
                    }
                }
            }
            else
            {
                Console.WriteLine("Not a valid choice. please try again");
                Thread.Sleep(1500);
                Console.Clear();
            }
        }

        Console.Write("\nWould you like to try again? (y/n) ");
        string loopChoice = Console.ReadLine().ToLower();

        if (loopChoice == "y")
        {
            Console.WriteLine("\nRestarting...");
            Thread.Sleep(1500);
            Console.Clear();
        }
        else if (loopChoice == "n")
        {
            Console.WriteLine("\nGoodbye!");
            break;
        }
        else
        {
            Console.WriteLine("\nThat wasn't y or n. Restarting anyway.");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
    else
    {
        Console.WriteLine("\nThat wasn't valid input, please try again.");
        Thread.Sleep(1500);
        Console.Clear();
    }
}