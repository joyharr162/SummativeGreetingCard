using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SummativeGreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Black;
            
            //pens and brushes
            Font titleFont = new Font("Segoe Script", 40, FontStyle.Bold);
            SolidBrush titleBrush = new SolidBrush(Color.PaleVioletRed);
            Font subtitleFont = new Font("Segoe Script", 16, FontStyle.Bold);
            SolidBrush subTitleBrush = new SolidBrush(Color.White);
            Graphics formGraphics = this.CreateGraphics();

            //Draw title and subtitle
            formGraphics.DrawString("Click for More Information!", subtitleFont, subTitleBrush, 50, 40);
            formGraphics.DrawString("Scorpio Greeting Card", titleFont, titleBrush, 50, 100);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //pens and brushes
            SolidBrush starBrush = new SolidBrush(Color.White);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.Black);
            Pen connecterPen = new Pen(Color.PaleVioletRed, 3);

            //draw the lines connecting the stars
            formGraphics.DrawLine(connecterPen, 216, 10, 155, 11);
            formGraphics.DrawLine(connecterPen, 251,25, 243, 35);
            formGraphics.DrawLine(connecterPen, 243, 35, 232, 50);
            formGraphics.DrawLine(connecterPen, 251, 25, 232, 50);
            formGraphics.DrawLine(connecterPen, 216, 10, 251, 25);
            formGraphics.DrawLine(connecterPen, 155, 11, 116, 51);
            formGraphics.DrawLine(connecterPen, 116, 51, 123, 30);
            formGraphics.DrawLine(connecterPen, 123, 30, 114, 148);
            formGraphics.DrawLine(connecterPen, 114, 148, 87, 150);
            formGraphics.DrawLine(connecterPen, 87, 150, 64, 246);
            formGraphics.DrawLine(connecterPen, 64, 246, 65, 210);
            formGraphics.DrawLine(connecterPen, 65, 210, 30, 200);
            formGraphics.DrawLine(connecterPen, 30, 200, 50, 230);

            //draw all the stars
            formGraphics.FillEllipse(starBrush, 251, 25, 8, 8);
            formGraphics.FillEllipse(starBrush, 243, 35, 7, 7);
            formGraphics.FillEllipse(starBrush, 232, 50, 9, 9);
            formGraphics.FillEllipse(starBrush, 216, 10, 10, 10);
            formGraphics.FillEllipse(starBrush, 155, 11, 5, 5);
            formGraphics.FillEllipse(starBrush, 116, 51, 6, 6);
            formGraphics.FillEllipse(starBrush, 123, 30, 6, 6);
            formGraphics.FillEllipse(starBrush, 129, 89, 10, 10);
            formGraphics.FillEllipse(starBrush, 114, 148, 4, 4);
            formGraphics.FillEllipse(starBrush, 87, 150, 13, 13);
            formGraphics.FillEllipse(starBrush, 64, 246, 4, 4);
            formGraphics.FillEllipse(starBrush, 65, 210, 3, 3);
            formGraphics.FillEllipse(starBrush, 30, 200, 5, 5);
            formGraphics.FillEllipse(starBrush, 50, 230, 5, 5);
        }
    }
}
