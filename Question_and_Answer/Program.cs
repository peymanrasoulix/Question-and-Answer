// Peyman Rasouli -- Q&A


// data haei ke masalan az server gereftim
List<string> questions = new List<string>()
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
List<string> Answers = new List<string>();
string digit;

start_questions();

// vorod meghdare yes ya no
void locked_ys(string q)
{
    Console.WriteLine(q);
    do
    {
        digit = Console.ReadKey(true).KeyChar.ToString();
    } while (digit.ToLower() != "y" && digit.ToLower() != "n" && digit.ToLower() != "غ" && digit.ToLower() != "د");
    digit = digit.ToLower();
}
// bakhshe ejraei barname
void start_questions()
{
    foreach (var question in questions)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        locked_ys(question);
        Switch_questions(question, digit);
        Console.Clear();
    }
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("You are a {0} {1} {2} {3} children\nand your monthly income {4}\n{5}", Answers[1], Answers[2], Answers[0], Answers[4], Answers[5], Answers[6]);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(Answers[7]);
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    locked_ys("Do you want to continue?");
    if (digit == "y")
    {
        Console.Clear();
        Answers.Clear();
        start_questions();
    }
}
// dastor swidch baraye tashkhis soval ha
void Switch_questions(string a,string d)
{
    if (digit == "y" || digit == "غ")
    {
        switch (a)
        {
            case "Are you a man?":
                Answers.Add("Man");
                break;
            case "Are you young?":
                Answers.Add("Young");
                break;
            case "Are you married?":
                Answers.Add("Married");
                break;
            case "Have you ever married?":
                Answers.Add("Yes");
                break;
            case "Do you have children?":
                Answers.Add("Without");
                break;
            case "Is your monthly income over 15 tomans?":
                Answers.Add("Is over 15 tomans");
                break;
            case "Are you satisfied with your life?":
                Answers.Add("So you are satisfied with your life");
                break;
            case "Did you like this program?":
                Answers.Add("Thank you for choosing us :)");
                break;

        }
    }
    else {
        switch (a)
        {
            case "Are you a man?":
                Answers.Add("Woman");
                break;
            case "Are you young?":
                Answers.Add("Old");
                break;
            case "Are you married?":
                Answers.Add("Single");
                break;
            case "Have you ever married?":
                Answers.Add("No");
                break;
            case "Do you have children?":
                Answers.Add("With");
                break;
            case "Is your monthly income over 15 tomans?":
                Answers.Add("Is below 15 tomans");
                break;
            case "Are you satisfied with your life?":
                Answers.Add("Then you are not satisfied with your life");
                break;
            case "Did you like this program?":
                Answers.Add("We hope to be able to satisfy you next time");
                break;
            case "are you a human??":
                Console.ReadKey();
                break;
        }
    }
}
