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
    public partial class Form2 : Form
    {   
                SqlConnection con = new SqlConnection(@"data source=.\sqlexpress;attachdbfilename=|datadirectory|\truemilk.mdf;integrated security=true;user instance=true");
                
        public Form2()
        {
            InitializeComponent();
            button2.Enabled = false;
            resetButton.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void codeText_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void aadharText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (incentiveRadioButton.Checked == true)
            {
                try
                {
                    String mc = codeText.Text;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM NewMember WHERE [MemberCode] ='" + mc + "' ", con);
                    DataSet ds = new DataSet();
                    SqlDataReader dr = cmd.ExecuteReader();


                    if (dr.Read())
                    {

                        memnbernameText.Text = (dr["MemberName"].ToString());
                        fhnameText.Text = (dr["MemberFHName"].ToString());
                        mobileText.Text = (dr["MemberMobile"].ToString());
                        accountText.Text = (dr["MemberAccount"].ToString());
                        aadharText.Text = (dr["MemberAdhar"].ToString());
                        bankText.Text = (dr["MemberBank"].ToString());
                        ifscText.Text = (dr["MemberIfsc"].ToString());


                        string dd = (dr["MemberDOB"].ToString());

                        if (dd == "")
                        {

                            MessageBox.Show("Date Of Birth Empty ");
                        }
                        else
                        {
                            dateTimePicker1.Value = (DateTime)(dr["MemberDOB"]);
                        }
                        button2.Enabled = true;
                        resetButton.Enabled = true;
                        codeText.Enabled = false;

                    }
                    else
                    {

                        MessageBox.Show("Member Not Found");

                    }


                }

                catch (Exception exx)
                {
                    MessageBox.Show(exx.ToString());

                }
                finally
                {
                    con.Close();

                }
            }

            if (paymentRadioButton.Checked == true) {

                try
                {
                    String mc = codeText.Text;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM PaymentMember WHERE [MemberCode] ='" + mc + "' ", con);
                    DataSet ds = new DataSet();
                    SqlDataReader dr = cmd.ExecuteReader();


                    if (dr.Read())
                    {

                        memnbernameText.Text = (dr["MemberName"].ToString());
                        fhnameText.Text = (dr["MemberFHName"].ToString());
                        mobileText.Text = (dr["MemberMobile"].ToString());
                        accountText.Text = (dr["MemberAccount"].ToString());
                        aadharText.Text = (dr["MemberAdhar"].ToString());
                        bankText.Text = (dr["MemberBank"].ToString());
                        ifscText.Text = (dr["MemberIfsc"].ToString());


                        string dd = (dr["MemberDOB"].ToString());

                        if (dd == "")
                        {

                            MessageBox.Show("Date Of Birth Empty ");
                        }
                        else
                        {
                            dateTimePicker1.Value = (DateTime)(dr["MemberDOB"]);
                        }
                        button2.Enabled = true;
                        resetButton.Enabled = true;
                        codeText.Enabled = false;

                    }
                    else
                    {

                        MessageBox.Show("Member Not Found");

                    }


                }

                catch (Exception exx)
                {
                    MessageBox.Show(exx.ToString());

                }
                finally
                {
                    con.Close();

                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
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
                        SqlCommand cmd = new SqlCommand("UPDATE NewMember set MemberName='" + mn + "', MemberFHName='" + fh + "', MemberDOB='" + dob + "',MemberAdhar='" + adc + "',MemberBank='" + bank + "',MemberIfsc='" + ifsc + "',MemberAccount='" + ac + "',MemberMobile='" + mb + "'  WHERE MemberCode='" + mc + "'  ", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated");
                        reset();
                    
                    }
                    if (paymentRadioButton.Checked == true) {

                        SqlCommand cmd = new SqlCommand("UPDATE PaymentMember set MemberName='" + mn + "', MemberFHName='" + fh + "', MemberDOB='" + dob + "',MemberAdhar='" + adc + "',MemberBank='" + bank + "',MemberIfsc='" + ifsc + "',MemberAccount='" + ac + "',MemberMobile='" + mb + "'  WHERE MemberCode='" + mc + "'  ", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated");
                        reset();
                    
                    }
                
                

            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.Message);
            }
            finally {
                con.Close();
            
            }
        }

        private void label4_Click(object sender, EventArgs e)
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

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
            
        }

        public void reset() {

            codeText.Text = "";
            memnbernameText.Text = "";
            fhnameText.Text = "";
            mobileText.Text = "";
            accountText.Text = "";
            aadharText.Text = "";
            bankText.Text = "";
            ifscText.Text = "";
            codeText.Enabled = true;
            button2.Enabled = false;
            resetButton.Enabled = false;
            
        
        }
        
    }
}
