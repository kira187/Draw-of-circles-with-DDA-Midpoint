using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //libreria para medir tiempo de ejecucion

namespace Drawn_Of_Circle
{
    public partial class Form1 : Form
    {

        Point Punto_C;
        Point Punto_R;

        Pen pen = new Pen(Color.Red, 1);
        Pen pen2 = new Pen(Color.Blue, 1);

        Stopwatch sw_dda = new Stopwatch();
        Stopwatch sw_midpoint = new Stopwatch();

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

            xc = Punto_C.X;
            yc = Punto_C.Y;

            xr = Punto_R.X;
            yr = Punto_R.Y;

            panel1.CreateGraphics().DrawEllipse(pen, xc, yc, 5, 5);
            panel1.CreateGraphics().DrawEllipse(pen, xr, yr, 5, 5);
        }

        private void CirculoDDA(int xc, int yc, double r, int Xr, int yr )
        {
            sw_dda.Start();
            double yk=0;
            
            for (int xk =0; xk <= yk; xk++)
            {
                yk = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(xk, 2));

                panel1.CreateGraphics().DrawEllipse(pen, (int)yk + xc, -(xk) + yc, 5, 5);     
                panel1.CreateGraphics().DrawEllipse(pen, xk + xc, -(int)yk + yc, 5, 5);       
                panel1.CreateGraphics().DrawEllipse(pen, -(xk) + xc, -(int)yk + yc, 5, 5);    
                panel1.CreateGraphics().DrawEllipse(pen, -(int)yk + xc, -(xk) + yc, 5, 5);    
                panel1.CreateGraphics().DrawEllipse(pen, -(int)yk + xc, xk + yc, 5, 5);       
                panel1.CreateGraphics().DrawEllipse(pen, -(xk) + xc, (int)yk + yc, 5, 5);     
                panel1.CreateGraphics().DrawEllipse(pen, xk + xc, (int)yk + yc, 5, 5);        
                panel1.CreateGraphics().DrawEllipse(pen, (int)yk + xc, xk + yc, 5, 5);        
            }
            lbltimedda.Text = String.Format("{0}", sw_dda.Elapsed.TotalSeconds);
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
                Midpoint(xc, yc, r);
                CrearCoordenada();

                xc = 0;

            }
        }

        private void Midpoint(int xc, int yc, double r)
        {
            sw_midpoint.Start();

            int x = (int)r, y = 0;
            int P = 1 - (int)r;

            while (x > y)
            {
                y++;
                
                //dentro de la circunferecia
                if (P <= 0)
                {
                    P = P + 2 * y + 1;
                }
                //fuera de la circunferencia
                else
                {
                    x--;
                    P = P + 2 * y - 2 * x + 1;
                }

                //graficacion en y
                panel1.CreateGraphics().DrawEllipse(pen2, x + xc, y + yc, 5, 5);
                panel1.CreateGraphics().DrawEllipse(pen2, -x + xc, y + yc, 5, 5);
                panel1.CreateGraphics().DrawEllipse(pen2, x + xc, -y + yc, 5, 5);
                panel1.CreateGraphics().DrawEllipse(pen2, -x + xc, -y + yc, 5, 5);
                
                //graficacion en x
                if (x != y)
                {
                    panel1.CreateGraphics().DrawEllipse(pen2, y + xc, x + yc, 5, 5);
                    panel1.CreateGraphics().DrawEllipse(pen2, -y + xc, x + yc, 5, 5);
                    panel1.CreateGraphics().DrawEllipse(pen2, y + xc, -x + yc, 5, 5);
                    panel1.CreateGraphics().DrawEllipse(pen2, -y + xc, -x + yc, 5, 5);
                }
            }
            lbltimemidpoint.Text = String.Format("{0}", sw_midpoint.Elapsed.TotalSeconds);
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
