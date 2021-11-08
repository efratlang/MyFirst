using System;
using System.Collections.Generic;
using System.Text;

namespace Ladders_and_ropes
{
    //מחלקת משחק 
    class play
    {
        private Board[,] board;// מטריצה לוח המשחק
        private int kobiya1;//קוביה 1
        private int kobiya2;//קוביה 2
        private player[] players;// 2 השחקנים
        private Point[] snakes;//מערך נחשים
        private Point[] ladder;//מערך סולמות
        private int gold1;
        private int gold2;
        Random r = new Random();
        Board a = null;
        Board b = null;
        int x = 0;
        int y = 0;
        public play(player[] players, int gold1, int gold2, int num1, int num2)
        {
            this.players = players;
            this.gold1 = gold1;
            this.gold2 = gold2;
            snakes = new Point[num1];
            ladder = new Point[num2];
            board = new Board[10, 10];
        }
        //מילוי הלוח בפעם הראשונה 
        public void fullBoard()
        {
            int mone = 100;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i, j] = new Board(mone--, true);

                }
            }
        }
        //השמת הנחשים בצורה רנדומלית שמספרם מוכנס כפרמטר בבנאי 
        public void fullsnakes()
        {
            Console.WriteLine("snakes:");
            int i = 0;
            while (i != snakes.Length  )
            {
                x = r.Next(1, 90);
                y = r.Next(x + 10, 100);




                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (board[j, k].Getnumber() == x)
                        {
                            a = board[j, k];

                        }
                        else

                            if (board[j, k].Getnumber() == y)
                        {
                            b = board[j, k];
                            
                        }

                        else
                        {
                            continue;
                        }
                    }
                }
                if (a.Getstatus() == true && b.Getstatus() == true)
                {
                    snakes[i] = new Point(x, y);
                    Console.WriteLine(snakes[i].Getx() + "=>" + snakes[i].Gety());
                 
                    a.Setstatus(false);
                  
                    b.Setstatus(false);
                    i++;
                }
                else
                    continue;

            }




        }
   
            public void fullsladders()
            {
            Console.WriteLine("ladders:");

             
            int i = 0;
            while (i != ladder.Length)
            {
                x = r.Next(1, 90);
                y = r.Next(x + 10, 100);




                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (board[j, k].Getnumber() == x)
                        {
                            a = board[j, k];

                        }
                        else

                            if (board[j, k].Getnumber() == y)
                        {
                            b = board[j, k];

                        }

                        else
                        {
                            continue;
                        }
                    }
                }
                if (a.Getstatus() == true && b.Getstatus() == true)
                {
                    ladder[i] = new Point(x, y);
                    Console.WriteLine(ladder[i].Getx() + "=>" + ladder[i].Gety());

                    a.Setstatus(false);

                    b.Setstatus(false);
                    i++;
                }
                else
                    continue;

            }
          
        }
        public void playnow()
            {
                int[] count = { 0, 0 };

                int a = 0;
                while (count[0] < 100 && count[1] < 100)
                {
                    Console.WriteLine("round" + " " + ++a);
                    for (int i = 0; i < 2; i++)
                    {
                        int sum = 0;
                        //רנדום של קוביות בכל סיבוב
                        kobiya1 = r.Next(1, 6);
                        kobiya2 = r.Next(1, 6);
                        sum = kobiya1 + kobiya2;
                        count[i] += sum;
                        if (count[i] >= 100)
                        {
                            Console.WriteLine(players[i].Getname() + " " + "rolled" + " " + sum);
                            Console.WriteLine("winner" + " " + players[i].Getname());
                            break;
                        }
                        Console.WriteLine(players[i].Getname() + " " + "rolled" + " " + sum);
                        Console.WriteLine(players[i].Getname() + " " + "is on " + " " + count[i]);
                        for (int j = 0; j < snakes.Length; j++)
                        {
                            if (count[i] == snakes[j].Gety())
                            {
                                count[i] = snakes[j].Getx();
                                Console.Write(players[i].Getname() + " " + "  has landed on a snake");
                                Console.WriteLine("and so he is on  " + count[i]);
                            }
                            else
                                if (count[i] == ladder[j].Getx())
                            {
                                count[i] = ladder[j].Gety();
                                Console.Write(players[i].Getname() + " " + "has landed on a ladder ");
                                Console.WriteLine("and so he is on  " + count[i]);
                            }
                        }
                        if (count[i] == gold1 || count[i] == gold2)
                        {
                            Console.WriteLine(players[i].Getname() + " " + "drop in gold");

                            int temp = count[1];
                            int temp1 = count[0];
                            if (count[0] >= count[1])
                            {
                                if (i == 0)
                                {
                                    count[0] = temp1;
                                    count[1] = temp;
                                }
                                else
                                {
                                    count[1] = temp1;
                                    count[0] = temp;
                                }
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    count[0] = temp;
                                    count[1] = temp1;
                                }
                                else
                                {
                                    count[1] = temp;
                                    count[0] = temp1;
                                }
                            }
                        }
                         
                    }
                }

            }
   

        }
    }
 
