using System;
using System.Collections.Generic;
using System.Text;

namespace Ladders_and_ropes
{
    //מחלקת שחקן
    class player
    {
        private string name;
        public player(string name)
        {
            this.name = name;    
        }
       public void Setname(string name)
        {
            this.name = name;
        }
        public string Getname()
        {
            return this.name;
        }
    }
}
