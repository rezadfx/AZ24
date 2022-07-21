using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConnectingAccessCsharp
{
    public partial class formAddUser : Form
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
                            lbUsers2.Items.Add(strListItem);
                    }
                }
            }
        }


        public void SaveUsers()
        {
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in lbUsers2.Items)
            {
                SaveFile.WriteLine(item);
            }
            SaveFile.Close();
        }


        //******** variables **********
        const string sPath = "app//Users.txt";
        public static string varUserF2 = "";
        public static string varSkinMode;

        // =======================================================================
        // =======================================================================
        // =======================================================================



        public formAddUser()
        {
            InitializeComponent();
        }

        private void formAddUser_Load(object sender, EventArgs e)
        {
            LoadUsers();

            //skin
            varSkinMode = AZ24.Properties.Settings.Default.Skins;

            if (varSkinMode == "Light")
            {
                this.BackColor = Color.WhiteSmoke;
                this.ForeColor = Color.Black;
                txtAddUserName.ForeColor = Color.Black;
                txtAddUserName.BackColor = Color.WhiteSmoke;
                txtAddUserName.FillColor = Color.Gainsboro;
                btnCloseUser.FillColor = Color.WhiteSmoke;
                btnCloseUser.BackColor = Color.WhiteSmoke;

            }
            else if (varSkinMode == "Dark")
            {
                this.BackColor = Color.FromArgb(23, 42, 59);
                this.ForeColor = Color.FromArgb(255, 255, 255);
                txtAddUserName.ForeColor = Color.FromArgb(255, 255, 255);
                txtAddUserName.BackColor = Color.FromArgb(20, 20, 30);
                txtAddUserName.FillColor = Color.FromArgb(20, 20, 30);
                btnCloseUser.FillColor = Color.FromArgb(23, 42, 59);
                btnCloseUser.BackColor = Color.FromArgb(23, 42, 59);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            form.Show();
            this.Close();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtAddUserName.Text != "")
            {
                lbUsers2.Items.Add(txtAddUserName.Text);
                SaveUsers();


                //textMsg
                formMsgBox.varMsgText = "User Successfully Added.";
                formMsgBox.varMsgTextLocX = 69;
                formMsgBox.varMsgTextLocY = 36;

                //Btn Loc
                formMsgBox.varMsgOkBtnLocationx = 117;
                formMsgBox.varMsgOkBtnLocationy = 63;
                //color Bg
                formMsgBox.varMsgColorBgR = 45;
                formMsgBox.varMsgColorBgG = 171;
                formMsgBox.varMsgColorBgB = 103;
                //form size
                formMsgBox.varMsgFrmH = 111;
                formMsgBox.varMsgFrmW = 282;

                //logo location
                formMsgBox.varMsgLogoLocationX = 12;
                formMsgBox.varMsgLogoLocationY = 19;

                txtAddUserName.Text = "";
                //OpenMsgBox
                formMsgBox form = new formMsgBox();
                form.Show();
            }
            else
            {
                //textMsg
                formMsgBox.varMsgText = "User Field is Empty.";
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

        private void btnCloseUser_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            form.Show();
            this.Hide();
        }

        private void txtAddUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            this.Close();
            form.Show();
        }
    }
}
