using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            IsMdiContainer = true;
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 rasp = new Form2();
            rasp.MdiParent = this;
            rasp.Show();
            rasp.WindowState = FormWindowState.Maximized;
        }

        private void рейтингпланToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 plan = new Form3();
            plan.MdiParent = this;
            plan.Show();
            plan.WindowState = FormWindowState.Maximized;
        }

        private void журналГруппToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 journal = new Form4();
            journal.MdiParent = this;
            journal.Show();
            journal.WindowState = FormWindowState.Maximized;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            parol f = new parol();
            while (true)
            {
                if (f.ShowDialog() != DialogResult.OK)
                {
                    this.Close();
                    return;
                }
                else if (f.Password == "1q2w3")
                {
                    f.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Введен неверный пароль, повторите попытку");
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Закрыть программу? Если данные не были сохранены, то при выходе из программы они будут утеряны", "", MessageBoxButtons.YesNoCancel);
            if (result != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}

