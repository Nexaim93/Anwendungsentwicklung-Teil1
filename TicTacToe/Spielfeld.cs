using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TicTacToe
{
    class Spielfeld
    {
        private readonly FieldState[,] board;
        private bool currentPlayerID;
        private byte turnCounter;

        public bool GetCurrentPlayer()
        {
            return currentPlayerID;
        }
        public FieldState[,] GetBoard()
        {
            return board;
        }
        public Spielfeld()
        {
            board = new FieldState[3, 3];
            Reset();
        }

        public void Reset()
        {
            Array.Clear(board, 0, board.Length);
            currentPlayerID = DateTime.Now.Millisecond % 2 == 0;
            turnCounter = 0;
        }
        public TurnResult Turn(Point Coordinates)
        {
            if (board[Coordinates.X, Coordinates.Y] == FieldState.0 || board[Coordinates.X, Coordinates.Y] == FieldState.X)
                return TurnResult.Invalid;  // wenn an mitgelieferten koordinaten bereits X oder O steht
            turnCounter++;//      Methodenende und rückgabe von Invalid
            // zugzähler um 1 erhöhen
            // wenn aktueller spieler true
            //      an koordinaten ein X schreiben
            // andernfalls
            //      an koordinaten ein O schreiben
            board[Coordinates.Y, Coordinates.X] = (currentPlayerID ? FieldState.X : FieldState.0); // wenn in einer der spalten 3 gleiche oder in einer der zeilen 3 gleiche oder in einer der beiden diagonalen 3 gleiche
            
            //      Methodenende und rückgabe von Win
            // wenn zuganzahl gleich  9
            //      Methodenende und rückgabe von Tie
            // rückgabe von valid
        }


    }
}
