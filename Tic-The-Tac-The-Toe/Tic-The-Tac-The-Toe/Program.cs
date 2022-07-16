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
            board.ShowBoard();
        }

        void PlayGame()
        {
            while (true)
            {

            }
        }

        static bool CheckForWinner()
        {
            if (HorizontalLine() || VerticalLine() || DiagonalLine())
                return true;
            else return false;

            bool HorizontalLine()
            {
                for (int i = 0; i < 3; i++)
                {
                    bool hasWon = true;
                    bool isValueX = false;


                }
                
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
    public Row[] rows;

    public Board() //Constructors
    {
        rows = new Row[3];
        for (int i =0; i < 3; i++) //Will create the new rows
        {
            rows[i] = new Row();
        }
    }

    public void ShowBoard()
    {
        for(int i = 0; i < rows.Length; i++)
        {
            rows[i].DisplayContents();
        }
    }

    public void ChooseRowThenSpace()
    {
        string input = "";
        int rowNum = 0;

        Console.WriteLine("Choose row 1,2, or 3 (top to bottom):");
        input = Console.ReadLine();

        if(int.TryParse(input, out rowNum)) {
            if (rowNum  < 1 || rowNum > 3)
            {
                Console.WriteLine("Input is Invalid. Please try again.:");
                ChooseRowThenSpace(); //Recursion
                return;
            }
            else
            {
                rows[rowNum - 1].ChooseSpace(TicTacToe.isPlayerATurn); //rowNum-1 -> because array index start at 0
            }
        }
        else
        {
            Console.WriteLine("That's not a valid input, Please try again.:");
            ChooseRowThenSpace();
            return;
        }
    }
}

public class Row
{

}