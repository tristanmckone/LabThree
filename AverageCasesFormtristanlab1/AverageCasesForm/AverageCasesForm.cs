/// Tristan Mckone Lab
/// 2021-06-26
/// This program builds on lab 1 which takes an input of 7 days case total and then displays the average. 
/// It does this 3 times then shows a total average of all 3.





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageCasesForm
{
    public partial class formAverageCases : Form
    {
        // Declare class level variables
        int currentDay = 0;
        int currentRegion = 0;
        
        const int NumberofRegions = 3;
        const int NumberofDays = 7;
        // 2D array of all recorded cases
        int[,] cases = new int[NumberofRegions,NumberofDays];

        // Arrays of controls of the form.
        TextBox[] textBoxCaseLists;
        Label[] labelAverages;
        // intalizes the form and its controls into arrays.
        public formAverageCases()
        {
            InitializeComponent();

            textBoxCaseLists = new TextBox[] { textBoxRegion1, textBoxRegion2, textBoxRegion3 };
            labelAverages = new Label[] { labelRegion1Average, labelRegion2Average, labelRegion3Average };
        }
        /// <summary>
        /// This button exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Clears all fields and resets the form to default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetClick(object sender, EventArgs e)
        {
            SetDefaults();
                    
        }
        /// <summary>
        /// Accepts a value, when valid records and adds value to running total. Creates average after all cases are entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterClick(object sender, EventArgs e)
        {
            // Use constant for numbers of days.
            const int NumberOfDays = 7;
            // Store users last input in variable.
            int enteredCases;

            // If the textbox contains number, validate number(Range,positive).
            if (int.TryParse(textBoxCaseEntry.Text, out enteredCases))
            {
                //If true, increment cases based on the input.
                if (enteredCases >= 0 && enteredCases <= int.MaxValue)
                {
                    // Add entered cases into the array
                    cases[currentRegion, currentDay] = enteredCases;
                    // Add entered cases to the correct textbox
                    textBoxCaseLists[currentRegion].Text += enteredCases + Environment.NewLine;
                    // increment day.
                    currentDay++;
                    // When the day reaches 7, do calculation and go to next region.
                    if (currentDay >= NumberOfDays)
                    {
                        // Calculate average for current region, for loop with i as counter.
                        double totalCases = 0;
                        for (int i = 0; i < NumberOfDays; i ++)
                        {
                            // Declare double value to hold number
                            
                            //Adds each total to a running total, as each day is passed in the current region.
                            totalCases += cases[currentRegion, i];
                        }
                        // Use total to calculate and show average.
                        labelAverages[currentRegion].Text = "Average: " + 
                            Math.Round(totalCases / NumberOfDays,2);
                        // Go to next region
                        currentDay = 0;
                        currentRegion++;
                        // When region 3 is reached find average.
                        if (currentRegion >= NumberofRegions)
                        {
                            // Calculate total for all regions
                            //for each loop
                            // use a constant for the number of weeks
                            double overallCases = 0;
                            double realOverallCases = 0;
                            const double ThreeWeeks = 21;
                            
                            foreach (int j in cases)
                            {

                                overallCases += j;
                                

                            }

                            // use the total to calculate and output overall average
                            // round average to 2 decimal places
                            // output average

                            realOverallCases = Math.Round(overallCases/ThreeWeeks,2);
                            

                            labelAverageOutput.Text = realOverallCases.ToString();

                            //disable the input textbox and calculate button.
                            textBoxCaseEntry.Enabled = false;
                            buttonEnter.Enabled = false;
                        }
                        labelDay.Text = "day " + currentDay + 1;
                    }
                    
                }
                // If contents not in range, show error.

                else
                {

                    MessageBox.Show("Your entry must be between 0 and " + int.MaxValue, "Entry Error!");
                    textBoxCaseEntry.SelectAll();
                    textBoxCaseEntry.Focus();
                }
            }
            // The contents is not a whole number, report an error.
            else
            {
                MessageBox.Show("Your entry must be a whole number " , "Entry Error!");
                textBoxCaseEntry.SelectAll();
                textBoxCaseEntry.Focus();
                
                   
            }
        }
        public void SetDefaults()
        {
            //Clear input and output controls
            textBoxCaseEntry.Clear();
            textBoxRegion1.Clear();
            textBoxRegion2.Clear();
            textBoxRegion3.Clear();
            labelRegion1Average.Text = String.Empty;
            labelRegion2Average.Text = String.Empty;
            labelRegion3Average.Text = String.Empty;
            labelAverageOutput.Text = String.Empty;

            // enable any controls that could of been disabled
            textBoxCaseEntry.Enabled = true;
            buttonEnter.Enabled = true;

            //Reset values of class level variables
            currentDay = 0;
            currentRegion = 0;
            

            

            // Set day back to default
            labelDay.Text = "Day " + currentDay + 1;


            //Set focus
            textBoxCaseEntry.Focus();
        }
    }

}
