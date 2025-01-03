namespace SJ_FNC
{
    partial class SearchForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_CsvSave = new Button();
            btn_Search = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            tbPartNo = new TextBox();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            dgvSearch = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.6533661F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.346633F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 198F));
            tableLayoutPanel1.Controls.Add(btn_CsvSave, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_Search, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvSearch, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1825171F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.81748F));
            tableLayoutPanel1.Size = new Size(1904, 1041);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_CsvSave
            // 
            btn_CsvSave.BackColor = SystemColors.ButtonShadow;
            btn_CsvSave.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CsvSave.ForeColor = SystemColors.ButtonFace;
            btn_CsvSave.Location = new Point(1708, 3);
            btn_CsvSave.Name = "btn_CsvSave";
            btn_CsvSave.Size = new Size(193, 100);
            btn_CsvSave.TabIndex = 2;
            btn_CsvSave.Text = "CSV 저장";
            btn_CsvSave.UseVisualStyleBackColor = false;
            btn_CsvSave.Click += btn_CsvSave_Click;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = SystemColors.ButtonShadow;
            btn_Search.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Search.ForeColor = SystemColors.ButtonFace;
            btn_Search.Location = new Point(1515, 3);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(187, 100);
            btn_Search.TabIndex = 0;
            btn_Search.Text = "데이터 조회";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbPartNo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1506, 100);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(723, 33);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 7;
            label3.Text = "품번 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 32);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 6;
            label2.Text = "검색기간 :";
            // 
            // tbPartNo
            // 
            tbPartNo.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbPartNo.Location = new Point(781, 30);
            tbPartNo.Name = "tbPartNo";
            tbPartNo.Size = new Size(330, 35);
            tbPartNo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 38);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 4;
            label1.Text = "-";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(383, 32);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(121, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(1173, 58);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(43, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "NG";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1173, 23);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(42, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "OK";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dgvSearch
            // 
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvSearch, 3);
            dgvSearch.Location = new Point(3, 109);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.RowTemplate.Height = 25;
            dgvSearch.Size = new Size(1898, 929);
            dgvSearch.TabIndex = 4;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tableLayoutPanel1);
            Name = "SearchForm";
            Text = "데이터 조회";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_CsvSave;
        private Button btn_Search;
        private Panel panel1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label2;
        private TextBox tbPartNo;
        private Label label3;
        private DataGridView dgvSearch;
    }
}