string userAnswer = "repeat";
string userName;
string userNumber;
int userNumberParse;

Console.WriteLine("Hello. What is your name?");
userName = Console.ReadLine();

while (userAnswer != "exit")
{ 
    Console.WriteLine($"\nAlright {userName}, Please enter an integer between 1 and 100.");
    userNumber = Console.ReadLine();
    if (int.TryParse(userNumber, out int number))
    {
        userNumberParse = int.Parse(userNumber);
        numberValidation();
        if (userNumberParse < 60 && userNumberParse % 2 != 0)
        {
            Console.WriteLine($"\n{userName}, {userNumberParse} is Odd and less than 60.");
        }
        else if (userNumberParse < 25 && userNumberParse % 2 == 0)
        {
            Console.WriteLine($"\n{userName}, {userNumberParse} is Even and less than 25.");
        }
        else if (userNumberParse > 25 && userNumberParse < 61 && userNumberParse % 2 == 0)
        {
            Console.WriteLine($"\n{userName}, {userNumberParse} is Even and between 26 and 60.");
        }
        else if (userNumberParse > 60 && userNumberParse % 2 == 0)
        {
            Console.WriteLine($"\n{userName}, {userNumberParse} is Even and greater than 60.");
        }
        else if (userNumberParse > 60 && userNumberParse % 2 != 0)
        {
            Console.WriteLine($"\n{userName}, {userNumberParse} is Odd and greater than 60.");
        }
        Console.WriteLine($"\nOkay {userName}, if you would like to exit the program, please type \"exit\" \n" +
            $"and press enter. Simply press enter to repeat the number analyzer program.");
        userAnswer = Console.ReadLine().ToLower().Trim();
    }
    else
    {
        Console.WriteLine($"\nSorry {userName}, That is an invalid number.");
    }

 
    void numberValidation()
    {
        while (userNumberParse < 0 || userNumberParse > 100)
        {
            Console.WriteLine($"\nI'm sorry {userName}, that is not a valid number. Can you please enter another \n" +
                $"integer between 1 and 100?");
            userNumber = Console.ReadLine();
            if(int.TryParse(userNumber, out int number))
            {
                userNumberParse = int.Parse(userNumber);
            }
        }
    }
}