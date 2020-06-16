using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08__PA09_QingLiang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            try
            {
                double AmountEntered;
                double convertedvalue;
                //checking for null values
                if ((rb_USdollars.Checked == false) || (rb_JapaneseYen.Checked == false))
                {
                    txt_convertedAmt.Text = "Select atleast one type of currency to convert";
                }
                //convert SGD to US dollars
                if (rb_USdollars.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 0.74;
                    txt_convertedAmt.Text = convertedvalue.ToString();
                }
                else if (rb_JapaneseYen.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 81.97;
                    txt_convertedAmt.Text = convertedvalue.ToString();
                }
            }
            

            catch (Exception)
            {
                txt_convertedAmt.Text = "Please enter a valid amount";
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_amount.Clear();
            txt_convertedAmt.Clear();
            rb_USdollars.Checked = false;
            rb_JapaneseYen.Checked = false;
        }
    }
}
