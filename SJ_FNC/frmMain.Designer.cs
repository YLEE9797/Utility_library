namespace SJ_FNC
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_Req = new Button();
            btn_Exit = new Button();
            btn_set = new Button();
            btn_Search = new Button();
            panel3 = new Panel();
            pnIO = new Panel();
            label14 = new Label();
            btn_AddNewRow = new Button();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            lblState = new Label();
            label15 = new Label();
            label1 = new Label();
            btn_Log = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblMy = new Label();
            label18 = new Label();
            lblZigNo = new Label();
            label16 = new Label();
            lblType = new Label();
            lblModel = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label28 = new Label();
            lblMax = new Label();
            label27 = new Label();
            lblMin = new Label();
            label25 = new Label();
            lblSpec = new Label();
            label23 = new Label();
            lblSerial = new Label();
            label21 = new Label();
            lblPartNo = new Label();
            label17 = new Label();
            lblStatus = new Label();
            lblJug = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            pnIO.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.6211F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.3789005F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 167F));
            tableLayoutPanel1.Controls.Add(btn_Req, 3, 1);
            tableLayoutPanel1.Controls.Add(btn_Exit, 4, 0);
            tableLayoutPanel1.Controls.Add(btn_set, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_Search, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_Log, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1904, 136);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Req
            // 
            btn_Req.BackColor = Color.Teal;
            btn_Req.FlatStyle = FlatStyle.Flat;
            btn_Req.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Req.ForeColor = Color.White;
            btn_Req.Location = new Point(1545, 69);
            btn_Req.Margin = new Padding(0);
            btn_Req.Name = "btn_Req";
            btn_Req.Size = new Size(191, 67);
            btn_Req.TabIndex = 7;
            btn_Req.Text = "사양요청";
            btn_Req.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.Location = new Point(1736, 0);
            btn_Exit.Margin = new Padding(0);
            btn_Exit.Name = "btn_Exit";
            tableLayoutPanel1.SetRowSpan(btn_Exit, 2);
            btn_Exit.Size = new Size(168, 136);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "프로그램 종료";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_set
            // 
            btn_set.FlatStyle = FlatStyle.Flat;
            btn_set.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_set.Location = new Point(1346, 0);
            btn_set.Margin = new Padding(0);
            btn_set.Name = "btn_set";
            tableLayoutPanel1.SetRowSpan(btn_set, 2);
            btn_set.Size = new Size(199, 136);
            btn_set.TabIndex = 2;
            btn_set.Text = "환경설정";
            btn_set.UseVisualStyleBackColor = true;
            btn_set.Click += btn_set_Click;
            // 
            // btn_Search
            // 
            btn_Search.FlatStyle = FlatStyle.Flat;
            btn_Search.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Search.Location = new Point(1139, 0);
            btn_Search.Margin = new Padding(0);
            btn_Search.Name = "btn_Search";
            tableLayoutPanel1.SetRowSpan(btn_Search, 2);
            btn_Search.Size = new Size(207, 136);
            btn_Search.TabIndex = 1;
            btn_Search.Text = "데이터 조회";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pnIO);
            panel3.Controls.Add(tableLayoutPanel6);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            tableLayoutPanel1.SetRowSpan(panel3, 2);
            panel3.Size = new Size(1139, 136);
            panel3.TabIndex = 5;
            // 
            // pnIO
            // 
            pnIO.Controls.Add(label14);
            pnIO.Controls.Add(btn_AddNewRow);
            pnIO.Controls.Add(label12);
            pnIO.Controls.Add(label13);
            pnIO.Controls.Add(label11);
            pnIO.Controls.Add(label10);
            pnIO.Controls.Add(label9);
            pnIO.Controls.Add(label8);
            pnIO.Controls.Add(label7);
            pnIO.Controls.Add(label3);
            pnIO.Location = new Point(432, 12);
            pnIO.Name = "pnIO";
            pnIO.Size = new Size(772, 380);
            pnIO.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(238, 320);
            label14.Name = "label14";
            label14.Size = new Size(55, 15);
            label14.TabIndex = 9;
            label14.Text = "검사완료";
            // 
            // btn_AddNewRow
            // 
            btn_AddNewRow.Location = new Point(228, 32);
            btn_AddNewRow.Name = "btn_AddNewRow";
            btn_AddNewRow.Size = new Size(147, 43);
            btn_AddNewRow.TabIndex = 8;
            btn_AddNewRow.Text = "행 추가";
            btn_AddNewRow.UseVisualStyleBackColor = true;
            btn_AddNewRow.Click += btn_AddNewRow_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(95, 320);
            label12.Name = "label12";
            label12.Size = new Size(23, 15);
            label12.TabIndex = 7;
            label12.Text = "RH";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(95, 290);
            label13.Name = "label13";
            label13.Size = new Size(22, 15);
            label13.TabIndex = 6;
            label13.Text = "LH";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(90, 259);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 5;
            label11.Text = "RHD";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(87, 165);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 4;
            label10.Text = "모델3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(91, 228);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 3;
            label9.Text = "LHD";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 196);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 2;
            label8.Text = "검사 요청";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 133);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 1;
            label7.Text = "CT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 94);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 0;
            label3.Text = "SV";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(lblState, 0, 1);
            tableLayoutPanel6.Controls.Add(label15, 0, 0);
            tableLayoutPanel6.Location = new Point(969, -2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(168, 135);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // lblState
            // 
            lblState.BackColor = Color.DarkRed;
            lblState.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel6.SetColumnSpan(lblState, 2);
            lblState.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblState.ForeColor = Color.White;
            lblState.Location = new Point(0, 67);
            lblState.Margin = new Padding(0);
            lblState.Name = "lblState";
            lblState.Size = new Size(168, 68);
            lblState.TabIndex = 12;
            lblState.Text = "PLC";
            lblState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.ActiveCaption;
            label15.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel6.SetColumnSpan(label15, 2);
            label15.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(0, 0);
            label15.Margin = new Padding(0);
            label15.Name = "label15";
            label15.Size = new Size(168, 66);
            label15.TabIndex = 8;
            label15.Text = "상태확인";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, -1);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(966, 136);
            label1.TabIndex = 1;
            label1.Text = "SlideTester";
            label1.Click += label1_Click;
            // 
            // btn_Log
            // 
            btn_Log.BackColor = Color.Teal;
            btn_Log.FlatStyle = FlatStyle.Flat;
            btn_Log.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Log.ForeColor = Color.White;
            btn_Log.Location = new Point(1545, 0);
            btn_Log.Margin = new Padding(0);
            btn_Log.Name = "btn_Log";
            btn_Log.Size = new Size(191, 69);
            btn_Log.TabIndex = 6;
            btn_Log.Text = "LOG";
            btn_Log.UseVisualStyleBackColor = false;
            btn_Log.Click += btn_Log_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7699413F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.23006F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 712F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 136);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.618875F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90.38113F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 353F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1904, 905);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(164, 53);
            label2.TabIndex = 1;
            label2.Text = "차종";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 7;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 2);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.9333344F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.0666656F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 505F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 429F));
            tableLayoutPanel3.Controls.Add(lblMy, 6, 0);
            tableLayoutPanel3.Controls.Add(label18, 5, 0);
            tableLayoutPanel3.Controls.Add(lblZigNo, 4, 0);
            tableLayoutPanel3.Controls.Add(label16, 3, 0);
            tableLayoutPanel3.Controls.Add(lblType, 2, 0);
            tableLayoutPanel3.Controls.Add(lblModel, 0, 0);
            tableLayoutPanel3.Controls.Add(label4, 1, 0);
            tableLayoutPanel3.Location = new Point(164, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1740, 53);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // lblMy
            // 
            lblMy.BackColor = SystemColors.ActiveCaptionText;
            lblMy.BorderStyle = BorderStyle.FixedSingle;
            lblMy.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMy.ForeColor = Color.White;
            lblMy.Location = new Point(1310, 0);
            lblMy.Margin = new Padding(0);
            lblMy.Name = "lblMy";
            tableLayoutPanel3.SetRowSpan(lblMy, 2);
            lblMy.Size = new Size(430, 53);
            lblMy.TabIndex = 13;
            lblMy.Text = "-";
            lblMy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = SystemColors.ActiveCaption;
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(1097, 0);
            label18.Margin = new Padding(0);
            label18.Name = "label18";
            tableLayoutPanel3.SetRowSpan(label18, 2);
            label18.Size = new Size(213, 53);
            label18.TabIndex = 12;
            label18.Text = "연식";
            // 
            // lblZigNo
            // 
            lblZigNo.BackColor = SystemColors.ActiveCaptionText;
            lblZigNo.BorderStyle = BorderStyle.FixedSingle;
            lblZigNo.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblZigNo.ForeColor = Color.White;
            lblZigNo.Location = new Point(928, 0);
            lblZigNo.Margin = new Padding(0);
            lblZigNo.Name = "lblZigNo";
            tableLayoutPanel3.SetRowSpan(lblZigNo, 2);
            lblZigNo.Size = new Size(169, 53);
            lblZigNo.TabIndex = 11;
            lblZigNo.Text = "-";
            lblZigNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.ActiveCaption;
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(797, 0);
            label16.Margin = new Padding(0);
            label16.Name = "label16";
            tableLayoutPanel3.SetRowSpan(label16, 2);
            label16.Size = new Size(131, 53);
            label16.TabIndex = 10;
            label16.Text = "지그";
            // 
            // lblType
            // 
            lblType.BackColor = SystemColors.ActiveCaptionText;
            lblType.BorderStyle = BorderStyle.FixedSingle;
            lblType.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.ForeColor = Color.White;
            lblType.Location = new Point(292, 0);
            lblType.Margin = new Padding(0);
            lblType.Name = "lblType";
            tableLayoutPanel3.SetRowSpan(lblType, 2);
            lblType.Size = new Size(505, 53);
            lblType.TabIndex = 9;
            lblType.Text = "-";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            lblType.Click += label6_Click;
            // 
            // lblModel
            // 
            lblModel.BackColor = SystemColors.ActiveCaptionText;
            lblModel.BorderStyle = BorderStyle.FixedSingle;
            lblModel.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblModel.ForeColor = Color.White;
            lblModel.Location = new Point(0, 0);
            lblModel.Margin = new Padding(0);
            lblModel.Name = "lblModel";
            tableLayoutPanel3.SetRowSpan(lblModel, 2);
            lblModel.Size = new Size(131, 53);
            lblModel.TabIndex = 8;
            lblModel.Text = "-";
            lblModel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(131, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            tableLayoutPanel3.SetRowSpan(label4, 2);
            label4.Size = new Size(161, 53);
            label4.TabIndex = 7;
            label4.Text = "사양";
            // 
            // panel1
            // 
            tableLayoutPanel2.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(label28);
            panel1.Controls.Add(lblMax);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(lblMin);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(lblSpec);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(lblSerial);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(lblPartNo);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblJug);
            panel1.Controls.Add(chart1);
            panel1.Location = new Point(0, 53);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 498);
            panel1.TabIndex = 7;
            // 
            // label28
            // 
            label28.BackColor = Color.DarkSlateGray;
            label28.BorderStyle = BorderStyle.FixedSingle;
            label28.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.White;
            label28.Location = new Point(0, 1);
            label28.Margin = new Padding(0);
            label28.Name = "label28";
            label28.Size = new Size(775, 60);
            label28.TabIndex = 15;
            label28.Text = "레버해제력";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            lblMax.BackColor = Color.White;
            lblMax.BorderStyle = BorderStyle.FixedSingle;
            lblMax.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMax.ForeColor = Color.Black;
            lblMax.Location = new Point(568, 338);
            lblMax.Margin = new Padding(0);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(207, 60);
            lblMax.TabIndex = 14;
            lblMax.Text = "-";
            lblMax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            label27.BackColor = Color.DarkSlateGray;
            label27.BorderStyle = BorderStyle.FixedSingle;
            label27.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.White;
            label27.Location = new Point(388, 338);
            label27.Margin = new Padding(0);
            label27.Name = "label27";
            label27.Size = new Size(180, 60);
            label27.TabIndex = 13;
            label27.Text = "최대값";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            lblMin.BackColor = Color.White;
            lblMin.BorderStyle = BorderStyle.FixedSingle;
            lblMin.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMin.ForeColor = Color.Black;
            lblMin.Location = new Point(200, 338);
            lblMin.Margin = new Padding(0);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(188, 60);
            lblMin.TabIndex = 12;
            lblMin.Text = "-";
            lblMin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.BackColor = Color.DarkSlateGray;
            label25.BorderStyle = BorderStyle.FixedSingle;
            label25.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.White;
            label25.Location = new Point(0, 338);
            label25.Margin = new Padding(0);
            label25.Name = "label25";
            label25.Size = new Size(200, 60);
            label25.TabIndex = 11;
            label25.Text = "최소값";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSpec
            // 
            lblSpec.BackColor = Color.White;
            lblSpec.BorderStyle = BorderStyle.FixedSingle;
            lblSpec.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpec.ForeColor = Color.Black;
            lblSpec.Location = new Point(268, 278);
            lblSpec.Margin = new Padding(0);
            lblSpec.Name = "lblSpec";
            lblSpec.Size = new Size(507, 60);
            lblSpec.TabIndex = 10;
            lblSpec.Text = "-";
            lblSpec.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.BackColor = Color.DarkSlateGray;
            label23.BorderStyle = BorderStyle.FixedSingle;
            label23.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(0, 278);
            label23.Margin = new Padding(0);
            label23.Name = "label23";
            label23.Size = new Size(268, 60);
            label23.TabIndex = 9;
            label23.Text = "스펙";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSerial
            // 
            lblSerial.BackColor = Color.White;
            lblSerial.BorderStyle = BorderStyle.FixedSingle;
            lblSerial.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSerial.ForeColor = Color.Black;
            lblSerial.Location = new Point(268, 218);
            lblSerial.Margin = new Padding(0);
            lblSerial.Name = "lblSerial";
            lblSerial.Size = new Size(507, 60);
            lblSerial.TabIndex = 8;
            lblSerial.Text = "-";
            lblSerial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.BackColor = Color.DarkSlateGray;
            label21.BorderStyle = BorderStyle.FixedSingle;
            label21.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(0, 218);
            label21.Margin = new Padding(0);
            label21.Name = "label21";
            label21.Size = new Size(268, 60);
            label21.TabIndex = 7;
            label21.Text = "시리얼";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPartNo
            // 
            lblPartNo.BackColor = Color.White;
            lblPartNo.BorderStyle = BorderStyle.FixedSingle;
            lblPartNo.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPartNo.ForeColor = Color.Black;
            lblPartNo.Location = new Point(268, 158);
            lblPartNo.Margin = new Padding(0);
            lblPartNo.Name = "lblPartNo";
            lblPartNo.Size = new Size(507, 60);
            lblPartNo.TabIndex = 6;
            lblPartNo.Text = "-";
            lblPartNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.BackColor = Color.DarkSlateGray;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(0, 158);
            label17.Margin = new Padding(0);
            label17.Name = "label17";
            label17.Size = new Size(268, 60);
            label17.TabIndex = 5;
            label17.Text = "품번";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.White;
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(268, 61);
            lblStatus.Margin = new Padding(0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(507, 97);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "대기중";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJug
            // 
            lblJug.BackColor = Color.DarkGreen;
            lblJug.BorderStyle = BorderStyle.FixedSingle;
            lblJug.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblJug.ForeColor = Color.White;
            lblJug.Location = new Point(0, 61);
            lblJug.Margin = new Padding(0);
            lblJug.Name = "lblJug";
            lblJug.Size = new Size(268, 97);
            lblJug.TabIndex = 3;
            lblJug.Text = "OK";
            lblJug.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(778, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "kgf/m";
            series1.Name = "chart1";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            chart1.Series.Add(series1);
            chart1.Size = new Size(1126, 498);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dataGridView1, 3);
            dataGridView1.Location = new Point(3, 554);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1898, 348);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnIO.ResumeLayout(false);
            pnIO.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_set;
        private Button btn_Search;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblType;
        private Label lblModel;
        private Label label4;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel pnIO;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label12;
        private Label label13;
        private Button btn_Exit;
        private Panel panel3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label15;
        private Label lblState;
        private Button btn_AddNewRow;
        private Label label14;
        private Label lblMy;
        private Label label18;
        private Label lblZigNo;
        private Label label16;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label lblJug;
        private Label lblStatus;
        private Label lblSerial;
        private Label label21;
        private Label lblPartNo;
        private Label label17;
        private Label lblMax;
        private Label label27;
        private Label lblMin;
        private Label label25;
        private Label lblSpec;
        private Label label23;
        private Label label28;
        private Button btn_Req;
        private Button btn_Log;
    }
}
