using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BMICalc
{
    public partial class BMICalc : Form
    {

        //Global variables
        static string firstName, lastName, email, address, phone;
        static double feet, feetConvertedToInches, inches, inchesMultiplied, cmToMeters, metersMultiplied, sumOfConvertedFeetAndInches;
        static double weight, englishBMI, metricBMI, recommendedBMI, everyInchOverFiveFeet, additionalWeight, metersToFeet;

        private void btnContactInfo_Click(object sender, EventArgs e)
        {
            frmPhoneAndAddress addPhoneAndAddress = new frmPhoneAndAddress();
            addPhoneAndAddress.Show();

        }

        
        private void BMICalc_Load(object sender, EventArgs e)
        {
            frmPhoneAndAddress.AddPhoneAndAddress += AddPhoneAndAddressToReport;

        }

        
        public BMICalc()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                feet = Int32.Parse(msktxtHeightFeet.Text);
                inches = Int32.Parse(msktxtInches.Text);
                weight = Int32.Parse(msktxtWeight.Text);

                if (rdbtnEnglishMeasurements.Checked == true)
                {
                    //convert feet to inches
                    feetConvertedToInches = feet * 12;

                    //add converted feet to inches and multiple by 2
                    sumOfConvertedFeetAndInches = feetConvertedToInches + inches;
                    inchesMultiplied = sumOfConvertedFeetAndInches * sumOfConvertedFeetAndInches;

                    //calculate BMI, round it and set to txtYourBMI
                    englishBMI = weight / inchesMultiplied * 703;
                    englishBMI = Math.Round(englishBMI, 0);
                    txtYourBMI.Text = englishBMI.ToString();

                    //Recommended BMI = 105 lbs + 5 lbs per every inch over 5 ft
                    everyInchOverFiveFeet = sumOfConvertedFeetAndInches - 60;
                    additionalWeight = everyInchOverFiveFeet * 5;

                    //calculate recommended BMI
                    recommendedBMI = 105 + additionalWeight;
                    txtRecommendedBMI.Text = "Adults are recommended to have a BMI between 19 and 25. Your ideal weight for this is " + recommendedBMI;

                }
                else if (rdbtnMetricMeasurements.Checked == true)
                {
                    //change layout of form to show metric measurements and hide the inches label and textbox
                    msktxtInches.Enabled = false;
                    lblInches.Enabled = false;
                    lblFeet.Text = "cm.";
                    lblWeight.Text = "kg.";

                    //convert cm to meters
                    cmToMeters = feet * 0.01;

                    //multipy meters 
                    metersMultiplied = cmToMeters * cmToMeters;

                    //calculate metric BMI, round it, and show in txtYourBMI
                    metricBMI = weight / metersMultiplied;
                    metricBMI = Math.Round(metricBMI, 0);
                    txtYourBMI.Text = metricBMI.ToString();

                    //Recommended BMI = 50 kgs + 2 kgs per every inch over 5 ft
                    //convert meters  to feet
                    metersToFeet = cmToMeters * 3;

                    //subtract 60 inches (5ft) from total height
                    everyInchOverFiveFeet = metersToFeet - 60;

                    //multiply left over height by 2 to get additional weight
                    additionalWeight = everyInchOverFiveFeet * 2;

                    //add 50 kg with additional weight
                    recommendedBMI = 50 + additionalWeight;
                    txtRecommendedBMI.Text = "Adults are recommended to have a BMI between 19 and 25. Your ideal weight for this is " + recommendedBMI;

                }

                WriteReport();

                msktxtHeightFeet.Clear();
                msktxtInches.Clear();
                msktxtWeight.Clear();
            }
            catch(Exception errorMessage)
            {
                MessageBox.Show("Please make sure you entered your information correctly. Your error was: \n" + errorMessage);
            }

        }

        private void EnglishBMICalculation()
        {
            throw new NotImplementedException();
        }

        private void WriteReport()
        {
            StreamWriter bmiReport = new StreamWriter("BMIreport.txt");

            //variables
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            email = txtEmail.Text;


            bmiReport.WriteLine(DateTime.Now);
            bmiReport.WriteLine();
            bmiReport.WriteLine("BMI Report for " + firstName + " "+ lastName);
            bmiReport.WriteLine();
            bmiReport.WriteLine("Email: " + email);
            bmiReport.WriteLine();

            if (phone != null)
            {
                bmiReport.WriteLine("Phone: " + phone);
                bmiReport.WriteLine();

            }
            
            if (address != null)
            {
                bmiReport.WriteLine("Address: " + address);
            }

            if(rdbtnEnglishMeasurements.Checked ==true)
            {
                bmiReport.WriteLine("Your BMI index is " + englishBMI);
            }
            else if(rdbtnMetricMeasurements.Checked == true)
            {
                bmiReport.WriteLine("Your BMI index" + metricBMI);
            }

            bmiReport.WriteLine();
            bmiReport.WriteLine("About IWishICouldLoseWeight.com:");
            bmiReport.WriteLine("    We are a small company attempting to help those who are frustrated with trying to lose weight.  Call us, we eat too and can help you.  ");

            bmiReport.Close();

        }


        private void AddPhoneAndAddressToReport(string phoneFromForm, string addressFromForm)
        {
            phone = phoneFromForm;
            address = addressFromForm;
        }
    }
}
