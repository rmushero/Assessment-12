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
        const int SIZE = 50;
        Experiment[] Experiments = new Experiment[SIZE];
        public Form1()
        {
            InitializeComponent();
        }

        private void getExperimentData(Experiment exp)
        {
            decimal weight;
            int number;
         
            if(int.TryParse(exNumBox.Text, out number))
            {
                exp.ExpNumber = number;
            }
            else
            {
                MessageBox.Show("Invalid Experiment Number");
            }
            if(decimal.TryParse(exResWeight.Text, out weight))
            {
                exp.ExWeight = weight;
            }
            else
            {
                MessageBox.Show("Invalid Weight");
            }
            exp.ExColor = exResColor.Text;
            exp.ExDesc = expDescriptionBox.Text;
            exp.StuName = stuNameBox.Text;



        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //create experiment object
            Experiment exp = new Experiment();
            //get experiment data
            getExperimentData(exp);

            for (int index = 0; index < Experiments.Length; index++)
            {
                Experiments[index] = new Experiment();
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            //create experiment object
            Experiment exp = new Experiment();
            //get experiment data
            getExperimentData(exp);
           
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Experiment exp = new Experiment();
            getExperimentData(exp);
            expListBox.Items.Add(exp.ExpNumber + '\t' + exp.ExDesc);
            stuNameBox.Clear();
            exNumBox.Clear();
            exResColor.Clear();
            expDescriptionBox.Clear();
            exResWeight.Clear();
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clearing all parts of the form as well don't forget to clear the array
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create headers for the list box. 
            expListBox.Items.Add("Experiment Number" + '\t' + "Experiment Description");
        }
    }
}
