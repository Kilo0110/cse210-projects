using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        EternalQuestProgram program = new EternalQuestProgram();

        int selectedMenuOption;

        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest Program");
        menu.DisplayMenu();

        Console.Write("What would you like to do? ");

        selectedMenuOption = int.Parse(Console.ReadLine());

        while (selectedMenuOption != 7)
        {
            if (selectedMenuOption == 1)
            {
                program.DisplayScore();
                menu.DisplayMenu();
            }
            else if (selectedMenuOption == 2)
            {
                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();

                Console.Write("Enter goal value: ");
                int value = int.Parse(Console.ReadLine());

                Console.Write("Enter goal type (simple/eternal/checklist/penalty): ");
                string type = Console.ReadLine();

                if (type.ToLower() == "simple")
                {
                    program.CreateGoal(name, value, type, 0);
                }
                else if (type.ToLower() == "eternal")
                {
                    program.CreateGoal(name, value, type, 0);
                }
                else if (type.ToLower() == "checklist")
                {
                    Console.Write("Enter required count: ");
                    int requiredCount = int.Parse(Console.ReadLine());
                    program.CreateGoal(name, value, type, requiredCount);
                }
                else if (type.ToLower() == "penalty")
                {
                    program.CreateGoal(name, value, type, 0);
                }

                menu.DisplayMenu();
            }
            else if (selectedMenuOption == 3)
            {
                program.DisplayGoals();
                Console.Write("Enter the index of the goal you want to record an event for: ");
                int index = int.Parse(Console.ReadLine());
                program.RecordEvent(index);
                menu.DisplayMenu();
            }
            else if (selectedMenuOption == 4)
            {
                program.DisplayGoals();
                menu.DisplayMenu();
            }
            else if (selectedMenuOption == 5)
            {
                Console.Write("Enter file name to save goals: ");
                string fileName = Console.ReadLine();
                program.SaveGoals(fileName);
                menu.DisplayMenu();
            }
            else if (selectedMenuOption == 6)
            {
                Console.Write("Enter file name to load goals: ");
                string fileName = Console.ReadLine();
                program.LoadGoals(fileName);
                menu.DisplayMenu();
            }

            Console.Write("What would you like to do? ");
            selectedMenuOption = int.Parse(Console.ReadLine());
        }
    }
}
