using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Drawn_Of_Circle
{
    public partial class Form1 : Form
    {

        Point Punto_C;
        Point Punto_R;
        Bitmap bmp = new Bitmap(480, 360);

        double r = 0;
        int xc, yc;
        int xr, yr;

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, 370, 350);
            pictureBox1.Image = bmp;
            lbltimedda.Text = "00 : 00";
            lbltimemidpoint.Text = "00 : 00";
            lblcoordenadaC.Text = "(00 , 00)";
            lblcoordenadaR.Text = "(00 , 00)";
            lblradio.Text = "0";
        }

        private void CrearCoordenada()
        {
            int xi, yi, xf, yf;
            Pen pen = new Pen(Color.Tomato, 3);
            Graphics Gfx = Graphics.FromImage(bmp);

            xi = Punto_C.X;
            yi = Punto_C.Y;

            xf = Punto_R.X;
            yf = Punto_R.Y;

            Gfx.FillRectangle(Brushes.Tomato, xi - 1, yi - 1, 2, 2);
            Gfx.FillRectangle(Brushes.Tomato, xf - 1, yf - 1, 2, 2);
            pictureBox1.Image = bmp;

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (xc == 0)
            {
                xc = e.X;
                yc = e.Y;

                Punto_C = new Point((int)xc, (int)yc);
            }
            else
            {
                xr = e.X;
                yr = e.Y;

                Punto_R = new Point((int)xr, (int)yr);

                r = Math.Round(Math.Sqrt(Math.Pow(xr - xc, 2) + Math.Pow(yr - yc, 2)));


                lblcoordenadaC.Text = "(" + xc + " , " + yc + ")";
                lblcoordenadaR.Text = "(" + xr + " , " + yr + ")";
                lblradio.Text = r.ToString();

                CirculoDDA(xc,yc, r, xr,yr);
                CrearCoordenada();

                pictureBox1.Image = bmp;
               
                xc = 0;

            }
        }

        private double Radio(int xc, int yc, int xr, int yr)
        {
            double r = 0;
            r = Math.Round(Math.Sqrt(Math.Pow((double)xr - (double)xc, 2) + Math.Pow((double)yr - (double)yc, 2)));
            return Math.Abs(r);
        }

        private void CirculoDDA(int xc, int yc, double r, int Xr, int yr )
        {
              double yk=10;
            
            //Console.WriteLine(xc + yc);
            for (int xk =0; xk < yk; xk++)
            {
                yk = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(xk, 2));
                /*
                bmp.SetPixel((int)yk + xc  ,  xk+yc, Color.Red);
                bmp.SetPixel( xk + xc  ,  (int)yk + yc, Color.Red);
                bmp.SetPixel(-xk + xc  ,  (int)yk + yc, Color.Red);
                bmp.SetPixel(-(int)yk + xc  ,  xk + yc, Color.Red);
                bmp.SetPixel(-(int)yk + xc  ,  xk + yc, Color.Red);
                bmp.SetPixel(-(int)yk + xc  ,  -(xk) + yc, Color.Red);
                bmp.SetPixel(xk + xc  ,  -(int)yk + yc, Color.Red);
                bmp.SetPixel((int)yk + xc  ,  -(xk) + yc, Color.Red);
                */
            }
        }
            
        private void Midpoint(int xc, int yc, int r){

            int x = r;
            int y = 0;

            Console.WriteLine("("+ x + xc + "," + y + yc +")");

            if (r > 0)
            {
                Console.WriteLine("(" + x + xc + "," + -y + yc + ")");
                Console.WriteLine("(" + x + xc + "," + y + yc + ")");

            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
