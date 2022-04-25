using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalc
{
    public partial class BMICalc : Form
    {

        //Global variables
        static string name, email, address, phone;
        static double feet, feetConvertedToInches, inches, inchesMultiplied, cmToMeters, metersMultiplied, sumOfConvertedFeetAndInches;


        static double weight, weightSumKG, weightSumLB, englishBMI, metricBMI;

        public BMICalc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            feet = Int32.Parse(msktxtHeightFeet.Text);
            inches = Int32.Parse(msktxtInches.Text);
            weight = Int32.Parse(msktxtWeight.Text);

            if(rdbtnEnglishMeasurements.Checked == true)
            {
                //convert feet to inches
                feetConvertedToInches = feet * 12;

                //add converted feet to inches and multiple by 2
                sumOfConvertedFeetAndInches = feetConvertedToInches + inches;
                inchesMultiplied = sumOfConvertedFeetAndInches * sumOfConvertedFeetAndInches;

                //calculate BMI and set to txtYourBMI
                englishBMI = weight / inchesMultiplied * 703;
                txtYourBMI.Text = englishBMI.ToString();

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

                //multiple meters 
                metersMultiplied = cmToMeters * cmToMeters;

                //calculate metric BMI and show in txtYourBMI
                metricBMI = weight / metersMultiplied;
                metricBMI = Math.Round(metricBMI, 0);
                txtYourBMI.Text = metricBMI.ToString();


            }

        }
    }
}
