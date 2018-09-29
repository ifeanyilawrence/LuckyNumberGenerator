using System;
using System.IO;
using System.Windows.Forms;

namespace LuckyNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateNumbers_Click(object sender, EventArgs e)
        {
            //Declare a variable to hold the user's input
            int numberEntered;

            //Declare a variable to hold each generated random number
            int generatedRandomNumber;

            //Declares a StreamWriter and a StreamReader variable
            StreamWriter fileToWrite;
            StreamReader fileToRead;

            //Declears and initializes variables to hold the largest and smallest number
            int largestNumber = 0;
            int smallestNumber = 45; //45 is chosen because its the largest possible number

            //Declare a variable to hold the read number
            string readNumber;

            //Validates input from the number textbox
            if (int.TryParse(tbxNumber.Text, out numberEntered))
            {
                //Checks if number entered is greater than zero
                if (numberEntered > 0)
                {
                    //Initializes the name of the file to be saved
                    saveFile.FileName = "Numbers.txt";
                    //Sets the default file extension
                    saveFile.DefaultExt = "*.txt";
                    //Sets the savefile filter
                    saveFile.Filter = "Text Files|*.txt";
                    //Sets the file's initial directory
                    saveFile.InitialDirectory = @"C:\Documents";
                    saveFile.RestoreDirectory = true;

                    //Displays a Save as dialog box and checks if the user cancels the operation or not
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        //Validates the file name
                        if (saveFile.FileName.ToLower().Contains(@"\numbers.txt"))
                        {
                            try
                            {
                                //Create the file and get a StreamWriter object
                                fileToWrite = File.CreateText(saveFile.FileName);

                                //Create a Random object.
                                Random rand = new Random();

                                //Generates the lucky numbers and writes to the file
                                for (int i = 0; i < numberEntered; i++)
                                {
                                    //Generates a random number between 1 and 45. 1 and 45 inclusive
                                    generatedRandomNumber = rand.Next(45) + 1;

                                    //Writes the generated lucky number to file
                                    fileToWrite.WriteLine(generatedRandomNumber);

                                    //Thread.Sleep(50);
                                }

                                //Close the file
                                fileToWrite.Close();

                                //Open the file and get a StreamReader object.
                                fileToRead = File.OpenText(saveFile.FileName);

                                //Clears the listbox items
                                lbxLuckyNumbers.Items.Clear();

                                //Reads the file till the end
                                while (!fileToRead.EndOfStream)
                                {
                                    //Reads a character and assigns it to the readNumber variable
                                    readNumber = fileToRead.ReadLine();

                                    //Add the read number to listbox items
                                    lbxLuckyNumbers.Items.Add(readNumber);

                                    //checks if read number is greater than the set largest number, and assigns it as largest if true
                                    if (int.Parse(readNumber) > largestNumber)
                                        largestNumber = int.Parse(readNumber);

                                    //checks if read number is smaller than the set smaller number, and assigns it as smallest if true
                                    if (int.Parse(readNumber) < smallestNumber)
                                        smallestNumber = int.Parse(readNumber);
                                }

                                //Closes the file
                                fileToRead.Close();

                                //Assigns the largest number
                                tbxLargestNumber.Text = largestNumber.ToString();

                                //Assigns the smallest number
                                tbxSmallestNumber.Text = smallestNumber.ToString();

                                tbxNumber.Focus();
                            }
                            catch (Exception ex)
                            {
                                //Display an error message
                                MessageBox.Show(ex.Message);
                                //Returns focus to the number of lucky numbers textbox
                                tbxNumber.Focus();
                            }
                        }
                        else
                        {
                            //Display an error message to the user
                            MessageBox.Show("Invalid filename.");
                            //Returns focus to the number of lucky numbers textbox
                            tbxNumber.Focus();
                        }
                    }
                    else
                    {
                        //Display a cancel message to the user
                        MessageBox.Show("Operation canceled.");
                        //Returns focus to the number of lucky numbers textbox
                        tbxNumber.Focus();
                    }
                }
                else
                {
                    //Display an error message to the user
                    MessageBox.Show("Number must be greater than zero.");

                    //Returns focus to the number of lucky numbers textbox
                    tbxNumber.Focus();
                }
            }
            else
            {
                //Display an error message to the user
                MessageBox.Show("Invalid number entered, kindly check and try again.");

                //Returns focus to the number of lucky numbers textbox
                tbxNumber.Focus();
            }
        }
        private void btnClearNumbers_Click(object sender, EventArgs e)
        {
            tbxNumber.Text = "";
            tbxSmallestNumber.Text = "";
            tbxLargestNumber.Text = "";
            lbxLuckyNumbers.Items.Clear();
            tbxNumber.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
