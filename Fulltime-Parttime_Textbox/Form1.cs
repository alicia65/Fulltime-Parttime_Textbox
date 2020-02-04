using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulltime_Parttime_Textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhatStatus_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCredits.Text, out double credits)) 
            {
                //figure out status
                if(credits >= 12) 
                {
                    lblStatus.Text = "Full time";//status textbox displays full time
                }
                else if (credits >= 6)
                {
                    lblStatus.Text = "Half time";
                }
                if (credits >= 0)
                {
                    lblStatus.Text = "Less than half time";
                }
                else
                {
                    MessageBox.Show("Enter as positive number", "Error");//messageBox shows message if user entered negative numbers or letters
                }
            }
            else 
            {
                MessageBox.Show("Enter a number", "Error");
            }
        }
    }
}
