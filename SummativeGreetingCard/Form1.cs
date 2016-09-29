///Created by Joy Harris
///September 29 2016
///to create a constelltion greeting card
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
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();

            //when the screen clears, play a sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.pageturn);
            player.Play();

            //erase labels
            titleLabel.Visible = false;
            subtitleLabel.Visible = false;
            nameLabel.Visible = false;

            //pens and brushes
            SolidBrush starBrush = new SolidBrush(Color.White);
            SolidBrush blueBrush = new SolidBrush(Color.LightBlue);
            SolidBrush greenstarBrush = new SolidBrush(Color.LightGreen);
            Pen connecterPen = new Pen(Color.PaleVioletRed, 2);
            Font scriptFont = new Font("Arial", 8, FontStyle.Bold);
            SolidBrush scriptBrush = new SolidBrush(Color.White);

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
            Thread.Sleep(75);

            formGraphics.Clear(Color.Black);

            //redraw connecting lines
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

            //make the stars grow larger
            formGraphics.FillEllipse(starBrush, 253, 25, 9, 9);
            formGraphics.FillEllipse(starBrush, 243, 35, 8, 8);
            formGraphics.FillEllipse(starBrush, 232, 50, 10, 10);
            formGraphics.FillEllipse(starBrush, 216, 10, 11, 11);
            formGraphics.FillEllipse(starBrush, 155, 11, 6, 6);
            formGraphics.FillEllipse(starBrush, 116, 51, 7, 7);
            formGraphics.FillEllipse(starBrush, 123, 30, 7, 7);
            formGraphics.FillEllipse(starBrush, 129, 89, 11, 11);
            formGraphics.FillEllipse(starBrush, 114, 148, 5, 5);
            formGraphics.FillEllipse(starBrush, 87, 150, 14, 14);
            formGraphics.FillEllipse(starBrush, 64, 246, 5, 5);
            formGraphics.FillEllipse(starBrush, 65, 210, 4, 4);
            formGraphics.FillEllipse(starBrush, 30, 200, 6, 6);
            formGraphics.FillEllipse(starBrush, 50, 230, 6, 6);
            Thread.Sleep(75);

            formGraphics.FillEllipse(starBrush, 253, 25, 10, 10);
            formGraphics.FillEllipse(starBrush, 243, 35, 9, 9);
            formGraphics.FillEllipse(starBrush, 232, 50, 11, 11);
            formGraphics.FillEllipse(starBrush, 216, 10, 12, 12);
            formGraphics.FillEllipse(starBrush, 155, 11, 7, 7);
            formGraphics.FillEllipse(starBrush, 116, 51, 8, 8);
            formGraphics.FillEllipse(starBrush, 123, 30, 8, 8);
            formGraphics.FillEllipse(starBrush, 129, 89, 12, 12);
            formGraphics.FillEllipse(starBrush, 114, 148, 6, 6);
            formGraphics.FillEllipse(starBrush, 87, 150, 15, 15);
            formGraphics.FillEllipse(starBrush, 64, 246, 6, 6);
            formGraphics.FillEllipse(starBrush, 65, 210, 5, 5);
            formGraphics.FillEllipse(starBrush, 30, 200, 7, 7);
            formGraphics.FillEllipse(starBrush, 50, 230, 7, 7);
            Thread.Sleep(75);

            formGraphics.FillEllipse(starBrush, 253, 25, 11, 11);
            formGraphics.FillEllipse(starBrush, 243, 35, 10, 10);
            formGraphics.FillEllipse(starBrush, 232, 50, 12, 12);
            formGraphics.FillEllipse(starBrush, 216, 10, 13, 13);
            formGraphics.FillEllipse(starBrush, 155, 11, 8, 8);
            formGraphics.FillEllipse(starBrush, 116, 51, 9, 9);
            formGraphics.FillEllipse(starBrush, 123, 30, 9, 9);
            formGraphics.FillEllipse(starBrush, 129, 89, 13, 13);
            formGraphics.FillEllipse(starBrush, 114, 148, 7, 7);
            formGraphics.FillEllipse(starBrush, 87, 150, 16, 16);
            formGraphics.FillEllipse(starBrush, 64, 246, 7, 7);
            formGraphics.FillEllipse(starBrush, 65, 210, 6, 6);
            formGraphics.FillEllipse(starBrush, 30, 200, 8, 8);
            formGraphics.FillEllipse(starBrush, 50, 230, 8, 8);
            Thread.Sleep(75);

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

            //shrink the stars
            formGraphics.FillEllipse(starBrush, 253, 25, 10, 10);
            formGraphics.FillEllipse(starBrush, 243, 35, 9, 9);
            formGraphics.FillEllipse(starBrush, 232, 50, 11, 11);
            formGraphics.FillEllipse(starBrush, 216, 10, 12, 12);
            formGraphics.FillEllipse(starBrush, 155, 11, 7, 7);
            formGraphics.FillEllipse(starBrush, 116, 51, 8, 8);
            formGraphics.FillEllipse(starBrush, 123, 30, 8, 8);
            formGraphics.FillEllipse(starBrush, 129, 89, 12, 12);
            formGraphics.FillEllipse(starBrush, 114, 148, 6, 6);
            formGraphics.FillEllipse(starBrush, 87, 150, 15, 15);
            formGraphics.FillEllipse(starBrush, 64, 246, 6, 6);
            formGraphics.FillEllipse(starBrush, 65, 210, 5, 5);
            formGraphics.FillEllipse(starBrush, 30, 200, 7, 7);
            formGraphics.FillEllipse(starBrush, 50, 230, 7, 7);
            Thread.Sleep(75);

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

            formGraphics.FillEllipse(starBrush, 253, 25, 9, 9);
            formGraphics.FillEllipse(starBrush, 243, 35, 8, 8);
            formGraphics.FillEllipse(starBrush, 232, 50, 10, 10);
            formGraphics.FillEllipse(starBrush, 216, 10, 11, 11);
            formGraphics.FillEllipse(starBrush, 155, 11, 6, 6);
            formGraphics.FillEllipse(starBrush, 116, 51, 7, 7);
            formGraphics.FillEllipse(starBrush, 123, 30, 7, 7);
            formGraphics.FillEllipse(starBrush, 129, 89, 11, 11);
            formGraphics.FillEllipse(starBrush, 114, 148, 5, 5);
            formGraphics.FillEllipse(starBrush, 87, 150, 14, 14);
            formGraphics.FillEllipse(starBrush, 64, 246, 5, 5);
            formGraphics.FillEllipse(starBrush, 65, 210, 4, 4);
            formGraphics.FillEllipse(starBrush, 30, 200, 6, 6);
            formGraphics.FillEllipse(starBrush, 50, 230, 6, 6);
            Thread.Sleep(75);

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

            //return stars to original state
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

            //animate the stars in light blue
            formGraphics.Clear(Color.Black);

            //Redraw connecting lines
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

            //make the stars grow larger
            formGraphics.FillEllipse(blueBrush, 253, 25, 9, 9);
            formGraphics.FillEllipse(blueBrush, 243, 35, 8, 8);
            formGraphics.FillEllipse(blueBrush, 232, 50, 10, 10);
            formGraphics.FillEllipse(blueBrush, 216, 10, 11, 11);
            formGraphics.FillEllipse(blueBrush, 155, 11, 6, 6);
            formGraphics.FillEllipse(blueBrush, 116, 51, 7, 7);
            formGraphics.FillEllipse(blueBrush, 123, 30, 7, 7);
            formGraphics.FillEllipse(blueBrush, 129, 89, 11, 11);
            formGraphics.FillEllipse(blueBrush, 114, 148, 5, 5);
            formGraphics.FillEllipse(blueBrush, 87, 150, 14, 14);
            formGraphics.FillEllipse(blueBrush, 64, 246, 5, 5);
            formGraphics.FillEllipse(blueBrush, 65, 210, 4, 4);
            formGraphics.FillEllipse(blueBrush, 30, 200, 6, 6);
            formGraphics.FillEllipse(blueBrush, 50, 230, 6, 6);
            Thread.Sleep(75);

            formGraphics.FillEllipse(blueBrush, 253, 25, 10, 10);
            formGraphics.FillEllipse(blueBrush, 243, 35, 9, 9);
            formGraphics.FillEllipse(blueBrush, 232, 50, 11, 11);
            formGraphics.FillEllipse(blueBrush, 216, 10, 12, 12);
            formGraphics.FillEllipse(blueBrush, 155, 11, 7, 7);
            formGraphics.FillEllipse(blueBrush, 116, 51, 8, 8);
            formGraphics.FillEllipse(blueBrush, 123, 30, 8, 8);
            formGraphics.FillEllipse(blueBrush, 129, 89, 12, 12);
            formGraphics.FillEllipse(blueBrush, 114, 148, 6, 6);
            formGraphics.FillEllipse(blueBrush, 87, 150, 15, 15);
            formGraphics.FillEllipse(blueBrush, 64, 246, 6, 6);
            formGraphics.FillEllipse(blueBrush, 65, 210, 5, 5);
            formGraphics.FillEllipse(blueBrush, 30, 200, 7, 7);
            formGraphics.FillEllipse(blueBrush, 50, 230, 7, 7);
            Thread.Sleep(75);

            formGraphics.FillEllipse(blueBrush, 253, 25, 11, 11);
            formGraphics.FillEllipse(blueBrush, 243, 35, 10, 10);
            formGraphics.FillEllipse(blueBrush, 232, 50, 12, 12);
            formGraphics.FillEllipse(blueBrush, 216, 10, 13, 13);
            formGraphics.FillEllipse(blueBrush, 155, 11, 8, 8);
            formGraphics.FillEllipse(blueBrush, 116, 51, 9, 9);
            formGraphics.FillEllipse(blueBrush, 123, 30, 9, 9);
            formGraphics.FillEllipse(blueBrush, 129, 89, 13, 13);
            formGraphics.FillEllipse(blueBrush, 114, 148, 7, 7);
            formGraphics.FillEllipse(blueBrush, 87, 150, 16, 16);
            formGraphics.FillEllipse(blueBrush, 64, 246, 7, 7);
            formGraphics.FillEllipse(blueBrush, 65, 210, 6, 6);
            formGraphics.FillEllipse(blueBrush, 30, 200, 8, 8);
            formGraphics.FillEllipse(blueBrush, 50, 230, 8, 8);
            Thread.Sleep(75);

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

            //shrink the stars
            formGraphics.FillEllipse(blueBrush, 253, 25, 10, 10);
            formGraphics.FillEllipse(blueBrush, 243, 35, 9, 9);
            formGraphics.FillEllipse(blueBrush, 232, 50, 11, 11);
            formGraphics.FillEllipse(blueBrush, 216, 10, 12, 12);
            formGraphics.FillEllipse(blueBrush, 155, 11, 7, 7);
            formGraphics.FillEllipse(blueBrush, 116, 51, 8, 8);
            formGraphics.FillEllipse(blueBrush, 123, 30, 8, 8);
            formGraphics.FillEllipse(blueBrush, 129, 89, 12, 12);
            formGraphics.FillEllipse(blueBrush, 114, 148, 6, 6);
            formGraphics.FillEllipse(blueBrush, 87, 150, 15, 15);
            formGraphics.FillEllipse(blueBrush, 64, 246, 6, 6);
            formGraphics.FillEllipse(blueBrush, 65, 210, 5, 5);
            formGraphics.FillEllipse(blueBrush, 30, 200, 7, 7);
            formGraphics.FillEllipse(blueBrush, 50, 230, 7, 7);
            Thread.Sleep(75);

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

            formGraphics.FillEllipse(blueBrush, 253, 25, 9, 9);
            formGraphics.FillEllipse(blueBrush, 243, 35, 8, 8);
            formGraphics.FillEllipse(blueBrush, 232, 50, 10, 10);
            formGraphics.FillEllipse(blueBrush, 216, 10, 11, 11);
            formGraphics.FillEllipse(blueBrush, 155, 11, 6, 6);
            formGraphics.FillEllipse(blueBrush, 116, 51, 7, 7);
            formGraphics.FillEllipse(blueBrush, 123, 30, 7, 7);
            formGraphics.FillEllipse(blueBrush, 129, 89, 11, 11);
            formGraphics.FillEllipse(blueBrush, 114, 148, 5, 5);
            formGraphics.FillEllipse(blueBrush, 87, 150, 14, 14);
            formGraphics.FillEllipse(blueBrush, 64, 246, 5, 5);
            formGraphics.FillEllipse(blueBrush, 65, 210, 4, 4);
            formGraphics.FillEllipse(blueBrush, 30, 200, 6, 6);
            formGraphics.FillEllipse(blueBrush, 50, 230, 6, 6);
            Thread.Sleep(75);

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
            formGraphics.FillEllipse(blueBrush, 253, 25, 8, 8);
            formGraphics.FillEllipse(blueBrush, 243, 35, 7, 7);
            formGraphics.FillEllipse(blueBrush, 232, 50, 9, 9);
            formGraphics.FillEllipse(blueBrush, 216, 10, 10, 10);
            formGraphics.FillEllipse(blueBrush, 155, 11, 5, 5);
            formGraphics.FillEllipse(blueBrush, 116, 51, 6, 6);
            formGraphics.FillEllipse(blueBrush, 123, 30, 6, 6);
            formGraphics.FillEllipse(blueBrush, 129, 89, 10, 10);
            formGraphics.FillEllipse(blueBrush, 114, 148, 4, 4);
            formGraphics.FillEllipse(blueBrush, 87, 150, 13, 13);
            formGraphics.FillEllipse(blueBrush, 64, 246, 4, 4);
            formGraphics.FillEllipse(blueBrush, 65, 210, 3, 3);
            formGraphics.FillEllipse(blueBrush, 30, 200, 5, 5);
            formGraphics.FillEllipse(blueBrush, 50, 230, 5, 5);

            //animate the stars in green
            formGraphics.Clear(Color.Black);

            //Redraw connecting lines
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

            //make the stars grow larger
            formGraphics.FillEllipse(greenstarBrush, 253, 25, 9, 9);
            formGraphics.FillEllipse(greenstarBrush, 243, 35, 8, 8);
            formGraphics.FillEllipse(greenstarBrush, 232, 50, 10, 10);
            formGraphics.FillEllipse(greenstarBrush, 216, 10, 11, 11);
            formGraphics.FillEllipse(greenstarBrush, 155, 11, 6, 6);
            formGraphics.FillEllipse(greenstarBrush, 116, 51, 7, 7);
            formGraphics.FillEllipse(greenstarBrush, 123, 30, 7, 7);
            formGraphics.FillEllipse(greenstarBrush, 129, 89, 11, 11);
            formGraphics.FillEllipse(greenstarBrush, 114, 148, 5, 5);
            formGraphics.FillEllipse(greenstarBrush, 87, 150, 14, 14);
            formGraphics.FillEllipse(greenstarBrush, 64, 246, 5, 5);
            formGraphics.FillEllipse(greenstarBrush, 65, 210, 4, 4);
            formGraphics.FillEllipse(greenstarBrush, 30, 200, 6, 6);
            formGraphics.FillEllipse(greenstarBrush, 50, 230, 6, 6);
            Thread.Sleep(75);

            formGraphics.FillEllipse(greenstarBrush, 253, 25, 10, 10);
            formGraphics.FillEllipse(greenstarBrush, 243, 35, 9, 9);
            formGraphics.FillEllipse(greenstarBrush, 232, 50, 11, 11);
            formGraphics.FillEllipse(greenstarBrush, 216, 10, 12, 12);
            formGraphics.FillEllipse(greenstarBrush, 155, 11, 7, 7);
            formGraphics.FillEllipse(greenstarBrush, 116, 51, 8, 8);
            formGraphics.FillEllipse(greenstarBrush, 123, 30, 8, 8);
            formGraphics.FillEllipse(greenstarBrush, 129, 89, 12, 12);
            formGraphics.FillEllipse(greenstarBrush, 114, 148, 6, 6);
            formGraphics.FillEllipse(greenstarBrush, 87, 150, 15, 15);
            formGraphics.FillEllipse(greenstarBrush, 64, 246, 6, 6);
            formGraphics.FillEllipse(greenstarBrush, 65, 210, 5, 5);
            formGraphics.FillEllipse(greenstarBrush, 30, 200, 7, 7);
            formGraphics.FillEllipse(greenstarBrush, 50, 230, 7, 7);
            Thread.Sleep(75);

            formGraphics.FillEllipse(greenstarBrush, 253, 25, 11, 11);
            formGraphics.FillEllipse(greenstarBrush, 243, 35, 10, 10);
            formGraphics.FillEllipse(greenstarBrush, 232, 50, 12, 12);
            formGraphics.FillEllipse(greenstarBrush, 216, 10, 13, 13);
            formGraphics.FillEllipse(greenstarBrush, 155, 11, 8, 8);
            formGraphics.FillEllipse(greenstarBrush, 116, 51, 9, 9);
            formGraphics.FillEllipse(greenstarBrush, 123, 30, 9, 9);
            formGraphics.FillEllipse(greenstarBrush, 129, 89, 13, 13);
            formGraphics.FillEllipse(greenstarBrush, 114, 148, 7, 7);
            formGraphics.FillEllipse(greenstarBrush, 87, 150, 16, 16);
            formGraphics.FillEllipse(greenstarBrush, 64, 246, 7, 7);
            formGraphics.FillEllipse(greenstarBrush, 65, 210, 6, 6);
            formGraphics.FillEllipse(greenstarBrush, 30, 200, 8, 8);
            formGraphics.FillEllipse(greenstarBrush, 50, 230, 8, 8);
            Thread.Sleep(75);

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

            //shrink the stars
            formGraphics.FillEllipse(greenstarBrush, 253, 25, 10, 10);
            formGraphics.FillEllipse(greenstarBrush, 243, 35, 9, 9);
            formGraphics.FillEllipse(greenstarBrush, 232, 50, 11, 11);
            formGraphics.FillEllipse(greenstarBrush, 216, 10, 12, 12);
            formGraphics.FillEllipse(greenstarBrush, 155, 11, 7, 7);
            formGraphics.FillEllipse(greenstarBrush, 116, 51, 8, 8);
            formGraphics.FillEllipse(greenstarBrush, 123, 30, 8, 8);
            formGraphics.FillEllipse(greenstarBrush, 129, 89, 12, 12);
            formGraphics.FillEllipse(greenstarBrush, 114, 148, 6, 6);
            formGraphics.FillEllipse(greenstarBrush, 87, 150, 15, 15);
            formGraphics.FillEllipse(greenstarBrush, 64, 246, 6, 6);
            formGraphics.FillEllipse(greenstarBrush, 65, 210, 5, 5);
            formGraphics.FillEllipse(greenstarBrush, 30, 200, 7, 7);
            formGraphics.FillEllipse(greenstarBrush, 50, 230, 7, 7);
            Thread.Sleep(75);

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

            formGraphics.FillEllipse(greenstarBrush, 253, 25, 9, 9);
            formGraphics.FillEllipse(greenstarBrush, 243, 35, 8, 8);
            formGraphics.FillEllipse(greenstarBrush, 232, 50, 10, 10);
            formGraphics.FillEllipse(greenstarBrush, 216, 10, 11, 11);
            formGraphics.FillEllipse(greenstarBrush, 155, 11, 6, 6);
            formGraphics.FillEllipse(greenstarBrush, 116, 51, 7, 7);
            formGraphics.FillEllipse(greenstarBrush, 123, 30, 7, 7);
            formGraphics.FillEllipse(greenstarBrush, 129, 89, 11, 11);
            formGraphics.FillEllipse(greenstarBrush, 114, 148, 5, 5);
            formGraphics.FillEllipse(greenstarBrush, 87, 150, 14, 14);
            formGraphics.FillEllipse(greenstarBrush, 64, 246, 5, 5);
            formGraphics.FillEllipse(greenstarBrush, 65, 210, 4, 4);
            formGraphics.FillEllipse(greenstarBrush, 30, 200, 6, 6);
            formGraphics.FillEllipse(greenstarBrush, 50, 230, 6, 6);
            Thread.Sleep(75);

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
            formGraphics.FillEllipse(greenstarBrush, 253, 25, 8, 8);
            formGraphics.FillEllipse(greenstarBrush, 243, 35, 7, 7);
            formGraphics.FillEllipse(greenstarBrush, 232, 50, 9, 9);
            formGraphics.FillEllipse(greenstarBrush, 216, 10, 10, 10);
            formGraphics.FillEllipse(greenstarBrush, 155, 11, 5, 5);
            formGraphics.FillEllipse(greenstarBrush, 116, 51, 6, 6);
            formGraphics.FillEllipse(greenstarBrush, 123, 30, 6, 6);
            formGraphics.FillEllipse(greenstarBrush, 129, 89, 10, 10);
            formGraphics.FillEllipse(greenstarBrush, 114, 148, 4, 4);
            formGraphics.FillEllipse(greenstarBrush, 87, 150, 13, 13);
            formGraphics.FillEllipse(greenstarBrush, 64, 246, 4, 4);
            formGraphics.FillEllipse(greenstarBrush, 65, 210, 3, 3);
            formGraphics.FillEllipse(greenstarBrush, 30, 200, 5, 5);
            formGraphics.FillEllipse(greenstarBrush, 50, 230, 5, 5);
            Thread.Sleep(500);

            //Stop animation, return stars to normal
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
            Thread.Sleep(500);

            //when the text appears, play another sound
            SoundPlayer player1 = new SoundPlayer(Properties.Resources.fireworks);
            player.Play();

            // draw information about the zodiac sign
            formGraphics.DrawString("Scorpio is the eighth astrological", scriptFont, scriptBrush, 90, 170);
            formGraphics.DrawString("sign in th Zodiac. It spans the", scriptFont, scriptBrush, 90, 185);
            formGraphics.DrawString("210–240th degree of the Zodiac,", scriptFont, scriptBrush, 90, 200);
            formGraphics.DrawString("between the 207.25 and 234.75", scriptFont, scriptBrush, 90, 215);
            formGraphics.DrawString("degree of celestial longitude.", scriptFont, scriptBrush, 90, 230);
        }
    }
}