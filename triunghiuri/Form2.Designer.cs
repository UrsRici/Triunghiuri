namespace triunghiuri
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.apply_coordonate = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.A_X = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.A_Y = new System.Windows.Forms.NumericUpDown();
            this.B_X = new System.Windows.Forms.NumericUpDown();
            this.B_Y = new System.Windows.Forms.NumericUpDown();
            this.C_Y = new System.Windows.Forms.NumericUpDown();
            this.C_X = new System.Windows.Forms.NumericUpDown();
            this.X_range = new System.Windows.Forms.Label();
            this.Y_range = new System.Windows.Forms.Label();
            this.lungimea_AB = new System.Windows.Forms.NumericUpDown();
            this.lungimea_BC = new System.Windows.Forms.NumericUpDown();
            this.lungimea_CA = new System.Windows.Forms.NumericUpDown();
            this.AB = new System.Windows.Forms.Label();
            this.BC = new System.Windows.Forms.Label();
            this.CA = new System.Windows.Forms.Label();
            this.apply_lungimi = new System.Windows.Forms.Button();
            this.L3_range = new System.Windows.Forms.Label();
            this.lungimea_L1 = new System.Windows.Forms.NumericUpDown();
            this.lungimea_L2 = new System.Windows.Forms.NumericUpDown();
            this.masura_unghiului = new System.Windows.Forms.NumericUpDown();
            this.apply_LUL = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.masuraunghiului1 = new System.Windows.Forms.Label();
            this.unghi2 = new System.Windows.Forms.NumericUpDown();
            this.lungimea_L = new System.Windows.Forms.NumericUpDown();
            this.apply_ULU = new System.Windows.Forms.Button();
            this.masuraunghiului2 = new System.Windows.Forms.Label();
            this.masuraunghiului3 = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.unghi1 = new System.Windows.Forms.NumericUpDown();
            this.b_tr_oarecare = new System.Windows.Forms.Button();
            this.b_tr_ascutitunghic = new System.Windows.Forms.Button();
            this.b_tr_obuzunghic = new System.Windows.Forms.Button();
            this.b_tr_dr = new System.Windows.Forms.Button();
            this.b_tr_dr_isoscel = new System.Windows.Forms.Button();
            this.b_tr_dr_30_60_90 = new System.Windows.Forms.Button();
            this.b_tr_isoscel = new System.Windows.Forms.Button();
            this.b_tr_echilateral = new System.Windows.Forms.Button();
            this.b_activare_coordonate = new System.Windows.Forms.Button();
            this.b_activare_LLL = new System.Windows.Forms.Button();
            this.b_activare_LUL = new System.Windows.Forms.Button();
            this.b_activare_ULU = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L2_range = new System.Windows.Forms.Label();
            this.unghi_range1 = new System.Windows.Forms.Label();
            this.unghi_range2 = new System.Windows.Forms.Label();
            this.L1_range = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.A_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_AB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_BC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_CA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_L1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_L2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masura_unghiului)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unghi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unghi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // apply_coordonate
            // 
            this.apply_coordonate.BackColor = System.Drawing.Color.PowderBlue;
            this.apply_coordonate.Location = new System.Drawing.Point(313, 567);
            this.apply_coordonate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.apply_coordonate.Name = "apply_coordonate";
            this.apply_coordonate.Size = new System.Drawing.Size(112, 35);
            this.apply_coordonate.TabIndex = 0;
            this.apply_coordonate.Text = "Apply";
            this.apply_coordonate.UseVisualStyleBackColor = false;
            this.apply_coordonate.Visible = false;
            this.apply_coordonate.Click += new System.EventHandler(this.apply_coordonate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelA.Location = new System.Drawing.Point(23, 486);
            this.labelA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelA.MaximumSize = new System.Drawing.Size(51, 30);
            this.labelA.MinimumSize = new System.Drawing.Size(51, 30);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(51, 30);
            this.labelA.TabIndex = 10;
            this.labelA.Text = "A";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelA.Visible = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelB.Location = new System.Drawing.Point(23, 526);
            this.labelB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelB.MaximumSize = new System.Drawing.Size(51, 30);
            this.labelB.MinimumSize = new System.Drawing.Size(51, 30);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(51, 30);
            this.labelB.TabIndex = 11;
            this.labelB.Text = "B";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelB.Visible = false;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelC.Location = new System.Drawing.Point(23, 567);
            this.labelC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelC.MaximumSize = new System.Drawing.Size(51, 30);
            this.labelC.MinimumSize = new System.Drawing.Size(51, 30);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(51, 30);
            this.labelC.TabIndex = 12;
            this.labelC.Text = "C";
            this.labelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelC.Visible = false;
            // 
            // A_X
            // 
            this.A_X.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.A_X.Location = new System.Drawing.Point(89, 486);
            this.A_X.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.A_X.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.A_X.Name = "A_X";
            this.A_X.Size = new System.Drawing.Size(107, 30);
            this.A_X.TabIndex = 16;
            this.A_X.Visible = false;
            // 
            // A_Y
            // 
            this.A_Y.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.A_Y.Location = new System.Drawing.Point(201, 486);
            this.A_Y.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.A_Y.Name = "A_Y";
            this.A_Y.Size = new System.Drawing.Size(107, 30);
            this.A_Y.TabIndex = 17;
            this.A_Y.Visible = false;
            // 
            // B_X
            // 
            this.B_X.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.B_X.Location = new System.Drawing.Point(89, 526);
            this.B_X.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.B_X.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.B_X.Name = "B_X";
            this.B_X.Size = new System.Drawing.Size(107, 30);
            this.B_X.TabIndex = 18;
            this.B_X.Visible = false;
            // 
            // B_Y
            // 
            this.B_Y.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.B_Y.Location = new System.Drawing.Point(201, 526);
            this.B_Y.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.B_Y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.B_Y.Name = "B_Y";
            this.B_Y.Size = new System.Drawing.Size(107, 30);
            this.B_Y.TabIndex = 19;
            this.B_Y.Visible = false;
            // 
            // C_Y
            // 
            this.C_Y.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.C_Y.Location = new System.Drawing.Point(201, 567);
            this.C_Y.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.C_Y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.C_Y.Name = "C_Y";
            this.C_Y.Size = new System.Drawing.Size(107, 30);
            this.C_Y.TabIndex = 21;
            this.C_Y.Visible = false;
            // 
            // C_X
            // 
            this.C_X.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.C_X.Location = new System.Drawing.Point(89, 567);
            this.C_X.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.C_X.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.C_X.Name = "C_X";
            this.C_X.Size = new System.Drawing.Size(107, 30);
            this.C_X.TabIndex = 20;
            this.C_X.Visible = false;
            // 
            // X_range
            // 
            this.X_range.AutoSize = true;
            this.X_range.BackColor = System.Drawing.Color.LightSkyBlue;
            this.X_range.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.X_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.X_range.ForeColor = System.Drawing.SystemColors.ControlText;
            this.X_range.Location = new System.Drawing.Point(89, 452);
            this.X_range.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.X_range.Name = "X_range";
            this.X_range.Size = new System.Drawing.Size(48, 26);
            this.X_range.TabIndex = 22;
            this.X_range.Text = "<X<";
            this.X_range.Visible = false;
            // 
            // Y_range
            // 
            this.Y_range.AutoSize = true;
            this.Y_range.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Y_range.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Y_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Y_range.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Y_range.Location = new System.Drawing.Point(201, 452);
            this.Y_range.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Y_range.Name = "Y_range";
            this.Y_range.Size = new System.Drawing.Size(46, 26);
            this.Y_range.TabIndex = 23;
            this.Y_range.Text = "<Y<";
            this.Y_range.Visible = false;
            // 
            // lungimea_AB
            // 
            this.lungimea_AB.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lungimea_AB.Location = new System.Drawing.Point(518, 299);
            this.lungimea_AB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lungimea_AB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lungimea_AB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.lungimea_AB.Name = "lungimea_AB";
            this.lungimea_AB.Size = new System.Drawing.Size(107, 30);
            this.lungimea_AB.TabIndex = 24;
            this.lungimea_AB.Visible = false;
            // 
            // lungimea_BC
            // 
            this.lungimea_BC.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lungimea_BC.Location = new System.Drawing.Point(518, 339);
            this.lungimea_BC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lungimea_BC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lungimea_BC.Name = "lungimea_BC";
            this.lungimea_BC.Size = new System.Drawing.Size(107, 30);
            this.lungimea_BC.TabIndex = 25;
            this.lungimea_BC.Visible = false;
            // 
            // lungimea_CA
            // 
            this.lungimea_CA.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lungimea_CA.Location = new System.Drawing.Point(518, 378);
            this.lungimea_CA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lungimea_CA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lungimea_CA.Name = "lungimea_CA";
            this.lungimea_CA.Size = new System.Drawing.Size(107, 30);
            this.lungimea_CA.TabIndex = 26;
            this.lungimea_CA.Visible = false;
            // 
            // AB
            // 
            this.AB.AutoSize = true;
            this.AB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AB.Location = new System.Drawing.Point(450, 299);
            this.AB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AB.MaximumSize = new System.Drawing.Size(51, 30);
            this.AB.MinimumSize = new System.Drawing.Size(51, 30);
            this.AB.Name = "AB";
            this.AB.Size = new System.Drawing.Size(51, 30);
            this.AB.TabIndex = 27;
            this.AB.Text = "AB";
            this.AB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AB.Visible = false;
            // 
            // BC
            // 
            this.BC.AutoSize = true;
            this.BC.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BC.Location = new System.Drawing.Point(450, 339);
            this.BC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BC.MaximumSize = new System.Drawing.Size(51, 30);
            this.BC.MinimumSize = new System.Drawing.Size(51, 30);
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(51, 30);
            this.BC.TabIndex = 28;
            this.BC.Text = "BC";
            this.BC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BC.Visible = false;
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CA.Location = new System.Drawing.Point(450, 378);
            this.CA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CA.MaximumSize = new System.Drawing.Size(51, 30);
            this.CA.MinimumSize = new System.Drawing.Size(51, 30);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(51, 30);
            this.CA.TabIndex = 29;
            this.CA.Text = "CA";
            this.CA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CA.Visible = false;
            // 
            // apply_lungimi
            // 
            this.apply_lungimi.BackColor = System.Drawing.Color.PowderBlue;
            this.apply_lungimi.Location = new System.Drawing.Point(742, 378);
            this.apply_lungimi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.apply_lungimi.Name = "apply_lungimi";
            this.apply_lungimi.Size = new System.Drawing.Size(112, 35);
            this.apply_lungimi.TabIndex = 30;
            this.apply_lungimi.Text = "Apply";
            this.apply_lungimi.UseVisualStyleBackColor = false;
            this.apply_lungimi.Visible = false;
            this.apply_lungimi.Click += new System.EventHandler(this.apply_lungimi_Click);
            // 
            // L3_range
            // 
            this.L3_range.AutoSize = true;
            this.L3_range.BackColor = System.Drawing.Color.LightSkyBlue;
            this.L3_range.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L3_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L3_range.ForeColor = System.Drawing.SystemColors.ControlText;
            this.L3_range.Location = new System.Drawing.Point(518, 265);
            this.L3_range.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L3_range.Name = "L3_range";
            this.L3_range.Size = new System.Drawing.Size(44, 26);
            this.L3_range.TabIndex = 31;
            this.L3_range.Text = "<L<";
            this.L3_range.Visible = false;
            // 
            // lungimea_L1
            // 
            this.lungimea_L1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lungimea_L1.Location = new System.Drawing.Point(518, 486);
            this.lungimea_L1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lungimea_L1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lungimea_L1.Name = "lungimea_L1";
            this.lungimea_L1.Size = new System.Drawing.Size(107, 30);
            this.lungimea_L1.TabIndex = 32;
            this.lungimea_L1.Visible = false;
            // 
            // lungimea_L2
            // 
            this.lungimea_L2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lungimea_L2.Location = new System.Drawing.Point(518, 526);
            this.lungimea_L2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lungimea_L2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lungimea_L2.Name = "lungimea_L2";
            this.lungimea_L2.Size = new System.Drawing.Size(107, 30);
            this.lungimea_L2.TabIndex = 33;
            this.lungimea_L2.Visible = false;
            // 
            // masura_unghiului
            // 
            this.masura_unghiului.Location = new System.Drawing.Point(728, 486);
            this.masura_unghiului.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.masura_unghiului.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.masura_unghiului.Name = "masura_unghiului";
            this.masura_unghiului.Size = new System.Drawing.Size(107, 30);
            this.masura_unghiului.TabIndex = 34;
            this.masura_unghiului.Visible = false;
            // 
            // apply_LUL
            // 
            this.apply_LUL.BackColor = System.Drawing.Color.PowderBlue;
            this.apply_LUL.Location = new System.Drawing.Point(742, 567);
            this.apply_LUL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.apply_LUL.Name = "apply_LUL";
            this.apply_LUL.Size = new System.Drawing.Size(112, 35);
            this.apply_LUL.TabIndex = 35;
            this.apply_LUL.Text = "Apply";
            this.apply_LUL.UseVisualStyleBackColor = false;
            this.apply_LUL.Visible = false;
            this.apply_LUL.Click += new System.EventHandler(this.apply_LUL_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.L1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.L1.Location = new System.Drawing.Point(450, 486);
            this.L1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L1.MaximumSize = new System.Drawing.Size(51, 30);
            this.L1.MinimumSize = new System.Drawing.Size(51, 30);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(51, 30);
            this.L1.TabIndex = 36;
            this.L1.Text = "L1";
            this.L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L1.Visible = false;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.L2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.L2.Location = new System.Drawing.Point(450, 526);
            this.L2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L2.MaximumSize = new System.Drawing.Size(51, 30);
            this.L2.MinimumSize = new System.Drawing.Size(51, 30);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(51, 30);
            this.L2.TabIndex = 37;
            this.L2.Text = "L2";
            this.L2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L2.Visible = false;
            // 
            // masuraunghiului1
            // 
            this.masuraunghiului1.AutoSize = true;
            this.masuraunghiului1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.masuraunghiului1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.masuraunghiului1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masuraunghiului1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.masuraunghiului1.Location = new System.Drawing.Point(660, 486);
            this.masuraunghiului1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.masuraunghiului1.MaximumSize = new System.Drawing.Size(51, 30);
            this.masuraunghiului1.MinimumSize = new System.Drawing.Size(51, 30);
            this.masuraunghiului1.Name = "masuraunghiului1";
            this.masuraunghiului1.Size = new System.Drawing.Size(51, 30);
            this.masuraunghiului1.TabIndex = 38;
            this.masuraunghiului1.Text = "m<";
            this.masuraunghiului1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.masuraunghiului1.Visible = false;
            // 
            // unghi2
            // 
            this.unghi2.Location = new System.Drawing.Point(89, 339);
            this.unghi2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.unghi2.Maximum = new decimal(new int[] {
            178,
            0,
            0,
            0});
            this.unghi2.Name = "unghi2";
            this.unghi2.Size = new System.Drawing.Size(107, 30);
            this.unghi2.TabIndex = 43;
            this.unghi2.Visible = false;
            this.unghi2.ValueChanged += new System.EventHandler(this.unghi2_ValueChanged);
            // 
            // lungimea_L
            // 
            this.lungimea_L.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lungimea_L.Location = new System.Drawing.Point(299, 299);
            this.lungimea_L.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lungimea_L.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lungimea_L.Name = "lungimea_L";
            this.lungimea_L.Size = new System.Drawing.Size(107, 30);
            this.lungimea_L.TabIndex = 44;
            this.lungimea_L.Visible = false;
            // 
            // apply_ULU
            // 
            this.apply_ULU.BackColor = System.Drawing.Color.PowderBlue;
            this.apply_ULU.Location = new System.Drawing.Point(313, 378);
            this.apply_ULU.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.apply_ULU.Name = "apply_ULU";
            this.apply_ULU.Size = new System.Drawing.Size(112, 35);
            this.apply_ULU.TabIndex = 45;
            this.apply_ULU.Text = "Apply";
            this.apply_ULU.UseVisualStyleBackColor = false;
            this.apply_ULU.Visible = false;
            this.apply_ULU.Click += new System.EventHandler(this.apply_ULU_Click);
            // 
            // masuraunghiului2
            // 
            this.masuraunghiului2.AutoSize = true;
            this.masuraunghiului2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.masuraunghiului2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.masuraunghiului2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masuraunghiului2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.masuraunghiului2.Location = new System.Drawing.Point(23, 299);
            this.masuraunghiului2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.masuraunghiului2.MaximumSize = new System.Drawing.Size(51, 30);
            this.masuraunghiului2.MinimumSize = new System.Drawing.Size(51, 30);
            this.masuraunghiului2.Name = "masuraunghiului2";
            this.masuraunghiului2.Size = new System.Drawing.Size(51, 30);
            this.masuraunghiului2.TabIndex = 46;
            this.masuraunghiului2.Text = "m<";
            this.masuraunghiului2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.masuraunghiului2.Visible = false;
            // 
            // masuraunghiului3
            // 
            this.masuraunghiului3.AutoSize = true;
            this.masuraunghiului3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.masuraunghiului3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.masuraunghiului3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masuraunghiului3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.masuraunghiului3.Location = new System.Drawing.Point(23, 339);
            this.masuraunghiului3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.masuraunghiului3.MaximumSize = new System.Drawing.Size(51, 30);
            this.masuraunghiului3.MinimumSize = new System.Drawing.Size(51, 30);
            this.masuraunghiului3.Name = "masuraunghiului3";
            this.masuraunghiului3.Size = new System.Drawing.Size(51, 30);
            this.masuraunghiului3.TabIndex = 47;
            this.masuraunghiului3.Text = "m<";
            this.masuraunghiului3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.masuraunghiului3.Visible = false;
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.BackColor = System.Drawing.Color.LightSkyBlue;
            this.L.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L.ForeColor = System.Drawing.SystemColors.ControlText;
            this.L.Location = new System.Drawing.Point(229, 299);
            this.L.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L.MaximumSize = new System.Drawing.Size(51, 30);
            this.L.MinimumSize = new System.Drawing.Size(51, 30);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(51, 30);
            this.L.TabIndex = 48;
            this.L.Text = "L";
            this.L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L.Visible = false;
            // 
            // unghi1
            // 
            this.unghi1.Location = new System.Drawing.Point(89, 299);
            this.unghi1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.unghi1.Maximum = new decimal(new int[] {
            178,
            0,
            0,
            0});
            this.unghi1.Name = "unghi1";
            this.unghi1.Size = new System.Drawing.Size(107, 30);
            this.unghi1.TabIndex = 42;
            this.unghi1.Visible = false;
            this.unghi1.ValueChanged += new System.EventHandler(this.unghi1_ValueChanged);
            // 
            // b_tr_oarecare
            // 
            this.b_tr_oarecare.BackColor = System.Drawing.Color.PowderBlue;
            this.b_tr_oarecare.Location = new System.Drawing.Point(490, 17);
            this.b_tr_oarecare.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_tr_oarecare.Name = "b_tr_oarecare";
            this.b_tr_oarecare.Size = new System.Drawing.Size(112, 35);
            this.b_tr_oarecare.TabIndex = 49;
            this.b_tr_oarecare.Text = "Oarecare";
            this.b_tr_oarecare.UseVisualStyleBackColor = false;
            this.b_tr_oarecare.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_tr_oarecare_MouseClick);
            // 
            // b_tr_ascutitunghic
            // 
            this.b_tr_ascutitunghic.BackColor = System.Drawing.Color.PowderBlue;
            this.b_tr_ascutitunghic.Location = new System.Drawing.Point(612, 17);
            this.b_tr_ascutitunghic.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_tr_ascutitunghic.Name = "b_tr_ascutitunghic";
            this.b_tr_ascutitunghic.Size = new System.Drawing.Size(122, 35);
            this.b_tr_ascutitunghic.TabIndex = 50;
            this.b_tr_ascutitunghic.Text = "Ascutitunghic";
            this.b_tr_ascutitunghic.UseVisualStyleBackColor = false;
            this.b_tr_ascutitunghic.Click += new System.EventHandler(this.b_tr_ascutitunghic_Click);
            // 
            // b_tr_obuzunghic
            // 
            this.b_tr_obuzunghic.BackColor = System.Drawing.Color.PowderBlue;
            this.b_tr_obuzunghic.Location = new System.Drawing.Point(612, 131);
            this.b_tr_obuzunghic.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_tr_obuzunghic.Name = "b_tr_obuzunghic";
            this.b_tr_obuzunghic.Size = new System.Drawing.Size(122, 35);
            this.b_tr_obuzunghic.TabIndex = 51;
            this.b_tr_obuzunghic.Text = "Obuzunghic";
            this.b_tr_obuzunghic.UseVisualStyleBackColor = false;
            this.b_tr_obuzunghic.Click += new System.EventHandler(this.b_tr_obuzunghic_Click);
            // 
            // b_tr_dr
            // 
            this.b_tr_dr.BackColor = System.Drawing.Color.PowderBlue;
            this.b_tr_dr.Location = new System.Drawing.Point(612, 75);
            this.b_tr_dr.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_tr_dr.Name = "b_tr_dr";
            this.b_tr_dr.Size = new System.Drawing.Size(122, 35);
            this.b_tr_dr.TabIndex = 52;
            this.b_tr_dr.Text = "Dreptunghic";
            this.b_tr_dr.UseVisualStyleBackColor = false;
            this.b_tr_dr.Click += new System.EventHandler(this.b_tr_dr_Click);
            // 
            // b_tr_dr_isoscel
            // 
            this.b_tr_dr_isoscel.BackColor = System.Drawing.Color.PowderBlue;
            this.b_tr_dr_isoscel.Location = new System.Drawing.Point(490, 188);
            this.b_tr_dr_isoscel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_tr_dr_isoscel.Name = "b_tr_dr_isoscel";
            this.b_tr_dr_isoscel.Size = new System.Drawing.Size(112, 57);
            this.b_tr_dr_isoscel.TabIndex = 53;
            this.b_tr_dr_isoscel.Text = "Dreptunghic Isoscel";
            this.b_tr_dr_isoscel.UseVisualStyleBackColor = false;
            this.b_tr_dr_isoscel.Click += new System.EventHandler(this.b_tr_dr_isoscel_Click);
            // 
            // b_tr_dr_30_60_90
            // 
            this.b_tr_dr_30_60_90.BackColor = System.Drawing.Color.PowderBlue;
            this.b_tr_dr_30_60_90.Location = new System.Drawing.Point(612, 188);
            this.b_tr_dr_30_60_90.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_tr_dr_30_60_90.Name = "b_tr_dr_30_60_90";
            this.b_tr_dr_30_60_90.Size = new System.Drawing.Size(122, 57);
            this.b_tr_dr_30_60_90.TabIndex = 54;
            this.b_tr_dr_30_60_90.Text = "Dreptunghic 30,60,90";
            this.b_tr_dr_30_60_90.UseVisualStyleBackColor = false;
            this.b_tr_dr_30_60_90.Click += new System.EventHandler(this.b_tr_dr_30_60_90_Click);
            // 
            // b_tr_isoscel
            // 
            this.b_tr_isoscel.BackColor = System.Drawing.Color.PowderBlue;
            this.b_tr_isoscel.Location = new System.Drawing.Point(490, 75);
            this.b_tr_isoscel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_tr_isoscel.Name = "b_tr_isoscel";
            this.b_tr_isoscel.Size = new System.Drawing.Size(112, 35);
            this.b_tr_isoscel.TabIndex = 55;
            this.b_tr_isoscel.Text = "Isoscel";
            this.b_tr_isoscel.UseVisualStyleBackColor = false;
            this.b_tr_isoscel.Click += new System.EventHandler(this.b_tr_isoscel_Click);
            // 
            // b_tr_echilateral
            // 
            this.b_tr_echilateral.BackColor = System.Drawing.Color.PowderBlue;
            this.b_tr_echilateral.Location = new System.Drawing.Point(490, 131);
            this.b_tr_echilateral.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_tr_echilateral.Name = "b_tr_echilateral";
            this.b_tr_echilateral.Size = new System.Drawing.Size(112, 35);
            this.b_tr_echilateral.TabIndex = 56;
            this.b_tr_echilateral.Text = "Echilateral";
            this.b_tr_echilateral.UseVisualStyleBackColor = false;
            this.b_tr_echilateral.Click += new System.EventHandler(this.b_tr_echilateral_Click);
            // 
            // b_activare_coordonate
            // 
            this.b_activare_coordonate.BackColor = System.Drawing.Color.PowderBlue;
            this.b_activare_coordonate.Location = new System.Drawing.Point(19, 17);
            this.b_activare_coordonate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_activare_coordonate.Name = "b_activare_coordonate";
            this.b_activare_coordonate.Size = new System.Drawing.Size(107, 30);
            this.b_activare_coordonate.TabIndex = 57;
            this.b_activare_coordonate.Text = "Coordonate";
            this.b_activare_coordonate.UseVisualStyleBackColor = false;
            this.b_activare_coordonate.Click += new System.EventHandler(this.b_activare_coordonate_Click);
            // 
            // b_activare_LLL
            // 
            this.b_activare_LLL.BackColor = System.Drawing.Color.PowderBlue;
            this.b_activare_LLL.Location = new System.Drawing.Point(366, 17);
            this.b_activare_LLL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_activare_LLL.Name = "b_activare_LLL";
            this.b_activare_LLL.Size = new System.Drawing.Size(107, 30);
            this.b_activare_LLL.TabIndex = 58;
            this.b_activare_LLL.Text = "L.L.L";
            this.b_activare_LLL.UseVisualStyleBackColor = false;
            this.b_activare_LLL.Click += new System.EventHandler(this.b_activare_LLL_Click);
            // 
            // b_activare_LUL
            // 
            this.b_activare_LUL.BackColor = System.Drawing.Color.PowderBlue;
            this.b_activare_LUL.Location = new System.Drawing.Point(135, 17);
            this.b_activare_LUL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_activare_LUL.Name = "b_activare_LUL";
            this.b_activare_LUL.Size = new System.Drawing.Size(107, 30);
            this.b_activare_LUL.TabIndex = 59;
            this.b_activare_LUL.Text = "L.U.L";
            this.b_activare_LUL.UseVisualStyleBackColor = false;
            this.b_activare_LUL.Click += new System.EventHandler(this.b_activare_LUL_Click);
            // 
            // b_activare_ULU
            // 
            this.b_activare_ULU.BackColor = System.Drawing.Color.PowderBlue;
            this.b_activare_ULU.Location = new System.Drawing.Point(250, 17);
            this.b_activare_ULU.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.b_activare_ULU.Name = "b_activare_ULU";
            this.b_activare_ULU.Size = new System.Drawing.Size(107, 30);
            this.b_activare_ULU.TabIndex = 60;
            this.b_activare_ULU.Text = "U.L.U";
            this.b_activare_ULU.UseVisualStyleBackColor = false;
            this.b_activare_ULU.Click += new System.EventHandler(this.b_activare_ULU_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(19, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 186);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // L2_range
            // 
            this.L2_range.AutoSize = true;
            this.L2_range.BackColor = System.Drawing.Color.LightSkyBlue;
            this.L2_range.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L2_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L2_range.ForeColor = System.Drawing.SystemColors.ControlText;
            this.L2_range.Location = new System.Drawing.Point(518, 452);
            this.L2_range.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L2_range.Name = "L2_range";
            this.L2_range.Size = new System.Drawing.Size(44, 26);
            this.L2_range.TabIndex = 62;
            this.L2_range.Text = "<L<";
            this.L2_range.Visible = false;
            // 
            // unghi_range1
            // 
            this.unghi_range1.AutoSize = true;
            this.unghi_range1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.unghi_range1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unghi_range1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unghi_range1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unghi_range1.Location = new System.Drawing.Point(728, 452);
            this.unghi_range1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.unghi_range1.Name = "unghi_range1";
            this.unghi_range1.Size = new System.Drawing.Size(73, 26);
            this.unghi_range1.TabIndex = 63;
            this.unghi_range1.Text = "<(m<)<";
            this.unghi_range1.Visible = false;
            // 
            // unghi_range2
            // 
            this.unghi_range2.AutoSize = true;
            this.unghi_range2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.unghi_range2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unghi_range2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unghi_range2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unghi_range2.Location = new System.Drawing.Point(89, 265);
            this.unghi_range2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.unghi_range2.Name = "unghi_range2";
            this.unghi_range2.Size = new System.Drawing.Size(73, 26);
            this.unghi_range2.TabIndex = 64;
            this.unghi_range2.Text = "<(m<)<";
            this.unghi_range2.Visible = false;
            // 
            // L1_range
            // 
            this.L1_range.AutoSize = true;
            this.L1_range.BackColor = System.Drawing.Color.LightSkyBlue;
            this.L1_range.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L1_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L1_range.ForeColor = System.Drawing.SystemColors.ControlText;
            this.L1_range.Location = new System.Drawing.Point(299, 265);
            this.L1_range.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L1_range.Name = "L1_range";
            this.L1_range.Size = new System.Drawing.Size(44, 26);
            this.L1_range.TabIndex = 65;
            this.L1_range.Text = "<L<";
            this.L1_range.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(754, 256);
            this.Controls.Add(this.L1_range);
            this.Controls.Add(this.unghi_range2);
            this.Controls.Add(this.unghi_range1);
            this.Controls.Add(this.L2_range);
            this.Controls.Add(this.b_activare_ULU);
            this.Controls.Add(this.b_activare_LUL);
            this.Controls.Add(this.b_activare_LLL);
            this.Controls.Add(this.b_activare_coordonate);
            this.Controls.Add(this.b_tr_echilateral);
            this.Controls.Add(this.b_tr_isoscel);
            this.Controls.Add(this.b_tr_dr_30_60_90);
            this.Controls.Add(this.b_tr_dr_isoscel);
            this.Controls.Add(this.b_tr_dr);
            this.Controls.Add(this.b_tr_obuzunghic);
            this.Controls.Add(this.b_tr_ascutitunghic);
            this.Controls.Add(this.b_tr_oarecare);
            this.Controls.Add(this.L);
            this.Controls.Add(this.masuraunghiului3);
            this.Controls.Add(this.masuraunghiului2);
            this.Controls.Add(this.apply_ULU);
            this.Controls.Add(this.lungimea_L);
            this.Controls.Add(this.unghi2);
            this.Controls.Add(this.unghi1);
            this.Controls.Add(this.masuraunghiului1);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.apply_LUL);
            this.Controls.Add(this.masura_unghiului);
            this.Controls.Add(this.lungimea_L2);
            this.Controls.Add(this.lungimea_L1);
            this.Controls.Add(this.L3_range);
            this.Controls.Add(this.apply_lungimi);
            this.Controls.Add(this.CA);
            this.Controls.Add(this.BC);
            this.Controls.Add(this.AB);
            this.Controls.Add(this.lungimea_CA);
            this.Controls.Add(this.lungimea_BC);
            this.Controls.Add(this.lungimea_AB);
            this.Controls.Add(this.Y_range);
            this.Controls.Add(this.X_range);
            this.Controls.Add(this.C_Y);
            this.Controls.Add(this.C_X);
            this.Controls.Add(this.B_Y);
            this.Controls.Add(this.B_X);
            this.Controls.Add(this.A_Y);
            this.Controls.Add(this.A_X);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.apply_coordonate);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.A_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_AB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_BC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_CA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_L1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_L2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masura_unghiului)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unghi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungimea_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unghi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apply_coordonate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label X_range;
        private System.Windows.Forms.Label Y_range;
        private System.Windows.Forms.Label AB;
        private System.Windows.Forms.Label BC;
        private System.Windows.Forms.Label CA;
        private System.Windows.Forms.Button apply_lungimi;
        private System.Windows.Forms.Label L3_range;
        private System.Windows.Forms.Button apply_LUL;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label masuraunghiului1;
        public System.Windows.Forms.NumericUpDown lungimea_AB;
        public System.Windows.Forms.NumericUpDown lungimea_BC;
        public System.Windows.Forms.NumericUpDown lungimea_CA;
        public System.Windows.Forms.NumericUpDown lungimea_L1;
        public System.Windows.Forms.NumericUpDown lungimea_L2;
        public System.Windows.Forms.NumericUpDown masura_unghiului;
        public System.Windows.Forms.NumericUpDown A_X;
        public System.Windows.Forms.NumericUpDown A_Y;
        public System.Windows.Forms.NumericUpDown B_X;
        public System.Windows.Forms.NumericUpDown B_Y;
        public System.Windows.Forms.NumericUpDown C_Y;
        public System.Windows.Forms.NumericUpDown C_X;
        public System.Windows.Forms.NumericUpDown unghi1;
        public System.Windows.Forms.NumericUpDown unghi2;
        public System.Windows.Forms.NumericUpDown lungimea_L;
        private System.Windows.Forms.Button apply_ULU;
        private System.Windows.Forms.Label masuraunghiului2;
        private System.Windows.Forms.Label masuraunghiului3;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Button b_tr_oarecare;
        private System.Windows.Forms.Button b_tr_ascutitunghic;
        private System.Windows.Forms.Button b_tr_obuzunghic;
        private System.Windows.Forms.Button b_tr_dr;
        private System.Windows.Forms.Button b_tr_dr_isoscel;
        private System.Windows.Forms.Button b_tr_dr_30_60_90;
        private System.Windows.Forms.Button b_tr_isoscel;
        private System.Windows.Forms.Button b_tr_echilateral;
        private System.Windows.Forms.Button b_activare_coordonate;
        private System.Windows.Forms.Button b_activare_LLL;
        private System.Windows.Forms.Button b_activare_LUL;
        private System.Windows.Forms.Button b_activare_ULU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L2_range;
        private System.Windows.Forms.Label unghi_range1;
        private System.Windows.Forms.Label unghi_range2;
        private System.Windows.Forms.Label L1_range;
    }
}