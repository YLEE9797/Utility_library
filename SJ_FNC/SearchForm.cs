using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib.DataProcess;

namespace SJ_FNC
{
    public partial class SearchForm : Form
    {
        public FileStream FileStream;

        public SearchForm()
        {
            InitializeComponent();
        }
        List<string> DataList = new List<string>();
        DataLoader DataLoader = new DataLoader();
        DataTable DT = new DataTable();
        private void btn_CsvSave_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string query = "select * from tb_Data1";
            DT = DataLoader.Search(query,out DT);
            try
            {
                DT.Columns[0].ColumnName = "날짜";
                DT.Columns[1].ColumnName = "모델";
                DT.Columns[2].ColumnName = "품번";
                DT.Columns[3].ColumnName = "1구간";
                DT.Columns[4].ColumnName = "1구간 판정";
                DT.Columns[5].ColumnName = "2구간";
                DT.Columns[6].ColumnName = "2구간 판정";
                DT.Columns[7].ColumnName = "3구간";
                DT.Columns[8].ColumnName = "3구간 판정";

                dgvSearch.DataSource = DT;
                dgvSearch.Columns[0].Width = 200;
                dgvSearch.Columns[2].Width = 300;
                dgvSearch.Columns[3].Width = 150;
                dgvSearch.Columns[5].Width = 150;
                dgvSearch.Columns[7].Width = 150;
                dgvSearch.ReadOnly = true;

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            
        }
    }
}
