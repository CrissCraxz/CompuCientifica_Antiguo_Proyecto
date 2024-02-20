using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuCientifica_6711.Scripts.VectorFigures._3D
{
    internal class Segmento : Vector
    {
        public double xf;
        public double yf;

        public Segmento() { }

        public Segmento(double xf, double yf)
        {
            this.xf = xf;
            this.yf = yf;
         
        }

        public override void Encender(Bitmap pixelVec)
        {
            Vector vector = new(0, 0, color0);
            double t = 0;
            double dt = 0.001;
            double tf = 1;

            do
            {
                vector.Xo = Xo + (xf - Xo) * t;
                vector.Yo = Yo + (yf - Yo) * t;
                vector.Encender(pixelVec);
                t += dt;
            }
            while (t <= 1);
        }

        public void guardarDatosSegmento(double X0, double Y0, double Xf, double Yf, Color color0)
        {
            this.Xo = X0;
            this.Yo = Y0;
            this.xf = Xf;
            this.yf = Yf;
            this.color0 = color0;
        }


    }
}
