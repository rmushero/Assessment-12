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
        private Experiment exp = new Experiment();
        int expCount = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string studentName = stuNameBox.Text;
            int experimentNumber = Convert.ToInt32(exNumBox.Text);
            string experimentDescription = expDescriptionBox.Text;

            if (studentName != "")
            {
                //get experiment data
                Experiment exp = new Experiment(studentName);

            }
            else if (experimentNumber > 0 && experimentDescription != "")
            {
                Experiment exp = new Experiment(experimentNumber, experimentDescription);
            }
            else
            {
                Experiment exp = new Experiment();
            }

            enabledLabels();

        }

        private void setButton_Click(object sender, EventArgs e)
        {

            decimal weight;
            int number;

            if (int.TryParse(exNumBox.Text, out number) && number < 50)
            {
                exp.ExpNumber = number;
            }
            else
            {
                MessageBox.Show("Invalid Experiment Number Please Enter a NUMBER between 1 and 50");
            }
            if (decimal.TryParse(exResWeight.Text, out weight))
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            

            if (this is where i am getting stuck )
            {
                Experiments[exp.ExpNumber] = new Experiment();
            }
            else
            {
                Experiments[exp.ExpNumber] = new Experiment();
                expListBox.Items.Add(exp.ExpNumber + " \t " + exp.ExDesc);
                //clear data from fields
                stuNameBox.Clear();
                exNumBox.Clear();
                exResColor.Clear();
                expDescriptionBox.Clear();
                exResWeight.Clear();
                exVolume.Clear();
                expCount++;
                if (expCount == SIZE)
                {
                    disableAll();
                }
            }
            
        }
        private void disableAll()
        {
            exResWeight.Enabled = false;
            exResColor.Enabled = false;
            exVolume.Enabled = false;
            resultColorLabel.Enabled = false;
            resultVolLabel.Enabled = false;
            resultWLabel.Enabled = false;
            stuNameBox.Enabled = false;
            exNumBox.Enabled = false;
            expDescriptionBox.Enabled = false;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            //clearing all parts of the form as well don't forget to clear the array
            stuNameBox.Clear();
            exNumBox.Clear();
            exResColor.Clear();
            expDescriptionBox.Clear();
            exResWeight.Clear();
            exVolume.Clear();
            expListBox.Items.Clear();
            expListBox.Items.Add("Experiment Number \t Experiment Description");



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create headers for the list box. 
            expListBox.Items.Add("Experiment Number \t Experiment Description");
        }
        //enable extra labels
        private void enabledLabels()
        {
            exResWeight.Enabled = true;
            exResColor.Enabled = true;
            exVolume.Enabled = true;
            resultColorLabel.Enabled = true;
            resultVolLabel.Enabled = true;
            resultWLabel.Enabled = true;
        }
        
        private void expListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         

            int index = expListBox.SelectedIndex;
           
                displayExperiment(index);
        
           
        }
        private void displayExperiment(int index)
        {
            Review reviewForm = new Review();
            reviewForm.ShowDialog();
            reviewForm.stuNameLabel.Text = "";
            reviewForm.exNumLabel.Text = index.ToString();
            reviewForm.exDescLabel.Text = "";
            reviewForm.rWeightLabel.Text = "";
            reviewForm.rColorLabel.Text = "";
            reviewForm.rVolumeLabel.Text = "";

        }
    }
}
