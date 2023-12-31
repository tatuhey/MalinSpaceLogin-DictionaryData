﻿namespace MalinSpaceLogin_DictionaryData
{
    partial class AdminGUI
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.gbShortcuts = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stText = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbAdmin.SuspendLayout();
            this.gbShortcuts.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 42);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Staff Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(23, 16);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(43, 13);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Staff ID";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(72, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(133, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(72, 16);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(133, 20);
            this.tbID.TabIndex = 3;
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.lbID);
            this.gbAdmin.Controls.Add(this.lbName);
            this.gbAdmin.Controls.Add(this.tbName);
            this.gbAdmin.Controls.Add(this.tbID);
            this.gbAdmin.Location = new System.Drawing.Point(12, 12);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(215, 88);
            this.gbAdmin.TabIndex = 7;
            this.gbAdmin.TabStop = false;
            // 
            // gbShortcuts
            // 
            this.gbShortcuts.Controls.Add(this.label4);
            this.gbShortcuts.Controls.Add(this.label3);
            this.gbShortcuts.Controls.Add(this.label2);
            this.gbShortcuts.Controls.Add(this.label1);
            this.gbShortcuts.Location = new System.Drawing.Point(233, 17);
            this.gbShortcuts.Name = "gbShortcuts";
            this.gbShortcuts.Size = new System.Drawing.Size(116, 83);
            this.gbShortcuts.TabIndex = 8;
            this.gbShortcuts.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ctrl + D | Delete staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ctrl + U | Update staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ctrl + A | Add staff";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alt + L | Close form";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 107);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(360, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stText
            // 
            this.stText.Name = "stText";
            this.stText.Size = new System.Drawing.Size(0, 17);
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 129);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbShortcuts);
            this.Controls.Add(this.gbAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminGUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminGUI_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminGUI_KeyDown);
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.gbShortcuts.ResumeLayout(false);
            this.gbShortcuts.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        internal System.Windows.Forms.TextBox tbName;
        internal System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.GroupBox gbShortcuts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stText;
    }
}