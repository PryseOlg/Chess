using System.Collections.Generic;

namespace ChessLogic
{
    /// <summary>
    /// Возможные действия над фигурой
    /// </summary>
    public class FigureEngine
    {
       /// <summary>
       /// Хранит соответствие между текстовым названием и классом фигуры
       /// </summary>
        private static Dictionary<string, IChessFigure> _figures = new Dictionary<string, IChessFigure>() {
            {"Knight", new Knight()},
            {"Pawn", new Pawn()},
            {"Rook", new Rook()},
            {"Bishop", new Bishop()},
            {"King", new King()},
            {"Queen", new Queen()}
        };

        /// <summary>
        /// Выводит список возмржных фигур
        /// </summary>
        /// <returns>Список</returns>
        public static List<string> GetListFigure() {
            List<string> listFigure = new List<string>();
            foreach (string key in _figures.Keys)
            {
                listFigure.Add(key);
            }
            return listFigure;
        }

        /// <summary> 
        /// Проверяет существование фигуры
        /// </summary>
        /// <param name="figure">Название фигуры</param>
        /// <returns>True, если фигура существует, иначе false</returns>
        public static bool ExistFigure(string figure) 
        {
            return (_figures.ContainsKey(figure));
        }
        
        /// <summary>
        /// Проверяет правильность хода любой фигуры
        /// </summary>
        /// <param name="figure">Название фигуры</param>
        /// <param name="vector">Координаты фигуры(от, до)</param>
        /// <returns>true, если правильно, иначе False</returns>
        public static bool IsCorrectStep(string figure, Vector vector) { 
            return ((ExistFigure(figure)) && _figures[figure].IsCorrectStep(vector));
        }
    }
}