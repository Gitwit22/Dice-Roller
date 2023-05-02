
Console.WriteLine("Welcome to the craps program!");
Console.WriteLine("How many sides should each die have?");
int sides = int.Parse(Console.ReadLine());


//Initialized variables and random number generator


Random ran = new Random();
int diceRoll = ran.Next(1, sides);
int diceRoll2 = ran.Next(1, sides);
int diceTotal = (diceRoll + diceRoll2);
bool playAgain = true;


// while loop for play again


while (playAgain = true)
{


    //re - Initialized variables and random number generator for while loop

     diceRoll = ran.Next(1, sides);
     diceRoll2 = ran.Next(1, sides);
     diceTotal = (diceRoll + diceRoll2);


    //Program functions/methods
     

    Console.WriteLine($"You rolled a {diceRoll}, and a {diceRoll2}. ({diceTotal} total)");
    Console.WriteLine(diceRollComments(diceRoll, diceRoll2, diceTotal));
    Console.WriteLine(DiceOutputs(diceTotal));
    Console.WriteLine("Roll Again? Y/N");
    
    string answer = Console.ReadLine();
    string ans = answer.ToLower();
    
    if (ans == "y")

    {
        playAgain = false;
    }
    else
    {
        Console.WriteLine("Hit any key to exit");
        break;
    }
}


//Method for wins and loses
static string DiceOutputs(int diceTotal)
    {
        
        switch (diceTotal)
        {

            case 1:
            case 2:
            case 3:
                return "You Lose!";
                return "Crap Out";
            case 7:
            case 11:
                return "You Win!";
            default:
                return "";
        }
    }

    //Methos for comments on dice rolls
    static string diceRollComments(int diceRoll, int diceRoll2, int diceTotal)
    {
        if (diceRoll == 6 && diceRoll2 == 6)
        {
            return "Box Cars!";
        }
        else if (diceRoll == 1 && diceRoll2 == 1)
        {
            return "Snake eyes";
        }
        else if (diceRoll == 2 && diceRoll2 == 1 || diceRoll == 1 && diceRoll2 == 2)
        {
            return "Ace Duece";
        }
        else if (diceRoll == 4 && diceRoll2 == 4)
        {
            return "Hard 8, shoot again!";
        }
            else
        {
            return " ";
            
        }
        //Random Number Generatoe
    static int randomNum(int diceRoll, int diceRoll2, int sides)
    {
        Random ran = new Random();
        diceRoll = ran.Next(1, sides);
        diceRoll2 = ran.Next(1, sides);
        return (diceRoll + diceRoll2);
    }
}



