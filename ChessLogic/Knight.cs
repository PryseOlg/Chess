using System;

namespace ChessLogic
{
    public class Knight : IChessFigure {
        public bool IsCorrectStep(Vector vector)
        {
            return (vector.From.X != vector.To.X) && (vector.From.Y != vector.To.Y)
                                                  && (((Math.Abs(vector.From.X - vector.To.X)) + Math.Abs(vector.From.Y - vector.To.Y)) == 3);
        }
    }
}