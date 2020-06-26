using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingVizualization
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        ArrayList array;

        static Random randomNumber = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawSamples()
        {
            graphics.Clear(Color.White);

            for (int i = 0; i < array.Count; i++)
            {
                int x = (int)(((double)pnlSort.Width/array.Count)*i);

                Pen pen = new Pen(Color.Black);
                graphics.DrawLine(pen, new Point(x, pnlSort.Height), new Point(x, (int)(pnlSort.Height - (int)array[i])));
            }
        }

        private void cmdRandomize_Click(object sender, EventArgs e)
        {
            array = new ArrayList(20);
            for (int i = 0; i < array.Capacity; i++)
            {
                int y = i / array.Capacity * pnlSort.Height;
                array.Add(y);
            }
            Randomize(array);
            DrawSamples();
        }

        public void Randomize(IList list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int swapIndex = randomNumber.Next(i + 1);
                if (swapIndex != i)
                {
                    object tmp = list[swapIndex];
                    list[swapIndex] = list[i];
                    list[i] = tmp;
                }
            }
        }

        private void RedrawItem(int index, Graphics graphics, IList list)
        {
            int x = pnlSort.Width / array.Count * index;
            graphics.DrawLine(new Pen(Color.White), new Point(x, 0), new Point(x, pnlSort.Height));
            graphics.DrawLine(new Pen(Color.Black), new Point(x, pnlSort.Height), new Point(x, pnlSort.Height - (int)list[index]));
        }
    }
}
