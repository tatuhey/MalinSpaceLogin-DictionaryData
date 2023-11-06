﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.IO;
using System.Runtime.CompilerServices;

namespace MalinSpaceLogin_DictionaryData
{
    public partial class AdminGUI : Form
    {
        public AdminGUI()
        {
            InitializeComponent();
            this.KeyPreview = true;           
        }

        //5.1.	Create the Admin GUI with the following settings: GUI is model, all Control Box features are removed/hidden,
        //then add two text boxes.The text box for the Staff ID should be read-only for Add, Update and Delete purposes.


        //5.2.	Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data. 
        // Inside AdminGUI.cs
        public void SetStaffInfo(string name, string id)
        {
            tbID.Text = id;
            tbName.Text = name;
        }


        //5.3.	Create a method that will create a new Staff ID and input the staff name from the related text box.
        //The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated.
        //The new staff member must be added to the Dictionary data structure.
        private int GenerateUniqueID()
        {
            Random random = new Random();
            int uniqueID;
            try
            {
                do
                {
                    uniqueID = random.Next(0, 10000000) + 770000000;
                }
                while (GeneralGUI.MasterFile.ContainsKey(uniqueID));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return uniqueID;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                int newID = GenerateUniqueID();
                // ensures a valid ID was generated
                if (newID != 0) 
                {
                    string name = tbName.Text.Trim();
                    // ensures name isn't empty or white space
                    if (!string.IsNullOrWhiteSpace(name)) 
                    {
                        GeneralGUI.MasterFile.Add(newID, name);
                        MessageBox.Show("New name has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Unable to generate a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //5.4.	Create a method that will Update the name of the current Staff ID.
        private void UpdateStaffName()
        {
            try
            {
                // Ensure there's a valid ID in tbID and a name in tbName
                if (int.TryParse(tbID.Text, out int staffID) && !string.IsNullOrEmpty(tbName.Text))
                {
                    if (GeneralGUI.MasterFile.ContainsKey(staffID))
                    {
                        // Update the name associated with the staff ID
                        GeneralGUI.MasterFile[staffID] = tbName.Text.Trim();
                        MessageBox.Show("Name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Staff ID {staffID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Staff ID and Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStaffName();
        }


        //5.5.	Create a method that will Remove the current Staff ID and clear the text boxes.
        private void RemoveStaff()
        {
            try
            {
                int id;
                if (int.TryParse(tbID.Text, out id) && GeneralGUI.MasterFile.ContainsKey(id))
                {
                    GeneralGUI.MasterFile.Remove(id);
                    tbID.Text = string.Empty;
                    tbName.Text = string.Empty;
                }
                MessageBox.Show("Selected entry has been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            RemoveStaff();
        }



        //5.6.	Create a method that will save changes to the csv file, this method should be called as the Admin GUI closes.
        private void SaveToCSV()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "MalinStaffNamesV2.csv");
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false)) // False means overwrite the file
                {
                    foreach (var entry in GeneralGUI.MasterFile)
                    {
                        writer.WriteLine($"{entry.Key},{entry.Value}"); // Write each key,value pair as a line in the CSV
                    }
                }
                MessageBox.Show("New file is saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToCSV();
            
        }



        //5.7.	Create a method that will close the Admin GUI when the Alt + L keys are pressed.
        private void AdminGUI_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Alt + L keys are pressed
            if (e.Alt && e.KeyCode == Keys.L)
            {
                this.Close();
            }
        }





        //5.8.	Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience.
        //Make all methods private and ensure the Dictionary is updated.


        //5.9.	Ensure all code is adequately commented.
        //Map the programming criteria and features to your code/methods by adding comments above the method signatures.
        //Ensure your code is compliant with the CITEMS and MS coding standards (refer http://www.citems.com.au/).

    }
}
