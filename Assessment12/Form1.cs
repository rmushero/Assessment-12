using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment12
{
    public partial class Form1 : Form
    {
        List<Experiment> experimentList = new List<Experiment>;
        public Form1()
        {
            InitializeComponent();
        }
        private void GetExperimentData(Experiment stuName, Experiment expNumb, Experiment expDesc, Experiment expWeight, Experiment color, Experiment value)
        {

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
