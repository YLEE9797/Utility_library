namespace SJ_FNC
{
    partial class ModelForm
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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            comboBox4 = new ComboBox();
            label5 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1153, 81);
            label1.TabIndex = 0;
            label1.Text = "모델설정";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 630);
            button2.Name = "button2";
            button2.Size = new Size(387, 96);
            button2.TabIndex = 4;
            button2.Text = "모델추가";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGreen;
            button3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(393, 630);
            button3.Name = "button3";
            button3.Size = new Size(388, 96);
            button3.TabIndex = 5;
            button3.Text = "모델수정";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkRed;
            button4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(787, 630);
            button4.Name = "button4";
            button4.Size = new Size(355, 96);
            button4.TabIndex = 6;
            button4.Text = "모델삭제";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 124);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 7;
            label2.Text = "PartNo";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(107, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 38);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(107, 171);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 38);
            comboBox2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 187);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 11;
            label3.Text = "차종";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(107, 302);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(167, 38);
            comboBox3.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 318);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 15;
            label4.Text = "좌석";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(107, 239);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(167, 38);
            comboBox4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 255);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 13;
            label5.Text = "운전석 위치";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(830, 108);
            listView1.Name = "listView1";
            listView1.Size = new Size(312, 505);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PartNo";
            columnHeader2.Width = 200;
            // 
            // ModelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 728);
            Controls.Add(listView1);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ModelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModelForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox3;
        private Label label4;
        private ComboBox comboBox4;
        private Label label5;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}