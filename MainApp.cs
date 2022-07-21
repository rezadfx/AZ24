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

        public static string varSorting = AZ24.Properties.Settings.Default.mainSorting;

        //******** variables DB root **********
        public string selectedFileName;
        public static string DBPath;

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

            SearchStripMenuItem1.BackColor = Color.FromArgb(255, 255, 255);
            SearchStripMenuItem1.ForeColor = Color.FromArgb(0, 0, 0);

            deleteRowToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);
            deleteRowToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);

            editRowToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);
            editRowToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);

            systemToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);
            systemToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);

            changeDataBaseRootToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);
            changeDataBaseRootToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0);

            toolStripMenuSort.BackColor = Color.FromArgb(255, 255, 255);
            toolStripMenuSort.ForeColor = Color.FromArgb(0, 0, 0);

            sortByID.BackColor = Color.FromArgb(255, 255, 255);
            sortByID.ForeColor = Color.FromArgb(0, 0, 0);

            sortByUSER.BackColor = Color.FromArgb(255, 255, 255);
            sortByUSER.ForeColor = Color.FromArgb(0, 0, 0);

            sortByTime.BackColor = Color.FromArgb(255, 255, 255);
            sortByTime.ForeColor = Color.FromArgb(0, 0, 0);

            sortByObject.BackColor = Color.FromArgb(255, 255, 255);
            sortByObject.ForeColor = Color.FromArgb(0, 0, 0);

            sortByProtocol.BackColor = Color.FromArgb(255, 255, 255);
            sortByProtocol.ForeColor = Color.FromArgb(0, 0, 0);

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
            AZ24.Properties.Settings.Default.Skins = "Light";
            AZ24.Properties.Settings.Default.Save();
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

            SearchStripMenuItem1.BackColor = Color.FromArgb(33, 52, 69);
            SearchStripMenuItem1.ForeColor = Color.FromArgb(255, 255, 255);

            deleteRowToolStripMenuItem.BackColor = Color.FromArgb(33, 52, 69);
            deleteRowToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);

            editRowToolStripMenuItem.BackColor = Color.FromArgb(33, 52, 69);
            editRowToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);

            systemToolStripMenuItem.BackColor = Color.FromArgb(33, 52, 69);
            systemToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);

            changeDataBaseRootToolStripMenuItem.BackColor = Color.FromArgb(33, 52, 69);
            changeDataBaseRootToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);

            toolStripMenuSort.BackColor = Color.FromArgb(33, 52, 69);
            toolStripMenuSort.ForeColor = Color.FromArgb(255, 255, 255);

            sortByID.BackColor = Color.FromArgb(33, 52, 69);
            sortByID.ForeColor = Color.FromArgb(255, 255, 255);

            sortByUSER.BackColor = Color.FromArgb(33, 52, 69);
            sortByUSER.ForeColor = Color.FromArgb(255, 255, 255);

            sortByTime.BackColor = Color.FromArgb(33, 52, 69);
            sortByTime.ForeColor = Color.FromArgb(255, 255, 255);

            sortByObject.BackColor = Color.FromArgb(33, 52, 69);
            sortByObject.ForeColor = Color.FromArgb(255, 255, 255);

            sortByProtocol.BackColor = Color.FromArgb(33, 52, 69);
            sortByProtocol.ForeColor = Color.FromArgb(255, 255, 255);

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
            AZ24.Properties.Settings.Default.Skins = "Dark";
            AZ24.Properties.Settings.Default.Save();

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


            switch (varSorting)
            {
                case "ID":
                    this.dataGridView.Sort(this.dataGridView.Columns["ID"], ListSortDirection.Ascending);
                    break;
                case "User":
                    this.dataGridView.Sort(this.dataGridView.Columns["User_"], ListSortDirection.Ascending);
                    break;
                case "Time":
                    this.dataGridView.Sort(this.dataGridView.Columns["Time_"], ListSortDirection.Ascending);
                    break;
                case "Protocol":
                    this.dataGridView.Sort(this.dataGridView.Columns["Protocol_"], ListSortDirection.Ascending);
                    break;
                case "Object":
                    this.dataGridView.Sort(this.dataGridView.Columns["Object_"], ListSortDirection.Ascending);
                    break;
            }


        }
        //******* Search Function **********
        public void SearchList()
        {
            using (DataTable dt = new DataTable())
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Protocols WHERE PROTOCOL_ LIKE '" + txtSearch.Text.ToString() + "%'", conn))
                {
                    adapter.Fill(dt);
                }
                dataGridView.DataSource = dt;
            }
            conn.Close();

            dataGridView.ClearSelection();
            int nRowIndex = dataGridView.Rows.Count - 1;
            dataGridView.CurrentCell = dataGridView.Rows[nRowIndex].Cells[0];

            switch (varSorting)
            {
                case "ID":
                    this.dataGridView.Sort(this.dataGridView.Columns["ID"], ListSortDirection.Ascending);
                    break;
                case "User":
                    this.dataGridView.Sort(this.dataGridView.Columns["User_"], ListSortDirection.Ascending);
                    break;
                case "Time":
                    this.dataGridView.Sort(this.dataGridView.Columns["Time_"], ListSortDirection.Ascending);
                    break;
                case "Protocol":
                    this.dataGridView.Sort(this.dataGridView.Columns["Protocol_"], ListSortDirection.Ascending);
                    break;
                case "Object":
                    this.dataGridView.Sort(this.dataGridView.Columns["Object_"], ListSortDirection.Ascending);
                    break;
            }
        }

        public static string SearchValue;

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

            this.dataGridView.Sort(this.dataGridView.Columns["ID"], ListSortDirection.Ascending);
        }


        // =======================================================================
        // =======================================================================
        // =======================================================================


        //focus form

        private void Form1_Load(object sender, EventArgs e)
        {

            if (AZ24.Properties .Settings.Default.DataBaseRoot == ""){
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

                        AZ24.Properties.Settings.Default.DataBaseRoot = selectedFileName;
                        AZ24.Properties.Settings.Default.Save();
                    }
                }
            }

            varSkinMode = AZ24.Properties.Settings.Default.Skins;

            if (varSkinMode == "Light")
            {
                ActivateLightMode();
                toggleDarlMode.Checked = false;

            }
            else
            {
                ActivateDarkMode();
                toggleDarlMode.Checked = true;
            }

            
            
            varSwitchUser = 1;

            // databse load root
            DBPath = AZ24.Properties.Settings.Default.DataBaseRoot;

            //getting username variable
            varUserF1 = formLogin.varUserF2;

            //setting variables
            lblUsers.Text = varUserF1;

            ConnectToDB();

            refreshList();

            //dataGridView Attribs
            this.dataGridView.Columns["ID"].Width = AZ24.Properties.Settings.Default.mainIDWidth;
            this.dataGridView.Columns["User_"].Width = AZ24.Properties.Settings.Default.mainUserWidth;
            this.dataGridView.Columns["Time_"].Width = AZ24.Properties.Settings.Default.mainTimeWidth;
            this.dataGridView.Columns["Protocol_"].Width = AZ24.Properties.Settings.Default.mainProtocolWidth;
            this.dataGridView.Columns["Object_"].Width = AZ24.Properties.Settings.Default.mainObjectWidth;


            switch (varSorting)
            {
                case "ID":
                    sortByID.Checked = true;
                    sortByUSER.Checked = false;
                    sortByTime.Checked = false;
                    sortByProtocol.Checked = false;
                    sortByObject.Checked = false;
                    break;
                case "User":
                    sortByID.Checked = false;
                    sortByUSER.Checked = true;
                    sortByTime.Checked = false;
                    sortByProtocol.Checked = false;
                    sortByObject.Checked = false;
                    break;
                case "Time":
                    sortByID.Checked = false;
                    sortByUSER.Checked = false;
                    sortByTime.Checked = true;
                    sortByProtocol.Checked = false;
                    sortByObject.Checked = false;
                    break;
                case "Protocol":
                    sortByID.Checked = false;
                    sortByUSER.Checked = false;
                    sortByTime.Checked = false;
                    sortByProtocol.Checked = true;
                    sortByObject.Checked = false;
                    break;
                case "Object":
                    sortByID.Checked = false;
                    sortByUSER.Checked = false;
                    sortByTime.Checked = false;
                    sortByProtocol.Checked = false;
                    sortByObject.Checked = true;
                    break;
            }

            

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
            AZ24.Properties.Settings.Default.mainIDWidth = this.dataGridView.Columns["ID"].Width;
            AZ24.Properties.Settings.Default.mainUserWidth = this.dataGridView.Columns["User_"].Width;
            AZ24.Properties.Settings.Default.mainTimeWidth = this.dataGridView.Columns["Time_"].Width;
            AZ24.Properties.Settings.Default.mainProtocolWidth = this.dataGridView.Columns["Protocol_"].Width;
            AZ24.Properties.Settings.Default.mainObjectWidth = this.dataGridView.Columns["Object_"].Width;
            AZ24.Properties.Settings.Default.Save();

            Application.Exit();
        }

        private void lblback_Click(object sender, EventArgs e)
        {

            AZ24.Properties.Settings.Default.mainIDWidth = this.dataGridView.Columns["ID"].Width;
            AZ24.Properties.Settings.Default.mainUserWidth = this.dataGridView.Columns["User_"].Width;
            AZ24.Properties.Settings.Default.mainTimeWidth = this.dataGridView.Columns["Time_"].Width;
            AZ24.Properties.Settings.Default.mainProtocolWidth = this.dataGridView.Columns["Protocol_"].Width;
            AZ24.Properties.Settings.Default.mainObjectWidth = this.dataGridView.Columns["Object_"].Width;
            AZ24.Properties.Settings.Default.Save();

            formLogin form = new formLogin();
            this.Close();
            form.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
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
            
            AZ24.Properties.Settings.Default.mainIDWidth = this.dataGridView.Columns["ID"].Width;
            AZ24.Properties.Settings.Default.mainUserWidth = this.dataGridView.Columns["User_"].Width;
            AZ24.Properties.Settings.Default.mainTimeWidth = this.dataGridView.Columns["Time_"].Width;
            AZ24.Properties.Settings.Default.mainProtocolWidth = this.dataGridView.Columns["Protocol_"].Width;
            AZ24.Properties.Settings.Default.mainObjectWidth = this.dataGridView.Columns["Object_"].Width;
            AZ24.Properties.Settings.Default.Save();

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

                    AZ24.Properties.Settings.Default.DataBaseRoot = selectedFileName;
                    AZ24.Properties.Settings.Default.Save();
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
            else
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
            else
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


        private void txtObjectes_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            gpboxSearch.Visible = false;
            gpboxSearch.Enabled = false;
        }

        private void SearchStripMenuItem1_Click(object sender, EventArgs e)
        {
            gpboxSearch.Visible = true;
            gpboxSearch.Enabled = true;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {



            using (DataTable dt = new DataTable())
            {
                if (rdbtnID.Checked)
                {
                    SearchValue = "ID";
                }
                if (rdbtnUser.Checked)
                {
                    SearchValue = "USER_";
                }
                if (rdbtnTime.Checked)
                {
                    SearchValue = "TIME_";
                }
                if (rdbtnProtocol.Checked)
                {
                    SearchValue = "PROTOCOL_";
                }
                if (rdbtnObject.Checked)
                {
                    SearchValue = "OBJECT_";
                }
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Protocols WHERE " + SearchValue + " LIKE '" + txtSearch.Text.ToString() + "%'", conn))
                {
                    adapter.Fill(dt);
                }
                dataGridView.DataSource = dt;
            }
            conn.Close();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            formPass frm = new formPass();
            frm.Show();
        }

        private void sortByID_Click(object sender, EventArgs e)
        {
            if (sortByID.Checked == false)
            {
                sortByID.Checked = true;
                sortByUSER.Checked = false;
                sortByTime.Checked = false;
                sortByProtocol.Checked = false;
                sortByObject.Checked = false;
                this.dataGridView.Sort(this.dataGridView.Columns["ID"], ListSortDirection.Ascending);

                varSorting = "ID";
                AZ24.Properties.Settings.Default.mainSorting = "ID";
                AZ24.Properties.Settings.Default.Save();
            }
            
        }

        private void sortByUSER_Click(object sender, EventArgs e)
        {
            if (sortByUSER.Checked == false)
            {
                sortByID.Checked = false;
                sortByUSER.Checked = true;
                sortByTime.Checked = false;
                sortByProtocol.Checked = false;
                sortByObject.Checked = false;
                this.dataGridView.Sort(this.dataGridView.Columns["USER_"], ListSortDirection.Ascending);

                varSorting = "User";
                AZ24.Properties.Settings.Default.mainSorting = "User";
                AZ24.Properties.Settings.Default.Save();
            }
        }

        private void sortByTime_Click(object sender, EventArgs e)
        {
            if (sortByTime.Checked == false)
            {
                sortByID.Checked = false;
                sortByUSER.Checked = false;
                sortByTime.Checked = true;
                sortByProtocol.Checked = false;
                sortByObject.Checked = false;
                this.dataGridView.Sort(this.dataGridView.Columns["Time_"], ListSortDirection.Ascending);

                varSorting = "Time";
                AZ24.Properties.Settings.Default.mainSorting = "Time";
                AZ24.Properties.Settings.Default.Save();
            }
        }

        private void sortByProtocol_Click(object sender, EventArgs e)
        {
            if (sortByProtocol.Checked == false)
            {
                sortByID.Checked = false;
                sortByUSER.Checked = false;
                sortByTime.Checked = false;
                sortByProtocol.Checked = true;
                sortByObject.Checked = false;
                this.dataGridView.Sort(this.dataGridView.Columns["Protocol_"], ListSortDirection.Ascending);

                varSorting = "Protocol";
                AZ24.Properties.Settings.Default.mainSorting = "Protocol";
                AZ24.Properties.Settings.Default.Save();
            }
        }

        private void sortByObject_Click(object sender, EventArgs e)
        {
            if (sortByObject.Checked == false)
            {
                sortByID.Checked = false;
                sortByUSER.Checked = false;
                sortByTime.Checked = false;
                sortByProtocol.Checked = false;
                sortByObject.Checked = true;
                this.dataGridView.Sort(this.dataGridView.Columns["Object_"], ListSortDirection.Ascending);

                varSorting = "Object";
                AZ24.Properties.Settings.Default.mainSorting = "Object";
                AZ24.Properties.Settings.Default.Save();
            }
        }

        private void gpboxTimeEdit_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            gpboxTimeEdit.Visible = false;
            gpboxTimeEdit.Enabled = false;
        }

        private void toggleSwitchTime_CheckedChanged(object sender, EventArgs e)
        {

            if (toggleSwitchTime1.Checked == true)
            {
                timer2.Enabled = true;
                txtTimeEdit.Enabled = false;
            }
            else if (toggleSwitchTime1.Checked == false)
            {
                timer2.Enabled = false;
                txtTimeEdit.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            txtTimeEdit.Text = DateTime.Now.ToString("g");
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            gpboxTimeEdit.Visible = true;
            gpboxTimeEdit.Enabled = true;
            timer2.Enabled = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string strIDnumEdit = txtIDTimeEdit.Text;
            string strtxtTimeEdit = txtTimeEdit.Text;
            string strQuery = "UPDATE Protocols SET [Time_]='" + strtxtTimeEdit + "' WHERE id=" + strIDnumEdit + ";";

            //MessageBox.Show(strQuery);
            //UPDATE Table_1 SET [text_col]='Updated text', [int_col]=2014 WHERE id=2;

            ConnectToDB();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = strQuery;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
