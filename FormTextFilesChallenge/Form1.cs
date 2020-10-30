using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace FormTextFilesChallenge
{
    public partial class ChallengeForm : Form
    {
        BindingList<UserModels> users = new BindingList<UserModels>();
        int firstNameOrder = 0;
        int lastNameOrder = 0;
        int ageOrder = 0;
        int isAliveOrder = 0;
        //string file = "StandardDataSet.csv";
        string file = "AdvancedDataSet.csv";

        public ChallengeForm()
        {
            InitializeComponent();

            LoadListFromFile();

            WireUpDropDown();
        }

        private void LoadListFromFile()
        {
            string[] lines = File.ReadAllLines(file);

            string[] headers = lines[0].Split(',');

            for(int i = 1; i < headers.Length; i++)
            {
                if (headers[i] == "FirstName")
                {
                    firstNameOrder = i;
                }
                else if(headers[i] == "LastName")
                {
                    lastNameOrder = i;
                }
                else if (headers[i] == "Age")
                {
                    ageOrder = i;
                }
                else if(headers[i] == "IsAlive")
                {
                    isAliveOrder = i;
                }
            }

            for(int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');
                bool isAlive = false;
                
                if(columns[isAliveOrder] == "1")
                {
                    isAlive = true;
                }

                users.Add(new UserModels
                {
                    FirstName = columns[firstNameOrder],
                    LastName = columns[lastNameOrder],
                    Age = int.Parse(columns[ageOrder]),
                    IsAlive = isAlive
                });
            }
        }

        private void WireUpDropDown()
        {
            listBox.DataSource = users;
            listBox.DisplayMember = nameof(UserModels.DisplayText);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            users.Add(new UserModels
            {
                FirstName = nameTextBox.Text,
                LastName = lastTextBox.Text,
                Age = (int)numericUpDown1.Value,
                IsAlive = checkBoxAlive.Checked
            });

            nameTextBox.Text = "";
            lastTextBox.Text = "";
            numericUpDown1.Value = 0;
            checkBoxAlive.Checked = false;
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            string line = "";
            //lines.Add("FirstName,LastName,Age,IsAlive");
            for(int i = 0; i < 4; i++)
            {
                if (firstNameOrder == i)
                {
                    line += "FirstName";
                }
                else if (lastNameOrder == i)
                {
                    line += "LastName";
                }
                else if (ageOrder == i)
                {
                    line += "Age";
                }
                else if (isAliveOrder == i)
                {
                    line += "IsAlive";
                }

                line += ",";
            }

            line = line.Substring(0, line.Length - 1);

            lines.Add(line);

            foreach(UserModels user in users)
            {
                int isAliveValue = 0;
                line = "";
                
                if(user.IsAlive == true)
                {
                    isAliveValue = 1;
                }

                for (int i = 0; i < 4; i++)
                {
                    if (firstNameOrder == i)
                    {
                        line += user.FirstName;
                    }
                    else if (lastNameOrder == i)
                    {
                        line += user.LastName;
                    }
                    else if (ageOrder == i)
                    {
                        line += user.Age;
                    }
                    else if (isAliveOrder == i)
                    {
                        line += isAliveValue;
                    }

                    line += ",";
                }

                line = line.Substring(0, line.Length - 1);

                lines.Add(line);
            }

            File.WriteAllLines(file,lines);

            MessageBox.Show("Save complete!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAlive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
