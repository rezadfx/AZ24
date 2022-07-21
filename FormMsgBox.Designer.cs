namespace ConnectingAccessCsharp
{
    partial class formMsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMsgBox));
            this.txtMsgBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnMsgBoxOk = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMsgBox
            // 
            this.txtMsgBox.AutoSize = true;
            this.txtMsgBox.Location = new System.Drawing.Point(69, 36);
            this.txtMsgBox.Name = "txtMsgBox";
            this.txtMsgBox.Size = new System.Drawing.Size(35, 17);
            this.txtMsgBox.TabIndex = 0;
            this.txtMsgBox.Text = "User";
            this.txtMsgBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMsgBox.Click += new System.EventHandler(this.txtMsgBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnMsgBoxOk
            // 
            this.btnMsgBoxOk.Animated = true;
            this.btnMsgBoxOk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(171)))), ((int)(((byte)(103)))));
            this.btnMsgBoxOk.BorderRadius = 20;
            this.btnMsgBoxOk.BorderThickness = 2;
            this.btnMsgBoxOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsgBoxOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMsgBoxOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMsgBoxOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMsgBoxOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMsgBoxOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnMsgBoxOk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMsgBoxOk.ForeColor = System.Drawing.Color.White;
            this.btnMsgBoxOk.Location = new System.Drawing.Point(116, 56);
            this.btnMsgBoxOk.Name = "btnMsgBoxOk";
            this.btnMsgBoxOk.Size = new System.Drawing.Size(54, 43);
            this.btnMsgBoxOk.TabIndex = 16;
            this.btnMsgBoxOk.Text = "OK";
            this.btnMsgBoxOk.Click += new System.EventHandler(this.btnMsgBoxOk_Click);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 40;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::AZ24.Properties.Resources.logo1Black;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.MaximumSize = new System.Drawing.Size(500, 500);
            this.label3.MinimumSize = new System.Drawing.Size(50, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 50);
            this.label3.TabIndex = 18;
            // 
            // formMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(282, 111);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMsgBoxOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMsgBox);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMsgBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMsgBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMsgBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnMsgBoxOk;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}