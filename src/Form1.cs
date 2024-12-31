using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCal
{
    public partial class Form1 : Form
    {
        Functions function = null;
        public Form1()
        {
            function = new Functions(this);
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            function.cal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            function.cal();
            timer1.Start();
        }

        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            function.topMost(true);
        }

        private void oFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            function.topMost(true);
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            function.opacityChange((int.Parse(toolStripComboBox1.Text)));
        }
    }
}
