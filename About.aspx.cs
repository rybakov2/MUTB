using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace MUTB
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            txtRefDate.Text = "";

            string csvPath = Server.MapPath("~/Data/VT_Balance.csv");

            //Create a DataTable.
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[12] {
                new DataColumn("ref_date", typeof(string)), //DateTime
                new DataColumn("acct_id", typeof(string)), //int
                new DataColumn("acct_sn", typeof(string)),
                new DataColumn("ccy_cd", typeof(string)),
                new DataColumn("l_s_type",typeof(string)),
                new DataColumn("value_date",typeof(string)), //DateTime
                new DataColumn("opening_bal",typeof(string)), //decimal
                new DataColumn("closing_bal",typeof(string)), //decimal
                new DataColumn("inp_type",typeof(string)), //int
                new DataColumn("src_type",typeof(string)), //int
                new DataColumn("upd_userid",typeof(string)),
                new DataColumn("upd_datetime",typeof(string)) //DateTime
            });

            //Read the contents of CSV file.
            string csvData = File.ReadAllText(csvPath);

            bool headerRow = true;

            //Execute a loop over the rows.
            foreach (string row in csvData.Split('\n'))
            {
                if (headerRow == false)
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        dt.Rows.Add();
                        int i = 0;

                        //Execute a loop over the columns.
                        foreach (string cell in row.Split(','))
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = cell;
                            i++;
                        }
                    }
                }
                else
                {
                    headerRow = false;
                }
            }

            //Bind the DataTable.
            GridView1.DataSource = dt;
            GridView1.DataBind();
            
            lblOut.Text = "Loaded at "+ DateTime.Now.ToString();
        }
    }
}