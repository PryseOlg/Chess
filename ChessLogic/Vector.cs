using System;
using System.Drawing;

namespace ChessLogic
{
    public class Vector {
        private Point _from; // приватные поля
        private Point _to; // приватные поля

        public Point From {
            get => _from;
            set => _from = value;
        } //пропертиес
        public Point To
        {
            get => _to;
            set => _to = value;
        } // пропертиес
        
        public Vector(Point from, Point to) {
            this._from = from;
            this._to = to;
        } //конструктор

        public Vector(string from, string to) {
            this._from = GetCoords(from);
            this._to = GetCoords(to);
        }

        public bool Exist()
        {
            return ((_from != Point.Empty) && (_to != Point.Empty));
        }
        private static bool IsLetterCorrect(char letter)
        {
            
            if (!Char.IsLetter(letter))
                return false;

            bool isInLeftBorder = (Char.IsUpper(letter) ? 'A' : 'a' ) <= letter;
            bool isInRightBorder = letter <= (char.IsUpper(letter) ? 'H' : 'h');

            return (isInLeftBorder && isInRightBorder);
        }
        private static bool IsDigitCorrect(char digit)
        {            
            if (!Char.IsDigit(digit))
                return false;

            return (digit >= '1' && digit <= '8');         
        }
        private static Point GetCoords(string coord)
        {
            if (coord.Length != 2)
                return Point.Empty;

            char abscissa = coord[0];
            char ordinate = coord[1];
            if (!IsLetterCorrect(abscissa) || !IsDigitCorrect(ordinate))
                return Point.Empty;
            int x = abscissa - (Char.IsUpper(abscissa) ? 64 : 96);
            int y = ordinate - '0';
            return new Point(x, y);
        }
    }
}