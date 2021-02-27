namespace ChessLogic
{
    /// <summary>
    /// Ладья
    /// </summary>
    public class Rook : IChessFigure
    {
        public bool IsCorrectStep(Vector vector)
        {
            return vector.From.X == vector.To.X || vector.From.Y == vector.To.Y;
        }
    }
}