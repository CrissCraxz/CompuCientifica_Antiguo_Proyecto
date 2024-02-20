using CompuCientifica_6711.Scripts.VectorFigures._3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompuCientifica_6711.Scripts.VectorFigures._2D
{
    internal class Onda : Vector
    {
        public double t; // time
        public double v; // velocity
        public double w; // vibe longitude
        public double m; // max height

        public Onda() { }
        public void GrafO(Bitmap screen)
        {
            int color0, r, g, b;
            double x, y, z;
            Color color;
            Color[] palette = new Color[16];
            int i;
            int j;

            //color nuevo de la onda
            Color[] paletteE = new Color[16];
            for ( i = 0; i <= 15; i++)
            {
                r = (int)(0);
                g = (int)(17 * i );
                b = (int)((14/3) * i + 50);
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





            for (i = 0; i<700;i++)
            {
                for (j = 0; j<540; j++)
                {
                    transform(i,j, out x, out y);
                    z = w * (Math.Sqrt(x * x + y * y) - (v * t));
                    z =  Math.Sin(z) + 1;
                    color0 = (int)(z * 7.5); // adjust to array color palette [0 : 15]
                    color = paletteE[color0];
                    screen.SetPixel(i, j, color);
                }
            }

        }

        // cambiando la fuente de origen
        public virtual void GrafOnda1(Bitmap pixelVec)
        {
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
                    pixelVec.SetPixel(i, j, color);
                }
            }
          
        }

        public virtual void InterferenciaGr(Bitmap screen)
        {
            int i, j, color0;
            double x, y, z, z1, z2;
            Color color;
            Color[] palette = new Color[16];
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

            for (i =0; i < 700; i++)
            {
                for (j = 0; j < 540; j++)
                {
                    transform(i, j,out x,out y);
                    z1 = w * Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y + 3, 2)) - v * t;

                    z2 = w * Math.Sqrt((x - 0) * (x - 0) + Math.Pow(y - 3, 2)) - v * t;
                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z = z1 + z2;

                    color0 = (int)(z * 3.75); // adjust to array color palette [0 : 15]
                    color = palette[color0];
                    screen.SetPixel(i, j, color);
                }
            }
        }


        public virtual void OndaTiempo(Bitmap screen)
        {
            int i, j, color0;
            double x, y, z;
            Color[] palette = new Color[16];
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

            Color color;

            for (i = 0; i < 700; i++)
            {
                        for (j = 0; j < 540; j++)
                        {
                            transform(i , j , out x, out y);
                            z = w * (Math.Sqrt(x * x + y * y)) - v * t;
                            z = Math.Sin(z) + 1;
                            color0 = (int)(z * 7.5);
                            color = palette[color0];
                            screen.SetPixel(i, j, color);
                        }
            }



            
        }


        public async void Onda3D(Bitmap viewPort)
        {
            Vector3D v3D = new Vector3D();
            double x, y, z, d;

            x = -7;
            do
            {
                y = -6;
                do
                {
                    //d = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y - 3), 2))));
                    d = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 3), 2))));
                    z = w * (d - v * t);
                    z = 0.4 * Math.Sin(z);


                    v3D.Xo = x;
                    v3D.Yo = y;
                    v3D.Z0 = z;
                    v3D.color0 = Color.Blue;
                    v3D.Encender(viewPort);
                    y += 0.2;


                } while (y <= 6);
                x += 0.2;
            } while (x <= 7);
        }


        public async void Onda3DC(Bitmap viewPort)
        {

            Vector3D v3D = new();
            double x, y, z, d;
            x = -7;
            do
            {
                y = -6;
                do
                {
                    v3D.color0 = Color.Red;
                    v3D.Xo = x + 2;
                    v3D.Yo = y;
                    v3D.Z0 = (0.4 * Math.Sin(w * (Math.Sqrt((x - 3) * (x - 3) + y * y) - v *
                    t)));
                    v3D.color0 = Color.Black;
                    v3D.Encender(viewPort);
                    y += 0.2;
                } while (y <= 6);
                x += 0.2;
            } while (x <= 7);
        }

        public void Interferecia3D_2f(Bitmap viewPort)
        {
            Vector3D v3D1 = new();
            double x, y, z1, z2, z3, d1, d2;

            x = -7;
            do
            {
                y = -6;
                do
                {
                    z1 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y - 3), 2))));
                    z1 = w * (z1 - v * t);
                    //z1 = (m) * Math.Sin(z1);
                    z2 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 3), 2))));
                    z2 = w * (z2 - v * t);
                    
                    v3D1.Xo = x;
                    v3D1.Yo = y;
                    v3D1.Z0 = 0.4 * Math.Sin(z1) + 0.4 * Math.Sin(z2);
                    v3D1.color0 = color0;
                    v3D1.Encender(viewPort);
                    y += 0.1;
                } while (y <= 6);
                x += 0.1;
            } while (x <= 7);
        }


        public void Interferecia3D_2fv1(Bitmap viewPort)
        {
            Vector3D v3D1 = new();
            double x, y, z1, z2, z3, d1, d2;

            x = -9;
            do
            {
                y = -6.5;
                do
                {
                    d1 = Math.Sqrt((x - 0) * (x - 0) + (y - 3) * (y - 3));
                    z1 = w * (d1 - (t * v));
                    z1 = (m) * Math.Sin(z1);

                    d2 = Math.Sqrt((x - 0) * (x - 0) + (y + 3) * (y + 3));
                    z2 = w * (d2 - (t * v));
                    z2 = (m) * Math.Sin(z2);

                    v3D1.Xo = x;
                    v3D1.Yo = y;
                    v3D1.Z0 = z1 + z2;
                    v3D1.color0 = color0;
                    v3D1.Encender(viewPort);
                    y += 0.1;
                } while (y <= 6.5);
                x += 0.1;
            } while (x <= 9);
        }


        public async void Onda3DL(Bitmap viewPort)
        {

            Vector3D v3D = new();
            double x, y, z, d;

            x = -7;
            do
            {
                y = -6;
                do
                {

                    v3D.color0 = Color.Red;

                    v3D.Xo = x + 2;
                    v3D.Yo = y;
                    v3D.Z0 = (0.4 * Math.Sin(w * (Math.Sqrt((x - 3) * (x - 3) + y * y) - v * t)));

                    v3D.color0 = Color.Black;
                    v3D.Encender(viewPort);

                    y += 0.2;
                } while (y <= 6);
                x += 0.2;
            } while (x <= 7);
        }





    }
}
