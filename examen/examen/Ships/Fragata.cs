using System;
namespace examen.Ships
{
    public class Fragata:Ship
    {
        public Fragata()
        {
            lifes = 4;
            name = "fragata";
        }
        public static void Move(Board board, int xInitialCoordinate, int xFinalCoordinate, int yInitialCoordinate, int yFinalCoordinate) // las coordenadas son la proa y la popa del barco )
        {
            Console.WriteLine("Cuantos espacios desea mover?(maximo movimientos = 2)"); //estoy suponiendo que el usuario no ingresara datos erroneos para agilizar el codigo
            int numero = Console.Read();
            Console.WriteLine("Hacia adelante -> 0 Hacia atras -> 1");//estoy suponiendo que el usuario no ingresara datos erroneos para agiliza
            int dir = Console.Read();
            while (xInitialCoordinate == xFinalCoordinate && dir == 0 && numero != 0)
            {
                board.matrix[xInitialCoordinate][yInitialCoordinate + numero] = 1;
                board.matrix[xInitialCoordinate][yFinalCoordinate - numero] = 0;

                numero -= 1;
            }
            while (xInitialCoordinate == xFinalCoordinate && dir == 1 && numero != 0)
            {
                board.matrix[xInitialCoordinate][yInitialCoordinate - numero] = 1;
                board.matrix[xInitialCoordinate][yFinalCoordinate + numero] = 0;

                numero -= 1;
            }
            while (yInitialCoordinate == yFinalCoordinate && dir == 0 && numero != 0)
            {
                board.matrix[xInitialCoordinate + numero][yInitialCoordinate + numero] = 1;
                board.matrix[yFinalCoordinate - numero][yInitialCoordinate] = 0;

                numero -= 1;
            }
            while (yInitialCoordinate == yFinalCoordinate && dir == 1 && numero != 0)
            {
                board.matrix[xInitialCoordinate - numero][yInitialCoordinate] = 1;
                board.matrix[yFinalCoordinate + numero][yInitialCoordinate] = 0;

                numero -= 1;
            }
        }

    }
}
