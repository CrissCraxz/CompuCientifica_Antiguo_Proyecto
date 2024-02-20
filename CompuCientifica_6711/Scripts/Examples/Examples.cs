using CompuCientifica_6711.Scripts;
using CompuCientifica_6711.Scripts.VectorFigures;
using CompuCientifica_6711;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using CompuCientifica_6711.Scripts.VectorFigures._3D;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.ConstrainedExecution;

namespace CompuCientifica_6711.Scripts.Examples
{
    internal class Examples:Vector
    {
        Vector vector = new Vector();
        Segmento segmento = new Segmento();
        public double t; // time
        public double v; // velocity
        public double w; // vibe longitude
        public double m; // max height

        Circunferencia circ = new Circunferencia();


        //Graficaciones de los ejes
        public void Ejes(Bitmap screen, PictureBox pictureBoxScreen)
        {
            
            segmento.Xo = -8;
            segmento.Yo = 0;
            segmento.xf = 8;
            segmento.yf = 0;
            segmento.color0 = Color.Red;
            segmento.Encender(screen);
            pictureBoxScreen.Image = screen;

            segmento.Xo = 0;
            segmento.Yo = -6.15;
            segmento.xf = 0;
            segmento.yf = 6.15;
            segmento.color0 = Color.Red;
            segmento.Encender(screen);
            pictureBoxScreen.Image = screen;

        }

        //Ejercicio de Polinomio de Taylor
        public void ExampleTaylor(Bitmap screen, PictureBox pictureBoxScreen)
        {
            //y^2
            double x = -8;
            double dt = 0.001;
            double X0 = 0;
            double Y0 = 0;

            double yf = 0;
            do
            {


                vector.Xo = x;
                vector.Yo = Math.Pow(2, x);
                vector.color0 = Color.Blue;
                vector.Encender(screen);

                

                vector.Yo = 1 + 0.69 * x + 0.24 * Math.Pow(x, 2);
                vector.color0 = Color.Purple;
                vector.Encender(screen);


                // vector.Yo = 0.055 * Math.Pow(x, 3) + 0.24 * Math.Pow(x, 2) + 0.69 * x + 1;
                vector.Yo = 1 + 0.69 * x + 0.055 * Math.Pow(x, 3);
                vector.color0 = Color.Green;
                vector.Encender(screen);


                x = x + 0.001;

            } while (x <= 6);

            pictureBoxScreen.Image = screen;





        }


        public void ExampleCl2(Bitmap screen, PictureBox pictureBoxScreen)
        {

            float t = 0;
            float dt = 0.001f;
            //para hacer mas grande 
            //h
            double h = 2;
            //Vector vector = new Vector();
            // vector.Xo=2+h+Math.Cos(2*t);

            do
            {
                vector.Xo = h + Math.Sin(2 * t);
                vector.Yo = Math.Cos(3 * t);
                vector.color0 = Color.Red;
                vector.Encender(screen);
                t += dt;
            } while (t <= 2 * Math.PI);

            pictureBoxScreen.Image = screen;

        }


        public void ExampleCl(Bitmap screen, PictureBox pictureBoxScreen)
        {
            float t = 0;
            float dt = 0.001f;
            //Vector vector = new Vector();
            do
            {
                //v.xo=xo+h+formula
                vector.Xo = t / 4.0 * Math.Cos(t);
                vector.Yo = t / 4.0 * Math.Sin(t);

                vector.color0 = Color.White;
                vector.Encender(screen);

                t += dt;

            } while (t <= 20);

            pictureBoxScreen.Image = screen;

        }


        public void vectorgrafic(Bitmap screen, PictureBox pictureBoxScreen)
        {

            double vxo = 0;
            double vyo = 0;

            double t = -5;
            vector.color0 = Color.Black;
            do
            {
                vector.color0 = Color.Black;
                vector.Xo = t;
                vector.Yo = (t / 4) + 5;
                vector.Encender(screen);


                t = t + 0.0001;

            } while (t <= 5);

            pictureBoxScreen.Image = screen;

        }

        public void circunferenciaGrafic(Bitmap screen, PictureBox pictureBoxScreen)
        {
            
            circ.Rd = 4;
            circ.Xo = 0;
            circ.Yo = 0;
            circ.color0 = Color.FromArgb(14, 102, 85);
            circ.Encender(screen);
            pictureBoxScreen.Image = screen;
        }
        public void parabolaGrafic(Bitmap screen, PictureBox pictureBoxScreen)
        {
            
            double vxo = 0;
            double vyo = 0;

            double t = -5;
            vector.color0 = Color.Black;
            do
            {

                vector.Xo = t;
                vector.Yo = (49 - Math.Pow(-3, 2)) / 15;
                vector.color0 = Color.Black;
                vector.Encender(screen);


                t = t + 0.0001;

            } while (t <= 5);

            pictureBoxScreen.Image = screen;
        }

        public void segmentoGrafic(Bitmap screen, PictureBox pictureBoxScreen)
        {
            
            
            //Primer punto
            segmento.Xo = -6;
            segmento.Yo = -4;

            //Punto final
            segmento.xf = 2;
            segmento.yf = 5;
            segmento.color0 = Color.Blue;

            segmento.Encender(screen);


            segmento.Xo = 0.5;
            segmento.Yo = -6;
            //Punto final
            segmento.xf = 0.2;
            segmento.yf = 7;
            segmento.color0 = Color.Red;
            segmento.Encender(screen);
            pictureBoxScreen.Image = screen;
        }

        public void Exercise(Bitmap screen, PictureBox pictureBoxScreen)
        {


            
            //Primer punto
            segmento.Xo = -6;
            segmento.Yo = -4;

            //Segundo punto
            segmento.xf = 2;
            segmento.yf = 5;
            segmento.color0 = Color.Blue;
            segmento.Encender(screen);


            segmento.Xo = 0.5;
            segmento.Yo = -6;

            //Punto final
            segmento.xf = 0.2;
            segmento.yf = 7;


            segmento.color0 = Color.Red;
            segmento.Encender(screen);


            segmento.Xo = -6;
            segmento.Yo = -3;

            segmento.xf = 1;
            segmento.yf = -4;

            segmento.color0 = Color.Black;
            segmento.Encender(screen);


            
            circ.Rd = 1;
            circ.Xo = 0;
            circ.Yo = 0;
            circ.color0 = Color.Purple;
            circ.Encender(screen);
            pictureBoxScreen.Image = screen;

        }



        public void esphere(Bitmap screen, PictureBox pictureBoxScreen)
        {
            //Ejercicio de esferas en la pantalla
            
            circ.Rd = 0.3;
            circ.Xo = -1;
            circ.Yo = 3;
            circ.color0 = Color.Green;
            circ.Encender(screen);

            circ.Rd = 0.3;
            circ.Xo = 1;
            circ.Yo = 5;
            circ.color0 = Color.Green;
            circ.Encender(screen);

            circ.Rd = 0.3;
            circ.Xo = 3;
            circ.Yo = 2;
            circ.color0 = Color.Green;
            circ.Encender(screen);
            pictureBoxScreen.Image = screen;

        }

        public void polyTaylor(Bitmap screen, PictureBox pictureBoxScreen)
        {
            //Vector cv = new Vector();
            
            double x = 4;
            do
            {
                vector.Xo = x;

                vector.Yo = 2.48 + (1/x+8)* Math.Pow(1/x+8, 2) + Math.Pow((1/x+8),3);
                vector.color0 = Color.GreenYellow;
                vector.Encender(screen);
               
                x = x + 0.001;
            } while (x <= 5);
            pictureBoxScreen.Image = screen;
        }

        public static void LoadBasicPalet(Color[] palette0)
        {
            palette0[0] = Color.Black;
            palette0[1] = Color.Navy;
            palette0[2] = Color.Green;
            palette0[3] = Color.Aqua;
            palette0[4] = Color.Red;
            palette0[5] = Color.Purple;
            palette0[6] = Color.Maroon;
            palette0[7] = Color.LightGray;
            palette0[8] = Color.DarkGray;
            palette0[9] = Color.Blue;
            palette0[10] = Color.Lime;
            palette0[11] = Color.Silver;
            palette0[12] = Color.Teal;
            palette0[13] = Color.Fuchsia;
            palette0[14] = Color.Yellow;
            palette0[15] = Color.White;
            // palette0[16] = Color.FromArgb(red,green,b);
        }

        public void mapping1(Bitmap screen, PictureBox pictureBoxScreen)
        {
            Color[] paleta0 = new Color[16];
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.FromArgb(132, 60, 11);
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            double colorT;
            Color c;

            Bitmap bmp = new Bitmap(pictureBoxScreen.Width, pictureBoxScreen.Height);

            int width = pictureBoxScreen.Width;
            int height = pictureBoxScreen.Height;

            for (int x = 0; x < width; x++)
            {

                for (int y = 0; y < height; y++)
                {
                    colorT = (x * x + y * y) % 15;

                    c = paleta0[(int)colorT];
                    bmp.SetPixel(x, y, c);
                }
            }


            pictureBoxScreen.Image = bmp;
        }

        public void mapping2(Bitmap screen, PictureBox pictureBoxScreen)
        {
            Color[] paleta0 = new Color[16];
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.FromArgb(132, 60, 11);
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            double colorT;
            Color c;

            Bitmap bmp = new Bitmap(pictureBoxScreen.Width, pictureBoxScreen.Height);

            int width = pictureBoxScreen.Width;
            int height = pictureBoxScreen.Height;

            for (int x = 0; x < width; x++)
            {

                for (int y = 0; y < height; y++)
                {
                    colorT = (x * (Math.Pow(2, x)) + y * y) % 15;

                    c = paleta0[(int)colorT];
                    bmp.SetPixel(x, y, c);
                }
            }


            pictureBoxScreen.Image = bmp;

        }

        public void mapping3(Bitmap screen, PictureBox pictureBoxScreen)
        {
            Color[] paleta0 = new Color[16];
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.FromArgb(132, 60, 11);
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            double colorT;
            Color c;

            Bitmap bmp = new Bitmap(pictureBoxScreen.Width, pictureBoxScreen.Height);

            int width = pictureBoxScreen.Width;
            int height = pictureBoxScreen.Height;

            for (int x = 0; x < width; x++)
            {

                for (int y = 0; y < height; y++)
                {
                    colorT = (x * x + y * y) % 15;

                    c = paleta0[(int)colorT];
                    bmp.SetPixel(x, y, c);
                }
            }


            pictureBoxScreen.Image = bmp;
        }

        public void mapping4(Bitmap screen, PictureBox pictureBoxScreen)
        {
            Color[] paleta0 = new Color[16];
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.FromArgb(132, 60, 11);
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            double colorT;
            Color color;

            Bitmap bmp = new Bitmap(pictureBoxScreen.Width, pictureBoxScreen.Height);

            int width = pictureBoxScreen.Width;
            int height = pictureBoxScreen.Height;

            for (int x = 0; x < width; x++)
            {

                for (int y = 0; y < height; y++)
                {
                    colorT = ( x + y * Math.Pow(2,y)) % 15;

                    color = paleta0[(int)colorT];
                    bmp.SetPixel(x, y, color);

                    color = paleta0[(int)colorT % 15];
                    bmp.SetPixel(x, y, color);
                }
            }


            pictureBoxScreen.Image = bmp;
        }

        public void mapping5(Bitmap screen, PictureBox pictureBoxScreen)
        {
            Color[] paleta0 = new Color[16];
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.FromArgb(132, 60, 11);
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            double colorT;
            Color c;

            Bitmap bmp = new Bitmap(pictureBoxScreen.Width, pictureBoxScreen.Height);

            int width = pictureBoxScreen.Width;
            int height = pictureBoxScreen.Height;

            for (int x = 0; x < width; x++)
            {

                for (int y = 0; y < height; y++)
                {
                    colorT = (Math.Pow(2,x) - x + y * y) % 15;

                    c = paleta0[(int)colorT];
                    bmp.SetPixel(x, y, c);
                }
            }


            pictureBoxScreen.Image = bmp;
        }

        public void mapping6(Bitmap screen, PictureBox pictureBoxScreen)
        {
            Color[] paleta0 = new Color[16];
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.FromArgb(132, 60, 11);
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            double colorT;
            Color c;

            Bitmap bmp = new Bitmap(pictureBoxScreen.Width, pictureBoxScreen.Height);

            int width = pictureBoxScreen.Width;
            int height = pictureBoxScreen.Height;

            for (int x = 0; x < width; x++)
            {

                for (int y = 0; y < height; y++)
                {
                    colorT = (Math.Sqrt( x) + y*y ) % 15;

                    c = paleta0[(int)colorT];
                    bmp.SetPixel(x, y, c);
                }
            }


            pictureBoxScreen.Image = bmp;
        }

        //wood
        public void mapping7(Bitmap screen, PictureBox pictureBoxScreen)
        {
            Color[] paleta0 = new Color[16];
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.FromArgb(132, 60, 11);
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            double colorT;
            Color c;

            Bitmap bmp = new Bitmap(pictureBoxScreen.Width, pictureBoxScreen.Height);

            int width = pictureBoxScreen.Width;
            int height = pictureBoxScreen.Height;


            for(int i= 0; i <16; i++)
            {
                paleta0[i]= Color.FromArgb((int)(2.46*i+133),(int)(100+2*i),0);
            }

            for (int x = 0; x < width; x++)
            {

                for (int y = 0; y < height; y++)
                {
                    colorT = (Math.Sqrt(x) + y * y) % 15;

                    c = paleta0[(int)colorT];
                    bmp.SetPixel(x, y, c);
                }
            }


            pictureBoxScreen.Image = bmp;
        }

        //Mapping homework 
        public void mapping8(Bitmap screen, PictureBox pictureBoxScreen)
        {
            Color[] paleta0 = new Color[16];
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.FromArgb(132, 60, 11);
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            double colorT;
            Color c;

            Bitmap bmp = new Bitmap(pictureBoxScreen.Width, pictureBoxScreen.Height);

            int width = pictureBoxScreen.Width;
            int height = pictureBoxScreen.Height;


            for (int i = 0; i <= 15; i++)
            {
                paleta0[i] = Color.FromArgb((int)((1.4) * (i) + 138.9), (int)((0.86) * (i) + 69), (int)((1.74) * (i) + 18.9));
            }

           
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 540; j++)
                {


                    colorT = Math.Abs((int)(Math.Sqrt(i * i + j * j)) % 15);
                    bmp.SetPixel(i, j, paleta0[(int)colorT]);
                   
                }
            }




            pictureBoxScreen.Image = bmp;
        }

        public void mapping9(Bitmap screen, PictureBox pictureBoxScreen)
        {
            Color[] paleta0 = new Color[16];
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.FromArgb(132, 60, 11);
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;
            paleta0 = new Color[16];


            double colorT;
            Color c;

            Bitmap bmp = new Bitmap(pictureBoxScreen.Width, pictureBoxScreen.Height);

            int width = pictureBoxScreen.Width;
            int height = pictureBoxScreen.Height;


            paleta0[0] = Color.FromArgb(0, 150, 0);
            paleta0[15] = Color.FromArgb(97, 255, 97);
            for (int i = 0; i < 15; i++)
            {
             double   valored = (int)(6.47 * i);
             double   valorgreen = (int)((7 * i) + 150);
             double   valorblue = (int)(6.47 * i);
                paleta0[i] = Color.FromArgb((int)valored, (int)valorgreen, (int)valorblue);
            }
        

            for (int j = 0; j < 700; j++)
            {
                for (int i = 0; i < 540; i++)
                {
                    colorT = (int)((i + i * j + j) * (Math.Sqrt(j) + Math.Sqrt(i)) % 15);
                    c = paleta0[(int)colorT];
                    bmp.SetPixel(j, i, c);
                }
            }


            pictureBoxScreen.Image = bmp;
        }

        public void mapping10(Bitmap screen, PictureBox pictureBoxScreen)
        {
            Color[] paleta0 = new Color[16];
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.FromArgb(132, 60, 11);
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;
            paleta0 = new Color[16];


            double colorT;
            Color c;

            Bitmap bmp = new Bitmap(pictureBoxScreen.Width, pictureBoxScreen.Height);

            int width = pictureBoxScreen.Width;
            int height = pictureBoxScreen.Height;
            int i, j;

            for ( i = 0; i < 15; i++)
            {
                paleta0[0] = Color.FromArgb((int)((10.87 * i) + 80), (int)((10.87 * i) + 80), (int)(10.86 * i) + 70);
            }


            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 540; j++)
                {

                    colorT = (int)(Math.Pow(i, Math.Sin(3 * i) * Math.Cos(3 * j)) + i * j) % 15;
                    c = paleta0[(int)colorT];
                    bmp.SetPixel(i, j, c);

                }
            }



            pictureBoxScreen.Image = bmp;
        }

        //parable and position
        public void parable(Bitmap screen, PictureBox pictureBoxScreen)
        {
            //fase 1
            vector.color0 = Color.Red;
            double t = -8;
            do
            {
                vector.Xo = t;
                vector.Yo = (49 - Math.Pow(t, 2)) / 15;
                vector.Encender(screen);
                t = t + 0.001;
            } while (t <= 8);
            pictureBoxScreen.Image = screen;




            // fase 2
            vector.color0 = Color.Blue;
            double t1 = -8;
            do
            {
                vector.Xo = t1;
                vector.Yo = (19 - Math.Pow(t1, 2)) / 15;
                vector.Encender(screen);
                t1 = t1 + 0.005;
            } while (t1 <= 8);
            pictureBoxScreen.Image = screen;

            //FASE 3
            circ.Rd = 0.2;
            double x = -8;

            do
            {
                circ.Xo = x;
                circ.Yo = (30-Math.Pow(x, 2)) / 15;
                circ.color0 = Color.Black;
                circ.Encender(screen);

                x = (x + 0.17);
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(30);
               
                circ.Encender(screen);
                pictureBoxScreen.Image = screen;
                circ.Apagar(screen);


            }
            while (x <= 8);
          





            //extender rayo hasta el fin del diseño
        }

        public void vectorG(Bitmap screen,double t,PictureBox pictureBoxScreen)
        {
            double vxo = 0;
            double vyo = 0;

             
            vector.color0 = Color.Black;
            do
            {
                vector.color0 = Color.Black;
                vector.Xo = t;
                vector.Yo = (t / 4) + 5;
                vector.Encender(screen);


                t = t + 0.0001;

            } while (t <= 5);



            //animated
            // rd= 07
            circ.Rd = 0.2;
            double x = -3;

            do
            {
                circ.Xo = x;
                circ.Yo = (10 - Math.Pow(t, 2)) / 15;
                circ.color0 = Color.Blue;
                circ.Encender(screen);

                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);
                pictureBoxScreen.Image = screen;
                circ.Apagar(screen);

                x += 0.2;
            }
            while (x < 7);

        }

        public void circuferenceG(Bitmap screen, double Rd)
        {
            circ.Rd= Rd;
            circ.Xo = 0;
            circ.Yo = 0;
            circ.color0 = Color.FromArgb(14, 102, 85);
            circ.Encender(screen);
            
        }

        public void Animated(Bitmap screen,PictureBox pictureBoxScreen )
        {

            //vectorG(screen,-4);
            
            pictureBoxScreen.Image = screen;

            circuferenceG(screen,4);
            pictureBoxScreen.Image = screen;

            Thread.Sleep(20);


           // vectorG(screen, -3);

           // pictureBoxScreen.Image = screen;

          //  pictureBoxScreen.Image = screen;

            circuferenceG(screen, 3);
            pictureBoxScreen.Image = screen;
        }

        public async void Animated1(Bitmap screen, PictureBox pictureBoxScreen)
        {
            // rd= 07
            circ.Rd = 0.7;
            double x;
            x = -7;
            do
            {
                circ.Xo = x;
                circ.color0 = Color.Blue;
                circ.Yo = Math.Pow(2, x);
                circ.Encender(screen);
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);
                circ.Yo = -Math.Pow(2, x);
                circ.Encender(screen);
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);
                circ.Yo = -Math.Sin(x)+ Math.Cos(x);
                circ.Encender(screen);
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);
                pictureBoxScreen.Image = screen;
                circ.Apagar(screen);
                x = x + 0.2;
            }
            while (x < 7);
        }

        public async void Animated2(Bitmap screen, PictureBox pictureBoxScreen)
        {
            const double EarthRadius = 0.7;
            const double EarthRotationSpeed = 0.2;
            const double OvalRadiusX = 2.0;
            const double OvalRadiusY = 1.0;
            const double OvalRotationSpeed = 0.1;

            double x = -7;
            do
            {
                double earthX = EarthRadius * Math.Cos(x);
                double earthY = EarthRadius * Math.Sin(x);

                // Incrementar el grosor de la circunferencia
                double thickness = Math.Abs(earthY) * 10;

                // Establecer el grosor de la circunferencia
                circ.Grosor = (int)thickness;

                // Establecer las coordenadas y el color de la circunferencia
                circ.Xo = earthX;
                circ.Yo = earthY;
                circ.color0 = Color.Blue;

                // Encender la circunferencia en la posición actual
                circ.Encender(screen);

                // Esperar un tiempo para la animación
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);

                // Actualizar la posición de rotación de la Tierra
                x += EarthRotationSpeed;

                // Apagar la circunferencia
                circ.Apagar(screen);

                // Actualizar la imagen del PictureBox para mostrar los cambios
                pictureBoxScreen.Image = screen;
            }
            while (x < 7);

            x = -7;
            do
            {
                double ovalX = OvalRadiusX * Math.Cos(x);
                double ovalY = OvalRadiusY * Math.Sin(x);

                // Establecer el grosor de la circunferencia para la segunda rotación
                double thickness = Math.Abs(ovalY) * 10;

                // Establecer el grosor de la circunferencia
                circ.Grosor = (int)thickness;

                // Establecer las coordenadas y el color de la circunferencia para la segunda rotación
                circ.Xo = ovalX;
                circ.Yo = ovalY;
                circ.color0 = Color.Red;

                // Encender la circunferencia en la posición actual
                circ.Encender(screen);

                // Esperar un tiempo para la animación
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);

                // Actualizar la posición de la segunda rotación
                x += OvalRotationSpeed;

                // Apagar la circunferencia
                circ.Apagar(screen);

                // Actualizar la imagen del PictureBox para mostrar los cambios
                pictureBoxScreen.Image = screen;
            }
            while (x < 7);
        }


        public async void Animated3(Bitmap screen, PictureBox pictureBoxScreen)
        {
            // rd= 07
            circ.Rd = 0.7;
            double x;
            x = -7;
            do
            {
                circ.Xo = x;
                circ.Yo = -(Math.Pow(x, 2) - 9) / 10;
                circ.color0 = Color.Red;
                circ.Encender(screen);

                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(30);


                pictureBoxScreen.Image = screen;
                x = x + 0.15;
                circ.Apagar(screen);

            } while (x <= 7);
        }


        public async void Animated4(Bitmap screen, PictureBox pictureBoxScreen)
        {
            // rd= 07
            circ.Rd = 0.2;
            double x = -7;

            do
            {
                // Definir las coordenadas de los vértices del triángulo
                double vertex1X = x;
                double vertex1Y = Math.Pow(2, x);
                double vertex2X = x + 0.5;
                double vertex2Y = 0;
                double vertex3X = x - 0.5;
                double vertex3Y = 0;

                // Encender los segmentos del triángulo
                circ.Xo = vertex1X;
                circ.Yo = vertex1Y;
                circ.color0 = Color.Blue;
                circ.Encender(screen);

                circ.Xo = vertex2X;
                circ.Yo = vertex2Y;
                circ.color0 = Color.Blue;
                circ.Encender(screen);

                circ.Xo = vertex3X;
                circ.Yo = vertex3Y;
                circ.color0 = Color.Blue;
                circ.Encender(screen);

                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);

                pictureBoxScreen.Image = screen;

                // Apagar los segmentos del triángulo
                circ.Xo = vertex1X;
                circ.Yo = vertex1Y;
                circ.Apagar(screen);

                circ.Xo = vertex2X;
                circ.Yo = vertex2Y;
                circ.Apagar(screen);

                circ.Xo = vertex3X;
                circ.Yo = vertex3Y;
                circ.Apagar(screen);

                x += 0.2;
            }
            while (x < 7);
        }


        public async void Animated5(Bitmap screen, PictureBox pictureBoxScreen)
        {
            // rd= 07
            circ.Rd = 0.2;
            double x = -3;

            do
            {
                circ.Xo = x;
                circ.Yo = -Math.Abs(x+2);
                circ.color0= Color.Blue;
                circ.Encender(screen);

                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);
                pictureBoxScreen.Image = screen;
                circ.Apagar(screen);

                x += 0.2;
            }
            while (x < 7);
        }





        public void parableAn(Bitmap screen, PictureBox pictureBoxScreen)
        {

            // Fase 1
            Vector vector = new Vector();

            vector.color0 = Color.Red;
            double dt = 0.0001;
            double t1 = 0;
            double t2 = 5;
            double t = -7;


            do
            {
                vector.Xo = t;
                vector.Yo = -((t + 7) * (t - 0)) / 7;

                vector.Encender(screen);
                t = t + dt;
            } while (t <= 0);

            // Fase 2
            Vector vector1 = new Vector();
            vector1.color0 = Color.Blue;
            
            do
            {
                vector1.Xo = t1;
                vector1.Yo = -((t1 + 0) * (t1 - 4)) / 5;

                vector1.Encender(screen);
                t1 = t1 + dt;
            } while (t1 <= 4);
            pictureBoxScreen.Image = screen;

            // Fase 3
            

            do
            {
                vector.Xo = t2;
                vector.Yo = -((t2 - 5) * (t2 - 8)) / 5;
                vector.color0 = Color.Green;
                vector.Encender(screen);
                t2 = t2 + dt;
            } while (t2 <= 7);
            pictureBoxScreen.Image = screen;


            // rd= 07
            circ.Rd = 0.2;
            t = -6;
            do
            {
                circ.Xo = t;
                circ.Yo = -((t + 6) * (t - 0)) / 6;
                circ.color0 = Color.Blue;
                circ.Encender(screen);

                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);
                pictureBoxScreen.Image = screen;
                circ.Apagar(screen);

                t += 0.2;
            }
            while (t < 0);

             t1 = 0;

            do
            {
                circ.Xo = t1;
                circ.Yo = -((t1 + 0) * (t1 - 4)) / 5;
                circ.color0 = Color.Blue;
                circ.Encender(screen);

                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);
                pictureBoxScreen.Image = screen;
                circ.Apagar(screen);

                t1 += 0.2;
            }
            while (t1 < 4);

             t2 = 4;


            do
            {
                circ.Xo = t2;
                circ.Yo = -((t2 - 4) * (t2 - 7)) / 4;
                circ.color0 = Color.Blue;
                circ.Encender(screen);

                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);
                pictureBoxScreen.Image = screen;
                circ.Apagar(screen);

                t2 += 0.2;
            }
            while (t2 < 7);



        }



        //interferencia con 3 fuentes 
        public void OndaInterferencia3(Bitmap screen, PictureBox pictureBoxScreen)
        {


        int color0, r, g, b;
            double x, y, z, z1, z2, z3;
            Color color;
            Color[] palette = new Color[16];
            Color[] paletteE = new Color[16];
            for (int i = 0; i <= 15; i++)
            {
                r = (int)(8.66 * i + 100);
                g = (int)(8.66 * i + 100);
                b = (int)(7.66 * i + 105);
                paletteE[i] = Color.FromArgb(r, g, b);
            }

            palette[0] = Color.Black;
            palette[1] = Color.Navy;
            palette[2] = Color.Green;
            palette[3] = Color.Aqua;
            palette[4] = Color.Red;
            palette[5] = Color.Purple;
            palette[6] = Color.Maroon;
            palette[7] = Color.LightGray;
            palette[8] = Color.DarkGray;
            palette[9] = Color.Blue;
            palette[10] = Color.Lime;
            palette[11] = Color.Silver;
            palette[12] = Color.Teal;
            palette[13] = Color.Fuchsia;
            palette[14] = Color.Yellow;
            palette[15] = Color.White;

            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    transform(i, j, out x, out y);
                    x += 0;
                    y += 2;

                    z1 = w * Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y + 3, 2)) - v * t;

                    x += 0; y = -3;
                    z2 = w * Math.Sqrt((x - 0) * (x - 0) + Math.Pow(y - 3, 2)) - v * t;

                    x += 0; y = +7;
                    z3 = w * Math.Sqrt((x - 0) * (x - 0) + Math.Pow(y - 3, 2)) - v * t;


                    //z3 = w * (Math.Sqrt((x - 3) * (x - 3) + (y + 1) * (y + 1)) - (v * t));
                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;
                    z = z1 + z2 + z3;
                    color0 = (int)(z * 2.5); // adjust to array color palette [0 : 15]
                    color = palette[color0];
                    screen.SetPixel(i, j, color);
                }
            }
            pictureBoxScreen.Image = screen;
        }


        //interferencia do ondas 
        public void OndaInterferencia2(Bitmap screen, PictureBox pictureBoxScreen)
        {
            {
                int color0, r, g, b;
                double x, y, z, z1, z2, z3;
                Color color;
                Color[] palette = new Color[16];
                //Color[] paletteE = new Color[16];
                //for (int i = 0; i <= 15; i++)
                //{
                //    r = (int)(8.66 * i + 100);
                //    g = (int)(8.66 * i + 100);
                //    b = (int)(7.66 * i + 105);
                //    paletteE[i] = Color.FromArgb(r, g, b);
                //}

                palette[0] = Color.Black;
                palette[1] = Color.Navy;
                palette[2] = Color.Green;
                palette[3] = Color.Aqua;
                palette[4] = Color.Red;
                palette[5] = Color.Purple;
                palette[6] = Color.Maroon;
                palette[7] = Color.LightGray;
                palette[8] = Color.DarkGray;
                palette[9] = Color.Blue;
                palette[10] = Color.Lime;
                palette[11] = Color.Silver;
                palette[12] = Color.Teal;
                palette[13] = Color.Fuchsia;
                palette[14] = Color.Yellow;
                palette[15] = Color.White;

                for (int i = 0; i < 700; i++)
                {
                    for (int j = 0; j < 500; j++)
                    {
                        transform(i, j, out x, out y);
                        x += 5;
                        y -= 5;

                        z1 = w * Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y + 3, 2)) - v * t;


                        z2 = w * Math.Sqrt((x - 0) * (x - 0) + Math.Pow(y - 3, 2)) - v * t;
                        x -= 3; y += 5;

                        //z3 = w * (Math.Sqrt((x - 3) * (x - 3) + (y + 1) * (y + 1)) - (v * t));
                        z1 = Math.Sin(z1) + 1;
                        z2 = Math.Sin(z2) + 1;

                        z = z1 + z2;
                        color0 = (int)(z * 2.5); // adjust to array color palette [0 : 15]
                        color = palette[color0];
                        screen.SetPixel(i, j, color);
                    }
                }
            }
            pictureBoxScreen.Image = screen;
        }


        public void OndaTiempo(Bitmap screen, PictureBox pictureBoxScreen)
        {
            double t0 = 0;
            
            do
            {
                t = t0;
                int i, j, color0;
                double x, y, z;
                Color[] palette = new Color[16];
                Color color;

                palette[0] = Color.Black;
                palette[1] = Color.Navy;
                palette[2] = Color.Green;
                palette[3] = Color.Aqua;
                palette[4] = Color.Red;
                palette[5] = Color.Purple;
                palette[6] = Color.Maroon;
                palette[7] = Color.LightGray;
                palette[8] = Color.DarkGray;
                palette[9] = Color.Blue;
                palette[10] = Color.Lime;
                palette[11] = Color.Silver;
                palette[12] = Color.Teal;
                palette[13] = Color.Fuchsia;
                palette[14] = Color.Yellow;
                palette[15] = Color.White;

                int xOffset = 200; // Desplazamiento en el eje x
                int yOffset = 100; // Desplazamiento en el eje y

                for (i = 0; i < 700; i++)
                {
                    for (j = 0; j < 540; j++)
                    {
                        transform(i + xOffset, j + yOffset, out x, out y);
                        z = w * (Math.Sqrt(x * x + y * y)) - v * t;
                        z = Math.Sin(z) + 1;
                        color0 = (int)(z * 7.5);
                        color = palette[color0];
                        screen.SetPixel(i, j, color);
                    }
                }

                t0 = t0 + 0.1;
            } while (t0 <=7);

        }


        public async void trazoSeg(Bitmap screen, PictureBox pictureBoxScreen)
        {
            //linea principal

            pictureBoxScreen.Image = screen;
            //tringulo principal
            //primera linea
            segmento.xf = 0;
            segmento.yf = 0.6;
            segmento.Xo = -0.8;
            segmento.Yo = 0;
            segmento.color0 = Color.Black;
            segmento.Encender(screen);
            pictureBoxScreen.Image = screen;
            //segunda linea
            segmento.xf = 0;
            segmento.yf = -0.6;
            segmento.Xo = -0.8;
            segmento.Yo = 0;
            segmento.color0 = Color.Black;
            segmento.Encender(screen);
            pictureBoxScreen.Image = screen;

            //tercera linea
            segmento.xf = 0;
            segmento.yf = 0.6;
            segmento.Xo = 0;
            segmento.Yo = -0.6;
            segmento.color0 = Color.Black;
            segmento.Encender(screen);
            pictureBoxScreen.Image = screen;


            // Lado contrario

            //tringulo principal
            //primera linea
            segmento.xf = 6;
            segmento.yf = 0.6;
            segmento.Xo = 6.8;
            segmento.Yo = 0;
            segmento.color0 = Color.Black;
            segmento.Encender(screen);
            pictureBoxScreen.Image = screen;
            //segunda linea
            segmento.xf = 6;
            segmento.yf = -0.6;
            segmento.Xo = 6;
            segmento.Yo = 0.6;
            
            segmento.color0 = Color.Black;
            segmento.Encender(screen);
            pictureBoxScreen.Image = screen;

            //tercera linea
            segmento.xf = 6;
            segmento.yf = -0.6;
            segmento.Xo = 6.8;
            segmento.Yo = 0;
            segmento.color0 = Color.Black;
            segmento.Encender(screen);
            pictureBoxScreen.Image = screen;

           
            


            
        }




    }
}
