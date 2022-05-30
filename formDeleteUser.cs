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
    public partial class formDeleteUser : Form
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
        public string varSkinMode;

        // =======================================================================
        // =======================================================================
        // =======================================================================


        public formDeleteUser()
        {
            InitializeComponent();
        }

        private void formDeleteUser_Load(object sender, EventArgs e)
        {
            LoadUsers();

            //skin
            var varSkinPath = Application.StartupPath + "\\app\\Skin.txt";
            varSkinMode = File.ReadAllText(varSkinPath);

            if (varSkinMode == "Light")
            {
                this.BackColor = Color.WhiteSmoke;
                this.ForeColor = Color.Black;
                lbUsers2.ForeColor = Color.Black;
                lbUsers2.BackColor = Color.Gainsboro;
            }
            else if (varSkinMode == "Dark")
            {
                this.BackColor = Color.FromArgb(23, 42, 59);
                this.ForeColor = Color.FromArgb(255, 255, 255);
                lbUsers2.ForeColor = Color.FromArgb(255, 255, 255);
                lbUsers2.BackColor = Color.FromArgb(20, 20, 30);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            form.Show();
            this.Hide();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            //lbUsers2.SelectedItems.Remove(lbUsers2.SelectedIndex);
            for (int i = lbUsers2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lbUsers2.Items.RemoveAt(lbUsers2.SelectedIndices[i]);
            }
            SaveUsers();

            //textMsg
            formMsgBox.varMsgText = "User Successfully Deleted.";
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

            //OpenMsgBox
            formMsgBox form = new formMsgBox();
            form.Show();

        }

        private void btnCloseUser_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            form.Show();
            this.Hide();
        }
    }
}
