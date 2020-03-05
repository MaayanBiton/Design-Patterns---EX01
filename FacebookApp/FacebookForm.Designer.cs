namespace C19_Ex01_Maayan_313353161_Eden_315855049
{
    partial class FacebookForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelHometown = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.pictureBoxLittleProfile = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.buttonSortLikes = new System.Windows.Forms.Button();
            this.labelFindMatch = new System.Windows.Forms.Label();
            this.labelSortLikes = new System.Windows.Forms.Label();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.comboBoxAges = new System.Windows.Forms.ComboBox();
            this.labelPost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLittleProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogIn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.White;
            this.buttonLogIn.Location = new System.Drawing.Point(458, 25);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(103, 35);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "LOG IN";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = global::FacebookApp.Properties.Resources.icons8_facebook_100;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(592, 90);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(458, 64);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(106, 20);
            this.checkBoxRememberMe.TabIndex = 3;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = false;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(16, 111);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(128, 92);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 4;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(321, 111);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(239, 225);
            this.listBoxOutput.TabIndex = 10;
            this.listBoxOutput.Visible = false;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxPost.Location = new System.Drawing.Point(321, 390);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPost.Size = new System.Drawing.Size(203, 20);
            this.textBoxPost.TabIndex = 11;
            this.textBoxPost.Visible = false;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFullName.Location = new System.Drawing.Point(157, 111);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(84, 16);
            this.labelFullName.TabIndex = 12;
            this.labelFullName.Text = "labelFullName";
            this.labelFullName.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Location = new System.Drawing.Point(157, 190);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 16);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "labelEmail";
            this.labelEmail.Visible = false;
            // 
            // labelHometown
            // 
            this.labelHometown.AutoSize = true;
            this.labelHometown.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHometown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHometown.Location = new System.Drawing.Point(157, 172);
            this.labelHometown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(95, 16);
            this.labelHometown.TabIndex = 14;
            this.labelHometown.Text = "labelHometown";
            this.labelHometown.Visible = false;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGender.Location = new System.Drawing.Point(157, 151);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(77, 16);
            this.labelGender.TabIndex = 15;
            this.labelGender.Text = "labelGender";
            this.labelGender.Visible = false;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBirthday.Location = new System.Drawing.Point(157, 131);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(79, 16);
            this.labelBirthday.TabIndex = 16;
            this.labelBirthday.Text = "labelBirthday";
            this.labelBirthday.Visible = false;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPost.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPost.Location = new System.Drawing.Point(533, 383);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(51, 31);
            this.buttonPost.TabIndex = 17;
            this.buttonPost.Text = "POST";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Visible = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // pictureBoxLittleProfile
            // 
            this.pictureBoxLittleProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBoxLittleProfile.Location = new System.Drawing.Point(115, 31);
            this.pictureBoxLittleProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLittleProfile.Name = "pictureBoxLittleProfile";
            this.pictureBoxLittleProfile.Size = new System.Drawing.Size(39, 35);
            this.pictureBoxLittleProfile.TabIndex = 18;
            this.pictureBoxLittleProfile.TabStop = false;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.SteelBlue;
            this.labelFirstName.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFirstName.Location = new System.Drawing.Point(169, 31);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(87, 15);
            this.labelFirstName.TabIndex = 19;
            this.labelFirstName.Text = "labelFirstName";
            this.labelFirstName.Visible = false;
            // 
            // buttonMatch
            // 
            this.buttonMatch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonMatch.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMatch.Location = new System.Drawing.Point(51, 380);
            this.buttonMatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(83, 40);
            this.buttonMatch.TabIndex = 20;
            this.buttonMatch.Text = "FIND ";
            this.buttonMatch.UseVisualStyleBackColor = false;
            this.buttonMatch.Visible = false;
            this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
            // 
            // buttonSortLikes
            // 
            this.buttonSortLikes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSortLikes.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortLikes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSortLikes.Location = new System.Drawing.Point(51, 257);
            this.buttonSortLikes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSortLikes.Name = "buttonSortLikes";
            this.buttonSortLikes.Size = new System.Drawing.Size(83, 40);
            this.buttonSortLikes.TabIndex = 21;
            this.buttonSortLikes.Text = "SORT";
            this.buttonSortLikes.UseVisualStyleBackColor = false;
            this.buttonSortLikes.Visible = false;
            this.buttonSortLikes.Click += new System.EventHandler(this.buttonSortLikes_Click);
            // 
            // labelFindMatch
            // 
            this.labelFindMatch.AutoSize = true;
            this.labelFindMatch.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFindMatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFindMatch.Location = new System.Drawing.Point(23, 316);
            this.labelFindMatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFindMatch.Name = "labelFindMatch";
            this.labelFindMatch.Size = new System.Drawing.Size(131, 15);
            this.labelFindMatch.TabIndex = 22;
            this.labelFindMatch.Text = "FIND OPTIONAL MATCH";
            this.labelFindMatch.Visible = false;
            // 
            // labelSortLikes
            // 
            this.labelSortLikes.AutoSize = true;
            this.labelSortLikes.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortLikes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSortLikes.Location = new System.Drawing.Point(23, 236);
            this.labelSortLikes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSortLikes.Name = "labelSortLikes";
            this.labelSortLikes.Size = new System.Drawing.Size(172, 15);
            this.labelSortLikes.TabIndex = 23;
            this.labelSortLikes.Text = "SORT FRIENDS BY PICTURE LIKES";
            this.labelSortLikes.Visible = false;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxMale.Location = new System.Drawing.Point(25, 334);
            this.checkBoxMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(55, 20);
            this.checkBoxMale.TabIndex = 24;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.Visible = false;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxFemale.Location = new System.Drawing.Point(75, 334);
            this.checkBoxFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(66, 20);
            this.checkBoxFemale.TabIndex = 25;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.Visible = false;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxFemale_CheckedChanged);
            // 
            // comboBoxAges
            // 
            this.comboBoxAges.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAges.FormattingEnabled = true;
            this.comboBoxAges.Location = new System.Drawing.Point(25, 354);
            this.comboBoxAges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAges.Name = "comboBoxAges";
            this.comboBoxAges.Size = new System.Drawing.Size(185, 24);
            this.comboBoxAges.TabIndex = 26;
            this.comboBoxAges.Text = "Select your desired age range";
            this.comboBoxAges.Visible = false;
            this.comboBoxAges.SelectedIndexChanged += new System.EventHandler(this.comboBoxAges_SelectedIndexChanged);
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPost.Location = new System.Drawing.Point(318, 374);
            this.labelPost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(124, 16);
            this.labelPost.TabIndex = 27;
            this.labelPost.Text = "What\'s on your mind?";
            this.labelPost.Visible = false;
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 435);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.comboBoxAges);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.labelSortLikes);
            this.Controls.Add(this.labelFindMatch);
            this.Controls.Add(this.buttonSortLikes);
            this.Controls.Add(this.buttonMatch);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.pictureBoxLittleProfile);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelHometown);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FacebookForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLittleProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.PictureBox pictureBoxLittleProfile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.Button buttonSortLikes;
        private System.Windows.Forms.Label labelFindMatch;
        private System.Windows.Forms.Label labelSortLikes;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.ComboBox comboBoxAges;
        private System.Windows.Forms.Label labelPost;
    }
}