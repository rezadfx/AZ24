namespace ConnectingAccessCsharp
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblClocks = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUsers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProtocoling = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtObjectes = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSort = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByID = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByUSER = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByTime = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByProtocol = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByObject = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDataBaseRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toggleDarlMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblDarkmode = new System.Windows.Forms.Label();
            this.gpboxSearch = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdbtnObject = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbtnID = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbtnProtocol = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbtnUser = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbtnTime = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWorkerLight = new System.Windows.Forms.Label();
            this.lblworkerDark = new System.Windows.Forms.Label();
            this.lblback = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpboxTimeEdit = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimeEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDTimeEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.toggleSwitchTime1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.gpboxSearch.SuspendLayout();
            this.gpboxTimeEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.dataGridView.Location = new System.Drawing.Point(2, 203);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1299, 540);
            this.dataGridView.TabIndex = 0;
            // 
            // lblClocks
            // 
            this.lblClocks.AutoSize = true;
            this.lblClocks.Location = new System.Drawing.Point(336, 101);
            this.lblClocks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClocks.Name = "lblClocks";
            this.lblClocks.Size = new System.Drawing.Size(39, 17);
            this.lblClocks.TabIndex = 9;
            this.lblClocks.Text = "Time";
            this.lblClocks.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(114, 101);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(35, 17);
            this.lblUsers.TabIndex = 9;
            this.lblUsers.Text = "User";
            this.lblUsers.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current User:";
            this.label1.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // txtProtocoling
            // 
            this.txtProtocoling.Animated = true;
            this.txtProtocoling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.txtProtocoling.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.txtProtocoling.BorderRadius = 20;
            this.txtProtocoling.BorderThickness = 3;
            this.txtProtocoling.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProtocoling.DefaultText = "";
            this.txtProtocoling.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.txtProtocoling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.txtProtocoling.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txtProtocoling.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProtocoling.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.txtProtocoling.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProtocoling.Font = new System.Drawing.Font("Nirmala UI", 11.25F);
            this.txtProtocoling.ForeColor = System.Drawing.Color.White;
            this.txtProtocoling.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProtocoling.Location = new System.Drawing.Point(12, 132);
            this.txtProtocoling.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProtocoling.Name = "txtProtocoling";
            this.txtProtocoling.PasswordChar = '\0';
            this.txtProtocoling.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtProtocoling.PlaceholderText = "Protocol";
            this.txtProtocoling.SelectedText = "";
            this.txtProtocoling.Size = new System.Drawing.Size(760, 50);
            this.txtProtocoling.TabIndex = 12;
            // 
            // txtObjectes
            // 
            this.txtObjectes.Animated = true;
            this.txtObjectes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.txtObjectes.BorderRadius = 20;
            this.txtObjectes.BorderThickness = 3;
            this.txtObjectes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObjectes.DefaultText = "";
            this.txtObjectes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtObjectes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtObjectes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObjectes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObjectes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.txtObjectes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObjectes.Font = new System.Drawing.Font("Nirmala UI", 11.25F);
            this.txtObjectes.ForeColor = System.Drawing.Color.White;
            this.txtObjectes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObjectes.Location = new System.Drawing.Point(778, 132);
            this.txtObjectes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObjectes.Name = "txtObjectes";
            this.txtObjectes.PasswordChar = '\0';
            this.txtObjectes.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtObjectes.PlaceholderText = "Object";
            this.txtObjectes.SelectedText = "";
            this.txtObjectes.Size = new System.Drawing.Size(307, 50);
            this.txtObjectes.TabIndex = 13;
            this.txtObjectes.TextChanged += new System.EventHandler(this.txtObjectes_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.BorderThickness = 2;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.btnRefresh.Location = new System.Drawing.Point(1208, 132);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 50);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1094, 132);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(108, 50);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "Send";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 40;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1301, 24);
            this.mnuMain.TabIndex = 18;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangeUser,
            this.toolStripMenuRefresh,
            this.toolStripMenuMinimize,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // mnuChangeUser
            // 
            this.mnuChangeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.mnuChangeUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuChangeUser.ForeColor = System.Drawing.Color.White;
            this.mnuChangeUser.Name = "mnuChangeUser";
            this.mnuChangeUser.Size = new System.Drawing.Size(174, 22);
            this.mnuChangeUser.Text = "Switch User";
            this.mnuChangeUser.Click += new System.EventHandler(this.mnuChangeUser_Click_2);
            // 
            // toolStripMenuRefresh
            // 
            this.toolStripMenuRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.toolStripMenuRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuRefresh.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuRefresh.Name = "toolStripMenuRefresh";
            this.toolStripMenuRefresh.ShortcutKeyDisplayString = "F5";
            this.toolStripMenuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuRefresh.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuRefresh.Text = "Refresh";
            this.toolStripMenuRefresh.Click += new System.EventHandler(this.toolStripMenuRefresh_Click);
            // 
            // toolStripMenuMinimize
            // 
            this.toolStripMenuMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.toolStripMenuMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuMinimize.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuMinimize.Name = "toolStripMenuMinimize";
            this.toolStripMenuMinimize.ShortcutKeyDisplayString = "Ctrl + M";
            this.toolStripMenuMinimize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.toolStripMenuMinimize.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuMinimize.Text = "Minimize";
            this.toolStripMenuMinimize.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.mnuExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuExit.ForeColor = System.Drawing.Color.White;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeyDisplayString = "Alt + F4";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(174, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click_2);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchStripMenuItem1,
            this.deleteRowToolStripMenuItem,
            this.editRowToolStripMenuItem,
            this.toolStripMenuSort,
            this.toolStripMenuItem1});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.editToolStripMenuItem.Text = "Oprtions";
            // 
            // SearchStripMenuItem1
            // 
            this.SearchStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.SearchStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SearchStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.SearchStripMenuItem1.Name = "SearchStripMenuItem1";
            this.SearchStripMenuItem1.ShortcutKeyDisplayString = "Ctrl + F";
            this.SearchStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.SearchStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.SearchStripMenuItem1.Text = "Search";
            this.SearchStripMenuItem1.Click += new System.EventHandler(this.SearchStripMenuItem1_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.deleteRowToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteRowToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Del";
            this.deleteRowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // editRowToolStripMenuItem
            // 
            this.editRowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.editRowToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editRowToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editRowToolStripMenuItem.Name = "editRowToolStripMenuItem";
            this.editRowToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + E";
            this.editRowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editRowToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.editRowToolStripMenuItem.Text = "Edit Row";
            this.editRowToolStripMenuItem.ToolTipText = "Always Sort By: ";
            this.editRowToolStripMenuItem.Click += new System.EventHandler(this.editRowToolStripMenuItem_Click);
            // 
            // toolStripMenuSort
            // 
            this.toolStripMenuSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.toolStripMenuSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByID,
            this.sortByUSER,
            this.sortByTime,
            this.sortByProtocol,
            this.sortByObject});
            this.toolStripMenuSort.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuSort.Name = "toolStripMenuSort";
            this.toolStripMenuSort.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuSort.Text = "Sorting";
            // 
            // sortByID
            // 
            this.sortByID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.sortByID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortByID.ForeColor = System.Drawing.Color.White;
            this.sortByID.Name = "sortByID";
            this.sortByID.Size = new System.Drawing.Size(199, 22);
            this.sortByID.Text = "Always Sort By ID";
            this.sortByID.Click += new System.EventHandler(this.sortByID_Click);
            // 
            // sortByUSER
            // 
            this.sortByUSER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.sortByUSER.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortByUSER.ForeColor = System.Drawing.Color.White;
            this.sortByUSER.Name = "sortByUSER";
            this.sortByUSER.Size = new System.Drawing.Size(199, 22);
            this.sortByUSER.Text = "Always Sort By User";
            this.sortByUSER.Click += new System.EventHandler(this.sortByUSER_Click);
            // 
            // sortByTime
            // 
            this.sortByTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.sortByTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortByTime.ForeColor = System.Drawing.Color.White;
            this.sortByTime.Name = "sortByTime";
            this.sortByTime.Size = new System.Drawing.Size(199, 22);
            this.sortByTime.Text = "Always Sort By Time";
            this.sortByTime.Click += new System.EventHandler(this.sortByTime_Click);
            // 
            // sortByProtocol
            // 
            this.sortByProtocol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.sortByProtocol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortByProtocol.ForeColor = System.Drawing.Color.White;
            this.sortByProtocol.Name = "sortByProtocol";
            this.sortByProtocol.Size = new System.Drawing.Size(199, 22);
            this.sortByProtocol.Text = "Always Sort By Protocol";
            this.sortByProtocol.Click += new System.EventHandler(this.sortByProtocol_Click);
            // 
            // sortByObject
            // 
            this.sortByObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.sortByObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortByObject.ForeColor = System.Drawing.Color.White;
            this.sortByObject.Name = "sortByObject";
            this.sortByObject.Size = new System.Drawing.Size(199, 22);
            this.sortByObject.Text = "Always Sort By Object";
            this.sortByObject.Click += new System.EventHandler(this.sortByObject_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDataBaseRootToolStripMenuItem,
            this.lightModeToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // changeDataBaseRootToolStripMenuItem
            // 
            this.changeDataBaseRootToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.changeDataBaseRootToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeDataBaseRootToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changeDataBaseRootToolStripMenuItem.Name = "changeDataBaseRootToolStripMenuItem";
            this.changeDataBaseRootToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.changeDataBaseRootToolStripMenuItem.Text = "Change DataBase Root";
            this.changeDataBaseRootToolStripMenuItem.Click += new System.EventHandler(this.changeDataBaseRootToolStripMenuItem_Click);
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.lightModeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lightModeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.lightModeToolStripMenuItem.Text = "Light Mode";
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1275, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 21;
            this.btnClose.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Animated = true;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.Green;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMinimize.Location = new System.Drawing.Point(1249, 30);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 21;
            this.btnMinimize.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.guna2CircleButton2_MouseHover);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 250;
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // toggleDarlMode
            // 
            this.toggleDarlMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.toggleDarlMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.toggleDarlMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleDarlMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleDarlMode.Location = new System.Drawing.Point(1156, 30);
            this.toggleDarlMode.Name = "toggleDarlMode";
            this.toggleDarlMode.Size = new System.Drawing.Size(35, 20);
            this.toggleDarlMode.TabIndex = 22;
            this.toggleDarlMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleDarlMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleDarlMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleDarlMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleDarlMode.CheckedChanged += new System.EventHandler(this.toggleDarlMode_CheckedChanged);
            // 
            // lblDarkmode
            // 
            this.lblDarkmode.AutoSize = true;
            this.lblDarkmode.BackColor = System.Drawing.Color.Transparent;
            this.lblDarkmode.ForeColor = System.Drawing.Color.White;
            this.lblDarkmode.Location = new System.Drawing.Point(1071, 31);
            this.lblDarkmode.Name = "lblDarkmode";
            this.lblDarkmode.Size = new System.Drawing.Size(76, 17);
            this.lblDarkmode.TabIndex = 23;
            this.lblDarkmode.Text = "Dark Mode";
            // 
            // gpboxSearch
            // 
            this.gpboxSearch.BackColor = System.Drawing.Color.Transparent;
            this.gpboxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.gpboxSearch.BorderRadius = 20;
            this.gpboxSearch.Controls.Add(this.guna2Button2);
            this.gpboxSearch.Controls.Add(this.txtSearch);
            this.gpboxSearch.Controls.Add(this.rdbtnObject);
            this.gpboxSearch.Controls.Add(this.rdbtnID);
            this.gpboxSearch.Controls.Add(this.rdbtnProtocol);
            this.gpboxSearch.Controls.Add(this.rdbtnUser);
            this.gpboxSearch.Controls.Add(this.rdbtnTime);
            this.gpboxSearch.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.gpboxSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.gpboxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpboxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gpboxSearch.Location = new System.Drawing.Point(529, 43);
            this.gpboxSearch.Name = "gpboxSearch";
            this.gpboxSearch.Size = new System.Drawing.Size(229, 150);
            this.gpboxSearch.TabIndex = 45;
            this.gpboxSearch.Text = "Search";
            this.gpboxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gpboxSearch.Visible = false;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(132, 115);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(70, 25);
            this.guna2Button2.TabIndex = 6;
            this.guna2Button2.Text = "Close";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(26, 1);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Serach";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(176, 35);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // rdbtnObject
            // 
            this.rdbtnObject.AutoSize = true;
            this.rdbtnObject.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnObject.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.rdbtnObject.CheckedState.BorderThickness = 0;
            this.rdbtnObject.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.rdbtnObject.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnObject.CheckedState.InnerOffset = -4;
            this.rdbtnObject.ForeColor = System.Drawing.Color.White;
            this.rdbtnObject.Location = new System.Drawing.Point(132, 85);
            this.rdbtnObject.Name = "rdbtnObject";
            this.rdbtnObject.Size = new System.Drawing.Size(60, 19);
            this.rdbtnObject.TabIndex = 5;
            this.rdbtnObject.Text = "Object";
            this.rdbtnObject.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnObject.UncheckedState.BorderThickness = 2;
            this.rdbtnObject.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnObject.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbtnObject.UseVisualStyleBackColor = false;
            // 
            // rdbtnID
            // 
            this.rdbtnID.AutoSize = true;
            this.rdbtnID.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnID.Checked = true;
            this.rdbtnID.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.rdbtnID.CheckedState.BorderThickness = 0;
            this.rdbtnID.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.rdbtnID.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnID.CheckedState.InnerOffset = -4;
            this.rdbtnID.ForeColor = System.Drawing.Color.White;
            this.rdbtnID.Location = new System.Drawing.Point(43, 58);
            this.rdbtnID.Name = "rdbtnID";
            this.rdbtnID.Size = new System.Drawing.Size(36, 19);
            this.rdbtnID.TabIndex = 1;
            this.rdbtnID.TabStop = true;
            this.rdbtnID.Text = "ID";
            this.rdbtnID.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnID.UncheckedState.BorderThickness = 2;
            this.rdbtnID.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnID.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbtnID.UseVisualStyleBackColor = false;
            // 
            // rdbtnProtocol
            // 
            this.rdbtnProtocol.AutoSize = true;
            this.rdbtnProtocol.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnProtocol.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.rdbtnProtocol.CheckedState.BorderThickness = 0;
            this.rdbtnProtocol.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.rdbtnProtocol.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnProtocol.CheckedState.InnerOffset = -4;
            this.rdbtnProtocol.ForeColor = System.Drawing.Color.White;
            this.rdbtnProtocol.Location = new System.Drawing.Point(132, 58);
            this.rdbtnProtocol.Name = "rdbtnProtocol";
            this.rdbtnProtocol.Size = new System.Drawing.Size(70, 19);
            this.rdbtnProtocol.TabIndex = 4;
            this.rdbtnProtocol.Text = "Protocol";
            this.rdbtnProtocol.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnProtocol.UncheckedState.BorderThickness = 2;
            this.rdbtnProtocol.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnProtocol.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbtnProtocol.UseVisualStyleBackColor = false;
            // 
            // rdbtnUser
            // 
            this.rdbtnUser.AutoSize = true;
            this.rdbtnUser.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnUser.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.rdbtnUser.CheckedState.BorderThickness = 0;
            this.rdbtnUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.rdbtnUser.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnUser.CheckedState.InnerOffset = -4;
            this.rdbtnUser.ForeColor = System.Drawing.Color.White;
            this.rdbtnUser.Location = new System.Drawing.Point(43, 85);
            this.rdbtnUser.Name = "rdbtnUser";
            this.rdbtnUser.Size = new System.Drawing.Size(48, 19);
            this.rdbtnUser.TabIndex = 2;
            this.rdbtnUser.Text = "User";
            this.rdbtnUser.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnUser.UncheckedState.BorderThickness = 2;
            this.rdbtnUser.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnUser.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbtnUser.UseVisualStyleBackColor = false;
            // 
            // rdbtnTime
            // 
            this.rdbtnTime.AutoSize = true;
            this.rdbtnTime.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnTime.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.rdbtnTime.CheckedState.BorderThickness = 0;
            this.rdbtnTime.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.rdbtnTime.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnTime.CheckedState.InnerOffset = -4;
            this.rdbtnTime.ForeColor = System.Drawing.Color.White;
            this.rdbtnTime.Location = new System.Drawing.Point(43, 112);
            this.rdbtnTime.Name = "rdbtnTime";
            this.rdbtnTime.Size = new System.Drawing.Size(51, 19);
            this.rdbtnTime.TabIndex = 3;
            this.rdbtnTime.Text = "Time";
            this.rdbtnTime.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnTime.UncheckedState.BorderThickness = 2;
            this.rdbtnTime.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnTime.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbtnTime.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Image = global::AZ24.Properties.Resources.pass50x50;
            this.label2.Location = new System.Drawing.Point(1163, 68);
            this.label2.MaximumSize = new System.Drawing.Size(50, 50);
            this.label2.MinimumSize = new System.Drawing.Size(50, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 50);
            this.label2.TabIndex = 46;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblWorkerLight
            // 
            this.lblWorkerLight.AutoSize = true;
            this.lblWorkerLight.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWorkerLight.Image = global::AZ24.Properties.Resources.worker2;
            this.lblWorkerLight.Location = new System.Drawing.Point(1219, 68);
            this.lblWorkerLight.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblWorkerLight.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblWorkerLight.Name = "lblWorkerLight";
            this.lblWorkerLight.Size = new System.Drawing.Size(50, 50);
            this.lblWorkerLight.TabIndex = 20;
            this.lblWorkerLight.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblworkerDark
            // 
            this.lblworkerDark.AutoSize = true;
            this.lblworkerDark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblworkerDark.Image = global::AZ24.Properties.Resources.worker;
            this.lblworkerDark.Location = new System.Drawing.Point(1219, 68);
            this.lblworkerDark.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblworkerDark.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblworkerDark.Name = "lblworkerDark";
            this.lblworkerDark.Size = new System.Drawing.Size(50, 50);
            this.lblworkerDark.TabIndex = 20;
            this.lblworkerDark.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblback
            // 
            this.lblback.AutoSize = true;
            this.lblback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblback.Image = global::AZ24.Properties.Resources.Untitled_1;
            this.lblback.Location = new System.Drawing.Point(22, 49);
            this.lblback.MaximumSize = new System.Drawing.Size(113, 30);
            this.lblback.MinimumSize = new System.Drawing.Size(113, 30);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(113, 30);
            this.lblback.TabIndex = 19;
            this.lblback.Click += new System.EventHandler(this.lblback_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::AZ24.Properties.Resources.logo;
            this.label3.Location = new System.Drawing.Point(589, 24);
            this.label3.MaximumSize = new System.Drawing.Size(500, 500);
            this.label3.MinimumSize = new System.Drawing.Size(100, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 100);
            this.label3.TabIndex = 17;
            // 
            // gpboxTimeEdit
            // 
            this.gpboxTimeEdit.BackColor = System.Drawing.Color.Transparent;
            this.gpboxTimeEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.gpboxTimeEdit.BorderRadius = 20;
            this.gpboxTimeEdit.Controls.Add(this.guna2Button4);
            this.gpboxTimeEdit.Controls.Add(this.toggleSwitchTime1);
            this.gpboxTimeEdit.Controls.Add(this.guna2Button3);
            this.gpboxTimeEdit.Controls.Add(this.txtIDTimeEdit);
            this.gpboxTimeEdit.Controls.Add(this.txtTimeEdit);
            this.gpboxTimeEdit.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.gpboxTimeEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.gpboxTimeEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpboxTimeEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gpboxTimeEdit.Location = new System.Drawing.Point(778, 43);
            this.gpboxTimeEdit.Name = "gpboxTimeEdit";
            this.gpboxTimeEdit.Size = new System.Drawing.Size(229, 140);
            this.gpboxTimeEdit.TabIndex = 46;
            this.gpboxTimeEdit.Text = "Search";
            this.gpboxTimeEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gpboxTimeEdit.Visible = false;
            this.gpboxTimeEdit.Click += new System.EventHandler(this.gpboxTimeEdit_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(153, 98);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(70, 25);
            this.guna2Button3.TabIndex = 6;
            this.guna2Button3.Text = "Close";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // txtTimeEdit
            // 
            this.txtTimeEdit.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeEdit.BorderRadius = 15;
            this.txtTimeEdit.BorderThickness = 2;
            this.txtTimeEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeEdit.DefaultText = "";
            this.txtTimeEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimeEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimeEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimeEdit.Enabled = false;
            this.txtTimeEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtTimeEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeEdit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTimeEdit.ForeColor = System.Drawing.Color.White;
            this.txtTimeEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimeEdit.Location = new System.Drawing.Point(26, 48);
            this.txtTimeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeEdit.Name = "txtTimeEdit";
            this.txtTimeEdit.PasswordChar = '\0';
            this.txtTimeEdit.PlaceholderText = "Time";
            this.txtTimeEdit.SelectedText = "";
            this.txtTimeEdit.Size = new System.Drawing.Size(176, 35);
            this.txtTimeEdit.TabIndex = 0;
            // 
            // txtIDTimeEdit
            // 
            this.txtIDTimeEdit.BackColor = System.Drawing.Color.Transparent;
            this.txtIDTimeEdit.BorderRadius = 15;
            this.txtIDTimeEdit.BorderThickness = 2;
            this.txtIDTimeEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDTimeEdit.DefaultText = "";
            this.txtIDTimeEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDTimeEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDTimeEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDTimeEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDTimeEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtIDTimeEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDTimeEdit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtIDTimeEdit.ForeColor = System.Drawing.Color.White;
            this.txtIDTimeEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDTimeEdit.Location = new System.Drawing.Point(26, 11);
            this.txtIDTimeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDTimeEdit.Name = "txtIDTimeEdit";
            this.txtIDTimeEdit.PasswordChar = '\0';
            this.txtIDTimeEdit.PlaceholderText = "ID";
            this.txtIDTimeEdit.SelectedText = "";
            this.txtIDTimeEdit.Size = new System.Drawing.Size(176, 35);
            this.txtIDTimeEdit.TabIndex = 0;
            // 
            // toggleSwitchTime1
            // 
            this.toggleSwitchTime1.Checked = true;
            this.toggleSwitchTime1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.toggleSwitchTime1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.toggleSwitchTime1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwitchTime1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwitchTime1.Location = new System.Drawing.Point(23, 98);
            this.toggleSwitchTime1.Name = "toggleSwitchTime1";
            this.toggleSwitchTime1.Size = new System.Drawing.Size(35, 20);
            this.toggleSwitchTime1.TabIndex = 43;
            this.toggleSwitchTime1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSwitchTime1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleSwitchTime1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwitchTime1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwitchTime1.CheckedChanged += new System.EventHandler(this.toggleSwitchTime_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem1.Text = "menuTimeEdit";
            this.toolStripMenuItem1.Visible = false;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Green;
            this.guna2Button4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(64, 98);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(83, 25);
            this.guna2Button4.TabIndex = 44;
            this.guna2Button4.Text = "Time Edit";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1301, 743);
            this.Controls.Add(this.gpboxTimeEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpboxSearch);
            this.Controls.Add(this.lblDarkmode);
            this.Controls.Add(this.toggleDarlMode);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblWorkerLight);
            this.Controls.Add(this.lblworkerDark);
            this.Controls.Add(this.lblback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtObjectes);
            this.Controls.Add(this.txtProtocoling);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblClocks);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AZ24 Protocoling App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.gpboxSearch.ResumeLayout(false);
            this.gpboxSearch.PerformLayout();
            this.gpboxTimeEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblClocks;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtProtocoling;
        private Guna.UI2.WinForms.Guna2TextBox txtObjectes;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeUser;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblback;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label lblworkerDark;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRowToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDataBaseRootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblDarkmode;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleDarlMode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuMinimize;
        private System.Windows.Forms.Label lblWorkerLight;
        private System.Windows.Forms.ToolStripMenuItem SearchStripMenuItem1;
        private Guna.UI2.WinForms.Guna2GroupBox gpboxSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnObject;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnID;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnProtocol;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnUser;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnTime;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSort;
        private System.Windows.Forms.ToolStripMenuItem sortByID;
        private System.Windows.Forms.ToolStripMenuItem sortByUSER;
        private System.Windows.Forms.ToolStripMenuItem sortByTime;
        private System.Windows.Forms.ToolStripMenuItem sortByProtocol;
        private System.Windows.Forms.ToolStripMenuItem sortByObject;
        private Guna.UI2.WinForms.Guna2GroupBox gpboxTimeEdit;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2TextBox txtIDTimeEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtTimeEdit;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleSwitchTime1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}

