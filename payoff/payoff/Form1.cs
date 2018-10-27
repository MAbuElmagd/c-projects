using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payoff
{
    public partial class Form1 : Form
    {
        public int[,] a = new int[5, 6];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public int[,] cost(int[,]a) {
            for (int i = 0; i < 3; i++)
            {
                //opti
                {
                    a[i, 3] = Math.Min(a[i, 0], a[i, 1]);
                    a[i, 3] = Math.Min(a[i, 2], a[i, 3]);
                }
                //pessi
                {
                    a[i, 4] = Math.Max(a[i, 0], a[i, 1]);
                    a[i, 4] = Math.Max(a[i, 2], a[i, 3]);
                }
                //regret
                {
                    int def=0;
                    int[,] redmat = new int[3, 3];
                    def = Math.Min(a[0, i], a[1, i]);
                    def = Math.Min(a[2, i], def);
                    for (int x = 0; x < 3; x++)
                        for (int z = 0; z < 3; z++)
                            redmat[x,z]=Math.Abs((a[x,z]-def));
                    a[i, 5] = Math.Max(redmat[i, 0], redmat[i, 1]);
                    a[i, 5] = Math.Max(redmat[i,2],a[i,5]);
                }

            }
            a[4, 3] = min(a[0, 3], 1, a[1, 3], 2, a[2, 3], 3);
            a[4, 4] = min(a[0, 4], 1, a[1, 4], 2, a[2, 4], 3);
            a[4, 5] = min(a[0, 5], 1, a[1, 5], 2, a[2, 5], 3);
            return a;
        }
        public int max(int v1,int i1,int v2,int i2,int v3 ,int i3) {
            if (v1 > v2 && v1 > 3)
                return i1;
            else if (v2 > v1 && v2 > v3)
                return i2;
            else
                return i3;
        }
        public int min(int v1, int i1, int v2, int i2, int v3, int i3)
        {
            if (v1 < v2 && v1 < 3)
                return i1;
            else if (v2 < v1 && v2 < v3)
                return i2;
            else
                return i3;
        }
        public int[,] profit(int[,]a) {
            for (int i = 0; i < 3; i++)
            {
                //opti
                {
                    a[i, 3] = Math.Max(a[i, 0], a[i, 1]);
                    a[i, 3] = Math.Max(a[i, 2], a[i, 3]);
                }
                //pessi
                {
                    a[i, 4] = Math.Min(a[i, 0], a[i, 1]);
                    a[i, 4] = Math.Min(a[i, 2], a[i, 3]);
                }
            //regret
            {
                int def = 0;
                int[,] redmat = new int[3, 3];
                def = Math.Max(a[0, i], a[1, i]);
                def = Math.Max(a[2, i], def);
                 for (int x = 0; x < 3; x++)
                        for (int z = 0; z < 3; z++)
                            redmat[x,z]=Math.Abs((a[x,z]-def));
                 a[i, 5] = Math.Max(redmat[i, 0], redmat[i, 1]);
                 a[i, 5] = Math.Max(redmat[i, 2], a[i, 5]);
            }}
            a[3, 3] = max(a[0, 3], 1, a[1, 3], 2, a[2, 3], 3);
            a[3, 4] = max(a[0, 4], 1, a[1, 4], 2, a[2, 4], 3);
            a[3, 5] = min(a[0, 5], 1, a[1, 5], 2, a[2, 5], 3);
            return a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a[0, 0] = int.Parse(textBox1.Text);
            a[0, 1] = int.Parse(textBox2.Text);
            a[0, 2] = int.Parse(textBox3.Text);
            a[1, 0] = int.Parse(textBox4.Text);
            a[1,1] = int.Parse(textBox5.Text);
            a[1,2] = int.Parse(textBox6.Text);
            a[2,0] = int.Parse(textBox7.Text);
            a[2,1] = int.Parse(textBox8.Text);
            a[2,2] = int.Parse(textBox9.Text);

            a = profit(a);
            MessageBox.Show("profit \n optimistic: s" + a[3, 3] + "\n pessimistic: s" + a[3, 4] + "\n regret: s" + a[3, 5]);
            a = cost(a);
            MessageBox.Show("cost \n optimistic: s"+a[4,3]+"\n pessimistic: s"+a[4,4]+"\n regret: s"+a[4,5]);
        }
    }
}
