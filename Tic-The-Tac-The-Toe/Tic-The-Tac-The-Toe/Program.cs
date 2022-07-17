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
                board.ChooseRowThenSpace();
                board.ShowBoard();

                if (CheckForWinner())
                {
                    break;
                }
                
                isPlayerATurn = !isPlayerATurn; // Change Turn between X and O player
                totalNumOfTurns++;
               
                if (totalNumOfTurns >= 9) // 3x3 board space
                {
                    Console.WriteLine("No winner! Try again.");
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to start the game!");
            Console.ReadKey(true);
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
    public int[] boardSpaces; // In the space: 0=blank, 1=X, and 2=0

    public void ChooseSpace(bool isValueX)
    {
        string input = "";
        int boardSpaceNum = 0;

        Console.WriteLine("Type a board space number from left to right (1,2, or 3):");

        input = Console.ReadLine();
        if (int.TryParse(input, out boardSpaceNum))
        {
            if (boardSpaceNum < 1 || boardSpaceNum > 3)
            {
                Console.WriteLine("That number is invalid. Try again.:");
                ChooseSpace(isValueX); //Recursion
                return;
            }

            if (boardSpaces[boardSpaceNum - 1] != 0) //Checks if space on board is taken
            {
                Console.WriteLine("That board space is already take. Try another one.:");
                TicTacToe.board.ChooseRowThenSpace(); //This is the reason for a static member in the TicTacToe method
                return;
            }

            if (isValueX)
            {
                boardSpaces[boardSpaceNum - 1] = 1; //Player with X
            }
            else
            {
                boardSpaces[boardSpaceNum - 1] = 2; //Player with O
            }
        }
        else
        {
            Console.WriteLine("Tht was a invalid input for board space. Try again.:");
            ChooseSpace(isValueX); //Recursion
            return;
        }
    }

    public void DisplayContents()
    {
        string lineToShow = "";
        for(int i = 0; i < boardSpaces.Length; i++)
        {
            int currentVal = boardSpaces[i];
            switch (currentVal)
            {
                case 0:
                    lineToShow += "|   |"; //Concatinating each string of the row (+=)
                    break;
                case 1:
                    lineToShow += "| X |";
                    break;
                case 2:
                    lineToShow += "| O |";
                    break;
            }
        }

        Console.WriteLine(lineToShow);
    }

    public Row() // Coonstructor for the Row method which initializes the boardSpace[]
    {
        boardSpaces = new int[3];
    }
}