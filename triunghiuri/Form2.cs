using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triunghiuri
{
    public partial class Form2 : Form
    {
        Form1 f1;
        int width, height;
        public float a, b, c;
        bool coordonate_isactive = true, LLL_isactive = true, LUL_isactive = true, ULU_isactive = true;

        public Form2(Form1 form1)
        {
            this.f1 = form1;
            width = f1.ClientSize.Width - 20;
            height = f1.ClientSize.Height - 172;
            InitializeComponent();
            max_min();
        }

        public void max_min()
        {         
            A_X.Maximum = width;
            A_Y.Maximum = height;
            B_X.Maximum = width;
            B_Y.Maximum = height;
            C_X.Maximum = width;
            C_Y.Maximum = height;
            
            X_range.Text = "0<X<" + width;
            Y_range.Text = "0<Y<" + height;

            unghi_range1.Text = "0°<(m<)<180°";
            unghi_range2.Text = "0°<(m<)<179°";

            L3_range.Text = "0<L<"+ width;
            L2_range.Text = "0<L<" + width;
            L1_range.Text = "0<L<" + width;
            
            lungimea_AB.Maximum = width;
            lungimea_BC.Maximum = width;
            lungimea_CA.Maximum = width;

            lungimea_L1.Maximum = width;
            lungimea_L2.Maximum = width;

            lungimea_L.Maximum = width;
        }

        private void apply_coordonate_Click(object sender, EventArgs e)
        {
            Graphics g = f1.CreateGraphics();
            f1.button_reset_Click(sender, e);

            f1.pointA.Location = new Point((int)A_X.Value, f1.ClientSize.Height - (int)A_Y.Value - 20);
            f1.pointB.Location = new Point((int)B_X.Value, f1.ClientSize.Height - (int)B_Y.Value - 20);
            f1.pointC.Location = new Point((int)C_X.Value, f1.ClientSize.Height - (int)C_Y.Value - 20);

            f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
            f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
            f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

            if (true/*calculare unghiuri si laturi*/)
            {
                a = (float)Math.Sqrt((f1.C.X - f1.B.X) * (f1.C.X - f1.B.X) + (f1.C.Y - f1.B.Y) * (f1.C.Y - f1.B.Y));
                b = (float)Math.Sqrt((f1.A.X - f1.C.X) * (f1.A.X - f1.C.X) + (f1.A.Y - f1.C.Y) * (f1.A.Y - f1.C.Y));
                c = (float)Math.Sqrt((f1.A.X - f1.B.X) * (f1.A.X - f1.B.X) + (f1.A.Y - f1.B.Y) * (f1.A.Y - f1.B.Y));

                f1.unghiul_B = (float)(Math.Acos((float)(c * c + a * a - b * b) / (float)(2 * c * a)) * 180 / Math.PI);
                f1.unghiul_A = (float)(Math.Acos((float)(c * c + b * b - b * a) / (float)(2 * c * b)) * 180 / Math.PI);
                f1.unghiul_C = (180 - f1.unghiul_A - f1.unghiul_B);
            }

            f1.pointA.Visible = true;
            f1.pointB.Visible = true;
            f1.pointC.Visible = true;

            f1.adaugare_triunghi(this);
            Close();
        }

        private void apply_LUL_Click(object sender, EventArgs e)
        {
            Graphics g = f1.CreateGraphics();
            a = (float)lungimea_L2.Value;
            c = (float)lungimea_L1.Value;
            float cosB = (float)Math.Cos((float)((double)masura_unghiului.Value * Math.PI) / (float)180);
            b = (float)Math.Sqrt((float)(c * c + a * a - 2 * c * a * cosB));
                               
            lungimea_AB.Value = (decimal)c;
            lungimea_BC.Value = (decimal)a;
            lungimea_CA.Value = (decimal)b;
            
            f1.AB = (float)lungimea_AB.Value;
            f1.BC = (float)lungimea_BC.Value;
            f1.AC = (float)lungimea_CA.Value;
            if (lungimea_AB.Value > Math.Abs(lungimea_BC.Value - lungimea_CA.Value) && lungimea_AB.Value < lungimea_BC.Value + lungimea_CA.Value && f1.AB >= f1.BC && f1.AB >= f1.AC)
            {
                float BH = (float)(f1.AB * f1.AB + f1.BC * f1.BC - f1.AC * f1.AC) / (float)(2 * f1.AB);
                float h = (float)Math.Sqrt(f1.BC * f1.BC - BH * BH);

                f1.pointA.Location = new Point((int)((width - lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((width + lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointC.Location = new Point((int)((float)((width + lungimea_AB.Value) / 2) - BH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;
            }
            else if (lungimea_BC.Value > Math.Abs(lungimea_AB.Value - lungimea_CA.Value) && lungimea_BC.Value < lungimea_AB.Value + lungimea_CA.Value && f1.BC >= f1.AB && f1.BC >= f1.AC)
            {
                float BH = (float)(f1.BC * f1.BC + f1.AB * f1.AB - f1.AC * f1.AC) / (float)(2 * f1.BC);
                float h = (float)Math.Sqrt(f1.AB * f1.AB - BH * BH);

                f1.pointC.Location = new Point((int)((width - lungimea_BC.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((width + lungimea_BC.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointA.Location = new Point((int)((float)((width + lungimea_BC.Value) / 2) - BH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;
            }
            else if (lungimea_CA.Value > Math.Abs(lungimea_AB.Value - lungimea_BC.Value) && lungimea_CA.Value < lungimea_AB.Value + lungimea_BC.Value && f1.AC >= f1.AB && f1.AC >= f1.BC)
            {
                float CH = (float)(f1.AC * f1.AC + f1.BC * f1.BC - f1.AB * f1.AB) / (float)(2 * f1.AC);
                float h = (float)Math.Sqrt(f1.BC * f1.BC - CH * CH);

                f1.pointA.Location = new Point((int)((width - lungimea_CA.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointC.Location = new Point((int)((width + lungimea_CA.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((float)((width + lungimea_CA.Value) / 2) - CH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;
            }
            else if (f1.AB == f1.BC && f1.AB == f1.AC)
            {
                float AH = f1.AB / 2;
                float h = AH * (float)Math.Sqrt(3);

                f1.pointA.Location = new Point((int)((width - lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((width + lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointC.Location = new Point((int)((float)((width + lungimea_AB.Value) / 2) - AH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;
            }
            else
            {
                f1.AB = float.NaN;
                f1.BC = float.NaN;
                f1.AC = float.NaN;

                f1.A = new PointF(float.NaN, float.NaN);
                f1.B = new PointF(float.NaN, float.NaN);
                f1.C = new PointF(float.NaN, float.NaN);
            }

            f1.unghiul_B = (float)(Math.Acos((float)(f1.AB * f1.AB + f1.BC * f1.BC - f1.AC * f1.AC) / (float)(2 * f1.AB * f1.BC)) * 180 / Math.PI);
            f1.unghiul_A = (float)(Math.Acos((float)(f1.AB * f1.AB + f1.AC * f1.AC - f1.BC * f1.BC) / (float)(2 * f1.AB * f1.AC)) * 180 / Math.PI);
            f1.unghiul_C = (180 - f1.unghiul_A - f1.unghiul_B);

            Rectangle cercB = new Rectangle((int)f1.B.X - 30, (int)f1.B.Y - 30, 60, 60);
            Rectangle cercB1 = new Rectangle((int)f1.B.X - 33, (int)f1.B.Y - 33, 66, 66);
            Pen penunghi = new Pen(Color.Green, 2);

            if (b > a && b > c)
            {
                g.DrawArc(penunghi, cercB, 360 + f1.unghiul_C, f1.unghiul_B);
                g.DrawArc(penunghi, cercB1, 360 + f1.unghiul_C, f1.unghiul_B);
            }
            else
            {
                g.DrawArc(penunghi, cercB, 360 + 180, f1.unghiul_B);
                g.DrawArc(penunghi, cercB1, 360 + 180, f1.unghiul_B);
            }
            f1.adaugare_triunghi(this);
            Close();
            //apply_lungimi_Click(sender, e);
        }

        private void apply_ULU_Click(object sender, EventArgs e)
        {
            Graphics g = f1.CreateGraphics();
            float uA = (float)unghi1.Value;
            float uB = (float)unghi2.Value;
            float uC = 180 - uA - uB;
            float sinA, sinB, sinC;
            if (Math.Max(uA, Math.Max(uB, uC)) == uA)
            {
                sinA = (float)Math.Sin((float)((float)unghi1.Value * Math.PI) / (float)180);
                sinB = (float)Math.Sin((float)((float)unghi2.Value * Math.PI) / (float)180);
                sinC = (float)Math.Sin((float)((float)(180 - unghi1.Value - unghi2.Value) * Math.PI) / (float)180);
                a = (float)lungimea_L.Value;
                b = sinB * a / sinA;
                c = sinC * a / sinA;
            }
            else if (Math.Max(uA, Math.Max(uB, uC)) == uB)
            {
                sinA = (float)Math.Sin((float)((double)unghi1.Value * Math.PI) / (float)180);
                sinB = (float)Math.Sin((float)((float)unghi2.Value * Math.PI) / (float)180);
                sinC = (float)Math.Sin((float)((float)(180 - unghi1.Value - unghi2.Value) * Math.PI) / (float)180);
                b = (float)lungimea_L.Value;
                a = sinA * b / sinB;
                c = sinC * b / sinB;
            }
            else
            {
                sinA = (float)Math.Sin((float)((float)unghi1.Value * Math.PI) / (float)180);
                sinB = (float)Math.Sin((float)((float)unghi2.Value * Math.PI) / (float)180);
                sinC = (float)Math.Sin((float)((float)(180 - unghi1.Value - unghi2.Value) * Math.PI) / (float)180);
                c = (float)lungimea_L.Value;
                b = sinB * c / sinC;
                a = sinA * c / sinC;
            }

            lungimea_AB.Value = (decimal)c;
            lungimea_BC.Value = (decimal)a;
            lungimea_CA.Value = (decimal)b;

            f1.AB = c;
            f1.BC = a;
            f1.AC = b;
            if (lungimea_AB.Value > Math.Abs(lungimea_BC.Value - lungimea_CA.Value) && lungimea_AB.Value < lungimea_BC.Value + lungimea_CA.Value && f1.AB >= f1.BC && f1.AB >= f1.AC)
            {
                float BH = (float)(f1.AB * f1.AB + f1.BC * f1.BC - f1.AC * f1.AC) / (float)(2 * f1.AB);
                float h = (float)Math.Sqrt(f1.BC * f1.BC - BH * BH);

                f1.pointA.Location = new Point((int)((width - lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((width + lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointC.Location = new Point((int)((float)((width + lungimea_AB.Value) / 2) - BH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;
            }
            else if (lungimea_BC.Value > Math.Abs(lungimea_AB.Value - lungimea_CA.Value) && lungimea_BC.Value < lungimea_AB.Value + lungimea_CA.Value && f1.BC >= f1.AB && f1.BC >= f1.AC)
            {
                float BH = (float)(f1.BC * f1.BC + f1.AB * f1.AB - f1.AC * f1.AC) / (float)(2 * f1.BC);
                float h = (float)Math.Sqrt(f1.AB * f1.AB - BH * BH);

                f1.pointC.Location = new Point((int)((width - lungimea_BC.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((width + lungimea_BC.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointA.Location = new Point((int)((float)((width + lungimea_BC.Value) / 2) - BH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;
            }
            else if (lungimea_CA.Value > Math.Abs(lungimea_AB.Value - lungimea_BC.Value) && lungimea_CA.Value < lungimea_AB.Value + lungimea_BC.Value && f1.AC >= f1.AB && f1.AC >= f1.BC)
            {
                float CH = (float)(f1.AC * f1.AC + f1.BC * f1.BC - f1.AB * f1.AB) / (float)(2 * f1.AC);
                float h = (float)Math.Sqrt(f1.BC * f1.BC - CH * CH);

                f1.pointA.Location = new Point((int)((width - lungimea_CA.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointC.Location = new Point((int)((width + lungimea_CA.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((float)((width + lungimea_CA.Value) / 2) - CH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;
            }
            else if (f1.AB == f1.BC && f1.AB == f1.AC)
            {
                float AH = f1.AB / 2;
                float h = AH * (float)Math.Sqrt(3);

                f1.pointA.Location = new Point((int)((width - lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((width + lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointC.Location = new Point((int)((float)((width + lungimea_AB.Value) / 2) - AH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;
            }
            else
            {
                f1.AB = float.NaN;
                f1.BC = float.NaN;
                f1.AC = float.NaN;

                f1.A = new PointF(float.NaN, float.NaN);
                f1.B = new PointF(float.NaN, float.NaN);
                f1.C = new PointF(float.NaN, float.NaN);
            }

            f1.unghiul_B = uB;
            f1.unghiul_A = uA;
            f1.unghiul_C = (180 - f1.unghiul_A - f1.unghiul_B);

            Rectangle cercB = new Rectangle((int)f1.B.X - 30, (int)f1.B.Y - 30, 60, 60);
            Rectangle cercB1 = new Rectangle((int)f1.B.X - 33, (int)f1.B.Y - 33, 66, 66);
            Rectangle cercA = new Rectangle((int)f1.A.X - 30, (int)f1.A.Y - 30, 60, 60);
            Rectangle cercA1 = new Rectangle((int)f1.A.X - 33, (int)f1.A.Y - 33, 66, 66);
            Rectangle cercA2 = new Rectangle((int)f1.A.X - 27, (int)f1.A.Y - 27, 54, 54);
            Pen penunghi = new Pen(Color.Green, 2);

            if (b > a && b > c)
            {
                g.DrawArc(penunghi, cercB, 360 + f1.unghiul_C, f1.unghiul_B);
                g.DrawArc(penunghi, cercB1, 360 + f1.unghiul_C, f1.unghiul_B);
            }
            else
            {
                g.DrawArc(penunghi, cercB, 360 + 180, f1.unghiul_B);
                g.DrawArc(penunghi, cercB1, 360 + 180, f1.unghiul_B);
            }
            if (a > b && a > c)
            {
                g.DrawArc(penunghi, cercA, 360 + f1.unghiul_B, f1.unghiul_A);
                g.DrawArc(penunghi, cercA1, 360 + f1.unghiul_B, f1.unghiul_A);
                g.DrawArc(penunghi, cercA2, 360 + f1.unghiul_B, f1.unghiul_A);
            }
            else
            {
                g.DrawArc(penunghi, cercA, 360 - f1.unghiul_A, f1.unghiul_A);
                g.DrawArc(penunghi, cercA1, 360 - f1.unghiul_A, f1.unghiul_A);
                g.DrawArc(penunghi, cercA2, 360 - f1.unghiul_A, f1.unghiul_A);
            }
            f1.adaugare_triunghi(this);
            Close();

        }

        private void apply_lungimi_Click(object sender, EventArgs e)
        {
            c = (float)lungimea_AB.Value;
            a = (float)lungimea_BC.Value;
            b = (float)lungimea_CA.Value;
            f1.AB = (float)lungimea_AB.Value;
            f1.BC = (float)lungimea_BC.Value;
            f1.AC = (float)lungimea_CA.Value;
            if (lungimea_AB.Value > Math.Abs(lungimea_BC.Value - lungimea_CA.Value) && lungimea_AB.Value < lungimea_BC.Value + lungimea_CA.Value && f1.AB >= f1.BC && f1.AB >= f1.AC)
            {
                float BH = (float)(f1.AB * f1.AB + f1.BC * f1.BC - f1.AC * f1.AC) / (float)(2 * f1.AB);
                float h = (float)Math.Sqrt(f1.BC * f1.BC - BH * BH);

                f1.pointA.Location = new Point((int)((width - lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((width + lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointC.Location = new Point((int)((float)((width + lungimea_AB.Value) / 2) - BH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;               
            }
            else if (lungimea_BC.Value > Math.Abs(lungimea_AB.Value - lungimea_CA.Value) && lungimea_BC.Value < lungimea_AB.Value + lungimea_CA.Value && f1.BC >= f1.AB && f1.BC >= f1.AC)
            {
                float BH = (float)(f1.BC * f1.BC + f1.AB * f1.AB - f1.AC * f1.AC) / (float)(2 * f1.BC);
                float h = (float)Math.Sqrt(f1.AB * f1.AB - BH * BH);

                f1.pointC.Location = new Point((int)((width - lungimea_BC.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((width + lungimea_BC.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointA.Location = new Point((int)((float)((width + lungimea_BC.Value) / 2) - BH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;                
            }
            else if (lungimea_CA.Value > Math.Abs(lungimea_AB.Value - lungimea_BC.Value) && lungimea_CA.Value < lungimea_AB.Value + lungimea_BC.Value && f1.AC >= f1.AB && f1.AC >= f1.BC)
            {
                float CH = (float)(f1.AC * f1.AC + f1.BC * f1.BC - f1.AB * f1.AB) / (float)(2 * f1.AC);
                float h = (float)Math.Sqrt(f1.BC * f1.BC - CH * CH);

                f1.pointA.Location = new Point((int)((width - lungimea_CA.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointC.Location = new Point((int)((width + lungimea_CA.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((float)((width + lungimea_CA.Value) / 2) - CH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;              
            }
            else if(f1.AB == f1.BC && f1.AB == f1.AC)
            {
                float AH = f1.AB / 2;
                float h = AH * (float)Math.Sqrt(3);

                f1.pointA.Location = new Point((int)((width - lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointB.Location = new Point((int)((width + lungimea_AB.Value) / 2), f1.ClientSize.Height + ((int)h - height) / 2);
                f1.pointC.Location = new Point((int)((float)((width + lungimea_AB.Value) / 2) - AH), (int)((f1.ClientSize.Height + ((int)h - height) / 2) - h));

                f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
                f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
                f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;               
            }                  
            else
            {
                f1.AB = float.NaN;
                f1.BC = float.NaN;
                f1.AC = float.NaN;

                f1.A = new PointF(float.NaN, float.NaN);
                f1.B = new PointF(float.NaN, float.NaN);
                f1.C = new PointF(float.NaN, float.NaN);  
            }

            f1.unghiul_B = (float)(Math.Acos((float)(f1.AB * f1.AB + f1.BC * f1.BC - f1.AC * f1.AC) / (float)(2 * f1.AB * f1.BC)) * 180 / Math.PI);
            f1.unghiul_A = (float)(Math.Acos((float)(f1.AB * f1.AB + f1.AC * f1.AC - f1.BC * f1.BC) / (float)(2 * f1.AB * f1.AC)) * 180 / Math.PI);
            f1.unghiul_C = (180 - f1.unghiul_A - f1.unghiul_B);

            f1.adaugare_triunghi(this);
            Close();
        }

        private void unghi2_ValueChanged(object sender, EventArgs e)
        {
            unghi1.Maximum = 178 - unghi2.Value;
        }

        private void unghi1_ValueChanged(object sender, EventArgs e)
        {
            unghi2.Maximum = 178 - unghi1.Value;
        }

        private void b_activare_coordonate_Click(object sender, EventArgs e)
        {
            if (coordonate_isactive)
            {
                b_activare_coordonate.BackColor = Color.SteelBlue;
                b_activare_coordonate.ForeColor = Color.White;
                coordonate_isactive = false;

                if (!ULU_isactive)
                    b_activare_ULU_Click(sender, e);
                if (!LUL_isactive)
                    b_activare_LUL_Click(sender, e);
                if (!LLL_isactive)
                    b_activare_LLL_Click(sender, e);

                X_range.Location = new Point(125, 68);
                Y_range.Location = new Point(260, 68);
                labelA.Location = new Point(50, 100);
                labelB.Location = new Point(50, 136);
                labelC.Location = new Point(50, 172);
                A_X.Location = new Point(115, 100);
                A_Y.Location = new Point(240, 100);
                B_X.Location = new Point(115, 136);
                B_Y.Location = new Point(240, 136);
                C_X.Location = new Point(115, 172);
                C_Y.Location = new Point(240, 172);
                apply_coordonate.Location = new Point(350, 200);

                X_range.Visible = true;
                Y_range.Visible = true;
                labelA.Visible = true;
                labelB.Visible = true;
                labelC.Visible = true;
                A_X.Visible = true;
                A_Y.Visible = true;
                B_X.Visible = true;
                B_Y.Visible = true;
                C_X.Visible = true;
                C_Y.Visible = true;
                apply_coordonate.Visible = true;
            }
            else
            {
                b_activare_coordonate.BackColor = Color.PowderBlue;
                b_activare_coordonate.ForeColor = Color.Black;
                coordonate_isactive = true;
                
                X_range.Visible = false;
                Y_range.Visible = false;
                labelA.Visible = false;
                labelB.Visible = false;
                labelC.Visible = false;
                A_X.Visible = false;
                A_Y.Visible = false;
                B_X.Visible = false;
                B_Y.Visible = false;
                C_X.Visible = false;
                C_Y.Visible = false;
                apply_coordonate.Visible = false;
            }
        }

        private void b_activare_LLL_Click(object sender, EventArgs e)
        {
            if (LLL_isactive)
            {
                b_activare_LLL.BackColor = Color.SteelBlue;
                b_activare_LLL.ForeColor = Color.White;
                LLL_isactive = false;

                if (!ULU_isactive)
                    b_activare_ULU_Click(sender, e);
                if (!LUL_isactive)
                    b_activare_LUL_Click(sender, e);
                if (!coordonate_isactive)
                    b_activare_coordonate_Click(sender, e);

                L3_range.Location = new Point(125, 68);
                AB.Location = new Point(50, 100);
                BC.Location = new Point(50, 136);
                CA.Location = new Point(50, 172);
                lungimea_AB.Location = new Point(115, 100);
                lungimea_BC.Location = new Point(115, 136);
                lungimea_CA.Location = new Point(115, 172);
                apply_lungimi.Location = new Point(350, 200);

                L3_range.Visible = true;
                AB.Visible = true;
                BC.Visible = true;
                CA.Visible = true;
                lungimea_AB.Visible = true;
                lungimea_BC.Visible = true;
                lungimea_CA.Visible = true;
                apply_lungimi.Visible = true;
            }
            else
            {
                b_activare_LLL.BackColor = Color.PowderBlue;
                b_activare_LLL.ForeColor = Color.Black;
                LLL_isactive = true;

                L3_range.Visible = false;
                AB.Visible = false;
                BC.Visible = false;
                CA.Visible = false;
                lungimea_AB.Visible = false;
                lungimea_BC.Visible = false;
                lungimea_CA.Visible = false;
                apply_lungimi.Visible = false;
            }
        }

        private void b_activare_LUL_Click(object sender, EventArgs e)
        {
            if (LUL_isactive)
            {
                b_activare_LUL.BackColor = Color.SteelBlue;
                b_activare_LUL.ForeColor = Color.White;
                LUL_isactive = false;
                
                if (!ULU_isactive)
                    b_activare_ULU_Click(sender, e);
                if (!LLL_isactive)
                    b_activare_LLL_Click(sender, e);
                if (!coordonate_isactive)
                    b_activare_coordonate_Click(sender, e);

                L2_range.Location = new Point(125, 68);
                L1.Location = new Point(50, 100);
                L2.Location = new Point(50, 136);
                lungimea_L1.Location = new Point(115, 100);
                lungimea_L2.Location = new Point(115, 136);
                unghi_range1.Location = new Point(300, 68);
                masuraunghiului1.Location = new Point(240, 100);
                masura_unghiului.Location = new Point(300, 100);
                apply_LUL.Location = new Point(350, 200);

                L2_range.Visible = true;
                L1.Visible = true;
                L2.Visible = true;
                lungimea_L1.Visible = true;
                lungimea_L2.Visible = true;
                unghi_range1.Visible = true;
                masuraunghiului1.Visible = true;
                masura_unghiului.Visible = true;
                apply_LUL.Visible = true;
            }
            else
            {
                b_activare_LUL.BackColor = Color.PowderBlue;
                b_activare_LUL.ForeColor = Color.Black;
                LUL_isactive = true;

                L2_range.Visible = false;
                L1.Visible = false;
                L2.Visible = false;
                lungimea_L1.Visible = false;
                lungimea_L2.Visible = false;
                unghi_range1.Visible = false;
                masuraunghiului1.Visible = false;
                masura_unghiului.Visible = false;
                apply_LUL.Visible = false;
            }
        }

        private void b_activare_ULU_Click(object sender, EventArgs e)
        {
            if (ULU_isactive)
            {
                b_activare_ULU.BackColor = Color.SteelBlue;
                b_activare_ULU.ForeColor = Color.White;
                ULU_isactive = false;

                if (!LUL_isactive)
                    b_activare_LUL_Click(sender, e);
                if (!LLL_isactive)
                    b_activare_LLL_Click(sender, e);
                if (!coordonate_isactive)
                    b_activare_coordonate_Click(sender, e);

                unghi_range2.Location = new Point(115, 68);
                masuraunghiului2.Location = new Point(50, 100);
                masuraunghiului3.Location = new Point(50, 136);
                unghi1.Location = new Point(115, 100);
                unghi2.Location = new Point(115, 136);
                L1_range.Location = new Point(310, 68);
                L.Location = new Point(240, 100);
                lungimea_L.Location = new Point(300, 100);
                apply_ULU.Location = new Point(350, 200);

                unghi_range2.Visible = true;
                masuraunghiului2.Visible = true;
                masuraunghiului3.Visible = true;
                unghi1.Visible = true;
                unghi2.Visible = true;
                L1_range.Visible = true;
                L.Visible = true;
                lungimea_L.Visible = true;
                apply_ULU.Visible = true;
            }
            else
            {
                b_activare_ULU.BackColor = Color.PowderBlue;
                b_activare_ULU.ForeColor = Color.Black;
                ULU_isactive = true;

                unghi_range2.Visible = false;
                masuraunghiului2.Visible = false;
                masuraunghiului3.Visible = false;
                unghi1.Visible = false;
                unghi2.Visible = false;
                L1_range.Visible = false;
                L.Visible = false;
                lungimea_L.Visible = false;
                apply_ULU.Visible = false;
            }
        }

        private void b_tr_ascutitunghic_Click(object sender, EventArgs e)
        {
            Graphics g = f1.CreateGraphics();
            f1.button_reset_Click(sender, e);

            f1.pointA.Location = new Point(width / 4 * 3 , (f1.ClientSize.Height - 20) / 4 * 3);
            f1.pointB.Location = new Point(width / 4 , (f1.ClientSize.Height - 20) / 4 * 3);
            f1.pointC.Location = new Point(width / 8 * 5, 200);

            f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
            f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
            f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

            if (true/*calculare unghiuri si laturi*/)
            {
                a = (float)Math.Sqrt((f1.C.X - f1.B.X) * (f1.C.X - f1.B.X) + (f1.C.Y - f1.B.Y) * (f1.C.Y - f1.B.Y));
                b = (float)Math.Sqrt((f1.A.X - f1.C.X) * (f1.A.X - f1.C.X) + (f1.A.Y - f1.C.Y) * (f1.A.Y - f1.C.Y));
                c = (float)Math.Sqrt((f1.A.X - f1.B.X) * (f1.A.X - f1.B.X) + (f1.A.Y - f1.B.Y) * (f1.A.Y - f1.B.Y));

                f1.unghiul_B = (float)(Math.Acos((float)(c * c + a * a - b * b) / (float)(2 * c * a)) * 180 / Math.PI);
                f1.unghiul_A = (float)(Math.Acos((float)(c * c + b * b - b * a) / (float)(2 * c * b)) * 180 / Math.PI);
                f1.unghiul_C = (180 - f1.unghiul_A - f1.unghiul_B);
            }

            f1.pointA.Visible = true;
            f1.pointB.Visible = true;
            f1.pointC.Visible = true;          
            
            f1.adaugare_triunghi(this);
            Close();
        }

        private void b_tr_oarecare_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = f1.CreateGraphics();
            f1.button_reset_Click(sender, e);

            Random rnd = new Random();

            f1.pointA.Location = new Point(rnd.Next(0, width), f1.ClientSize.Height - 20 - rnd.Next(0, height));
            f1.pointB.Location = new Point(rnd.Next(0, width), f1.ClientSize.Height - 20 - rnd.Next(0, height));
            f1.pointC.Location = new Point(rnd.Next(0, width), f1.ClientSize.Height - 20 - rnd.Next(0, height));

            f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
            f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
            f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);


            a = (float)Math.Sqrt((f1.C.X - f1.B.X) * (f1.C.X - f1.B.X) + (f1.C.Y - f1.B.Y) * (f1.C.Y - f1.B.Y));
            b = (float)Math.Sqrt((f1.A.X - f1.C.X) * (f1.A.X - f1.C.X) + (f1.A.Y - f1.C.Y) * (f1.A.Y - f1.C.Y));
            c = (float)Math.Sqrt((f1.A.X - f1.B.X) * (f1.A.X - f1.B.X) + (f1.A.Y - f1.B.Y) * (f1.A.Y - f1.B.Y));

            if (Math.Abs(a + b - c) < 10 || Math.Abs(a + c - b) < 10 || Math.Abs(c + b - a) < 10 || Math.Abs(a - b) < 10 || Math.Abs(c - b) < 10 || Math.Abs(a - c) < 10)
            {
                b_tr_oarecare_MouseClick(sender, e);
            }
            else
            {
                f1.unghiul_B = (float)(Math.Acos((float)(c * c + a * a - b * b) / (float)(2 * c * a)) * 180 / Math.PI);
                f1.unghiul_A = (float)(Math.Acos((float)(c * c + b * b - b * a) / (float)(2 * c * b)) * 180 / Math.PI);
                f1.unghiul_C = (180 - f1.unghiul_A - f1.unghiul_B);

                f1.pointA.Visible = true;
                f1.pointB.Visible = true;
                f1.pointC.Visible = true;


                f1.miscare_punct(sender, e);
                Close();
            }
        }

        private void b_tr_obuzunghic_Click(object sender, EventArgs e)
        {
            Graphics g = f1.CreateGraphics();
            f1.button_reset_Click(sender, e);

            f1.pointA.Location = new Point(width / 8 * 5, (f1.ClientSize.Height - 20) / 6 * 4);
            f1.pointB.Location = new Point(width / 8 * 3, (f1.ClientSize.Height - 20) / 6 * 4);
            f1.pointC.Location = new Point(f1.pointB.Location.X - 100, f1.pointB.Location.Y - 200);

            f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
            f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
            f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

            if (true/*calculare unghiuri si laturi*/)
            {
                a = (float)Math.Sqrt((f1.C.X - f1.B.X) * (f1.C.X - f1.B.X) + (f1.C.Y - f1.B.Y) * (f1.C.Y - f1.B.Y));
                b = (float)Math.Sqrt((f1.A.X - f1.C.X) * (f1.A.X - f1.C.X) + (f1.A.Y - f1.C.Y) * (f1.A.Y - f1.C.Y));
                c = (float)Math.Sqrt((f1.A.X - f1.B.X) * (f1.A.X - f1.B.X) + (f1.A.Y - f1.B.Y) * (f1.A.Y - f1.B.Y));

                f1.unghiul_B = (float)(Math.Acos((float)(c * c + a * a - b * b) / (float)(2 * c * a)) * 180 / Math.PI);
                f1.unghiul_A = (float)(Math.Acos((float)(c * c + b * b - b * a) / (float)(2 * c * b)) * 180 / Math.PI);
                f1.unghiul_C = (180 - f1.unghiul_A - f1.unghiul_B);
            }

            f1.pointA.Visible = true;
            f1.pointB.Visible = true;
            f1.pointC.Visible = true;

            f1.calculeaza_bisectaorele();
            Rectangle cercB = new Rectangle((int)f1.B.X - 30, (int)f1.B.Y - 30, 60, 60);
            Rectangle cercB1 = new Rectangle((int)f1.B.X - 33, (int)f1.B.Y - 33, 66, 66);
            Pen penunghi = new Pen(Color.Green, 2);
            g.DrawArc(penunghi, cercB, 360 - f1.calibrareB - f1.unghiul_B / 2, f1.unghiul_B);
            g.DrawArc(penunghi, cercB1, 360 - f1.calibrareB - f1.unghiul_B / 2, f1.unghiul_B);
            
            f1.adaugare_triunghi(this);
            Close();
        }

        private void b_tr_dr_Click(object sender, EventArgs e)
        {
            Graphics g = f1.CreateGraphics();
            f1.button_reset_Click(sender, e);

            f1.pointA.Location = new Point(width / 4 * 3, (f1.ClientSize.Height - 20) / 4 * 3);
            f1.pointB.Location = new Point(width / 4, (f1.ClientSize.Height - 20) / 4 * 3);
            f1.pointC.Location = new Point(width / 4, 200);

            f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
            f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
            f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

            if (true/*calculare unghiuri si laturi*/)
            {
                a = (float)Math.Sqrt((f1.C.X - f1.B.X) * (f1.C.X - f1.B.X) + (f1.C.Y - f1.B.Y) * (f1.C.Y - f1.B.Y));
                b = (float)Math.Sqrt((f1.A.X - f1.C.X) * (f1.A.X - f1.C.X) + (f1.A.Y - f1.C.Y) * (f1.A.Y - f1.C.Y));
                c = (float)Math.Sqrt((f1.A.X - f1.B.X) * (f1.A.X - f1.B.X) + (f1.A.Y - f1.B.Y) * (f1.A.Y - f1.B.Y));

                f1.unghiul_B = (float)(Math.Acos((float)(c * c + a * a - b * b) / (float)(2 * c * a)) * 180 / Math.PI);
                f1.unghiul_A = (float)(Math.Acos((float)(c * c + b * b - b * a) / (float)(2 * c * b)) * 180 / Math.PI);
                f1.unghiul_C = (180 - f1.unghiul_A - f1.unghiul_B);
            }

            f1.pointA.Visible = true;
            f1.pointB.Visible = true;
            f1.pointC.Visible = true;
            Pen dr = new Pen(Color.Red, 3);
            g.DrawLine(dr, f1.B.X, f1.B.Y - 25, f1.B.X + 27, f1.B.Y - 25);
            g.DrawLine(dr, f1.B.X + 25, f1.B.Y, f1.B.X + 25, f1.B.Y - 25);

            f1.adaugare_triunghi(this);
            Close();
        }

        private void b_tr_dr_isoscel_Click(object sender, EventArgs e)
        {
            Graphics g = f1.CreateGraphics();
            f1.button_reset_Click(sender, e);

            f1.pointA.Location = new Point(width / 4 * 3, (f1.ClientSize.Height - 20) / 4 * 3);
            f1.pointB.Location = new Point(width / 4, (f1.ClientSize.Height - 20) / 4 * 3);            
            f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
            f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
            
            c = (float)Math.Sqrt((f1.A.X - f1.B.X) * (f1.A.X - f1.B.X) + (f1.A.Y - f1.B.Y) * (f1.A.Y - f1.B.Y));
            
            f1.pointC.Location = new Point(width / 2, (int)((f1.ClientSize.Height - 20) / 4 * 3 - c / 2));
            f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

            a = (float)Math.Sqrt((f1.C.X - f1.B.X) * (f1.C.X - f1.B.X) + (f1.C.Y - f1.B.Y) * (f1.C.Y - f1.B.Y));
            b = (float)Math.Sqrt((f1.A.X - f1.C.X) * (f1.A.X - f1.C.X) + (f1.A.Y - f1.C.Y) * (f1.A.Y - f1.C.Y));

            f1.unghiul_B = 45;
            f1.unghiul_A = 45;
            f1.unghiul_C = 90;

            /*Afisare*/{
                Rectangle cercB = new Rectangle((int)f1.B.X - 30, (int)f1.B.Y - 30, 60, 60);
                Rectangle cercB1 = new Rectangle((int)f1.B.X - 33, (int)f1.B.Y - 33, 66, 66);
                Rectangle cercA = new Rectangle((int)f1.A.X - 30, (int)f1.A.Y - 30, 60, 60);
                Rectangle cercA1 = new Rectangle((int)f1.A.X - 33, (int)f1.A.Y - 33, 66, 66);
                Pen penunghi = new Pen(Color.Green, 2);
                g.DrawArc(penunghi, cercB, 360 - 45, f1.unghiul_B);
                g.DrawArc(penunghi, cercB1, 360 - 45, f1.unghiul_B);
                g.DrawArc(penunghi, cercA, 180, f1.unghiul_A);
                g.DrawArc(penunghi, cercA1, 180, f1.unghiul_A);
                Pen dr = new Pen(Color.Red, 3);
                g.DrawLine(dr, f1.C.X + 15, f1.C.Y + 15, f1.C.X, f1.C.Y + 30);
                g.DrawLine(dr, f1.C.X - 15, f1.C.Y + 15, f1.C.X, f1.C.Y + 30);
                Point mij1 = new Point((int)(f1.A.X + f1.C.X) / 2, (int)(f1.A.Y + f1.C.Y) / 2);
                Point mij2 = new Point((int)(f1.B.X + f1.C.X) / 2, (int)(f1.B.Y + f1.C.Y) / 2);
                g.DrawLine(penunghi, mij1.X - 12, mij1.Y + 8, mij1.X + 8, mij1.Y - 12);
                g.DrawLine(penunghi, mij1.X - 8, mij1.Y + 12, mij1.X + 12, mij1.Y - 8);
                g.DrawLine(penunghi, mij2.X + 12, mij2.Y + 8, mij2.X - 8, mij2.Y - 12);
                g.DrawLine(penunghi, mij2.X + 8, mij2.Y + 12, mij2.X - 12, mij2.Y - 8);
            }

            f1.label1.Text = "45°";
            f1.label2.Text = "45°";
            f1.label1.Location = new Point((int)f1.B.X + 40, (int)f1.B.Y - 27);
            f1.label2.Location = new Point((int)f1.A.X - 65, (int)f1.A.Y - 27);
            f1.label1.Visible = true;
            f1.label2.Visible = true;

            f1.pointA.Visible = true;
            f1.pointB.Visible = true;
            f1.pointC.Visible = true;

            f1.adaugare_triunghi(this);
            Close();
        }

        private void b_tr_dr_30_60_90_Click(object sender, EventArgs e)
        {
            Graphics g = f1.CreateGraphics();
            f1.button_reset_Click(sender, e);

            f1.unghiul_A = 90;
            f1.unghiul_B = 60;
            f1.unghiul_C = 30;

            f1.pointC.Location = new Point(width / 4 * 3, (f1.ClientSize.Height - 20) / 4 * 3);
            f1.pointB.Location = new Point(width / 4, (f1.ClientSize.Height - 20) / 4 * 3);            

            f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
            f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);
            
            a = (float)Math.Sqrt((f1.C.X - f1.B.X) * (f1.C.X - f1.B.X) + (f1.C.Y - f1.B.Y) * (f1.C.Y - f1.B.Y));
            b = a / 2 * (float)Math.Sqrt(3);
            c = a / 2;
            
            f1.pointA.Location = new Point((int)(f1.B.X + a / 4) - 10, (int)(f1.B.Y - b / 2) - 10);
            f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);

            Pen dr = new Pen(Color.Red, 3);
            g.DrawLine(dr, f1.A.X + 21, f1.A.Y + 10, f1.A.X + 8, f1.A.Y + 31);
            g.DrawLine(dr, f1.A.X - 10, f1.A.Y + 21, f1.A.X + 8, f1.A.Y + 31);

            Rectangle cercB = new Rectangle((int)f1.B.X - 30, (int)f1.B.Y - 30, 60, 60);
            Rectangle cercB1 = new Rectangle((int)f1.B.X - 33, (int)f1.B.Y - 33, 66, 66);
            Rectangle cercC = new Rectangle((int)f1.C.X - 35, (int)f1.C.Y - 35, 70, 70);
            Pen penunghi = new Pen(Color.Green, 2);
            g.DrawArc(penunghi, cercB, 360 - 60, f1.unghiul_B);
            g.DrawArc(penunghi, cercB1, 360 - 60, f1.unghiul_B);
            g.DrawArc(penunghi, cercC, 180, f1.unghiul_C);
            
            f1.label1.Text = "30°";
            f1.label2.Text = "60°";
            f1.label1.Location = new Point((int)f1.C.X - 70, (int)f1.C.Y - 23);
            f1.label2.Location = new Point((int)f1.B.X + 40, (int)f1.B.Y - 35);
            f1.label1.Visible = true;
            f1.label2.Visible = true;
            
            f1.pointA.Visible = true;
            f1.pointB.Visible = true;
            f1.pointC.Visible = true;

            f1.adaugare_triunghi(this);
            Close();
        }

        private void b_tr_isoscel_Click(object sender, EventArgs e)
        {
            Graphics g = f1.CreateGraphics();
            f1.button_reset_Click(sender, e);

            f1.pointA.Location = new Point(width / 8 * 6, (f1.ClientSize.Height - 20) / 4 * 3);
            f1.pointB.Location = new Point(width / 8 * 2, (f1.ClientSize.Height - 20) / 4 * 3);
            f1.pointC.Location = new Point(width / 2 - 2, 200);

            f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);
            f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
            f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

            if (true/*calculare unghiuri si laturi*/)
            {
                a = (float)Math.Sqrt((f1.C.X - f1.B.X) * (f1.C.X - f1.B.X) + (f1.C.Y - f1.B.Y) * (f1.C.Y - f1.B.Y));
                b = (float)Math.Sqrt((f1.A.X - f1.C.X) * (f1.A.X - f1.C.X) + (f1.A.Y - f1.C.Y) * (f1.A.Y - f1.C.Y));
                c = (float)Math.Sqrt((f1.A.X - f1.B.X) * (f1.A.X - f1.B.X) + (f1.A.Y - f1.B.Y) * (f1.A.Y - f1.B.Y));

                f1.unghiul_B = (float)(Math.Acos((float)(c * c + a * a - b * b) / (float)(2 * c * a)) * 180 / Math.PI);
                f1.unghiul_A = f1.unghiul_B;
                f1.unghiul_C = 180 - (float)Math.Round(f1.unghiul_A, 1) - (float)Math.Round(f1.unghiul_B, 1);
            }

            /*desenarea liniilor si ungiurilor de congruenta si */{
                Rectangle cercB = new Rectangle((int)f1.B.X - 30, (int)f1.B.Y - 30, 60, 60);
                Rectangle cercB1 = new Rectangle((int)f1.B.X - 33, (int)f1.B.Y - 33, 66, 66);
                Rectangle cercA = new Rectangle((int)f1.A.X - 30, (int)f1.A.Y - 30, 60, 60);
                Rectangle cercA1 = new Rectangle((int)f1.A.X - 33, (int)f1.A.Y - 33, 66, 66);
                Pen penunghi = new Pen(Color.Green, 2);
                g.DrawArc(penunghi, cercB, 360 - f1.unghiul_B, f1.unghiul_B);
                g.DrawArc(penunghi, cercB1, 360 - f1.unghiul_B, f1.unghiul_B);
                g.DrawArc(penunghi, cercA, 180, f1.unghiul_A);
                g.DrawArc(penunghi, cercA1, 180, f1.unghiul_A);
                Point mij1 = new Point((int)(f1.A.X + f1.C.X) / 2, (int)(f1.A.Y + f1.C.Y) / 2);
                Point mij2 = new Point((int)(f1.B.X + f1.C.X) / 2, (int)(f1.B.Y + f1.C.Y) / 2);
                g.DrawLine(penunghi, mij1.X - 12, mij1.Y + 8, mij1.X + 8, mij1.Y - 12);
                g.DrawLine(penunghi, mij1.X - 8, mij1.Y + 12, mij1.X + 12, mij1.Y - 8);
                g.DrawLine(penunghi, mij2.X + 12, mij2.Y + 8, mij2.X - 8, mij2.Y - 12);
                g.DrawLine(penunghi, mij2.X + 8, mij2.Y + 12, mij2.X - 12, mij2.Y - 8);
            }

            f1.pointA.Visible = true;
            f1.pointB.Visible = true;
            f1.pointC.Visible = true;

            f1.adaugare_triunghi(this);
            Close();
        }

        private void b_tr_echilateral_Click(object sender, EventArgs e)
        {
            Graphics g = f1.CreateGraphics();
            f1.button_reset_Click(sender, e);

            f1.pointC.Location = new Point(width / 6 * 4, (f1.ClientSize.Height - 20) / 8 * 7);
            f1.pointB.Location = new Point(width / 6 * 2, (f1.ClientSize.Height - 20) / 8 * 7);
            
            f1.B = new Point(f1.pointB.Location.X + 10, f1.pointB.Location.Y + 10);
            f1.C = new Point(f1.pointC.Location.X + 10, f1.pointC.Location.Y + 10);

            a = (float)Math.Sqrt((f1.C.X - f1.B.X) * (f1.C.X - f1.B.X) + (f1.C.Y - f1.B.Y) * (f1.C.Y - f1.B.Y));
            b = a;
            c = a;

            float h = a / 2 * (float)Math.Sqrt(3);
            
            f1.pointA.Location = new Point(width / 2 - 2, (f1.ClientSize.Height - 20) / 8 * 7 - (int)h);
            f1.A = new Point(f1.pointA.Location.X + 10, f1.pointA.Location.Y + 10);

            f1.unghiul_B = 60;
            f1.unghiul_A = 60;
            f1.unghiul_C = 60;

            /*desenarea liniilor si ungiurilor de congruenta si */{
                Rectangle cercB = new Rectangle((int)f1.B.X - 30, (int)f1.B.Y - 30, 60, 60);
                Rectangle cercB1 = new Rectangle((int)f1.B.X - 33, (int)f1.B.Y - 33, 66, 66);
                Rectangle cercA = new Rectangle((int)f1.A.X - 30, (int)f1.A.Y - 30, 60, 60);
                Rectangle cercA1 = new Rectangle((int)f1.A.X - 33, (int)f1.A.Y - 33, 66, 66);
                Rectangle cercC = new Rectangle((int)f1.C.X - 30, (int)f1.C.Y - 30, 60, 60);
                Rectangle cercC1 = new Rectangle((int)f1.C.X - 33, (int)f1.C.Y - 33, 66, 66);
                Pen penunghi = new Pen(Color.Green, 2);
                g.DrawArc(penunghi, cercA, 360 + 60, 60);
                g.DrawArc(penunghi, cercA1, 360 + 60, 60);
                g.DrawArc(penunghi, cercB, 360 - 60, 60);
                g.DrawArc(penunghi, cercB1, 360 - 60, 60);
                g.DrawArc(penunghi, cercC, 180, 60);
                g.DrawArc(penunghi, cercC1, 180, 60);
                
                Point mij1 = new Point((int)(f1.A.X + f1.C.X) / 2, (int)(f1.A.Y + f1.C.Y) / 2);
                Point mij2 = new Point((int)(f1.B.X + f1.C.X) / 2, (int)(f1.B.Y + f1.C.Y) / 2);
                Point mij3 = new Point((int)(f1.B.X + f1.A.X) / 2, (int)(f1.B.Y + f1.A.Y) / 2);
                g.DrawLine(penunghi, mij1.X - 12, mij1.Y + 9, mij1.X + 14, mij1.Y - 5);
                g.DrawLine(penunghi, mij1.X - 14, mij1.Y + 6, mij1.X + 12, mij1.Y - 8);
                
                g.DrawLine(penunghi, mij3.X + 12, mij3.Y + 9, mij3.X - 14, mij3.Y - 5);
                g.DrawLine(penunghi, mij3.X + 14, mij3.Y + 6, mij3.X - 12, mij3.Y - 8);

                g.DrawLine(penunghi, mij2.X - 2, mij2.Y + 15, mij2.X - 2, mij2.Y - 15);
                g.DrawLine(penunghi, mij2.X + 2, mij2.Y + 15, mij2.X + 2, mij2.Y - 15);

            }

            f1.pointA.Visible = true;
            f1.pointB.Visible = true;
            f1.pointC.Visible = true;

            f1.adaugare_triunghi(this);
            Close();
        }
    }
}
