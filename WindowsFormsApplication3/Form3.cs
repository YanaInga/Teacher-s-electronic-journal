using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        string nowopen;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            System.IO.FileInfo file = new System.IO.FileInfo("Plans.xml");
            if (file.Length > 5)
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Plans.xml");
                foreach (DataRow item in ds.Tables["Plans"].Rows)
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
            dt.TableName = "Plans";
            dt.Columns.Add("GROUP");
            dt.Columns.Add("PATH");
            ds.Tables.Add(dt);
            foreach (var item in listBox1.Items)
            {
                DataRow row = ds.Tables["Plans"].NewRow();
                row["GROUP"] = item;
                row["PATH"] = item + ".xml";
                ds.Tables["Plans"].Rows.Add(row);
            }
            ds.WriteXml("Plans.xml");
            System.IO.File.Create(textBox1.Text+".xml");
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                this.dataGridView1.Rows.Clear();
                DataSet ds = new DataSet();
                ds.ReadXml("Plans.xml");
                foreach (DataRow item in ds.Tables["Plans"].Rows)
                {
                    if (listBox1.Items[index].ToString() == item["GROUP"].ToString())
                    {
                        System.IO.FileInfo file = new System.IO.FileInfo(item["PATH"].ToString());
                        if (file.Length > 5)
                        {
                            DataSet ds1 = new DataSet();
                            ds1.ReadXml(item["PATH"].ToString());

                            foreach (DataRow item1 in ds1.Tables["GROUP"].Rows)
                            {
                                int n = dataGridView1.Rows.Add();
                                dataGridView1.Rows[n].Cells[0].Value = item1["Number"];
                                dataGridView1.Rows[n].Cells[1].Value = item1["Subject"];
                                dataGridView1.Rows[n].Cells[2].Value = item1["Annotation"];
                                dataGridView1.Rows[n].Cells[3].Value = item1["Control"];
                                dataGridView1.Rows[n].Cells[4].Value = item1["Mark"];
                            }
                        }
                        nowopen = item["PATH"].ToString();
                        button2.Visible = true;
                        break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "GROUP";
            dt.Columns.Add("Number");
            dt.Columns.Add("Subject");
            dt.Columns.Add("Annotation");
            dt.Columns.Add("Control");
            dt.Columns.Add("Mark");
            ds.Tables.Add(dt);
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                DataRow row = ds.Tables["GROUP"].NewRow();
                row["Number"] = r.Cells[0].Value;
                row["Subject"] = r.Cells[1].Value;
                row["Annotation"] = r.Cells[2].Value;
                row["Control"] = r.Cells[3].Value;
                row["Mark"] = r.Cells[4].Value;
                ds.Tables["GROUP"].Rows.Add(row);
            }
            ds.WriteXml(nowopen);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                this.button3.Enabled = true;
                this.button5.Enabled = true;
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox2.ForeColor = Color.Black;
                textBox3.ForeColor = Color.Black;
                textBox4.ForeColor = Color.Black;
                textBox5.ForeColor = Color.Black;
                textBox6.ForeColor = Color.Black;
            }
            else
            {
                this.button3.Enabled = false;
                this.button5.Enabled = false;
                textBox2.Clear();
                textBox2.Text = "Неделя";
                textBox2.ForeColor = Color.Gray;
                textBox3.Clear();
                textBox3.Text = "Вид занятий";
                textBox3.ForeColor = Color.Gray;
                textBox4.Clear();
                textBox4.Text = "Содержание занятий";
                textBox4.ForeColor = Color.Gray;
                textBox5.Clear();
                textBox5.Text = "Вид контроля";
                textBox5.ForeColor = Color.Gray;
                textBox6.Clear();
                textBox6.Text = "Баллы";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Неделя")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Неделя";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Вид занятий")
            {
                textBox3.Clear();
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "Вид занятий";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Содержание занятий")
            {
                textBox4.Clear();
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "Содержание занятий";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Вид контроля")
            {
                textBox5.Clear();
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "Вид контроля";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Баллы")
            {
                textBox6.Clear();
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = "Баллы";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Неделя" || textBox3.Text == "Вид занятий" ||
                textBox4.Text == "Содержание занятий" || textBox5.Text == "Вид контроля" || textBox6.Text == "Баллы")
            {
                MessageBox.Show("Заполните все поля.", "Ошибка.");
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox2.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBox3.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox4.Text;
                dataGridView1.Rows[n].Cells[3].Value = textBox5.Text;
                dataGridView1.Rows[n].Cells[4].Value = textBox6.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows[n].Cells[0].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox3.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox4.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBox5.Text;
            dataGridView1.Rows[n].Cells[4].Value = textBox6.Text;
            this.button3.Enabled = false;
            this.button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            this.button3.Enabled = false;
            this.button5.Enabled = false;
        }
    }
}
