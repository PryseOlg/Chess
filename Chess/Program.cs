using System;
using System.Drawing;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Point[] MassivePoints;
                do
                {
                    Console.WriteLine("Введите две координаты");
                    //string coordinate = Console.ReadLine();
                    MassivePoints = GetMassivePoints();
                }
                while (MassivePoints == null);

                if (GetCheckStepKnight(MassivePoints[0], MassivePoints[1]))
                {
                    Console.WriteLine("You are breathtaking");
                    break;
                }
                else Console.WriteLine("You are not breathtaking");

            }
        }
        static Point GetCoords(string Coord)
        {
            if (Coord.Length != 2)
                return Point.Empty;

            char FirstCoord = Coord[0];
            char SecondCoord = Coord[1];
            if (!IsLetterCorrect(FirstCoord) || !IsDigitCorrect(SecondCoord))
                return Point.Empty;
            int X = FirstCoord - (Char.IsUpper(FirstCoord) ? 64 : 96);
            int Y = SecondCoord - '0';
            return new Point(X, Y);

        }

        static bool IsLetterCorrect(char Letter)
        {
            
            if (!Char.IsLetter(Letter))
                return false;

            bool IsInLeftBorder = (Char.IsUpper(Letter) ? 'A' : 'a' ) <= Letter;
            bool IsInRightBorder = Letter <= (char.IsUpper(Letter) ? 'H' : 'h');

            return (IsInLeftBorder && IsInRightBorder);
        }

        static bool IsDigitCorrect(char Digit)
        {            
            if (!Char.IsDigit(Digit))
                return false;

            return (Digit >= '1' && Digit <= '8');         
        }

        static Point[] GetMassivePoints()
        {
            Point[] points = new Point[2];
            for (int i = 0; i < points.Length; i++)
            {
                Console.Write($"Введите {i+1}-ую координату: ");
                points[i] = GetCoords(Console.ReadLine());
                if (points[i] == Point.Empty)
                    return null;             
            }
            return points;
        } //

        static bool GetCheckStepKnight(Point PointFrom, Point PointTo)
        {
            return (PointFrom.X != PointTo.X) && (PointFrom.Y != PointTo.Y) 
                && (((Math.Abs(PointFrom.X - PointTo.X)) + Math.Abs(PointFrom.Y - PointTo.Y)) == 3);

               


        }
    }
}
