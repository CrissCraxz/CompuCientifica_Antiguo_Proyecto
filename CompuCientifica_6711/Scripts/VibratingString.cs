using CompuCientifica_6711.Scripts.VectorFigures._3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuCientifica_6711.Scripts
{
    internal class VibratingString : Vector
    {
        public double t;

        public VibratingString() { }

        public VibratingString(double t)
        {
            this.t = t;
        }

        private double F(double x)
        {
            return x /5;//(-x * (x - 4)) / 2;
        }

        private double G(double x)
        {
            return x;
        }

        public void FourierC(double x, out double fou)
        {
            double pi = Math.PI;
            double an, bn, l = 2;
            double c = 1;

            int k = 0;
            double SumF = 0;

            do
            {
                k += 1;
                an = 0.33 * (4 * 1 * Math.Sin(k * Math.PI * 0.5) + 2 * Math.Sin(k * Math.PI * 1));

                an *= 0.5;

                bn = (0.33) * (0 + 4 * 1 * Math.Sin(k * Math.PI * 0.5) + 2 * Math.Sin(k * Math.PI * 1));
                bn = bn * (2 / (k * Math.PI * c));


                SumF = SumF + (an * Math.Cos((k * Math.PI* c* t) / 2) + bn * Math.Sin((k * Math.PI* c* t) / 2)) *Math.Sin(k * Math.PI * x / 2);


            } while (k <= 16);
            fou = SumF;
        }

        public double F2(double x)
        {
            return x * (2 - x);
        }

        public double G2(double y)
        {
            return y * (3 - y);
        }

        public void FourierPlate(double x, double y, out double fou)
        {
            /*
             * to complete, good luck!
             */
            double pi = Math.PI, Amn, Bmn, a, b, c = 1, sumF = 0, m1, n1;
            int m = 0, n = 0;

            Console.WriteLine("rest");
            do
            {
                n += 1;
                do
                {
                    m += 1;
                    //Amn = 0.111 * ((0 + 4 * F2(1) * Math.Sin((m * pi * 1) / 2) + F2(2) * Math.Sin(m * pi)) * (0 + 4 * G2(3 / 2) * Math.Sin((m * pi * 3) / 4) + G2(3) * Math.Sin(m * pi)));
                    Bmn = 0;
                    //System.Console.WriteLine("n: " + n + " m: " + m + " Amn: " + Amn);
                    transform(m, n, out m1, out n1);
                    Amn = (((1 + Math.Pow(-1, m1 + 1)) * (1 + Math.Pow(-1, n1 + 1))) / m1 * m1 * m1 * n1 * n1 * n1);
                    Amn = Amn * Math.Sin((m1 * pi * x) / 2) * Math.Sin((n1 * pi * y) / 3);
                    Amn = Amn * Math.Cos(pi * Math.Sqrt(9 * m1 * m1 + 4 * n1 * n1) * t);
                    //sumF += Math.Sin((m * pi * x) / 2) * Math.Sin((n * pi * y) / 3) * (Amn * Math.Cos(6 * t * Math.Sqrt(((m * pi) / 2) * ((m * pi) / 2) + ((n * pi) / 3) * ((n * pi) / 3))));
                    sumF += Amn;

                } while (m <= 5);

            } while (n <= 5);

            fou = sumF * 0.599;
        }

        public void Grapth2D(Bitmap viewPort)
        {
            Vector vector = new();
            double h, dh;
            vector.color0 = color0;
            h = 0;
            dh = 0.0002;
            do
            {
                vector.Xo = h;
                FourierC(h, out double fou);
                vector.Yo = fou;
                vector.Encender(viewPort);
                h += dh;
            } while (h <= 2);
        }

        public void Gra3D(Bitmap viewPort)
        {
            Vector3D vector = new();
            double i, di, j, dj, x, y;
            vector.color0 = Color.Black;
            i = 0;
            di = 0.002;
            j = 0;
            dj = 0.002;
            do
            {
                do
                {
                    vector.Xo = i;
                    vector.Yo = j;
                    FourierPlate(i, j, out double fou);
                    vector.Z0 = fou;
                  
                    vector.Encender(viewPort);
                    i += di;
                } while (i <= 2);
                j += dj;
            } while (j <= 3);
        }


        public void cuerda3D(Bitmap viewPort)
        {
            Vector3D vector = new Vector3D();
            double i, di, j, dj, x, y;
            vector.color0 = color0;
            i = 0;
            di = 0.0012;
            j = 0;
            dj = 0.0013;
            do
            {
                do
                {
                    vector.Xo = i;
                    vector.Yo = j;
                    FourierC(i, out double fou);
                    vector.Z0 = fou;
                    vector.Encender(viewPort);
                    i += di;
                } while (i <= 3);
                j += dj;
            } while (j <= 3);
        }

    }
}
