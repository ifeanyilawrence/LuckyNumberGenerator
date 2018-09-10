using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            int numberEntered = 0;

            if (int.TryParse(tbxNumber.Text, out numberEntered))
            {
                if (numberEntered <= 0)
                {
                    MessageBox.Show("Number must be greater than zero.", "Warning!");
                    tbxNumber.Focus();
                    return;
                }

                string randomNumbersToSave = null;
                List<int> randomNumbers = new List<int>();

                for (int i = 0; i < numberEntered; i++)
                {
                    int randomNumber = GenerateRandomNumbers();
                    randomNumbersToSave += i == (numberEntered-1) ?  randomNumber.ToString() : (randomNumber.ToString() + " ");

                    randomNumbers.Add(randomNumber);

                    Thread.Sleep(50);
                }

                try
                {
                    SaveFileDialog fileDialog = new SaveFileDialog();
                    fileDialog.FileName = "Numbers.txt";
                    fileDialog.DefaultExt = "*.txt";
                    fileDialog.Filter = "Text Files|*.txt";
                    fileDialog.ShowDialog();

                    if (fileDialog.FileName == null || !fileDialog.FileName.ToLower().Contains("numbers.txt"))
                    {
                        MessageBox.Show("Invalid filename.", "Warning!");
                        tbxNumber.Focus();
                        return;
                    }

                    File.WriteAllText(fileDialog.FileName, randomNumbersToSave);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File Operation Error!");
                    tbxNumber.Focus();
                    return;
                }
                
                lbxLuckyNumbers.DataSource = randomNumbers;

                tbxLargestNumber.Text = randomNumbers.Max().ToString();
                tbxSmallestNumber.Text = randomNumbers.Min().ToString();

                tbxNumber.Focus();
            }
            else
            {
                MessageBox.Show("Invalid number entered, kindly check and try again.", "Warning!");
                tbxNumber.Focus();
                return;
            }
        }

        private int GenerateRandomNumbers()
        {
            Random random = new Random();
            return random.Next(1, 46);
        }

        private void btnClearNumbers_Click(object sender, EventArgs e)
        {
            tbxNumber.Text = "";
            tbxSmallestNumber.Text = "";
            tbxLargestNumber.Text = "";
            lbxLuckyNumbers.DataSource = null;
            tbxNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
