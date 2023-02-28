using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.1;
        Random random = new Random();
        int clickCount = 0, x = 0;

        double us, rs;

        private void startButton_Click(object sender, EventArgs e)
        {
            if (clickCount == 0)
            {
                us = (double)ustart.Value;
                rs = (double)rubstart.Value;
                timer1.Start();
            }
            else if (clickCount % 2 == 0)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
            clickCount++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(x, Math.Round(us, 2));
            chart1.Series[1].Points.AddXY(x, Math.Round(rs, 2));
            us = us * (1 + k * (random.NextDouble() - 0.5));
            rs = rs * (1 + k * (random.NextDouble() - 0.5));
            if (us < 0) us = 0;
            if (rs < 0) rs = 0;
            unow.Value = Convert.ToDecimal(us);
            rubnow.Value = Convert.ToDecimal(rs); 
            x++;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
