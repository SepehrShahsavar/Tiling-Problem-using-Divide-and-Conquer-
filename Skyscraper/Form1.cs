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
using TourinoPuzzel;

namespace Skyscraper
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = Int32.Parse(textBox1.Text);
            int x = Int32.Parse(textBox2.Text);
            int y = Int32.Parse(textBox3.Text);
            if (x < 0 || y < 0 || x >= size || y >= size)
            {
                MessageBox.Show("INVALID INPUTS!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form2 f2 = new Form2(size, x, y);
            f2.Show();
        }
    }
}
