using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myNotepad
{
    public partial class Form2 : Form
    {
        public Form2()  //생성자
        {
            InitializeComponent();

            cbStopbit.Items.Add("1");
            cbStopbit.Items.Add("2");
        }
    }
}
