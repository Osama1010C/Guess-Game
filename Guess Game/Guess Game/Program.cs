using System.Diagnostics;

namespace Guess_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }

        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("======================\n      Guess Game\n======================\n");
                Console.WriteLine("1] Start\n\n2] Info\n\n3] Exit\n");
                int select1;
                while (true)
                {
                    try
                    {
                        select1 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unknown Choice");
                        continue;
                    }
                    if (select1 != 1 && select1 != 2 && select1 != 3)
                    {
                        Console.WriteLine("Unknown Choice");
                        continue;
                    }
                    else break;
                }
                
                
                if(select1 == 1)
                {
                    Console.Clear();
                    while (true)
                    {

                        Console.WriteLine("======================\n      Guess Game\n======================\n");
                        Console.WriteLine("1] Easy Level\n\n2] Normal Level\n\n3] Hard Level\n\n4] Back\n");
                        int select2;
                        while (true)
                        {
                            try
                            {
                                select2 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Unknown Choice");
                                continue;
                            }
                            if (select2 != 1 && select2 != 2 && select2 != 3 && select2 != 4)
                            {
                                Console.WriteLine("Unknown Choice");
                                continue;
                            }
                            else break;
                        }
                        if (select2 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("======================\n      Guess Game\n======================\n");
                            Random random = new Random();
                            int rightNumber = random.Next(0,11);
                            Hint hint = new Hint(rightNumber);
                            hint.CreateHints();
                            int availableHints = 3;
                            int chances = 3;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("======================\n      Guess Game\n======================\n");
                                Console.WriteLine($"Chances Left : {chances}  |  Hints : {availableHints}\n-------------------------------\n");
                                Console.Write("Guess < -1 For a Hint > : ");
                                if (chances == 0)
                                {
                                    Console.WriteLine($"You Lose The Answer Was {rightNumber}\n\n\n");
                                    Console.WriteLine("< Click Enter To Back >");
                                    string enter = Console.ReadLine();
                                    break;
                                }
                                int guess;
                                while (true)
                                {
                                    try
                                    {
                                        guess = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Invalid Guess");
                                        continue;
                                    }
                                    if (guess < 0 && guess != -1)
                                    {
                                        Console.WriteLine("Bro We Are Start From < Zero >");
                                        continue;
                                    }
                                    else if (guess > 10)
                                    {
                                        Console.WriteLine($"Bro We Are End In < {10} >");
                                        continue;
                                    }
                                    else break;
                                }

                                if (guess == -1)
                                {
                                    if (availableHints != 0)
                                    {
                                        Console.WriteLine($"Hint > {hint.GetHint()}");
                                        availableHints--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You Don't Have Any Hints Left");
                                    }

                                }
                                else
                                {
                                    if (guess == rightNumber)
                                    {
                                        Console.WriteLine($"{guess} Is The Right Answer \n\nYou Win\n\n\n");
                                        Console.WriteLine("< Click Enter To Back >");
                                        string enter = Console.ReadLine();
                                        break;

                                    }
                                    else
                                    {
                                        chances--;
                                        Console.WriteLine("Wrong Answer\n");
                                        if (chances == 0)
                                        {
                                            Console.WriteLine($"You Lose The Answer Was {rightNumber}\n\n\n");
                                            Console.WriteLine("< Click Enter To Back >");
                                            string enter = Console.ReadLine();
                                            break;
                                        }
                                    }
                                }
                                Thread.Sleep(2000);
                                Console.Clear();
                            }

                            Console.Clear();
                        }
                        else if (select2 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("======================\n      Guess Game\n======================\n");
                            Random random = new Random();
                            int rightNumber = random.Next(0, 26);
                            Hint hint = new Hint(rightNumber);
                            hint.CreateHints();
                            int availableHints = 3;
                            int chances = 5;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("======================\n      Guess Game\n======================\n");
                                Console.WriteLine($"Chances Left : {chances}  |  Hints : {availableHints}\n-------------------------------\n");
                                Console.Write("Guess < -1 For a Hint > : ");
                                if (chances == 0)
                                {
                                    Console.WriteLine($"You Lose The Answer Was {rightNumber}\n\n\n");
                                    Console.WriteLine("< Click Enter To Back >");
                                    string enter = Console.ReadLine();
                                    break;
                                }
                                int guess;
                                while (true)
                                {
                                    try
                                    {
                                        guess = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Invalid Guess");
                                        continue;
                                    }
                                    if (guess < 0 && guess != -1)
                                    {
                                        Console.WriteLine("Bro We Are Start From < Zero >");
                                        continue;
                                    }
                                    else if (guess > 25)
                                    {
                                        Console.WriteLine($"Bro We Are End In < {25} >");
                                        continue;
                                    }
                                    else break;
                                }

                                if (guess == -1)
                                {
                                    if (availableHints != 0)
                                    {
                                        Console.WriteLine($"Hint > {hint.GetHint()}");
                                        availableHints--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You Don't Have Any Hints Left");
                                    }

                                }
                                else
                                {
                                    if (guess == rightNumber)
                                    {
                                        Console.WriteLine($"{guess} Is The Right Answer \n\nYou Win\n\n\n");
                                        Console.WriteLine("< Click Enter To Back >");
                                        string enter = Console.ReadLine();
                                        break;

                                    }
                                    else
                                    {
                                        chances--;
                                        Console.WriteLine("Wrong Answer\n");
                                        if (chances == 0)
                                        {
                                            Console.WriteLine($"You Lose The Answer Was {rightNumber}\n\n\n");
                                            Console.WriteLine("< Click Enter To Back >");
                                            string enter = Console.ReadLine();
                                            break;
                                        }
                                    }
                                }
                                Thread.Sleep(2000);
                                Console.Clear();
                            }

                            Console.Clear();
                        }
                        else if (select2 == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("======================\n      Guess Game\n======================\n");
                            Random random = new Random();
                            int rightNumber = random.Next(0, 51);
                            Hint hint = new Hint(rightNumber);
                            hint.CreateHints();
                            int availableHints = 4;
                            int chances = 8;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("======================\n      Guess Game\n======================\n");
                                Console.WriteLine($"Chances Left : {chances}  |  Hints : {availableHints}\n-------------------------------\n");
                                Console.Write("Guess < -1 For a Hint > : ");
                                if (chances == 0)
                                {
                                    Console.WriteLine($"You Lose The Answer Was {rightNumber}\n\n\n");
                                    Console.WriteLine("< Click Enter To Back >");
                                    string enter = Console.ReadLine();
                                    break;
                                }
                                int guess;
                                while (true)
                                {
                                    try
                                    {
                                        guess = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Invalid Guess");
                                        continue;
                                    }
                                    if (guess < 0 && guess != -1)
                                    {
                                        Console.WriteLine("Bro We Are Start From < Zero >");
                                        continue;
                                    }
                                    else if (guess > 50)
                                    {
                                        Console.WriteLine($"Bro We Are End In < {50} >");
                                        continue;
                                    }
                                    else break;
                                }

                                if (guess == -1)
                                {
                                    if (availableHints != 0)
                                    {
                                        Console.WriteLine($"Hint > {hint.GetHint()}");
                                        availableHints--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You Don't Have Any Hints Left");
                                    }

                                }
                                else
                                {
                                    if (guess == rightNumber)
                                    {
                                        Console.WriteLine($"{guess} Is The Right Answer \n\nYou Win\n\n\n");
                                        Console.WriteLine("< Click Enter To Back >");
                                        string enter = Console.ReadLine();
                                        break;

                                    }
                                    else
                                    {
                                        chances--;
                                        Console.WriteLine("Wrong Answer\n");
                                        if (chances == 0)
                                        {
                                            Console.WriteLine($"You Lose The Answer Was {rightNumber}\n\n\n");
                                            Console.WriteLine("< Click Enter To Back >");
                                            string enter = Console.ReadLine();
                                            break;
                                        }
                                    }
                                }
                                Thread.Sleep(2500);
                                Console.Clear();
                            }

                            Console.Clear();
                        }
                        else
                            break;
                    }






                    Console.Clear();
                }
                //select == 2
                else if(select1 == 2)
                {
                    Console.Clear();

                    Console.WriteLine("======================\n      Guess Game\n======================\n");
                    Console.WriteLine("About :\n--------\n");
                    Console.WriteLine("This Game Is About Guessing a Number And You Have Chances And Hints To Win The Game\n\n");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
                    Console.WriteLine("Levels :\n--------\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("1) Easy Level : ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Number Could be Between 0 And 10\n*] You Will Have ( 3 ) Chances And ( 3 ) Hints\n\n");
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.Write("2) Normal Level : ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Number Could be Between 0 And 25\n*] You Will Have ( 5 ) Chances And ( 3 ) Hints\n\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("3) Hard Level : ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Number Could be Between 0 And 50\n*] You Will Have ( 8 ) Chances And ( 4 ) Hints\n\n");
                    Console.WriteLine("==========================================================================================================\n\n");

                    Console.WriteLine("< Click Enter To Back >");
                    string enter = Console.ReadLine();
                    
                    Console.Clear();
                }
                else
                {
                    break;
                }   
            }            
        }
    }
}
