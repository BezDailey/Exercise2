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
    public partial class salesPage : Form
    {
        decimal smallTees = 0;
        decimal mediumTees = 0;
        decimal largeTees = 0;
        decimal extraLargeTees = 0;
        string orderDisplayedS = "";
        string orderDisplayedM = "";
        string orderDisplayedL = "";
        string orderDisplayedXL = "";
        public salesPage()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            smallTees = numUpDownS.Value;
            mediumTees = numUpDownM.Value;
            largeTees = numUpDownL.Value;
            extraLargeTees = numUpDownXL.Value;
            orderDisplayedS = $"Small T-Shirt --- x{smallTees}";
            orderDisplayedM += $"Medium T-Shirt --- x{mediumTees}";
            orderDisplayedL += $"Large T-Shirt --- x{largeTees}";
            orderDisplayedXL += $"Extra Large T Shirt --- x{extraLargeTees}";
            button1.Enabled = false;
            panel2.BackColor = Color.Lime; 
        }

        private void DisplayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderDisplayed f2 = new orderDisplayed(orderDisplayedS, orderDisplayedM, orderDisplayedL, orderDisplayedXL);
            f2.ShowDialog();
            orderDisplayedS = "";
            orderDisplayedM = "";
            orderDisplayedL = "";
            orderDisplayedXL = "";
            button1.Enabled = true;
            panel2.BackColor = Color.Silver;
        }
    }
}
