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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"data source=.\sqlexpress;attachdbfilename=|datadirectory|\truemilk.mdf;integrated security=true;user instance=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            string datefrom1 = dateTimePicker1.Value.ToShortDateString();
            Console.WriteLine(datefrom1);
            string dateto1 = dateTimePicker2.Value.ToShortDateString();
            Console.WriteLine(dateto1);
            string datefrom2 = dateTimePicker3.Value.ToShortDateString();
            Console.WriteLine(datefrom2);
            string dateto2 = dateTimePicker4.Value.ToShortDateString();
            Console.WriteLine(dateto2);
            string datefrom3 = dateTimePicker5.Value.ToShortDateString();
            Console.WriteLine(datefrom3);
            string dateto3 = dateTimePicker6.Value.ToShortDateString();
            Console.WriteLine(dateto3);


            if (radioButton1.Checked == true)
            {
                try
                {
                    CrystalReport1 cr = new CrystalReport1();

                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT [MemberCode],[MemberName],[MemberFHName],[MemberDOB],[MemberAdhar],[MemberBank],[MemberIfsc],[MemberAccount],[MemberMobile],m11,m21,m31,isnull(m11,0)+isnull(m21,0)+isnull(m31,0) as IncentiveAmt from ( SELECT [MemberCode],[MemberName],[MemberFHName],[MemberDOB],[MemberAdhar],[MemberBank],[MemberIfsc],[MemberAccount],[MemberMobile],sum([IncentiveAmt]) as m,'m3' + CAST(ROW_NUMBER() over (Partition By MemberCode Order By MemberCode)as Varchar(10)) as ColumnSequence FROM [NewIncentive] WHERE [coll_date] between '" + datefrom3 + "' and '" + dateto3 + "' GROUP BY  [MemberCode],[MemberName],[MemberFHName],[MemberDOB],[MemberAdhar],[MemberBank],[MemberIfsc],[MemberAccount],[MemberMobile] UNION SELECT [MemberCode],[MemberName],[MemberFHName],[MemberDOB],[MemberAdhar],[MemberBank],[MemberIfsc],[MemberAccount],[MemberMobile],sum([IncentiveAmt]) as m,'m2' + CAST(ROW_NUMBER() over (Partition By MemberCode Order By MemberCode)as Varchar(10)) as ColumnSequence FROM [NewIncentive] WHERE [coll_date] between '" + datefrom2 + "' and '" + dateto2 + "' GROUP BY  [MemberCode],[MemberName],[MemberFHName],[MemberDOB],[MemberAdhar],[MemberBank],[MemberIfsc],[MemberAccount],[MemberMobile] UNION SELECT [MemberCode],[MemberName],[MemberFHName],[MemberDOB],[MemberAdhar],[MemberBank],[MemberIfsc],[MemberAccount],[MemberMobile],sum([IncentiveAmt]) as m,'m1' + CAST(ROW_NUMBER() over (Partition By MemberCode Order By MemberCode)as Varchar(10)) as ColumnSequence FROM [NewIncentive] WHERE [coll_date] between '" + datefrom1 + "' and '" + dateto1 + "' GROUP BY  [MemberCode],[MemberName],[MemberFHName],[MemberDOB],[MemberAdhar],[MemberBank],[MemberIfsc],[MemberAccount],[MemberMobile] )Temp PIVOT ( MAX(m) for ColumnSequence in(m11,m21,m31) ) PIV", con);
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "NewIncentive");
                    cr.SetDataSource(ds.Tables["NewIncentive"]);
                    crystalReportViewer1.ReportSource = cr;
                    crystalReportViewer1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {

                    con.Close();
                }
            }
            if (radioButton2.Checked == true) {
                try
                {
                    CrystalReport2 cr = new CrystalReport2();

                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT [MemberBank],[MemberName],[MemberFHName],[MemberCode],[MemberAccount],[MemberMobile],sum([MilkAmount]) as MilkAmount FROM advicePayment WHERE [coll_date] between '" + datefrom1 + "' and '" + dateto1 + "' GROUP BY [MemberBank],[MemberName],[MemberFHName],[MemberCode],[MemberAccount],[MemberMobile]", con);
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "advicePayment");
                    cr.SetDataSource(ds.Tables["advicePayment"]);
                    crystalReportViewer1.ReportSource = cr;
                    crystalReportViewer1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {

                    con.Close();
                }
                
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
