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

namespace CarRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMake.Items.Add("Toyota");
            comboBoxMake.Items.Add("Honda");
            comboBoxMake.Items.Add("Ford");

            comboBoxYear.Items.Add("2019");
            comboBoxYear.Items.Add("2020");
            comboBoxYear.Items.Add("2021");
            comboBoxYear.Items.Add("2022");
            comboBoxYear.Items.Add("2023");
        }

        private void radioCar_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxCar.Enabled = true;
            grpBoxOwner.Enabled = false;
            
        }

        private void radioOwner_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxCar.Enabled = false;
            grpBoxOwner.Enabled = true;
        }

        private void comboBoxMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModel.Items.Clear();

            //Toyota
            if (comboBoxMake.SelectedIndex == 0)
            {
                comboBoxModel.Items.Add("Camry");
                comboBoxModel.Items.Add("Corolla");
                comboBoxModel.Items.Add("Prius");
                comboBoxModel.Items.Add("Rav4");
            }

            //Honda 
            if (comboBoxMake.SelectedIndex == 1)
            {
                comboBoxModel.Items.Add("Accord");
                comboBoxModel.Items.Add("Civic");
                comboBoxModel.Items.Add("Pilot");
                comboBoxModel.Items.Add("Fit");
            }

            //Ford 
            if (comboBoxMake.SelectedIndex == 2)
            {
                comboBoxModel.Items.Add("F-150");
                comboBoxModel.Items.Add("Mustang");
                comboBoxModel.Items.Add("Fiesta");
                comboBoxModel.Items.Add("Focus");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBoxMake.Text = string.Empty;
            comboBoxModel.Text = string.Empty;
            comboBoxYear.Text = string.Empty;
            textBoxFName.Text = string.Empty;
            textBoxLName.Text = string.Empty;
            textBoxPhone.Text = string.Empty;

        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDlg = new SaveFileDialog())
            {
                saveFileDlg.Filter = "Text Files|*.txt|Documents|*.doc";
                saveFileDlg.CreatePrompt = true;
                saveFileDlg.OverwritePrompt = false;
                saveFileDlg.Title = "Save Text Document";
                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    SaveFile(saveFileDlg);

                }

            }

        }
        private void SaveFile(SaveFileDialog sfd)
        {
            string path = sfd.FileName;
            string texty = "The car " + comboBoxMake.Text + " " + comboBoxModel.Text + " " + comboBoxYear.Text + " belongs to " + textBoxFName.Text + " " + textBoxLName.Text + ". Phone#: " + textBoxPhone.Text;
            File.WriteAllText(path, texty);
            //File.WriteAllText(path, Model.Text);
        }
    }
}
