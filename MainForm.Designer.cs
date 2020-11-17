namespace FaceApp
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfileUser = new System.Windows.Forms.PictureBox();
            this.buttonLikeCommentFeature = new System.Windows.Forms.Button();
            this.buttonBestFriendFeature = new System.Windows.Forms.Button();
            this.textBoxLikeCommentFriends = new System.Windows.Forms.TextBox();
            this.labelLikeComment = new System.Windows.Forms.Label();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.textBoxBestFriend = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(-4, 100);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(111, 28);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfileUser
            // 
            this.pictureBoxProfileUser.Location = new System.Drawing.Point(145, 214);
            this.pictureBoxProfileUser.Name = "pictureBoxProfileUser";
            this.pictureBoxProfileUser.Size = new System.Drawing.Size(107, 104);
            this.pictureBoxProfileUser.TabIndex = 1;
            this.pictureBoxProfileUser.TabStop = false;
            // 
            // buttonLikeCommentFeature
            // 
            this.buttonLikeCommentFeature.Location = new System.Drawing.Point(23, 182);
            this.buttonLikeCommentFeature.Name = "buttonLikeCommentFeature";
            this.buttonLikeCommentFeature.Size = new System.Drawing.Size(150, 50);
            this.buttonLikeCommentFeature.TabIndex = 2;
            this.buttonLikeCommentFeature.Text = "Say thanks (like/comment)  to birthday greetings from friends I didn\'t reply to";
            this.buttonLikeCommentFeature.UseVisualStyleBackColor = true;
            this.buttonLikeCommentFeature.Visible = false;
            this.buttonLikeCommentFeature.Click += new System.EventHandler(this.buttonLikeCommentFeature_Click);
            // 
            // buttonBestFriendFeature
            // 
            this.buttonBestFriendFeature.Location = new System.Drawing.Point(205, 182);
            this.buttonBestFriendFeature.Name = "buttonBestFriendFeature";
            this.buttonBestFriendFeature.Size = new System.Drawing.Size(151, 50);
            this.buttonBestFriendFeature.TabIndex = 3;
            this.buttonBestFriendFeature.Text = "show me my  best friends  (the friends that is tagged the most in my picture)";
            this.buttonBestFriendFeature.UseVisualStyleBackColor = true;
            this.buttonBestFriendFeature.Visible = false;
            this.buttonBestFriendFeature.Click += new System.EventHandler(this.buttonBestFriendsFeature_Click);
            // 
            // textBoxLikeCommentFriends
            // 
            this.textBoxLikeCommentFriends.Location = new System.Drawing.Point(23, 258);
            this.textBoxLikeCommentFriends.Multiline = true;
            this.textBoxLikeCommentFriends.Name = "textBoxLikeCommentFriends";
            this.textBoxLikeCommentFriends.Size = new System.Drawing.Size(165, 188);
            this.textBoxLikeCommentFriends.TabIndex = 4;
            this.textBoxLikeCommentFriends.Visible = false;
            // 
            // labelLikeComment
            // 
            this.labelLikeComment.AutoSize = true;
            this.labelLikeComment.Location = new System.Drawing.Point(9, 242);
            this.labelLikeComment.Name = "labelLikeComment";
            this.labelLikeComment.Size = new System.Drawing.Size(206, 13);
            this.labelLikeComment.TabIndex = 5;
            this.labelLikeComment.Text = "List of friends we liked/commented for you";
            this.labelLikeComment.Visible = false;
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AccessibleName = "checkBoxRememberUser";
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(12, 134);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRememberUser.TabIndex = 7;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            this.checkBoxRememberUser.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBoxBestFriend
            // 
            this.textBoxBestFriend.Location = new System.Drawing.Point(205, 258);
            this.textBoxBestFriend.Multiline = true;
            this.textBoxBestFriend.Name = "textBoxBestFriend";
            this.textBoxBestFriend.Size = new System.Drawing.Size(151, 188);
            this.textBoxBestFriend.TabIndex = 8;
            this.textBoxBestFriend.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(128, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 76);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, -22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 468);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 458);
            this.Controls.Add(this.labelLikeComment);
            this.Controls.Add(this.buttonLikeCommentFeature);
            this.Controls.Add(this.textBoxBestFriend);
            this.Controls.Add(this.buttonBestFriendFeature);
            this.Controls.Add(this.textBoxLikeCommentFriends);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxProfileUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "FaceApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfileUser;
        private System.Windows.Forms.Button buttonLikeCommentFeature;
        private System.Windows.Forms.Button buttonBestFriendFeature;
        private System.Windows.Forms.TextBox textBoxLikeCommentFriends;
        private System.Windows.Forms.Label labelLikeComment;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.TextBox textBoxBestFriend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

