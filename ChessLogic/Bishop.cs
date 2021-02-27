using System;

namespace ChessLogic
{
    /// <summary>
    /// Слон
    /// </summary>
    public class Bishop : IChessFigure
    {
        public bool IsCorrectStep(Vector vector)
        {
            return Math.Abs(vector.From.X - vector.To.X) == Math.Abs(vector.From.Y - vector.To.Y);
        }
    }
}