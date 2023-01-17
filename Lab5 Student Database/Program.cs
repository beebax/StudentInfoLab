string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };
string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };
string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };

string wannaRestart;

do
{
    Console.WriteLine("Welcome to the Student Information tool!");
    Console.WriteLine("If you would like to view a list of all students, enter 'all'. Enter any other input to learn about a specific student.");
    string choiceProcess = Console.ReadLine().ToLower();

    if (choiceProcess == "all")
    {
        foreach (string n in names)
        {
            Console.WriteLine(n);
        }
    }
    else
    {
        Console.WriteLine("Which student would you like to learn about? Please enter an index number 0 - " + (names.Length - 1));
        int choiceStudent = int.Parse(Console.ReadLine());

        if (choiceStudent >= 0 && choiceStudent <= (names.Length - 1))
        {
            Console.WriteLine("Okay, you asked for information about " + names[choiceStudent]);
            Console.WriteLine("Which category would you like to explore? You can enter 'hometown' or 'favorite food'.");
            string whichSubCat = Console.ReadLine().ToLower();

            if (whichSubCat == "hometown" || whichSubCat == "home" || whichSubCat == "town")
            {
                Console.WriteLine(names[choiceStudent] + " is from " + towns[choiceStudent]);
            }

            else if (whichSubCat == "favorite food" || whichSubCat == "fave food" || whichSubCat == "food")
            {
                Console.WriteLine(names[choiceStudent] + "'s favorite food is " + foods[choiceStudent]);
            }
            else
            {
                Console.WriteLine("I'm sorry, that category name was invalid.");
            }
        }

        else
        {
            Console.WriteLine("I'm sorry, that student index number was invalid.");
        }
    }

    Console.WriteLine("Would you like to use this tool again? Enter 'Y' to continue, or any other key to exit.");
    wannaRestart = Console.ReadLine();
}
while (wannaRestart == "Y");

Console.WriteLine("Thank you for using our tool. Goodbye.");