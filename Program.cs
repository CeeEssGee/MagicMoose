using System;

// invokes the Main() function
Main();

// declares the Main() function
void Main()
{
    // new line with \n
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!\n--------------------------------------------\n");

    //Let the moose speak - twice
    MooseSays("HI, I'M ENTHUSIASTIC!");
    MooseSays("What's your question?");

    // declares the response as an integer, which is the result of the MooseSession() function
    int response = MooseSession();
    // while loop - while the response == 1, the response will always == the initial value, so we need to re-declare it inside the loop
    while (response == 1)
    {
        response = MooseSession();
    }
}


void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
};

// declare the MooseAnswers() function
void MooseAnswers()
{
    // randomly selects a number between 0 and 19
    Random r = new Random();
    int genRand = r.Next(0, 19);

    // assigns a number between 0 and 19 to the phrases
    switch (genRand)
    {
        case 0:
            Console.WriteLine("As I see it, yes.");
            break;
        case 1:
            Console.WriteLine("Ask again later.");
            break;
        case 2:
            Console.WriteLine("Better not tell you now.");
            break;
        case 3:
            Console.WriteLine("Cannot predict now.");
            break;
        case 4:
            Console.WriteLine("Concentrate and ask again.");
            break;
        case 5:
            Console.WriteLine("Don't count on it.");
            break;
        case 6:
            Console.WriteLine("It is certain.");
            break;
        case 7:
            Console.WriteLine("It is decidedly so.");
            break;
        case 8:
            Console.WriteLine("Most likely.");
            break;
        case 9:
            Console.WriteLine("My reply is no.");
            break;
        case 10:
            Console.WriteLine("My sources say no.");
            break;
        case 11:
            Console.WriteLine("Outlook not so good.");
            break;
        case 12:
            Console.WriteLine("Outlook good.");
            break;
        case 13:
            Console.WriteLine("Reply hazy, try again.");
            break;
        case 14:
            Console.WriteLine("Signs point to yes.");
            break;
        case 15:
            Console.WriteLine("Very doubtful.");
            break;
        case 16:
            Console.WriteLine("Without a doubt.");
            break;
        case 17:
            Console.WriteLine("Yes.");
            break;
        case 18:
            Console.WriteLine("Yes - definitely.");
            break;
        case 19:
            Console.WriteLine("You may rely on it.");
            break;
    }
};

// assigns a 0 or a 1 to whether a question is asked or not so we can utilize it as a "check" above
int MooseSession()
{
    string questionAsked = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(questionAsked))
    {
        return 0;
    }
    MooseAnswers();
    return 1;


};