using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 單位轉換器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn公分轉英吋_Click(object sender, EventArgs e)
        {
            if (txt公分.Text != "")//如果文字方塊txt公分不等於空值
            {
                try { //例外處理try、catch
                    string strInput1 = txt公分.Text;
                float mycm = 0.0F;
                float myinch = 0.0F;

                mycm = System.Convert.ToSingle(strInput1);
                myinch = mycm * 0.3937f;
                txt英吋.Text = Convert.ToString(myinch);
                }

                catch(Exception error) 
                {
                    MessageBox.Show(error.Message);
                    txt公分.Clear();
                }
            }
            else 
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btn英吋轉公分_Click(object sender, EventArgs e)
        {
            if (txt英吋.Text != "")
            {
                try
                {
                    string strInput2 = txt英吋.Text;
                    float mycm = 0.0F;
                    float myinch = 0.0F;

                    myinch = System.Convert.ToSingle(strInput2);
                    mycm = myinch * 2.54f;
                    txt公分.Text = Convert.ToString(mycm);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    txt英吋.Clear();
                }

            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btn坪轉平方公尺_Click(object sender, EventArgs e)
        {
            if (txt坪.Text != "")
            {
                try
                {
                    string strInput3 = txt坪.Text;
                    double myping = 0.0;
                    double mymtwo = 0.0;

                    myping = System.Convert.ToDouble(strInput3);
                    mymtwo = myping * 3.3058;
                    txt平方公尺.Text = System.Convert.ToString(mymtwo);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    txt坪.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btn平方公尺轉坪_Click(object sender, EventArgs e)
        {
            if (txt平方公尺.Text != "")
            {
                try
                {
                    string strInput4 = txt平方公尺.Text;
                    double myping = 0.0;
                    double mymtwo = 0.0;

                    mymtwo = System.Convert.ToDouble(strInput4);
                    myping = mymtwo * 0.3025;
                    txt坪.Text = System.Convert.ToString(myping);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    txt平方公尺.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btn公斤轉磅_Click(object sender, EventArgs e)
        {
            if (txt公斤.Text.Length > 0)
            {       
                double mykg,mybong = 0.0;
                bool is轉換成功 = false;

                is轉換成功 = Double.TryParse(txt公斤.Text, out mykg);
                
                if(is轉換成功) 
                {
                    mybong = mykg * 2.20462;
                    txt磅.Text = string.Format("{0:F2}", mybong);
                    
                }
                else
                {
                    MessageBox.Show("輸入數值有誤，請重新輸入");
                    txt公斤.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btn磅轉公斤_Click(object sender, EventArgs e)
        {
            if (txt磅.Text != "")
            {
                try
                {
                    string strInput6 = txt磅.Text;
                    double mykg = 0.0;
                    double mybong = 0.0;

                    mybong = System.Convert.ToDouble(strInput6);
                    mykg = mybong * 0.453592;
                    txt公斤.Text = System.Convert.ToString(mykg);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    txt磅.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }
    }
}
