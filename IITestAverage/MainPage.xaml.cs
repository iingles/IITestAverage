//Name: Isaac Ingles
//Class: INFO 1200
//Section: X01
//Professor: Jensen
//Date: 9/10/2020
//Project #: Participation 5
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IITestAverage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Handle the click event on "BtnAverage".  Use variables to store user
        ///  input, calculate the averaage score, and display results.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAverage_Clicked(object sender, EventArgs e)
        {
            // Variables for test scores and average
            double test1, test2, test3, average;

            // Validation/Error handling - Try the code and catch any errors
            try
            {
                // Store variables from user input - Parse text as a double
                test1 = double.Parse(EntryTest1.Text);
                test2 = double.Parse(EntryTest2.Text);
                test3 = double.Parse(EntryTest3.Text);

                // Calculate average (use parenthesis to ensure desired order of operations)
                average = (test1 + test2 + test3) / 3 / 100;

                // Display results - convert average back to string with a percent sign and 2 decimal places
                LblResults.Text = average.ToString("p2");
            }
            catch
            {   
                //Display an alert if there was an error.
                DisplayAlert("Invalid Input", "Please only enter nubmers for the test scores.", "Close");
            }            

            
        }

        /// <summary>
        ///  Handle the BtnClear button click - clear the user's input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            // Use the ClearValue method to clear the entry
            EntryTest1.ClearValue(Entry.TextColorProperty);
            EntryTest2.ClearValue(Entry.TextColorProperty);
            EntryTest3.ClearValue(Entry.TextColorProperty);

            LblResults.Text = "Results...";
        }
    }
}
