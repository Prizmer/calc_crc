using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CRCCalc;


namespace CtlCrcCalc
{
    public partial class CtlCrcCalc: UserControl
    {
        LibCRC libCrc = new LibCRC();
        private string _inputByteString = "";

        public CtlCrcCalc()
        {
            InitializeComponent();
        }

        private void CtlCrcCalc_Load(object sender, EventArgs e)
        {
            List<string> algList = new List<string>();
            algList = libCrc.GetAlgorithmsList();

            listBoxAlgorithms.Items.AddRange(algList.ToArray());
            listBoxAlgorithms.SelectedIndex = 0;
        }


        public string InputByteString
        {
            get {
                return _inputByteString;
            }
            set
            {
                _inputByteString = value;
            }
        }    

        public List<string> LibAlgorithms
        {
            get
            {
                return libCrc.GetAlgorithmsList();
            }
        }
        public bool LibCalcCRC(string byteString, string algName, ref byte[] resCRC)
        {
            return this.libCrc.GetCRCFromInputString(byteString, algName, ref resCRC);
        }
        public bool LibConvertStringToBytesArr(string byteString, ref byte[] resBytesArr)
        {
            return this.libCrc.ConvertInputStringToByteArray(byteString, ref resBytesArr);
        }

        public bool CalcCRCAndAppend(out string byteString)
        {

            byteString = "Ошибка";

            string algName = "";
            if (listBoxAlgorithms.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                algName = listBoxAlgorithms.Items[listBoxAlgorithms.SelectedIndex].ToString();
            }

            if (_inputByteString.Length == 0)
            {
                return false;
            }

            byte[] bytesArr = null;
            if (!libCrc.ConvertInputStringToByteArray(_inputByteString, ref bytesArr))
            {
                return false;
            }

            byte[] resCrc = null;
            if (!LibCalcCRC(_inputByteString, algName, ref resCrc))
            {
                return false;
            }

            int bsumm = 0;
            foreach (byte cb in resCrc)
            {
                bsumm += cb;
            }

            if (bsumm == 0 && bytesArr[bytesArr.Length - 1] == 0x0)
            {
                byteString = _inputByteString;
                return true;
            }

            List<byte> resCmd = new List<byte>();
            resCmd.AddRange(bytesArr);
            resCmd.AddRange(resCrc);

            byteString = "";
            foreach (byte b in resCmd)
            {
                string s = "";
                if (b < 0x10)
                    s += "0";

                s += Convert.ToString(b, 16);

                byteString += s + " ";
            }
            byteString = byteString.Trim(' ').ToUpper();

            return true;
        }


        private void listBoxAlgorithms_DoubleClick(object sender, EventArgs e)
        {
            string msg = "";
            ListBox lb = (ListBox)sender;
            if (lb.SelectedIndex == -1) return;

            if (_inputByteString.Length == 0)
            {
                msg = "Нет входной строки";
                tbCRC.Text = msg;
                return;
            }


            string algName = lb.Items[lb.SelectedIndex].ToString();
            byte[] resCrc = null;

            if (!libCrc.GetCRCFromInputString(_inputByteString, algName, ref resCrc)
                || resCrc == null
                || resCrc.Length == 0
                )
            {
                msg = "Ошибка";
                tbCRC.Text = msg;
            }
            else
            {
                string crcStr = BitConverter.ToString(resCrc).Replace("-", " ").ToUpper();        
                tbCRC.Text = crcStr;
            }
        }

        private void panelDrop_DragDrop(object sender, DragEventArgs e)
        {
            
            string res = (string)e.Data.GetData(DataFormats.Text);
            lblDropNote.Text = res;
            lblDropNote.ForeColor = Color.DarkGreen;
            InputByteString = res;
        }

        private void panelDrop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDrop_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panelDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
