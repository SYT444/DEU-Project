using System;

class Program
{
    //function for controll area ( is it free )
    static bool AreaControl(string[][] field, int wallx, int wally, int wallLength, int emptySpace, int direction)
    {
        
        // controll for vertical walls
        if (direction == 1)
        {
            for (int i = wallx - 1; i <= wallx + wallLength + emptySpace; i++)
            {
                for (int j = wally - 1; j <= wally + 1; j++)
                {
                    if (i >= 0 && i < 23 && j >= 0 && j < 53)
                    {
                        if (field[i][j] == "#")
                        {
                            return false; // If a wall is detected in the neighborhood, the area is not free
                        }
                    }
                }
            }
            return true;
        }

        // controll for horizontal walls
        else
        {
            for (int i = wallx - 1; i <= wallx + 1; i++)
            {
                for (int j = wally - 1; j <= wally + wallLength + emptySpace; j++)
                {
                    if (i >= 0 && i < 23 && j >= 0 && j < 53)
                    {
                        if (field[i][j] == "#")
                        {
                            return false; // If a wall is detected in the neighborhood, the area is not free
                        }
                    }
                }
            }
            return true;
        }

    }
    // for moving numbers 
    static bool numMove(string[][] field ,int direction, int cursorx , int cursory)
    {
        
        switch (direction)
        {
            //move up
            case 0:
                if (field[cursory - 3][cursorx] == "0" || field[cursory - 3][cursorx] == "1" || field[cursory - 3][cursorx] == "2" || field[cursory - 3][cursorx] == "3" || field[cursory - 3][cursorx] == "4" || field[cursory - 3][cursorx] == "5" || field[cursory - 3][cursorx] == "6" || field[cursory - 3][cursorx] == "7" || field[cursory - 3][cursorx] == "8" || field[cursory - 3][cursorx] == "9")
                {

                    if (numMove(field, direction, cursorx, cursory - 1))
                    {
                        field[cursory - 3][cursorx] = field[cursory - 2][cursorx];
                        field[cursory - 2][cursorx] = " ";

                        return true;
                    }
                    return false;
                }
                else if (field[cursory - 3][cursorx] == "#")
                {

                    return false;
                }
                else
                {
                    field[cursory - 3][cursorx] = field[cursory - 2][cursorx];
                    field[cursory - 2][cursorx] = " ";
                    return true;

                }
            // move right   
            case 1:
                if (field[cursory - 2][cursorx + 1] == "0" || field[cursory - 2][cursorx + 1] == "1" || field[cursory - 2][cursorx + 1] == "2" || field[cursory - 2][cursorx + 1] == "3" || field[cursory - 2][cursorx + 1] == "4" || field[cursory - 2][cursorx + 1] == "5" || field[cursory - 2][cursorx + 1] == "6" || field[cursory - 2][cursorx + 1] == "7" || field[cursory - 2][cursorx + 1] == "8" || field[cursory - 2][cursorx + 1] == "9")
                {

                    if (numMove(field, direction, cursorx + 1, cursory))
                    {


                        field[cursory - 2][cursorx + 1] = field[cursory - 2][cursorx];
                        field[cursory - 2][cursorx] = " ";

                        return true;


                    }

                    return false;
                }
                else if (field[cursory - 2][cursorx + 1] == "#")
                {

                    field[cursory - 2][cursorx] = " ";
                    //[cursory - 2][cursorx] = field[cursory - 2][cursorx-1];
                    
                    return false;
                }
                else
                {
                    field[cursory - 2][cursorx + 1] = field[cursory - 2][cursorx];
                    field[cursory - 2][cursorx] = " ";
                    return true;

                }
            // move down
            case 2:
                if (field[cursory - 1][cursorx] == "0" || field[cursory - 1][cursorx] == "1" || field[cursory - 1][cursorx] == "2" || field[cursory - 1][cursorx] == "3" || field[cursory - 1][cursorx] == "4" || field[cursory - 1][cursorx] == "5" || field[cursory - 1][cursorx] == "6" || field[cursory - 1][cursorx] == "7" || field[cursory - 1][cursorx] == "8" || field[cursory - 1][cursorx] == "9")
                {

                    if (numMove(field, direction, cursorx, cursory + 1))
                    {
                        field[cursory - 1][cursorx] = field[cursory - 2][cursorx];
                        field[cursory - 2][cursorx] = " ";

                        return true;
                    }
                    return false;
                }
                else if (field[cursory - 1][cursorx] == "#")
                {
                    return false;
                }
                else
                {
                    field[cursory - 1][cursorx] = field[cursory - 2][cursorx];
                    field[cursory - 2][cursorx] = " ";
                    return true;

                }
                

            //move left
            case 3:
                if (field[cursory - 2][cursorx - 1] == "0" || field[cursory - 2][cursorx - 1] == "1" || field[cursory - 2][cursorx - 1] == "2" || field[cursory - 2][cursorx - 1] == "3" || field[cursory - 2][cursorx - 1] == "4" || field[cursory - 2][cursorx - 1] == "5" || field[cursory - 2][cursorx - 1] == "6" || field[cursory - 2][cursorx - 1] == "7" || field[cursory - 2][cursorx - 1] == "8" || field[cursory - 2][cursorx - 1] == "9")
                {

                    if (numMove(field, direction, cursorx - 1, cursory))
                    {
                        field[cursory - 2][cursorx - 1] = field[cursory - 2][cursorx];
                        field[cursory - 2][cursorx] = " ";

                        return true;
                    }
                    return false;
                }
                else if (field[cursory - 2][cursorx - 1] == "#")
                {
                    return false;
                }
                else
                {
                    field[cursory - 2][cursorx - 1] = field[cursory - 2][cursorx];
                    field[cursory - 2][cursorx] = " ";
                    return true;

                }
                
                
           
                


        }
        return false;
        
      
    }
    
    static void Main()
    {

        // ASCII art for the game's name in a loading screen style
        Console.WriteLine(@"
        ██████╗░██╗░░░██╗██████╗░███████╗███╗░░░███╗███████╗██████╗░
        ██╔══██╗██║░░░██║██╔══██╗██╔════╝████╗░████║██╔════╝██╔══██╗
        ██████╔╝██║░░░██║██║░░██║█████╗░░██╔████╔██║█████╗░░██████╔╝
        ██╔══██╗██║░░░██║██║░░██║██╔══╝░░██║╚██╔╝██║██╔══╝░░██╔══██╗
        ██║░░██║╚██████╔╝██████╔╝███████╗██║░╚═╝░██║███████╗██║░░██║
        ╚═╝░░╚═╝░╚═════╝░╚═════╝░╚══════╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");

        Thread.Sleep(3000); // Wait for 3 seconds to simulate a loading screen

        Console.Clear(); // Clear the console after loading screen

        // Your game logic would start here after the loading screen
        Console.WriteLine("Welcome to CountDown!");
        // Add the rest of your game's functionality or scenes here


        string[][] field = new string[23][];

        // Initializing each inner array with 53 elements
        for (int i = 0; i < 23; i++)
        {
            field[i] = new string[53];
        }

        for (int i = 0; i < 53; i++)
        {
            field[0][i] = "#";
            field[22][i] = "#";
        }

        for (int i = 1; i < 22; i++)
        {
            field[i][0] = "#";
            field[i][52] = "#";

            for (int j = 1; j < 52; j++)
            {
                field[i][j] = " ";
                field[i][j] = " ";
            }
        }

        Random random = new Random();

        
        int wall11x = 0;
        int wall11y = 0;
        // direction of wall 0 = horizontall , 1 = vertical
        int direction = 2;

        // creating 3x 11 unit wall
        for (int z = 0; z < 3; z++)
        {
           
            direction = random.Next(0, 2);
            do
            {
                if (direction == 1)
                {
                    wall11x = random.Next(2, 11);
                    wall11y = random.Next(2, 51);
                }
                else if (direction == 0)
                {
                    wall11x = random.Next(2, 21);
                    wall11y = random.Next(2, 41);
                }


              //control is area free
            } while (!AreaControl(field, wall11x, wall11y, 11, 1, direction));
          

            
            for (int i = 0; i < 11; i++)
            {
                //vertical walls
                if (direction == 1)
                {
                    field[wall11x + i][wall11y] = "#";         
                }

                //horizontall walls
                else if (direction == 0)
                {
                    field[wall11x][wall11y + i] = "#";
                }
            }    
        }

        // creating 5x 7 unit wall
        int wall7x = 0;
        int wall7y = 0;
        for (int z = 0; z < 5; z++)
        {
            direction = random.Next(0, 2);
            do
            {
                if (direction == 1)
                {
                    wall11x = random.Next(2, 15);
                    wall11y = random.Next(2, 51);
                }
                else if (direction == 0)
                {
                    wall11x = random.Next(2, 21);
                    wall11y = random.Next(2, 45);
                }
                //control is area free
            } while (!AreaControl(field, wall11x, wall11y, 7, 1, direction));

            for (int i = 0; i < 7; i++)
            {
                //vertical walls
                if (direction == 1)
                {
                    field[wall11x + i][wall11y] = "#";
                }

                //horizontall walls
                else if (direction == 0)
                {
                    field[wall11x][wall11y + i] = "#";
                }
            }
        }


        // creating 20x 3 unit wall
        int wall3x = 0;
        int wall3y = 0;
        for (int z = 0; z < 20; z++)
        {
            direction = random.Next(0, 2);
            do
            {
                if (direction == 1)
                {
                    wall11x = random.Next(2, 19);
                    wall11y = random.Next(2, 51);
                }
                else if (direction == 0)
                {
                    wall11x = random.Next(2, 21);
                    wall11y = random.Next(2, 49);
                }
                //control is area free
            } while (!AreaControl(field, wall11x, wall11y, 3, 1, direction));

            for (int i = 0; i < 3; i++)
            {
                //vertical walls
                if (direction == 1)
                {
                    field[wall11x + i][wall11y] = "#";
                }

                //horizontall walls
                else if (direction == 0)
                {
                    field[wall11x][wall11y + i] = "#";
                }
            }
        }










        //70 random numbers
        int nx; int ny;
        for (int i = 0; i < 70; i++)
        {
            do
            {
                ny = random.Next(1, 22); nx = random.Next(1, 52);
            } while (!(field[ny][nx] == " "));

            field[ny][nx] = Convert.ToString(random.Next(0,10));

        }




        


        // TIME
        int time = 0;
        int sleepCounter = 0;
        int counter15s = 0;


        // player movement
        int cursorx = 1, cursory = 3;   // position of cursor
        ConsoleKeyInfo cki;               // required for readkey

        while (true)
        {
            


            if (Console.KeyAvailable)
            {       // true: there is a key in keyboard buffer
                cki = Console.ReadKey(true);       // true: do not write character 

                // PLAYER MOVE RIGHT
                if (cki.Key == ConsoleKey.RightArrow && cursorx < 51)
                {   // key and boundary control
                    if (field[cursory - 2][cursorx + 1] == " ")
                    {
                        Console.SetCursorPosition(cursorx, cursory);           // delete X (old position)
                        Console.WriteLine(" ");
                        cursorx++;
                    }
                    
                    else if ((field[cursory - 2][cursorx + 1] == "1" || field[cursory - 2][cursorx + 1] == "2" || field[cursory - 2][cursorx + 1] == "3" || field[cursory - 2][cursorx + 1] == "4" || field[cursory - 2][cursorx + 1] == "5" || field[cursory - 2][cursorx + 1] == "6" || field[cursory - 2][cursorx + 1] == "7" || field[cursory - 2][cursorx + 1] == "8" || field[cursory - 2][cursorx + 1] == "9") && numMove(field,1,cursorx,cursory))
                    {
                        Console.SetCursorPosition(cursorx, cursory);           // delete X (old position)
                        Console.WriteLine(" ");
                        cursorx++;
                    }

                }
                // PLAYER MOVE LEFT
                if (cki.Key == ConsoleKey.LeftArrow && cursorx > 1)
                {
                    if (field[cursory - 2][cursorx - 1] == " ")
                    {
                        Console.SetCursorPosition(cursorx, cursory);           // delete X (old position)
                        Console.WriteLine(" ");
                        cursorx--;
                    }
                    else if ((field[cursory - 2][cursorx - 1] == "1" || field[cursory - 2][cursorx - 1] == "2" || field[cursory - 2][cursorx - 1] == "3" || field[cursory - 2][cursorx - 1] == "4" || field[cursory - 2][cursorx - 1] == "5" || field[cursory - 2][cursorx - 1] == "6" || field[cursory - 2][cursorx - 1] == "7" || field[cursory - 2][cursorx - 1] == "8" || field[cursory - 2][cursorx - 1] == "9") && numMove(field,3,cursorx,cursory))
                    {
                        Console.SetCursorPosition(cursorx, cursory);           // delete X (old position)
                        Console.WriteLine(" ");
                        cursorx--;
                    }
                }
                // PLAYER MOVE UP
                if (cki.Key == ConsoleKey.UpArrow && cursory > 3)
                {
                    if (field[cursory - 3][cursorx] == " ")
                    {
                        Console.SetCursorPosition(cursorx, cursory);           // delete X (old position)
                        Console.WriteLine(" ");
                        cursory--;
                    }
                    else if ((field[cursory - 3][cursorx] == "1" || field[cursory - 3][cursorx] == "2" || field[cursory - 3][cursorx] == "3" || field[cursory - 3][cursorx] == "4" || field[cursory - 3][cursorx] == "5" || field[cursory - 3][cursorx ] == "6" || field[cursory - 3][cursorx ] == "7" || field[cursory - 3][cursorx ] == "8" || field[cursory - 3][cursorx ] == "9") && numMove(field, 0, cursorx, cursory))
                    {
                        Console.SetCursorPosition(cursorx, cursory);           // delete X (old position)
                        Console.WriteLine(" ");
                        cursory--;
                    }
                }
                // PLAYER MOVE DOWN
                if (cki.Key == ConsoleKey.DownArrow && cursory < 23)
                {
                    if (field[cursory - 1][cursorx] == " ")
                    {
                        Console.SetCursorPosition(cursorx, cursory);           // delete X (old position)
                        Console.WriteLine(" ");
                        cursory++;
                    }
                    else if ((field[cursory - 1][cursorx] == "1" || field[cursory - 1][cursorx] == "2" || field[cursory - 1][cursorx] == "3" || field[cursory - 1][cursorx] == "4" || field[cursory - 1][cursorx] == "5" || field[cursory - 1][cursorx] == "6" || field[cursory - 1][cursorx] == "7" || field[cursory - 1][cursorx] == "8" || field[cursory - 1][cursorx] == "9") && numMove(field, 2, cursorx, cursory))
                    {
                        Console.SetCursorPosition(cursorx, cursory);           // delete X (old position)
                        Console.WriteLine(" ");
                        cursory++;
                    }
                }
                                
                if (cki.Key == ConsoleKey.Escape) break;
            }






            Console.Clear();
            //Console.SetCursorPosition(0, 0);

            //Accessing and printing elements of the array of arrays
            Console.Write($" Time  :   {time}");
            Console.WriteLine($"      Life  :    5       Score :    0");
            Console.WriteLine();

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }
            



            // TIMERS
            sleepCounter++;
            Console.WriteLine($"50ms has passed {sleepCounter} times");

            if (sleepCounter%20==0)
            {
                time++;
            }


            // -1 every 15 seconds
            int tempValue;
            
            if (sleepCounter%300==0)
            {
                counter15s++;
                for (int i = 1; i < 22; i++)
                {
                    for (int j = 1; j < 52; j++)
                    {
                        if ( field[i][j] == "2" || field[i][j] == "3" || field[i][j] == "4" || field[i][j] == "5" || field[i][j] == "6" || field[i][j] == "7" || field[i][j] == "8" || field[i][j] == "9" )
                        {
                            tempValue = Convert.ToInt16( field[i][j] );
                            tempValue--;
                            field[i][j] = Convert.ToString(tempValue);
                        }
                        else if (field[i][j] == "1")
                        {
                            int three = random.Next(1, 101);
                            if (three==1 || three ==2 || three ==3)
                            {
                                tempValue = Convert.ToInt16(field[i][j]);
                                tempValue--;
                                field[i][j] = Convert.ToString(tempValue);
                            }
                        }
                    }
                }
            }

            // ZERO MOVES
            int dir = 0;
            if (sleepCounter % 20 == 0)
            {
                for (int i = 1; i < 22; i++)
                {
                    for (int j = 1; j < 52; j++)
                    {                     
                        if (field[i][j] == "0")
                        {  
                            
                            dir = random.Next(0, 4);
                            switch (dir)
                            {
                                case 0:
                                    if (field[i - 1][j] == " ")
                                    {
                                        field[i - 1][j] = field[i][j];
                                        field[i][j] = " ";
                                        break;
                                    }
                                break;
                                case 1:
                                    if (field[i][j + 1] == " ")
                                    {
                                        field[i][j + 1] = field[i][j];
                                        field[i][j] = " ";
                                        break;
                                    }
                                break;
                                case 2:
                                    if (field[i + 1][j] == " ")
                                    {
                                        field[i + 1][j] = field[i][j];
                                        field[i][j] = " ";
                                        break;
                                    }
                                break;
                                case 3:
                                    if (field[i][j - 1] == " ")
                                    {
                                        field[i][j - 1] = field[i][j];
                                        field[i][j] = " ";
                                        break;
                                    }
                                    break;
                            }
                            
                            
                        }
                    }
                }
            }



            Console.WriteLine($"15s has passed {counter15s} times");


            



            Console.SetCursorPosition(cursorx, cursory);    // refresh X (current position)
            Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("X");

            




            Thread.Sleep(50);     // sleep 50 ms
            

        }
    }

}

