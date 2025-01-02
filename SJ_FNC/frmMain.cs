using System.Runtime.CompilerServices;
using UtilityLib;
using UtilityLib.Util;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using ClassLibrary1;
using UtilityLib.DataProcess;

namespace SJ_FNC

{
    public partial class MainForm : Form
    {
        public static DataLoader DB=new DataLoader();
        public MainForm()
        {
            DB.CreateDB();
            InitializeComponent();
        }
       

        public void LoadChart()
        {

            Chart chart1 = new Chart();
            ChartArea chartArea = new ChartArea("ChartArea1");
            chart1.ChartAreas.Add(chartArea);
            Series series = new Series("Series1")
            {
                Points = {
                new DataPoint(0, 10),
                new DataPoint(1, 20),
                new DataPoint(2, 30),
                new DataPoint(3, 25),
                new DataPoint(4, 40)
            },
                ChartType = SeriesChartType.Line,  // �� �׷��� ����
                MarkerStyle = MarkerStyle.Circle,  // ����Ʈ ��Ÿ�� ���� (�� ���)
                MarkerSize = 10,  // ����Ʈ ũ�� ����
                MarkerColor = System.Drawing.Color.Red  // ����Ʈ ���� ����
            };

            chart1.Series.Add(series);
            chartArea.AxisX.Title = "t(�ð�)";  // X�� ����
            chartArea.AxisY.Title = "��(kgf)";   // Y�� ����
            // ��Ʈ ũ�� �� ��ġ ����
            chart1.Dock = DockStyle.Fill;
            panel1.Controls.Add(chart1);
        }
        public DataTable dt;
        public void CreateDataView()
        {
            dataGridView1.Rows.Clear();
            dt = new DataTable();
            dt.Columns.Add("��¥", typeof(string));
            dt.Columns.Add("�ð�", typeof(string));
            dt.Columns.Add("��", typeof(string));
            dt.Columns.Add("���", typeof(string));
            dt.Columns.Add("1����(kg/f)", typeof(string));
            dt.Columns.Add("1���� ����", typeof(string));
            dt.Columns.Add("2����(kg/f)", typeof(string));
            dt.Columns.Add("2���� ����", typeof(string));
            dt.Columns.Add("3����(kg/f)", typeof(string));
            dt.Columns.Add("3���� ����", typeof(string));
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;  // ��� �� ���� �Ұ�
            dataGridView1.AllowUserToAddRows = false;  // �� �� �߰� �Ұ�
            dataGridView1.ReadOnly = true;  // ���� �Ұ�
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public void AddNewRow(DataGridView dgv, params object[] values)
        {
            if (dgv.DataSource is BindingSource bindingSource && bindingSource.DataSource is DataTable dataTable)
            {
                DataRow newRow = dataTable.NewRow();

                for (int i = 0; i < values.Length && i < dataTable.Columns.Count; i++)
                {
                    newRow[i] = values[i];
                }

                dataTable.Rows.Add(newRow);
                bindingSource.ResetBindings(false);

                // ���� �߰��� �� ��Ÿ�� ����
                DataGridViewRow addedRow = dgv.Rows[dgv.Rows.Count - 1];

                foreach (DataGridViewCell cell in addedRow.Cells)
                {
                    if (cell.Value?.ToString() == "OK")
                    {
                        cell.Style.BackColor = Color.DarkGreen;
                        cell.Style.ForeColor = Color.White;
                    }
                    else if (cell.Value?.ToString() == "NG")
                    {
                        cell.Style.BackColor = Color.Red;
                        cell.Style.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                MessageBox.Show("��ȿ�� DataSource�� �����ϴ�.", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ListLog(string str)
        {
            listBox1.Items.Add(str);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListLog(DateTime.Now.ToString() + "->" + "���α׷� ����");
           
            CreateDataView();
            //LoadChart();
            if (pnIO.Visible)
            {
                pnIO.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!pnIO.Visible)
            {
                pnIO.Visible = true;
            }
            else
            {
                pnIO.Visible = false;

            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AddNewRow_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;

            dataGridView1.DataSource = bindingSource;
            AddNewRow(dataGridView1, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH:MM:ss"), "SV", "LHD_LH_IMS_VENT", 1.414, "OK", 3.15, "NG", 3.15, "NG");
        
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // "����" �÷�(��: ù ��° �÷�)�� �������� ��Ÿ���� ����
            if (dataGridView1.Columns[e.ColumnIndex].Name == "1���� ����") // �÷� �̸� Ȯ��
            {
                if (e.Value != null)
                {
                    string cellValue = e.Value.ToString();

                    if (cellValue == "OK")
                    {
                        e.CellStyle.BackColor = Color.DarkGreen;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (cellValue == "NG")
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.White; // �⺻ ��Ÿ��
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
            // "����" �÷�(��: ù ��° �÷�)�� �������� ��Ÿ���� ����
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "2���� ����") // �÷� �̸� Ȯ��
            {
                if (e.Value != null)
                {
                    string cellValue = e.Value.ToString();

                    if (cellValue == "OK")
                    {
                        e.CellStyle.BackColor = Color.DarkGreen;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (cellValue == "NG")
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.White; // �⺻ ��Ÿ��
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "3���� ����") // �÷� �̸� Ȯ��
            {
                if (e.Value != null)
                {
                    string cellValue = e.Value.ToString();

                    if (cellValue == "OK")
                    {
                        e.CellStyle.BackColor = Color.DarkGreen;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (cellValue == "NG")
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.White; // �⺻ ��Ÿ��
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
