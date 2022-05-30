namespace ConnectingAccessCsharp
{
    partial class formInputBox
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
            this.btnMsgBoxButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInputBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtIDN = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMsgBoxCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnMsgBoxYes = new Guna.UI2.WinForms.Guna2Button();
            this.btnMsgBoxNo = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gpboxYesOrNo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpboxEditTable = new System.Windows.Forms.GroupBox();
            this.btnInputBoxEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtEditboxinput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdObject = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbProtocol = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gpBoxEdit = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gpboxYesOrNo.SuspendLayout();
            this.gpboxEditTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMsgBoxButton
            // 
            this.btnMsgBoxButton.Animated = true;
            this.btnMsgBoxButton.BorderColor = System.Drawing.Color.White;
            this.btnMsgBoxButton.BorderRadius = 20;
            this.btnMsgBoxButton.BorderThickness = 3;
            this.btnMsgBoxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsgBoxButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMsgBoxButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMsgBoxButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMsgBoxButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMsgBoxButton.FillColor = System.Drawing.Color.White;
            this.btnMsgBoxButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMsgBoxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnMsgBoxButton.Location = new System.Drawing.Point(34, 143);
            this.btnMsgBoxButton.Name = "btnMsgBoxButton";
            this.btnMsgBoxButton.Size = new System.Drawing.Size(144, 43);
            this.btnMsgBoxButton.TabIndex = 21;
            this.btnMsgBoxButton.Text = "Delete";
            this.btnMsgBoxButton.Click += new System.EventHandler(this.btnMsgBoxButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInputBox
            // 
            this.lblInputBox.AutoSize = true;
            this.lblInputBox.ForeColor = System.Drawing.Color.White;
            this.lblInputBox.Location = new System.Drawing.Point(76, 64);
            this.lblInputBox.Name = "lblInputBox";
            this.lblInputBox.Size = new System.Drawing.Size(192, 17);
            this.lblInputBox.TabIndex = 19;
            this.lblInputBox.Text = "Type the ID number to Delete";
            this.lblInputBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::ConnectingAccessCsharp.Properties.Resources.logo1Black;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.MaximumSize = new System.Drawing.Size(500, 500);
            this.label3.MinimumSize = new System.Drawing.Size(50, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 50);
            this.label3.TabIndex = 22;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 40;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // txtIDN
            // 
            this.txtIDN.BorderRadius = 10;
            this.txtIDN.BorderThickness = 2;
            this.txtIDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDN.DefaultText = "";
            this.txtIDN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtIDN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDN.ForeColor = System.Drawing.Color.White;
            this.txtIDN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDN.Location = new System.Drawing.Point(34, 90);
            this.txtIDN.Name = "txtIDN";
            this.txtIDN.PasswordChar = '\0';
            this.txtIDN.PlaceholderText = "ID Number";
            this.txtIDN.SelectedText = "";
            this.txtIDN.Size = new System.Drawing.Size(263, 36);
            this.txtIDN.TabIndex = 23;
            // 
            // btnMsgBoxCancel
            // 
            this.btnMsgBoxCancel.Animated = true;
            this.btnMsgBoxCancel.BorderColor = System.Drawing.Color.White;
            this.btnMsgBoxCancel.BorderRadius = 20;
            this.btnMsgBoxCancel.BorderThickness = 3;
            this.btnMsgBoxCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsgBoxCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMsgBoxCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMsgBoxCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMsgBoxCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMsgBoxCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnMsgBoxCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMsgBoxCancel.ForeColor = System.Drawing.Color.White;
            this.btnMsgBoxCancel.Location = new System.Drawing.Point(184, 143);
            this.btnMsgBoxCancel.Name = "btnMsgBoxCancel";
            this.btnMsgBoxCancel.Size = new System.Drawing.Size(114, 43);
            this.btnMsgBoxCancel.TabIndex = 21;
            this.btnMsgBoxCancel.Text = "Cancel";
            this.btnMsgBoxCancel.Click += new System.EventHandler(this.btnMsgBoxCancel_Click);
            // 
            // btnMsgBoxYes
            // 
            this.btnMsgBoxYes.Animated = true;
            this.btnMsgBoxYes.BackColor = System.Drawing.Color.White;
            this.btnMsgBoxYes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnMsgBoxYes.BorderRadius = 20;
            this.btnMsgBoxYes.BorderThickness = 3;
            this.btnMsgBoxYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsgBoxYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMsgBoxYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMsgBoxYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMsgBoxYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMsgBoxYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnMsgBoxYes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMsgBoxYes.ForeColor = System.Drawing.Color.White;
            this.btnMsgBoxYes.Location = new System.Drawing.Point(37, 70);
            this.btnMsgBoxYes.Name = "btnMsgBoxYes";
            this.btnMsgBoxYes.Size = new System.Drawing.Size(144, 43);
            this.btnMsgBoxYes.TabIndex = 27;
            this.btnMsgBoxYes.Text = "Yes";
            this.btnMsgBoxYes.Click += new System.EventHandler(this.btnMsgBoxYes_Click);
            // 
            // btnMsgBoxNo
            // 
            this.btnMsgBoxNo.Animated = true;
            this.btnMsgBoxNo.BackColor = System.Drawing.Color.White;
            this.btnMsgBoxNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnMsgBoxNo.BorderRadius = 20;
            this.btnMsgBoxNo.BorderThickness = 3;
            this.btnMsgBoxNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsgBoxNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMsgBoxNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMsgBoxNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMsgBoxNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMsgBoxNo.FillColor = System.Drawing.Color.White;
            this.btnMsgBoxNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMsgBoxNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnMsgBoxNo.Location = new System.Drawing.Point(187, 70);
            this.btnMsgBoxNo.Name = "btnMsgBoxNo";
            this.btnMsgBoxNo.Size = new System.Drawing.Size(113, 43);
            this.btnMsgBoxNo.TabIndex = 26;
            this.btnMsgBoxNo.Text = "No";
            this.btnMsgBoxNo.Click += new System.EventHandler(this.btnMsgBoxNo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(115, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Are You Sure?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpboxYesOrNo
            // 
            this.gpboxYesOrNo.BackColor = System.Drawing.Color.White;
            this.gpboxYesOrNo.Controls.Add(this.btnMsgBoxYes);
            this.gpboxYesOrNo.Controls.Add(this.label5);
            this.gpboxYesOrNo.Controls.Add(this.label2);
            this.gpboxYesOrNo.Controls.Add(this.btnMsgBoxNo);
            this.gpboxYesOrNo.Enabled = false;
            this.gpboxYesOrNo.ForeColor = System.Drawing.Color.White;
            this.gpboxYesOrNo.Location = new System.Drawing.Point(-3, 388);
            this.gpboxYesOrNo.Name = "gpboxYesOrNo";
            this.gpboxYesOrNo.Size = new System.Drawing.Size(340, 135);
            this.gpboxYesOrNo.TabIndex = 28;
            this.gpboxYesOrNo.TabStop = false;
            this.gpboxYesOrNo.Visible = false;
            this.gpboxYesOrNo.Enter += new System.EventHandler(this.gpboxYesOrNo_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label5.Location = new System.Drawing.Point(205, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 25;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gpboxEditTable
            // 
            this.gpboxEditTable.BackColor = System.Drawing.Color.White;
            this.gpboxEditTable.Controls.Add(this.btnInputBoxEdit);
            this.gpboxEditTable.Controls.Add(this.txtEditboxinput);
            this.gpboxEditTable.Controls.Add(this.label4);
            this.gpboxEditTable.Controls.Add(this.rdObject);
            this.gpboxEditTable.Controls.Add(this.rbProtocol);
            this.gpboxEditTable.Enabled = false;
            this.gpboxEditTable.Location = new System.Drawing.Point(-3, 209);
            this.gpboxEditTable.Name = "gpboxEditTable";
            this.gpboxEditTable.Size = new System.Drawing.Size(340, 175);
            this.gpboxEditTable.TabIndex = 29;
            this.gpboxEditTable.TabStop = false;
            this.gpboxEditTable.Visible = false;
            // 
            // btnInputBoxEdit
            // 
            this.btnInputBoxEdit.BorderRadius = 20;
            this.btnInputBoxEdit.BorderThickness = 3;
            this.btnInputBoxEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInputBoxEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInputBoxEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInputBoxEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInputBoxEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInputBoxEdit.ForeColor = System.Drawing.Color.White;
            this.btnInputBoxEdit.Location = new System.Drawing.Point(97, 106);
            this.btnInputBoxEdit.Name = "btnInputBoxEdit";
            this.btnInputBoxEdit.Size = new System.Drawing.Size(150, 45);
            this.btnInputBoxEdit.TabIndex = 3;
            this.btnInputBoxEdit.Text = "Edit";
            this.btnInputBoxEdit.Click += new System.EventHandler(this.btnInputBoxEdit_Click);
            // 
            // txtEditboxinput
            // 
            this.txtEditboxinput.BorderRadius = 10;
            this.txtEditboxinput.BorderThickness = 3;
            this.txtEditboxinput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditboxinput.DefaultText = "";
            this.txtEditboxinput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEditboxinput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEditboxinput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditboxinput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditboxinput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEditboxinput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEditboxinput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEditboxinput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEditboxinput.Location = new System.Drawing.Point(37, 59);
            this.txtEditboxinput.Name = "txtEditboxinput";
            this.txtEditboxinput.PasswordChar = '\0';
            this.txtEditboxinput.PlaceholderText = "Edit";
            this.txtEditboxinput.SelectedText = "";
            this.txtEditboxinput.Size = new System.Drawing.Size(263, 36);
            this.txtEditboxinput.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Choose to Edit:";
            // 
            // rdObject
            // 
            this.rdObject.AutoSize = true;
            this.rdObject.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdObject.CheckedState.BorderThickness = 0;
            this.rdObject.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdObject.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdObject.CheckedState.InnerOffset = -4;
            this.rdObject.Location = new System.Drawing.Point(234, 22);
            this.rdObject.Name = "rdObject";
            this.rdObject.Size = new System.Drawing.Size(66, 21);
            this.rdObject.TabIndex = 0;
            this.rdObject.Text = "Object";
            this.rdObject.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdObject.UncheckedState.BorderThickness = 2;
            this.rdObject.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdObject.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbProtocol
            // 
            this.rbProtocol.AutoSize = true;
            this.rbProtocol.Checked = true;
            this.rbProtocol.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbProtocol.CheckedState.BorderThickness = 0;
            this.rbProtocol.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbProtocol.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbProtocol.CheckedState.InnerOffset = -4;
            this.rbProtocol.Location = new System.Drawing.Point(143, 22);
            this.rbProtocol.Name = "rbProtocol";
            this.rbProtocol.Size = new System.Drawing.Size(78, 21);
            this.rbProtocol.TabIndex = 0;
            this.rbProtocol.TabStop = true;
            this.rbProtocol.Text = "Protocol\r\n";
            this.rbProtocol.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbProtocol.UncheckedState.BorderThickness = 2;
            this.rbProtocol.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbProtocol.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // gpBoxEdit
            // 
            this.gpBoxEdit.Name = "gpBoxEdit";
            this.gpBoxEdit.Size = new System.Drawing.Size(61, 4);
            // 
            // formInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(329, 522);
            this.Controls.Add(this.gpboxEditTable);
            this.Controls.Add(this.gpboxYesOrNo);
            this.Controls.Add(this.txtIDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMsgBoxCancel);
            this.Controls.Add(this.btnMsgBoxButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInputBox);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formInputBox";
            this.Text = "formInputBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formInputBox_Load);
            this.gpboxYesOrNo.ResumeLayout(false);
            this.gpboxYesOrNo.PerformLayout();
            this.gpboxEditTable.ResumeLayout(false);
            this.gpboxEditTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnMsgBoxButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInputBox;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtIDN;
        private Guna.UI2.WinForms.Guna2Button btnMsgBoxCancel;
        private Guna.UI2.WinForms.Guna2Button btnMsgBoxYes;
        private Guna.UI2.WinForms.Guna2Button btnMsgBoxNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpboxYesOrNo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpboxEditTable;
        private MetroFramework.Controls.MetroContextMenu gpBoxEdit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RadioButton rdObject;
        private Guna.UI2.WinForms.Guna2RadioButton rbProtocol;
        private Guna.UI2.WinForms.Guna2Button btnInputBoxEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtEditboxinput;
    }
}