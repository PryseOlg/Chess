namespace ChessLogic
{
    public class Pawn : IChessFigure {
        public bool IsCorrectStep(Vector vector)
        {
            return vector.From.X - vector.To.X == 0 && (vector.To.Y - vector.From.Y == 1 
                                                    || vector.To.Y - vector.From.Y == 2); 
        }
    }
}