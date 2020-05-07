using Skyscraper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourinoPuzzel
{
    public partial class Form2 : Form
    {
        private int size, x, y;
        public Form2(int size ,int x ,int y)
        {
            InitializeComponent();
            this.size = size;
            this.x = x;
            this.y = y;
            this.Width = 1000;
            this.Height = 1000;
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Map map = new Map();

            int[,] arr = new int[size, size];
            arr[x, y] = 0;

            map.Mapper(arr, size, x , y , 0 , size , 0 , size);


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Brush brush = new SolidBrush(colorPicker(arr[i, j]));
                    g.FillRectangle(brush, j * 50, i * 50, 50, 50);
                }
            }
            e.Dispose();
        }

        private Color colorPicker(int i)
        {
            switch (i)
            {
                case 0:
                    return Color.FromArgb(71, 74, 74);
                case 1:
                    return Color.FromArgb(3, 223, 252);
                case 2:
                    return Color.FromArgb(252, 40, 3);
                case 3:
                    return Color.FromArgb(252, 219, 3);
                case 4:
                    return Color.FromArgb(0, 255, 68);
                case 5:
                    return Color.FromArgb(98, 0, 255);
                case 6:
                    return Color.FromArgb(252, 177, 3);
                case 7:
                    return Color.FromArgb(183, 0, 255);
                case 8:
                    return Color.FromArgb(212, 126, 21);
                default:
                    break;
            }
            return Color.FromArgb(250, 7, 165);
        }
    }
}
