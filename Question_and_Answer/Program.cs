//Peyman Rasouli -- Q&A
string digit;

// data haei ke masalan az server gereftim
List<string> qu = new List<string>()
{   "are you a human??",
    "Are you a man?",
    "Are you young?",
    "Are you married?",
    "Have you ever married?",
    "Do you have children?",
    "Is your monthly income over 15 tomans?",
    "Are you satisfied with your life?",
    "Did you like this program?"
};
List<string> an = new List<string>();

start_questions();

//vorod meghdare yes ya no
void locked_ys(string q)
{
    Console.WriteLine(q);
    do
    {
        digit = Console.ReadKey(true).KeyChar.ToString();
    } while (digit.ToLower() != "y" && digit.ToLower() != "n" && digit.ToLower() != "غ" && digit.ToLower() != "د");
    digit = digit.ToLower();
}
//bakhshe ejraei barname
void start_questions()
{
    foreach (var qua in qu)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        locked_ys(qua);
        Switch_questions(qua, digit);
        Console.Clear();
    }
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("You are a {0} {1} {2} {3} children\nand your monthly income {4}\n{5}", an[1], an[2], an[0], an[4], an[5], an[6]);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(an[7]);
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    locked_ys("Do you want to continue?");
    if (digit == "y")
    {
        Console.Clear();
        an.Clear();
        start_questions();
    }
}
//dastor swidch baraye tashkhis soval ha
void Switch_questions(string a,string d)
{
    if (digit == "y" || digit == "غ")
    {
        switch (a)
        {
            case "Are you a man?":
                an.Add("Man");
                break;
            case "Are you young?":
                an.Add("Young");
                break;
            case "Are you married?":
                an.Add("Married");
                break;
            case "Have you ever married?":
                an.Add("Yes");
                break;
            case "Do you have children?":
                an.Add("Without");
                break;
            case "Is your monthly income over 15 tomans?":
                an.Add("Is over 15 tomans");
                break;
            case "Are you satisfied with your life?":
                an.Add("So you are satisfied with your life");
                break;
            case "Did you like this program?":
                an.Add("Thank you for choosing us :)");
                break;

        }
    }
    else {
        switch (a)
        {
            case "Are you a man?":
                an.Add("Woman");
                break;
            case "Are you young?":
                an.Add("Old");
                break;
            case "Are you married?":
                an.Add("Single");
                break;
            case "Have you ever married?":
                an.Add("No");
                break;
            case "Do you have children?":
                an.Add("With");
                break;
            case "Is your monthly income over 15 tomans?":
                an.Add("Is below 15 tomans");
                break;
            case "Are you satisfied with your life?":
                an.Add("Then you are not satisfied with your life");
                break;
            case "Did you like this program?":
                an.Add("We hope to be able to satisfy you next time");
                break;
            case "are you a human??":
                Console.ReadKey();
                break;
        }
    }
}
