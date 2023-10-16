namespace MalinSpaceLogin_DictionaryData
{
    partial class GeneralGUI
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
            this.lbStaffMain = new System.Windows.Forms.ListBox();
            this.lbStaffSecondary = new System.Windows.Forms.ListBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.gbShortcut = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.gbShortcut.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStaffMain
            // 
            this.lbStaffMain.FormattingEnabled = true;
            this.lbStaffMain.Location = new System.Drawing.Point(54, 45);
            this.lbStaffMain.Name = "lbStaffMain";
            this.lbStaffMain.Size = new System.Drawing.Size(196, 355);
            this.lbStaffMain.TabIndex = 0;
            // 
            // lbStaffSecondary
            // 
            this.lbStaffSecondary.FormattingEnabled = true;
            this.lbStaffSecondary.Location = new System.Drawing.Point(302, 214);
            this.lbStaffSecondary.Name = "lbStaffSecondary";
            this.lbStaffSecondary.Size = new System.Drawing.Size(196, 186);
            this.lbStaffSecondary.TabIndex = 1;
            this.lbStaffSecondary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbStaffSecondary_KeyDown);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Staff Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(6, 66);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(43, 13);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "Staff ID";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(80, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(80, 66);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 5;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            this.tbID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbID_KeyDown);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.tbID);
            this.gbLogin.Controls.Add(this.lbName);
            this.gbLogin.Controls.Add(this.tbName);
            this.gbLogin.Controls.Add(this.lbID);
            this.gbLogin.Location = new System.Drawing.Point(302, 45);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(196, 115);
            this.gbLogin.TabIndex = 6;
            this.gbLogin.TabStop = false;
            // 
            // gbShortcut
            // 
            this.gbShortcut.Controls.Add(this.label3);
            this.gbShortcut.Controls.Add(this.label2);
            this.gbShortcut.Controls.Add(this.label1);
            this.gbShortcut.Location = new System.Drawing.Point(549, 45);
            this.gbShortcut.Name = "gbShortcut";
            this.gbShortcut.Size = new System.Drawing.Size(200, 100);
            this.gbShortcut.TabIndex = 7;
            this.gbShortcut.TabStop = false;
            this.gbShortcut.Text = "Shortcuts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // GeneralGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbShortcut);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.lbStaffSecondary);
            this.Controls.Add(this.lbStaffMain);
            this.Name = "GeneralGUI";
            this.Text = "Malin Staff Details";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbShortcut.ResumeLayout(false);
            this.gbShortcut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbStaffMain;
        private System.Windows.Forms.ListBox lbStaffSecondary;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.GroupBox gbShortcut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

