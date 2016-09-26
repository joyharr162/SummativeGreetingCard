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
// comment
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
            SolidBrush starBrush2 = new SolidBrush(Color.LightBlue);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.Black);
            Pen connecterPen = new Pen(Color.PaleVioletRed, 2);

            //draw the lines connecting the stars
            formGraphics.DrawLine(connecterPen, 155, 13, 125, 32);
            formGraphics.DrawLine(connecterPen, 225, 16, 155, 13);
            formGraphics.DrawLine(connecterPen, 259, 25, 225, 16);
            formGraphics.DrawLine(connecterPen, 259, 25, 240, 50);
            formGraphics.DrawLine(connecterPen, 120, 51, 128, 30);
            formGraphics.DrawLine(connecterPen, 128, 30, 121, 51);
            formGraphics.DrawLine(connecterPen, 132, 89, 120, 57);
            formGraphics.DrawLine(connecterPen, 136, 87, 114, 148);
            formGraphics.DrawLine(connecterPen, 114, 148, 87, 157);
            formGraphics.DrawLine(connecterPen, 92, 150, 67, 209);
            formGraphics.DrawLine(connecterPen, 65, 209, 65, 210);
            formGraphics.DrawLine(connecterPen, 65, 210, 30, 200);
            formGraphics.DrawLine(connecterPen, 65, 210, 50, 230);
            formGraphics.DrawLine(connecterPen, 65, 210, 66, 244);

            //draw all the stars
            formGraphics.FillEllipse(starBrush, 253, 25, 8, 8);
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
            Thread.Sleep(1500);

            formGraphics.Clear(Color.Black);

            //clear the screen, redraw lines, and animate the stars

            formGraphics.DrawLine(connecterPen, 155, 13, 125, 32);
            formGraphics.DrawLine(connecterPen, 225, 16, 155, 13);
            formGraphics.DrawLine(connecterPen, 259, 25, 225, 16);
            formGraphics.DrawLine(connecterPen, 259, 25, 240, 50);
            formGraphics.DrawLine(connecterPen, 120, 51, 128, 30);
            formGraphics.DrawLine(connecterPen, 128, 30, 121, 51);
            formGraphics.DrawLine(connecterPen, 132, 89, 120, 57);
            formGraphics.DrawLine(connecterPen, 136, 87, 114, 148);
            formGraphics.DrawLine(connecterPen, 114, 148, 87, 157);
            formGraphics.DrawLine(connecterPen, 92, 150, 67, 209);
            formGraphics.DrawLine(connecterPen, 65, 209, 65, 210);
            formGraphics.DrawLine(connecterPen, 65, 210, 30, 200);
            formGraphics.DrawLine(connecterPen, 65, 210, 50, 230);
            formGraphics.DrawLine(connecterPen, 65, 210, 66, 244);

            formGraphics.FillEllipse(starBrush2, 253, 25, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 243, 35, 11, 11);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 232, 50, 4, 4);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 216, 10, 16, 16);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 155, 11, 2,2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 116, 51, 11, 11);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 123, 30, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 129, 89, 16, 16);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 114, 148, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 87, 150, 6, 6);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 64, 246, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 65, 210, 7, 7);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 30, 200, 7, 7);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush2, 50, 230, 2, 2);
            Thread.Sleep(100);

            //return stars to normal
            formGraphics.FillEllipse(starBrush, 253, 25, 8, 8);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 243, 35, 7, 7);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 232, 50, 9, 9);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 216, 10, 10, 10);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 155, 11, 5, 5);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 116, 51, 6, 6);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 123, 30, 6, 6);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 129, 89, 10, 10);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 114, 148, 4, 4);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 87, 150, 13, 13);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 64, 246, 4, 4);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 65, 210, 3, 3);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 30, 200, 5, 5);
            Thread.Sleep(100);
            formGraphics.FillEllipse(starBrush, 50, 230, 5, 5);
            Thread.Sleep(100);

            formGraphics.Clear(Color.Black);

            formGraphics.DrawLine(connecterPen, 155, 13, 125, 32);
            formGraphics.DrawLine(connecterPen, 225, 16, 155, 13);
            formGraphics.DrawLine(connecterPen, 259, 25, 225, 16);
            formGraphics.DrawLine(connecterPen, 259, 25, 240, 50);
            formGraphics.DrawLine(connecterPen, 120, 51, 128, 30);
            formGraphics.DrawLine(connecterPen, 128, 30, 121, 51);
            formGraphics.DrawLine(connecterPen, 132, 89, 120, 57);
            formGraphics.DrawLine(connecterPen, 136, 87, 114, 148);
            formGraphics.DrawLine(connecterPen, 114, 148, 87, 157);
            formGraphics.DrawLine(connecterPen, 92, 150, 67, 209);
            formGraphics.DrawLine(connecterPen, 65, 209, 65, 210);
            formGraphics.DrawLine(connecterPen, 65, 210, 30, 200);
            formGraphics.DrawLine(connecterPen, 65, 210, 50, 230);
            formGraphics.DrawLine(connecterPen, 65, 210, 66, 244);

            //return starts to original state
            formGraphics.FillEllipse(starBrush, 253, 25, 8, 8);
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
