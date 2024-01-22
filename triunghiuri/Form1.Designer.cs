namespace triunghiuri
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pointA = new System.Windows.Forms.Label();
            this.pointB = new System.Windows.Forms.Label();
            this.pointC = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.b_mediana_1 = new System.Windows.Forms.Button();
            this.pointM = new System.Windows.Forms.Label();
            this.b_mediana_2 = new System.Windows.Forms.Button();
            this.pointN = new System.Windows.Forms.Label();
            this.pointP = new System.Windows.Forms.Label();
            this.b_mediana_3 = new System.Windows.Forms.Button();
            this.b_mediane = new System.Windows.Forms.Button();
            this.pointG = new System.Windows.Forms.Label();
            this.b_mediatoare = new System.Windows.Forms.Button();
            this.pointO = new System.Windows.Forms.Label();
            this.b_mediatoarea_1 = new System.Windows.Forms.Button();
            this.b_mediatoarea_2 = new System.Windows.Forms.Button();
            this.b_mediatoarea_3 = new System.Windows.Forms.Button();
            this.CoordonateA = new System.Windows.Forms.Label();
            this.CoordonateB = new System.Windows.Forms.Label();
            this.CoordonateC = new System.Windows.Forms.Label();
            this.unghiulA = new System.Windows.Forms.Label();
            this.unghiulB = new System.Windows.Forms.Label();
            this.unghiulC = new System.Windows.Forms.Label();
            this.b_inaltime_1 = new System.Windows.Forms.Button();
            this.b_inaltime_2 = new System.Windows.Forms.Button();
            this.b_inaltime_3 = new System.Windows.Forms.Button();
            this.b_inaltime = new System.Windows.Forms.Button();
            this.pointD = new System.Windows.Forms.Label();
            this.pointE = new System.Windows.Forms.Label();
            this.pointF = new System.Windows.Forms.Label();
            this.pointH = new System.Windows.Forms.Label();
            this.b_bisectoare_1 = new System.Windows.Forms.Button();
            this.b_bisectoare_2 = new System.Windows.Forms.Button();
            this.b_bisectoare_3 = new System.Windows.Forms.Button();
            this.b_bisectoare = new System.Windows.Forms.Button();
            this.pointI = new System.Windows.Forms.Label();
            this.pointV = new System.Windows.Forms.Label();
            this.pointU = new System.Windows.Forms.Label();
            this.pointT = new System.Windows.Forms.Label();
            this.b_muta_puncte = new System.Windows.Forms.Button();
            this.back_butoare = new System.Windows.Forms.PictureBox();
            this.b_adaugare_triunghi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.activare_mediane = new System.Windows.Forms.Button();
            this.activare_mediatoare = new System.Windows.Forms.Button();
            this.activare_inaltimi = new System.Windows.Forms.Button();
            this.activare_bisectoare = new System.Windows.Forms.Button();
            this.button_stergere_lini = new System.Windows.Forms.Button();
            this.lungimea_c = new System.Windows.Forms.Label();
            this.lungimea_b = new System.Windows.Forms.Label();
            this.lungimea_a = new System.Windows.Forms.Label();
            this.coordonate_point = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.back_butoare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pointA
            // 
            this.pointA.AutoSize = true;
            this.pointA.BackColor = System.Drawing.Color.PeachPuff;
            this.pointA.Cursor = System.Windows.Forms.Cursors.Default;
            this.pointA.Location = new System.Drawing.Point(1073, 168);
            this.pointA.Name = "pointA";
            this.pointA.Padding = new System.Windows.Forms.Padding(4, 4, 2, 3);
            this.pointA.Size = new System.Drawing.Size(20, 20);
            this.pointA.TabIndex = 3;
            this.pointA.Text = "A";
            this.pointA.Visible = false;
            this.pointA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.point_MouseDown);
            this.pointA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.point_MouseMove);
            this.pointA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.point_MouseUp);
            // 
            // pointB
            // 
            this.pointB.AutoSize = true;
            this.pointB.BackColor = System.Drawing.Color.PeachPuff;
            this.pointB.Cursor = System.Windows.Forms.Cursors.Default;
            this.pointB.Location = new System.Drawing.Point(1098, 168);
            this.pointB.Name = "pointB";
            this.pointB.Padding = new System.Windows.Forms.Padding(4, 4, 2, 3);
            this.pointB.Size = new System.Drawing.Size(20, 20);
            this.pointB.TabIndex = 4;
            this.pointB.Text = "B";
            this.pointB.Visible = false;
            this.pointB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.point_MouseDown);
            this.pointB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.point_MouseMove);
            this.pointB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.point_MouseUp);
            // 
            // pointC
            // 
            this.pointC.AutoEllipsis = true;
            this.pointC.AutoSize = true;
            this.pointC.BackColor = System.Drawing.Color.PeachPuff;
            this.pointC.Cursor = System.Windows.Forms.Cursors.Default;
            this.pointC.Location = new System.Drawing.Point(1123, 168);
            this.pointC.Name = "pointC";
            this.pointC.Padding = new System.Windows.Forms.Padding(4, 4, 2, 3);
            this.pointC.Size = new System.Drawing.Size(20, 20);
            this.pointC.TabIndex = 5;
            this.pointC.Text = "C";
            this.pointC.Visible = false;
            this.pointC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.point_MouseDown);
            this.pointC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.point_MouseMove);
            this.pointC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.point_MouseUp);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Bisque;
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.Navy;
            this.button.Location = new System.Drawing.Point(33, 26);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(130, 30);
            this.button.TabIndex = 6;
            this.button.Text = "Resetare";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // b_mediana_1
            // 
            this.b_mediana_1.BackColor = System.Drawing.Color.SteelBlue;
            this.b_mediana_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_mediana_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_mediana_1.ForeColor = System.Drawing.Color.White;
            this.b_mediana_1.Location = new System.Drawing.Point(475, 168);
            this.b_mediana_1.Name = "b_mediana_1";
            this.b_mediana_1.Size = new System.Drawing.Size(130, 30);
            this.b_mediana_1.TabIndex = 7;
            this.b_mediana_1.Text = "Mediana din A";
            this.b_mediana_1.UseVisualStyleBackColor = false;
            this.b_mediana_1.Visible = false;
            this.b_mediana_1.Click += new System.EventHandler(this.b_mediana_1_Click);
            // 
            // pointM
            // 
            this.pointM.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pointM.AutoSize = true;
            this.pointM.BackColor = System.Drawing.Color.Salmon;
            this.pointM.Location = new System.Drawing.Point(1073, 193);
            this.pointM.Name = "pointM";
            this.pointM.Padding = new System.Windows.Forms.Padding(3, 4, 1, 3);
            this.pointM.Size = new System.Drawing.Size(20, 20);
            this.pointM.TabIndex = 8;
            this.pointM.Text = "M";
            this.pointM.Visible = false;
            this.pointM.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointM.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // b_mediana_2
            // 
            this.b_mediana_2.BackColor = System.Drawing.Color.SteelBlue;
            this.b_mediana_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_mediana_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_mediana_2.ForeColor = System.Drawing.Color.White;
            this.b_mediana_2.Location = new System.Drawing.Point(610, 168);
            this.b_mediana_2.Name = "b_mediana_2";
            this.b_mediana_2.Size = new System.Drawing.Size(130, 30);
            this.b_mediana_2.TabIndex = 10;
            this.b_mediana_2.Text = "Mediana din B";
            this.b_mediana_2.UseVisualStyleBackColor = false;
            this.b_mediana_2.Visible = false;
            this.b_mediana_2.Click += new System.EventHandler(this.b_mediana_2_Click);
            // 
            // pointN
            // 
            this.pointN.AutoSize = true;
            this.pointN.BackColor = System.Drawing.Color.Salmon;
            this.pointN.Location = new System.Drawing.Point(1098, 193);
            this.pointN.Name = "pointN";
            this.pointN.Padding = new System.Windows.Forms.Padding(4, 4, 1, 3);
            this.pointN.Size = new System.Drawing.Size(20, 20);
            this.pointN.TabIndex = 11;
            this.pointN.Text = "N";
            this.pointN.Visible = false;
            this.pointN.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointN.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // pointP
            // 
            this.pointP.AutoSize = true;
            this.pointP.BackColor = System.Drawing.Color.Salmon;
            this.pointP.Location = new System.Drawing.Point(1123, 193);
            this.pointP.Name = "pointP";
            this.pointP.Padding = new System.Windows.Forms.Padding(5, 4, 1, 3);
            this.pointP.Size = new System.Drawing.Size(20, 20);
            this.pointP.TabIndex = 12;
            this.pointP.Text = "P";
            this.pointP.Visible = false;
            this.pointP.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointP.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // b_mediana_3
            // 
            this.b_mediana_3.BackColor = System.Drawing.Color.SteelBlue;
            this.b_mediana_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_mediana_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_mediana_3.ForeColor = System.Drawing.Color.White;
            this.b_mediana_3.Location = new System.Drawing.Point(745, 168);
            this.b_mediana_3.Name = "b_mediana_3";
            this.b_mediana_3.Size = new System.Drawing.Size(130, 30);
            this.b_mediana_3.TabIndex = 13;
            this.b_mediana_3.Text = "Mediana din C";
            this.b_mediana_3.UseVisualStyleBackColor = false;
            this.b_mediana_3.Visible = false;
            this.b_mediana_3.Click += new System.EventHandler(this.b_mediana_3_Click);
            // 
            // b_mediane
            // 
            this.b_mediane.BackColor = System.Drawing.Color.SteelBlue;
            this.b_mediane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_mediane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_mediane.ForeColor = System.Drawing.Color.White;
            this.b_mediane.Location = new System.Drawing.Point(881, 168);
            this.b_mediane.Name = "b_mediane";
            this.b_mediane.Size = new System.Drawing.Size(130, 30);
            this.b_mediane.TabIndex = 14;
            this.b_mediane.Text = "Toate Medianele";
            this.b_mediane.UseVisualStyleBackColor = false;
            this.b_mediane.Visible = false;
            this.b_mediane.Click += new System.EventHandler(this.b_mediane_Click);
            // 
            // pointG
            // 
            this.pointG.AutoSize = true;
            this.pointG.BackColor = System.Drawing.Color.Red;
            this.pointG.Location = new System.Drawing.Point(1148, 193);
            this.pointG.Name = "pointG";
            this.pointG.Padding = new System.Windows.Forms.Padding(4, 4, 1, 3);
            this.pointG.Size = new System.Drawing.Size(20, 20);
            this.pointG.TabIndex = 15;
            this.pointG.Text = "G";
            this.pointG.Visible = false;
            this.pointG.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointG.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // b_mediatoare
            // 
            this.b_mediatoare.BackColor = System.Drawing.Color.SteelBlue;
            this.b_mediatoare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_mediatoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_mediatoare.ForeColor = System.Drawing.Color.White;
            this.b_mediatoare.Location = new System.Drawing.Point(881, 204);
            this.b_mediatoare.Name = "b_mediatoare";
            this.b_mediatoare.Size = new System.Drawing.Size(130, 30);
            this.b_mediatoare.TabIndex = 16;
            this.b_mediatoare.Text = "Toate Mediatoarele";
            this.b_mediatoare.UseVisualStyleBackColor = false;
            this.b_mediatoare.Visible = false;
            this.b_mediatoare.Click += new System.EventHandler(this.b_mediatoare_Click);
            // 
            // pointO
            // 
            this.pointO.AutoSize = true;
            this.pointO.BackColor = System.Drawing.Color.Orange;
            this.pointO.Location = new System.Drawing.Point(1148, 168);
            this.pointO.Name = "pointO";
            this.pointO.Padding = new System.Windows.Forms.Padding(4, 4, 1, 3);
            this.pointO.Size = new System.Drawing.Size(20, 20);
            this.pointO.TabIndex = 17;
            this.pointO.Text = "O";
            this.pointO.Visible = false;
            this.pointO.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointO.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // b_mediatoarea_1
            // 
            this.b_mediatoarea_1.BackColor = System.Drawing.Color.SteelBlue;
            this.b_mediatoarea_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_mediatoarea_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_mediatoarea_1.ForeColor = System.Drawing.Color.White;
            this.b_mediatoarea_1.Location = new System.Drawing.Point(610, 204);
            this.b_mediatoarea_1.Name = "b_mediatoarea_1";
            this.b_mediatoarea_1.Size = new System.Drawing.Size(130, 30);
            this.b_mediatoarea_1.TabIndex = 18;
            this.b_mediatoarea_1.Text = "Mediatoarea [BC]";
            this.b_mediatoarea_1.UseVisualStyleBackColor = false;
            this.b_mediatoarea_1.Visible = false;
            this.b_mediatoarea_1.Click += new System.EventHandler(this.b_mediatoarea_1_Click);
            // 
            // b_mediatoarea_2
            // 
            this.b_mediatoarea_2.BackColor = System.Drawing.Color.SteelBlue;
            this.b_mediatoarea_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_mediatoarea_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_mediatoarea_2.ForeColor = System.Drawing.Color.White;
            this.b_mediatoarea_2.Location = new System.Drawing.Point(475, 205);
            this.b_mediatoarea_2.Name = "b_mediatoarea_2";
            this.b_mediatoarea_2.Size = new System.Drawing.Size(130, 30);
            this.b_mediatoarea_2.TabIndex = 19;
            this.b_mediatoarea_2.Text = "Mediatoarea [CA]";
            this.b_mediatoarea_2.UseVisualStyleBackColor = false;
            this.b_mediatoarea_2.Visible = false;
            this.b_mediatoarea_2.Click += new System.EventHandler(this.b_mediatoarea_2_Click);
            // 
            // b_mediatoarea_3
            // 
            this.b_mediatoarea_3.BackColor = System.Drawing.Color.SteelBlue;
            this.b_mediatoarea_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_mediatoarea_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_mediatoarea_3.ForeColor = System.Drawing.Color.White;
            this.b_mediatoarea_3.Location = new System.Drawing.Point(745, 204);
            this.b_mediatoarea_3.Name = "b_mediatoarea_3";
            this.b_mediatoarea_3.Size = new System.Drawing.Size(130, 30);
            this.b_mediatoarea_3.TabIndex = 20;
            this.b_mediatoarea_3.Text = "Mediatoarea [AB]";
            this.b_mediatoarea_3.UseVisualStyleBackColor = false;
            this.b_mediatoarea_3.Visible = false;
            this.b_mediatoarea_3.Click += new System.EventHandler(this.b_mediatoarea_3_Click);
            // 
            // CoordonateA
            // 
            this.CoordonateA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CoordonateA.AutoSize = true;
            this.CoordonateA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CoordonateA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CoordonateA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordonateA.Location = new System.Drawing.Point(913, 41);
            this.CoordonateA.MaximumSize = new System.Drawing.Size(103, 25);
            this.CoordonateA.MinimumSize = new System.Drawing.Size(103, 25);
            this.CoordonateA.Name = "CoordonateA";
            this.CoordonateA.Size = new System.Drawing.Size(103, 25);
            this.CoordonateA.TabIndex = 21;
            this.CoordonateA.Text = "A(x,y)";
            this.CoordonateA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CoordonateB
            // 
            this.CoordonateB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CoordonateB.AutoSize = true;
            this.CoordonateB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CoordonateB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CoordonateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordonateB.Location = new System.Drawing.Point(913, 70);
            this.CoordonateB.MaximumSize = new System.Drawing.Size(103, 25);
            this.CoordonateB.MinimumSize = new System.Drawing.Size(103, 25);
            this.CoordonateB.Name = "CoordonateB";
            this.CoordonateB.Size = new System.Drawing.Size(103, 25);
            this.CoordonateB.TabIndex = 22;
            this.CoordonateB.Text = "B(x,y)";
            this.CoordonateB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CoordonateC
            // 
            this.CoordonateC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CoordonateC.AutoSize = true;
            this.CoordonateC.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CoordonateC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CoordonateC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordonateC.Location = new System.Drawing.Point(913, 99);
            this.CoordonateC.MaximumSize = new System.Drawing.Size(103, 25);
            this.CoordonateC.MinimumSize = new System.Drawing.Size(103, 25);
            this.CoordonateC.Name = "CoordonateC";
            this.CoordonateC.Size = new System.Drawing.Size(103, 25);
            this.CoordonateC.TabIndex = 23;
            this.CoordonateC.Text = "C(x,y)";
            this.CoordonateC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unghiulA
            // 
            this.unghiulA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unghiulA.AutoSize = true;
            this.unghiulA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.unghiulA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unghiulA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unghiulA.Location = new System.Drawing.Point(1118, 41);
            this.unghiulA.MaximumSize = new System.Drawing.Size(108, 25);
            this.unghiulA.MinimumSize = new System.Drawing.Size(108, 25);
            this.unghiulA.Name = "unghiulA";
            this.unghiulA.Size = new System.Drawing.Size(108, 25);
            this.unghiulA.TabIndex = 24;
            this.unghiulA.Text = "m(<A)=";
            this.unghiulA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unghiulB
            // 
            this.unghiulB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unghiulB.AutoSize = true;
            this.unghiulB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.unghiulB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unghiulB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unghiulB.Location = new System.Drawing.Point(1118, 70);
            this.unghiulB.MaximumSize = new System.Drawing.Size(108, 25);
            this.unghiulB.MinimumSize = new System.Drawing.Size(108, 25);
            this.unghiulB.Name = "unghiulB";
            this.unghiulB.Size = new System.Drawing.Size(108, 25);
            this.unghiulB.TabIndex = 25;
            this.unghiulB.Text = "m(<B)=";
            this.unghiulB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unghiulC
            // 
            this.unghiulC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unghiulC.AutoSize = true;
            this.unghiulC.BackColor = System.Drawing.Color.LightSkyBlue;
            this.unghiulC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unghiulC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unghiulC.Location = new System.Drawing.Point(1118, 99);
            this.unghiulC.MaximumSize = new System.Drawing.Size(108, 25);
            this.unghiulC.MinimumSize = new System.Drawing.Size(108, 25);
            this.unghiulC.Name = "unghiulC";
            this.unghiulC.Size = new System.Drawing.Size(108, 25);
            this.unghiulC.TabIndex = 26;
            this.unghiulC.Text = "m(<C)=";
            this.unghiulC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_inaltime_1
            // 
            this.b_inaltime_1.BackColor = System.Drawing.Color.SteelBlue;
            this.b_inaltime_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_inaltime_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_inaltime_1.ForeColor = System.Drawing.Color.White;
            this.b_inaltime_1.Location = new System.Drawing.Point(475, 240);
            this.b_inaltime_1.Name = "b_inaltime_1";
            this.b_inaltime_1.Size = new System.Drawing.Size(130, 30);
            this.b_inaltime_1.TabIndex = 27;
            this.b_inaltime_1.Text = "Inaltimea din A";
            this.b_inaltime_1.UseVisualStyleBackColor = false;
            this.b_inaltime_1.Visible = false;
            this.b_inaltime_1.Click += new System.EventHandler(this.b_inaltime_1_Click);
            // 
            // b_inaltime_2
            // 
            this.b_inaltime_2.BackColor = System.Drawing.Color.SteelBlue;
            this.b_inaltime_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_inaltime_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_inaltime_2.ForeColor = System.Drawing.Color.White;
            this.b_inaltime_2.Location = new System.Drawing.Point(610, 240);
            this.b_inaltime_2.Name = "b_inaltime_2";
            this.b_inaltime_2.Size = new System.Drawing.Size(130, 30);
            this.b_inaltime_2.TabIndex = 28;
            this.b_inaltime_2.Text = "Inaltimea din B";
            this.b_inaltime_2.UseVisualStyleBackColor = false;
            this.b_inaltime_2.Visible = false;
            this.b_inaltime_2.Click += new System.EventHandler(this.b_inaltime_2_Click);
            // 
            // b_inaltime_3
            // 
            this.b_inaltime_3.BackColor = System.Drawing.Color.SteelBlue;
            this.b_inaltime_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_inaltime_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_inaltime_3.ForeColor = System.Drawing.Color.White;
            this.b_inaltime_3.Location = new System.Drawing.Point(745, 240);
            this.b_inaltime_3.Name = "b_inaltime_3";
            this.b_inaltime_3.Size = new System.Drawing.Size(130, 30);
            this.b_inaltime_3.TabIndex = 29;
            this.b_inaltime_3.Text = "Inaltimea din C";
            this.b_inaltime_3.UseVisualStyleBackColor = false;
            this.b_inaltime_3.Visible = false;
            this.b_inaltime_3.Click += new System.EventHandler(this.b_inaltime_3_Click);
            // 
            // b_inaltime
            // 
            this.b_inaltime.BackColor = System.Drawing.Color.SteelBlue;
            this.b_inaltime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_inaltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_inaltime.ForeColor = System.Drawing.Color.White;
            this.b_inaltime.Location = new System.Drawing.Point(881, 240);
            this.b_inaltime.Name = "b_inaltime";
            this.b_inaltime.Size = new System.Drawing.Size(130, 30);
            this.b_inaltime.TabIndex = 30;
            this.b_inaltime.Text = "Toate Inaltimile";
            this.b_inaltime.UseVisualStyleBackColor = false;
            this.b_inaltime.Visible = false;
            this.b_inaltime.Click += new System.EventHandler(this.b_inaltime_Click);
            // 
            // pointD
            // 
            this.pointD.AutoSize = true;
            this.pointD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pointD.Location = new System.Drawing.Point(1073, 218);
            this.pointD.Name = "pointD";
            this.pointD.Padding = new System.Windows.Forms.Padding(4, 4, 1, 3);
            this.pointD.Size = new System.Drawing.Size(20, 20);
            this.pointD.TabIndex = 31;
            this.pointD.Text = "D";
            this.pointD.Visible = false;
            this.pointD.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointD.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // pointE
            // 
            this.pointE.AutoSize = true;
            this.pointE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pointE.Location = new System.Drawing.Point(1098, 218);
            this.pointE.Name = "pointE";
            this.pointE.Padding = new System.Windows.Forms.Padding(4, 4, 2, 3);
            this.pointE.Size = new System.Drawing.Size(20, 20);
            this.pointE.TabIndex = 32;
            this.pointE.Text = "E";
            this.pointE.Visible = false;
            this.pointE.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointE.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // pointF
            // 
            this.pointF.AutoSize = true;
            this.pointF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pointF.Location = new System.Drawing.Point(1123, 218);
            this.pointF.Name = "pointF";
            this.pointF.Padding = new System.Windows.Forms.Padding(5, 4, 2, 3);
            this.pointF.Size = new System.Drawing.Size(20, 20);
            this.pointF.TabIndex = 33;
            this.pointF.Text = "F";
            this.pointF.Visible = false;
            this.pointF.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointF.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // pointH
            // 
            this.pointH.AutoSize = true;
            this.pointH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pointH.Location = new System.Drawing.Point(1148, 218);
            this.pointH.Name = "pointH";
            this.pointH.Padding = new System.Windows.Forms.Padding(4, 4, 1, 3);
            this.pointH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pointH.Size = new System.Drawing.Size(20, 20);
            this.pointH.TabIndex = 34;
            this.pointH.Text = "H";
            this.pointH.Visible = false;
            this.pointH.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointH.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // b_bisectoare_1
            // 
            this.b_bisectoare_1.BackColor = System.Drawing.Color.SteelBlue;
            this.b_bisectoare_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_bisectoare_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_bisectoare_1.ForeColor = System.Drawing.Color.White;
            this.b_bisectoare_1.Location = new System.Drawing.Point(475, 277);
            this.b_bisectoare_1.Name = "b_bisectoare_1";
            this.b_bisectoare_1.Size = new System.Drawing.Size(130, 30);
            this.b_bisectoare_1.TabIndex = 35;
            this.b_bisectoare_1.Text = "Bisectoarea lui A";
            this.b_bisectoare_1.UseVisualStyleBackColor = false;
            this.b_bisectoare_1.Visible = false;
            this.b_bisectoare_1.Click += new System.EventHandler(this.b_bisectoare_1_Click);
            // 
            // b_bisectoare_2
            // 
            this.b_bisectoare_2.BackColor = System.Drawing.Color.SteelBlue;
            this.b_bisectoare_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_bisectoare_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_bisectoare_2.ForeColor = System.Drawing.Color.White;
            this.b_bisectoare_2.Location = new System.Drawing.Point(610, 276);
            this.b_bisectoare_2.Name = "b_bisectoare_2";
            this.b_bisectoare_2.Size = new System.Drawing.Size(130, 30);
            this.b_bisectoare_2.TabIndex = 36;
            this.b_bisectoare_2.Text = "Bisectoarea lui B";
            this.b_bisectoare_2.UseVisualStyleBackColor = false;
            this.b_bisectoare_2.Visible = false;
            this.b_bisectoare_2.Click += new System.EventHandler(this.b_bisectoare_2_Click);
            // 
            // b_bisectoare_3
            // 
            this.b_bisectoare_3.BackColor = System.Drawing.Color.SteelBlue;
            this.b_bisectoare_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_bisectoare_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_bisectoare_3.ForeColor = System.Drawing.Color.White;
            this.b_bisectoare_3.Location = new System.Drawing.Point(745, 276);
            this.b_bisectoare_3.Name = "b_bisectoare_3";
            this.b_bisectoare_3.Size = new System.Drawing.Size(130, 30);
            this.b_bisectoare_3.TabIndex = 37;
            this.b_bisectoare_3.Text = "Bisectoarea lui C";
            this.b_bisectoare_3.UseVisualStyleBackColor = false;
            this.b_bisectoare_3.Visible = false;
            this.b_bisectoare_3.Click += new System.EventHandler(this.b_bisectoare_3_Click);
            // 
            // b_bisectoare
            // 
            this.b_bisectoare.BackColor = System.Drawing.Color.SteelBlue;
            this.b_bisectoare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_bisectoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_bisectoare.ForeColor = System.Drawing.Color.White;
            this.b_bisectoare.Location = new System.Drawing.Point(881, 276);
            this.b_bisectoare.Name = "b_bisectoare";
            this.b_bisectoare.Size = new System.Drawing.Size(130, 30);
            this.b_bisectoare.TabIndex = 38;
            this.b_bisectoare.Text = "Toate Bisectoarele";
            this.b_bisectoare.UseVisualStyleBackColor = false;
            this.b_bisectoare.Visible = false;
            this.b_bisectoare.Click += new System.EventHandler(this.b_bisectoare_Click);
            // 
            // pointI
            // 
            this.pointI.AutoSize = true;
            this.pointI.BackColor = System.Drawing.Color.ForestGreen;
            this.pointI.Location = new System.Drawing.Point(1148, 243);
            this.pointI.Name = "pointI";
            this.pointI.Padding = new System.Windows.Forms.Padding(6, 4, 4, 3);
            this.pointI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pointI.Size = new System.Drawing.Size(20, 20);
            this.pointI.TabIndex = 42;
            this.pointI.Text = "I";
            this.pointI.Visible = false;
            this.pointI.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointI.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // pointV
            // 
            this.pointV.AutoSize = true;
            this.pointV.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pointV.Location = new System.Drawing.Point(1123, 243);
            this.pointV.Name = "pointV";
            this.pointV.Padding = new System.Windows.Forms.Padding(4, 4, 2, 3);
            this.pointV.Size = new System.Drawing.Size(20, 20);
            this.pointV.TabIndex = 41;
            this.pointV.Text = "V";
            this.pointV.Visible = false;
            this.pointV.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointV.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // pointU
            // 
            this.pointU.AutoSize = true;
            this.pointU.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pointU.Location = new System.Drawing.Point(1098, 243);
            this.pointU.Name = "pointU";
            this.pointU.Padding = new System.Windows.Forms.Padding(3, 4, 2, 3);
            this.pointU.Size = new System.Drawing.Size(20, 20);
            this.pointU.TabIndex = 40;
            this.pointU.Text = "U";
            this.pointU.Visible = false;
            this.pointU.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointU.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // pointT
            // 
            this.pointT.AutoSize = true;
            this.pointT.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pointT.Location = new System.Drawing.Point(1073, 243);
            this.pointT.Name = "pointT";
            this.pointT.Padding = new System.Windows.Forms.Padding(4, 4, 2, 3);
            this.pointT.Size = new System.Drawing.Size(20, 20);
            this.pointT.TabIndex = 39;
            this.pointT.Text = "T";
            this.pointT.Visible = false;
            this.pointT.MouseLeave += new System.EventHandler(this.point_MouseHoverLeave);
            this.pointT.MouseHover += new System.EventHandler(this.point_MouseHover);
            // 
            // b_muta_puncte
            // 
            this.b_muta_puncte.BackColor = System.Drawing.Color.Bisque;
            this.b_muta_puncte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_muta_puncte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_muta_puncte.ForeColor = System.Drawing.Color.Navy;
            this.b_muta_puncte.Location = new System.Drawing.Point(33, 66);
            this.b_muta_puncte.Name = "b_muta_puncte";
            this.b_muta_puncte.Size = new System.Drawing.Size(130, 30);
            this.b_muta_puncte.TabIndex = 43;
            this.b_muta_puncte.Text = "Muta puncte";
            this.b_muta_puncte.UseVisualStyleBackColor = false;
            this.b_muta_puncte.Click += new System.EventHandler(this.b_muta_puncte_Click);
            // 
            // back_butoare
            // 
            this.back_butoare.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.back_butoare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_butoare.BackColor = System.Drawing.Color.Navy;
            this.back_butoare.Location = new System.Drawing.Point(11, 12);
            this.back_butoare.Name = "back_butoare";
            this.back_butoare.Size = new System.Drawing.Size(1250, 140);
            this.back_butoare.TabIndex = 44;
            this.back_butoare.TabStop = false;
            // 
            // b_adaugare_triunghi
            // 
            this.b_adaugare_triunghi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_adaugare_triunghi.BackColor = System.Drawing.Color.Bisque;
            this.b_adaugare_triunghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_adaugare_triunghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_adaugare_triunghi.ForeColor = System.Drawing.Color.Navy;
            this.b_adaugare_triunghi.Location = new System.Drawing.Point(749, 32);
            this.b_adaugare_triunghi.Name = "b_adaugare_triunghi";
            this.b_adaugare_triunghi.Size = new System.Drawing.Size(130, 30);
            this.b_adaugare_triunghi.TabIndex = 45;
            this.b_adaugare_triunghi.Text = "Adauga triunghi";
            this.b_adaugare_triunghi.UseVisualStyleBackColor = false;
            this.b_adaugare_triunghi.Click += new System.EventHandler(this.b_adaugare_triunghi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(897, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 100);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // activare_mediane
            // 
            this.activare_mediane.BackColor = System.Drawing.Color.Bisque;
            this.activare_mediane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activare_mediane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activare_mediane.ForeColor = System.Drawing.Color.Navy;
            this.activare_mediane.Location = new System.Drawing.Point(193, 26);
            this.activare_mediane.Name = "activare_mediane";
            this.activare_mediane.Size = new System.Drawing.Size(130, 30);
            this.activare_mediane.TabIndex = 47;
            this.activare_mediane.Text = "Mediane";
            this.activare_mediane.UseVisualStyleBackColor = false;
            this.activare_mediane.Click += new System.EventHandler(this.mediane_Click);
            // 
            // activare_mediatoare
            // 
            this.activare_mediatoare.BackColor = System.Drawing.Color.Bisque;
            this.activare_mediatoare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activare_mediatoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activare_mediatoare.ForeColor = System.Drawing.Color.Navy;
            this.activare_mediatoare.Location = new System.Drawing.Point(329, 26);
            this.activare_mediatoare.Name = "activare_mediatoare";
            this.activare_mediatoare.Size = new System.Drawing.Size(130, 30);
            this.activare_mediatoare.TabIndex = 48;
            this.activare_mediatoare.Text = "Mediatoare";
            this.activare_mediatoare.UseVisualStyleBackColor = false;
            this.activare_mediatoare.Click += new System.EventHandler(this.mediatoare_Click);
            // 
            // activare_inaltimi
            // 
            this.activare_inaltimi.BackColor = System.Drawing.Color.Bisque;
            this.activare_inaltimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activare_inaltimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activare_inaltimi.ForeColor = System.Drawing.Color.Navy;
            this.activare_inaltimi.Location = new System.Drawing.Point(465, 26);
            this.activare_inaltimi.Name = "activare_inaltimi";
            this.activare_inaltimi.Size = new System.Drawing.Size(130, 30);
            this.activare_inaltimi.TabIndex = 49;
            this.activare_inaltimi.Text = "Inaltimi";
            this.activare_inaltimi.UseVisualStyleBackColor = false;
            this.activare_inaltimi.Click += new System.EventHandler(this.inaltimi_Click);
            // 
            // activare_bisectoare
            // 
            this.activare_bisectoare.BackColor = System.Drawing.Color.Bisque;
            this.activare_bisectoare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activare_bisectoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activare_bisectoare.ForeColor = System.Drawing.Color.Navy;
            this.activare_bisectoare.Location = new System.Drawing.Point(601, 26);
            this.activare_bisectoare.Name = "activare_bisectoare";
            this.activare_bisectoare.Size = new System.Drawing.Size(130, 30);
            this.activare_bisectoare.TabIndex = 50;
            this.activare_bisectoare.Text = "Bisectoare";
            this.activare_bisectoare.UseVisualStyleBackColor = false;
            this.activare_bisectoare.Click += new System.EventHandler(this.bisectoare_Click);
            // 
            // button_stergere_lini
            // 
            this.button_stergere_lini.BackColor = System.Drawing.Color.Bisque;
            this.button_stergere_lini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_stergere_lini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stergere_lini.ForeColor = System.Drawing.Color.Navy;
            this.button_stergere_lini.Location = new System.Drawing.Point(33, 106);
            this.button_stergere_lini.Name = "button_stergere_lini";
            this.button_stergere_lini.Size = new System.Drawing.Size(130, 30);
            this.button_stergere_lini.TabIndex = 51;
            this.button_stergere_lini.Text = "Sterge liniile";
            this.button_stergere_lini.UseVisualStyleBackColor = false;
            this.button_stergere_lini.Click += new System.EventHandler(this.button_stergere_lini_Click);
            // 
            // lungimea_c
            // 
            this.lungimea_c.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lungimea_c.AutoSize = true;
            this.lungimea_c.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lungimea_c.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lungimea_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lungimea_c.Location = new System.Drawing.Point(1025, 99);
            this.lungimea_c.MaximumSize = new System.Drawing.Size(83, 25);
            this.lungimea_c.MinimumSize = new System.Drawing.Size(83, 25);
            this.lungimea_c.Name = "lungimea_c";
            this.lungimea_c.Size = new System.Drawing.Size(83, 25);
            this.lungimea_c.TabIndex = 54;
            this.lungimea_c.Text = "CA=";
            this.lungimea_c.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lungimea_b
            // 
            this.lungimea_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lungimea_b.AutoSize = true;
            this.lungimea_b.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lungimea_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lungimea_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lungimea_b.Location = new System.Drawing.Point(1025, 70);
            this.lungimea_b.MaximumSize = new System.Drawing.Size(83, 25);
            this.lungimea_b.MinimumSize = new System.Drawing.Size(83, 25);
            this.lungimea_b.Name = "lungimea_b";
            this.lungimea_b.Size = new System.Drawing.Size(83, 25);
            this.lungimea_b.TabIndex = 53;
            this.lungimea_b.Text = "BC=";
            this.lungimea_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lungimea_a
            // 
            this.lungimea_a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lungimea_a.AutoSize = true;
            this.lungimea_a.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lungimea_a.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lungimea_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lungimea_a.Location = new System.Drawing.Point(1025, 41);
            this.lungimea_a.MaximumSize = new System.Drawing.Size(83, 25);
            this.lungimea_a.MinimumSize = new System.Drawing.Size(83, 25);
            this.lungimea_a.Name = "lungimea_a";
            this.lungimea_a.Size = new System.Drawing.Size(83, 25);
            this.lungimea_a.TabIndex = 52;
            this.lungimea_a.Text = "AB=";
            this.lungimea_a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // coordonate_point
            // 
            this.coordonate_point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coordonate_point.AutoSize = true;
            this.coordonate_point.BackColor = System.Drawing.Color.LightSkyBlue;
            this.coordonate_point.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.coordonate_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordonate_point.Location = new System.Drawing.Point(749, 87);
            this.coordonate_point.MinimumSize = new System.Drawing.Size(130, 25);
            this.coordonate_point.Name = "coordonate_point";
            this.coordonate_point.Size = new System.Drawing.Size(130, 25);
            this.coordonate_point.TabIndex = 55;
            this.coordonate_point.Text = "(x,y)";
            this.coordonate_point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coordonate_point.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(807, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(857, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1271, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_bisectoare);
            this.Controls.Add(this.b_bisectoare_3);
            this.Controls.Add(this.b_bisectoare_2);
            this.Controls.Add(this.b_bisectoare_1);
            this.Controls.Add(this.b_inaltime);
            this.Controls.Add(this.b_inaltime_3);
            this.Controls.Add(this.b_inaltime_2);
            this.Controls.Add(this.b_inaltime_1);
            this.Controls.Add(this.b_mediatoarea_1);
            this.Controls.Add(this.b_mediatoarea_2);
            this.Controls.Add(this.b_mediatoarea_3);
            this.Controls.Add(this.b_mediatoare);
            this.Controls.Add(this.b_mediane);
            this.Controls.Add(this.b_mediana_3);
            this.Controls.Add(this.b_mediana_2);
            this.Controls.Add(this.b_mediana_1);
            this.Controls.Add(this.coordonate_point);
            this.Controls.Add(this.lungimea_c);
            this.Controls.Add(this.lungimea_b);
            this.Controls.Add(this.lungimea_a);
            this.Controls.Add(this.button_stergere_lini);
            this.Controls.Add(this.activare_bisectoare);
            this.Controls.Add(this.activare_inaltimi);
            this.Controls.Add(this.activare_mediatoare);
            this.Controls.Add(this.activare_mediane);
            this.Controls.Add(this.b_adaugare_triunghi);
            this.Controls.Add(this.b_muta_puncte);
            this.Controls.Add(this.button);
            this.Controls.Add(this.unghiulC);
            this.Controls.Add(this.unghiulB);
            this.Controls.Add(this.unghiulA);
            this.Controls.Add(this.CoordonateC);
            this.Controls.Add(this.CoordonateB);
            this.Controls.Add(this.CoordonateA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_butoare);
            this.Controls.Add(this.pointA);
            this.Controls.Add(this.pointB);
            this.Controls.Add(this.pointC);
            this.Controls.Add(this.pointO);
            this.Controls.Add(this.pointI);
            this.Controls.Add(this.pointH);
            this.Controls.Add(this.pointG);
            this.Controls.Add(this.pointV);
            this.Controls.Add(this.pointU);
            this.Controls.Add(this.pointT);
            this.Controls.Add(this.pointF);
            this.Controls.Add(this.pointE);
            this.Controls.Add(this.pointD);
            this.Controls.Add(this.pointP);
            this.Controls.Add(this.pointN);
            this.Controls.Add(this.pointM);
            this.ForeColor = System.Drawing.Color.Black;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "Triunghiuri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.back_butoare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button b_mediana_1;
        private System.Windows.Forms.Label pointM;
        private System.Windows.Forms.Button b_mediana_2;
        private System.Windows.Forms.Label pointN;
        private System.Windows.Forms.Label pointP;
        private System.Windows.Forms.Button b_mediana_3;
        private System.Windows.Forms.Button b_mediane;
        private System.Windows.Forms.Label pointG;
        private System.Windows.Forms.Button b_mediatoare;
        private System.Windows.Forms.Label pointO;
        private System.Windows.Forms.Button b_mediatoarea_1;
        private System.Windows.Forms.Button b_mediatoarea_2;
        private System.Windows.Forms.Button b_mediatoarea_3;
        private System.Windows.Forms.Button b_inaltime_1;
        private System.Windows.Forms.Button b_inaltime_2;
        private System.Windows.Forms.Button b_inaltime_3;
        private System.Windows.Forms.Button b_inaltime;
        private System.Windows.Forms.Label pointD;
        private System.Windows.Forms.Label pointE;
        private System.Windows.Forms.Label pointF;
        private System.Windows.Forms.Label pointH;
        private System.Windows.Forms.Button b_bisectoare_1;
        private System.Windows.Forms.Button b_bisectoare_2;
        private System.Windows.Forms.Button b_bisectoare_3;
        private System.Windows.Forms.Button b_bisectoare;
        private System.Windows.Forms.Label pointI;
        private System.Windows.Forms.Label pointV;
        private System.Windows.Forms.Label pointU;
        private System.Windows.Forms.Label pointT;
        private System.Windows.Forms.Button b_muta_puncte;
        private System.Windows.Forms.PictureBox back_butoare;
        private System.Windows.Forms.Button b_adaugare_triunghi;
        public System.Windows.Forms.Label pointA;
        public System.Windows.Forms.Label pointB;
        public System.Windows.Forms.Label pointC;
        public System.Windows.Forms.Label CoordonateA;
        public System.Windows.Forms.Label CoordonateB;
        public System.Windows.Forms.Label CoordonateC;
        public System.Windows.Forms.Label unghiulA;
        public System.Windows.Forms.Label unghiulB;
        public System.Windows.Forms.Label unghiulC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button activare_mediane;
        private System.Windows.Forms.Button activare_mediatoare;
        private System.Windows.Forms.Button activare_inaltimi;
        private System.Windows.Forms.Button activare_bisectoare;
        private System.Windows.Forms.Button button_stergere_lini;
        public System.Windows.Forms.Label lungimea_c;
        public System.Windows.Forms.Label lungimea_b;
        public System.Windows.Forms.Label lungimea_a;
        public System.Windows.Forms.Label coordonate_point;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}

