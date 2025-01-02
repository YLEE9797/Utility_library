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
            btn_Exit = new Button();
            btn_Model = new Button();
            btn_set = new Button();
            btn_Search = new Button();
            panel3 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            lblState = new Label();
            label15 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
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
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            pnIO.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(btn_Exit, 4, 0);
            tableLayoutPanel1.Controls.Add(btn_Model, 3, 0);
            tableLayoutPanel1.Controls.Add(btn_set, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_Search, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1904, 136);
            tableLayoutPanel1.TabIndex = 0;
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
            // btn_Model
            // 
            btn_Model.FlatStyle = FlatStyle.Flat;
            btn_Model.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Model.Location = new Point(1545, 0);
            btn_Model.Margin = new Padding(0);
            btn_Model.Name = "btn_Model";
            tableLayoutPanel1.SetRowSpan(btn_Model, 2);
            btn_Model.Size = new Size(191, 136);
            btn_Model.TabIndex = 3;
            btn_Model.Text = "모델설정";
            btn_Model.UseVisualStyleBackColor = true;
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
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel6);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            tableLayoutPanel1.SetRowSpan(panel3, 2);
            panel3.Size = new Size(1139, 136);
            panel3.TabIndex = 5;
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
            tableLayoutPanel2.Controls.Add(listBox1, 2, 2);
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
            label2.Text = "모델";
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
            tableLayoutPanel3.Controls.Add(label19, 6, 0);
            tableLayoutPanel3.Controls.Add(label18, 5, 0);
            tableLayoutPanel3.Controls.Add(label17, 4, 0);
            tableLayoutPanel3.Controls.Add(label16, 3, 0);
            tableLayoutPanel3.Controls.Add(label6, 2, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
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
            // label19
            // 
            label19.BackColor = SystemColors.ActiveCaptionText;
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(1310, 0);
            label19.Margin = new Padding(0);
            label19.Name = "label19";
            tableLayoutPanel3.SetRowSpan(label19, 2);
            label19.Size = new Size(430, 53);
            label19.TabIndex = 13;
            label19.Text = "-";
            label19.TextAlign = ContentAlignment.MiddleCenter;
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
            // label17
            // 
            label17.BackColor = SystemColors.ActiveCaptionText;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(928, 0);
            label17.Margin = new Padding(0);
            label17.Name = "label17";
            tableLayoutPanel3.SetRowSpan(label17, 2);
            label17.Size = new Size(169, 53);
            label17.TabIndex = 11;
            label17.Text = "-";
            label17.TextAlign = ContentAlignment.MiddleCenter;
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
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(292, 0);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            tableLayoutPanel3.SetRowSpan(label6, 2);
            label6.Size = new Size(505, 53);
            label6.TabIndex = 9;
            label6.Text = "-";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            tableLayoutPanel3.SetRowSpan(label5, 2);
            label5.Size = new Size(131, 53);
            label5.TabIndex = 8;
            label5.Text = "-";
            label5.TextAlign = ContentAlignment.TopCenter;
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
            panel1.Controls.Add(pnIO);
            panel1.Controls.Add(chart1);
            panel1.Location = new Point(0, 53);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 498);
            panel1.TabIndex = 7;
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
            pnIO.Location = new Point(271, 62);
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "kgf/m";
            series1.Name = "chart1";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            chart1.Series.Add(series1);
            chart1.Size = new Size(1904, 498);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Location = new Point(3, 554);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1185, 348);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(1191, 551);
            listBox1.Margin = new Padding(0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(713, 349);
            listBox1.TabIndex = 9;
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
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnIO.ResumeLayout(false);
            pnIO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_Model;
        private Button btn_set;
        private Button btn_Search;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private DataGridView dataGridView1;
        private ListBox listBox1;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
    }
}
