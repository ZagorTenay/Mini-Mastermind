using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b; //numbers that we will be computer's number
            int c, d; //feedback that player will enter
            int cs = 0, ps = 0; //computer score and player score
            int pn; // player's guess
            int round; //round counter
            int game; // game counter

            game = 1;
            round = 1;

            while (round < 11)
            {
                int gc = 0; // guessing counter
                if (game == 1) //Computer Codemaker, Player Codebreaker
                {
                    c = 0;
                    d = 0;

                    Console.WriteLine("Round: " + round);
                    Console.WriteLine("Game: " + game);
                    Console.WriteLine("Computer score: " + cs);
                    Console.WriteLine("Player score: " + ps);
                    Console.WriteLine();

                    Random random1 = new Random();
                    a = random1.Next(1, 4);
                    b = random1.Next(1, 4);
                    
                    while (a == b)
                    {
                        Random random2 = new Random();
                        a = random2.Next(1, 4);
                        b = random2.Next(1, 4);
                    }


                    while (c != 2 ) //conditions to finish the game
                    {

                        Console.Write("Enter your guess: ");
                        pn = Convert.ToInt32(Console.ReadLine());

                        if (pn == 12 | pn == 13 | pn == 21 | pn == 23 | pn == 31 | pn == 32)
                        {

                            if (a == pn / 10 && b == pn % 10)
                            {
                                c = 2;
                                d = 0;
                            }
                            else if (a == pn % 10 && b == pn / 10)
                            {
                                c = 0;
                                d = 2;
                            }
                            else if (a == pn / 10 || b == pn % 10)
                            {
                                c = 1;
                                d = 0;
                            }
                            else if (a == pn % 10 || b == pn / 10)
                            {
                                c = 0;
                                d = 1;
                            }
                            Console.WriteLine("Feedback(+): " + c); //Computer's feedback
                            Console.WriteLine("Feedback(-): " + d);
                            gc = gc + 1;

                        }
                    }

                    Console.WriteLine();

                    if (gc > 3)
                    {
                        Console.Write("Computer Wins!");
                    }
                    else
                    {
                        Console.WriteLine("Player Wins!");
                    }
                    cs = cs + gc;
                    game++;
                }


                if(game==2) //Computer Codebreaker, Player Codemaker
                {
                    gc = 0;
                    Console.WriteLine();
                    Console.WriteLine("Keep a number and press 'Enter'...");
                    Console.WriteLine("---------------------");
                    Console.ReadLine();
                    

                    Console.WriteLine("Round: " + round);
                    Console.WriteLine("Game: " + game);
                    Console.WriteLine("Computer score: " + cs);
                    Console.WriteLine("Player score: " + ps);
                    Console.WriteLine();

                    int x; //for feedbacks like 0,-1/1,0
                    int e; //for 3rd guess

                    Random rnd1 = new Random();
                    a = rnd1.Next(1, 4);
                    b = rnd1.Next(1, 4);
                    x = rnd1.Next(1, 4);

                    while (a == b | b == x | a == x)
                    {
                        a = rnd1.Next(1, 4);
                        b = rnd1.Next(1, 4);
                        x = rnd1.Next(1, 4);
                    }

                    Console.Write("My Guess: " + a);
                    Console.WriteLine(b);
                    gc++;

                    Console.Write("Feedback (+): ");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Feedback (-): ");
                    d = Convert.ToInt32(Console.ReadLine());

                    while ((c != 2 & d != 0 | c != 1 & d != 0) & (c != 0 & d != 1 | c != 0 & d != 2))
                    {
                        Console.WriteLine("Check your feedback please.");
                        Console.Write("Feedback (+): ");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Feedback (-): ");
                        d = Convert.ToInt32(Console.ReadLine());
                    }
                 

                            if (c == 2 & d == 0) //Feedback 2,0
                            {
                                Console.WriteLine();
                                Console.WriteLine("Computer Wins!");
                            }
                            else if (d == 2 & c == 0) //Feedback 0,-2
                            {
                                Console.Write("My Guess " + b);
                                Console.WriteLine(a);
                                gc++;
                                Console.Write("Feedback (+): ");
                                c = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Feedback (-): ");
                                d = Convert.ToInt32(Console.ReadLine());
                                while (c != 2 && d != 0)
                                {
                                    Console.WriteLine("Check your feedback please.");
                                    Console.Write("Feedback (+): ");
                                    c = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Feedback (-): ");
                                    d = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.WriteLine();
                                Console.WriteLine("Computer Wins!");
                                Console.ReadLine();
                            }

                            else if (c == 1 & d == 0) //Feedback 1,0
                            {
                                //ab ==> ax,xb
                                Random rnd2 = new Random();
                                e = rnd2.Next(1, 3);

                                switch (e)
                                {
                                    case 1:
                                        Console.Write("My Guess " + a);
                                        Console.WriteLine(x);
                                        break;
                                    case 2:
                                        Console.Write("My Guess " + x);
                                        Console.WriteLine(b);
                                        break;
                                }
                                gc++;
                                Console.Write("Feedback (+): ");
                                c = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Feedback (-): ");
                                d = Convert.ToInt32(Console.ReadLine());
                                while (c != 2 && d != 0 | c != 0 && d != 1)
                                {
                                    Console.WriteLine("Check your feedback please.");
                                    Console.Write("Feedback (+): ");
                                    c = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Feedback (-): ");
                                    d = Convert.ToInt32(Console.ReadLine());
                                }

                                if (c == 0 & d == 1) //Feedback 1,0 ==> Feedback 0,-1
                                {
                                    if (e == 1)
                                    {
                                        Console.Write("My Guess " + x);
                                        Console.WriteLine(b);
                                    }
                                    else if (e == 2)
                                    {
                                        Console.Write("My Guess " + a);
                                        Console.WriteLine(x);
                                    }

                                    gc++;
                                    Console.Write("Feedback (+): ");
                                    c = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Feedback (-): ");
                                    d = Convert.ToInt32(Console.ReadLine());


                                    while (c != 2 && d != 0)
                                    {
                                        Console.WriteLine("Check your feedback please.");
                                        Console.Write("Feedback (+): ");
                                        c = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Feedback (-): ");
                                        d = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                                if (c == 2 && d == 0) //Feedback 1,0 ==> Feedback 2,0
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Computer Wins!");
                                }
                            }
                            else if (c == 0 && d == 1) //Feedback 0,-1
                            {
                                //..ab ==> bx xa 
                                gc++;

                                Random rnd2 = new Random();
                                e = rnd2.Next(1, 3);

                                switch (e)
                                {
                                    case 1:
                                        Console.Write("My Guess " + x);
                                        Console.WriteLine(a);
                                        break;
                                    case 2:
                                        Console.Write("My Guess " + b);
                                        Console.WriteLine(x);
                                        break;
                                }

                                Console.Write("Feedback (+): ");
                                c = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Feedback (-): ");
                                d = Convert.ToInt32(Console.ReadLine());
                                while (c != 2 && d != 0 | c != 0 && d != 1)//Checking feedback after (0,-1)
                                {
                                    Console.WriteLine("Check your feedback please.");
                                    Console.Write("Feedback (+): ");
                                    c = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Feedback (-): ");
                                    d = Convert.ToInt32(Console.ReadLine());
                                }

                                if (c == 0 & d == 1)//Feedback 0,-1 ==> Feedback 0,-1
                                {
                                    gc++;

                                    if (e == 1)
                                    {
                                        Console.Write("My Guess " + b);
                                        Console.WriteLine(x);
                                    }
                                    else if (e == 2)
                                    {
                                        Console.Write("My Guess " + x);
                                        Console.WriteLine(a);
                                    }

                                    Console.Write("Feedback (+): ");
                                    c = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Feedback (-): ");
                                    d = Convert.ToInt32(Console.ReadLine());

                                    while (c != 2 && d != 0)
                                    {
                                        Console.WriteLine("Check your feedback please.");
                                        Console.Write("Feedback (+): ");
                                        c = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Feedback (-): ");
                                        d = Convert.ToInt32(Console.ReadLine());
                                    }

                                }
                                if (c == 2 && d == 0)//Feedback 2,0
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Computer Wins!");
                                }
                            }

                    Console.WriteLine();
                    Console.WriteLine("If you want to continue, press 'Enter' please...");
                    Console.WriteLine("---------------------");
                    Console.ReadLine();
                    ps = ps + gc;
                    game--;
                    round++;
                }
            }

            Console.WriteLine("Computer Score:" + cs);
            Console.WriteLine("Player Score:" + ps);
            if (cs > ps)
            {
                Console.WriteLine("Winner is computer!");
            }
            else if (cs < ps)
            {
                Console.WriteLine("Winner is player!");
            }
            else if (cs==ps)
            {
                Console.WriteLine("Draw!");
            }
            Console.ReadLine();
        }
    }
}
