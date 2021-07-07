//By: B1706
//Prog4
//CIS-199-02
//Due: 04-25-2017

//This program allows the user to enter their packing 
//information and then displays the total packing cost
//in the listbox. From there the user can look at the 
//details of each package enetered in the listbox. The 
//user can also choose a package from the listbox and 
//click either send to or send from UofL which changes 
//the corresponding zip code to the UofL zip code.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4
{
    public partial class Form1 : Form
    {
        //List to hold GroundPackage objects.
        private List<GroundPackage> packageList = new List<GroundPackage>();

        //GroundPackage object to test class with.
        GroundPackage package = new GroundPackage(40202, 90210, 12.0, 12.0, 12.0, 100.0);

        public Form1()
        {
            InitializeComponent();
        }

        //Constant Variables
        public const int UOFL_ZIP = 40292; //UofL Zip Code.
        public const int LOW_ZIP = 00000; //Minimum Zip Code.
        public const int HIGH_ZIP = 99999; //Maximum Zip Code.

        //Precondition: User has clicked on addPackageButton.
        //Postcondition:If user's input is validated then the package's 
        //              cost is determined based on the input and stored in the listBox.
        private void addPackageButton_Click(object sender, EventArgs e)
        { 
            int originZip; //Holds the origin zip code.
            int destZip; //Holds the destination zip code.
            double length; //Holds the length.
            double width; //Holds the width.
            double height; //Holds the height.
            double weight; //Holds the weight.

            if (int.TryParse(originZipTextBox.Text, out originZip) && originZip >= LOW_ZIP && originZip <= HIGH_ZIP)
            {
                if (int.TryParse(destZipTextBox.Text, out destZip) && destZip >= LOW_ZIP && originZip <= HIGH_ZIP)
                {
                    if (double.TryParse(lengthTextBox.Text, out length) && length > 0)
                    {
                        if (double.TryParse(widthTextBox.Text, out width) && width > 0)
                        {
                            if (double.TryParse(heightTextBox.Text, out height) && height > 0)
                            {
                                if (double.TryParse(weightTextBox.Text, out weight) && weight > 0)
                                {

                                    package = new GroundPackage(originZip, destZip, length, width, height, weight);

                                    packageList.Add(package);

                                    outputListBox.Items.Add(package.CalcCost().ToString("c"));
                                    
                                    //Clear TextBoxes.
                                    originZipTextBox.Clear();
                                    destZipTextBox.Clear();
                                    lengthTextBox.Clear();
                                    widthTextBox.Clear();
                                    heightTextBox.Clear();
                                    weightTextBox.Clear();

                                    originZipTextBox.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Weight");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Height");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Width");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Length");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Destination Zip");
                }
            }
            else
            {
                MessageBox.Show("Invalid Origin Zip");
            }
        }

        //Precondition: User clicked on detailsButton.
        //Postcondition: Shows the package details of the package 
        //               that the user selected from the listBox.
        private void detailsButton_Click_1(object sender, EventArgs e)
        {
            int index;

            index = outputListBox.SelectedIndex;

            if (outputListBox.SelectedIndex != -1)
            {
                MessageBox.Show(packageList[index].ToString());
            }
            else
            {
                MessageBox.Show("Select Shipping cost");
            }
        }

        //Precondition: User clicked on sendToButton.
        //Postcondition: Updates the package's destination zip code that 
        //               the user selected from the listbox. Is updated
        //               to UofL Zip:40292
        private void sendToButton_Click(object sender, EventArgs e)
        {
            int index = outputListBox.SelectedIndex;//Index position of the selected listtbox item.

            if (outputListBox.SelectedIndex != -1)
            {
                packageList[index].DestinationZip = UOFL_ZIP;

                //Updates Packaging Details.
                outputListBox.Items.RemoveAt(index);
                outputListBox.Items.Insert(index, packageList[index].CalcCost().ToString("c"));

                MessageBox.Show("Destination Zip Code Changed to 40292");
            }
            else
            {
                MessageBox.Show("Select Shipping Cost");
            }
        }

        //Precondition: User clicked sendFromButton. 
        //Postcondition: Updates the package's origin zip code that 
        //               the user selected from the listbox. Is updated
        //               to UofL Zip:40292
        private void sendFromButton_Click(object sender, EventArgs e)
        {
            int index = outputListBox.SelectedIndex;///Index position of the selected listtbox item.

            if (outputListBox.SelectedIndex != -1)
            {
                packageList[index].OriginZip = UOFL_ZIP;

                //Updates Packaging Details.
                outputListBox.Items.RemoveAt(index);
                outputListBox.Items.Insert(index, packageList[index].CalcCost().ToString("c"));

                MessageBox.Show("Origin ZIp Code Changed to 40292");
            }
            else
            {
                MessageBox.Show("Select Shipping Cost");
            }
        }
    }
}
