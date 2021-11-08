using System;
using System.Collections.Generic;
using System.Text;

namespace Ladders_and_ropes
{
    //מחלת נקודה מציין את מיקום הסולמות והחבלים 
    class Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Setx(int x)
        {
            this.x = x;
        }
        public int Getx()
        {
            return this.x;
        }
        public void Sety(int y)
        {
            this.y = y;
        }
        public int Gety()
        {
            return this.y;
        }
    }
}
