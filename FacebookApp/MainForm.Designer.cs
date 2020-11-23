namespace FacebookApp
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
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.WritePostLabel = new System.Windows.Forms.Label();
            this.PostTextBox = new System.Windows.Forms.RichTextBox();
            this.PostButton = new System.Windows.Forms.Button();
            this.FriendsLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.FriendsComboBox = new System.Windows.Forms.ComboBox();
            this.MessageComboBox = new System.Windows.Forms.ComboBox();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.AddPhotoCheckBox = new System.Windows.Forms.CheckBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.AlbumsComboBox = new System.Windows.Forms.ComboBox();
            this.MakeCollageButton = new System.Windows.Forms.Button();
            this.ClickOnPhotoLabel = new System.Windows.Forms.Label();
            this.TopRightPictureBox = new System.Windows.Forms.PictureBox();
            this.TopLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.BottomRightPictureBox = new System.Windows.Forms.PictureBox();
            this.BottomLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(24, 26);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(168, 157);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePictureBox.TabIndex = 0;
            this.ProfilePictureBox.TabStop = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(227, 29);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(89, 20);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "User Name";
            // 
            // WritePostLabel
            // 
            this.WritePostLabel.AutoSize = true;
            this.WritePostLabel.Location = new System.Drawing.Point(614, 29);
            this.WritePostLabel.Name = "WritePostLabel";
            this.WritePostLabel.Size = new System.Drawing.Size(85, 20);
            this.WritePostLabel.TabIndex = 2;
            this.WritePostLabel.Text = "Write post:";
            // 
            // PostTextBox
            // 
            this.PostTextBox.Location = new System.Drawing.Point(696, 26);
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(335, 141);
            this.PostTextBox.TabIndex = 3;
            this.PostTextBox.Text = "";
            // 
            // PostButton
            // 
            this.PostButton.Enabled = false;
            this.PostButton.Location = new System.Drawing.Point(956, 193);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(75, 29);
            this.PostButton.TabIndex = 4;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // FriendsLabel
            // 
            this.FriendsLabel.AutoSize = true;
            this.FriendsLabel.Location = new System.Drawing.Point(20, 211);
            this.FriendsLabel.Name = "FriendsLabel";
            this.FriendsLabel.Size = new System.Drawing.Size(66, 20);
            this.FriendsLabel.TabIndex = 5;
            this.FriendsLabel.Text = "Friends:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(334, 211);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(79, 20);
            this.BirthdayLabel.TabIndex = 7;
            this.BirthdayLabel.Text = "Birthdays:";
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FriendsComboBox
            // 
            this.FriendsComboBox.AllowDrop = true;
            this.FriendsComboBox.FormattingEnabled = true;
            this.FriendsComboBox.Location = new System.Drawing.Point(338, 256);
            this.FriendsComboBox.Name = "FriendsComboBox";
            this.FriendsComboBox.Size = new System.Drawing.Size(174, 28);
            this.FriendsComboBox.TabIndex = 8;
            this.FriendsComboBox.Text = "Choose friend";
            // 
            // MessageComboBox
            // 
            this.MessageComboBox.FormattingEnabled = true;
            this.MessageComboBox.Location = new System.Drawing.Point(338, 302);
            this.MessageComboBox.Name = "MessageComboBox";
            this.MessageComboBox.Size = new System.Drawing.Size(174, 28);
            this.MessageComboBox.TabIndex = 9;
            this.MessageComboBox.Text = "Choose message";
            this.MessageComboBox.SelectedIndexChanged += new System.EventHandler(this.MessageComboBox_SelectedIndexChanged);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(338, 356);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(205, 171);
            this.MessageTextBox.TabIndex = 10;
            this.MessageTextBox.Text = "";
            // 
            // AddPhotoCheckBox
            // 
            this.AddPhotoCheckBox.AutoSize = true;
            this.AddPhotoCheckBox.Location = new System.Drawing.Point(338, 547);
            this.AddPhotoCheckBox.Name = "AddPhotoCheckBox";
            this.AddPhotoCheckBox.Size = new System.Drawing.Size(212, 24);
            this.AddPhotoCheckBox.TabIndex = 11;
            this.AddPhotoCheckBox.Text = "Add photo of us together";
            this.AddPhotoCheckBox.UseVisualStyleBackColor = true;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Enabled = false;
            this.SendMessageButton.Location = new System.Drawing.Point(338, 596);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(145, 28);
            this.SendMessageButton.TabIndex = 12;
            this.SendMessageButton.Text = "Send message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // AlbumsLabel
            // 
            this.AlbumsLabel.AutoSize = true;
            this.AlbumsLabel.Location = new System.Drawing.Point(633, 211);
            this.AlbumsLabel.Name = "AlbumsLabel";
            this.AlbumsLabel.Size = new System.Drawing.Size(66, 20);
            this.AlbumsLabel.TabIndex = 13;
            this.AlbumsLabel.Text = "Albums:";
            // 
            // AlbumsComboBox
            // 
            this.AlbumsComboBox.FormattingEnabled = true;
            this.AlbumsComboBox.Location = new System.Drawing.Point(637, 256);
            this.AlbumsComboBox.Name = "AlbumsComboBox";
            this.AlbumsComboBox.Size = new System.Drawing.Size(328, 28);
            this.AlbumsComboBox.TabIndex = 14;
            this.AlbumsComboBox.Text = "Choose album";
            this.AlbumsComboBox.SelectedIndexChanged += new System.EventHandler(this.AlbumsComboBox_SelectedIndexChanged);
            // 
            // MakeCollageButton
            // 
            this.MakeCollageButton.Enabled = false;
            this.MakeCollageButton.Location = new System.Drawing.Point(637, 302);
            this.MakeCollageButton.Name = "MakeCollageButton";
            this.MakeCollageButton.Size = new System.Drawing.Size(175, 28);
            this.MakeCollageButton.TabIndex = 15;
            this.MakeCollageButton.Text = "Make photo collage";
            this.MakeCollageButton.UseVisualStyleBackColor = true;
            this.MakeCollageButton.Click += new System.EventHandler(this.MakeCollageButton_Click);
            // 
            // ClickOnPhotoLabel
            // 
            this.ClickOnPhotoLabel.AutoSize = true;
            this.ClickOnPhotoLabel.Location = new System.Drawing.Point(633, 359);
            this.ClickOnPhotoLabel.Name = "ClickOnPhotoLabel";
            this.ClickOnPhotoLabel.Size = new System.Drawing.Size(218, 20);
            this.ClickOnPhotoLabel.TabIndex = 16;
            this.ClickOnPhotoLabel.Text = "* Click on a photo to replace it";
            // 
            // TopRightPictureBox
            // 
            this.TopRightPictureBox.Enabled = false;
            this.TopRightPictureBox.Location = new System.Drawing.Point(733, 423);
            this.TopRightPictureBox.Name = "TopRightPictureBox";
            this.TopRightPictureBox.Size = new System.Drawing.Size(106, 92);
            this.TopRightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopRightPictureBox.TabIndex = 17;
            this.TopRightPictureBox.TabStop = false;
            this.TopRightPictureBox.Click += new System.EventHandler(this.TopRightPictureBox_Click);
            // 
            // TopLeftPictureBox
            // 
            this.TopLeftPictureBox.Enabled = false;
            this.TopLeftPictureBox.Location = new System.Drawing.Point(637, 423);
            this.TopLeftPictureBox.Name = "TopLeftPictureBox";
            this.TopLeftPictureBox.Size = new System.Drawing.Size(106, 92);
            this.TopLeftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopLeftPictureBox.TabIndex = 19;
            this.TopLeftPictureBox.TabStop = false;
            this.TopLeftPictureBox.Click += new System.EventHandler(this.TopLeftPictureBox_Click);
            // 
            // BottomRightPictureBox
            // 
            this.BottomRightPictureBox.Enabled = false;
            this.BottomRightPictureBox.Location = new System.Drawing.Point(733, 512);
            this.BottomRightPictureBox.Name = "BottomRightPictureBox";
            this.BottomRightPictureBox.Size = new System.Drawing.Size(106, 92);
            this.BottomRightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomRightPictureBox.TabIndex = 20;
            this.BottomRightPictureBox.TabStop = false;
            this.BottomRightPictureBox.Click += new System.EventHandler(this.BottomRightPictureBox_Click);
            // 
            // BottomLeftPictureBox
            // 
            this.BottomLeftPictureBox.Enabled = false;
            this.BottomLeftPictureBox.Location = new System.Drawing.Point(637, 512);
            this.BottomLeftPictureBox.Name = "BottomLeftPictureBox";
            this.BottomLeftPictureBox.Size = new System.Drawing.Size(106, 92);
            this.BottomLeftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomLeftPictureBox.TabIndex = 21;
            this.BottomLeftPictureBox.TabStop = false;
            this.BottomLeftPictureBox.Click += new System.EventHandler(this.BottomLeftPictureBox_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(231, 98);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 28);
            this.LoginButton.TabIndex = 22;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 20;
            this.FriendsListBox.Location = new System.Drawing.Point(24, 256);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(156, 364);
            this.FriendsListBox.TabIndex = 23;
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.AutoSize = true;
            this.RememberMeCheckBox.Location = new System.Drawing.Point(231, 159);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(140, 24);
            this.RememberMeCheckBox.TabIndex = 24;
            this.RememberMeCheckBox.Text = "Remember Me";
            this.RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 680);
            this.Controls.Add(this.RememberMeCheckBox);
            this.Controls.Add(this.FriendsListBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.BottomLeftPictureBox);
            this.Controls.Add(this.BottomRightPictureBox);
            this.Controls.Add(this.TopLeftPictureBox);
            this.Controls.Add(this.TopRightPictureBox);
            this.Controls.Add(this.ClickOnPhotoLabel);
            this.Controls.Add(this.MakeCollageButton);
            this.Controls.Add(this.AlbumsComboBox);
            this.Controls.Add(this.AlbumsLabel);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.AddPhotoCheckBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessageComboBox);
            this.Controls.Add(this.FriendsComboBox);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.FriendsLabel);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.PostTextBox);
            this.Controls.Add(this.WritePostLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.ProfilePictureBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label WritePostLabel;
        private System.Windows.Forms.RichTextBox PostTextBox;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Label FriendsLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.ComboBox FriendsComboBox;
        private System.Windows.Forms.ComboBox MessageComboBox;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.CheckBox AddPhotoCheckBox;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Label AlbumsLabel;
        private System.Windows.Forms.ComboBox AlbumsComboBox;
        private System.Windows.Forms.Button MakeCollageButton;
        private System.Windows.Forms.Label ClickOnPhotoLabel;
        private System.Windows.Forms.PictureBox TopRightPictureBox;
        private System.Windows.Forms.PictureBox TopLeftPictureBox;
        private System.Windows.Forms.PictureBox BottomRightPictureBox;
        private System.Windows.Forms.PictureBox BottomLeftPictureBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.CheckBox RememberMeCheckBox;
    }
}

