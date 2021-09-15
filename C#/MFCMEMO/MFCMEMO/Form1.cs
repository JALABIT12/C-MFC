using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFCMEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            string s1 = tbMemo1.Text;
            //Console.WriteLine(s1.ToLower());
            tbMemo2.Text = s1.ToLower();

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            string s1 = tbMemo1.Text;
            //Console.WriteLine(s1.ToUpper());
            tbMemo2.Text = s1.ToUpper();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            /*CString cstr, cs, cs1;
            CMemo1.GetWindowTextA(cstr);
            char* str = cstr.GetBuffer();  // 1 l I |
            for (int i = 0; *(str + i); i++) //i<strlen(str)      for (int i = 0; str[i]!=0; i++) *==[]
            {
                //CString class를 이용한 경우
                cs1.Format("%02X ", (unsigned char)str[i]);
            if (i % 16 == 0) cs += "\r\n"; // 16문자마다 줄바꿈
            cs += cs1;
        }

            CMemo2.SetWindowTextA(cs);*/
        }

        private void btnT_Click(object sender, EventArgs e)
        {

            //string hex = tbMemo1.Text;
            //tbMemo2.Text = Convert.ToString(hex,16);
            byte[] ASCIIVal = Encoding.ASCII.GetBytes(tbMemo1.Text);
            Array.Reverse(ASCIIVal);
            tbMemo2.Text = string.Empty;
            foreach(byte btVal in ASCIIVal)
            {
                tbMemo2.Text += String.Format("{0:x} \n", Convert.ToString(btVal, 16));
      
            }
        }
    }
}
