using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KakuroUI
{
    public partial class kakuroSquare : UserControl
    {
        private int mode;
        private int row;
        private int col;
        private int prow;
        private int pcol;
        private int? tr;
        private int? bl;
        public kakuroSquare(int col, int row)
        {
            mode = 0;
            this.row = row;
            this.col = col;

            prow = row + 1;
            pcol = col + 1;

            
            InitializeComponent();



            entryBL.TabStop = false;
            entryTR.TabStop = false;

            labelpos.Text =  this.col.ToString() + "." + this.row.ToString();

            labelpos.Visible = false;
            labelTablePos.Visible = false;

        }


       

        private void kakuroSquare_Click(object sender, EventArgs e)
        {
            change();
        }

        private void entrybackground_Click(object sender, EventArgs e)
        {
            change();
        }


        private void change()
        {
            mode++;
            if(mode > 2)
            {
                mode = 0;
            }
            switch (mode)
            {
                case 0:
                    entryTR.Visible = false;
                    entryBL.Visible = false;
                    entryBL.TabStop = false;
                    entryTR.TabStop = false;
                    entrybackground.Visible = false;
                    BackColor = Color.White;
                    break;
                case 1:
                    BackColor = Color.Black;
                    break;
                case 2:
                    entryTR.Visible = true;
                    entryBL.Visible = true;
                    entryTR.TabStop = true;
                    entryBL.TabStop = true;
                    entrybackground.Visible = true;
                    break;
            }
        }

   
        

        public void setTablePosLabel(int col, int row)
        {
            labelTablePos.Text = col.ToString() + "." + row.ToString();
            //labelTablePos.Visible = true;
        }


        public void setEntryValue()
        {
            int i;
            if (Int32.TryParse(entryTR.Text, out i))
            {
                tr = i;
            }
            else
            {
                tr = null; 
            }

            if (Int32.TryParse(entryBL.Text, out i))
            {
                bl = i;
            }
            else
            {
                bl = null;
            }
        }

        public Boolean checkEntryValue()
        {
            if (tr == null && bl == null)
            {
                return false;
            }
            else {
                return true;
            } 
       }


        public int getMode()
        {
            return mode;
        }

        public int getRow()
        {
            return row;
        }
        public int getCol()
        {
            return col;
        }

        public int getPCol()
        {
            return pcol;
        }

        public int getPRow()
        {
            return prow;
        }

        public int? getTR()
        {
            return tr;
        }
        public int? getBL()
        {
            return bl;
        }

        private void entryBL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
