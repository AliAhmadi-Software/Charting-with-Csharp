namespace Charting
{
    partial class frmMain
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
            this.rbtnAria = new System.Windows.Forms.RadioButton();
            this.rbtnPyramid = new System.Windows.Forms.RadioButton();
            this.rbtnPie = new System.Windows.Forms.RadioButton();
            this.rbtnBar = new System.Windows.Forms.RadioButton();
            this.rbtnLine = new System.Windows.Forms.RadioButton();
            this.rbtnPoint = new System.Windows.Forms.RadioButton();
            this.rbtnPrice = new System.Windows.Forms.RadioButton();
            this.rbtnFunnel = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbx3D = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxChart = new System.Windows.Forms.GroupBox();
            this.gbxAria = new System.Windows.Forms.GroupBox();
            this.cmbTypeAria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxFunnel = new System.Windows.Forms.GroupBox();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.nudPointGap = new System.Windows.Forms.NumericUpDown();
            this.cmbchartStyleFunnel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxLine = new System.Windows.Forms.GroupBox();
            this.cmbTypeLine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxPie = new System.Windows.Forms.GroupBox();
            this.cmbDesignPie = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cbxRotate = new System.Windows.Forms.CheckBox();
            this.cmbExplodedPoint = new System.Windows.Forms.ComboBox();
            this.cmbLabelStyle = new System.Windows.Forms.ComboBox();
            this.cmbTypePie = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbxPoint = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.gbxPyramid = new System.Windows.Forms.GroupBox();
            this.nudAnglePyramid = new System.Windows.Forms.NumericUpDown();
            this.nudPointPyramid = new System.Windows.Forms.NumericUpDown();
            this.cmbTypePyramid = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gbxBar = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbxAria.SuspendLayout();
            this.gbxFunnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointGap)).BeginInit();
            this.gbxLine.SuspendLayout();
            this.gbxPie.SuspendLayout();
            this.gbxPoint.SuspendLayout();
            this.gbxPyramid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnglePyramid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointPyramid)).BeginInit();
            this.gbxBar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnAria
            // 
            this.rbtnAria.AutoSize = true;
            this.rbtnAria.Location = new System.Drawing.Point(757, 18);
            this.rbtnAria.Name = "rbtnAria";
            this.rbtnAria.Size = new System.Drawing.Size(71, 17);
            this.rbtnAria.TabIndex = 0;
            this.rbtnAria.TabStop = true;
            this.rbtnAria.Text = "منطقه ای";
            this.rbtnAria.UseVisualStyleBackColor = true;
            this.rbtnAria.CheckedChanged += new System.EventHandler(this.rbtnAria_CheckedChanged);
            // 
            // rbtnPyramid
            // 
            this.rbtnPyramid.AutoSize = true;
            this.rbtnPyramid.Location = new System.Drawing.Point(458, 18);
            this.rbtnPyramid.Name = "rbtnPyramid";
            this.rbtnPyramid.Size = new System.Drawing.Size(55, 17);
            this.rbtnPyramid.TabIndex = 1;
            this.rbtnPyramid.TabStop = true;
            this.rbtnPyramid.Text = "هرمی";
            this.rbtnPyramid.UseVisualStyleBackColor = true;
            this.rbtnPyramid.CheckedChanged += new System.EventHandler(this.rbtnPyramid_CheckedChanged);
            // 
            // rbtnPie
            // 
            this.rbtnPie.AutoSize = true;
            this.rbtnPie.Location = new System.Drawing.Point(390, 18);
            this.rbtnPie.Name = "rbtnPie";
            this.rbtnPie.Size = new System.Drawing.Size(62, 17);
            this.rbtnPie.TabIndex = 2;
            this.rbtnPie.TabStop = true;
            this.rbtnPie.Text = "دایره ای";
            this.rbtnPie.UseVisualStyleBackColor = true;
            this.rbtnPie.CheckedChanged += new System.EventHandler(this.rbtnPie_CheckedChanged);
            // 
            // rbtnBar
            // 
            this.rbtnBar.AutoSize = true;
            this.rbtnBar.Location = new System.Drawing.Point(323, 18);
            this.rbtnBar.Name = "rbtnBar";
            this.rbtnBar.Size = new System.Drawing.Size(61, 17);
            this.rbtnBar.TabIndex = 3;
            this.rbtnBar.TabStop = true;
            this.rbtnBar.Text = "میله ای";
            this.rbtnBar.UseVisualStyleBackColor = true;
            this.rbtnBar.CheckedChanged += new System.EventHandler(this.rbtnBar_CheckedChanged);
            // 
            // rbtnLine
            // 
            this.rbtnLine.AutoSize = true;
            this.rbtnLine.Location = new System.Drawing.Point(519, 18);
            this.rbtnLine.Name = "rbtnLine";
            this.rbtnLine.Size = new System.Drawing.Size(51, 17);
            this.rbtnLine.TabIndex = 4;
            this.rbtnLine.TabStop = true;
            this.rbtnLine.Text = "خطی";
            this.rbtnLine.UseVisualStyleBackColor = true;
            this.rbtnLine.CheckedChanged += new System.EventHandler(this.rbtnLine_CheckedChanged);
            // 
            // rbtnPoint
            // 
            this.rbtnPoint.AutoSize = true;
            this.rbtnPoint.Location = new System.Drawing.Point(576, 18);
            this.rbtnPoint.Name = "rbtnPoint";
            this.rbtnPoint.Size = new System.Drawing.Size(64, 17);
            this.rbtnPoint.TabIndex = 5;
            this.rbtnPoint.TabStop = true;
            this.rbtnPoint.Text = "نقطه ای";
            this.rbtnPoint.UseVisualStyleBackColor = true;
            this.rbtnPoint.CheckedChanged += new System.EventHandler(this.rbtnPoint_CheckedChanged);
            // 
            // rbtnPrice
            // 
            this.rbtnPrice.AutoSize = true;
            this.rbtnPrice.Location = new System.Drawing.Point(646, 18);
            this.rbtnPrice.Name = "rbtnPrice";
            this.rbtnPrice.Size = new System.Drawing.Size(48, 17);
            this.rbtnPrice.TabIndex = 6;
            this.rbtnPrice.TabStop = true;
            this.rbtnPrice.Text = "مالی";
            this.rbtnPrice.UseVisualStyleBackColor = true;
            this.rbtnPrice.CheckedChanged += new System.EventHandler(this.rbtnPrice_CheckedChanged);
            // 
            // rbtnFunnel
            // 
            this.rbtnFunnel.AutoSize = true;
            this.rbtnFunnel.Location = new System.Drawing.Point(700, 18);
            this.rbtnFunnel.Name = "rbtnFunnel";
            this.rbtnFunnel.Size = new System.Drawing.Size(51, 17);
            this.rbtnFunnel.TabIndex = 7;
            this.rbtnFunnel.TabStop = true;
            this.rbtnFunnel.Text = "قیفی";
            this.rbtnFunnel.UseVisualStyleBackColor = true;
            this.rbtnFunnel.CheckedChanged += new System.EventHandler(this.rbtnFunnel_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbx3D);
            this.groupBox1.Controls.Add(this.rbtnAria);
            this.groupBox1.Controls.Add(this.rbtnPrice);
            this.groupBox1.Controls.Add(this.rbtnFunnel);
            this.groupBox1.Controls.Add(this.rbtnPyramid);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.rbtnPie);
            this.groupBox1.Controls.Add(this.rbtnLine);
            this.groupBox1.Controls.Add(this.rbtnPoint);
            this.groupBox1.Controls.Add(this.rbtnBar);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب نوع نمودار";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "رسم نمودار";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx3D
            // 
            this.cbx3D.AutoSize = true;
            this.cbx3D.Location = new System.Drawing.Point(757, 44);
            this.cbx3D.Name = "cbx3D";
            this.cbx3D.Size = new System.Drawing.Size(71, 17);
            this.cbx3D.TabIndex = 17;
            this.cbx3D.Text = "سه بعدی";
            this.cbx3D.UseVisualStyleBackColor = true;
            this.cbx3D.CheckedChanged += new System.EventHandler(this.cbx3D_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "نمودار Real Time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbxChart
            // 
            this.gbxChart.Location = new System.Drawing.Point(9, 123);
            this.gbxChart.Name = "gbxChart";
            this.gbxChart.Size = new System.Drawing.Size(834, 454);
            this.gbxChart.TabIndex = 10;
            this.gbxChart.TabStop = false;
            // 
            // gbxAria
            // 
            this.gbxAria.Controls.Add(this.cmbTypeAria);
            this.gbxAria.Controls.Add(this.label1);
            this.gbxAria.Location = new System.Drawing.Point(859, 8);
            this.gbxAria.Name = "gbxAria";
            this.gbxAria.Size = new System.Drawing.Size(235, 45);
            this.gbxAria.TabIndex = 11;
            this.gbxAria.TabStop = false;
            this.gbxAria.Text = "تنظیمات منطقه ای";
            // 
            // cmbTypeAria
            // 
            this.cmbTypeAria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeAria.FormattingEnabled = true;
            this.cmbTypeAria.Items.AddRange(new object[] {
            "لبه تیز",
            "لبه گرد"});
            this.cmbTypeAria.Location = new System.Drawing.Point(9, 17);
            this.cmbTypeAria.Name = "cmbTypeAria";
            this.cmbTypeAria.Size = new System.Drawing.Size(104, 21);
            this.cmbTypeAria.TabIndex = 4;
            this.cmbTypeAria.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "نوع نمودار:";
            // 
            // gbxFunnel
            // 
            this.gbxFunnel.Controls.Add(this.nudAngle);
            this.gbxFunnel.Controls.Add(this.nudPointGap);
            this.gbxFunnel.Controls.Add(this.cmbchartStyleFunnel);
            this.gbxFunnel.Controls.Add(this.label6);
            this.gbxFunnel.Controls.Add(this.label5);
            this.gbxFunnel.Controls.Add(this.label2);
            this.gbxFunnel.Enabled = false;
            this.gbxFunnel.Location = new System.Drawing.Point(859, 55);
            this.gbxFunnel.Name = "gbxFunnel";
            this.gbxFunnel.Size = new System.Drawing.Size(235, 85);
            this.gbxFunnel.TabIndex = 13;
            this.gbxFunnel.TabStop = false;
            this.gbxFunnel.Text = "تنظیمات قیفی";
            // 
            // nudAngle
            // 
            this.nudAngle.Location = new System.Drawing.Point(9, 35);
            this.nudAngle.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAngle.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(104, 21);
            this.nudAngle.TabIndex = 27;
            this.nudAngle.ValueChanged += new System.EventHandler(this.nudAngle_ValueChanged);
            // 
            // nudPointGap
            // 
            this.nudPointGap.Location = new System.Drawing.Point(9, 12);
            this.nudPointGap.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPointGap.Name = "nudPointGap";
            this.nudPointGap.Size = new System.Drawing.Size(104, 21);
            this.nudPointGap.TabIndex = 28;
            this.nudPointGap.ValueChanged += new System.EventHandler(this.nudPointGap_ValueChanged);
            // 
            // cmbchartStyleFunnel
            // 
            this.cmbchartStyleFunnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbchartStyleFunnel.FormattingEnabled = true;
            this.cmbchartStyleFunnel.Items.AddRange(new object[] {
            "خطوط مربعی",
            "خطوط دایره ای"});
            this.cmbchartStyleFunnel.Location = new System.Drawing.Point(9, 58);
            this.cmbchartStyleFunnel.Name = "cmbchartStyleFunnel";
            this.cmbchartStyleFunnel.Size = new System.Drawing.Size(104, 21);
            this.cmbchartStyleFunnel.TabIndex = 26;
            this.cmbchartStyleFunnel.SelectedIndexChanged += new System.EventHandler(this.cmbchartStyleFunnel_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "زاویه:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "فاصله نقطه ها از هم:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "نوع نمایش خطوط:";
            // 
            // gbxLine
            // 
            this.gbxLine.Controls.Add(this.cmbTypeLine);
            this.gbxLine.Controls.Add(this.label3);
            this.gbxLine.Enabled = false;
            this.gbxLine.Location = new System.Drawing.Point(859, 234);
            this.gbxLine.Name = "gbxLine";
            this.gbxLine.Size = new System.Drawing.Size(235, 40);
            this.gbxLine.TabIndex = 14;
            this.gbxLine.TabStop = false;
            this.gbxLine.Text = "تنظیمات خطی";
            // 
            // cmbTypeLine
            // 
            this.cmbTypeLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeLine.FormattingEnabled = true;
            this.cmbTypeLine.Items.AddRange(new object[] {
            "خطی تیز",
            "خطی گرد"});
            this.cmbTypeLine.Location = new System.Drawing.Point(9, 14);
            this.cmbTypeLine.Name = "cmbTypeLine";
            this.cmbTypeLine.Size = new System.Drawing.Size(104, 21);
            this.cmbTypeLine.TabIndex = 4;
            this.cmbTypeLine.SelectedIndexChanged += new System.EventHandler(this.cmbTypeLine_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "نوع نمودار:";
            // 
            // gbxPie
            // 
            this.gbxPie.Controls.Add(this.cmbDesignPie);
            this.gbxPie.Controls.Add(this.label7);
            this.gbxPie.Controls.Add(this.button3);
            this.gbxPie.Controls.Add(this.cbxRotate);
            this.gbxPie.Controls.Add(this.cmbExplodedPoint);
            this.gbxPie.Controls.Add(this.cmbLabelStyle);
            this.gbxPie.Controls.Add(this.cmbTypePie);
            this.gbxPie.Controls.Add(this.label8);
            this.gbxPie.Controls.Add(this.label9);
            this.gbxPie.Controls.Add(this.label10);
            this.gbxPie.Enabled = false;
            this.gbxPie.Location = new System.Drawing.Point(859, 367);
            this.gbxPie.Name = "gbxPie";
            this.gbxPie.Size = new System.Drawing.Size(235, 158);
            this.gbxPie.TabIndex = 15;
            this.gbxPie.TabStop = false;
            this.gbxPie.Text = "تنظیمات دایره ای";
            // 
            // cmbDesignPie
            // 
            this.cmbDesignPie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignPie.FormattingEnabled = true;
            this.cmbDesignPie.Items.AddRange(new object[] {
            "پیش فرض",
            "لبه صف",
            "مقعر"});
            this.cmbDesignPie.Location = new System.Drawing.Point(6, 63);
            this.cmbDesignPie.Name = "cmbDesignPie";
            this.cmbDesignPie.Size = new System.Drawing.Size(107, 21);
            this.cmbDesignPie.TabIndex = 20;
            this.cmbDesignPie.SelectedIndexChanged += new System.EventHandler(this.cmbDesignPie_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "طرح:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "تغییر رنگ نقطه ها";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbxRotate
            // 
            this.cbxRotate.AutoSize = true;
            this.cbxRotate.Location = new System.Drawing.Point(54, 109);
            this.cbxRotate.Name = "cbxRotate";
            this.cbxRotate.Size = new System.Drawing.Size(59, 17);
            this.cbxRotate.TabIndex = 19;
            this.cbxRotate.Text = "چرخش";
            this.cbxRotate.UseVisualStyleBackColor = true;
            this.cbxRotate.CheckedChanged += new System.EventHandler(this.cbxRotate_CheckedChanged);
            // 
            // cmbExplodedPoint
            // 
            this.cmbExplodedPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExplodedPoint.FormattingEnabled = true;
            this.cmbExplodedPoint.Location = new System.Drawing.Point(6, 87);
            this.cmbExplodedPoint.Name = "cmbExplodedPoint";
            this.cmbExplodedPoint.Size = new System.Drawing.Size(107, 21);
            this.cmbExplodedPoint.TabIndex = 17;
            this.cmbExplodedPoint.SelectedIndexChanged += new System.EventHandler(this.cmbExplodedPoint_SelectedIndexChanged);
            // 
            // cmbLabelStyle
            // 
            this.cmbLabelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabelStyle.FormattingEnabled = true;
            this.cmbLabelStyle.Items.AddRange(new object[] {
            "داخل نمودار",
            "خارج نمودار",
            "غیر فعال"});
            this.cmbLabelStyle.Location = new System.Drawing.Point(6, 39);
            this.cmbLabelStyle.Name = "cmbLabelStyle";
            this.cmbLabelStyle.Size = new System.Drawing.Size(107, 21);
            this.cmbLabelStyle.TabIndex = 16;
            this.cmbLabelStyle.SelectedIndexChanged += new System.EventHandler(this.cmbLabelStyle_SelectedIndexChanged);
            // 
            // cmbTypePie
            // 
            this.cmbTypePie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypePie.FormattingEnabled = true;
            this.cmbTypePie.Items.AddRange(new object[] {
            "دایره تو پر",
            "دایره تو خالی"});
            this.cmbTypePie.Location = new System.Drawing.Point(6, 16);
            this.cmbTypePie.Name = "cmbTypePie";
            this.cmbTypePie.Size = new System.Drawing.Size(107, 21);
            this.cmbTypePie.TabIndex = 15;
            this.cmbTypePie.SelectedIndexChanged += new System.EventHandler(this.cmbTypePie_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "جدا کردن یک نقطه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "نوع نمایش لیبل ها:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "نوع نمودار:";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbxPoint
            // 
            this.gbxPoint.Controls.Add(this.button4);
            this.gbxPoint.Controls.Add(this.cmbSize);
            this.gbxPoint.Controls.Add(this.label11);
            this.gbxPoint.Controls.Add(this.label12);
            this.gbxPoint.Controls.Add(this.cmbShape);
            this.gbxPoint.Enabled = false;
            this.gbxPoint.Location = new System.Drawing.Point(859, 144);
            this.gbxPoint.Name = "gbxPoint";
            this.gbxPoint.Size = new System.Drawing.Size(235, 88);
            this.gbxPoint.TabIndex = 0;
            this.gbxPoint.TabStop = false;
            this.gbxPoint.Text = "تنظیمات نقطه ای";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 26);
            this.button4.TabIndex = 16;
            this.button4.Text = "رسم نقطه فشرده سریع";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "18"});
            this.cmbSize.Location = new System.Drawing.Point(9, 35);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(104, 21);
            this.cmbSize.TabIndex = 15;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "اندازه نقطه ها:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "شکل نقطه ها:";
            // 
            // cmbShape
            // 
            this.cmbShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Items.AddRange(new object[] {
            "مربع",
            "لوزی",
            "دایره"});
            this.cmbShape.Location = new System.Drawing.Point(9, 13);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(104, 21);
            this.cmbShape.TabIndex = 12;
            this.cmbShape.SelectedIndexChanged += new System.EventHandler(this.cmbShape_SelectedIndexChanged);
            // 
            // gbxPyramid
            // 
            this.gbxPyramid.Controls.Add(this.nudAnglePyramid);
            this.gbxPyramid.Controls.Add(this.nudPointPyramid);
            this.gbxPyramid.Controls.Add(this.cmbTypePyramid);
            this.gbxPyramid.Controls.Add(this.label13);
            this.gbxPyramid.Controls.Add(this.label14);
            this.gbxPyramid.Controls.Add(this.label15);
            this.gbxPyramid.Enabled = false;
            this.gbxPyramid.Location = new System.Drawing.Point(859, 276);
            this.gbxPyramid.Name = "gbxPyramid";
            this.gbxPyramid.Size = new System.Drawing.Size(235, 88);
            this.gbxPyramid.TabIndex = 16;
            this.gbxPyramid.TabStop = false;
            this.gbxPyramid.Text = "تنظیمات هرمی";
            // 
            // nudAnglePyramid
            // 
            this.nudAnglePyramid.Location = new System.Drawing.Point(9, 39);
            this.nudAnglePyramid.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAnglePyramid.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudAnglePyramid.Name = "nudAnglePyramid";
            this.nudAnglePyramid.Size = new System.Drawing.Size(104, 21);
            this.nudAnglePyramid.TabIndex = 19;
            this.nudAnglePyramid.ValueChanged += new System.EventHandler(this.nudAnglePyramid_ValueChanged);
            // 
            // nudPointPyramid
            // 
            this.nudPointPyramid.Location = new System.Drawing.Point(9, 15);
            this.nudPointPyramid.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPointPyramid.Name = "nudPointPyramid";
            this.nudPointPyramid.Size = new System.Drawing.Size(104, 21);
            this.nudPointPyramid.TabIndex = 20;
            this.nudPointPyramid.ValueChanged += new System.EventHandler(this.nudPointPyramid_ValueChanged);
            // 
            // cmbTypePyramid
            // 
            this.cmbTypePyramid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypePyramid.FormattingEnabled = true;
            this.cmbTypePyramid.Items.AddRange(new object[] {
            "خطوط مربعی",
            "خطوط دایره ای"});
            this.cmbTypePyramid.Location = new System.Drawing.Point(9, 63);
            this.cmbTypePyramid.Name = "cmbTypePyramid";
            this.cmbTypePyramid.Size = new System.Drawing.Size(104, 21);
            this.cmbTypePyramid.TabIndex = 18;
            this.cmbTypePyramid.SelectedIndexChanged += new System.EventHandler(this.cmbTypePyramid_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(194, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "زاویه:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(119, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "فاصله نقطه ها از هم:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(137, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "نوع نمایش خطوط:";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // gbxBar
            // 
            this.gbxBar.Controls.Add(this.button5);
            this.gbxBar.Enabled = false;
            this.gbxBar.Location = new System.Drawing.Point(859, 527);
            this.gbxBar.Name = "gbxBar";
            this.gbxBar.Size = new System.Drawing.Size(235, 50);
            this.gbxBar.TabIndex = 18;
            this.gbxBar.TabStop = false;
            this.gbxBar.Text = "تنظیمات میله ای";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "تنظیمات";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Location = new System.Drawing.Point(9, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 42);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "رسم با منابع مختلف داده ای";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(230, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "رسم با آرایه";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(381, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "رسم با فایل Excel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(532, 17);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "رسم با رسم با فایل xml";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(683, 17);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(145, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "رسم با دیتابیس";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 585);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxBar);
            this.Controls.Add(this.gbxPie);
            this.Controls.Add(this.gbxPyramid);
            this.Controls.Add(this.gbxPoint);
            this.Controls.Add(this.gbxLine);
            this.Controls.Add(this.gbxFunnel);
            this.Controls.Add(this.gbxAria);
            this.Controls.Add(this.gbxChart);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رسم نمودار";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAria.ResumeLayout(false);
            this.gbxAria.PerformLayout();
            this.gbxFunnel.ResumeLayout(false);
            this.gbxFunnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointGap)).EndInit();
            this.gbxLine.ResumeLayout(false);
            this.gbxLine.PerformLayout();
            this.gbxPie.ResumeLayout(false);
            this.gbxPie.PerformLayout();
            this.gbxPoint.ResumeLayout(false);
            this.gbxPoint.PerformLayout();
            this.gbxPyramid.ResumeLayout(false);
            this.gbxPyramid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnglePyramid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointPyramid)).EndInit();
            this.gbxBar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnAria;
        private System.Windows.Forms.RadioButton rbtnPyramid;
        private System.Windows.Forms.RadioButton rbtnPie;
        private System.Windows.Forms.RadioButton rbtnBar;
        private System.Windows.Forms.RadioButton rbtnLine;
        private System.Windows.Forms.RadioButton rbtnPoint;
        private System.Windows.Forms.RadioButton rbtnPrice;
        private System.Windows.Forms.RadioButton rbtnFunnel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbxChart;
        private System.Windows.Forms.GroupBox gbxAria;
        private System.Windows.Forms.ComboBox cmbTypeAria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbxFunnel;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.NumericUpDown nudPointGap;
        private System.Windows.Forms.ComboBox cmbchartStyleFunnel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxLine;
        private System.Windows.Forms.ComboBox cmbTypeLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxPie;
        private System.Windows.Forms.ComboBox cmbDesignPie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cbxRotate;
        private System.Windows.Forms.ComboBox cmbExplodedPoint;
        private System.Windows.Forms.ComboBox cmbLabelStyle;
        private System.Windows.Forms.ComboBox cmbTypePie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbxPoint;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.GroupBox gbxPyramid;
        private System.Windows.Forms.NumericUpDown nudAnglePyramid;
        private System.Windows.Forms.NumericUpDown nudPointPyramid;
        private System.Windows.Forms.ComboBox cmbTypePyramid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox cbx3D;
        private System.Windows.Forms.GroupBox gbxBar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

