using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "№ ленты" || textBox6.Text == "Предмет" || textBox7.Text == "Аудитория")
            {
                MessageBox.Show("Заполните все поля.", "Ошибка.");
            }
            else
            {
                if (comboBox1.Text == "Понедельник")
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = textBox5.Text;
                    dataGridView1.Rows[n].Cells[1].Value = textBox8.Text;
                    dataGridView1.Rows[n].Cells[2].Value = textBox9.Text;
                    this.button3.Enabled = false;
                    this.button4.Enabled = false;

                }
                else if (comboBox1.Text == "Вторник")
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = textBox5.Text;
                    dataGridView2.Rows[n].Cells[1].Value = textBox8.Text;
                    dataGridView2.Rows[n].Cells[2].Value = textBox9.Text;
                    this.button3.Enabled = false;
                    this.button4.Enabled = false;
                }
                else if (comboBox1.Text == "Среда")
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = textBox5.Text;
                    dataGridView3.Rows[n].Cells[1].Value = textBox8.Text;
                    dataGridView3.Rows[n].Cells[2].Value = textBox9.Text;
                    this.button3.Enabled = false;
                    this.button4.Enabled = false;
                }
                else if (comboBox1.Text == "Четверг")
                {
                    int n = dataGridView4.Rows.Add();
                    dataGridView4.Rows[n].Cells[0].Value = textBox5.Text;
                    dataGridView4.Rows[n].Cells[1].Value = textBox8.Text;
                    dataGridView4.Rows[n].Cells[2].Value = textBox9.Text;
                    this.button3.Enabled = false;
                    this.button4.Enabled = false;
                }
                else if (comboBox1.Text == "Пятница")
                {
                    int n = dataGridView5.Rows.Add();
                    dataGridView5.Rows[n].Cells[0].Value = textBox5.Text;
                    dataGridView5.Rows[n].Cells[1].Value = textBox8.Text;
                    dataGridView5.Rows[n].Cells[2].Value = textBox9.Text;
                    this.button3.Enabled = false;
                    this.button4.Enabled = false;
                }
                else if (comboBox1.Text == "Суббота")
                {
                    int n = dataGridView6.Rows.Add();
                    dataGridView6.Rows[n].Cells[0].Value = textBox5.Text;
                    dataGridView6.Rows[n].Cells[1].Value = textBox8.Text;
                    dataGridView6.Rows[n].Cells[2].Value = textBox9.Text;
                    this.button3.Enabled = false;
                    this.button4.Enabled = false;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 1;
                while (i <= 7)
                {
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    dt.TableName = "Timetable";
                    dt.Columns.Add("Number");
                    dt.Columns.Add("Subject");
                    dt.Columns.Add("Room");
                    ds.Tables.Add(dt);
                    switch (i)
                    {
                        case 1:
                            if (dataGridView1.Rows.Count > 1)
                            {
                                foreach (DataGridViewRow r in dataGridView1.Rows)
                                {
                                    DataRow row = ds.Tables["Timetable"].NewRow();
                                    row["Number"] = r.Cells[0].Value;
                                    row["Subject"] = r.Cells[1].Value; 
                                    row["Room"] = r.Cells[2].Value;
                                    ds.Tables["Timetable"].Rows.Add(row); 
                                }

                                ds.WriteXml("Monday.xml");
                            }
                            break;
                        case 2:
                            if (dataGridView2.Rows.Count > 1)
                            {
                                foreach (DataGridViewRow r in dataGridView2.Rows)
                                {
                                    DataRow row = ds.Tables["Timetable"].NewRow();
                                    row["Number"] = r.Cells[0].Value; 
                                    row["Subject"] = r.Cells[1].Value; 
                                    row["Room"] = r.Cells[2].Value; 
                                    ds.Tables["Timetable"].Rows.Add(row);
                                }

                                ds.WriteXml("Tuesday.xml");
                            }
                            break;
                        case 3:
                            if (dataGridView3.Rows.Count > 1)
                            {
                                foreach (DataGridViewRow r in dataGridView3.Rows) 
                                {
                                    DataRow row = ds.Tables["Timetable"].NewRow();
                                    row["Number"] = r.Cells[0].Value;
                                    row["Subject"] = r.Cells[1].Value; 
                                    row["Room"] = r.Cells[2].Value; 
                                    ds.Tables["Timetable"].Rows.Add(row);
                                }

                                ds.WriteXml("Wednesday.xml");
                            }
                            break;
                        case 4:
                            if (dataGridView4.Rows.Count > 1)
                            {
                                foreach (DataGridViewRow r in dataGridView4.Rows)
                                {
                                    DataRow row = ds.Tables["Timetable"].NewRow();
                                    row["Number"] = r.Cells[0].Value; 
                                    row["Subject"] = r.Cells[1].Value; 
                                    row["Room"] = r.Cells[2].Value; 
                                    ds.Tables["Timetable"].Rows.Add(row);
                                }

                                ds.WriteXml("Thursday.xml");
                            }
                            break;
                        case 5:
                            if (dataGridView5.Rows.Count > 1)
                            {
                                foreach (DataGridViewRow r in dataGridView5.Rows)
                                {
                                    DataRow row = ds.Tables["Timetable"].NewRow();
                                    row["Number"] = r.Cells[0].Value;
                                    row["Subject"] = r.Cells[1].Value;
                                    row["Room"] = r.Cells[2].Value;
                                    ds.Tables["Timetable"].Rows.Add(row);
                                }

                                ds.WriteXml("Friday.xml");
                            }
                            break;
                        case 6:
                            if (dataGridView6.Rows.Count > 1)
                            {
                                foreach (DataGridViewRow r in dataGridView6.Rows)
                                {
                                    DataRow row = ds.Tables["Timetable"].NewRow(); 
                                    row["Number"] = r.Cells[0].Value;
                                    row["Subject"] = r.Cells[1].Value; 
                                    row["Room"] = r.Cells[2].Value; 
                                    ds.Tables["Timetable"].Rows.Add(row); 
                                }

                                ds.WriteXml("Saturday.xml");
                            }
                            break;
                    }
                    i++;
                }
                MessageBox.Show("Изменения успешно сохранены.");
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить данные", "Ошибка.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 7)
            {
                switch (i)
                {
                    case 1:
                        {
                            System.IO.FileInfo file = new System.IO.FileInfo("Monday.xml");
                            if (file.Length > 5)
                            {
                                DataSet ds = new DataSet();
                                ds.ReadXml("Monday.xml");

                                foreach (DataRow item in ds.Tables["Timetable"].Rows)
                                {
                                    int n = dataGridView1.Rows.Add();
                                    dataGridView1.Rows[n].Cells[0].Value = item["Number"];
                                    dataGridView1.Rows[n].Cells[1].Value = item["Subject"];
                                    dataGridView1.Rows[n].Cells[2].Value = item["Room"];
                                }
                            }
                        }
                        break;
                    case 2:
                        {
                            System.IO.FileInfo file = new System.IO.FileInfo("Tuesday.xml");
                            if (file.Length > 5)
                            {
                                DataSet ds = new DataSet();
                                ds.ReadXml("Tuesday.xml");

                                foreach (DataRow item in ds.Tables["Timetable"].Rows)
                                {
                                    int n = dataGridView2.Rows.Add();
                                    dataGridView2.Rows[n].Cells[0].Value = item["Number"];
                                    dataGridView2.Rows[n].Cells[1].Value = item["Subject"];
                                    dataGridView2.Rows[n].Cells[2].Value = item["Room"];
                                }
                            }
                        }
                        break;
                    case 3:
                        {
                            System.IO.FileInfo file = new System.IO.FileInfo("Wednesday.xml");
                            if (file.Length > 5)
                            {
                                DataSet ds = new DataSet();
                                ds.ReadXml("Wednesday.xml");

                                foreach (DataRow item in ds.Tables["Timetable"].Rows)
                                {
                                    int n = dataGridView3.Rows.Add();
                                    dataGridView3.Rows[n].Cells[0].Value = item["Number"];
                                    dataGridView3.Rows[n].Cells[1].Value = item["Subject"];
                                    dataGridView3.Rows[n].Cells[2].Value = item["Room"];
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            System.IO.FileInfo file = new System.IO.FileInfo("Thursday.xml");
                            if (file.Length > 5)
                            {
                                DataSet ds = new DataSet();
                                ds.ReadXml("Thursday.xml");

                                foreach (DataRow item in ds.Tables["Timetable"].Rows)
                                {
                                    int n = dataGridView4.Rows.Add();
                                    dataGridView4.Rows[n].Cells[0].Value = item["Number"];
                                    dataGridView4.Rows[n].Cells[1].Value = item["Subject"];
                                    dataGridView4.Rows[n].Cells[2].Value = item["Room"];
                                }
                            }
                        }
                        break;
                    case 5:
                        {
                            System.IO.FileInfo file = new System.IO.FileInfo("Friday.xml");
                            if (file.Length > 5)
                            {
                                DataSet ds = new DataSet();
                                ds.ReadXml("Friday.xml");

                                foreach (DataRow item in ds.Tables["Timetable"].Rows)
                                {
                                    int n = dataGridView5.Rows.Add();
                                    dataGridView5.Rows[n].Cells[0].Value = item["Number"];
                                    dataGridView5.Rows[n].Cells[1].Value = item["Subject"];
                                    dataGridView5.Rows[n].Cells[2].Value = item["Room"];
                                }
                            }
                        }
                        break;
                    case 6:
                        {
                            System.IO.FileInfo file = new System.IO.FileInfo("Saturday.xml");
                            if (file.Length > 5)
                            {
                                DataSet ds = new DataSet();
                                ds.ReadXml("Saturday.xml");

                                foreach (DataRow item in ds.Tables["Timetable"].Rows)
                                {
                                    int n = dataGridView6.Rows.Add();
                                    dataGridView6.Rows[n].Cells[0].Value = item["Number"];
                                    dataGridView6.Rows[n].Cells[1].Value = item["Subject"];
                                    dataGridView6.Rows[n].Cells[2].Value = item["Room"];
                                }
                            }
                        }
                        break;
                }
                i++;
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                this.button3.Enabled = true;
                this.button4.Enabled = true;
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox8.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox9.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox5.ForeColor = Color.Black;
                textBox8.ForeColor = Color.Black;
                textBox9.ForeColor = Color.Black;
            }
            else
            {
                printgray();
            }
        }
        
        private void button3_Click(object sender, EventArgs e) //изменить ленту
        {
            if (comboBox1.Text == "Понедельник")
            {
                int n = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows[n].Cells[0].Value = textBox5.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBox8.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox9.Text;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

            }
            else if (comboBox1.Text == "Вторник")
            {
                int n = dataGridView2.SelectedRows[0].Index;
                dataGridView2.Rows[n].Cells[0].Value = textBox5.Text;
                dataGridView2.Rows[n].Cells[1].Value = textBox8.Text;
                dataGridView2.Rows[n].Cells[2].Value = textBox9.Text;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
            }
            else if (comboBox1.Text == "Среда")
            {
                int n = dataGridView3.SelectedRows[0].Index;
                dataGridView3.Rows[n].Cells[0].Value = textBox5.Text;
                dataGridView3.Rows[n].Cells[1].Value = textBox8.Text;
                dataGridView3.Rows[n].Cells[2].Value = textBox9.Text;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
            }
            else if (comboBox1.Text == "Четверг")
            {
                int n = dataGridView4.SelectedRows[0].Index;
                dataGridView4.Rows[n].Cells[0].Value = textBox5.Text;
                dataGridView4.Rows[n].Cells[1].Value = textBox8.Text;
                dataGridView4.Rows[n].Cells[2].Value = textBox9.Text;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
            }
            else if (comboBox1.Text == "Пятница")
            {
                int n = dataGridView5.SelectedRows[0].Index;
                dataGridView5.Rows[n].Cells[0].Value = textBox5.Text;
                dataGridView5.Rows[n].Cells[1].Value = textBox8.Text;
                dataGridView5.Rows[n].Cells[2].Value = textBox9.Text;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
            }
            else if (comboBox1.Text == "Суббота")
            {
                int n = dataGridView6.SelectedRows[0].Index;
                dataGridView6.Rows[n].Cells[0].Value = textBox5.Text;
                dataGridView6.Rows[n].Cells[1].Value = textBox8.Text;
                dataGridView6.Rows[n].Cells[2].Value = textBox9.Text;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
            }
    }
        private void printgray()
        {
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            textBox5.Clear();
            textBox5.Text = "№ ленты";
            textBox5.ForeColor = Color.Gray;
            textBox8.Clear();
            textBox8.Text = "Предмет";
            textBox8.ForeColor = Color.Gray;
            textBox9.Clear();
            textBox9.Text = "Аудитория";
            textBox9.ForeColor = Color.Gray;
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                this.button3.Enabled = true;
                this.button4.Enabled = true;
                textBox5.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                textBox8.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox9.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                textBox5.ForeColor = Color.Black;
                textBox8.ForeColor = Color.Black;
                textBox9.ForeColor = Color.Black;
            }
            else
            {
                printgray();
            }
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                this.button3.Enabled = true;
                this.button4.Enabled = true;
                textBox5.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                textBox8.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                textBox9.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                textBox5.ForeColor = Color.Black;
                textBox8.ForeColor = Color.Black;
                textBox9.ForeColor = Color.Black;
            }
            else
            {
                printgray();
            }
        }

        private void dataGridView4_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                this.button3.Enabled = true;
                this.button4.Enabled = true;
                textBox5.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
                textBox8.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
                textBox9.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
                textBox5.ForeColor = Color.Black;
                textBox8.ForeColor = Color.Black;
                textBox9.ForeColor = Color.Black;
            }
            else
            {
                printgray();
            }
        }

        private void dataGridView5_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                this.button3.Enabled = true;
                this.button4.Enabled = true;
                textBox5.Text = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();
                textBox8.Text = dataGridView5.SelectedRows[0].Cells[1].Value.ToString();
                textBox9.Text = dataGridView5.SelectedRows[0].Cells[2].Value.ToString();
                textBox5.ForeColor = Color.Black;
                textBox8.ForeColor = Color.Black;
                textBox9.ForeColor = Color.Black;
            }
            else
            {
                printgray();
            }
        }

        private void dataGridView6_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView6.SelectedRows.Count > 0)
            {
                this.button3.Enabled = true;
                this.button4.Enabled = true;
                textBox5.Text = dataGridView6.SelectedRows[0].Cells[0].Value.ToString();
                textBox8.Text = dataGridView6.SelectedRows[0].Cells[1].Value.ToString();
                textBox9.Text = dataGridView6.SelectedRows[0].Cells[2].Value.ToString();
                textBox5.ForeColor = Color.Black;
                textBox8.ForeColor = Color.Black;
                textBox9.ForeColor = Color.Black;
            }
            else
            {
                printgray();
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "№ ленты")
            {
                textBox5.Clear();
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "№ ленты";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Предмет")
            {
                textBox8.Clear();
                textBox8.ForeColor = Color.Black;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                textBox8.Text = "Предмет";
                textBox8.ForeColor = Color.Gray;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Аудитория")
            {
                textBox9.Clear();
                textBox9.ForeColor = Color.Black;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                textBox9.Text = "Аудитория";
                textBox9.ForeColor = Color.Gray;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Понедельник")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
                
            }
            else if (comboBox1.Text == "Вторник")
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                }
            }
            else if (comboBox1.Text == "Среда")
            {
                if (dataGridView3.SelectedRows.Count > 0)
                {
                    dataGridView3.Rows.RemoveAt(dataGridView3.SelectedRows[0].Index);
                }
            }
            else if (comboBox1.Text == "Четверг")
            {
                if (dataGridView4.SelectedRows.Count > 0)
                {
                    dataGridView4.Rows.RemoveAt(dataGridView4.SelectedRows[0].Index);
                }
            }
            else if (comboBox1.Text == "Пятница")
            {
                if (dataGridView5.SelectedRows.Count > 0)
                {
                    dataGridView5.Rows.RemoveAt(dataGridView5.SelectedRows[0].Index);
                }
            }
            else if (comboBox1.Text == "Суббота")
            {
                if (dataGridView6.SelectedRows.Count > 0)
                {
                    dataGridView6.Rows.RemoveAt(dataGridView6.SelectedRows[0].Index);
                }
            }
            this.button3.Enabled = false;
            this.button4.Enabled = false;
        }
    }
}

