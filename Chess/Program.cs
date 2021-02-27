using System;
using ChessLogic;

namespace Chess
{
    class Program
    {
        static void Main(string[] args) {
            Vector vector;
            string firstcoordinate;
            string secondcoordinate;
            string figure;
            while (true)
            {
                do
                {
                    Console.Write($"Выберите фигуру: [{string.Join(", ", FigureEngine.GetListFigure())}]: ");
                    figure = Console.ReadLine();
                } while (!FigureEngine.ExistFigure(figure));
                    
                do {
                    Console.WriteLine("Введите две координаты");
                    Console.Write($"Введите 1-ую координату:");
                    firstcoordinate = Console.ReadLine();
                    Console.Write($"Введите 2-ую координату:");
                    secondcoordinate = Console.ReadLine();
                    vector = new Vector(firstcoordinate, secondcoordinate);
                }
                while (!vector.Exist());

                if (FigureEngine.IsCorrectStep(figure, vector)) {
                    Console.WriteLine("Верно");
                    break;
                }
                else Console.WriteLine("Некорректный ход");
            }
        }
        
    }

    

    
}
