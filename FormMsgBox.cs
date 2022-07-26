using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace ConnectingAccessCsharp
{
    public partial class formMsgBox : Form
    {
        //color var
        public static int varMsgColorBgR = 0;
        public static int varMsgColorBgG = 0;
        public static int varMsgColorBgB = 0;
        
        //Msg Text
        public static string varMsgText = "";
        public static int varMsgTextLocX = 0;
        public static int varMsgTextLocY = 0;

        //MsgBox Btn Location
        public static int varMsgOkBtnLocationx = 0;
        public static int varMsgOkBtnLocationy = 0;

        //MsgBox Form Size

        public static int varMsgFrmH = 0;
        public static int varMsgFrmW = 0;

        //Logo Lable Loc
        public static int varMsgLogoLocationX = 0;
        public static int varMsgLogoLocationY = 0;

        public formMsgBox()
        {
            InitializeComponent();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormMsgBox_Load(object sender, EventArgs e)
        {
            //form style
            this.Height = varMsgFrmH;
            this.Width = varMsgFrmW;
            this.BackColor = Color.FromArgb(varMsgColorBgR, varMsgColorBgG, varMsgColorBgB);

            //txtMsg
            txtMsgBox.Left = varMsgTextLocX;
            txtMsgBox.Top = varMsgTextLocY;
            txtMsgBox.Text = varMsgText;
            
            //btnOk
            btnMsgBoxOk.Left = varMsgOkBtnLocationx;
            btnMsgBoxOk.Top = varMsgOkBtnLocationy;
            btnMsgBoxOk.BorderColor = Color.FromArgb(varMsgColorBgR, varMsgColorBgG, varMsgColorBgB);

            //Logo
            label3.Left = varMsgLogoLocationX;
            label3.Top = varMsgLogoLocationY;

        }

        private void btnMsgBox_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMsgBoxOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtMsgBox_Click(object sender, EventArgs e)
        {

        }
    }
}
