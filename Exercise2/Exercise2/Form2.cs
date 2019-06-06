using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class orderDisplayed : Form
    {
        public orderDisplayed(string s, string m, string l, string xl)
        {
            InitializeComponent();
            string display;
            display = s;
            display += "\r\n" + m;
            display += "\r\n" + l;
            display += "\r\n" + xl;
            textBox1.Text = display;
            display = "";
        }

        private void ExitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
