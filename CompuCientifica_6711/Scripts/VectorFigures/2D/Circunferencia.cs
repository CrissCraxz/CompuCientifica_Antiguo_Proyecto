using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuCientifica_6711.Scripts
{
    internal class Circunferencia : Vector
    {
        public double Rd;
        

        public Circunferencia() { }

        public Circunferencia(double Rd)
        {
            this.Rd = Rd;
        }

        public override void Encender(Bitmap viewPort)
        {
            Vector vector = new(0, 0, color0);
            double t = 0;
            double dt = 0.001;
            double tf = (2 * Math.PI);

            do
            {
                vector.Xo = Xo + (Rd * Math.Cos(t));
                vector.Yo = Yo + (Rd * Math.Sin(t));
                vector.Encender(viewPort);
                t += dt;
            }
            while (t <= tf);
        }

        public void guardarDatosCircunferencia(double X0, double Y0, double Rd, Color color0)
        {
            this.Xo = X0;
            this.Yo = Y0;
            this.Rd = Rd;
            this.color0 = color0;
        }

        internal void Pantalla(int x, int y, out double t, out double t2)
        {
            throw new NotImplementedException();
        }

        internal void Pantalla(double x, double y, out double t, out double t2)
        {
            throw new NotImplementedException();
        }
    }
}
