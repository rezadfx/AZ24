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
using System.Text;

namespace ConnectingAccessCsharp
{
    public partial class formPass : Form
    {

        public static string varCheckBoxChoicePass = "Clients";

        //******* Connect Function **********
        OleDbConnection conn;

        public string DBPath = AZ24.Properties.Settings.Default.DataBaseRoot;

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
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ID, Clients, Passwords FROM tbPasswordList", conn))
                {
                    adapter.Fill(dt);
                }
                dataGridView.DataSource = dt;
            }
            conn.Close();

        }
        //******* Search Function **********
        public void SearchList()
        {
            using (DataTable dt = new DataTable())
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tbPasswordList WHERE CLIENTS LIKE '" + txtPassSearch.Text.ToString() + "%'", conn))
                {
                    adapter.Fill(dt);
                }
                dataGridView.DataSource = dt;
            }
            conn.Close();
        }
        //******* Search Function **********
        public void SearchListPass()
        {
            using (DataTable dt = new DataTable())
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tbPasswordList WHERE PASSWORDs LIKE '" + txtSearchPassword.Text.ToString() + "%'", conn))
                {
                    adapter.Fill(dt);
                }
                dataGridView.DataSource = dt;
            }
            conn.Close();
        }

        //======================================================================

        public formPass()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formPass_Load(object sender, EventArgs e)
        {

            

            ConnectToDB();

            refreshList();

            //this.dataGridView.Columns["ID"].Width = 60;
            this.dataGridView.Columns["ID"].Width = 60;
            this.dataGridView.Columns["Clients"].Width = 345;
            this.dataGridView.Columns["Passwords"].Width = 345;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPassSearch.Text == "")
            {
                ConnectToDB();
                refreshList();
            }
            else
            {
                SearchList();
            }
            
        }

        private void txtSearchPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchPassword.Text == "")
            {
                ConnectToDB();
                refreshList();
            }
            else
            {
                SearchListPass();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gpboxAddClient.Enabled = true;
            gpboxAddClient.Visible = true;
        }

        private void btnCloseAdd_Click(object sender, EventArgs e)
        {
            gpboxAddClient.Enabled = false;
            gpboxAddClient.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {


            if (txtAddClient.Text != "" && txtAddPassword.Text != "")
            {
                //validating Values
                string strClientName = txtAddClient.Text;
                string strClentPass = txtAddPassword.Text;
                string strQuery = "INSERT INTO tbPasswordList (Clients, Passwords) VALUES ('" + strClientName + "','" + strClentPass + "')";

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

            txtAddClient.Text = "";
            txtAddPassword.Text = "";
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            guna2Button2.Text= "Add Client";
            txtIDedit.Enabled = false;
            txtIDedit.Visible = false;

        }

        private void btnEditList_CheckedChanged(object sender, EventArgs e)
        {
            guna2Button2.Text = "Edit Client";
            txtIDedit.Enabled = true;
            txtIDedit.Visible = true;
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtTextasd.PlaceholderText = "Name of Client to Edit";
            btnEditClient.Text = "Edit Name";
            varCheckBoxChoicePass = "Clients";
        }

        private void guna2RadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

            txtTextasd.PlaceholderText = "Password of Client to Edit";
            btnEditClient.Text = "Edit Password";
            varCheckBoxChoicePass = "Passwords";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            if (txtIDedit.Text != "" && txtTextasd.Text != "")
            {
                string strClientIDEdit = txtIDedit.Text;
                string strClentTextEdit = txtTextasd.Text;
                string strQuery = "UPDATE tbPasswordList SET [" + varCheckBoxChoicePass + "]='" + strClentTextEdit + "' WHERE id=" + strClientIDEdit + ";";

                ConnectToDB();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = strQuery;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                conn.Close();
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

            txtIDedit.Text = "";
            txtTextasd.Text = "";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            gpboxManageClients.Enabled = true;
            gpboxManageClients.Visible = true;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gpboxManageClients.Enabled = false;
            gpboxManageClients.Visible = false;
        }
    }
}
