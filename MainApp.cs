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
using System.IO;

namespace ConnectingAccessCsharp
{
    public partial class MainApp : Form
    {

        OleDbConnection conn;


        //variables shared between forms
        public static string varUserF1 = "";
        public static int varSwitchUser = 0;

        //******** variables DB root **********
        public string selectedFileName;
        public static string varDataName;
        public string readDBPathTxt = Application.StartupPath + "\\app\\DBroot.txt";
        public string DBPath;

        //****************variables for Skin *******************
        public static string varSkinMode;
        public static string varSkinSave;


        //public string DBPath = Application.StartupPath + "\\DB.mdb";




        public MainApp()
        {
            InitializeComponent();

        }
        // =======================================================================
        // =======================================================================
        // ==============================Functions================================

        //Light Mode Function
        public void ActivateLightMode()
        {
            this.BackColor = Color.WhiteSmoke;
            this.ForeColor = Color.Black;

            lblDarkmode.Text = "Light Mode";
            lblDarkmode.ForeColor = Color.FromArgb(0, 0, 0);

            lblWorkerLight.Visible = true;
            lblworkerDark.Visible = false;

            mnuMain.BackColor = Color.FromArgb(255, 255, 255, 255);
            mnuMain.ForeColor = Color.FromArgb(0, 0, 0);

            mnuChangeUser.BackColor = Color.FromArgb(255, 255, 255, 255);
            mnuChangeUser.ForeColor = Color.FromArgb(0, 0, 0);

            mnuExit.BackColor = Color.FromArgb(255, 255, 255, 255);
            mnuExit.ForeColor = Color.FromArgb(0, 0, 0);

            fileToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);
            fileToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);

            toolStripMenuRefresh.BackColor = Color.FromArgb(255, 255, 255);
            toolStripMenuRefresh.ForeColor = Color.FromArgb(0, 0, 0);

            toolStripMenuMinimize.BackColor = Color.FromArgb(255, 255, 255);
            toolStripMenuMinimize.ForeColor = Color.FromArgb(0, 0, 0);

            editToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);
            editToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);

            deleteRowToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);
            deleteRowToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);

            editRowToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);
            editRowToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);

            systemToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);
            systemToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);

            changeDataBaseRootToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);
            changeDataBaseRootToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);

            lightModeToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);
            lightModeToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);
            lightModeToolStripMenuItem.Text = "Dark Mode";

            txtProtocoling.BackColor = Color.FromArgb(255, 255, 255);
            txtProtocoling.FillColor = Color.FromArgb(255, 255, 255);
            txtProtocoling.ForeColor = Color.FromArgb(0, 0, 0);
            txtProtocoling.PlaceholderForeColor = Color.Gray;

            txtObjectes.BackColor = Color.FromArgb(255, 255, 255);
            txtObjectes.FillColor = Color.FromArgb(255, 255, 255);
            txtObjectes.ForeColor = Color.FromArgb(0, 0, 0);
            txtObjectes.PlaceholderForeColor = Color.Gray;


            dataGridView.BackgroundColor = Color.FromArgb(230, 230, 230);
            dataGridView.ForeColor = Color.FromArgb(0, 0, 0);

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 230);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0);

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 171, 103);

            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200);
            dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200);
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200);


            btnRefresh.FillColor = Color.FromArgb(255, 255, 255);
            btnRefresh.BackColor = Color.FromArgb(255, 255, 255);

            //===============================save in file
            var varSkinPath = Application.StartupPath + "\\app\\Skin.txt";
            varSkinSave = "Light";
            File.WriteAllText(varSkinPath, varSkinSave);
        }

        //Activate Dark Mode
        public void ActivateDarkMode()
        {
            this.BackColor = Color.FromArgb(23, 42, 59);
            this.ForeColor = Color.FromArgb(255, 255, 255);

            lblDarkmode.Text = "Dark Mode";
            lblDarkmode.ForeColor = Color.FromArgb(255, 255, 255);

            lblWorkerLight.Visible = false;
            lblworkerDark.Visible = true;

            // ========================================
            mnuMain.BackColor = Color.FromArgb(23, 42, 59);
            mnuMain.ForeColor = Color.FromArgb(255, 255, 255);

            mnuChangeUser.BackColor = Color.FromArgb(33, 52, 69);
            mnuChangeUser.ForeColor = Color.FromArgb(255, 255, 255);

            mnuExit.BackColor = Color.FromArgb(33, 52, 69);
            mnuExit.ForeColor = Color.FromArgb(255, 255, 255);

            fileToolStripMenuItem.BackColor = Color.FromArgb(33, 52, 69);
            fileToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);

            toolStripMenuRefresh.BackColor = Color.FromArgb(33, 52, 69);
            toolStripMenuRefresh.ForeColor = Color.FromArgb(255, 255, 255);

            toolStripMenuMinimize.BackColor = Color.FromArgb(33, 52, 69);
            toolStripMenuMinimize.ForeColor = Color.FromArgb(255, 255, 255);

            editToolStripMenuItem.BackColor = Color.FromArgb(33, 52, 69);
            editToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);

            deleteRowToolStripMenuItem.BackColor = Color.FromArgb(33, 52, 69);
            deleteRowToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);

            editRowToolStripMenuItem.BackColor = Color.FromArgb(33, 52, 69);
            editRowToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);

            systemToolStripMenuItem.BackColor = Color.FromArgb(33, 52, 69);
            systemToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);

            changeDataBaseRootToolStripMenuItem.BackColor = Color.FromArgb(33, 52, 69);
            changeDataBaseRootToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);

            lightModeToolStripMenuItem.BackColor = Color.FromArgb(33, 52, 69);
            lightModeToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
            lightModeToolStripMenuItem.Text = "Light Mode";

            // ========================================
            txtProtocoling.BackColor = Color.FromArgb(23, 42, 59);
            txtProtocoling.FillColor = Color.FromArgb(23, 42, 59);
            txtProtocoling.ForeColor = Color.FromArgb(255, 255, 255);
            txtProtocoling.PlaceholderForeColor = Color.DarkGray;

            txtObjectes.BackColor = Color.FromArgb(23, 42, 59);
            txtObjectes.FillColor = Color.FromArgb(23, 42, 59);
            txtObjectes.ForeColor = Color.FromArgb(255, 255, 255);
            txtObjectes.PlaceholderForeColor = Color.DarkGray;

            // ========================================
            dataGridView.BackgroundColor = Color.FromArgb(20,20,30);
            dataGridView.ForeColor = Color.FromArgb(255, 255, 255);

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(23, 42, 59);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 42, 59);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(20, 20, 30);
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 171, 103);

            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(23, 42, 59);
            dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);

            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(23, 42, 59);
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 42, 59);

            btnRefresh.FillColor = Color.FromArgb(23, 42, 59);
            btnRefresh.BackColor = Color.FromArgb(23, 42, 59);

            //===============================save in file
            var varSkinPath = Application.StartupPath + "\\app\\Skin.txt";
            varSkinSave = "Dark";
            File.WriteAllText(varSkinPath, varSkinSave);

        }


        //******* Connect Function **********
        public void ConnectToDB()
        {
            // ApplicationEXEPath\Test.mdb
            conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" + DBPath);
            conn.Open();
        }


        //******* Refresh Load Function **********
        public void refreshList()
        {
            using (DataTable dt = new DataTable())
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ID, USER_, TIME_, PROTOCOL_, OBJECT_ FROM Protocols", conn))
                {
                    adapter.Fill(dt);
                }
                dataGridView.DataSource = dt;
            }
            conn.Close();

            dataGridView.ClearSelection();
            int nRowIndex = dataGridView.Rows.Count - 1;
            dataGridView.CurrentCell = dataGridView.Rows[nRowIndex].Cells[0];

        }
        //*********** refresh dataGridView *************
        public void RefreshAfterFocus()
        {
            using (DataTable dt = new DataTable())
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ID, USER_, TIME_, PROTOCOL_, OBJECT_ FROM Protocols", conn))
                {
                    adapter.Fill(dt);
                }
                dataGridView.DataSource = dt;
            }
            conn.Close();
        }


        // =======================================================================
        // =======================================================================
        // =======================================================================


        //focus form

        private void Form1_Load(object sender, EventArgs e)
        {
            //skin
            var varSkinPath = Application.StartupPath + "\\app\\Skin.txt";
            varSkinMode = File.ReadAllText(varSkinPath);

            if (varSkinMode == "Light")
            {
                ActivateLightMode();
                toggleDarlMode.Checked = false;

            }
            else if (varSkinMode == "Dark")
            {
                ActivateDarkMode();
                toggleDarlMode.Checked = true;
            }

            
            varSwitchUser = 1;

            // databse load root
            DBPath = File.ReadAllText(readDBPathTxt);

            //getting username variable
            varUserF1 = formLogin.varUserF2;

            //setting variables
            lblUsers.Text = varUserF1;

            ConnectToDB();

            refreshList();

            //dataGridView Attribs
            //this.dataGridView.Columns["ID"].Width = 60;
            this.dataGridView.Columns["ID"].Width = 60;
            //this.dataGridView.Columns["Userclm"].Width = 120;
            this.dataGridView.Columns["User_"].Width = 120;
            //this.dataGridView.Columns["Timeclm"].Width = 170;
            this.dataGridView.Columns["Time_"].Width = 170;
            //this.dataGridView.Columns["Protocolclm"].Width = 700;
            this.dataGridView.Columns["Protocol_"].Width = 700;
            //this.dataGridView.Columns["Objectclm"].Width = 247;
            this.dataGridView.Columns["Object_"].Width = 247;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClocks.Text = DateTime.Now.ToString("g");

        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }


        private void mnuChangeUser_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            form.Show();
            this.Hide();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to exit?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Environment.Exit(1);
                Application.Exit();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // refreshing List
            refreshList();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtProtocoling.Text != "")
            {
                //validating Values
                string strUsernames = lblUsers.Text;
                string strClock = lblClocks.Text;
                string strProtocol = txtProtocoling.Text;
                string strObject = txtObjectes.Text;
                string strQuery = "INSERT INTO Protocols (user_, time_, protocol_, object_) VALUES ('" + strUsernames + "','" + strClock + "','" + strProtocol + "','" + strObject + "')";

                ConnectToDB();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = strQuery;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

            }
            else
            {
                //textMsg
                formMsgBox.varMsgText = "Protocol Field is Empty.";
                formMsgBox.varMsgTextLocX = 70;
                formMsgBox.varMsgTextLocY = 36;

                //Btn Loc
                formMsgBox.varMsgOkBtnLocationx = 117;
                formMsgBox.varMsgOkBtnLocationy = 63;
                //color Bg
                formMsgBox.varMsgColorBgR = 255;
                formMsgBox.varMsgColorBgG = 69;
                formMsgBox.varMsgColorBgB = 0;
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

            //refreshing List
            refreshList();

            txtProtocoling.Text = "";
            txtObjectes.Text = "";
        }


        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            form.Show();
            this.Hide();
        }


        private void mnuChangeUser_Click_2(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            this.Hide();
            form.Show();
        }

        private void mnuExit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            this.Hide();
            form.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchByObject_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form color Red
            formInputBox.varInputBoxColorBgR = 220;
            formInputBox.varInputBoxColorBgG = 53;
            formInputBox.varInputBoxColorBgB = 53;
            //buttons text
            formInputBox.varbtnMsgBoxButton = "Delete";

            formInputBox frm = new formInputBox();
            frm.Show();
        }

        private void editRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form color Blue
            formInputBox.varInputBoxColorBgR = 0;
            formInputBox.varInputBoxColorBgG = 87;
            formInputBox.varInputBoxColorBgB = 157;
            //buttons text
            formInputBox.varbtnMsgBoxButton = "Edit";

            formInputBox frm = new formInputBox();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            formImportantNote frm = new formImportantNote();
            this.Hide();
            frm.Show();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton2_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.FillColor = Color.LimeGreen;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.FillColor = Color.Green;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.FillColor = Color.FromArgb(220, 10, 10);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.FillColor = Color.FromArgb(192, 0, 0);
        }

        private void changeDataBaseRootToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = Application.StartupPath;
                openFileDialog1.Filter = "Text files (*.mdb, *.accdb)|*.mdb;*.accdb";
                openFileDialog1.FilterIndex = 0;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    selectedFileName = openFileDialog1.FileName;
                    selectedFileName = selectedFileName.Replace(@"\", @"\\");

                    var saveDBPath = Application.StartupPath + "\\app\\DBroot.txt";
                    File.WriteAllText(saveDBPath, selectedFileName);
                    DBPath = File.ReadAllText(readDBPathTxt);
                    ConnectToDB();
                    refreshList();


                }
            }

        }

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toggleDarlMode_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleDarlMode.Checked == true)
            {
                ActivateDarkMode();
            }
            else if(toggleDarlMode.Checked == false)
            {
                ActivateLightMode();
            }
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lightModeToolStripMenuItem.Text == "Dark Mode")
            {
                ActivateDarkMode();
                toggleDarlMode.Checked = true;
            }
            else if (lightModeToolStripMenuItem.Text == "Light Mode")
            {
                ActivateLightMode();
                toggleDarlMode.Checked = false;
            }
        }

        private void toolStripMenuRefresh_Click(object sender, EventArgs e)
        {
            // refreshing List
            refreshList();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
