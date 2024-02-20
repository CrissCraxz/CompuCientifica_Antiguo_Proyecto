using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuCientifica_6711.Scripts
{

    
    internal class Vector
    {
        public int Grosor { get; set; } = 1;
        public int sx1 = 0;
        public int sx2 = 700;
        public int sy1 = 0;
        public int sy2 = 540;

        public double Xo;
        public double Yo;
        public Color color0;
        public Color offColor= Color.White;

        public double x1 = -8;
        public double x2 = 8;
        public double y1 = -6.15;
        public double y2 = 6.15;
        public Vector() { }

        public Vector(double Xo, double Yo, Color color0)
        {
            this.Xo = Xo;
            this.Yo = Yo;
            this.color0 = color0;
        }

        public void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2) + sx1);
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2) + sy1);
        }

        //out double
        public void transform(double sx, double sy, out double x, out double y)
        {
            x = ((x1 - x2) * (sx - sx1) / (sx1 - sx2)) + x1;
            y = ((y2 - y1) * (sy - sy1) / (sy1 - sy2)) + y2;
        }
        public virtual void Encender(Bitmap pixelVec)
        {
            int Sx, Sy;
            Pantalla(Xo, Yo, out Sx, out Sy);
            if (Sx >= 0 && Sx < 699 &&  Sy >= 0 && Sy <= 539)
            {
               for (int i = 0; i < Grosor; i++)
                {
                    pixelVec.SetPixel(Sx + i, Sy, color0);
                }
            }


        }
        public virtual void Apagar(Bitmap screen)
        {
            color0 = Color.White;
            Encender(screen);

        }
    }
}
