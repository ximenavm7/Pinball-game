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
        int ballId;

        public Form1()
        {
            InitializeComponent();

        }

        private void ExitVBox_Collided(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Init()
        {
            Random rand = new Random();
            canvas              = new Canvas(PCT_CANVAS.Size);
            PCT_CANVAS.Image    = canvas.bmp;
            balls              = new List<VPoint>();
            boxes               = new List<VBox>();
            solver              = new VSolver(balls);
            
            
            ExitVBox  exitVBox = new ExitVBox(10, 400, 10, 1000, balls.Count);

            exitVBox.Collided += ExitVBox_Collided;
            boxes.Add(exitVBox);

            balls.Add(exitVBox.a);
            balls.Add(exitVBox.b);
            balls.Add(exitVBox.c);
            balls.Add(exitVBox.d);

            //***********Ropes
            /*
            rope = new VRope(450, 400, 15, 26, balls.Count);
            balls.AddRange(rope.pts);// hay que añadir las pelotas de cada cuerpo a la lista para ser tratadas
            */

            for (int i = 0; i < 1; i++)
                balls.Add(new VPoint(rand.Next(PCT_CANVAS.Width), rand.Next(PCT_CANVAS.Height), balls.Count));


            //**************STOMPERS 
            /*
            
            for (int b = 0; b < 50; b++)//stompers265
                balls.Add(new VPoint(0 + (b * 15), (int)(Height * .2f + b * 2), balls.Count, true));
            */

            /*
            for (int b = 0; b < 50; b++)//stompers265
                balls.Add(new VPoint(0 + (b * 15), 400, balls.Count, true));
            */




            ///////*************CAJAS/*


            //TOP
            /*
            boxes.Add(new VBox(0, 300,1000, 10, balls.Count));
            balls.Add(boxes[boxes.Count - 1].a);
            balls.Add(boxes[boxes.Count - 1].b);
            balls.Add(boxes[boxes.Count - 1].c);
            balls.Add(boxes[boxes.Count - 1].d);
            */

           





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
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
            canvas.LessFast();

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
