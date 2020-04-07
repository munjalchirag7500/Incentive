using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Incentive
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"data source=.\sqlexpress;attachdbfilename=|datadirectory|\truemilk.mdf;integrated security=true;user instance=true");
           
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            string mc = codeText.Text;
            string mn = memnbernameText.Text;
            string dob = dateTimePicker1.Value.ToShortDateString();
            string fh = fhnameText.Text;
            string mb = mobileText.Text;
            string adc = aadharText.Text;
            string bank = bankText.Text;
            string ac = accountText.Text;
            string ifsc = ifscText.Text;

            try
            {

                if (incentiveRadioButton.Checked == true)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO NewMember (MemberName,MemberFHName,MemberDOB,MemberAdhar,MemberBank,MemberIfsc,MemberAccount,MemberMobile,MemberCode) VALUES ('" + mn + "','" + fh + "','" + dob + "','" + adc + "','" + bank + "','" + ifsc + "','" + ac + "','" + mb + "', '" + mc + "')", con);

                    int a = cmd.ExecuteNonQuery();
                    MessageBox.Show(a.ToString());
                    reset();
                }
                if (paymentRadioButton.Checked == true)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO PaymentMember (MemberName,MemberFHName,MemberDOB,MemberAdhar,MemberBank,MemberIfsc,MemberAccount,MemberMobile,MemberCode) VALUES ('" + mn + "','" + fh + "','" + dob + "','" + adc + "','" + bank + "','" + ifsc + "','" + ac + "','" + mb + "', '" + mc + "')", con);

                    int a = cmd.ExecuteNonQuery();
                    MessageBox.Show(a.ToString());
                    reset();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }
        }

        private void mobileText_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }
        public void reset()
        {

            codeText.Text = "";
            memnbernameText.Text = "";
            fhnameText.Text = "";
            mobileText.Text = "";
            accountText.Text = "";
            aadharText.Text = "";
            bankText.Text = "";
            ifscText.Text = "";
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
