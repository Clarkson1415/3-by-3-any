using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_by_3_any
{
    class Program
    {
        static void Main(string[] args)
        {
            //game board is (1,1) bottom left start, ends at (2,2)
            int x = 0;
            int y = 0;
            int r = 0;


            Random diceRoll = new Random(); //random method calle diceRoll
            int i = 0;
            for (; ; )
            {
                if (i < 1000000) //run the game until I've won 5 times.
                {

                    //!Console.WriteLine("{0},{1}", x, y); //where u at



                    if (x == 2 && y == 2) //won
                    {
                        Console.WriteLine("{0}", r); //!Rolls
                        x = 0;
                        y = 0;
                        r = 0;
                        i++; //increase counter by 1

                    }
                    //ladders
                    else if (x == 2 && y == 0)
                    {
                        x = 0;
                        y = 1;
                        //!Console.WriteLine("up ladder to 2,0");
                    }
                    //snake
                    else if (x == 0 && y == 2)
                    {
                        //! Console.WriteLine("snake to 0,2");
                        x = 1;
                        y = 1;
                    }

                    else
                    {
                        int Roll = diceRoll.Next(1, 4); //roll 1,2 or 3.
                        //!Console.WriteLine("rolled {0}", Roll);
                        r++;
                        //!Console.WriteLine("Times Rolled: {0}", r); //times rolled

                        if (y % 2 == 0 && y < 2) //if line is even and not the last line
                        {
                            if (x + Roll < 3)
                            {
                                x += Roll;
                            }
                            else if (x + Roll == 3)
                            {
                                x = 2;
                                if (y < 2)
                                {
                                    y++;
                                }
                            }
                            else if (x + Roll == 4)
                            {
                                x = 1;
                                if (y < 2) //if not the last row
                                {
                                    y++;
                                }
                            }
                            else if (x + Roll == 5)
                            {
                                x = 0;
                                if (y < 2) //only adds y if in last row
                                {
                                    y++;
                                }
                            }

                        }
                        else if (y == 2)//for the last line.
                        {
                            if (x + Roll <= 2)
                            {
                                x += Roll;
                            }
                            else if (x + Roll > 2)
                            {
                                x = 2; //so you land on 2 even if you roll more
                            }
                        }


                        else if (y % 2 != 0 && y <= 2)
                        {
                            //!Console.WriteLine("y is odd");
                            if (x - Roll >= 0)
                            {
                                x -= Roll;
                            }
                            else if (x - Roll == -1)
                            {
                                x = 0;
                                if (y < 2)
                                {
                                    y++;
                                }
                            }
                            else if (x - Roll == -2)
                            {
                                x = 1;
                                if (y < 2)
                                {
                                    y++;
                                }
                            }
                            else if (x - Roll == -3)
                            {
                                x = 2;
                                if (y < 2)
                                {
                                    y++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
