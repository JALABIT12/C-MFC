﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myNotepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }
        string strOrg="";
        int viewState = 0; // 0:Normal 1:Lower 2:Upper 3:Hexa
        private void mnuViewLower_Click(object sender, EventArgs e)
        {
            if(viewState !=1) //ReadOnly bool값
            {
                if(strOrg=="") strOrg = tbMemo.Text;
                tbMemo.Text = strOrg.ToLower();
                tbMemo.ReadOnly = true; //다음 동작은 true 상태라 되돌아 나간다.
                viewState = 1;
            }
        }

        private void mnuViewUpper_Click(object sender, EventArgs e)
        {
            if (viewState != 2) //ReadOnly bool값
            {
                if (strOrg == "") strOrg = tbMemo.Text;
                tbMemo.Text = strOrg.ToUpper();
                tbMemo.ReadOnly = true;
                viewState = 2;
            }
        }

        private void mnuViewHexa_Click(object sender, EventArgs e)
        {
            if (viewState != 3) //ReadOnly bool값
            {
                if (strOrg == "") strOrg = tbMemo.Text;
                tbMemo.Text = ""; //내용이 아무것도 없어야...

                string s1;
                char[] chr = strOrg.ToCharArray();
                byte[] bArr = Encoding.Default.GetBytes(chr);
                byte[] bAr1 = Encoding.Default.GetBytes(strOrg.ToCharArray()); 

                for (int i=0; i<bArr.GetLength(0); i++)
                {
                    //s1 = string.Format("{0:X} \n", bArr[i]); //printf("%x",n);
                    s1 = $" {bArr[i]:X2}";
                    if (i % 16 == 15) s1 += "\r\n";
                    tbMemo.Text += s1;
                }
                /*tbMemo.Text += "\r\n================================================\r\n";
                int count = 0;
                foreach (byte c in bArr)
                {
                    s1 =$" {c:X2}"; //printf("%x",n);
                    if (count++ % 16 == 15) s1 += "\r\n";
                    tbMemo.Text += s1;
                }*/
                tbMemo.ReadOnly = true;
                viewState = 3; 
            }
        }

        private void mnuViewRefresh_Click(object sender, EventArgs e)
        {
            if(strOrg!="")
            {
                tbMemo.Text=strOrg;
                strOrg = ""; //nullstream
                tbMemo.ReadOnly = false;
                viewState = 0;
            }
           
        }

        private void tbMemo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mnuViewRefresh_Click(sender, e);
            }
        }

        string filePath = "";
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath=openFileDialog.FileName;
                //tbMemo.Text += openFileDialog.FileName;
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                tbMemo.Text = sr.ReadToEnd();
                sr.Close();
            }
                
            
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = Path.GetFileName(filePath); //파일 이름만 추출
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.Write(tbMemo.Text);
                sw.Close();
            }
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = filePath;
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.Write(tbMemo.Text);
                sw.Close();
            }
        }

        // prototype : string GetToken(int n, string str, char d)
        // Argument : 
        //        n : n번째 Item 
        //      str : 문자열
        //        d : 구분자
        // 설명 : 문자열 str에 있는 데이터를 구분자 d를 통해 필드를 구분하여, 그 중 n번째 데이터를 반환
        //  ex) GetToken(1, "a,b,c,d", ',') ===> "b"
        //GetToken 함수를 이용하여 GetFileName 함수를 구현하세요.
        string GetTokenEx(int n, string str, char d)
        {
            int i, j, k,n1,n2; //n1 = start, n2 = end

            for (i = j = k = n1 = n2 = 0; i < str.Length; i++)
            {
                if (str[i] == d) k++; //구분자와 같은 위치에서 만나면 k 증가
                if (k == n) n1 = i; //찾고자하는 구분자의 위치에 도달하면 그 해당 위치를 기록
                if (k == n + 1) n2 = i; // 그 다음에 발견하면 2번째 위치를 기억
                                        // n1과 n2 사이가 우리가 찾고자하는 위치
                                        //모든 구분자의 개수를 k에 기억
                                        // 4가 나올 수 없으므로 or 나쁜 사용자 4입력시
            }
            if (n1 == 0) return "";
            if (n2 == 0) n2 = str.Length+1;
            return str.Substring(n1,n2-1-n1); //n2-n1-1=length 구분자는 빼고 복사: n2-1
        }
        string GetToken(int n, string str, char d)
        {
            string[] sArr = str.Split(d);
            if(n < sArr.Length) return sArr[n]; //임계조건 체크필수
            return "";
        }
        void AddLine(string str)
        {
            tbMemo.Text += str + "\r\n";
        }
        int num = 0;
        private void mnuEditTest_Click(object sender, EventArgs e)
        {
            AddLine($"{GetToken(num++, " a,b,c,d", ',')}");
            //tbMemo.Text += $"{GetToken(num++, " a,b,c,d", ',')}\r\n";
        }

        private void mnuEditCallTest_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            if(dlg.ShowDialog() == DialogResult.OK) //COM1:9600N81
            {
                //string str= (dlg.rbCom1.Checked)? "COM1:": "COM2:";
                //string str; =>동일한 문장
                //if (dlg.rbCom1.Checked) str += "COM1:";
                //else if (dlg.rbCom2.Checked) str += "COM2:";
                //else str="XXXX:";
                string str = (dlg.rbCom1.Checked) ? "COM1:" :
                             (dlg.rbCom2.Checked) ? "COM2:" : "XXX"; //3개인 경우

                str += dlg.cbSpeed.Text;
                str += dlg.cbParity.Text.Trim().ToUpper()[0]; //None, Odd, Even
                //trim:공백X, ToUpper:대문자 변환 [0]: 제일 앞 한글자만 가져오도록 설정
                str += dlg.cbDatabit.Text;
                str += dlg.cbStopbit.Text;
                //AddLine(str);
                //tbMemo.Text += str + "\r\n";
                sbLabel1.Text = str;
            }
        }
    }
}
