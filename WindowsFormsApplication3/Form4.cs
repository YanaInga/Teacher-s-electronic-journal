using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        string nowopen;
        string nowname;
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            System.IO.FileInfo file = new System.IO.FileInfo("Groups.xml");
            if (file.Length > 5)
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Groups.xml");
                foreach (DataRow item in ds.Tables["Groups"].Rows)
                {
                    listBox1.Items.Add(item["GROUP"]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Groups";
            dt.Columns.Add("GROUP");
            dt.Columns.Add("PATH");
            ds.Tables.Add(dt);
            foreach (var item in listBox1.Items)
            {
                DataRow row = ds.Tables["Groups"].NewRow();
                row["GROUP"] = item;
                row["PATH"] = item + ".xls";
                ds.Tables["Groups"].Rows.Add(row);
            }
            ds.WriteXml("Groups.xml");
            System.IO.File.Create(textBox1.Text + ".xls");
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                this.dataGridView1.Rows.Clear();
                DataSet ds = new DataSet();
                ds.ReadXml("Groups.xml");
                foreach (DataRow item in ds.Tables["Groups"].Rows)
                {
                    if (listBox1.Items[index].ToString() == item["GROUP"].ToString())
                    {
                        Excel.Range xlRange;
                        int xlRow;
                        if (item["PATH"].ToString() != string.Empty)
                        {
                            xlApp = new Excel.Application();
                            xlWorkBook = xlApp.Workbooks.Open(System.IO.Directory.GetCurrentDirectory() + @"\" + item["PATH"].ToString());

                            xlWorkSheet = xlWorkBook.Worksheets[item["GROUP"].ToString()];
                            xlRange = xlWorkSheet.UsedRange;
                            int i = 0;
                            for (xlRow = 1; xlRow <= xlRange.Rows.Count; xlRow++)
                            {
                                i++;
                                dataGridView1.Rows.Add(xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text,
                                    xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text,
                                    xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text,
                                    xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text,
                                    xlRange.Cells[xlRow, 12].Text, xlRange.Cells[xlRow, 13].Text, xlRange.Cells[xlRow, 14].Text,
                                    xlRange.Cells[xlRow, 15].Text, xlRange.Cells[xlRow, 16].Text);
                            }
                            xlWorkBook.Close(true);
                        }
                        nowopen = item["PATH"].ToString();
                        nowname = item["GROUP"].ToString();
                        button2.Visible = true;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xlApp = new Excel.Application();
            xlWorkBook= xlApp.Workbooks.Add();
            xlWorkSheet = xlWorkBook.ActiveSheet;
            for (int i = 1; i < dataGridView1.RowCount + 1; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                {
                    xlWorkSheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            xlWorkSheet.Name = nowname;
            xlApp.DisplayAlerts = false;
            xlWorkBook.SaveAs(System.IO.Directory.GetCurrentDirectory() + @"\" + nowopen);
            xlWorkBook.Close(true);
            MessageBox.Show("сохранено");
        }
    }
}
