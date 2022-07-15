using System;

namespace TicTheTacTheToe // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

public static class TicTacToe
{//GameLogice
    public static bool isPlayerATurn = true;
    public static Board board;
    public static int totalNumOfTurns = 0;

    static void Main()
    { 
        while (true)
        {
            ResetBoard();
            PlayGame();
        }

        void ResetBoard()
        {
            board = new Board();
            totalNumOfTurns = 0;
            //board.ShowBoard();
        }

        void PlayGame()
        {

        }

        static bool CheckForWinner()
        {
            if (HorizontalLine() || VerticalLine() || DiagonalLine())
                return true;
            else return false;

            bool HorizontalLine()
            {

            }
            bool VerticalLine()
            {

            }
            bool DiagonalLine()
            {

            }

            void DisplayTheWinnerNote(bool isPlayerX)
            {
                
            }
           
        }
    }

}

public class Board
{

}

public class Row
{

}