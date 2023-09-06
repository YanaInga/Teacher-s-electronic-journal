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
    public partial class parol : Form
    {
        public parol()
        {
            InitializeComponent();
        }
        public string Password
        {
            get
            {
                return textBox1.Text;
            }
        }
    }
}
