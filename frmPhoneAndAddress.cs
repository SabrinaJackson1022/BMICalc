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
    public partial class frmPhoneAndAddress : Form
    {
        public static event Action<string, string> AddPhoneAndAddress;


        public frmPhoneAndAddress()
        {
            InitializeComponent();
        }

        private void btnAddPhoneAndAddress_Click(object sender, EventArgs e)
        {
            AddPhoneAndAddress.Invoke(msktxtPhone.Text, txtAddress.Text);

            this.Close(); 
        }
    }
}
