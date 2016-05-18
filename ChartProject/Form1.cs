using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChartProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Series["Age"].Points.AddXY("Yousef", 33);
            this.chart1.Series["Scores"].Points.AddXY("Yousef", 90);

            this.chart1.Series["Age"].Points.AddXY("Younes", 35);
            this.chart1.Series["Scores"].Points.AddXY("Younes", 70);

            this.chart1.Series["Age"].Points.AddXY("Mohamad", 40);
            this.chart1.Series["Scores"].Points.AddXY("Mohamad", 70);



        }
    }
}
