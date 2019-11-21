using System;
using System.Collections.Generic;

namespace examen
{
    public class Board
    {
        public List<int> fila1;
        public List<int> fila2;
        public List<int> fila3;
        public List<int> fila4;
        public List<int> fila5;
        public List<int> fila6;
        public List<int> fila7;
        public List<int> fila8;
        public List<int> fila9;
        public List<int> fila10;
        public List<List<int>> matrix;

        //para diferenciar los barcos:
        //1 es portaaviones
        //2 es fragata
        //3 es submarino
        //4 es reparador
        //5 es radar
        //6 es submarino sumergido

        public Board()
        {
            fila1 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            fila2 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            fila3 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            fila4 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            fila5 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            fila6 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            fila7 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            fila8 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            fila9 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            fila10 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            matrix = new List<List<int>>() { fila1, fila2, fila3, fila4, fila5, fila6, fila7, fila8, fila9, fila10 };
        }
        
    }
}
