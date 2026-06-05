using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CoreSimulator.Utils
{
    public struct Vector2i
    {
        public Vector2i(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; }
        public int Y { get; }

        public static Vector2i Zero = new Vector2i(0, 0);
        public static Vector2i One = new Vector2i(1, 1);
        public static Vector2i Up = new Vector2i(0, -1);
        public static Vector2i Down = new Vector2i(0, 1);
        public static Vector2i Left = new Vector2i(-1, 0);
        public static Vector2i Right = new Vector2i(1, 0);

        public static Vector2i operator +(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.X + b.X, a.Y + b.Y);
        }

        public static Vector2i operator -(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.X - b.X, a.Y - b.Y);
        }

        public static Vector2i operator *(Vector2i a, int b)
        {
            return new Vector2i(a.X * b, a.Y * b);
        }

        public static Vector2i operator *(int a, Vector2i b)
        {
            return new Vector2i(a * b.X, a * b.Y);
        }

        public static Vector2i operator /(Vector2i a, int b)
        {
            return new Vector2i(a.X / b, a.Y / b);
        }

        public static Vector2i operator /(int a, Vector2i b)
        {
            return new Vector2i(a / b.X, a / b.Y);
        }

        public override String ToString()
        {
            return $"({X}, {Y})";
        }
    }
    
}
