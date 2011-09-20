using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace driver
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name",typeof(string));
            dt.Columns.Add("value",typeof(string));

            DataRow dr = dt.NewRow();
            dr["name"] = "[var]";
            dr["value"] = "3";

            dt.Rows.Add(dr);

            xBuilder1.DataSource = dt;
        }

        private void xBuilder1_Load(object sender, EventArgs e)
        {

        }
    }
}
