using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C19_Ex01_Maayan_313353161_Eden_315855049
{
    public partial class FacebookForm : Form
    {
        private static readonly string[]    sr_AgeRange = new string[] { "18-21", "22-25", "26-30", "31-40", "41-50", "51-65", "66+" };
        private User                        m_LoggedInUser;
        private AppSettings                 m_AppSettings;
        private LoginResult                 m_LoggedInResult;
        private LikeSorter                  m_LikeSorter;
        private MatchFinder                 m_MatchFinder;

        public FacebookForm()
        {
            this.InitializeComponent();
            this.m_AppSettings = AppSettings.LoadFromFile();
            this.checkBoxRememberMe.Checked = this.m_AppSettings.RememberMe;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            this.m_AppSettings.RememberMe = this.checkBoxRememberMe.Checked;

            if (this.m_AppSettings.RememberMe)
            {
                this.m_AppSettings.LastAccessToken = this.m_LoggedInResult.AccessToken;
            }
            else
            {
                this.m_AppSettings.LastAccessToken = null;
            }

            this.m_AppSettings.SaveToFile();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (this.m_AppSettings.RememberMe && !string.IsNullOrEmpty(this.m_AppSettings.LastAccessToken))
            {
                this.m_LoggedInResult = FacebookService.Connect(this.m_AppSettings.LastAccessToken);
                this.m_LoggedInUser = this.m_LoggedInResult.LoggedInUser;
                this.setFormInfo();
            }
        }

        private void loginAndInit()
        {   //we used guy's app ID. Our app ID is "515144672559542"
            this.m_LoggedInResult = FacebookService.Login(
                "1450160541956417",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_friends",
                "user_likes",
                "user_photos",
                "user_posts",
                "user_hometown",
                "email"
                );

            if (!string.IsNullOrEmpty(this.m_LoggedInResult.AccessToken))
            {
                this.m_LoggedInUser = this.m_LoggedInResult.LoggedInUser;
                this.setFormInfo();
            }
            else
            {
                MessageBox.Show(this.m_LoggedInResult.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            try
            {
                this.pictureBoxLittleProfile.LoadAsync(this.m_LoggedInUser.PictureSmallURL);
                this.pictureBoxProfilePicture.LoadAsync(this.m_LoggedInUser.PictureNormalURL);
                this.labelFirstName.Text = this.m_LoggedInUser.FirstName;
                this.labelFullName.Text = this.m_LoggedInUser.Name;
                this.labelGender.Text = this.m_LoggedInUser.Gender.ToString();
                this.labelHometown.Text = this.m_LoggedInUser.Hometown.ToString();
                this.labelEmail.Text = this.m_LoggedInUser.Email;
                this.labelBirthday.Text = this.m_LoggedInUser.Birthday;
                this.setVisible();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void setFormInfo()
        {
            this.Text = "Logged in as " + this.m_LoggedInUser.Name;
            this.fetchUserInfo();
            this.fetchAgeRange();
            this.fetchPosts();
        }

        private void fetchAgeRange()
        {
            foreach (string ageRange in sr_AgeRange)
            {
                this.comboBoxAges.Items.Add(ageRange);
            }
        }

        private void fetchPosts()
        {
            foreach (Post post in this.m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    this.listBoxOutput.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    this.listBoxOutput.Items.Add(post.Caption);
                }
                else
                {
                    this.listBoxOutput.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (this.m_LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void setVisible()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            this.loginAndInit();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxPost.Text))
            {
                this.m_LoggedInUser.PostStatus(this.textBoxPost.Text);
            }
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            this.m_AppSettings.RememberMe = this.checkBoxRememberMe.Checked;
        }

        private void buttonSortLikes_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_LikeSorter = new LikeSorter(this.m_LoggedInUser);
                this.m_LikeSorter.RunLikeSorter();
                this.showSortedFriendsByLikes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showSortedFriendsByLikes()
        {
            this.listBoxOutput.Items.Clear();

            if (this.m_LikeSorter.FriendsLikeCounter.Count == 0)
            {
                this.listBoxOutput.Items.Add("No likes found");
            }
            else
            {
                foreach (User friend in this.m_LikeSorter.FriendsLikeCounter.Keys)
                {
                    this.listBoxOutput.Items.Add(friend.Name);
                }
            }
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            this.genderListInit("Male");
        }

        private void matchInitializer()
        {
            if (this.m_MatchFinder == null)
            {
                this.m_MatchFinder = new MatchFinder(this.m_LoggedInUser);
            }
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            this.genderListInit("Female");
        }

        private void genderListInit(string i_Gender)
        {
            this.matchInitializer();
            if (this.checkBoxMale.Checked)
            {
                this.m_MatchFinder.SelectedGender.Add(i_Gender, true);
            }
            else
            {
                this.m_MatchFinder.SelectedGender.Add(i_Gender, false);
            }
        }

        private void comboBoxAges_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.matchInitializer();
            this.m_MatchFinder.AgeRangeSelected = this.comboBoxAges.SelectedItem.ToString();
        }

        private void buttonMatch_Click(object sender, EventArgs e)
        {
            try
            {
                if ((this.checkBoxFemale.Checked || this.checkBoxMale.Checked) && !this.comboBoxAges.SelectedText.Equals("Select your desired age range"))
                {
                    this.m_MatchFinder.FindMatch();
                    this.showMatchedFriends();
                }
                else
                {
                    throw new Exception("Not all parameters are selected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showMatchedFriends()
        {
            this.listBoxOutput.Items.Clear();
            if (this.m_MatchFinder.MatchFriends.Count == 0)
            {
                this.listBoxOutput.Items.Add("We didn't find any matching friends");
            }
            else
            {
                this.addFriendsToListBox();
            }
        }

        private void addFriendsToListBox()
        {
            foreach (User friend in this.m_MatchFinder.MatchFriends)
            {
                this.listBoxOutput.Items.Add(friend.Name);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
