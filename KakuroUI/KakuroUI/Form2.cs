using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KakuroUI
{
    public partial class KakuroGridView : Form
    /**
   * This form handles the displaying and intake of the Kakuro grid
   * 
   * 
   * author Richard Taylor
   * 
   * version 0.1
   **/

    {
        private List<List<kakuroSquare>> squareCol;
        private List<String> bS;
        private List<String> aS;
        private List<String> dS;
        public KakuroGridView(int columns, int rows)
        {
            
            //creates a table layout dispay for the form
            TableLayoutPanel tableLayoutGrid = new TableLayoutPanel();
            tableLayoutGrid.Location = new System.Drawing.Point(3, 34);
            tableLayoutGrid.Size = new System.Drawing.Size(columns * 55, rows * 55);
            tableLayoutGrid.Name = "Grid";
            tableLayoutGrid.TabStop = false;
            tableLayoutGrid.ColumnCount = columns;
            tableLayoutGrid.RowCount = rows;

            
          
            for (int c = 0; c < columns; c++)
            {
                tableLayoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55));
            }
            for (int r = 0; r < rows; r++)
            {
                tableLayoutGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            }


            //add custom made kakurosquare user controls to the grid and makes a martix of colums with a list or row lists.
            squareCol = new List<List<kakuroSquare>>();
            for (int c = 0; c < tableLayoutGrid.ColumnCount; c++)     
            {
                List<kakuroSquare> squareRow = new List<kakuroSquare>();
                for (int r = 0; r < tableLayoutGrid.RowCount; r++)
                {
                    kakuroSquare square = new kakuroSquare(c, r);
                    squareRow.Add(square);
                    square.Location = new Point(10, 10);
                    tableLayoutGrid.Controls.Add(square, c, r);
                    square.Size = new Size(50, 50);
                    Controls.Add(tableLayoutGrid);
                }
                squareCol.Add(squareRow);
            }


            //debug tool
            //setTableLabels();



            InitializeComponent();
            DoubleBuffered = true;
        }
       

        private void KakuroGridView_Load(object sender, EventArgs e)
        {

        }

        private void buttonGrid_Click(object sender, EventArgs e)
        {

            Boolean pass = true;
            bS = new List<string>();
            aS = new List<string>();
            dS = new List<string>();

            for (int c = 0; c < squareCol.Count; c++)
            {
                List<kakuroSquare> squareRow = squareCol.ElementAt(c);
                for (int r = 0; r < squareRow.Count; r++ )
                {
                    kakuroSquare square = squareRow.ElementAt(r);

                    if (!sortSqaure(square))
                    {
                        pass = false;
                    }   
                }
               
            }
            if (pass)
            {
                Writer writer = new Writer(bS, aS, dS);
            }
            else
            {
                MessageBox.Show("Please only type numbers into at least one entry box for each entry square.", "Invalid Entry");
            }
        }
   
        private Boolean sortSqaure(kakuroSquare square)
        {
            Boolean sorted = false;

            switch (square.getMode())
            {
                case 0:
                case 1:
                    buildBS(square);
                    sorted = true;
                    break;
                case 2:
                    square.setEntryValue();
                    if (square.checkEntryValue())
                    {
                        if (buildASDS(square))
                        {
                            sorted = true;
                        }
                        break;
                    }
                    else
                    {
                        break;
                    }

            }
            return sorted;
        }

        private void buildBS(kakuroSquare sqaure)
        {
            bS.Add("black(" + sqaure.getPRow() + ", " + sqaure.getPCol() + ").");
        }


        private Boolean buildASDS(kakuroSquare square)
       {

            Boolean built = false;
          

            if(square.getTR() != null && square.getBL() == null)
            {
                int length = findRowAcross(square);
                if(length > 0)
                {
                    aS.Add("across(" + square.getPRow() + ", " + square.getPCol() + ", " + length + ", " + square.getTR() + ").");

                    built = true;
                }
            }
            else if(square.getTR() == null && square.getBL() != null)
            {
               int length = findColDown(square);
               
                if(length > 0)
                {
                    dS.Add("down(" + square.getPRow() + ", " + square.getPCol() + ", " + length + ", " + square.getBL() + ").");
                    built = true;
                }
            }
            else
            {
                int alength = findRowAcross(square);
                int dlength = findColDown(square);
                if(alength > 0 && dlength > 0)
                {
                    aS.Add("across(" + square.getPRow() + ", " + square.getPCol() + ", " + alength + ", " + square.getTR() + ").");
                    dS.Add("down(" + square.getPRow() + ", " + square.getPCol() + ", " + dlength + ", " + square.getBL() + ").");

                    built = true;
                }
            }

            return built;
         
       }

        public int findRowAcross(kakuroSquare square)
        {
            Debug.WriteLine("finding Across length");
            int length = 0;
            int col = square.getCol();
            int row = square.getRow();
            while (true)
            {
                col++;
               Debug.WriteLine("FindAcross row is " + row +  " col @" + col);
                if (col <= squareCol.Count()-1)
                {
                    Debug.WriteLine("col (" + col + ") is smaller than " + squareCol.Count());
                    kakuroSquare nextsqaure = squareCol.ElementAt(col).ElementAt(row);
                    if (nextsqaure.getMode() == 0)
                    {
                        length++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return length;
        }

        public int findColDown(kakuroSquare square)
        {
            int length = 0;
            int col = square.getCol();
            int row = square.getRow();
            while (true)
            {
                row++;
                Debug.WriteLine("FindDown col is " + col + " row @" + row);
                if (row <= squareCol.ElementAt(col).Count()-1)
                {
                    Debug.WriteLine("row (" + row + ") is smaller than " + squareCol.ElementAt(col).Count());
                    kakuroSquare nextsqaure = squareCol.ElementAt(col).ElementAt(row);
                    if (nextsqaure.getMode() == 0)
                    {
                        length++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
              
            }
            return length;
        }

      

        //a debug tool for the tables.
        private void setTableLabels()
        {
            for(int c = 0; c < squareCol.Count; c++)
            {
                int col = c;
                List<kakuroSquare> squareRow = squareCol.ElementAt(c);
                for(int r = 0; r < squareRow.Count; r++)
                {
                    int row = r;
                    kakuroSquare sqaure = squareRow.ElementAt(r);
                    sqaure.setTablePosLabel(c, r);
                } 
            }
        } 
    }
}
