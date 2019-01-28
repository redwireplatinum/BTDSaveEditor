namespace DgDecryptor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.select_path = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.feedback = new System.Windows.Forms.Label();
            this.bypass = new System.Windows.Forms.CheckBox();
            this.Decrypt0r = new System.Windows.Forms.GroupBox();
            this.flag_bypass = new System.Windows.Forms.CheckBox();
            this.Decrypt0r.SuspendLayout();
            this.SuspendLayout();
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(6, 45);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(126, 23);
            this.encrypt.TabIndex = 0;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(138, 45);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(116, 23);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(6, 19);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(209, 20);
            this.pathBox.TabIndex = 2;
            // 
            // select_path
            // 
            this.select_path.Location = new System.Drawing.Point(221, 19);
            this.select_path.Name = "select_path";
            this.select_path.Size = new System.Drawing.Size(33, 20);
            this.select_path.TabIndex = 3;
            this.select_path.Text = "...";
            this.select_path.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.select_path.UseVisualStyleBackColor = true;
            this.select_path.Click += new System.EventHandler(this.select_path_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(233, 117);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Credits";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // feedback
            // 
            this.feedback.Location = new System.Drawing.Point(12, 117);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(114, 13);
            this.feedback.TabIndex = 5;
            this.feedback.Text = "Idle";
            // 
            // bypass
            // 
            this.bypass.AutoSize = true;
            this.bypass.Location = new System.Drawing.Point(132, 65);
            this.bypass.Name = "bypass";
            this.bypass.Size = new System.Drawing.Size(95, 17);
            this.bypass.TabIndex = 6;
            this.bypass.Text = "Battles Bypass";
            this.bypass.UseVisualStyleBackColor = true;
            // 
            // Decrypt0r
            // 
            this.Decrypt0r.Controls.Add(this.flag_bypass);
            this.Decrypt0r.Controls.Add(this.pathBox);
            this.Decrypt0r.Controls.Add(this.select_path);
            this.Decrypt0r.Controls.Add(this.decrypt);
            this.Decrypt0r.Controls.Add(this.encrypt);
            this.Decrypt0r.Location = new System.Drawing.Point(12, 12);
            this.Decrypt0r.Name = "Decrypt0r";
            this.Decrypt0r.Size = new System.Drawing.Size(260, 102);
            this.Decrypt0r.TabIndex = 7;
            this.Decrypt0r.TabStop = false;
            this.Decrypt0r.Text = "Control";
            // 
            // flag_bypass
            // 
            this.flag_bypass.AutoSize = true;
            this.flag_bypass.Location = new System.Drawing.Point(6, 74);
            this.flag_bypass.Name = "flag_bypass";
            this.flag_bypass.Size = new System.Drawing.Size(95, 17);
            this.flag_bypass.TabIndex = 1;
            this.flag_bypass.Text = "Battles Bypass";
            this.flag_bypass.UseVisualStyleBackColor = true;
            this.flag_bypass.CheckedChanged += new System.EventHandler(this.flag_bypass_CheckedChanged);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.Decrypt0r);
            this.Controls.Add(this.bypass);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Nk Decrypt0r";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Decrypt0r.ResumeLayout(false);
            this.Decrypt0r.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button select_path;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label feedback;
        private System.Windows.Forms.CheckBox bypass;
        private System.Windows.Forms.GroupBox Decrypt0r;
        private System.Windows.Forms.CheckBox flag_bypass;
    }
}

