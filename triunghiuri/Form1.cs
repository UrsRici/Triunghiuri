using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace triunghiuri
{
    public partial class Form1 : Form
    {
        public Pen penred = new Pen(Color.Red, 3);
        public Pen penorange = new Pen(Color.Orange, 3);
        public Pen penblue = new Pen(Color.DeepSkyBlue, 3);
        public Pen pengreen = new Pen(Color.LightSeaGreen, 3);
        public Pen penblack = new Pen(Color.Black, 4);
        public Pen reset = new Pen(Color.White, 1000000);
        public PointF A, B, C;          //varfurile triunghiului
        public float AB, BC, AC;
        public PointF M, N, P;       //mislocul segmetelor [AB],[AC] si [BC]
        public PointF O, O1, O2, O3;    //ortocentrul cercului si proiectiile punctelor M,N si P pe cerc
        public PointF D, E, F, H;       //inaltimile triunghiului din A, B, C si ortocentrul H
        public PointF T, U, V, I;       //bisectoarele unghiurilor A, B, C si centrul cercului inscris
        public int xPos, yPos, nr_de_puncte = 0;//verifica numarul de puncte care se creaza
        public bool dragging_punct;             //verifica daca se misca vreun punct(A, B sau C)
        public bool mediane_toggle = true, mediatoare_toggle = true, inaltime_toggle = true, bisectoare_toggle = true;
        public bool[] mediana = new bool[4] { false, false, false, false };         //vector de vizibilitate mediane(daca mediana 1 e vizibila atunci mediana[1] == true else mediana[1] == false)
        public bool[] mediatoare = new bool[4] { false, false, false, false };      //vector de vizualizare mediatoare(daca mediatoarea 3 este vizibila mediatoare[3] == true else mediatoare[3] == false)
        public bool[] inaltime = new bool[4] { false, false, false, false };        //vector de vizualizare inaltime(daca inaltimea 2 este vizibila ineltime[2] == true else inaltime[2] == false)
        public bool[] bisectoare = new bool[4] { false, false, false, false };      //vector de vizualizare bisectoare(daca bisectoarea 3 este vizibila bisectoare[3] == true else bisectoare[3] == false)
        public float raza_cercului_circumscris, raza_cercului_inscris;
        public bool muta_puncte = false;
        bool mediane_isactiv = true, mediatoare_isactiv = true, inaltimi_isactiv = true, bisectoare_isactiv = true;


        public Form1()
        {
            InitializeComponent();
            round_label();
        }
        public void round_label()                                           //subprogram care face label-ul rotund
        {
            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0, 0, pointA.Width, pointA.Height);
            Region rg = new Region(obj);
            pointA.Region = rg;
            pointB.Region = rg;
            pointC.Region = rg;
            
            pointM.Region = rg;
            pointN.Region = rg;
            pointP.Region = rg;
            pointG.Region = rg;
            pointO.Region = rg;
            
            pointD.Region = rg;
            pointE.Region = rg;
            pointF.Region = rg;
            pointH.Region = rg;
            
            pointT.Region = rg;
            pointU.Region = rg;
            pointV.Region = rg;
            pointI.Region = rg;
        }

        public void button_reset_Click(object sender, EventArgs e)         //buton resetare
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(reset, -1, -1, this.ClientSize.Width + 1, this.ClientSize.Height + 1);
            nr_de_puncte = 0;
            mediatoare_toggle = true;
            mediane_toggle = true;
            inaltime_toggle = true;
            bisectoare_toggle = true;

            label1.Visible = false;
            label2.Visible = false;

            pointA.Visible = false;
            pointB.Visible = false;
            pointC.Visible = false;
            pointM.Visible = false;
            pointN.Visible = false;
            pointP.Visible = false;
            pointG.Visible = false;
            pointO.Visible = false;
            mediatoare = new bool[] { false, false, false, false };
            mediana = new bool[] { false, false, false, false };

            pointH.Visible = false;
            pointD.Visible = false;
            pointE.Visible = false;
            pointF.Visible = false;
            inaltime = new bool[] { false, false, false, false };

            pointT.Visible = false;
            pointU.Visible = false;
            pointV.Visible = false;
            pointI.Visible = false;
            bisectoare = new bool[] { false, false, false, false };

            CoordonateA.Text = "A(x,y)";
            CoordonateB.Text = "B(x,y)";
            CoordonateC.Text = "C(x,y)";
            unghiulA.Text = "m(<A)=";
            unghiulB.Text = "m(<B)=";
            unghiulC.Text = "m(<C)=";
            lungimea_a.Text = "AB=";
            lungimea_b.Text = "BC=";
            lungimea_c.Text = "CA=";

            if (muta_puncte)
                b_muta_puncte_Click(sender, e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)      //cand click in form se face punctul
        {
            Graphics g = this.CreateGraphics();
            if (nr_de_puncte <= 3 && e.Y > 150)
            {
                Point p = new Point(e.X - 10, e.Y - 10);

                if (true/*calibrari*/)
                {
                    if (e.X - 10 < 0)
                        p.X = 0;
                    if (e.X + 10 > this.ClientSize.Width)
                        p.X = this.ClientSize.Width - 20;
                    if (e.Y - 10 < 152)
                        p.Y = 152;
                    if (e.Y + 10 > this.ClientSize.Height)
                        p.Y = this.ClientSize.Height - 20;
                }

                if (nr_de_puncte == 0)
                {
                    pointA.Location = p;
                    pointA.Visible = true;
                }
                if (nr_de_puncte == 1)
                {
                    pointB.Location = p;
                    A = new Point(pointA.Location.X + 10, pointA.Location.Y + 10);
                    B = new Point(pointB.Location.X + 10, pointB.Location.Y + 10);
                    pointB.Visible = true;
                    g.DrawLine(penblack, A, B);
                }
                if (nr_de_puncte == 2)
                {
                    pointC.Location = p;
                    C = new Point(pointC.Location.X + 10, pointC.Location.Y + 10);                 
                    pointC.Visible = true;
                    g.DrawLine(penblack, A, C);
                    g.DrawLine(penblack, B, C);
                    calculeaza_mediatoarele();
                    calculeaza_inaltimile();
                    calculeaza_bisectaorele();
                    afisare();
                }
                nr_de_puncte++;
            }
        }

        private void b_muta_puncte_Click(object sender, EventArgs e)        //butonul de mutare punte
        {
            if(!muta_puncte)
            {
                muta_puncte = true;
                b_muta_puncte.BackColor = Color.SteelBlue;
                b_muta_puncte.ForeColor = Color.White;
                pointA.Cursor = Cursors.Hand;
                pointB.Cursor = Cursors.Hand;
                pointC.Cursor = Cursors.Hand;
            }
            else
            {
                muta_puncte = false;
                b_muta_puncte.BackColor = Color.Bisque;
                b_muta_puncte.ForeColor = Color.Navy;
                pointA.Cursor = Cursors.Default;
                pointB.Cursor = Cursors.Default;
                pointC.Cursor = Cursors.Default;
            }
        }

        public void afisare()                                               //afiseaza coordonatele lui A, B, C si masura unghiurilor
        {
            CoordonateA.Text = "A(" + (int)(A.X - 10) + ", " + (int)(ClientSize.Height - A.Y - 10) + ")";
            CoordonateB.Text = "B(" + (int)(B.X - 10) + ", " + (int)(ClientSize.Height - B.Y - 10) + ")";
            CoordonateC.Text = "C(" + (int)(C.X - 10) + ", " + (int)(ClientSize.Height - C.Y - 10) + ")";
                
            unghiulA.Text = "m(<A)=" + Math.Round(unghiul_A, 1) + "°";
            unghiulB.Text = "m(<B)=" + Math.Round(unghiul_B, 1) + "°";
            unghiulC.Text = "m(<C)=" + Math.Round(unghiul_C, 1) + "°";

            lungimea_a.Text = "AB=" + (int)AB;
            lungimea_b.Text = "BC=" + (int)BC;
            lungimea_c.Text = "CA=" + (int)AC;
        }

        private void b_adaugare_triunghi_Click(object sender, EventArgs e)  //deschide Form2
        {
            button_reset_Click(sender, e);
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        public void button_stergere_lini_Click(object sender, EventArgs e)  //stergerea tuturor linilor cu exceptia AB, AC si BC
        {
            if(pointA.Visible && pointB.Visible && pointC.Visible)
            {              
                mediatoare_toggle = true;
                mediane_toggle = true;
                inaltime_toggle = true;
                bisectoare_toggle = true;

                pointM.Visible = false;
                pointN.Visible = false;
                pointP.Visible = false;
                pointG.Visible = false;
                pointO.Visible = false;
                mediatoare = new bool[] { false, false, false, false };
                mediana = new bool[] { false, false, false, false };

                pointH.Visible = false;
                pointD.Visible = false;
                pointE.Visible = false;
                pointF.Visible = false;
                inaltime = new bool[] { false, false, false, false };

                pointT.Visible = false;
                pointU.Visible = false;
                pointV.Visible = false;
                pointI.Visible = false;
                bisectoare = new bool[] { false, false, false, false };
                
                Graphics g = CreateGraphics();
                g.DrawLine(reset, -1, -1, this.ClientSize.Width + 1, this.ClientSize.Height + 1);
                g.DrawLine(penblack, A, B);
                g.DrawLine(penblack, C, B);
                g.DrawLine(penblack, A, C);
            }

        }

        public void adaugare_triunghi(Form2 f2)                             //butonul care deschide Form2
        {
            if (A.X != A.X)
            {
                CoordonateA.Text = "A(" + float.NaN + ", " + float.NaN + ")";
                CoordonateB.Text = "B(" + float.NaN + ", " + float.NaN + ")";
                CoordonateC.Text = "C(" + float.NaN + ", " + float.NaN + ")";

                unghiulA.Text = "m(<A)=" + float.NaN + "°";
                unghiulB.Text = "m(<B)=" + float.NaN + "°";
                unghiulC.Text = "m(<C)=" + float.NaN + "°";

                lungimea_a.Text = "AB=" + float.NaN;
                lungimea_b.Text = "BC=" + float.NaN;
                lungimea_c.Text = "CA=" + float.NaN;
            }
            else
            {
                CoordonateA.Text = "A(" + (int)(A.X - 10) + ", " + (int)(ClientSize.Height - A.Y - 10) + ")";
                CoordonateB.Text = "B(" + (int)(B.X - 10) + ", " + (int)(ClientSize.Height - B.Y - 10) + ")";
                CoordonateC.Text = "C(" + (int)(C.X - 10) + ", " + (int)(ClientSize.Height - C.Y - 10) + ")";

                unghiulA.Text = "m(<A)=" + Math.Round(unghiul_A, 1) + "°";
                unghiulB.Text = "m(<B)=" + Math.Round(unghiul_B, 1) + "°";
                unghiulC.Text = "m(<C)=" + Math.Round(unghiul_C, 1) + "°";

                lungimea_a.Text = "AB=" + Math.Round(f2.c);
                lungimea_b.Text = "BC=" + Math.Round(f2.a);
                lungimea_c.Text = "CA=" + Math.Round(f2.b);
                if (pointA.Visible && pointB.Visible && pointC.Visible)
                {
                    nr_de_puncte = 3;
                    calculeaza_mediatoarele();
                    calculeaza_inaltimile();
                    calculeaza_bisectaorele();
                }
            }
            Graphics g = CreateGraphics();
            g.DrawLine(penblack, A, B);
            g.DrawLine(penblack, A, C);
            g.DrawLine(penblack, C, B);
        }

        private void mediane_Click(object sender, EventArgs e)              //buton mediane
        {
            if (mediane_isactiv)
            {
                activare_mediane.BackColor = Color.SteelBlue;
                activare_mediane.ForeColor = Color.White;
                mediane_isactiv = false;

                if (!mediatoare_isactiv)
                    mediatoare_Click(sender, e);
                if (!inaltimi_isactiv)
                    inaltimi_Click(sender, e);
                if (!bisectoare_isactiv)
                    bisectoare_Click(sender, e);

                b_mediana_1.Location = new Point(193, 86);
                b_mediana_2.Location = new Point(328, 86);
                b_mediana_3.Location = new Point(463, 86);
                b_mediane.Location = new Point(598, 86);

                b_mediana_1.Visible = true;
                b_mediana_2.Visible = true;
                b_mediana_3.Visible = true;
                b_mediane.Visible = true;
            }
            else
            {
                activare_mediane.BackColor = Color.Bisque;
                activare_mediane.ForeColor = Color.Navy;
                mediane_isactiv = true;

                b_mediana_1.Visible = false;
                b_mediana_2.Visible = false;
                b_mediana_3.Visible = false;
                b_mediane.Visible = false;
            }
        }

        private void mediatoare_Click(object sender, EventArgs e)           //buton mediatoare
        {
            if (mediatoare_isactiv)
            {
                activare_mediatoare.BackColor = Color.SteelBlue;
                activare_mediatoare.ForeColor = Color.White;
                mediatoare_isactiv = false;

                if (!mediane_isactiv)
                    mediane_Click(sender, e);
                if (!inaltimi_isactiv)
                    inaltimi_Click(sender, e);
                if (!bisectoare_isactiv)
                    bisectoare_Click(sender, e);
                
                b_mediatoarea_1.Location = new Point(193, 86);
                b_mediatoarea_2.Location = new Point(328, 86);
                b_mediatoarea_3.Location = new Point(463, 86);
                b_mediatoare.Location = new Point(598, 86);

                b_mediatoarea_1.Visible = true;
                b_mediatoarea_2.Visible = true;
                b_mediatoarea_3.Visible = true;
                b_mediatoare.Visible = true;
            }
            else
            {
                activare_mediatoare.BackColor = Color.Bisque;
                activare_mediatoare.ForeColor = Color.Navy;
                mediatoare_isactiv = true;
                
                b_mediatoarea_1.Visible = false;
                b_mediatoarea_2.Visible = false;
                b_mediatoarea_3.Visible = false;
                b_mediatoare.Visible = false;
            }
        }
        
        private void inaltimi_Click(object sender, EventArgs e)             //buton inaltimi
        {
            if (inaltimi_isactiv)
            {
                activare_inaltimi.BackColor = Color.SteelBlue;
                activare_inaltimi.ForeColor = Color.White;
                inaltimi_isactiv = false;
                
                if (!mediane_isactiv)
                    mediane_Click(sender, e);
                if (!mediatoare_isactiv)
                    mediatoare_Click(sender, e);
                if (!bisectoare_isactiv)
                    bisectoare_Click(sender, e);

                b_inaltime_1.Location = new Point(193, 86);
                b_inaltime_2.Location = new Point(328, 86);
                b_inaltime_3.Location = new Point(463, 86);
                b_inaltime.Location = new Point(598, 86);

                b_inaltime_1.Visible = true;
                b_inaltime_2.Visible = true;
                b_inaltime_3.Visible = true;
                b_inaltime.Visible = true;
            }
            else
            {
                activare_inaltimi.BackColor = Color.Bisque;
                activare_inaltimi.ForeColor = Color.Navy;
                inaltimi_isactiv = true;

                b_inaltime_1.Visible = false;
                b_inaltime_2.Visible = false;
                b_inaltime_3.Visible = false;
                b_inaltime.Visible = false;
            }
        }

        private void bisectoare_Click(object sender, EventArgs e)           //buton bisectoare
        {
            if (bisectoare_isactiv)
            {
                activare_bisectoare.BackColor = Color.SteelBlue;
                activare_bisectoare.ForeColor = Color.White;
                bisectoare_isactiv = false;
                
                if (!mediane_isactiv)
                    mediane_Click(sender, e);
                if (!mediatoare_isactiv)
                    mediatoare_Click(sender, e);
                if (!inaltimi_isactiv)
                    inaltimi_Click(sender, e);

                b_bisectoare_1.Location = new Point(193, 86);
                b_bisectoare_2.Location = new Point(328, 86);
                b_bisectoare_3.Location = new Point(463, 86);
                b_bisectoare.Location = new Point(598, 86);

                b_bisectoare_1.Visible = true;
                b_bisectoare_2.Visible = true;
                b_bisectoare_3.Visible = true;
                b_bisectoare.Visible = true;
            }
            else
            {
                activare_bisectoare.BackColor = Color.Bisque;
                activare_bisectoare.ForeColor = Color.Navy;
                bisectoare_isactiv = true;

                b_bisectoare_1.Visible = false;
                b_bisectoare_2.Visible = false;
                b_bisectoare_3.Visible = false;
                b_bisectoare.Visible = false;
            }
        }
       
        /*Finalul butoanelor 
                si 
        inceputul interactiunilor*/
        private void point_MouseHover(object sender, EventArgs e)          //cand ai mousul pe punct
        {
            coordonate_point.Visible = true;
            if(sender.Equals(pointM))
                coordonate_point.Text = "M(" + (int)(M.X - 10) + ", " + (int)(ClientSize.Height - M.Y - 10) + ")";
            if (sender.Equals(pointN))
                coordonate_point.Text = "N(" + (int)(N.X - 10) + ", " + (int)(ClientSize.Height - N.Y - 10) + ")";
            if (sender.Equals(pointP))
                coordonate_point.Text = "P(" + (int)(P.X - 10) + ", " + (int)(ClientSize.Height - P.Y - 10) + ")";
            if (sender.Equals(pointG))
                coordonate_point.Text = "G(" + (pointG.Location.X) + ", " + (ClientSize.Height - pointG.Location.Y - 20) + ")";
            if (sender.Equals(pointO))
                coordonate_point.Text = "O(" + (int)(O.X - 10) + ", " + (int)(ClientSize.Height - O.Y - 10) + ")";
            if (sender.Equals(pointD))
                coordonate_point.Text = "D(" + (int)(D.X - 10) + ", " + (int)(ClientSize.Height - D.Y - 10) + ")";
            if (sender.Equals(pointE))
                coordonate_point.Text = "E(" + (int)(E.X - 10) + ", " + (int)(ClientSize.Height - E.Y - 10) + ")";
            if (sender.Equals(pointF))
                coordonate_point.Text = "F(" + (int)(F.X - 10) + ", " + (int)(ClientSize.Height - F.Y - 10) + ")";
            if (sender.Equals(pointI))
                coordonate_point.Text = "I(" + (int)(I.X - 10) + ", " + (int)(ClientSize.Height - I.Y - 10) + ")";
            if (sender.Equals(pointT))
                coordonate_point.Text = "T(" + (int)(T.X - 10) + ", " + (int)(ClientSize.Height - T.Y - 10) + ")";
            if (sender.Equals(pointU))
                coordonate_point.Text = "U(" + (int)(U.X - 10) + ", " + (int)(ClientSize.Height - U.Y - 10) + ")";
            if (sender.Equals(pointV))
                coordonate_point.Text = "V(" + (int)(V.X - 10) + ", " + (int)(ClientSize.Height - V.Y - 10) + ")";
            if (sender.Equals(pointH))
                coordonate_point.Text = "H(" + (int)(H.X - 10) + ", " + (int)(ClientSize.Height - H.Y - 10) + ")";
        }

        private void point_MouseHoverLeave(object sender, EventArgs e)     //cand iei mousul de pe punct
        {
            coordonate_point.Visible = false;
        }

        public void point_MouseUp(object sender, MouseEventArgs e)         //cand leftclick nu e apasat
        {
            if (muta_puncte)
            {
                dragging_punct = false;
                miscare_punct(sender, e);
            }
        }

        private void point_MouseMove(object sender, MouseEventArgs e)       //cand mousul se misca
        {
            Control c = sender as Control;
            if (dragging_punct && c != null)
            {
                // Calculul noilor poziții
                int newTop = e.Y + c.Top - yPos;
                int newLeft = e.X + c.Left - xPos;

                // Limitarea noilor poziții la interiorul ferestrei
                newTop = Math.Max(152, Math.Min(newTop, this.ClientSize.Height - c.Height));
                newLeft = Math.Max(0, Math.Min(newLeft, this.ClientSize.Width - c.Width));

                // Setarea noilor poziții ale controlului
                c.Top = newTop;
                c.Left = newLeft;
            }
        }

        private void point_MouseDown(object sender, MouseEventArgs e)       //cant leftclick e apasat
        {
            if (e.Button == MouseButtons.Left && muta_puncte)
            {
                Graphics g = this.CreateGraphics();
                g.DrawLine(reset, -1, -1, this.ClientSize.Width + 1, this.ClientSize.Height + 1);
                pointM.Visible = false;
                pointN.Visible = false;
                pointP.Visible = false;
                pointG.Visible = false;
                pointO.Visible = false;
                
                pointH.Visible = false;
                pointD.Visible = false;
                pointE.Visible = false;
                pointF.Visible = false;
                
                pointI.Visible = false;
                pointT.Visible = false;
                pointU.Visible = false;
                pointV.Visible = false;

                dragging_punct = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }

        public void miscare_punct(object sender, MouseEventArgs e)         //redesenarea triunghiului daca un punct se muta
        {
            label1.Visible = false; label2.Visible = false;
            Graphics g = CreateGraphics();
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                A = new Point(pointA.Location.X + 10, pointA.Location.Y + 10);
                B = new Point(pointB.Location.X + 10, pointB.Location.Y + 10);
                C = new Point(pointC.Location.X + 10, pointC.Location.Y + 10);

                verificare_lini_miscare(sender, e);
            }
            else if (pointA.Visible && pointB.Visible && !pointC.Visible)
            {
                A = new Point(pointA.Location.X + 10, pointA.Location.Y + 10);
                B = new Point(pointB.Location.X + 10, pointB.Location.Y + 10);
                g.DrawLine(penblack, A, B);
            }

            afisare();
        }

        public void verificare_lini_miscare(object sender, EventArgs e)     //la stergerea unei lini se verifica daca alte lini sunt vizibile daca sunt acestea se redeseneaza(in cazul in care un punct A,B sau C isi schimba locatia)
        {
            ////ADAUGARE PUNCT////
            calculeaza_mediatoarele();
            calculeaza_inaltimile();
            calculeaza_bisectaorele();

            verificare_lini(sender, e);
        }

        public void verificare_lini(object sender, EventArgs e)             //la stergerea unei lini se verifica daca alte lini sunt vizibile daca sunt acestea se redeseneaza
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(reset, -1, -1, this.ClientSize.Width + 1, this.ClientSize.Height + 1);

            ////ADAUGARE PUNCT////
            verificare_mediane();
            verificare_mediatoare();
            verificare_inaltimi();
            verificare_bisectoare();

            g.DrawLine(penblack, A, B);
            g.DrawLine(penblack, A, C);
            g.DrawLine(penblack, B, C);
        }

        //MEDIANE START//
        public void verificare_mediane()                                    //verifica medianele
        {
            Graphics g = CreateGraphics();
            if (mediana[1])
            {
                pointM.Location = new Point((int)(B.X + C.X) / 2 - 10, (int)(B.Y + C.Y) / 2 - 10);
                M = new Point(pointM.Location.X + 10, pointM.Location.Y + 10);
                pointM.Visible = true;
            }
            if (mediana[2])
            {
                pointN.Location = new Point((int)(A.X + C.X) / 2 - 10, (int)(A.Y + C.Y) / 2 - 10);
                N = new Point(pointN.Location.X + 10, pointN.Location.Y + 10);
                pointN.Visible = true;
            }
            if (mediana[3])
            {
                pointP.Location = new Point((int)(A.X + B.X) / 2 - 10, (int)(A.Y + B.Y) / 2 - 10);
                P = new Point(pointP.Location.X + 10, pointP.Location.Y + 10);
                pointP.Visible = true;
            }
            centru_de_greutate();
            if (mediana[1])
                g.DrawLine(penred, A, M);
            if (mediana[2])
                g.DrawLine(penred, B, N);
            if (mediana[3])
                g.DrawLine(penred, C, P);
        }

        public void centru_de_greutate()                                    //verifivca daca cel putin 2 mediane si pune punctul G
        {
            if (mediana[1] && mediana[2] || mediana[1] && mediana[3] || mediana[2] && mediana[3])
            {
                pointG.Location = new Point((int)(A.X + B.X + C.X) / 3 - 10, (int)(A.Y + B.Y + C.Y) / 3 - 10);
                pointG.Visible = true;
            }
            else
            {
                pointG.Visible = false;
                //verificare_mediatoare();
                //verificare_inaltimi();
            }
        }

        private void b_mediane_Click(object sender, EventArgs e)            //buton toate medianele
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!mediana[1] && !mediana[2] && !mediana[3] && !mediane_toggle)   //cazul in care medianele au fost desenate separat, butonul va sterge toate medianele
                    mediane_toggle = true;

                if (mediana[1] && mediana[2] && mediana[3] && mediane_toggle)        //cazul in care medianele au fost sterse separat, butonul va desena toate medianele
                    mediane_toggle = false;

                if (mediane_toggle)
                {
                    pointG.Location = new Point((int)(A.X + B.X + C.X) / 3 - 10, (int)(A.Y + B.Y + C.Y) / 3 - 10);
                    pointG.Visible = true;
                    mediana[1] = true;
                    mediana[2] = true;
                    mediana[3] = true;
                    verificare_mediane();

                    mediane_toggle = false;
                }
                else
                {
                    Graphics g = this.CreateGraphics();
                    g.DrawLine(reset, -1, -1, this.ClientSize.Width + 1, this.ClientSize.Height + 1);

                    pointG.Visible = false;
                    pointM.Visible = false; mediana[1] = false;
                    pointN.Visible = false; mediana[2] = false;
                    pointP.Visible = false; mediana[3] = false;

                    verificare_mediatoare();
                    verificare_inaltimi();
                    verificare_bisectoare();

                    g.DrawLine(penblack, A, B);
                    g.DrawLine(penblack, A, C);
                    g.DrawLine(penblack, B, C);

                    mediane_toggle = true;
                }

            }
        }

        private void b_mediana_1_Click(object sender, EventArgs e)          //buton mediana din A
        {
            Graphics g = CreateGraphics();
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!mediana[1])
                {
                    mediana[1] = true;
                    verificare_mediane();
                }
                else
                {
                    pointM.Visible = false;
                    mediana[1] = false;

                    verificare_lini(sender, e);
                }
            }
        }

        private void b_mediana_2_Click(object sender, EventArgs e)          //buton mediana din B
        {
            Graphics g = this.CreateGraphics();
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!mediana[2])
                {
                    mediana[2] = true;
                    verificare_mediane();
                }
                else
                {
                    pointN.Visible = false;
                    mediana[2] = false;

                    verificare_lini(sender, e);
                }
            }
        }

        private void b_mediana_3_Click(object sender, EventArgs e)          //buton mediana din C
        {
            Graphics g = this.CreateGraphics();
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!mediana[3])
                {
                    mediana[3] = true;
                    verificare_mediane();
                }
                else
                {
                    pointP.Visible = false;
                    mediana[3] = false;

                    verificare_lini(sender, e);
                }
            }
        }
        //MEDIANE FINISH//

        //MEDIATOARE START//
        public void verificare_mediatoare()                                 //verifica mediatoarele
        {
            Graphics g = CreateGraphics();
            Brush b = new SolidBrush(Color.Orange);
            if (mediatoare[1] && mediatoare[2] && mediatoare[3])
            {               //verificarea mediatoarelor cand sunt toate vizibile
                float raza = raza_cercului_circumscris;
                g.DrawEllipse(penorange, O.X - raza, O.Y - raza, raza * 2, raza * 2);
                g.DrawLine(penorange, O, O1); g.FillEllipse(b, O1.X - 4, O1.Y - 4, 8, 8);
                g.DrawLine(penorange, O, O2); g.FillEllipse(b, O2.X - 4, O2.Y - 4, 8, 8);
                g.DrawLine(penorange, O, O3); g.FillEllipse(b, O3.X - 4, O3.Y - 4, 8, 8);

                if(BC > 30)
                    g.DrawLines(penorange, pM);//   afisarea
                if(AC > 30)
                    g.DrawLines(penorange, pN);//   patratelelor
                if(AB > 30)
                    g.DrawLines(penorange, pP);//   de perpendicularitate

                pointM.Location = new Point((int)(B.X + C.X) / 2 - 10, (int)(B.Y + C.Y) / 2 - 10);
                pointN.Location = new Point((int)(A.X + C.X) / 2 - 10, (int)(A.Y + C.Y) / 2 - 10);
                pointP.Location = new Point((int)(B.X + A.X) / 2 - 10, (int)(B.Y + A.Y) / 2 - 10);
                pointM.Visible = true;
                pointN.Visible = true;
                pointP.Visible = true;
                pointO.Visible = true;
            }               //verificarea mediatoarelor separat
            else
            {
                centrul_cercului_circumscris();
                if (mediatoare[1])
                {
                    g.DrawLine(penorange, O, O1);
                    if (BC > 30)
                        g.DrawLines(penorange, pM);//   afisarea
                    pointM.Visible = true;
                }
                if (mediatoare[2])
                {
                    g.DrawLine(penorange, O, O2);
                    if (AC > 30)
                        g.DrawLines(penorange, pN);//   patratelelor
                    pointN.Visible = true;
                }
                if (mediatoare[3])
                {
                    g.DrawLine(penorange, O, O3);
                    if (AB > 30)
                        g.DrawLines(penorange, pP);//   de perpendicularitate
                    pointP.Visible = true;
                }
                if (mediatoare[1] && mediatoare[2] || mediatoare[2] && mediatoare[3] || mediatoare[1] && mediatoare[3])
                {
                    float raza = raza_cercului_circumscris;
                    pointO.Visible = true;
                    g.DrawEllipse(penorange, O.X - raza, O.Y - raza, raza * 2, raza * 2);
                    if (mediatoare[1] && mediatoare[2])
                    {
                        g.FillEllipse(b, O1.X - 4, O1.Y - 4, 8, 8);
                        g.FillEllipse(b, O2.X - 4, O2.Y - 4, 8, 8);
                    }
                    else if (mediatoare[2] && mediatoare[3])
                    {
                        g.FillEllipse(b, O3.X - 4, O3.Y - 4, 8, 8);
                        g.FillEllipse(b, O2.X - 4, O2.Y - 4, 8, 8);
                    }
                    else
                    {
                        g.FillEllipse(b, O1.X - 4, O1.Y - 4, 8, 8);
                        g.FillEllipse(b, O3.X - 4, O3.Y - 4, 8, 8);
                    }
                }
            }
            g.DrawLine(penblack, A, B);
            g.DrawLine(penblack, B, C);
            g.DrawLine(penblack, A, C);
        }

        public void centrul_cercului_circumscris()                          //verifica daca exista cel putin 2 mediatoare si pune punctul de O
        {
            Graphics g = this.CreateGraphics();
            if (mediatoare[1] && mediatoare[2] || mediatoare[1] && mediatoare[3] || mediatoare[2] && mediatoare[3])
            {
                float raza = raza_cercului_circumscris;
                g.DrawEllipse(penorange, O.X - raza, O.Y - raza, raza * 2, raza * 2);
                pointO.Visible = true;
            }
            else
            {
                pointO.Visible = false;
                //verificare_mediane();
                //verificare_inaltimi();
            }
        }

        private void b_mediatoare_Click(object sender, EventArgs e)         //buton toate mediatoarelor
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!mediatoare[1] && !mediatoare[2] && !mediatoare[3] && !mediatoare_toggle)
                    mediatoare_toggle = true;
                if (mediatoare[1] && mediatoare[2] && mediatoare[3] && mediatoare_toggle)
                    mediatoare_toggle = false;
                if (mediatoare_toggle)
                {
                    pointM.Visible = true; mediatoare[1] = true;
                    pointN.Visible = true; mediatoare[2] = true;
                    pointP.Visible = true; mediatoare[3] = true;
                    pointO.Visible = true;
                    verificare_mediatoare();

                    mediatoare_toggle = false;
                }
                else
                {
                    pointM.Visible = false; mediatoare[1] = false;
                    pointN.Visible = false; mediatoare[2] = false;
                    pointP.Visible = false; mediatoare[3] = false;
                    pointO.Visible = false;
                    verificare_lini(sender, e);

                    mediatoare_toggle = true;

                }
            }
        }

        private void b_mediatoarea_1_Click(object sender, EventArgs e)      //buton mediatoarea lui [BC]
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!mediatoare[1])
                {
                    mediatoare[1] = true;
                    verificare_mediatoare();
                }
                else
                {
                    pointM.Visible = false; mediatoare[1] = false;
                    verificare_lini(sender, e);
                }
            }
        }

        private void b_mediatoarea_2_Click(object sender, EventArgs e)      //buton mediatoarea lui [AC]
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!mediatoare[2])
                {
                    mediatoare[2] = true;
                    verificare_mediatoare();
                }
                else
                {
                    pointN.Visible = false; mediatoare[2] = false;
                    verificare_lini(sender, e);
                }
            }
        }

        private void b_mediatoarea_3_Click(object sender, EventArgs e)      //buton mediatoarea lui [AB]
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!mediatoare[3])
                {
                    mediatoare[3] = true;
                    verificare_mediatoare();
                }
                else
                {
                    pointP.Visible = false; mediatoare[3] = false;
                    verificare_lini(sender, e);
                }
            }
        }

        //constante pentru determinarea ecuatiilor dreptelor ce fomreaza mediatoare M si patratelul mic(Y = m * X + n)
        public float[] mM = new float[4];
        public float[] nM = new float[4];
        public PointF[] pM = new PointF[3];
        //constante pentru determinarea ecuatiilor dreptelor ce fomreaza mediatoare N si patratelul mic(Y = m * X + n)
        public float[] mN = new float[4];
        public float[] nN = new float[4];
        public PointF[] pN = new PointF[3];
        //constante pentru determinarea ecuatiilor dreptelor ce fomreaza mediatoare P si patratelul mic(Y = m * X + n)
        public float[] mP = new float[4];
        public float[] nP = new float[4];
        public PointF[] pP = new PointF[3];
        public void calculeaza_mediatoarele()               //programul care calculeaza centrul cercului circumscris O
        {
            pointM.Location = new Point((int)(B.X + C.X) / 2 - 10, (int)(B.Y + C.Y) / 2 - 10);
            pointN.Location = new Point((int)(A.X + C.X) / 2 - 10, (int)(A.Y + C.Y) / 2 - 10);
            pointP.Location = new Point((int)(B.X + A.X) / 2 - 10, (int)(B.Y + A.Y) / 2 - 10);

            M = new PointF((B.X + C.X) / 2, (B.Y + C.Y) / 2);
            mM[1] = -(float)(B.X - C.X) / (float)(B.Y - C.Y);
            nM[1] = M.Y - mM[1] * M.X;

            N = new PointF((A.X + C.X) / 2, (A.Y + C.Y) / 2);
            mN[1] = -(float)(C.X - A.X) / (float)(C.Y - A.Y);
            nN[1] = N.Y - mN[1] * N.X;

            P = new PointF((B.X + A.X) / 2, (B.Y + A.Y) / 2);
            mP[1] = -(float)(B.X - A.X) / (float)(B.Y - A.Y);
            nP[1] = P.Y - mP[1] * P.X;

            if (B.Y == A.Y) //verificarea daca 2 puncte au acelasi Y
            {               //(daca au acelasi Y la calcularea lui m va rezulta /0 =>eroare)
                O.X = (float)(nN[1] - nM[1]) / (float)(mM[1] - mN[1]);
                O.Y = mM[1] * O.X + nM[1];
            }
            else if (C.Y == A.Y)
            {
                O.X = (float)(nP[1] - nM[1]) / (float)(mM[1] - mP[1]);
                O.Y = mM[1] * O.X + nM[1];
            }
            else
            {
                O.X = (float)(nN[1] - nP[1]) / (float)(mP[1] - mN[1]);
                O.Y = mP[1] * O.X + nP[1];
            }

            pointO.Location = new Point((int)(O.X - 10), (int)(O.Y - 10));
            raza_cercului_circumscris = (float)Math.Sqrt((O.X - A.X) * (O.X - A.X) + (O.Y - A.Y) * (O.Y - A.Y));
            float raza = raza_cercului_circumscris;

            mediatoare_din_M();
            mediatoare_din_N();
            mediatoare_din_P();
        }

        public void mediatoare_din_M()                                      //calcularea mediataorei M si a patratelului mic
        {
            float raza = raza_cercului_circumscris;
            if (Math.Abs(B.Y - C.Y) <= 2)
            {
                if (M.Y > O.Y)
                    O1 = new PointF(O.X, O.Y + raza);
                else
                    O1 = new PointF(O.X, O.Y - raza);

                if (M.Y - O.Y > 30 || M.Y - O.Y < 0 && M.Y - O.Y > -30)
                {
                    pM[0] = new PointF(M.X, M.Y - 15);
                    pM[1] = new PointF(M.X - 15, M.Y - 15);
                    pM[2] = new PointF(M.X - 15, M.Y);
                }
                else
                {
                    pM[0] = new PointF(M.X, M.Y + 15);
                    pM[1] = new PointF(M.X - 15, M.Y + 15);
                    pM[2] = new PointF(M.X - 15, M.Y);
                }
            }
            else if (Math.Abs(B.X - C.X) <= 2)
            {
                if (M.X > O.X)
                    O1 = new PointF(O.X + raza, O.Y);
                else
                    O1 = new PointF(O.X - raza, O.Y);
                if (M.X - O.X > 30 || M.X - O.X < 0 && M.X - O.X > -30)
                {
                    pM[0] = new PointF(M.X - 15, M.Y);
                    pM[1] = new PointF(M.X - 15, M.Y - 15);
                    pM[2] = new PointF(M.X, M.Y - 15);
                }
                else
                {
                    pM[0] = new PointF(M.X + 15, M.Y);
                    pM[1] = new PointF(M.X + 15, M.Y - 15);
                    pM[2] = new PointF(M.X, M.Y - 15);
                }
            }
            else
            {
                float dO, dM;
                float OM = (float)Math.Sqrt((O.X - M.X) * (O.X - M.X) + (O.Y - M.Y) * (O.Y - M.Y));

                for (float i = O.X - raza - 0.001f; i < O.X + raza + 0.002f; i += 0.001f)
                {
                    float j = mM[1] * i + nM[1];
                    dO = (float)Math.Sqrt((O.X - i) * (O.X - i) + (O.Y - j) * (O.Y - j));
                    dM = (float)Math.Sqrt((M.X - i) * (M.X - i) + (M.Y - j) * (M.Y - j));
                    if (pointM.Location == pointO.Location)
                    {
                        if ((int)dO == (int)raza)
                        {
                            O1 = new PointF(i, j);
                            break;
                        }
                    }
                    else
                    {
                        if ((int)dO == (int)raza && dM < dO)
                        {
                            O1 = new PointF(i, j);
                            break;
                        }
                    }
                }

                for (float i = M.X - 15; i < M.X + 15.01f; i += 0.01f)
                {
                    float j = mM[1] * i + nM[1];
                    dM = (float)Math.Sqrt((M.X - i) * (M.X - i) + (M.Y - j) * (M.Y - j));
                    dO = (float)Math.Sqrt((O.X - i) * (O.X - i) + (O.Y - j) * (O.Y - j));
                    float dO1 = (float)Math.Sqrt((O1.X - i) * (O1.X - i) + (O1.Y - j) * (O1.Y - j));
                    if (pointM.Location == pointO.Location)
                    {
                        if ((int)dM == 15 && dO1 - raza < 0)
                        {
                            pM[0] = new PointF(i, j);
                            break;
                        }
                    }
                    else
                    {
                        if ((int)dM == 15 && dO > dM)
                        {
                            pM[0] = new PointF(i, j);
                            if (OM > dO)
                                break;
                        }
                    }
                }

                mM[2] = (float)-1 / (float)mM[1];
                nM[2] = pM[0].Y - pM[0].X * mM[2];
                for (float i = pM[0].X - 15; i < pM[0].X + 0.01f; i += 0.01f)
                {
                    float j = mM[2] * i + nM[2];
                    float distanta = (float)Math.Sqrt((pM[0].X - i) * (pM[0].X - i) + (pM[0].Y - j) * (pM[0].Y - j));

                    if ((int)distanta == 15)
                    {
                        pM[1] = new PointF(i, j);
                        break;
                    }
                }

                mM[0] = mM[2];
                nM[0] = M.Y - mM[0] * M.X;
                mM[3] = mM[1];
                nM[3] = pM[1].Y - mM[3] * pM[1].X;

                pM[2].X = (float)(nM[3] - nM[0]) / (float)(mM[0] - mM[3]);
                pM[2].Y = mM[0] * pM[2].X + nM[0];
            }
        }

        public void mediatoare_din_N()                                      //calcularea mediataorei N si a patratelului mic
        {
            float raza = raza_cercului_circumscris;
            if (Math.Abs(A.Y - C.Y) <= 2)
            {
                if (N.Y > O.Y)
                    O2 = new PointF(O.X, O.Y + raza);
                else
                    O2 = new PointF(O.X, O.Y - raza);

                if (N.Y - O.Y > 30 || N.Y - O.Y < 0 && N.Y - O.Y > -30)
                {
                    pN[0] = new PointF(N.X, N.Y - 15);
                    pN[1] = new PointF(N.X - 15, N.Y - 15);
                    pN[2] = new PointF(N.X - 15, N.Y);
                }
                else
                {
                    pN[0] = new PointF(N.X, N.Y + 15);
                    pN[1] = new PointF(N.X - 15, N.Y + 15);
                    pN[2] = new PointF(N.X - 15, N.Y);
                }
            }
            else if (Math.Abs(A.X - C.X) <= 2)
            {
                if (N.X > O.X)
                    O2 = new PointF(O.X + raza, O.Y);
                else
                    O2 = new PointF(O.X - raza, O.Y);
                if (N.X - O.X > 30 || N.X - O.X < 0 && N.X - O.X > -30)
                {
                    pN[0] = new PointF(N.X - 15, N.Y);
                    pN[1] = new PointF(N.X - 15, N.Y - 15);
                    pN[2] = new PointF(N.X, N.Y - 15);
                }
                else
                {
                    pN[0] = new PointF(N.X + 15, N.Y);
                    pN[1] = new PointF(N.X + 15, N.Y - 15);
                    pN[2] = new PointF(N.X, N.Y - 15);
                }
            }
            else
            {
                float dO, dN;
                float ON = (float)Math.Sqrt((O.X - N.X) * (O.X - N.X) + (O.Y - N.Y) * (O.Y - N.Y));

                for (float i = O.X - raza - 0.001f; i < O.X + raza + 0.002f; i += 0.001f)
                {
                    float j = mN[1] * i + nN[1];
                    dO = (float)Math.Sqrt((O.X - i) * (O.X - i) + (O.Y - j) * (O.Y - j));
                    dN = (float)Math.Sqrt((N.X - i) * (N.X - i) + (N.Y - j) * (N.Y - j));
                    if (pointN.Location == pointO.Location)
                    {
                        if ((int)dO == (int)raza)
                        {
                            O2 = new PointF(i, j);
                            break;
                        }
                    }
                    else
                    {
                        if ((int)dO == (int)raza && dN < dO)
                        {
                            O2 = new PointF(i, j);
                            break;
                        }
                    }
                }

                for (float i = N.X - 15; i < N.X + 15.01f; i += 0.01f)
                {
                    float j = mN[1] * i + nN[1];
                    dN = (float)Math.Sqrt((N.X - i) * (N.X - i) + (N.Y - j) * (N.Y - j));
                    dO = (float)Math.Sqrt((O.X - i) * (O.X - i) + (O.Y - j) * (O.Y - j));
                    float dO2 = (float)Math.Sqrt((O2.X - i) * (O2.X - i) + (O2.Y - j) * (O2.Y - j));
                    if (pointN.Location == pointO.Location)
                    {
                        if ((int)dN == 15 && dO2 - raza < 0)
                        {
                            pN[0] = new PointF(i, j);
                            break;
                        }
                    }
                    else
                    {
                        if ((int)dN == 15 && dO > dN)
                        {
                            pN[0] = new PointF(i, j);
                            if (ON > dO)
                                break;
                        }
                    }
                }

                mN[2] = (float)-1 / (float)mN[1];
                nN[2] = pN[0].Y - pN[0].X * mN[2];
                for (float i = pN[0].X - 15; i < pN[0].X + 0.01f; i += 0.01f)
                {
                    float j = mN[2] * i + nN[2];
                    float distanta = (float)Math.Sqrt((pN[0].X - i) * (pN[0].X - i) + (pN[0].Y - j) * (pN[0].Y - j));

                    if ((int)distanta == 15)
                    {
                        pN[1] = new PointF(i, j);
                        break;
                    }
                }

                mN[0] = mN[2];
                nN[0] = N.Y - mN[0] * N.X;
                mN[3] = mN[1];
                nN[3] = pN[1].Y - mN[3] * pN[1].X;

                pN[2].X = (float)(nN[3] - nN[0]) / (float)(mN[0] - mN[3]);
                pN[2].Y = mN[0] * pN[2].X + nN[0];
            }
        }

        public void mediatoare_din_P()                                      //calcularea mediataorei P si a patratelului mic
        {
            float raza = raza_cercului_circumscris;
            if (Math.Abs(B.Y - A.Y) <= 2)
            {
                if (P.Y > O.Y)
                    O3 = new PointF(O.X, O.Y + raza);
                else
                    O3 = new PointF(O.X, O.Y - raza);

                if (P.Y - O.Y > 30 || P.Y - O.Y < 0 && P.Y - O.Y > -30)
                {
                    pP[0] = new PointF(P.X, P.Y - 15);
                    pP[1] = new PointF(P.X - 15, P.Y - 15);
                    pP[2] = new PointF(P.X - 15, P.Y);
                }
                else
                {
                    pP[0] = new PointF(P.X, P.Y + 15);
                    pP[1] = new PointF(P.X - 15, P.Y + 15);
                    pP[2] = new PointF(P.X - 15, P.Y);
                }
            }
            else if (Math.Abs(B.X - A.X) <= 2)
            {
                if (P.X > O.X)
                    O3 = new PointF(O.X + raza, O.Y);
                else
                    O3 = new PointF(O.X - raza, O.Y);
                if (P.X - O.X > 30 || P.X - O.X < 0 && P.X - O.X > -30)
                {
                    pP[0] = new PointF(P.X - 15, P.Y);
                    pP[1] = new PointF(P.X - 15, P.Y - 15);
                    pP[2] = new PointF(P.X, P.Y - 15);
                }
                else
                {
                    pP[0] = new PointF(P.X + 15, P.Y);
                    pP[1] = new PointF(P.X + 15, P.Y - 15);
                    pP[2] = new PointF(P.X, P.Y - 15);
                }
            }
            else
            {

                float dO, dP;
                float OP = (float)Math.Sqrt((O.X - P.X) * (O.X - P.X) + (O.Y - P.Y) * (O.Y - P.Y));

                for (float i = O.X - raza - 0.001f; i < O.X + raza + 0.002f; i += 0.001f)
                {
                    float j = mP[1] * i + nP[1];
                    dO = (float)Math.Sqrt((O.X - i) * (O.X - i) + (O.Y - j) * (O.Y - j));
                    dP = (float)Math.Sqrt((P.X - i) * (P.X - i) + (P.Y - j) * (P.Y - j));
                    if (pointP.Location == pointO.Location)
                    {
                        if ((int)dO == (int)raza)
                        {
                            O3 = new PointF(i, j);
                            break;
                        }
                    }
                    else
                    {
                        if ((int)dO == (int)raza && dP < dO)
                        {
                            O3 = new PointF(i, j);
                            break;
                        }
                    }
                }

                for (float i = P.X - 15; i < P.X + 15.01f; i += 0.01f)
                {
                    float j = mP[1] * i + nP[1];
                    dP = (float)Math.Sqrt((P.X - i) * (P.X - i) + (P.Y - j) * (P.Y - j));
                    dO = (float)Math.Sqrt((O.X - i) * (O.X - i) + (O.Y - j) * (O.Y - j));
                    float dO3 = (float)Math.Sqrt((O3.X - i) * (O3.X - i) + (O3.Y - j) * (O3.Y - j));
                    if (pointP.Location == pointO.Location)
                    {
                        if ((int)dP == 15 && dO3 - raza < 0)
                        {
                            pP[0] = new PointF(i, j);
                            break;
                        }
                    }
                    else
                    {
                        if ((int)dP == 15 && dO > dP)
                        {
                            pP[0] = new PointF(i, j);
                            if (OP > dO)
                                break;
                        }
                    }
                }

                mP[2] = (float)-1 / (float)mP[1];
                nP[2] = pP[0].Y - pP[0].X * mP[2];
                for (float i = pP[0].X - 15; i < pP[0].X + 0.01f; i += 0.01f)
                {
                    float j = mP[2] * i + nP[2];
                    float distanta = (float)Math.Sqrt((pP[0].X - i) * (pP[0].X - i) + (pP[0].Y - j) * (pP[0].Y - j));

                    if ((int)distanta == 15)
                    {
                        pP[1] = new PointF(i, j);
                        break;
                    }
                }

                mP[0] = mP[2];
                nP[0] = P.Y - mP[0] * P.X;
                mP[3] = mP[1];
                nP[3] = pP[1].Y - mP[3] * pP[1].X;

                pP[2].X = (float)(nP[3] - nP[0]) / (float)(mP[0] - mP[3]);
                pP[2].Y = mP[0] * pP[2].X + nP[0];
                
            }
        }
        //MEDIATOARE FINISH//

        //INALTIME START//
        public void verificare_inaltimi()                                   //verifica inaltimile
        {
            Graphics g = CreateGraphics();
            if (inaltime[1] && inaltime[2] && inaltime[3])
            {     //INALTIMEA// ; //DACA INALTIMEA E IN AFARA TR// ; //DACA H E IN AFARA TRIUNGHIULUI//
                g.DrawLine(penblue, A, D); g.DrawLine(penblue, B, D); g.DrawLine(penblue, H, D);
                g.DrawLine(penblue, B, E); g.DrawLine(penblue, C, E); g.DrawLine(penblue, H, E);
                g.DrawLine(penblue, C, F); g.DrawLine(penblue, A, F); g.DrawLine(penblue, H, F);
                if (AD > 15)
                    g.DrawLines(penblue, pD);//patratelul pentru AD
                if (BE > 15)
                    g.DrawLines(penblue, pE);//patratelul pentru BE
                if (CF > 15)
                    g.DrawLines(penblue, pF);//tapratelul pentru CF

                pointD.Location = new Point((int)D.X - 10, (int)D.Y - 10);
                pointE.Location = new Point((int)E.X - 10, (int)E.Y - 10);
                pointF.Location = new Point((int)F.X - 10, (int)F.Y - 10);
                pointD.Visible = true;
                pointE.Visible = true;
                pointF.Visible = true;
                pointH.Visible = true;
            }
            else
            {
                ortocentrul_cercului();
                if (inaltime[1])
                {
                    g.DrawLine(penblue, A, D);
                    g.DrawLine(penblue, B, D);
                    if (AD > 15)
                        g.DrawLines(penblue, pD);
                    pointD.Location = new Point((int)D.X - 10, (int)D.Y - 10);
                    pointD.Visible = true;
                }
                if (inaltime[2])
                {
                    g.DrawLine(penblue, B, E);
                    g.DrawLine(penblue, C, E);
                    if (BE > 15)
                        g.DrawLines(penblue, pE);
                    pointE.Location = new Point((int)E.X - 10, (int)E.Y - 10);
                    pointE.Visible = true;
                }
                if (inaltime[3])
                {
                    g.DrawLine(penblue, C, F);
                    g.DrawLine(penblue, A, F);
                    if (CF > 15)
                        g.DrawLines(penblue, pF);
                    pointF.Location = new Point((int)F.X - 10, (int)F.Y - 10);
                    pointF.Visible = true;
                }
            }

            g.DrawLine(penblack, A, B);
            g.DrawLine(penblack, A, C);
            g.DrawLine(penblack, B, C);
        }

        public void ortocentrul_cercului()                                  //verificarea daca sunt cel putin 2 inaltimi si pune H
        {
            Graphics g = CreateGraphics();
            if (inaltime[1] && inaltime[2])
            {
                g.DrawLine(penblue, D, H);
                g.DrawLine(penblue, E, H);
                pointH.Visible = true;
            }
            else if (inaltime[1] && inaltime[3])
            {
                g.DrawLine(penblue, D, H);
                g.DrawLine(penblue, F, H);
                pointH.Visible = true;
            }
            else if (inaltime[3] && inaltime[2])
            {
                g.DrawLine(penblue, E, H);
                g.DrawLine(penblue, F, H);
                pointH.Visible = true;
            }
            else
            {
                pointH.Visible = false;
                //verificare_mediane();
                //verificare_mediatoare();
            }
        }

        private void b_inaltime_Click(object sender, EventArgs e)           //buton toate inaltimile
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!pointD.Visible && !pointE.Visible && !pointF.Visible && !inaltime_toggle)
                    inaltime_toggle = true;
                if (pointD.Visible && pointE.Visible && pointF.Visible && inaltime_toggle)
                    inaltime_toggle = false;
                if (inaltime_toggle)
                {
                    inaltime[1] = true;
                    inaltime[2] = true;
                    inaltime[3] = true;
                    verificare_inaltimi();

                    inaltime_toggle = false;
                }
                else
                {
                    pointH.Visible = false;
                    pointD.Visible = false; inaltime[1] = false;
                    pointE.Visible = false; inaltime[2] = false;
                    pointF.Visible = false; inaltime[3] = false;
                    verificare_lini(sender, e);

                    inaltime_toggle = true;
                }
            }
        }

        private void b_inaltime_1_Click(object sender, EventArgs e)         //buton inaltime din A
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!inaltime[1])
                {
                    inaltime[1] = true;
                    verificare_inaltimi();
                }
                else
                {
                    pointD.Visible = false; inaltime[1] = false;
                    verificare_lini(sender, e);
                }
            }
        }

        private void b_inaltime_2_Click(object sender, EventArgs e)         //buton inaltime din B
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!inaltime[2])
                {
                    inaltime[2] = true;
                    verificare_inaltimi();
                }
                else
                {
                    pointE.Visible = false; inaltime[2] = false;
                    verificare_lini(sender, e);
                }
            }
        }

        private void b_inaltime_3_Click(object sender, EventArgs e)         //buton inaltime din C
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!inaltime[3])
                {
                    inaltime[3] = true;
                    verificare_inaltimi();
                }
                else
                {
                    pointF.Visible = false; inaltime[3] = false;
                    verificare_lini(sender, e);
                }
            }
        }

        //constante pentru determinarea ecuatiilor ce formeaza inaltimea din A si oatratelul mic(Y = m * X + n)
        public float[] mD = new float[4];
        public float[] nD = new float[4];
        public PointF[] pD = new PointF[3];
        public float AD;
        //constante pentru determinarea ecuatiilor ce formeaza inaltimea din B si oatratelul mic(Y = m * X + n)
        public float[] mE = new float[4];
        public float[] nE = new float[4];
        public PointF[] pE = new PointF[3];
        public float BE;
        //constante pentru determinarea ecuatiilor ce formeaza inaltimea din A si oatratelul mic(Y = m * X + n)
        public float[] mF = new float[4];
        public float[] nF = new float[4];
        public PointF[] pF = new PointF[3];
        public float CF;

        public void calculeaza_inaltimile()                                 //program care calculeaza ortocentrul H
        {
            mD[1] = -(float)(B.X - C.X) / (float)(B.Y - C.Y);
            nD[1] = A.Y - mD[1] * A.X;
            
            mE[1] = -(float)(A.X - C.X) / (float)(A.Y - C.Y);
            nE[1] = B.Y - mE[1] * B.X;
            
            mF[1] = -(float)(B.X - A.X) / (float)(B.Y - A.Y);
            nF[1] = C.Y - mF[1] * C.X;

            if (Math.Abs(B.Y - A.Y) <= 2) //verificarea daca 2 puncte au acelasi Y
            {               //(daca au acelasi Y la calcularea lui m va rezulta /0 => eroare)
                H.X = (float)(nD[1] - nE[1]) / (float)(mE[1] - mD[1]);
                H.Y = mD[1] * H.X + nD[1];
            }
            else if (Math.Abs(C.Y - A.Y) <= 2)
            {
                H.X = (float)(nF[1] - nD[1]) / (float)(mD[1] - mF[1]);
                H.Y = mF[1] * H.X + nF[1];
            }
            else
            {
                H.X = (float)(nE[1] - nF[1]) / (float)(mF[1] - mE[1]);
                H.Y = mE[1] * H.X + nE[1];
            }

            pointH.Location = new Point((int)H.X - 10, (int)H.Y - 10);
            
            inaltimea_AD();
            inaltimea_BE();
            inaltimea_CF();
        }

        public void inaltimea_AD()                                          //calcularea inaltimi AD si a patratului mic
        {
            Graphics g = CreateGraphics();
            if (Math.Abs(B.Y - C.Y) <= 2)
            {
                D = new PointF(A.X, (float)(B.Y + C.Y) / 2);
                AD = (float)Math.Sqrt((D.X - A.X) * (D.X - A.X) + (D.Y - A.Y) * (D.Y - A.Y));
                if (A.Y > D.Y)
                    pD[0] = new PointF(D.X, D.Y + 15);
                else
                    pD[0] = new PointF(D.X, D.Y - 15);

                if (D.X < (float)(B.X + C.X) / 2)
                    pD[2] = new PointF(D.X + 15, D.Y);
                else
                    pD[2] = new PointF(D.X - 15, D.Y);

                pD[1] = new PointF(pD[2].X, pD[0].Y);
                
                /*g.DrawLines(penblue, pD);
                g.DrawLine(penblue, B, D);
                g.DrawLine(penblue, A, D);*/
            }
            else if (Math.Abs(B.X - C.X) <= 2)
            {
                D = new PointF((float)(B.X + C.X) / 2, A.Y);
                AD = (float)Math.Sqrt((D.X - A.X) * (D.X - A.X) + (D.Y - A.Y) * (D.Y - A.Y));
                if (A.X > D.X)
                    pD[0] = new PointF(D.X + 15, D.Y);
                else
                    pD[0] = new PointF(D.X - 15, D.Y);

                if (D.Y < (float)(B.Y + C.Y) / 2)
                    pD[2] = new PointF(D.X, D.Y + 15);
                else
                    pD[2] = new PointF(D.X, D.Y - 15);

                pD[1] = new PointF(pD[0].X, pD[2].Y);
                /*g.DrawLines(penblue, pD);
                g.DrawLine(penblue, D, B);
                g.DrawLine(penblue, A, D);*/
            } 
            else
            {
                mD[0] = (float)(-1) / (float)mD[1];
                nD[0] = B.Y - mD[0] * B.X;

                D.X = (float)(nD[1] - nD[0]) / (float)(mD[0] - mD[1]);
                D.Y = mD[0] * D.X + nD[0];

                float dD, dA;
                AD = (float)Math.Sqrt((D.X - A.X) * (D.X - A.X) + (D.Y - A.Y) * (D.Y - A.Y));
                for (float i = D.X - 15; i < D.X + 15.01f; i += 0.01f)
                {
                    float j = mD[1] * i + nD[1];
                    dD = (float)Math.Sqrt((D.X - i) * (D.X - i) + (D.Y - j) * (D.Y - j));
                    dA = (float)Math.Sqrt((A.X - i) * (A.X - i) + (A.Y - j) * (A.Y - j));

                    if ((int)dD == 15 && dA < AD)
                    {
                        pD[0] = new PointF(i, j);
                        break;
                    }
                }
                float dB, dC;
                float BD = (float)Math.Sqrt((D.X - B.X) * (D.X - B.X) + (D.Y - B.Y) * (D.Y - B.Y));
                float CD = (float)Math.Sqrt((D.X - C.X) * (D.X - C.X) + (D.Y - C.Y) * (D.Y - C.Y));
                for (float i = D.X - 15; i < D.X + 15.01f; i += 0.01f)
                {
                    float j = mD[0] * i + nD[0];
                    dD = (float)Math.Sqrt((D.X - i) * (D.X - i) + (D.Y - j) * (D.Y - j));
                    dB = (float)Math.Sqrt((B.X - i) * (B.X - i) + (B.Y - j) * (B.Y - j));
                    dC = (float)Math.Sqrt((C.X - i) * (C.X - i) + (C.Y - j) * (C.Y - j));
                    if (CD < BD)
                    {
                        if ((int)dD == 15 && dB < BD)
                        {
                            pD[2] = new PointF(i, j);
                            break;
                        }
                    }
                    else
                    {
                        if ((int)dD == 15 && dC < CD)
                        {
                            pD[2] = new PointF(i, j);
                            break;
                        }
                    }
                }
                mD[2] = mD[0];
                nD[2] = pD[0].Y - mD[2] * pD[0].X;

                mD[3] = mD[1];
                nD[3] = pD[2].Y - mD[3] * pD[2].X;

                pD[1].X = (float)(nD[3] - nD[2]) / (float)(mD[2] - mD[3]);
                pD[1].Y = mD[2] * pD[1].X + nD[2];

                /*g.DrawLines(penblue, pD);
                g.DrawLine(penblue, D, B);
                g.DrawLine(penblue, A, D);*/
            }
        }

        public void inaltimea_BE()                                          //calcularea inaltimi BE si a patratului mic
        {
            Graphics g = CreateGraphics();
            if (Math.Abs(C.Y - A.Y) <= 2)
            {
                E = new PointF(B.X, (float)(C.Y + A.Y) / 2);
                BE = (float)Math.Sqrt((E.X - B.X) * (E.X - B.X) + (E.Y - B.Y) * (E.Y - B.Y));
                for (float i = E.X - 15; i < E.X + 15.01f; i += 0.01f)
                    if (B.Y > E.Y)
                    pE[0] = new PointF(E.X, E.Y + 15);
                else
                    pE[0] = new PointF(E.X, E.Y - 15);

                if (E.X < (float)(C.X + A.X) / 2)
                    pE[2] = new PointF(E.X + 15, E.Y);
                else
                    pE[2] = new PointF(E.X - 15, E.Y);

                pE[1] = new PointF(pE[2].X, pE[0].Y);

                /*g.DrawLines(penblue, pE);
                g.DrawLine(penblue, C, E);
                g.DrawLine(penblue, B, E);*/
            }
            else if (Math.Abs(C.X - A.X) <= 2)
            {
                E = new PointF((float)(C.X + A.X) / 2, B.Y);
                BE = (float)Math.Sqrt((E.X - B.X) * (E.X - B.X) + (E.Y - B.Y) * (E.Y - B.Y));
                for (float i = E.X - 15; i < E.X + 15.01f; i += 0.01f)
                    if (B.X > E.X)
                    pE[0] = new PointF(E.X + 15, E.Y);
                else
                    pE[0] = new PointF(E.X - 15, E.Y);

                if (E.Y < (float)(C.Y + A.Y) / 2)
                    pE[2] = new PointF(E.X, E.Y + 15);
                else
                    pE[2] = new PointF(E.X, E.Y - 15);

                pE[1] = new PointF(pE[0].X, pE[2].Y);

                /*g.DrawLines(penblue, pE);
                g.DrawLine(penblue, C, E);
                g.DrawLine(penblue, B, E);*/
            }
            else
            {
                mE[0] = (float)(-1) / (float)mE[1];
                nE[0] = C.Y - mE[0] * C.X;

                E.X = (float)(nE[1] - nE[0]) / (float)(mE[0] - mE[1]);
                E.Y = mE[0] * E.X + nE[0];

                float dE, dB;
                BE = (float)Math.Sqrt((E.X - B.X) * (E.X - B.X) + (E.Y - B.Y) * (E.Y - B.Y));
                for (float i = E.X - 15; i < E.X + 15.01f; i += 0.01f)
                {
                    float j = mE[1] * i + nE[1];
                    dE = (float)Math.Sqrt((E.X - i) * (E.X - i) + (E.Y - j) * (E.Y - j));
                    dB = (float)Math.Sqrt((B.X - i) * (B.X - i) + (B.Y - j) * (B.Y - j));

                    if ((int)dE == 15 && dB < BE)
                    {
                        pE[0] = new PointF(i, j);
                        break;
                    }
                }
                float dC, dA;
                float CE = (float)Math.Sqrt((E.X - C.X) * (E.X - C.X) + (E.Y - C.Y) * (E.Y - C.Y));
                float AE = (float)Math.Sqrt((E.X - A.X) * (E.X - A.X) + (E.Y - A.Y) * (E.Y - A.Y));
                for (float i = E.X - 15; i < E.X + 15.01f; i += 0.01f)
                {
                    float j = mE[0] * i + nE[0];
                    dE = (float)Math.Sqrt((E.X - i) * (E.X - i) + (E.Y - j) * (E.Y - j));
                    dC = (float)Math.Sqrt((C.X - i) * (C.X - i) + (C.Y - j) * (C.Y - j));
                    dA = (float)Math.Sqrt((A.X - i) * (A.X - i) + (A.Y - j) * (A.Y - j));
                    if (AE < CE)
                    {
                        if ((int)dE == 15 && dC < CE)
                        {
                            pE[2] = new PointF(i, j);
                            break;
                        }
                    }
                    else
                    {
                        if ((int)dE == 15 && dA < AE)
                        {
                            pE[2] = new PointF(i, j);
                            break;
                        }
                    }
                }
                mE[2] = mE[0];
                nE[2] = pE[0].Y - mE[2] * pE[0].X;

                mE[3] = mE[1];
                nE[3] = pE[2].Y - mE[3] * pE[2].X;

                pE[1].X = (float)(nE[3] - nE[2]) / (float)(mE[2] - mE[3]);
                pE[1].Y = mE[2] * pE[1].X + nE[2];

                /*g.DrawLines(penblue, pE);
                g.DrawLine(penblue, C, E);
                g.DrawLine(penblue, B, E);*/
            }
        }

        public void inaltimea_CF()                                          //calcularea inaltimi CF si a patratului mic
        {
            Graphics g = CreateGraphics();
            if (Math.Abs(A.Y - B.Y) <= 2)
            {
                F = new PointF(C.X, (float)(A.Y + B.Y) / 2);
                CF = (float)Math.Sqrt((F.X - C.X) * (F.X - C.X) + (F.Y - C.Y) * (F.Y - C.Y));
                if (C.Y > F.Y)
                    pF[0] = new PointF(F.X, F.Y + 15);
                else
                    pF[0] = new PointF(F.X, F.Y - 15);

                if (F.X < (float)(A.X + B.X) / 2)
                    pF[2] = new PointF(F.X + 15, F.Y);
                else
                    pF[2] = new PointF(F.X - 15, F.Y);

                pF[1] = new PointF(pF[2].X, pF[0].Y);

                /*g.DrawLines(penblue, pF);
                g.DrawLine(penblue, A, F);
                g.DrawLine(penblue, C, F);*/
            }
            else if (Math.Abs(A.X - B.X) <= 2)
            {
                {
                    F = new PointF((float)(A.X + B.X) / 2, C.Y);
                    CF = (float)Math.Sqrt((F.X - C.X) * (F.X - C.X) + (F.Y - C.Y) * (F.Y - C.Y));
                    if (C.X > F.X)
                        pF[0] = new PointF(F.X + 15, F.Y);
                    else
                        pF[0] = new PointF(F.X - 15, F.Y);

                    if (F.Y < (float)(A.Y + B.Y) / 2)
                        pF[2] = new PointF(F.X, F.Y + 15);
                    else
                        pF[2] = new PointF(F.X, F.Y - 15);

                    pF[1] = new PointF(pF[0].X, pF[2].Y);

                    /*g.DrawLines(penblue, pF);
                    g.DrawLine(penblue, A, F);
                    g.DrawLine(penblue, C, F);*/
                }
            }
            else
            {

                mF[0] = (float)(-1) / (float)mF[1];
                nF[0] = A.Y - mF[0] * A.X;

                F.X = (float)(nF[1] - nF[0]) / (float)(mF[0] - mF[1]);
                F.Y = mF[0] * F.X + nF[0];

                float dF, dC;
                CF = (float)Math.Sqrt((F.X - C.X) * (F.X - C.X) + (F.Y - C.Y) * (F.Y - C.Y));
                for (float i = F.X - 15; i < F.X + 15.01f; i += 0.01f)
                {
                    float j = mF[1] * i + nF[1];
                    dF = (float)Math.Sqrt((F.X - i) * (F.X - i) + (F.Y - j) * (F.Y - j));
                    dC = (float)Math.Sqrt((C.X - i) * (C.X - i) + (C.Y - j) * (C.Y - j));

                    if ((int)dF == 15 && dC < CF)
                    {
                        pF[0] = new PointF(i, j);
                        break;
                    }
                }
                float dA, dB;
                float AF = (float)Math.Sqrt((F.X - A.X) * (F.X - A.X) + (F.Y - A.Y) * (F.Y - A.Y));
                float BF = (float)Math.Sqrt((F.X - B.X) * (F.X - B.X) + (F.Y - B.Y) * (F.Y - B.Y));
                for (float i = F.X - 15; i < F.X + 15.01f; i += 0.01f)
                {
                    float j = mF[0] * i + nF[0];
                    dF = (float)Math.Sqrt((F.X - i) * (F.X - i) + (F.Y - j) * (F.Y - j));
                    dA = (float)Math.Sqrt((A.X - i) * (A.X - i) + (A.Y - j) * (A.Y - j));
                    dB = (float)Math.Sqrt((B.X - i) * (B.X - i) + (B.Y - j) * (B.Y - j));
                    if (BF < AF)
                    {
                        if ((int)dF == 15 && dA < AF)
                        {
                            pF[2] = new PointF(i, j);
                            break;
                        }
                    }
                    else
                    {
                        if ((int)dF == 15 && dB < BF)
                        {
                            pF[2] = new PointF(i, j);
                            break;
                        }
                    }
                }
                mF[2] = mF[0];
                nF[2] = pF[0].Y - mF[2] * pF[0].X;

                mF[3] = mF[1];
                nF[3] = pF[2].Y - mF[3] * pF[2].X;

                pF[1].X = (float)(nF[3] - nF[2]) / (float)(mF[2] - mF[3]);
                pF[1].Y = mF[2] * pF[1].X + nF[2];

                /*g.DrawLines(penblue, pF);
                g.DrawLine(penblue, A, F);
                g.DrawLine(penblue, C, F);*/
            }
        }
        //INALTIME FINISH//

        //BISECTOARE START//
        public void verificare_bisectoare()                                 //verifica bisectoarele
        {
            float raza = raza_cercului_inscris;
            Pen penunghi = new Pen(Color.Green, 2);
            Rectangle cercA = new Rectangle((int)A.X - 30, (int)A.Y - 30, 60, 60);
            Rectangle cercB = new Rectangle((int)B.X - 30, (int)B.Y - 30, 60, 60);
            Rectangle cercB1 = new Rectangle((int)B.X - 33, (int)B.Y - 33, 66, 66);
            Rectangle cercC = new Rectangle((int)C.X - 30, (int)C.Y - 30, 60, 60);
            Rectangle cercC1 = new Rectangle((int)C.X - 33, (int)C.Y - 33, 66, 66);
            Rectangle cercC2 = new Rectangle((int)C.X - 27, (int)C.Y - 27, 54, 54);

            Graphics g = CreateGraphics();

            if (bisectoare[1] && bisectoare[2] && bisectoare[3])
            {
                g.DrawEllipse(pengreen, I.X - raza, I.Y - raza, raza * 2, raza * 2);
                if (true/*desenarea unghiurilor congruente*/)
                {
                    if (T.Y > A.Y && AB > 60 && AC > 60 && AD > 30)//unchiul A
                    {
                        g.DrawArc(penunghi, cercA, calibrareA - unghiul_A / 2, unghiul_A);
                    }
                    else if (AB > 60 && AC > 60 && AD > 30)
                    {
                        g.DrawArc(penunghi, cercA, 360 - calibrareA - unghiul_A / 2, unghiul_A);
                    }
                    if (U.Y > B.Y && AB > 66 && BC > 66 && BE > 33)//unchiul B
                    {
                        g.DrawArc(penunghi, cercB, calibrareB - unghiul_B / 2, unghiul_B);
                        g.DrawArc(penunghi, cercB1, calibrareB - unghiul_B / 2, unghiul_B);
                    }
                    else if (AB > 66 && BC > 66 && BE > 33)
                    {
                        g.DrawArc(penunghi, cercB, 360 - calibrareB - unghiul_B / 2, unghiul_B);
                        g.DrawArc(penunghi, cercB1, 360 - calibrareB - unghiul_B / 2, unghiul_B);
                    }
                    if (V.Y > C.Y && AC > 66 && BC > 66 && CF > 33)//unghiul C
                    {
                        g.DrawArc(penunghi, cercC, calibrareC - unghiul_C / 2, unghiul_C);
                        g.DrawArc(penunghi, cercC1, calibrareC - unghiul_C / 2, unghiul_C);
                        g.DrawArc(penunghi, cercC2, calibrareC - unghiul_C / 2, unghiul_C);
                    }
                    else if (AC > 66 && BC > 66 && CF > 33)
                    {
                        g.DrawArc(penunghi, cercC, 360 - calibrareC - unghiul_C / 2, unghiul_C);
                        g.DrawArc(penunghi, cercC1, 360 - calibrareC - unghiul_C / 2, unghiul_C);
                        g.DrawArc(penunghi, cercC2, 360 - calibrareC - unghiul_C / 2, unghiul_C);
                    }
                }

                g.DrawLine(pengreen, T, A);
                g.DrawLine(pengreen, U, B);
                g.DrawLine(pengreen, V, C);

                pointT.Location = new Point((int)T.X - 10, (int)T.Y - 10);
                pointU.Location = new Point((int)U.X - 10, (int)U.Y - 10);
                pointV.Location = new Point((int)V.X - 10, (int)V.Y - 10);
                pointT.Visible = true;
                pointU.Visible = true;
                pointV.Visible = true;
                pointI.Visible = true;
            }
            else
            {
                centrul_cercului_inscris();
                if (bisectoare[1])
                {
                    if (T.Y > A.Y && AB > 60 && AC > 60 && AD > 30)//unchiul A
                    {
                        g.DrawArc(penunghi, cercA, calibrareA - unghiul_A / 2, unghiul_A);
                    }
                    else if (AB > 60 && AC > 60 && AD > 30)
                    {
                        g.DrawArc(penunghi, cercA, 360 - calibrareA - unghiul_A / 2, unghiul_A);
                    }
                    g.DrawLine(pengreen, T, A);
                    pointT.Location = new Point((int)T.X - 10, (int)T.Y - 10);
                    pointT.Visible = true;
                }
                if (bisectoare[2])
                {
                    if (U.Y > B.Y && AB > 66 && BC > 66 && BE > 33)//unchiul B
                    {
                        g.DrawArc(penunghi, cercB, calibrareB - unghiul_B / 2, unghiul_B);
                        g.DrawArc(penunghi, cercB1, calibrareB - unghiul_B / 2, unghiul_B);
                    }
                    else if (AB > 66 && BC > 66 && BE > 33)
                    {
                        g.DrawArc(penunghi, cercB, 360 - calibrareB - unghiul_B / 2, unghiul_B);
                        g.DrawArc(penunghi, cercB1, 360 - calibrareB - unghiul_B / 2, unghiul_B);
                    }
                    g.DrawLine(pengreen, U, B);
                    pointU.Location = new Point((int)U.X - 10, (int)U.Y - 10);
                    pointU.Visible = true;
                }
                if (bisectoare[3])
                {
                    if (V.Y > C.Y && AC > 66 && BC > 66 && CF > 33)//unghiul C
                    {
                        g.DrawArc(penunghi, cercC, calibrareC - unghiul_C / 2, unghiul_C);
                        g.DrawArc(penunghi, cercC1, calibrareC - unghiul_C / 2, unghiul_C);
                        g.DrawArc(penunghi, cercC2, calibrareC - unghiul_C / 2, unghiul_C);
                    }
                    else if (AC > 66 && BC > 66 && CF > 33)
                    {
                        g.DrawArc(penunghi, cercC, 360 - calibrareC - unghiul_C / 2, unghiul_C);
                        g.DrawArc(penunghi, cercC1, 360 - calibrareC - unghiul_C / 2, unghiul_C);
                        g.DrawArc(penunghi, cercC2, 360 - calibrareC - unghiul_C / 2, unghiul_C);
                    }
                    g.DrawLine(pengreen, V, C);
                    pointV.Location = new Point((int)V.X - 10, (int)V.Y - 10);
                    pointV.Visible = true;
                }
            }

            g.DrawLine(penblack, A, B);
            g.DrawLine(penblack, A, C);
            g.DrawLine(penblack, B, C);
        }

        public void centrul_cercului_inscris()                              //verifica daca sunt cel putin 2 bisectoare si pune I
        {
            Graphics g = CreateGraphics();
            float raza = raza_cercului_inscris;
            if (bisectoare[1] && bisectoare[2] || bisectoare[1] && bisectoare[3] || bisectoare[3] && bisectoare[2])
            {
                pointI.Visible = true;
                g.DrawEllipse(pengreen, I.X - raza, I.Y - raza, raza * 2, raza * 2);
            }
            else
                pointI.Visible = false;
        }

        private void b_bisectoare_Click(object sender, EventArgs e)         //buton toate bisectoarele
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!pointT.Visible && !pointU.Visible && !pointV.Visible && !bisectoare_toggle)
                    bisectoare_toggle = true;
                if (pointT.Visible && pointU.Visible && pointV.Visible && bisectoare_toggle)
                    bisectoare_toggle = false;
                if (bisectoare_toggle)
                {
                    bisectoare[1] = true;
                    bisectoare[2] = true;
                    bisectoare[3] = true;
                    verificare_bisectoare();

                    bisectoare_toggle = false;
                }
                else
                {
                    pointI.Visible = false;
                    pointT.Visible = false; bisectoare[1] = false;
                    pointU.Visible = false; bisectoare[2] = false;
                    pointV.Visible = false; bisectoare[3] = false;
                    verificare_lini(sender, e);

                    bisectoare_toggle = true;
                }
            }
        }

        private void b_bisectoare_1_Click(object sender, EventArgs e)       //buton bisectoarea AT
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!bisectoare[1])
                {
                    bisectoare[1] = true;
                    verificare_bisectoare();
                }
                else
                {
                    pointT.Visible = false; bisectoare[1] = false;
                    verificare_lini(sender, e);
                }
            }
        }

        private void b_bisectoare_2_Click(object sender, EventArgs e)       //buton bisectoarea BU
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!bisectoare[2])
                {
                    bisectoare[2] = true;
                    verificare_bisectoare();
                }
                else
                {
                    pointU.Visible = false; bisectoare[2] = false;
                    verificare_lini(sender, e);
                }
            }
        }

        private void b_bisectoare_3_Click(object sender, EventArgs e)       //buton bisectoarea CV
        {
            if (pointA.Visible && pointB.Visible && pointC.Visible)
            {
                if (!bisectoare[3])
                {
                    bisectoare[3] = true;
                    verificare_bisectoare();
                }
                else
                {
                    pointV.Visible = false; bisectoare[3] = false;
                    verificare_lini(sender, e);
                }
            }
        }

        //constante care ajuta la desenarea unghiurilor A, B si C
        public float calibrareA, unghiul_A;
        public float calibrareB, unghiul_B;
        public float calibrareC, unghiul_C;
        public void calculeaza_bisectaorele()                               //program care calculeaza centru cercului insctris I
        {
            AB = (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
            BC = (float)Math.Sqrt((C.X - B.X) * (C.X - B.X) + (C.Y - B.Y) * (C.Y - B.Y));
            AC = (float)Math.Sqrt((A.X - C.X) * (A.X - C.X) + (A.Y - C.Y) * (A.Y - C.Y));
            
            bisectoarea_AT();
            bisectoarea_BU();
            bisectoarea_CV();
            
            //Graphics g = CreateGraphics();
            /*g.DrawLine(pengreen, T, A);
            g.DrawLine(pengreen, U, B);
            g.DrawLine(pengreen, V, C);*/

            float m1 = 0, n1 = 0, m2 = 0, n2 = 0;
            if (C.X == V.X || C.Y == V.Y || B.X == A.X)
            {
                m1 = (float)(A.Y - T.Y) / (float)(A.X - T.X);
                n1 = T.Y - m1 * T.X;
                m2 = (float)(B.Y - U.Y) / (float)(B.X - U.X);
                n2 = U.Y - m2 * U.X;
            }
            else if (B.X == U.X || B.Y == U.Y || C.X == A.X)
            {
                m1 = (float)(A.Y - T.Y) / (float)(A.X - T.X);
                n1 = T.Y - m1 * T.X;
                m2 = (float)(C.Y - V.Y) / (float)(C.X - V.X);
                n2 = V.Y - m2 * V.X;
            }
            else
            {
                m1 = (float)(B.Y - U.Y) / (float)(B.X - U.X);
                n1 = U.Y - m1 * U.X;
                m2 = (float)(C.Y - V.Y) / (float)(C.X - V.X);
                n2 = V.Y - m2 * V.X;  
            }
            I.X = (float)(n1 - n2) / (float)(m2 - m1);
            I.Y = m1 * I.X + n1;
            
            pointI.Location = new Point((int)I.X - 10, (int)I.Y - 10);

            float p = (float)(AB + AC + BC) / (float)2;
            float S = (float)Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));

            raza_cercului_inscris = (float)S / (float)p;



            /*float raza = raza_cercului_inscris;
            g.DrawEllipse(pengreen, I.X - raza, I.Y - raza, raza * 2, raza * 2);*/

        }

        public void bisectoarea_AT()                                        //calculeaza AT si unghiul lui A
        {
            Graphics g = CreateGraphics();
            if (B.X == C.X)
            {
                float min = Math.Min(B.Y, C.Y);
                float max = Math.Max(B.Y, C.Y);
                T = new PointF(0, 0);
                for (float j = min; j < max; j +=0.01f)
                {
                    float i = B.X;
                    float dB = (float)Math.Sqrt((j - B.Y) * (j - B.Y));
                    float dC = (float)Math.Sqrt((j - C.Y) * (j - C.Y));
                    if ((int)((float)dB / (float)dC * 100) == (int)((float)AB / (float)AC * 100))
                    {
                        T = new PointF(i, j);
                        break;
                    }
                }
            }
            else
            {
                float mT = (float)(B.Y - C.Y) / (float)(B.X - C.X);
                float nT = B.Y - mT * B.X;
                float min = Math.Min(B.X, C.X);
                float max = Math.Max(B.X, C.X);
                T = new PointF(0, 0);
                for (float i = min; i < max; i += 0.001f)
                {
                    float j = mT * i + nT;
                    float dB = (float)Math.Sqrt((i - B.X) * (i - B.X) + (j - B.Y) * (j - B.Y));
                    float dC = (float)Math.Sqrt((i - C.X) * (i - C.X) + (j - C.Y) * (j - C.Y));
                    if ((int)((float)dB / (float)dC * 100) == (int)((float)AB / (float)AC * 100))
                    {
                        T = new PointF(i, j);
                        break;
                    }
                }
            }
           
            if (true/*semicercul pt <A*/)
            {
                PointF X = new PointF(A.X + 100, A.Y);
                float XA = 100;
                float AT = (float)Math.Sqrt((A.X - T.X) * (A.X - T.X) + (A.Y - T.Y) * (A.Y - T.Y));
                float XT = (float)Math.Sqrt((X.X - T.X) * (X.X - T.X) + (X.Y - T.Y) * (X.Y - T.Y));

                float cosA = (float)(AB * AB + AC * AC - BC * BC) / (float)(2 * AB * AC);
                float cosT = (float)(AT * AT + XA * XA - XT * XT) / (float)(2 * AT * XA);

                calibrareA = (float)(Math.Acos(cosT) * 180) / (float)Math.PI;
                unghiul_A = (float)(Math.Acos(cosA) * 180) / (float)Math.PI;
            }
        }   

        public void bisectoarea_BU()                                        //calculeaza BU si unghiul lui B
        {
            Graphics g = CreateGraphics();
            if(A.X == C.X)
            {
                float min = Math.Min(A.Y, C.Y);
                float max = Math.Max(A.Y, C.Y);
                U = new PointF(0, 0);
                for (float j = min; j < max; j += 0.01f)
                {
                    float i = A.X;
                    float dA = (float)Math.Sqrt((j - A.Y) * (j - A.Y));
                    float dC = (float)Math.Sqrt((j - C.Y) * (j - C.Y));
                    if ((int)((float)dA / (float)dC * 100) == (int)((float)AB / (float)BC * 100))
                    {
                        U = new PointF(i, j);
                        break;
                    }
                }
            }
            else
            {
                float mU = (float)(A.Y - C.Y) / (float)(A.X - C.X);
                float nU = A.Y - mU * A.X;
                float min = Math.Min(A.X, C.X);
                float max = Math.Max(A.X, C.X);
                U = new PointF(0, 0);
                for (float i = min; i < max; i += 0.001f)
                {
                    float j = mU * i + nU;
                    float dA = (float)Math.Sqrt((i - A.X) * (i - A.X) + (j - A.Y) * (j - A.Y));
                    float dC = (float)Math.Sqrt((i - C.X) * (i - C.X) + (j - C.Y) * (j - C.Y));
                    if ((int)((float)dA / (float)dC * 100) == (int)((float)AB / (float)BC * 100))
                    {
                        U = new PointF(i, j);
                        break;
                    }
                }
            }


            if (true/*semicercul pt <B*/)
            {
                PointF Y = new PointF(B.X + 100, B.Y);
                float YB = 100;
                float BU = (float)Math.Sqrt((B.X - U.X) * (B.X - U.X) + (B.Y - U.Y) * (B.Y - U.Y));
                float YU = (float)Math.Sqrt((Y.X - U.X) * (Y.X - U.X) + (Y.Y - U.Y) * (Y.Y - U.Y));

                float cosB = (float)(AB * AB + BC * BC - AC * AC) / (float)(2 * AB * BC);
                float cosU = (float)(BU * BU + YB * YB - YU * YU) / (float)(2 * BU * YB);

                calibrareB = (float)(Math.Acos(cosU) * 180) / (float)Math.PI;
                unghiul_B = (float)(Math.Acos(cosB) * 180) / (float)Math.PI;
            }
        }

        public void bisectoarea_CV()                                        //calculeaza CV si unghiul lui C
        {
            Graphics g = CreateGraphics();
            if (B.X == A.X)
            {
                float min = Math.Min(A.Y, B.Y);
                float max = Math.Max(A.Y, B.Y);
                V = new PointF(0, 0);
                for (float j = min; j < max; j += 0.001f)
                {
                    float i = B.X;
                    float dA = (float)Math.Sqrt((j - A.Y) * (j - A.Y));
                    float dB = (float)Math.Sqrt((j - B.Y) * (j - B.Y));
                    if ((int)((float)dA / (float)dB * 100) == (int)((float)AC / (float)BC * 100))
                    {
                        V = new PointF(i, j);
                        break;
                    }
                }
            }
            else
            {
                float mV = (float)(A.Y - B.Y) / (float)(A.X - B.X);
                float nV = A.Y - mV * A.X;
                float min = Math.Min(A.X, B.X);
                float max = Math.Max(A.X, B.X);
                V = new PointF(0, 0);
                for (float i = min; i < max; i += 0.001f)
                {
                    float j = mV * i + nV;
                    float dA = (float)Math.Sqrt((i - A.X) * (i - A.X) + (j - A.Y) * (j - A.Y));
                    float dB = (float)Math.Sqrt((i - B.X) * (i - B.X) + (j - B.Y) * (j - B.Y));
                    if ((int)((float)dA / (float)dB * 100) == (int)((float)AC / (float)BC * 100))
                    {
                        V = new PointF(i, j);
                        break;
                    }
                }
            }

            if (true/*semicercul pt <C*/)
            {
                PointF Z = new PointF(C.X + 100, C.Y);
                float ZC = 100;
                float CV = (float)Math.Sqrt((C.X - V.X) * (C.X - V.X) + (C.Y - V.Y) * (C.Y - V.Y));
                float ZV = (float)Math.Sqrt((Z.X - V.X) * (Z.X - V.X) + (Z.Y - V.Y) * (Z.Y - V.Y));

                float cosC = (float)(AC * AC + BC * BC - AB * AB) / (float)(2 * AC * BC);
                float cosV = (float)(CV * CV + ZC * ZC - ZV * ZV) / (float)(2 * CV * ZC);

                calibrareC = (float)(Math.Acos(cosV) * 180) / (float)Math.PI;
                unghiul_C = (float)(Math.Acos(cosC) * 180) / (float)Math.PI;
            }
        }

    }
}
