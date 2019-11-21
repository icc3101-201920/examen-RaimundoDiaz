using System;
using System.Collections.Generic;

namespace examen.Ships
{
    public class Radar : Ship
    {
        public Radar()
        {
            lifes = 1;
            name = "radar";
        }

        public static void Move(Board board, int xInitialCoordinate, int xFinalCoordinate, int yInitialCoordinate, int yFinalCoordinate) // las coordenadas son la proa y la popa del barco )
        {
            Console.WriteLine("Cuantos espacios desea mover?(maximo movimientos = 1)"); //estoy suponiendo que el usuario no ingresara datos erroneos para agilizar el codigo
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

        public static void Special(Board board, int xCoordinate, int yCoordinate) // x&y are the center of the 3x3 sector
        {
            List<int> ships = new List<int>();
            if (board.matrix[xCoordinate - 1][yCoordinate - 1] != 0 && board.matrix[xCoordinate - 1][yCoordinate - 1] != 6)
            {
                ships.Add(board.matrix[xCoordinate - 1][yCoordinate - 1]);
            }
            else if (board.matrix[xCoordinate - 1][yCoordinate] != 0 && board.matrix[xCoordinate - 1][yCoordinate - 1] != 6)
            {
                ships.Add(board.matrix[xCoordinate - 1][yCoordinate]);
            }
            else if (board.matrix[xCoordinate - 1][yCoordinate + 1] != 0 && board.matrix[xCoordinate - 1][yCoordinate - 1] != 6)
            {
                ships.Add(board.matrix[xCoordinate - 1][yCoordinate + 1]);
            }
            else if (board.matrix[xCoordinate][yCoordinate - 1] != 0 && board.matrix[xCoordinate - 1][yCoordinate - 1] != 6)
            {
                ships.Add(board.matrix[xCoordinate][yCoordinate - 1]);
            }
            else if (board.matrix[xCoordinate][yCoordinate] != 0 && board.matrix[xCoordinate - 1][yCoordinate - 1] != 6)
            {
                ships.Add(board.matrix[xCoordinate][yCoordinate]);
            }
            else if (board.matrix[xCoordinate][yCoordinate + 1] != 0 && board.matrix[xCoordinate - 1][yCoordinate - 1] != 6)
            {
                ships.Add(board.matrix[xCoordinate][yCoordinate + 1]);
            }
            else if (board.matrix[xCoordinate + 1][yCoordinate - 1] != 0 && board.matrix[xCoordinate - 1][yCoordinate - 1] != 6)
            {
                ships.Add(board.matrix[xCoordinate + 1][yCoordinate - 1]);
            }
            else if (board.matrix[xCoordinate + 1][yCoordinate] != 0 && board.matrix[xCoordinate - 1][yCoordinate - 1] != 6)
            {
                ships.Add(board.matrix[xCoordinate + 1][yCoordinate]);
            }
            else if (board.matrix[xCoordinate + 1][yCoordinate + 1] != 0 && board.matrix[xCoordinate - 1][yCoordinate - 1] != 6)
            {
                ships.Add(board.matrix[xCoordinate + 1][yCoordinate + 1]);
            }

            if (ships.Count != 0)
            {
                // no alcance a agregar que sume una vida al barco
            }
            else
            {
                Console.WriteLine("No ships nearby");
            }
        }
    }
}
