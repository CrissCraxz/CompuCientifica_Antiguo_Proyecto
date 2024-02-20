

using CompuCientifica_6711.Scripts;
using CompuCientifica_6711.Scripts.Examples;
using CompuCientifica_6711.Scripts.VectorFigures;
using CompuCientifica_6711.Scripts.VectorFigures._2D;
using CompuCientifica_6711.Scripts.VectorFigures._3D;
using MathNet.Numerics.LinearAlgebra;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Vector = CompuCientifica_6711.Scripts.Vector;

using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace CompuCientifica_6711
{


    public partial class App : Form
    {
        Bitmap pantalla = new Bitmap(700, 540);
        private Color viewPortBackColor;
        Vector vector = new Vector();
        Examples examples = new Examples();
        Color[] palette;
        private Color figuresColor = Color.LightSkyBlue;
        private Color axesColor = Color.FromArgb(152, 152, 152);
        Circunferencia circ = new Circunferencia();
        double x, y;

        public App()
        {
            InitializeComponent();
            pictureBoxPantalla.Size = new System.Drawing.Size(700, 540);

        }

        public void PanelNonVisible()
        {
            panelOptions.Visible = false;
            panelOptions2D.Visible = false;
            panelOptionsExamples.Visible = false;
            panelOptionsPalette.Visible = false;
            panelOptions3D.Visible = false;
        }

        private void buttonGv_Click(object sender, EventArgs e)
        {
            examples.parable(pantalla, pictureBoxPantalla);
            examples.vectorgrafic(pantalla, pictureBoxPantalla);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            examples.parabolaGrafic(pantalla, pictureBoxPantalla);
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            examples.segmentoGrafic(pantalla, pictureBoxPantalla);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {

            examples.circunferenciaGrafic(pantalla, pictureBoxPantalla);

        }

        private void buttonExe_Click(object sender, EventArgs e)

        //Exercise();
        {
            examples.ExampleCl(pantalla, pictureBoxPantalla);
            examples.ExampleCl2(pantalla, pictureBoxPantalla);
        }




        private void buttonEj_Click(object sender, EventArgs e)
        {

            examples.Ejes(pantalla, pictureBoxPantalla);
        }



        private void buttonTaylor_Click(object sender, EventArgs e)
        {
            //examples.esphere(pantalla, pictureBoxPantalla);

            examples.polyTaylor(pantalla, pictureBoxPantalla);
            



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonConC_Click(object sender, EventArgs e)
        {
            examples.esphere(pantalla, pictureBoxPantalla);






        }

        private void buttonOff_Click(object sender, EventArgs e)
        {


            Vector vector = new Vector();
            vector.Apagar(pantalla);

        }

        private void App_Load(object sender, EventArgs e)
        {
            viewPortBackColor = pictureBoxPantalla.BackColor;
            // Add ITems
            for (int i = 1; i < 11; i++)
            {
                comboBoxPalette.Items.Add("Mapping" + i);
            }

        }

        public static Bitmap Encender4(Bitmap bmp)
        {
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 540; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(90, (int)(0.2 * i + 0), 20));
                }

            }
            return bmp;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Encender4(pantalla);
            pictureBoxPantalla.Image = pantalla;
        }


        private void buttonPalle_Click(object sender, EventArgs e)
        {



            if (!panelOptionsPalette.Visible)
                panelOptionsPalette.Visible = true;
            else

                panelOptionsPalette.Visible = false;

        }

        private void button2D_Click(object sender, EventArgs e)
        {
            PanelNonVisible();
            if (!panelOptions2D.Visible)
                panelOptions2D.Visible = true;
            else
                panelOptions2D.Visible = false;


        }



        private void button3D_Click(object sender, EventArgs e)
        {
            PanelNonVisible();
            if (!panelOptions3D.Visible)
                panelOptions3D.Visible = true;
            else
                panelOptions3D.Visible = false;
        }

        private void buttonExamples_Click(object sender, EventArgs e)
        {

            PanelNonVisible();
            if (!panelOptionsExamples.Visible)
                panelOptionsExamples.Visible = true;
            else
                panelOptionsExamples.Visible = false;

        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {

            PanelNonVisible();
            if (!panelOptions.Visible)
                panelOptions.Visible = true;
            else
                panelOptions.Visible = false;
        }

        private void panelOptionsPalette_Paint(object sender, PaintEventArgs e)
        {

        }


        private void buttonParable_Click(object sender, EventArgs e)
        {
            examples.parable(pantalla, pictureBoxPantalla);

        }

        private void buttonAnimate_Click(object sender, EventArgs e)
        {
            examples.Animated5(pantalla, pictureBoxPantalla);

        }

        private void pictureBoxPantalla_MouseDown(object sender, MouseEventArgs e)
        {
            int LabOption = 0;

            switch (LabOption)
            {
                case 0:
                    ProcessClickEve2(e.X, e.Y);

                    break;
                default: MessageBox.Show("Lab option" + LabOption.ToString() + " does not exists"); break;
            }
        }

        public void SimulationRayReflection(int x, int y)
        {
            /*
             * Description
             * This experiment shows see how a ray light reflect on surface (parabolic equation) 
            */

            // surface
            Vector vector = new();
            vector.color0 = Color.Wheat;
            double t, tf, dt = 0.001;

            t = -6.15;
            tf = 6.15;
            do
            {
                vector.Xo = t;
                vector.Yo = -((t - 8) * (t + 8)) / 18;
                vector.Encender(pantalla);
                t += dt;
            } while (t <= tf);

            // ray light incident and reflected
            Color incidentRayColor = Color.Yellow;
            Color reflectedRayColor = Color.Red;

            double xf, yf, fx;
            Circunferencia circumference = new();
            circumference.color0 = figuresColor;
            circumference.transform(x, y, out xf, out yf);
            circumference.Rd = 0.1;
            circumference.Xo = xf;
            circumference.Yo = yf;

            fx = -((xf - 8) * (xf + 8)) / 18;

            Segmento incidentRay = new();
            incidentRay.color0 = incidentRayColor;
            incidentRay.Xo = xf;
            incidentRay.Yo = yf;
            incidentRay.xf = xf;
            incidentRay.yf = fx;
            incidentRay.Encender(pantalla);

            //reflected ray using normal line to the surface
            Segmento reflectedRay = new();
            reflectedRay.color0 = reflectedRayColor;
            reflectedRay.Xo = incidentRay.xf;
            reflectedRay.Yo = incidentRay.yf;
            if (incidentRay.xf < 0)
            {
                reflectedRay.xf = 6.15;
                reflectedRay.yf = (8 / incidentRay.xf) * (8 - incidentRay.xf) + incidentRay.yf;
            }
            else
            {
                reflectedRay.xf = -6.15;
                reflectedRay.yf = (8 / incidentRay.xf) * (-8 - incidentRay.xf) + incidentRay.yf;
            }

            reflectedRay.Encender(pantalla);
            circumference.Encender(pantalla);

            pictureBoxPantalla.Image = pantalla;
        }

        public void Prueba2Parcial()
        {
            // surface
            Vector vector = new();
            vector.color0 = Color.Wheat;
            double t, tf, dt = 0.001;

            t = -7;
            tf = 7;
            do
            {
                vector.Xo = t;
                vector.Yo = -((t - 8) * (t + 8)) / 18;
                vector.Encender(pantalla);
                t += dt;
            } while (t <= tf);

            // ray light incident and reflected
            Color incidentRayColor = Color.Yellow;
            Color reflectedRayColor = Color.Red;

            double xf, yf, fx;
            Circunferencia circumference = new();
            circumference.color0 = figuresColor;
            circumference.Encender(pantalla);
            circumference.Rd = 0.1;




            Segmento incidentRay = new();
            incidentRay.color0 = incidentRayColor;

            incidentRay.Encender(pantalla);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            int selectedIndex = comboBoxPalette.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < 10)
            {
                string selectedMapping = "Mapping" + selectedIndex;

                switch (selectedMapping)
                {
                    case "Mapping1":
                        examples.mapping1(pantalla, pictureBoxPantalla);
                        break;
                    case "Mapping2":
                        examples.mapping2(pantalla, pictureBoxPantalla);
                        break;
                    case "Mapping3":
                        examples.mapping3(pantalla, pictureBoxPantalla);
                        break;
                    case "Mapping4":
                        examples.mapping4(pantalla, pictureBoxPantalla);
                        break;
                    case "Mapping5":
                        examples.mapping5(pantalla, pictureBoxPantalla);
                        break;
                    case "Mapping6":
                        examples.mapping6(pantalla, pictureBoxPantalla);
                        break;
                    case "Mapping7":
                        examples.mapping7(pantalla, pictureBoxPantalla);
                        break;
                    case "Mapping8":
                        examples.mapping8(pantalla, pictureBoxPantalla);
                        break;
                    case "Mapping9":
                        examples.mapping9(pantalla, pictureBoxPantalla);
                        break;
                    case "Mapping10":
                        examples.mapping10(pantalla, pictureBoxPantalla);
                        break;
                    default:

                        break;

                }
            }


        }

        private void pictureBoxPantalla_Click(object sender, EventArgs e)
        {

        }

        private void buttonv3D_Click(object sender, EventArgs e)
        {

            double t = 0;
            double dt = 0.005;
            Vector3D v3d = new Vector3D(0, 0, 0, figuresColor);
            // Vector3D v3d1 = new Vector3D();
            //   Vector3D v3d2 = new Vector3D();

            do
            {//el pirmer numero de cada eje  mueve la figura ya sea derecha , izquiera y fondo
                v3d.Xo = -3 + t / 6;// 1 + 0.8 * Math.Cos(t);
                v3d.Yo = 1 + 3 * Math.Sin(t);// -2 + 0.8 * Math.Sin(t);   //el valor de 3 en y0 y z0 hace q el radio de la circunferencia sea mas delgado si baja y si se pone mas alto se engorda 
                v3d.Z0 = 1 + 3 * Math.Cos(t);// 3 * (t / 18);
                v3d.Encender(pantalla);
                figuresColor = Color.Red;
                pictureBoxPantalla.Image = pantalla;
                t = t + dt;
                /*
                                v3d1.color0 = Color.Green;
                                v3d1.x0 = -4 + 1 * Math.Cos(t);
                                v3d1.y0 = 3 + 2 * Math.Sin(t);
                                v3d1.Z0 = -3 + 2 * (t / 30);
                                v3d1.Encender(bitmap);
                                pictureBox1.Image = bitmap;
                                t = t + dt;

                                v3d2.color0 = Color.Fuchsia;
                                v3d2.x0 = 3 + 2 * Math.Cos(t);
                                v3d2.y0 = 1 + 2 * Math.Sin(t);
                                v3d2.Z0 = (t / 10);
                                v3d2.Encender(bitmap);
                                pictureBox1.Image = bitmap;
                                t = t + dt;*/

            } while (t <= 22);

        }

        private void buttonPAn_Click(object sender, EventArgs e)
        {
            examples.parableAn(pantalla, pictureBoxPantalla);
            panelOptions2D.Visible = false;
        }

        private void buttonOnda_Click(object sender, EventArgs e)
        {
            Onda onda = new Onda();
            onda.GrafOnda1(pantalla);
            pictureBoxPantalla.Image = pantalla;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Onda onda = new Onda();
            onda.m = 1;
            onda.w = 1.5;
            onda.v = 9.3;

            // onda.GrafOnda1(pantalla);
            pictureBoxPantalla.Image = pantalla;

        }

        private void buttonOndD_Click(object sender, EventArgs e)
        {

            examples.m = 1;
            examples.w = 1.5;
            examples.v = 9.3;
            examples.t = 0.5;
            examples.OndaInterferencia2(pantalla, pictureBoxPantalla);



        }

        private void buttonOTr_Click(object sender, EventArgs e)
        {

            examples.m = 1;
            examples.w = 1.5;
            examples.v = 9.3;
            examples.t = 0.5;
            examples.OndaInterferencia3(pantalla, pictureBoxPantalla);


        }

        private void buttonOTiempo_Click(object sender, EventArgs e)
        {
            Onda onda = new Onda();
            onda.m = 1;
            onda.w = 1.5;
            onda.v = 9.3;
            double t0 = 0;
            do
            {
                onda.t = t0;
                onda.GrafOnda1(pantalla);
                pictureBoxPantalla.Image = pantalla;
                System.Windows.Forms.Application.DoEvents();
                t0 = t0 + 0.1;
            } while (t0 <= 7);

        }

        private void buttonO3D_Click(object sender, EventArgs e)
        {

            panelOptions3D.Visible = false;
            Onda wave = new();
            wave.color0 = figuresColor;
            wave.m = 0.7;
            wave.t = 0.03;
            wave.v = 9.3;
            wave.w = 1.5;
            wave.Onda3D(pantalla);
            pictureBoxPantalla.Image = pantalla;


        }

        public async void AnimateSimpleCircularWave3D()
        {
            double t = 0.02, dt = 0, tf = 1.80;
            Onda wave = new();
            wave.m = 0.7;
            wave.v = 7.3;
            wave.w = 2.1;
            do
            {
                wave.color0 = figuresColor;
                wave.Onda3D(pantalla);
                await Task.Delay(40);
                wave.color0 = viewPortBackColor;
                wave.Onda3D(pantalla);
                pictureBoxPantalla.Image = pantalla;
                wave.t = dt;
                dt += t;
            } while (dt <= tf);
        }

        public async void AnimateInterferenceTwoWaves3D()
        {
            double t = 0.001, dt = 0, tf = 3;
            Onda wave = new();
            wave.m = 0.7;
            wave.v = 9.3;
            wave.w = 1.5;
            do
            {
                //para la limpieza de la animacion 
                wave.color0 = figuresColor;
                wave.Interferecia3D_2f(pantalla);
                await Task.Delay(40);
                wave.color0 = viewPortBackColor;
                wave.Interferecia3D_2f(pantalla);
                pictureBoxPantalla.Image = pantalla;
                wave.t += t;
                wave.w += 0.1;
                dt += t;
            } while (dt <= tf);
        }



        private void button3DAn_Click(object sender, EventArgs e)
        {
            AnimateSimpleCircularWave3D();
            panelOptions3D.Visible = false;
        }

        private void button13DA2F_Click(object sender, EventArgs e)
        {
            AnimateInterferenceTwoWaves3D();
            panelOptions.Visible = false;
        }

        private void buttonOnd3D_2F_Click(object sender, EventArgs e)
        {
            InterferenceTwoWaves3D();
            panelOptions3D.Visible = false;
        }


        public void InterferenceTwoWaves3D()
        {
            Onda wave = new();
            wave.color0 = figuresColor;
            wave.m = 0.7;
            wave.t = 0;
            wave.v = 9.3;
            wave.w = 1.5;
            wave.Interferecia3D_2f(pantalla);

            pictureBoxPantalla.Image = pantalla;
        }

        public void VibratingString()
        {
            VibratingString vibratingString = new();
            vibratingString.color0 = figuresColor;
            vibratingString.t = 5.04;
            vibratingString.Grapth2D(pantalla);
            pictureBoxPantalla.Image = pantalla;
        }
        private void button1_Click_3(object sender, EventArgs e)
        {
            VibratingString();
        }

        private void buttonAnFou_Click(object sender, EventArgs e)
        {
            AnimateVibratingString();
            panelOptions.Visible = false;
        }



        public async void AnimateVibratingString()
        {
            VibratingString vibratingString = new();
            double t = 0;
            do
            {
                vibratingString.t = t;
                vibratingString.color0 = figuresColor;
                // graph2DAxes();
                vibratingString.cuerda3D(pantalla);
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(15);

                vibratingString.Apagar(pantalla);
                vibratingString.color0 = viewPortBackColor;
                vibratingString.cuerda3D(pantalla);
                pictureBoxPantalla.Image = pantalla;
                t += 0.01;

                if (t >= 20)
                {
                    t = 0;
                }
            } while (true);
        }

        public void graph2DAxes()
        {
            //viewPort = new(viewPort.Width, viewPort.Height);

            Vector vector = new();
            Segmento segmentX = new(vector.x1, 0);
            segmentX.Xo = vector.x2;
            segmentX.Yo = 0;
            segmentX.color0 = axesColor;
            segmentX.Encender(pantalla);

            Segmento segmentY = new(0, vector.y1);
            segmentY.Xo = 0;
            segmentY.Yo = vector.y2;
            segmentY.color0 = axesColor;
            segmentY.Encender(pantalla);

            pictureBoxPantalla.Image = pantalla;
        }

        private void buttonOnda3DC_Click(object sender, EventArgs e)
        {
            panelOptions3D.Visible = false;
            Onda wave = new Onda();
            wave.color0 = figuresColor;
            wave.m = 0.7;
            wave.t = 0.2;
            wave.v = 7.3;
            wave.w = 1.5;
            wave.Onda3DL(pantalla);
            pictureBoxPantalla.Image = pantalla;


        }

        private void buttonOnda3DCA_Click(object sender, EventArgs e)
        {
            AnimateSimpleCircularWaveL3D();
            panelOptions.Visible = false;
        }



        public async void AnimateSimpleCircularWaveL3D()
        {
            double t = 0.02, dt = 0, tf = 1.80;
            Onda wave = new();
            wave.m = 0.7;
            wave.v = 7.3;
            wave.w = 2.1;
            do
            {
                wave.color0 = figuresColor;
                wave.Onda3DL(pantalla);
                await Task.Delay(40);


                wave.color0 = viewPortBackColor;
                wave.Onda3DL(pantalla);
                pictureBoxPantalla.Image = pantalla;

                wave.t = dt;
                dt += t;
            } while (dt <= tf);
        }



        public async void AnimateSimpleCircularWaveLl3D()
        {
            double t = 0.02, dt = 0, tf = 1.80;
            Onda wave = new();
            wave.m = 0.7;
            wave.v = 7.3;
            wave.w = 2.1;

            wave.color0 = figuresColor;
            wave.Onda3D(pantalla);

            wave.color0 = viewPortBackColor;
            wave.Onda3DL(pantalla);
            pictureBoxPantalla.Image = pantalla;


        }

        private void buttonOnda3D_2FV1_Click(object sender, EventArgs e)
        {
            AnimateSimpleCircularWaveLl3D();
            panelOptions3D.Visible = false;
        }

        public async void Reflex()
        {
            // Crear una nueva imagen de pantalla
            pantalla = new Bitmap(pictureBoxPantalla.Width, pictureBoxPantalla.Height);
            // Crear un nuevo objeto Graphics para dibujar en la imagen de pantalla
            Graphics g = Graphics.FromImage(pantalla);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Establecer los límites de la gráfica
            double xMin = -8;
            double xMax = 8;
            double yMin = -6.15;
            double yMax = 6.15;

            // ray light incident and reflected
            Color incidentRayColor = Color.Yellow;
            Color reflectedRayColor = Color.Red;

            // Punto de inicio del rayo incidente Po(1, 0)
            double xi = 1;
            double yi = 0;

            // Ángulo de incidencia en grados (60 grados)
            double angleInDegrees = 60;

            // Convertir el ángulo de incidencia a radianes
            double angleInRadians = angleInDegrees * Math.PI / 180;

            // Pendiente del rayo incidente m = tan(60°) = 2
            double m = Math.Tan(angleInRadians);

            // Calcular el punto de finalización del rayo incidente (xf, yf)
            double xf = xi + (yMax - yi) / m;
            double yf = yMax;

            // Ajustar el punto de finalización dentro de los límites de la gráfica
            if (xf < xMin)
            {
                xf = xMin;
                yf = yi + m * (xf - xi);
            }
            else if (xf > xMax)
            {
                xf = xMax;
                yf = yi + m * (xf - xi);
            }

            // Dibujar el rayo incidente
            Segmento incidentRay = new Segmento();
            incidentRay.color0 = incidentRayColor;
            incidentRay.Xo = xi;
            incidentRay.Yo = yi;
            incidentRay.xf = xf;
            incidentRay.yf = yf;
            incidentRay.Encender(pantalla);

            // Calcular el ángulo de reflexión (al contrario del ángulo de incidencia)
            double angleOfReflectionDegrees = -angleInDegrees;
            double angleOfReflectionRadians = angleOfReflectionDegrees * Math.PI / 180;

            // Pendiente del rayo reflejado
            double mReflected = Math.Tan(angleOfReflectionRadians);

            // Calcular el punto de reflexión
            double xReflected = xf;
            double yReflected = yf + mReflected * (xf - xi);

            // Ajustar el punto de reflexión dentro de los límites de la gráfica
            if (xReflected < xMin)
            {
                xReflected = xMin;
                yReflected = yf + mReflected * (xReflected - xf);
            }
            else if (xReflected > xMax)
            {
                xReflected = xMax;
                yReflected = yf + mReflected * (xReflected - xf);
            }

            // Dibujar el rayo reflejado desde el punto final del rayo incidente hasta el punto de reflexión
            Segmento reflectedRay = new Segmento();
            reflectedRay.color0 = reflectedRayColor;
            reflectedRay.Xo = xf;
            reflectedRay.Yo = yf;
            reflectedRay.xf = xReflected;
            reflectedRay.yf = yReflected;
            reflectedRay.Encender(pantalla);

            // Mostrar la imagen de pantalla en el control PictureBox
            pictureBoxPantalla.Image = pantalla;
        }

        public async void Ref()
        {
            Segmento foco2 = new Segmento();
            foco2.color0 = Color.Black;
            double m, b, xi, x1, x2, y1, y2;
            x1 = 1;
            y1 = 0;//x1;y1

            //x2 = 6.15;
            // y2 = 0;//x2;y2

            m = -2;//m con tan(-60)
            b = y1 - (m * x1);//b
            xi = (-b - 6.15) / (m);// y final
            //xi = ((6.15-0) / (m)+1);// x final

            foco2.Xo = 1; foco2.Yo = 0;//x1;y1 (punto0)
            foco2.xf = xi; foco2.yf = 6.15;//x2;y2 (punto1)

            MessageBox.Show(b.ToString());

            foco2.Encender(pantalla);
            pictureBoxPantalla.Image = pantalla;



            ////////////////////////////////////////////////// p1 a; p2

            x1 = xi;
            y1 = 6.15;//x1;y1

            double yi;
            m = -1.73;//m con tan(-30)
            b = y1 - (m * x1);//b
            yi = (6.15) + ((8 - xi) * m);// y final

            foco2.Xo = x1; foco2.Yo = 6.15;//x1;y1 (punto1)
            foco2.xf = 8; foco2.yf = yi;//x2;y2 (punto2)

            MessageBox.Show(b.ToString());
            foco2.Encender(pantalla);
            pictureBoxPantalla.Image = pantalla;




        }



        private void buttonRef_Click(object sender, EventArgs e)
        {
            //Reflex();
            Ref();
        }

        private void buttonTs_Click(object sender, EventArgs e)
        {



            examples.trazoSeg(pantalla, pictureBoxPantalla);
            panelTS.Visible = true;




        }



        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {



        }








        public async void ReflexPrueba()
        {

            // Crear una nueva imagen de pantalla
            pantalla = new Bitmap(pictureBoxPantalla.Width, pictureBoxPantalla.Height);
            // Crear un nuevo objeto Graphics para dibujar en la imagen de pantalla
            Graphics g = Graphics.FromImage(pantalla);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Establecer los límites de la gráfica
            double xMin = -8;
            double xMax = 8;
            double yMin = -6.15;
            double yMax = 6.15;

            // ray light incident and reflected
            Color incidentRayColor = Color.Yellow;
            Color reflectedRayColor = Color.Red;

            // Punto de inicio del rayo incidente Po(2, 0) (considerando los valores que diste)
            double xi = 2;
            double yi = 0;

            // Punto final del rayo incidente P1(4, 6.15) (considerando los valores que diste)
            double xf = 4;
            double yf = 6.15;

            // Dibujar el rayo incidente
            Segmento incidentRay = new Segmento();
            incidentRay.color0 = incidentRayColor;
            incidentRay.Xo = xi;
            incidentRay.Yo = yi;
            incidentRay.xf = xf;
            incidentRay.yf = yf;
            incidentRay.Encender(pantalla);

            // Calcular el ángulo de incidencia en grados
            double angleInDegrees = Math.Atan2(yf - yi, xf - xi) * 180 / Math.PI;

            // Calcular el ángulo de reflexión (al contrario del ángulo de incidencia)
            double angleOfReflectionDegrees = -angleInDegrees;
            double angleOfReflectionRadians = angleOfReflectionDegrees * Math.PI / 180;

            // Pendiente del rayo reflejado
            double mReflected = Math.Tan(angleOfReflectionRadians);

            // Calcular el punto de reflexión
            double xReflected = xf;
            double yReflected = yf + mReflected * (xf - xi);

            // Ajustar el punto de reflexión dentro de los límites de la gráfica
            if (xReflected < xMin)
            {
                xReflected = xMin;
                yReflected = yf + mReflected * (xReflected - xf);
            }
            else if (xReflected > xMax)
            {
                xReflected = xMax;
                yReflected = yf + mReflected * (xReflected - xf);
            }

            // Dibujar el rayo reflejado desde el punto final del rayo incidente hasta el punto de reflexión
            Segmento reflectedRay = new Segmento();
            reflectedRay.color0 = reflectedRayColor;
            reflectedRay.Xo = xf;
            reflectedRay.Yo = yf;
            reflectedRay.xf = xReflected;
            reflectedRay.yf = yReflected;
            reflectedRay.Encender(pantalla);

            // Mostrar la imagen de pantalla en el control PictureBox
            pictureBoxPantalla.Image = pantalla;
        }


        private void buttonRP_Click(object sender, EventArgs e)
        {
            ReflexPrueba();
        }

        private void buttonFP3D_Click(object sender, EventArgs e)
        {



            VibratingString vibratingString = new();
            vibratingString.color0 = Color.Green;
            vibratingString.t = 12;
            vibratingString.cuerda3D(pantalla);
            pictureBoxPantalla.Image = pantalla;
            panelOptions3D.Visible = false;
        }


        public void graficarFechas()
        {
            Vector v = new Vector();
            v.Apagar(pantalla);
            Segmento S = new Segmento();
            S.guardarDatosSegmento(0, 0.6, 0, -0.6, Color.Red);
            S.Encender(pantalla);
            S.guardarDatosSegmento(0, 0.6, -0.8, 0, Color.Red);
            S.Encender(pantalla);
            S.guardarDatosSegmento(0, -0.6, -0.8, 0, Color.Red);
            S.Encender(pantalla);

            S.guardarDatosSegmento(6, 0.6, 6, -0.6, Color.Red);
            S.Encender(pantalla);
            S.guardarDatosSegmento(6, 0.6, 6.8, 0, Color.Red);
            S.Encender(pantalla);
            S.guardarDatosSegmento(6, -0.6, 6.8, 0, Color.Red);
            S.Encender(pantalla);


            pictureBoxPantalla.Image = pantalla;
        }
        private void buttonF_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && textBoxElas.Text != "" && textBoxPeso.Text != "")
            {

                graficarFechas();
                int n = int.Parse(comboBox1.SelectedItem.ToString());
                double m = double.Parse(textBoxPeso.Text);
                double k = double.Parse(textBoxElas.Text);

                // Matriz A
                Matrix<double> A = DenseMatrix.OfArray(crearMatrixA(n));

                // Vector B
                MathNet.Numerics.LinearAlgebra.Vector<double> BenY = DenseVector.OfArray(crearVectorB(n));
                MathNet.Numerics.LinearAlgebra.Vector<double> BenX = DenseVector.OfArray(crearVectorBenX(n));
                Circunferencia C = new Circunferencia();
                Segmento S = new Segmento();
                double posXInicial = 0;
                double posYInicial = 0;

                double posXFinal = 0;
                double posYFinal = 0;

                double datoMGK = ((m * 9.8) / k);


                try
                {
                    // Resolver el sistema de ecuaciones Ax = B
                    MathNet.Numerics.LinearAlgebra.Vector<double> X = A.Solve(BenX);
                    MathNet.Numerics.LinearAlgebra.Vector<double> Y = A.Solve(BenY);

                    for (int i = 0; i < X.Count; i++)
                    {
                        posXFinal = X[i];
                        posYFinal = Y[i] * datoMGK;
                        S.guardarDatosSegmento(posXInicial, posYInicial, posXFinal, posYFinal, Color.Black);
                        S.Encender(pantalla);

                        C.guardarDatosCircunferencia(X[i], Y[i] * datoMGK, 0.15, Color.Red);

                        C.Encender(pantalla);
                        posXInicial = posXFinal;
                        posYInicial = posYFinal;
                    }

                    S.guardarDatosSegmento(posXInicial, posYInicial, 6, 0, Color.Black);
                    S.Encender(pantalla);
                    pictureBoxPantalla.Image = pantalla;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al resolver el sistema de ecuaciones: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos");
            }
        }



        public static double[,] crearMatrixA(int n)
        {
            double[,] matrix = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = -2;
                    }
                    else if (Math.Abs(i - j) == 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }

        // Método para crear el vector B de forma recursiva
        public static double[] crearVectorB(int n)
        {
            double[] vector = new double[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = 1;
            }

            return vector;
        }

        public static double[] crearVectorBenX(int n)
        {
            double[] vector = new double[n];
            for (int i = 0; i < n; i++)
            {
                if (i == (n - 1))
                {
                    vector[i] = -6;
                }
                else
                {
                    vector[i] = 0;
                }

            }

            return vector;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.x = e.Location.X;
            this.y = e.Location.Y;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // Creación de un objeto de tipo 'segmento' que representa la parábola
            Segmento seg1 = new Segmento();

            // Definición de los límites y el paso para el trazado de la parábola
            double t1 = -8;  // Inicio del trazado
            double dt1 = 0.1;  // Paso del trazado

            // Bucle para trazar la parábola punto por punto
            do
            {
                seg1.Xo = t1;  // Coordenada x del punto inicial
                seg1.Yo = (-0.1 * Math.Pow(t1, 2) + 1);  // Coordenada y del punto inicial, calculada con la ecuación de la parábola
                seg1.xf = t1 + dt1;  // Coordenada x del punto final
                seg1.yf = (-0.1 * Math.Pow(seg1.xf, 2) + 1);  // Coordenada y del punto final, calculada con la ecuación de la parábola
                seg1.color0 = Color.Red;  // Color del segmento
                seg1.Encender(pantalla);  // Método para dibujar el segmento en el mapa de bits 'bmp'
                t1 += dt1;  // Incremento de t1 para el siguiente punto
            } while (t1 <= 8);

            // Obtén las coordenadas donde se hizo clic
            double t, t2;
            Circunferencia cir = new Circunferencia();
            // Conversión de las coordenadas del clic (x, y) a coordenadas del mundo real (t, t2)
            cir.Pantalla(x, y, out t, out t2);


            // Calcula el valor de y en la parábola en el punto x donde se hizo clic
            double yParabola = -0.1 * Math.Pow(t, 2) + 1;

            // Verificación de si el click
            if (t2 < yParabola)
            {
                cir.color0 = Color.YellowGreen;
                cir.Rd = 0.2;
                cir.Xo = t;
                cir.Yo = t2;
                cir.Encender(pantalla);


                //dibuja el circulo del foco 
                Circunferencia cir2 = new Circunferencia();
                cir2.color0 = Color.Red;
                cir2.Pantalla(x, y, out t, out t2);
                cir2.Rd = 0.2;
                cir2.Xo = 0;
                cir2.Yo = -3.5;
                cir2.Encender(pantalla);


                //liena hasta el techo de la parabola
                Segmento seg = new Segmento();
                seg.Xo = t;
                seg.Yo = t2;
                seg.xf = t;
                seg.yf = -0.1 * Math.Pow(t, 2) + 1;  // calcula la y de la parábola
                seg.color0 = Color.Black;
                seg.Encender(pantalla);

                // Línea hasta el foco de la parábola y más allá
                Segmento segFoco = new Segmento();
                segFoco.color0 = Color.Black;  // Color a verde para distinguir
                segFoco.Xo = seg.xf;
                segFoco.Yo = seg.yf;

                // Foco de la parábola
                double focoX = 0, focoY = -3.5;

                // Calcula la pendiente m y el intercepto n
                double m = (focoY - seg.yf) / (focoX - seg.xf);
                double n = seg.yf - m * seg.xf;

                double mTangente = -0.2 * t;

                // Calcula el intercepto usando y = mx + b
                double bTangente = yParabola - mTangente * t;

                // Establece las coordenadas para el segmento tangente
                Segmento segTangente = new Segmento();
                segTangente.Xo = -8;
                segTangente.Yo = mTangente * segTangente.Xo + bTangente;
                segTangente.xf = 8;
                segTangente.yf = mTangente * segTangente.xf + bTangente;
                segTangente.color0 = Color.Blue; // Puedes cambiar el color si prefieres
                segTangente.Encender(pantalla);

                if (segFoco.yf < -6.15)  // si el punto está por debajo del borde inferior de la pantalla
                {
                    segFoco.xf = -8;  // borde izquierdo de la pantalla
                    segFoco.yf = m * segFoco.xf + n;
                    segFoco.yf = -6.15;  // establece yf al borde inferior de la pantalla
                    segFoco.xf = (segFoco.yf - n) / m;  // calcula el valor de x en la línea
                }
                else
                {
                    segFoco.xf = 8;  // borde derecho de la pantalla
                    segFoco.yf = m * segFoco.xf + n;
                    segFoco.yf = -6.15;  // establece yf al borde inferior de la pantalla
                    segFoco.xf = (segFoco.yf - n) / m;
                }

                segFoco.Encender(pantalla);

                pictureBoxPantalla.Image = pantalla;
            }
        }



        private void ProcessClickEve(int x, int y)
        {
            Bitmap bmp = new Bitmap(740, 540);

            // Creación de un objeto de tipo 'segmento' que representa la parábola
            Segmento seg1 = new Segmento();

            // Definición de los límites y el paso para el trazado de la parábola
            double t1 = -8;  // Inicio del trazado
            double dt1 = 0.1;  // Paso del trazado

            // Bucle para trazar la parábola punto por punto
            do
            {
                seg1.Xo = t1;  // Coordenada x del punto inicial
                seg1.Yo = (-0.1 * Math.Pow(t1, 2) + 1);  // Coordenada y del punto inicial, calculada con la ecuación de la parábola
                seg1.xf = t1 + dt1;  // Coordenada x del punto final
                seg1.yf = (-0.1 * Math.Pow(seg1.xf, 2) + 1);  // Coordenada y del punto final, calculada con la ecuación de la parábola
                seg1.color0 = Color.Red;  // Color del segmento
                seg1.Encender(bmp);  // Método para dibujar el segmento en el mapa de bits 'bmp'
                t1 += dt1;  // Incremento de t1 para el siguiente punto
            } while (t1 <= 8);

            // Obtén las coordenadas donde se hizo clic
            double t, t2;
            Circunferencia cir = new Circunferencia();
            // Conversión de las coordenadas del clic (x, y) a coordenadas del mundo real (t, t2)
            cir.transform(x, y, out t, out t2);

            // Calcula el valor de y en la parábola en el punto x donde se hizo clic
            double yParabola = -0.1 * Math.Pow(t, 2) + 1;

            // Verificación de si el clic
            if (t2 < yParabola)
            {
                cir.color0 = Color.YellowGreen;
                cir.Rd = 0.2;
                cir.Xo = t;
                cir.Yo = t2;
                cir.Encender(bmp);

                //dibuja el circulo del foco 
                Circunferencia cir2 = new Circunferencia();
                cir2.color0 = Color.Red;
                cir2.transform(x, y, out t, out t2);
                cir2.Rd = 0.2;
                cir2.Xo = 0;
                cir2.Yo = -3.5;
                cir2.Encender(bmp);


                //liena hasta el techo de la parabola
                Segmento seg = new Segmento();
                seg.Xo = t;
                seg.Yo = t2;
                seg.xf = t;
                seg.yf = -0.1 * Math.Pow(t, 2) + 1;  // calcula la y de la parábola
                seg.color0 = Color.Black;
                seg.Encender(bmp);

                // Línea hasta el foco de la parábola y más allá
                Segmento segFoco = new Segmento();
                segFoco.color0 = Color.Black;  // Color a verde para distinguir
                segFoco.Xo = seg.xf;
                segFoco.Yo = seg.yf;

                // Foco de la parábola
                double focoX = 0, focoY = -3.5;

                // Calcula la pendiente m y el intercepto n
                double m = (focoY - seg.yf) / (focoX - seg.xf);
                double n = seg.yf - m * seg.xf;


                if (segFoco.yf < -6.15)  // si el punto está por debajo del borde inferior de la pantalla
                {
                    segFoco.xf = -8;  // borde izquierdo de la pantalla
                    segFoco.yf = m * segFoco.xf + n;
                    segFoco.yf = -6.15;  // establece yf al borde inferior de la pantalla
                    segFoco.xf = (segFoco.yf - n) / m;  // calcula el valor de x en la línea
                }
                else
                {
                    segFoco.xf = 8;  // borde derecho de la pantalla
                    segFoco.yf = m * segFoco.xf + n;
                    segFoco.yf = -6.15;  // establece yf al borde inferior de la pantalla
                    segFoco.xf = (segFoco.yf - n) / m;
                }

                segFoco.Encender(bmp);



                pictureBoxPantalla.Image = bmp;
            }
        }


        private void ProcessClickEve2(int x, int y)
        {
            Bitmap bmp = new Bitmap(740, 540);

            // Creación de un objeto de tipo 'segmento' que representa la parábola
            Segmento seg1 = new Segmento();

            // Definición de los límites y el paso para el trazado de la parábola
            double t1 = -8;  // Inicio del trazado
            double dt1 = 0.1;  // Paso del trazado

            // Bucle para trazar la parábola punto por punto
            do
            {
                seg1.Xo = t1;  // Coordenada x del punto inicial
                seg1.Yo = (-0.1 * Math.Pow(t1, 2) + 1);  // Coordenada y del punto inicial, calculada con la ecuación de la parábola
                seg1.xf = t1 + dt1;  // Coordenada x del punto final
                seg1.yf = (-0.1 * Math.Pow(seg1.xf, 2) + 1);  // Coordenada y del punto final, calculada con la ecuación de la parábola
                seg1.color0 = Color.Red;  // Color del segmento
                seg1.Encender(bmp);  // Método para dibujar el segmento en el mapa de bits 'bmp'
                t1 += dt1;  // Incremento de t1 para el siguiente punto
            } while (t1 <= 8);

            // Obtén las coordenadas donde se hizo clic
            double t, t2;
            Circunferencia cir = new Circunferencia();
            // Conversión de las coordenadas del clic (x, y) a coordenadas del mundo real (t, t2)
            cir.transform(x, y, out t, out t2);

            // Calcula el valor de y en la parábola en el punto x donde se hizo clic
            double yParabola = -0.1 * Math.Pow(t, 2) + 1;

            // Verificación de si el clic
            if (t2 < yParabola)
            {
                cir.color0 = Color.YellowGreen;
                cir.Rd = 0.2;
                cir.Xo = t;
                cir.Yo = t2;
                cir.Encender(bmp);

                //dibuja el circulo del foco 
                Circunferencia cir2 = new Circunferencia();
                cir2.color0 = Color.Red;
                cir2.transform(x, y, out t, out t2);
                cir2.Rd = 0.2;
                cir2.Xo = 0;
                cir2.Yo = -3.5;
                cir2.Encender(bmp);


                //liena hasta el techo de la parabola
                Segmento seg = new Segmento();
                seg.Xo = t;
                seg.Yo = t2;
                seg.xf = t;
                seg.yf = -0.1 * Math.Pow(t, 2) + 1;  // calcula la y de la parábola
                seg.color0 = Color.Black;
                seg.Encender(bmp);

                // Línea hasta el foco de la parábola y más allá
                Segmento segFoco = new Segmento();
                segFoco.color0 = Color.Black;  // Color a verde para distinguir
                segFoco.Xo = seg.xf;
                segFoco.Yo = seg.yf;

                // Foco de la parábola
                double focoX = 0, focoY = -3.5;




                // Calcula la pendiente m y el intercepto n
                double m = (focoY - seg.yf) / (focoX - seg.xf);
                double n = seg.yf - m * seg.xf;

                double mTangente = -0.2 * t;

                // Calcula el intercepto usando y = mx + b
                double bTangente = yParabola - mTangente * t;

                // Establece las coordenadas para el segmento tangente
                Segmento segTangente = new Segmento();
                segTangente.Xo = -8;
                segTangente.Yo = mTangente * segTangente.Xo + bTangente;
                segTangente.xf = 8;
                segTangente.yf = mTangente * segTangente.xf + bTangente;
                segTangente.color0 = Color.Blue; // Puedes cambiar el color si prefieres
                segTangente.Encender(bmp);

                if (segFoco.yf < -6.15)  // si el punto está por debajo del borde inferior de la pantalla
                {
                    segFoco.xf = -8;  // borde izquierdo de la pantalla
                    segFoco.yf = m * segFoco.xf + n;
                    segFoco.yf = -6.15;  // establece yf al borde inferior de la pantalla
                    segFoco.xf = (segFoco.yf - n) / m;  // calcula el valor de x en la línea
                }
                else
                {
                    segFoco.xf = 8;  // borde derecho de la pantalla
                    segFoco.yf = m * segFoco.xf + n;
                    segFoco.yf = -6.15;  // establece yf al borde inferior de la pantalla
                    segFoco.xf = (segFoco.yf - n) / m;
                }

                segFoco.Encender(bmp);

                pictureBoxPantalla.Image = bmp;
            }
        }


        private void ProcessClickEve3(int x, int y)
        {
            Bitmap bmp = new Bitmap(740, 540);

            // Creación de un objeto de tipo 'segmento' que representa la parábola
            Segmento seg1 = new Segmento();

            // Definición de los límites y el paso para el trazado de la parábola
            double t1 = -8;  // Inicio del trazado
            double dt1 = 0.1;  // Paso del trazado

            // Bucle para trazar la parábola punto por punto
            do
            {
                seg1.Xo = t1;  // Coordenada x del punto inicial
                seg1.Yo = (-0.1 * Math.Pow(t1, 2) + 1);  // Coordenada y del punto inicial, calculada con la ecuación de la parábola
                seg1.xf = t1 + dt1;  // Coordenada x del punto final
                seg1.yf = (-0.1 * Math.Pow(seg1.xf, 2) + 1);  // Coordenada y del punto final, calculada con la ecuación de la parábola
                seg1.color0 = Color.Red;  // Color del segmento
                seg1.Encender(bmp);  // Método para dibujar el segmento en el mapa de bits 'bmp'
                t1 += dt1;  // Incremento de t1 para el siguiente punto
            } while (t1 <= 8);

            // Obtén las coordenadas donde se hizo clic
            double t, t2;
            Circunferencia cir = new Circunferencia();
            // Conversión de las coordenadas del clic (x, y) a coordenadas del mundo real (t, t2)
            cir.transform(x, y, out t, out t2);

            // Calcula el valor de y en la parábola en el punto x donde se hizo clic
            double yParabola = -0.1 * Math.Pow(t, 2) + 1;

            // Verificación de si el clic
            if (t2 < yParabola)
            {
                cir.color0 = Color.YellowGreen;
                cir.Rd = 0.2;
                cir.Xo = t;
                cir.Yo = t2;
                cir.Encender(bmp);

                //dibuja el circulo del foco 
                Circunferencia cir2 = new Circunferencia();
                cir2.color0 = Color.Red;
                cir2.transform(x, y, out t, out t2);
                cir2.Rd = 0.2;
                cir2.Xo = 0;
                cir2.Yo = -3.5;
                cir2.Encender(bmp);

                //liena hasta el techo de la parabola
                Segmento seg = new Segmento();
                seg.Xo = t;
                seg.Yo = t2;
                seg.xf = t;
                seg.yf = -0.1 * Math.Pow(t, 2) + 1;  // calcula la y de la parábola
                seg.color0 = Color.Black;
                seg.Encender(bmp);

                // Línea hasta el foco de la parábola y más allá
                Segmento segFoco = new Segmento();
                segFoco.color0 = Color.Black;  // Color a verde para distinguir
                segFoco.Xo = seg.xf;
                segFoco.Yo = seg.yf;

                // Foco de la parábola
                double focoX = 0, focoY = -3.5;









                // Calcula la pendiente m y el intercepto n
                double m = (focoY - seg.yf) / (focoX - seg.xf);
                double n = seg.yf - m * seg.xf;

                double mTangente = -0.2 * t;

                // Calcula el intercepto usando y = mx + b
                double bTangente = yParabola - mTangente * t;

                // Establece las coordenadas para el segmento tangente
                Segmento segTangente = new Segmento();
                segTangente.Xo = -8;
                segTangente.Yo = mTangente * segTangente.Xo + bTangente;
                segTangente.xf = 8;
                segTangente.yf = mTangente * segTangente.xf + bTangente;
                segTangente.color0 = Color.Blue; // Puedes cambiar el color si prefieres
                segTangente.Encender(bmp);

                // (El resto del código sigue igual)

                // Agregar la parábola inversa
                double aParabolaInversa = -0.05; // Ajusta el valor según lo necesario
                double yParabolaInversa = aParabolaInversa * Math.Pow(t, 2) + 1;

                // Línea hasta el punto donde la parábola inversa choca con la línea reflejada
                Segmento segParabolaInversa = new Segmento();
                segParabolaInversa.color0 = Color.Purple;
                segParabolaInversa.Xo = t;
                segParabolaInversa.Yo = t2;
                segParabolaInversa.xf = t;
                segParabolaInversa.yf = yParabolaInversa;
                segParabolaInversa.Encender(bmp);




                segFoco.Encender(bmp);

                pictureBoxPantalla.Image = bmp;

            }
        }



    }
}

























