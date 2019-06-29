using System; 

namespace LabOne
{
    class Position 
    {
        public int X; 
        public int Y; 

        public Position(int x, int y)
        {
            X = x; 
            Y = y; 
        }

        public double Length 
        {
            get
            {
                return Math.Round(Math.Sqrt((X*X)+(Y*Y)), 2);
            }
        }

        public bool Equals(Position p)
        {
            if(p.X == X && p.Y == Y)
            {
                return true;
            } else 
            {
                return false; 
            }
        }
        public Position Clone()
        {
            return new Position(X, Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public static bool operator >(Position p1, Position p2)
        {
            if(p1.Length != p2.Length)
            {
                if(p1.Length > p2.Length)
                {
                    return true;
                } else 
                {
                    return false; 
                }
            } else 
            {
                if(p1.X > p2.X)
                {
                    return true; 
                } else 
                {
                    return false;
                }
            }
        }
        public static bool operator <(Position p1, Position p2)
        {
           if(p1.Length != p2.Length)
            {
                if(p1.Length < p2.Length)
                {
                    return true;
                } else 
                {
                    return false; 
                }
            } else 
            {
                if(p1.X < p2.X)
                {
                    return true; 
                } else 
                {
                    return false;
                }
            }
        }
        public static Position operator +(Position p1, Position p2)
        {
            return new Position(p1.X + p2.X, p1.Y+p2.Y);
        }
        public static Position operator -(Position p1, Position p2)
        {
            return new Position(p1.X-p2.X, p1.Y-p2.Y);
        }
        public static double operator %(Position p1, Position p2)
        {
            return Math.Round(Math.Sqrt(((p1.X-p2.X)*(p1.X-p2.X))+((p1.Y-p2.Y)*(p1.Y-p2.Y))), 2);
        }
    }
}