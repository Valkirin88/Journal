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
using System.Xml.Serialization;

namespace Journal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {
            CheckSaveButton();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CheckSaveButton();
            

            JobDatabase job = new JobDatabase();
           
            job.descriptionJob = descriptionBox.Text;
            job.worker = workerBox.Text;
            job.plant = plantBox.Text;
            
            // job.time = dateTimePicker1.Value;
            
            JobDatabase.SaveJobs(job);
            
           



        }

        private void workerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSaveButton();
        }

        /// <summary>
        /// Для кнопки сохранить ввести описание работы и работника
        /// </summary>
        private void CheckSaveButton()
        {
            if ((descriptionBox.Text != String.Empty) && (workerBox.Text != String.Empty))
            {
                saveButton.Enabled = true;
            }
        }

        private void newJobButton_Click(object sender, EventArgs e)
        {
            descriptionBox.Text = String.Empty;
            workerBox.Text = String.Empty;
            plantBox.Text = String.Empty;

        }

        private void newLineDatabase()
        {
            
        }

        private void DebugText_Click(object sender, EventArgs e)
        {
          
        }

        private void plantBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ShowError()
        {
            MessageBox.Show("Попытка сохранить одну работу дважды", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
