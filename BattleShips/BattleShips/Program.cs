using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    enum BattleShips { Longboi = 4, Cruiser = 3, ubåd = 2, fiskekutter = 1 }




    class Program
    {
        

        static void Main(string[] args)
        {
            //Defines the board Array
            int[,] player1board = new int[7, 7];

            player1board[0, 1] = 1;
            player1board[0, 2] = 2;
            player1board[0, 3] = 3;
            player1board[0, 4] = 4;
            player1board[0, 5] = 5;
            player1board[0, 6] = 6;

            player1board[1, 0] = 1;
            player1board[2, 0] = 2;
            player1board[3, 0] = 3;
            player1board[4, 0] = 4;
            player1board[5, 0] = 5;
            player1board[6, 0] = 6;

            //This prints the Array to the console
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    Console.Write(player1board[x, y]);
                    Console.Write("|");


                }
                Console.WriteLine();

            }

            //This is a loop where you can place 4 ships of your choice
            for (int shipPP = 0; shipPP < 4; shipPP++)
            {
                Console.WriteLine("Place your battleships. Choose a ship to place");
                Console.WriteLine("1 for boat, 2 for submarine, 3 for cruiser, 4 for longboi");
                


                string shipP1 = Console.ReadLine();

                switch (shipP1)
                {

                    case "1":
                        Console.WriteLine("Where do you want to place your ship?");
                        Console.WriteLine("(x goes downwards, Y goes to the left)");
                        Console.WriteLine("Pick a X coordiante then press enter");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Pick a Y coordinate and press enter");
                        int y = Convert.ToInt32(Console.ReadLine());
                        player1board[x, y] = 1;
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Where do you want to place your ship?");
                        Console.WriteLine("(x goes downwards, Y goes to the left)");
                        Console.WriteLine("Pick a X coordiante then press enter");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Pick a Y coordinate and press enter");
                        y = Convert.ToInt32(Console.ReadLine());
                        player1board[x, y] = 2;
                        player1board[x, y + 1] = 2;
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Where do you want to place your ship?");
                        Console.WriteLine("(x goes downwards, Y goes to the left)");
                        Console.WriteLine("Pick a X coordiante then press enter");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Pick a Y coordinate and press enter");
                        y = Convert.ToInt32(Console.ReadLine());
                        player1board[x, y] = 3;
                        player1board[x, y + 1] = 3;
                        player1board[x, y + 2] = 3;
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("Where do you want to place your ship?");
                        Console.WriteLine("(x goes downwards, Y goes to the left)");
                        Console.WriteLine("Pick a X coordiante then press enter");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Pick a Y coordinate and press enter");
                        y = Convert.ToInt32(Console.ReadLine());
                        player1board[x, y] = 4;
                        player1board[x, y + 1] = 4;
                        player1board[x, y + 2] = 4;
                        player1board[x, y + 3] = 4;
                        Console.Clear();
                        break;

                }

                for (int x = 0; x < 6; x++)
                {
                    for (int y = 0; y < 6; y++)
                    {
                        Console.Write(player1board[x, y]);
                        Console.Write("|");


                    }
                    Console.WriteLine();

                }

            }

            Console.WriteLine("It is now player 2 turn to shoot down your ships :)");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            
            //this is the board player 
            int[,] player2board = new int[7, 7];

            player2board[0, 1] = 1;
            player2board[0, 2] = 2;
            player2board[0, 3] = 3;
            player2board[0, 4] = 4;
            player2board[0, 5] = 5;
            player2board[0, 6] = 6;

            player2board[1, 0] = 1;
            player2board[2, 0] = 2;
            player2board[3, 0] = 3;
            player2board[4, 0] = 4;
            player2board[5, 0] = 5;
            player2board[6, 0] = 6;

            //This code prints the new board to Console
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    Console.Write(player2board[x, y]);
                    Console.Write("|");


                }
                Console.WriteLine();

            }
            //This code allows player two to take 17 shots before the game ends.
            for (int shootPP = 0; shootPP < 17; shootPP++)
            {
                Console.WriteLine("Choose a tile to shoot");
                Console.WriteLine("1 is a shot hit , 2 is a missed shot");
                Console.WriteLine("Downward (x) first. Finish with enter");
                int xs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("To the left (Y). Finish with enter");
                int ys = Convert.ToInt32(Console.ReadLine());

                if (player1board[xs, ys] != 0)
                {
                    Console.WriteLine("You hit a target!");
                    player1board[xs, ys] = 0;
                    player2board[xs, ys] = 1;
                }
                else
                {
                    Console.WriteLine("You missed");
                    player2board[xs, ys] = 2;
                }

                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Console.Clear();

                for (int x = 0; x < 6; x++)
                {
                    for (int y = 0; y < 6; y++)
                    {
                        Console.Write(player2board[x, y]);
                        Console.Write("|");


                    }
                    Console.WriteLine();

                }

            }

            Console.Clear();

            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    Console.Write(player1board[x, y]);
                    Console.Write("|");


                }
                Console.WriteLine();

            }

            Console.WriteLine("If you only see zeros on this board player 2 has won, otherwise player 1 wins :)");


            Console.WriteLine("End of Game");
            
            Console.ReadKey();


        }


            
        
            

         

            

            
        
    }
}
