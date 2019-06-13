using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace crcCalc
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
   
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string target = richTextBox1.Text;
            ctlCrcCalc1.InputByteString = target;
            ctlCrcCalc1.CalcCRCAndAppend(out target);
            richTextBox1.Text = target;
        }
    }
}
