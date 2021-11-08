using System;
using System.Collections.Generic;
using System.Text;

namespace Ladders_and_ropes
{
    class Board
    {
        private int number;
       private bool status;
        public Board(int number, bool status)
        {
            this.number = number;
            this.status = status;
        }
        public void Setnumber(int number)
        {
            this.number= number;
        }
        public int Getnumber()
        {
            return this.number;
        }
        public void Setstatus(bool status )
        {
            this.status = status;
        }
        public bool Getstatus()
        {
            return this.status;
        }
    }
}
