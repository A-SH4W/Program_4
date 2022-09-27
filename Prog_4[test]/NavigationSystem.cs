using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prog_4_test_
{
    public class NavigationSystem
    {
        string[,] Map;
        string islandLoc;
        int islandRow;
        int islandCol;

        // Constructor for 2d array, fills with waves
        public NavigationSystem(int row,int col)
        {
            Map = new string[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Map[i, j] = "~";
                }
            }

        }


        public string getIslandLoc()
        {
            return islandLoc;
        }

        // method for generating island location
        public void IslandLoc()
        {
            Random rnd = new Random();
            islandRow = rnd.Next(StartScreen.r);
            islandCol = rnd.Next(StartScreen.c);
            islandLoc = string.Join(",", islandRow, islandCol);
            Debug.Write("island loc-> ");
            Debug.Write(islandLoc);
        }

        public int getIslandRow()
        {
            return islandRow;
        }
        public int getIslandCol()
        {
            return islandCol;
        }

        // method that converts 2d array (map) into string to be printed to the map display
        public string PrintMap()
        {     
            var sb = new StringBuilder(string.Empty);
            var maxI = Map.GetLength(0);
            var maxJ = Map.GetLength(1);
            sb.Append(" ");
            for (var x=0; x < maxJ; x++)
            {
                sb.Append(x.ToString());
                sb.Append(" ");
            }
            sb.Append("\n");
            for (var i = 0; i < maxI; i++)
            {               
                sb.Append(i.ToString());
                for (var j = 0; j < maxJ; j++)
                {
                    sb.Append($"{Map[i, j]}");                    
                }               
                sb.Append("\n");               
            }
            var result = sb.ToString();
            return result;          
        }

        public void GuessMethod()
        {
            //what do? useless?
            
        }


    }
}
