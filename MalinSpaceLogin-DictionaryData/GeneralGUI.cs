using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.IO;

namespace MalinSpaceLogin_DictionaryData
{
    public partial class GeneralGUI : Form
    {
        public GeneralGUI()
        {
            InitializeComponent();
            ReadData();
            DisplayDataInListBox();
        }

        //4.1.	Create a Dictionary data structure with a TKey of type integer and a TValue of type string,
        //      name the new data structure “MasterFile”.
        
        Dictionary <int, string> MasterFile = new Dictionary <int, string>();

        //4.2.	Create a method that will read the data from the.csv file into the Dictionary data structure when the GUI loads.
        public void ReadData()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "MalinStaffNamesV2.csv");

            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);

                    foreach (var line in lines)
                    {
                        var parts = line.Split(',');

                        // Assuming well-formed CSV and error handling for parsing 
                        // the integer and avoiding duplicate keys.
                        if (parts.Length == 2
                            && int.TryParse(parts[0], out int id)
                            && !MasterFile.ContainsKey(id))
                        {
                            MasterFile.Add(id, parts[1]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //4.3.	Create a method to display the Dictionary data into a non-selectable display only list box (ie read only).
        private void DisplayDataInListBox()
        {
            lbStaffMain.Items.Clear();  // Clear any existing items

            foreach (var entry in MasterFile)
            {
                lbStaffMain.Items.Add($"ID: {entry.Key}, Name: {entry.Value}");
            }

            lbStaffMain.SelectionMode = SelectionMode.None;  // Make the list box non-selectable
        }

        //4.4.	Create a method to filter the Staff Name data from the Dictionary into a second filtered and selectable list box.
        //      This method must use a text box input and update as each character is entered.
        //      The list box must reflect the filtered data in real time.


        //4.5.	Create a method to filter the Staff ID data from the Dictionary into the second filtered and selectable list box.
        //      This method must use a text box input and update as each number is entered.
        //      The list box must reflect the filtered data in real time.


        //4.6.	Create a method for the Staff Name text box which will clear the contents and place the focus into the Staff Name text box.
        //      Utilise a keyboard shortcut.


        //4.7.	Create a method for the Staff ID text box which will clear the contents and place the focus into the text box.
        //      Utilise a keyboard shortcut.


        //4.8.	Create a method for the filtered and selectable list box which will populate the two text boxes
        //      when a staff record is selected.Utilise the Tab and keyboard keys.


        //4.9.	Create a method that will open the Admin GUI when the Alt + A keys are pressed.
        //      Ensure the General GUI sends the currently selected Staff ID and Staff Name
        //      to the Admin GUI for Update and Delete purposes and is opened as modal.
        //      Create modified logic to open the Admin GUI to Create a new user when the Staff ID 77
        //      and the Staff Name is empty.Read the appropriate criteria in the Admin GUI for further information.

        //4.10.	Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience.
        //      Make all methods private and ensure the Dictionary is static and public.


        //4.11.	Ensure all code is adequately commented.Map the programming criteria and features to your code/methods
        //      by adding comments above the method signatures.
        //      Ensure your code is compliant with the CITEMS coding standards (refer http://www.citems.com.au/).



    }
}
