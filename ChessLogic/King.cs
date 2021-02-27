using System;

namespace ChessLogic
{
    /// <summary>
    /// Король
    /// </summary>
    public class King : IChessFigure
    {
        public bool IsCorrectStep(Vector vector)
        {
            return (Math.Abs(vector.From.X - vector.To.X) == 1 && vector.From.Y - vector.To.Y == 0) 
                || (Math.Abs(vector.From.Y - vector.To.Y) == 1 && vector.From.X - vector.To.X == 0);
        }
    }
}