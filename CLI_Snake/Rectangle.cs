﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Snake
{
    public class Rectangle
    {
        public Point Position { get; set; }
        public Point Sizes { get; set; }

        public Rectangle(Point position, Point sizes)
        {
            Position = position;
            Sizes = sizes;
        }

        public Rectangle(int x, int y, int lenX, int lenY)
        {
            Position = new Point(x, y);
            Sizes = new Point(lenX, lenY);
        }

        public bool IsIntersect(Point point)
        {
            return point.X >= Position.X 
                   && point.X < Position.X + Sizes.X 
                   && point.Y >= Position.Y 
                   && point.Y < Position.Y + Sizes.Y;
        }
    }
}
