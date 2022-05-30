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
    public partial class formPropertyProtection : Form
    {

        OleDbConnection conn;

        //******** variables DB root **********
        public string selectedFileName;
        public static string varDataName;
        public string readDBPathTxt = Application.StartupPath + "\\app\\DBroot.txt";
        public string DBPath;
        public static string varUserF3 = "";

        public static string varSelectedObject = "";


        //****************variables for Skin *******************
        public static string varSkin = "";
        public string varSkinSave;



        public formPropertyProtection()
        {
            InitializeComponent();
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
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ID, USER_, TIME_, NAME_, OBJECT_ FROM tbAnmeldungen", conn))
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
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ID, USER_, TIME_, NAME_, OBJECT_ FROM tbAnmeldungen", conn))
                {
                    adapter.Fill(dt);
                }
                dataGridView.DataSource = dt;
            }
            conn.Close();
        }

        public void LoadObjects()
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@varOPath))
            {
                while (!sr.EndOfStream)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        string strListItem = sr.ReadLine();
                        if (!String.IsNullOrEmpty(strListItem))
                            dropdownObjects.Items.Add(strListItem);
                    }
                }
            }
        }

        const string varOPath = "app//Objects.txt";


        public void LoadWorkers()
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@varWPath))
            {
                while (!sr.EndOfStream)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        string strListItem = sr.ReadLine();
                        if (!String.IsNullOrEmpty(strListItem))
                            dropDownWorkers.Items.Add(strListItem);
                    }
                }
            }
        }

        const string varWPath = "app//Mitarbeiter.txt";

        // =======================================================================



        public void ActivateLightMode()
        {
            this.BackColor = Color.WhiteSmoke;
            this.ForeColor = Color.Black;

            dropDownWorkers.FillColor = Color.FromArgb(255, 255, 255);
            dropDownWorkers.ForeColor = Color.FromArgb(0, 0, 0);

            dropdownObjects.FillColor = Color.FromArgb(255, 255, 255);
            dropdownObjects.ForeColor = Color.FromArgb(0, 0, 0);

            txtTime.FillColor = Color.FromArgb(255, 255, 255);
            txtTime.ForeColor = Color.FromArgb(0, 0, 0);
            txtTime.PlaceholderForeColor = Color.Gray;


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

            //===============================save in file
            var varSkinPath = Application.StartupPath + "\\app\\Skin.txt";
            varSkinSave = "Light";
            File.WriteAllText(varSkinPath, varSkinSave);

        }

        //Activate Dark Mode
        public void ActivateDarkMode()
        {
            this.BackColor = Color.FromArgb(23, 30, 40);
            this.ForeColor = Color.FromArgb(255, 255, 255);

            dropDownWorkers.FillColor = Color.FromArgb(23, 42, 59);
            dropDownWorkers.ForeColor = Color.FromArgb(255, 255, 255);

            dropdownObjects.FillColor = Color.FromArgb(23, 42, 59);
            dropdownObjects.ForeColor = Color.FromArgb(255, 255, 255);

            txtTime.FillColor = Color.FromArgb(23, 42, 59);
            txtTime.ForeColor = Color.FromArgb(255, 255, 255);
            txtTime.PlaceholderForeColor = Color.DarkGray;

            // ========================================
            dataGridView.BackgroundColor = Color.FromArgb(20, 20, 30);
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

            //===============================save in file
            var varSkinPath = Application.StartupPath + "\\app\\Skin.txt";
            varSkinSave = "Dark";
            File.WriteAllText(varSkinPath, varSkinSave);

        }


        // =======================================================================
        // =======================================================================

        //varSelectedObject = dropdownObjects.SelectedItem.ToString();
        //send dropdown

        private void formImportantNote_Load(object sender, EventArgs e)
        {
            varSkin = MainApp.varSkinMode;
            if (varSkin == "Light")
            {
                ActivateLightMode();
                toggleDarlMode.Checked = false;

            }
            else if (varSkin == "Dark")
            {
                ActivateDarkMode();
                toggleDarlMode.Checked = true;
            }

            //Load Objects
            LoadObjects();

            //Load Mitarbeitern
            LoadWorkers();

            //databse load root
            DBPath = File.ReadAllText(readDBPathTxt);

            //getting username variable
            varUserF3 = formLogin.varUserF2;

            //setting variables
            lblUsers.Text = varUserF3;

            ConnectToDB();

            refreshList();

            //this.dataGridView.Columns["ID"].Width = 60;
            this.dataGridView.Columns["ID"].Width = 60;
            //this.dataGridView.Columns["Userclm"].Width = 120;
            this.dataGridView.Columns["User_"].Width = 120;
            //this.dataGridView.Columns["Timeclm"].Width = 170;
            this.dataGridView.Columns["Time_"].Width = 170;
            //this.dataGridView.Columns["Protocolclm"].Width = 700;
            this.dataGridView.Columns["Name_"].Width = 474;
            //this.dataGridView.Columns["Objectclm"].Width = 247;
            this.dataGridView.Columns["Object_"].Width = 320;


        }

        private void txtObjectes_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblback_Click(object sender, EventArgs e)
        {
            MainApp frm = new MainApp();
            this.Hide();
            frm.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            //validating Values
            string strUsernames = lblUsers.Text;
            string strClock = txtTime.Text;
            string strWorker = dropDownWorkers.SelectedItem.ToString();
            string strObject = dropdownObjects.SelectedItem.ToString();

            if (strWorker != "" && strClock != "" && strObject != "")
            {
                
                string strQuery = "INSERT INTO tbAnmeldungen (USER_, TIME_, NAME_, OBJECT_) VALUES ('" + strUsernames + "','" + strClock + "','" + strWorker + "','" + strObject + "')";

                ConnectToDB();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = strQuery;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

            }
            else
            {
                //textMsg
                formMsgBox.varMsgText = "Fields are Empty.";
                formMsgBox.varMsgTextLocX = 90;
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

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("G");
        }

        private void toggleSwitchTime_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSwitchTime.Checked == true)
            {
                timer1.Enabled = true;
                txtTime.Enabled = false;
            }
            else if (toggleSwitchTime.Checked == false)
            {
                timer1.Enabled = false;
                txtTime.Enabled = true;
            }
        }

        private void toggleDarlMode_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleDarlMode.Checked == true)
            {
                ActivateDarkMode();
            }
            else if (toggleDarlMode.Checked == false)
            {
                ActivateLightMode();
            }
        }
    }
}
