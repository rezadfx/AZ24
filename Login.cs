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
    public partial class formLogin : Form
    {

        // =======================================================================
        // =======================================================================
        // ==============================Functions================================

        //******* LoadUsers() Function **********
        public void LoadUsers()
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@sPath))
            {
                while (!sr.EndOfStream)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        string strListItem = sr.ReadLine();
                        if (!String.IsNullOrEmpty(strListItem))
                            lbUsers.Items.Add(strListItem);
                    }
                }
            }
        }

        //******** variables **********
        const string sPath = "app//Users.txt";
        public static string varUserF2 = "";
        public static string varSkinMode;


        // =======================================================================
        // =======================================================================
        // =======================================================================



        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            this.Height = 445;
            this.Width = 300;
            if (MainApp.varSwitchUser == 1)
            {
                label4.Text = "Switch User";
            }
            else
            {
                label4.Text = "Select User";
            }
            LoadUsers();

            //skin
            varSkinMode = AZ24.Properties.Settings.Default.Skins;

            if (varSkinMode == "Light")
            {
                this.BackColor = Color.WhiteSmoke;
                this.ForeColor = Color.Black;
                lbUsers.ForeColor = Color.Black;
                lbUsers.BackColor = Color.Gainsboro;
                btnAddNewUser.FillColor = Color.WhiteSmoke;
                btnAddNewUser.BackColor = Color.WhiteSmoke;
            }
            else if (varSkinMode == "Dark")
            {
                this.BackColor = Color.FromArgb(23, 42, 59);
                this.ForeColor = Color.White;
                lbUsers.ForeColor = Color.White;
                lbUsers.BackColor = Color.FromArgb(20, 20, 30);
                btnAddNewUser.FillColor = Color.FromArgb(23, 42, 59);
                btnAddNewUser.BackColor = Color.FromArgb(23, 42, 59);
            }




        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            varUserF2 = lbUsers.SelectedItem.ToString();


            MainApp form = new MainApp();
            form.Show();
            this.Hide();

        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {




            formAddUser form = new formAddUser();
            form.Show();
            this.Hide();




            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            varUserF2 = lbUsers.SelectedItem.ToString();


            MainApp form = new MainApp();
            this.Hide();
            form.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Width = 300;
            this.Height = 489;
            btnAddUser.Enabled = true;
            btnAddUser.Visible = true;
            btnDeleteUser.Enabled = true;
            btnDeleteUser.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Height = 445;
            this.Width = 300;
            formAddUser form = new formAddUser();
            this.Hide();
            form.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            this.Height = 445;
            this.Width = 300;
            formDeleteUser form = new formDeleteUser();
            this.Hide();
            form.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
