using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ElkhomsiGauge2020
{
    public partial class UserControl1 : UserControl

        /* declaration des variables Min,Max et Valeur */

    {   
        private float _max = 100;
        [Browsable(true), DefaultValue(100)]
        public float Max
        {
            get { return _max; }
            set
            {
                _max = value;
                Invalidate();
            }
        }


        private float _min = 0;
        [Browsable(true), DefaultValue(0)]
        public float Min
        {
            get { return _min; }
            set
            {
                _min = value;
                Invalidate();
            }
        }

        /* si l'utilisateur introduit une valeur superieur a 100
         * Valeur prend 100 si il introduit une valeur inferieur a zero Valeur prend 0
         */

        private float _valeur = 0;
        [Browsable(true), DefaultValue(0)]
        public float Valeur
        {
            get { return _valeur; }
            set
            {   if (value > 100)
                { _valeur = 100; }

                else if (value < 0)
                { _valeur = 0; }
            else 
                _valeur = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            /* instanciation d'un objet Graphics */

            Graphics g = CreateGraphics();
            /* deux objets Pen pour dessiner les deux rectangles */

            Pen penR1 = new Pen(Color.Green);
            Pen penR2 = new Pen(Color.Yellow);

            /* 3 objets Pen pour dessiner les graduations */

            Pen penGraduation1 = new Pen(Color.Black);
            Pen penGraduation2 = new Pen(Color.Black);
            Pen penGraduation3 = new Pen(Color.Black);
            Pen PenPolygon = new Pen(Color.Chocolate);
            Pen PenCirclePoint = new Pen(Color.DarkBlue);
            /* --------*/
            Brush BrushBigCircle = new SolidBrush(Color.Red);

            Brush BrushText = new SolidBrush(Color.DarkGray);

            /* Objet Font pour ecrire les graduations */

            Font MyFont = new Font("tahoma", 10, FontStyle.Bold);

            /* instanciation de 6 objets Point pour dessiner les graduations */

            Point p1R2 = new Point(155, 20);
            Point p2R2 = new Point(170, 20);
            Point p3R2 = new Point(155, 178);
            Point p4R2 = new Point(170, 178);
            Point p5R2 = new Point(155, 340);
            Point p6R2 = new Point(170, 340);

            /* 8 objets points pour dessiner les petits polygones */

            Point pE1 = new Point(150, 95);
            Point pE2 = new Point(155, 90);
            Point pE3 = new Point(160, 95);
            Point pE4 = new Point(155, 100);

            Point pE5 = new Point(150, 255);
            Point pE6 = new Point(155, 250);
            Point pE7 = new Point(160, 255);
            Point pE8 = new Point(155, 260);

            /* deux tableurs composees des points instanciees plus haut pour dessiner les petits polygones */

            Point[] Allp1 = { pE1, pE2, pE3, pE4 };
            Point[] Allp2 = { pE5, pE6, pE7, pE8 };

            /* trois objets point pour ecrire les textes des graduations */

            Point pointText1 = new Point(110, 10);
            Point pointText2 = new Point(110, 165);
            Point pointText3 = new Point(110, 330);

            
             /* j'ai instancie deux points pour utiliser un objet LineaGradientBrush */

            Point pgb1 = new Point(105, 0);
            Point pgb2 = new Point(210, 0);

            LinearGradientBrush gb1 = new LinearGradientBrush(pgb1, pgb2,Color.LightGray,Color.DarkGray);
            /* ---- tracer le premier rectange ----*/
            g.FillRectangle(gb1, 105, 10, 105, 340);

            /* j'ai instancie deux points pour utiliser un objet LineaGradientBrush */
           
            Point pgb3 = new Point(170, 0);
            Point pgb4 = new Point(190, 0);
            LinearGradientBrush gb2 = new LinearGradientBrush(pgb1, pgb2, Color.FloralWhite, Color.WhiteSmoke);
            /* ---- tracer le deuxieme rectangre ----*/
            g.FillRectangle(gb2, 170, 20, 20, 320);

           

            /* ---- tracer les graduations ----*/
            g.DrawLine(penGraduation1, p1R2, p2R2);
            g.DrawLine(penGraduation1, p3R2, p4R2);
            g.DrawLine(penGraduation1, p5R2, p6R2);

            /*----tracer les polygones ----*/
            g.DrawPolygon(PenPolygon, Allp1);
           g.DrawPolygon(PenPolygon, Allp2);

            /* ---- tracer les petits cercles ----*/

            g.DrawEllipse(PenCirclePoint, 152, 55, 3, 3);
            g.DrawEllipse(PenCirclePoint, 152, 135, 3, 3);
            g.DrawEllipse(PenCirclePoint, 152, 210, 3, 3);
            g.DrawEllipse(PenCirclePoint, 152, 295, 3, 3);

            /* ---- tracer les strings d 'ecriture ----*/
            g.DrawString("100", MyFont, BrushText, pointText1);
           g.DrawString("50", MyFont, BrushText, pointText2);
            g.DrawString("0", MyFont, BrushText, pointText3);

           

            /* On recupere la valeur inscrite par l'utilisateur, en suite on utilise la 
             * formule ci-dessous et on l'affecte a une variable ValeurRemplissage,
             * ensuite on calcule le point y (valy)par lequel on va commencer le remplissage 
             * 
             */

            float ValeurRemplissage = (Valeur * 320 )/ (Max-Min) ;
            float valy = (320 - ValeurRemplissage) + 20;

            /* j'ai instancie deux points pour utiliser un objet LineaGradientBrush */

            Point pgb5 = new Point(170, 0);
            Point pgb6 = new Point(190, 0);

            LinearGradientBrush gb3 = new LinearGradientBrush(pgb5, pgb6, Color.OrangeRed, Color.MediumVioletRed);
            /*---- tracer le troisieme rectangle dynamique ----*/

            g.FillRectangle(gb3, 170, valy, 20, ValeurRemplissage);

            /*---- tracer le cercle dynamique ----*/

            g.FillEllipse(Brushes.OrangeRed, 165, (valy-10), 30, 30);

        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
