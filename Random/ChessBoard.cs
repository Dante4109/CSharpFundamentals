using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.Random
{
    class ChessBoard
    {
        public static string[] CreateGrid(int rows, int cols, char light, char dark)
        {
            var grid = new string[rows];
            //Adding the spaces improves the display
            string[] cells = { new string(new char[] { light, ' ', dark, ' ' }), new string(new char[] { dark, ' ', light, ' ' }) };
            for (var row = 0; row < (rows-1); row++)
            {
                int cellIndex = row % 2;
                StringBuilder sb = new StringBuilder(cells[cellIndex]);
                for (var col = 0; col < (cols-1); col++)
                {
                    sb.Append(cells[cellIndex]);
                }
                grid[row] = '\n' + sb.ToString() ;
            }
            //Returning a string array reduces the print loop to just 1.
            return grid;
        }
    }
}
