/***************************************************************
* Name: Zubaidah Alqaisi                                       *
* ZID: Z1786977                                                * 
* Course: CSCI 473 Section 2 Spring 2018                       *
* Assignment: assign 4                                         *
* Due Date: Wednesday, March. 28.                              *
* Program goal: Display a chart in a form and do some tricks   *
*               with it: adding values from different sources, *
*               changing the chart type, adding random values, *
*               and adding value from the user to the chart.   *
***************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Assign4
{
    public partial class Form1 : Form
    {
        // creating a list of type double for the storing the file content
        List<double> fileContent = new List<double>();
        int i;

        public Form1()
        {
            InitializeComponent();
        }

/****************************************************
* Function: RadioButton_CheckedChanged ()          * 
* Purpose: This method change the type of the chart*
*          based on a radio button selected by the *
*          user. If a particular radio button is   *
*          selected, it will be disabled so the    *
*          user won't be able to click on it again.*
***************************************************/

        void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // if the bar chart radio button is selected 
            if (barChart.Checked)
            {
                // change the type of the char to bar char 
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                barChart.Checked = false;
            }
            // if the column chart is selected 
            if (columnChart.Checked)
            {
                // change the chart type to column 
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                columnChart.Checked = false;
            }
            // if the pie chart is selected 
            if (pieChart.Checked)
            {
                // chage the char type to pie chart 
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                pieChart.Checked = false;
            }
            // if a point chart is selected 
            if (pointChart.Checked)
            {
                // change the chart type to point chart
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                pointChart.Checked = false;
            }
        } // end of radioButton_CheckedChanged () method 

/*********************************************************
 * Function: Clear_Click ()                              *
 * Purpose: This function clears up the the chart points *
 *          and the text box.                            *
 * ******************************************************/

        private void Clear_Click(object sender, EventArgs e)
        {
            // clear up the chart points 
            chart1.Series[0].Points.Clear();
            numberTextBox.Clear();    // clear up the text box 

        } // end of Clear_Click () method 

/*****************************************************
 * Function: Exit_Click ()                           *
 * Purpose: this function exit the form when the user*
 *          click on the exit button.                *
 * **************************************************/

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

/*******************************************************
 * Function: ChooseAFile_Click ()                      *
 * Purpose: This function allows the user to select a  *
 *           input file source with a double numbetrs  *
 *           format. It will use the StreamReader ()   *
 *           to read the files and store the content in*
 *           a list of double. Then it will empty the  *
 *           list for the user to select another file. *
 * ****************************************************/

        private void ChooseAFile_Click(object sender, EventArgs e)
        {
            // create instance of the openFileDialog class 
            OpenFileDialog theDialog = new OpenFileDialog();

            // set the InitialDirectory property of the openFileDialog = '.'
            theDialog.InitialDirectory = ".";

            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                // StreamReader method to read the input file 
                using (StreamReader sr = new StreamReader(theDialog.FileName))
                {
                    String s;
                    s = sr.ReadLine();   // first read 

                    //reset the list
                    i = 0;
                    fileContent.Clear();
                    try
                    {
                        // if the file is not empty 
                        while (s != null)
                        {
                            // add the content to the list and parse it
                            fileContent.Add(Double.Parse(s));
                            s = sr.ReadLine();    // second read 
                        }

                    } catch (FormatException)
                    {
                        // if the user select a wrong type file 
                        MessageBox.Show("Please Enter a valid file with a valid data.");
                        i = 0;
                        fileContent.Clear();   // empty the list again
                    }// end of catch 

                } // end StreamReader ()

            } // end of if 

        } // end of ChooseAFile_Click () method 

/******************************************************
 * Function: ValueFromFile_Click ()                   *
 * Purpose: this function store each value in the list*
 *          in a variable and add the value of that   *
 *          variable to the chart.                    *
 * ***************************************************/

        private void ValueFromFile_Click(object sender, EventArgs e)
        {
            double fileValue;

            if (i < fileContent.Count)
            {
                // store each value in the list in fileValue
                fileValue = fileContent[i];
                i++;
                // AddY function already generate a x value and assign y value to it
                chart1.Series[0].Points.AddY(fileValue);
          
            } // end of if 
            else
            {
                // when there is no more values in the file 
                MessageBox.Show("File is empty. All points are added to the chart");
            }
        } // end of ValueFromFile_Click()

/***************************************************
 * Function: ValueFromUser ()                      *
 * Purpose: this function allows the user to add   *
 *          values to the chart.The user will enter*
 *          the value in the text box. The value   *
 *          then will get parsed and added to the  *
 *          chart.                                 *
 * ************************************************/

        private void ValueFromUser_Click(object sender, EventArgs e)
        {
            double userValue;

            // parse the value from the user and save it to userValue 
            if (double.TryParse(numberTextBox.Text, out userValue))
            {
                // add the values from the user to the chart
                chart1.Series[0].Points.AddY(userValue);
            }
            else
            {
                // the user does not enter a valid value 
                MessageBox.Show("Please enter a valid number.");
            }

        } // end of ValueFromUser_Click () 

/****************************************************
 * Function: ValueAtRandom_Click ()                 *
 * Purpose: this function will generate a random    *
 *          number and add them to the chart.       *
 * *************************************************/

        private void ValueAtRandom_Click(object sender, EventArgs e)
        {
            double ranNum;

            // create instance of the Random class 
            Random randomNum = new Random();

            // generate random numbers between 0 and 30 and store it in ranNum
            ranNum = randomNum.Next(0, 30);

            // add the generated numbers as points 
            chart1.Series[0].Points.AddY(ranNum);
            
        } // end of ValueAtRandom () method 

    } // end of class Form1

} // end of Assign4 namespace 
