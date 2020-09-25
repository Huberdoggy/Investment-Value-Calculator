/*
 * AUTHOR: Kyle Huber
 * DATE: 09/21/2020
 * DESCRIPTION: A simple calculator which will determine the performance rate of
 * a given stock based on user specified values. The program can calculate the
 * criteria for: 6 month, 1 year, 2 year, or 5 year terms.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investment_Value_Calculator
{
    public partial class InvestmentValueCalculator : Form
    {
       

        /*Declare an empty private field var to store overall return - 
         * generated after clicking submit with information 
         * provided from the respective groupbox calculations*/

      

        private string stockName = "";
        private string stockSymbol = "";
        private double cost_perShare = 0;
        private int desired_amt = 0;
        private int anticipated_arr = 0;
        private double begVal = 0;
        private double endVal = 0;
        private double overall_return = 0;


        //Make num of years a floating point due to 6 month calculation being equal to 0.5 yrs
        private double num_ofYears = 0;


        public InvestmentValueCalculator()
        {
            InitializeComponent();
            

        }

        private void submitInfoBtn_Click(object sender, EventArgs e)
        {

            stockName = stockNameTxtBox.Text;
            stockSymbol = stockSymbolTxtBox.Text;
           

            //Init some try catches

            try
            {
                cost_perShare = double.Parse(costPerShareTxtBox.Text);
            }
            catch
            {
                resultsGroupBox.Enabled = false;
                MessageBox.Show("Please enter a valid whole or fractional number.");
            }
            try
            {
                desired_amt = int.Parse(desiredNumSharesTxtBox.Text);
                //Make sure they enter the correct numeric type. No 'share portions'

            }
            catch
            {
                resultsGroupBox.Enabled = false;
                MessageBox.Show("Enter 'shares' as an integer whole number.");
            }

            try
            {
                //Make sure they enter the correct numeric type
                anticipated_arr = int.Parse(anticipatedARRTxtBox.Text);

                /* Perform the initial calculations to avoid redundancy
               * when user chooses the specific term later on
               *Use formula ((End val - start val) / start val))
               * Reassign field var value based on new calculation*/

                //Calc the beginning value
                begVal = cost_perShare * desired_amt;
               //Calc the ending value based on initial investment plus anticipated return
               //The anticipated ARR box is set for int so the result must be divided by 100*/

                endVal = (begVal * anticipated_arr / 100) + begVal;
                
                //Finally, subtract the beginning from the ending and divide the result by the beginning value
                overall_return = (endVal - begVal) / begVal;

                MessageBox.Show("Thankyou, your data has been saved successfully. Please proceed to choose an option below.");
                // Toggle the Results group box active
                resultsGroupBox.Enabled = true;


                //Perform calculation to output in the total avg annual return txt box
                totalAvgTxtBox.Visible = true;

                num_ofYears = 5;
                //Calc the return (as a float)
                double five_yearAvg = Math.Pow(1 + overall_return, 1 / num_ofYears) - 1;

                //Multiply the 5 year return rate by the beginning amount

                double out_five_yearAvg = (five_yearAvg * begVal) + begVal;

                //Calculate the total avg rate of return based on the preceding data
                out_five_yearAvg = out_five_yearAvg / begVal;

                double tot_AvgReturn = Math.Pow(out_five_yearAvg, 1 / num_ofYears) - 1;

                //Send it
                totalAvgTxtBox.Text = ("The total average annual return over 5 years on your " + begVal.ToString("C") + " investment in: "
                    + stockName + ", " + stockSymbol + " is " + tot_AvgReturn.ToString("P"));            }
            catch
            {
                resultsGroupBox.Enabled = false;
                MessageBox.Show("Enter ARR as an integer whole number. Auto conversion to percentage will be done for you.");
            }



       
    }

        private void after_6Btn_Click_1(object sender, EventArgs e)
        {
            //Reassign val for num of years
            num_ofYears = 0.5;
            //Calc the return for THIS period (as a float)
            double val6 = Math.Pow(1 + overall_return, 1 / num_ofYears) - 1;
            
            //Multiply the return for THIS period by the beginning amount and show the reflected change in the textbox
            double out6 = (val6 * begVal) + begVal;

            calcValueTxtBox.Text = ("The " + num_ofYears + " year return on your " + begVal.ToString("C") + " investment in: " + stockName + ", " + stockSymbol + " is " + val6.ToString("P") +
                " which would value your investment at " + out6.ToString("C"));

        }

        private void after_1Btn_Click(object sender, EventArgs e)
        {
            //Reassign val for num of years
            num_ofYears = 1;
            //Calc the return for THIS period (as a float)
            double val1 = Math.Pow(1 + overall_return, 1 / num_ofYears) - 1;

            //Multiply the return for THIS period by the beginning amount and show the reflected change in the textbox

            double out1 = (val1 * begVal) + begVal;

            calcValueTxtBox.Text = ("The " + num_ofYears + " year return on your " + begVal.ToString("C") + " investment in: " + stockName + ", " + stockSymbol + " is " + val1.ToString("P") +
                " which would value your investment at " + out1.ToString("C"));
        }

        private void after_2Btn_Click(object sender, EventArgs e)
        {
            //Reassign val for num of years
            num_ofYears = 2;
            //Calc the return for THIS period (as a float)
            double val2 = Math.Pow(1 + overall_return, 1 / num_ofYears) - 1;

            //Multiply the return for THIS period by the beginning amount and show the reflected change in the textbox

            double out2 = (val2 * begVal) + begVal;

            calcValueTxtBox.Text = ("The " + num_ofYears + " year return on your " + begVal.ToString("C") + " investment in: " + stockName + ", " + stockSymbol + " is " + val2.ToString("P") +
                " which would value your investment at " + out2.ToString("C"));
        }

        private void after_5Btn_Click(object sender, EventArgs e)
        {
            //Reassign val for num of years
            num_ofYears = 5;
            //Calc the return for THIS period (as a float)
            double val5 = Math.Pow(1 + overall_return, 1 / num_ofYears) - 1;

            //Multiply the return for THIS period by the beginning amount and show the reflected change in the textbox

            double out5 = (val5 * begVal) + begVal;

            calcValueTxtBox.Text = ("The " + num_ofYears + " year return on your " + begVal.ToString("C") + " investment in: " + stockName + ", " + stockSymbol + " is " + val5.ToString("P") +
                " which would value your investment at " + out5.ToString("C"));
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Clear everything or hit ESC
            calcValueTxtBox.Text = "";
            stockNameTxtBox.Text = "";
            stockSymbolTxtBox.Text = "";
            costPerShareTxtBox.Text = "";
            desiredNumSharesTxtBox.Text = "";
            anticipatedARRTxtBox.Text = "";
            totalAvgTxtBox.Text = "";
            stockNameTxtBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Close the program or ALT+X
            MessageBox.Show("Have a great day!");
            this.Close();
            
        }
    }
}