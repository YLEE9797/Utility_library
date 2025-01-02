using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void btn_CsvSave_Click(object sender, EventArgs e)
        {
            FileStream = new FileStream(Application.StartupPath, FileMode.Create);
    
        }
    }
}
