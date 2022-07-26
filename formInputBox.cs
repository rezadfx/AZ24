using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text;

namespace ConnectingAccessCsharp
{
    public partial class formInputBox : Form
    {


        OleDbConnection conn;
        // =======================================================================
        // =======================================================================
        // ==============================Functions================================

        //******* Connect Function **********
        public void ConnectToDB()
        {
            // ApplicationEXEPath\Test.mdb
            var DBPath = AZ24.Properties.Settings.Default.DataBaseRoot;
            conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" + DBPath);
            conn.Open();
        }




        // =======================================================================
        // =======================================================================
        // =======================================================================



        //checkbox var
        public static string varCheckBoxChoice = "";

        //count down var
        public static int varCountDown = 3;

        //form color var
        public static int varInputBoxColorBgR = 0;
        public static int varInputBoxColorBgG = 0;
        public static int varInputBoxColorBgB = 0;

        //Buttons Color / text
        public static string varbtnMsgBoxButton = "";
        public static string varbtnMsgBoxCancel = "Cancel";

        public formInputBox()
        {
            InitializeComponent();
        }

        private void formInputBox_Load(object sender, EventArgs e)
        {
            //form style
            this.Height = 210;
            this.BackColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);

            //button texts/style 
            btnMsgBoxButton.Text = varbtnMsgBoxButton;
            btnMsgBoxCancel.Text = varbtnMsgBoxCancel;
            btnMsgBoxButton.BackColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);
            btnMsgBoxButton.ForeColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);
            btnMsgBoxCancel.BackColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);
            btnMsgBoxCancel.FillColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);

            btnMsgBoxYes.BorderColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);
            btnMsgBoxYes.FillColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);
            btnMsgBoxNo.BorderColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);
            btnMsgBoxNo.ForeColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);

            btnInputBoxEdit.BorderColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);
            btnInputBoxEdit.FillColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);

            //text box color
            txtIDN.FillColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);
            txtIDN.BackColor = Color.FromArgb(varInputBoxColorBgR, varInputBoxColorBgG, varInputBoxColorBgB);

            //label text choice
            if (varbtnMsgBoxButton == "Delete")
            {
                lblInputBox.Text = "Type the ID number to Delete";
            }
            else if (varbtnMsgBoxButton == "Edit")
            {
                lblInputBox.Text = "Type the ID number to Edit";
            }
            else
            {

            }

        }

        private void btnMsgBoxButton_Click(object sender, EventArgs e)
        {
            if (txtIDN.Text != "")
            {
                txtIDN.Enabled = false;
                btnMsgBoxButton.Enabled = false;

                //Delete Sure?
                if (varbtnMsgBoxButton == "Delete")
                {
                    gpboxYesOrNo.Visible = true;
                    this.Height = 367;
                    gpboxYesOrNo.Top = 213;
                    gpboxYesOrNo.Left = -3;
                    timer1.Enabled = true;

                }
                else if (varbtnMsgBoxButton == "Edit")
                {
                    gpboxEditTable.Visible = true;
                    gpboxEditTable.Enabled = true;
                    gpboxEditTable.Top = 209;
                    gpboxEditTable.Left = -1;
                    this.Height = 388;
                }

            }
            else
            {
                //textMsg
                formMsgBox.varMsgText = "ID Field is Empty.";
                formMsgBox.varMsgTextLocX = 83;
                formMsgBox.varMsgTextLocY = 36;

                //Btn Loc
                formMsgBox.varMsgOkBtnLocationx = 117;
                formMsgBox.varMsgOkBtnLocationy = 63;
                //color Bg
                formMsgBox.varMsgColorBgR = 220;
                formMsgBox.varMsgColorBgG = 53;
                formMsgBox.varMsgColorBgB = 53;
                //form size
                formMsgBox.varMsgFrmH = 111;
                formMsgBox.varMsgFrmW = 282;

                //logo location
                formMsgBox.varMsgLogoLocationX = 12;
                formMsgBox.varMsgLogoLocationY = 19;

                //OpenMsgBox
                formMsgBox form = new formMsgBox();
                form.Show();
            }
        }

        private void btnMsgBoxCancel_Click(object sender, EventArgs e)
        {
            this.Height = 210;
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Height = 210;
            this.Hide();
        }

        private void btnMsgBoxNo_Click(object sender, EventArgs e)
        {
            this.Height = 210;
            this.Hide();
        }

        private void btnMsgBoxYes_Click(object sender, EventArgs e)
        {
            
            //delete row
            if (varbtnMsgBoxButton == "Delete")
            {
                string strIDnum = txtIDN.Text;
                string strQuery = "DELETE FROM Protocols WHERE id = " + strIDnum + ";";

                //MessageBox.Show(strQuery);
                //DELETE FROM Table_1 WHERE id = 10;

                ConnectToDB();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = strQuery;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                conn.Close();

            }
            //end delete

            //update
            if (varbtnMsgBoxButton == "Edit")
            {
                string strIDnum = txtIDN.Text;
                string strTXTedit = txtEditboxinput.Text;
                string strQuery = "UPDATE Protocols SET [" + varCheckBoxChoice + "]='" + txtEditboxinput.Text + "' WHERE id=" + strIDnum + ";";

                //MessageBox.Show(strQuery);
                //UPDATE Table_1 SET [text_col]='Updated text', [int_col]=2014 WHERE id=2;

                ConnectToDB();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = strQuery;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            //end Edit

            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = "(" + varCountDown + ")";
            varCountDown = varCountDown - 1;
            if (varCountDown <= -1)
            {
                label5.Text = "";
                timer1.Stop();
                timer1.Enabled = false;
                varCountDown = 3;
                gpboxYesOrNo.Enabled = true;
            }
        }

        private void btnInputBoxEdit_Click(object sender, EventArgs e)
        {
            if(txtEditboxinput.Text != "")
            {
                if (rbProtocol.Checked)
                {
                    varCheckBoxChoice = "Protocol_";
                }
                else if (rdObject.Checked)
                {
                    varCheckBoxChoice = "Object_";
                }

                gpboxYesOrNo.Visible = true;
                this.Height = 367;
                gpboxYesOrNo.Top = 388;
                gpboxYesOrNo.Left = -3;
                timer1.Enabled = true;
                this.Height = 522;
                btnInputBoxEdit.Enabled = false;
            }
            else
            {
                //textMsg
                formMsgBox.varMsgText = "Text Field is Empty.";
                formMsgBox.varMsgTextLocX = 77;
                formMsgBox.varMsgTextLocY = 36;

                //Btn Loc
                formMsgBox.varMsgOkBtnLocationx = 117;
                formMsgBox.varMsgOkBtnLocationy = 63;
                //color Bg
                formMsgBox.varMsgColorBgR = 220;
                formMsgBox.varMsgColorBgG = 53;
                formMsgBox.varMsgColorBgB = 53;
                //form size
                formMsgBox.varMsgFrmH = 111;
                formMsgBox.varMsgFrmW = 282;

                //logo location
                formMsgBox.varMsgLogoLocationX = 12;
                formMsgBox.varMsgLogoLocationY = 19;

                //OpenMsgBox
                formMsgBox form = new formMsgBox();
                form.Show();
            }
        }

        private void gpboxYesOrNo_Enter(object sender, EventArgs e)
        {

        }
    }
}
