
    {
        // Create 3 arrays. One with name, one with hometown and one with fav food
        string[] studentsName = new string[] { "Chris Cornell", "Curt Cobain", "Chris Robinson", "Robin Zander", "Stephen Tyler" };
        string[] hometown = new string[] { "Seattle", "Aberdeen", "Atlanta", "Beloit", "Yonkers" };
        string[] favoriteFood = new string[] { "Oysters", "Prawn Salad", "Tacos", "Eggs", "Pancakes" };

        bool continueToLearn = true;
        while (continueToLearn)
        {
            Console.WriteLine("Welcome!\nWhich student would you like to learn more about? Enter a number 1-5: ");

            for (int i = 0; i < studentsName.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {studentsName[i]}\n");
            }

            string input = Console.ReadLine();

            if (int.TryParse(input, out int studentsNumber))
            {
                if (studentsNumber >= 1 && studentsNumber <= studentsName.Length)
                {
                    Console.WriteLine($"You selected: {studentsName[studentsNumber - 1]}");

                    bool validCategory = true;
                    while (validCategory)
                    {
                        Console.WriteLine("What category do you want to display? (Enter 'h' for hometown or 'f' for favorite food): ");
                        string categoryInput = Console.ReadLine().Trim().ToLower();

                        if (categoryInput.Contains("h") || categoryInput.Contains("home") || categoryInput.Contains("town"))
                        {
                            Console.WriteLine($"{studentsName[studentsNumber - 1]} is from {hometown[studentsNumber - 1]}\n");
                            validCategory = false;
                        }
                        else if (categoryInput.Contains("f") || categoryInput.Contains("food") || categoryInput.Contains("fav"))
                        {
                            Console.WriteLine($"{studentsName[studentsNumber - 1]}'s favorite food is {favoriteFood[studentsNumber - 1]} \n");
                            validCategory = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid category selection, please enter 'h' for hometown or 'f' for favorite food.\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid student number. Please enter a number between 1 and 5.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }

            Console.WriteLine("Would you like to learn about another student? (yes/no)\n");
            string continueInput = Console.ReadLine().Trim().ToLower();
            continueToLearn = continueInput == "yes" || continueInput == "y";
        }

        Console.WriteLine("Thanks!");
        Console.ReadKey();
    }

