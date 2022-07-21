namespace ConnectingAccessCsharp
{
    partial class Form1
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
            this.gpboxAddClient = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnCloseAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gpboxAddClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxAddClient
            // 
            this.gpboxAddClient.BackColor = System.Drawing.Color.Transparent;
            this.gpboxAddClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.gpboxAddClient.BorderRadius = 20;
            this.gpboxAddClient.Controls.Add(this.guna2Button1);
            this.gpboxAddClient.Controls.Add(this.txtAddPassword);
            this.gpboxAddClient.Controls.Add(this.btnCloseAdd);
            this.gpboxAddClient.Controls.Add(this.txtAddClient);
            this.gpboxAddClient.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.gpboxAddClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.gpboxAddClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpboxAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gpboxAddClient.Location = new System.Drawing.Point(128, 73);
            this.gpboxAddClient.Name = "gpboxAddClient";
            this.gpboxAddClient.Size = new System.Drawing.Size(267, 211);
            this.gpboxAddClient.TabIndex = 46;
            this.gpboxAddClient.Text = "Add Client";
            this.gpboxAddClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gpboxAddClient.Visible = false;
            // 
            // btnCloseAdd
            // 
            this.btnCloseAdd.BorderRadius = 10;
            this.btnCloseAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloseAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCloseAdd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCloseAdd.ForeColor = System.Drawing.Color.White;
            this.btnCloseAdd.Location = new System.Drawing.Point(28, 150);
            this.btnCloseAdd.Name = "btnCloseAdd";
            this.btnCloseAdd.Size = new System.Drawing.Size(83, 35);
            this.btnCloseAdd.TabIndex = 6;
            this.btnCloseAdd.Text = "Close";
            // 
            // txtAddClient
            // 
            this.txtAddClient.BackColor = System.Drawing.Color.Transparent;
            this.txtAddClient.BorderRadius = 15;
            this.txtAddClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddClient.DefaultText = "";
            this.txtAddClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtAddClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddClient.ForeColor = System.Drawing.Color.White;
            this.txtAddClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddClient.Location = new System.Drawing.Point(28, 52);
            this.txtAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddClient.Name = "txtAddClient";
            this.txtAddClient.PasswordChar = '\0';
            this.txtAddClient.PlaceholderText = "Client Name";
            this.txtAddClient.SelectedText = "";
            this.txtAddClient.Size = new System.Drawing.Size(218, 35);
            this.txtAddClient.TabIndex = 0;
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.BorderRadius = 15;
            this.txtAddPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddPassword.DefaultText = "";
            this.txtAddPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtAddPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPassword.Location = new System.Drawing.Point(28, 94);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.PasswordChar = '\0';
            this.txtAddPassword.PlaceholderText = "Password";
            this.txtAddPassword.SelectedText = "";
            this.txtAddPassword.Size = new System.Drawing.Size(218, 35);
            this.txtAddPassword.TabIndex = 7;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(117, 150);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(129, 35);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpboxAddClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpboxAddClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gpboxAddClient;
        private Guna.UI2.WinForms.Guna2TextBox txtAddPassword;
        private Guna.UI2.WinForms.Guna2Button btnCloseAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtAddClient;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}