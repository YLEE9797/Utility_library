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
                ChartType = SeriesChartType.Line,  // 선 그래프 설정
                MarkerStyle = MarkerStyle.Circle,  // 포인트 스타일 설정 (원 모양)
                MarkerSize = 10,  // 포인트 크기 설정
                MarkerColor = System.Drawing.Color.Red  // 포인트 색상 설정
            };

            chart1.Series.Add(series);
            chartArea.AxisX.Title = "t(시간)";  // X축 제목
            chartArea.AxisY.Title = "힘(kgf)";   // Y축 제목
            // 차트 크기 및 위치 설정
            chart1.Dock = DockStyle.Fill;
            panel1.Controls.Add(chart1);
        }
        public DataTable dt;
        public void CreateDataView()
        {
            dataGridView1.Rows.Clear();
            dt = new DataTable();
            dt.Columns.Add("날짜", typeof(string));
            dt.Columns.Add("시간", typeof(string));
            dt.Columns.Add("모델", typeof(string));
            dt.Columns.Add("사양", typeof(string));
            dt.Columns.Add("1구간(kg/f)", typeof(string));
            dt.Columns.Add("1구간 판정", typeof(string));
            dt.Columns.Add("2구간(kg/f)", typeof(string));
            dt.Columns.Add("2구간 판정", typeof(string));
            dt.Columns.Add("3구간(kg/f)", typeof(string));
            dt.Columns.Add("3구간 판정", typeof(string));
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;  // 모든 셀 편집 불가
            dataGridView1.AllowUserToAddRows = false;  // 새 행 추가 불가
            dataGridView1.ReadOnly = true;  // 편집 불가
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

                // 새로 추가된 행 스타일 설정
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
                MessageBox.Show("유효한 DataSource가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ListLog(string str)
        {
            listBox1.Items.Add(str);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListLog(DateTime.Now.ToString() + "->" + "프로그램 시작");
           
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
            // "상태" 컬럼(예: 첫 번째 컬럼)을 기준으로 스타일을 적용
            if (dataGridView1.Columns[e.ColumnIndex].Name == "1구간 판정") // 컬럼 이름 확인
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
                        e.CellStyle.BackColor = Color.White; // 기본 스타일
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
            // "상태" 컬럼(예: 첫 번째 컬럼)을 기준으로 스타일을 적용
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "2구간 판정") // 컬럼 이름 확인
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
                        e.CellStyle.BackColor = Color.White; // 기본 스타일
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "3구간 판정") // 컬럼 이름 확인
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
                        e.CellStyle.BackColor = Color.White; // 기본 스타일
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
