using LYB.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LYB
{
    public partial class Form1 : Form
    {
        Canvas canvas;
        List<VPoint> balls;
        VRope rope;
        List<VBox> boxes;
        VSolver solver;
        Point mouse, trigger;
        bool isMouseDown,isRightButton;
        int ballId, angle;

        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {
            Random rand = new Random();
            canvas              = new Canvas(PCT_CANVAS.Size);
            PCT_CANVAS.Image    = canvas.bmp;
            balls               = new List<VPoint>();
            boxes               = new List<VBox>();
            solver              = new VSolver(balls);
            angle = 0;
            
            /*            
            rope = new VRope(450, 400, 15, 25, balls.Count);
            balls.AddRange(rope.pts);//*/// hay que añadir las pelotas de cada cuerpo a la lista para ser tratadas


            
            for (int i = 0; i < 15; i++)
                balls.Add(new VPoint(rand.Next(450,820), rand.Next(20, 550), balls.Count, true));//*/

            canvas.DrawMap(Mapas.map2, balls, boxes); // Dibujar el mapa
            balls.Add(new VPoint(870, 570, balls.Count));

            /*
            for (int b = 0; b < 25; b++)//stompers265
                balls.Add(new VPoint(0 + (b * 15), (int)(Height * .2f + b * 2), balls.Count, true));

            for (int b = 0; b < 25; b++)//stompers265
                balls.Add(new VPoint(800 + (b * 15), (int)(Height * .5f - b * 6), balls.Count, true));
            //*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            this.BackgroundImage = Resource1.space;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Init();
        }

        private void BTN_EXE_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void PCT_CANVAS_MouseClick(object sender, MouseEventArgs e)
        {
            if (CHK_GENERATE.Checked)
                balls.Add(new VPoint(e.X, e.Y, balls.Count));
        }

        private void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e)
        {
            if (!CHK_GENERATE.Checked)
            {
                isMouseDown = true;

                isRightButton = (e.Button == MouseButtons.Right);
                if (isRightButton)
                    trigger = e.Location;

                mouse = e.Location;
            }
        }

        private void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e)
        {         
            if (isMouseDown)
            {
                if (e.Button == MouseButtons.Left)//MOVE BALL TO POINTER
                {
                    LBL_STATUS.Text = "Ahh !!" + e.Location.ToString();
                    mouse = e.Location;
                    if (ballId > -1)
                    {
                        balls[ballId].Pos.X = e.Location.X;
                        balls[ballId].Pos.Y = e.Location.Y;

                        balls[ballId].Old = balls[ballId].Pos;
                    }
                }
                else
                    trigger = e.Location;
            }
        }

        private void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (e.Button == MouseButtons.Right && ballId != -1)
            {
                balls[ballId].Old.X = e.Location.X;
                balls[ballId].Old.Y = e.Location.Y;
                LBL_STATUS.Text = "FIRE !!!";               
            }

            ballId = -1;
        }
        private void TIMER_Tick(object sender, EventArgs e)
        {
            canvas.LessFast(balls);

            ballId = solver.Update(canvas.g, canvas.Width, canvas.Height, mouse, isMouseDown);
      
            if(rope!=null)
                rope.Update(canvas.g, canvas.Width, canvas.Height);

            for (int b = 0; b < boxes.Count; b++)
                boxes[b].React(canvas.g, balls, PCT_CANVAS.Width, PCT_CANVAS.Height);//*/   

            if (isMouseDown && isRightButton && ballId != -1)
                canvas.g.DrawLine(Pens.Green, balls[ballId].X, balls[ballId].Y, trigger.X, trigger.Y);
            
            PCT_CANVAS.Invalidate();
        }
    }
}
