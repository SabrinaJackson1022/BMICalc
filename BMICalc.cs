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
        static double feet, feetConvertedToInches, inches, sumOfConvertedFeetAndInches;
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
                //multiple feet total and inches together
                sumOfConvertedFeetAndInches = feetConvertedToInches * inches;
                //calculate BMI and set to txtYourBMI
                englishBMI = weight / sumOfConvertedFeetAndInches * 703;
                txtYourBMI.Text = englishBMI.ToString();

            }

        }
    }
}
