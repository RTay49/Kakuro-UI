using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KakuroUI
{
    public partial class Form1 : Form
    {
        /**
         * Form1 is used primarly to set up the grid with confgigurations of its width and height
         * 
         * 
         * author Richard Taylor
         * 
         * version 0.1
         **/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int w = 0;
            
            int h = 0;

           if(Int32.TryParse(textBoxWidth.Text, out w) && Int32.TryParse(textBoxHeight.Text, out h) && w > 0 && h > 0 && w < 16 && h < 16)
            {
                KakuroGridView kgv = new KakuroGridView(w, h);
                if (w * 55 < 363)
                {
                    int dif = 363 - w * 52;
                    kgv.Size = new Size(w * 58 + dif, h * 58 + 100);
                }
                else
                {
                    kgv.Size = new Size(w * 58, h * 58 + 50);
                }
                kgv.Show();
                Hide();
            }
           else
            {
                MessageBox.Show("Please enter only possitve integers at a maximum of 15.", "Invalid grid entry");
            }
           
            
            

            
        }
    }
}
