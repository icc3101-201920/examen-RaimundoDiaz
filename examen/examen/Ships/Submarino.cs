using System;
namespace examen.Ships
{
    public class Submarino:Ship
    {
        public Submarino()
        {
            lifes = 3;
            name = "submarino";
        }

        public static void Move(Board board, int xInitialCoordinate, int xFinalCoordinate, int yInitialCoordinate, int yFinalCoordinate) // las coordenadas son la proa y la popa del barco )
        {
            Console.WriteLine("Cuantos espacios desea mover?(maximo movimientos = 3)"); //estoy suponiendo que el usuario no ingresara datos erroneos para agilizar el codigo
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

        public static void Special(Board board, int xInitialCoordinate, int xFinalCoordinate, int yInitialCoordinate, int yFinalCoordinate ) // las coordenadas son la proa y la popa del barco
        {
            if (xInitialCoordinate == xFinalCoordinate)
            {
                board.matrix[xInitialCoordinate][yInitialCoordinate] = 6;    //luego al inicio de cada turno se busca si algun casillero es 6, y se cambia a 3
                board.matrix[xInitialCoordinate][yInitialCoordinate+1] = 6;
                board.matrix[xInitialCoordinate][yInitialCoordinate+1] = 6;
            }
            else
            {
                board.matrix[xInitialCoordinate][yInitialCoordinate] = 6;
                board.matrix[xInitialCoordinate+1][yInitialCoordinate] = 6;
                board.matrix[xInitialCoordinate+1][yInitialCoordinate] = 6;
            }
        }
    }
}
