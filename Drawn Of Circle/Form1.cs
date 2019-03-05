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
        Pen pen = new Pen(Color.Tomato, 1);

        double r = 0;
        int xc, yc;
        int xr, yr;

        private void btn_clear_Click(object sender, EventArgs e)
        {
           
            lbltimedda.Text = "00 : 00";
            lbltimemidpoint.Text = "00 : 00";
            lblcoordenadaC.Text = "(00 , 00)";
            lblcoordenadaR.Text = "(00 , 00)";
            lblradio.Text = "0";
            panel1.Refresh();
        }

        private void CrearCoordenada()
        {
            int xc, yc, xr, yr;
            //Pen pen = new Pen(Color.Tomato, 3);

            xc = Punto_C.X;
            yc = Punto_C.Y;

            xr = Punto_R.X;
            yr = Punto_R.Y;

            panel1.CreateGraphics().DrawEllipse(pen, xc, yc, 2, 2);
            panel1.CreateGraphics().DrawEllipse(pen, xr, yr, 2, 2);
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

                panel1.CreateGraphics().DrawRectangle(pen, (int)yk + xc, xk + yc, 5, 5);//(y,x)           8 Octante
                panel1.CreateGraphics().DrawRectangle(pen, xk + xc, (int)yk + yc, 5, 5);//(x,y)           7 Octante
                panel1.CreateGraphics().DrawRectangle(pen, -(xk) + xc, (int)yk + yc, 5, 5);//(-x,y)         6 Octante
                panel1.CreateGraphics().DrawRectangle(pen, -(int)yk + xc, xk + yc, 5, 5);//(-y,x)      5 Octante
                panel1.CreateGraphics().DrawRectangle(pen, -(int)yk + xc, -(xk) + yc, 5, 5);//(-y,-x)   4 Octante
                panel1.CreateGraphics().DrawRectangle(pen, -(xk) + xc, -(int)yk + yc, 5, 5);//(-x,-y)   3 Octante
                panel1.CreateGraphics().DrawRectangle(pen, xk + xc, -(int)yk + yc, 5, 5);//(x,-y)      2 Octante
                panel1.CreateGraphics().DrawRectangle(pen, Convert.ToInt64(yk) + xc, -(xk) + yc, 5, 5);//(y,-x)       1 Octante
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
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

                CirculoDDA(xc, yc, r, xr, yr);
                CrearCoordenada();

                xc = 0;

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
