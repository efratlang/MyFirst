using System;

namespace Ladders_and_ropes
{
    class Program
    {
        static void Main(string[] args)
        {
            player p = new player("Ron");
            player p1 = new player("Dan");
            player[] parr = { p, p1 };
            play play = new play(parr,36,53,5,5);
           
            play.fullBoard();
             play.fullsladders();
            play.fullsnakes();
            play.playnow();
          
            
        }
    }
}
