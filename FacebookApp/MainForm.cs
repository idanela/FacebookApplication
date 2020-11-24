using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace FacebookAppUI
{
    public partial class MainForm : Form
    {
        private LoginResult m_LoginResult;
        private LoggedInUserData m_LoggedInUser;
        private readonly AppSettings r_AppSettings = AppSettings.LoadFromFile();

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            Location = r_AppSettings.LastWindowLocation;
            Size = r_AppSettings.LastWindowSize;
            RememberMeCheckBox.Checked = r_AppSettings.RememberUser;
            if(RememberMeCheckBox.Checked && !string.IsNullOrEmpty (r_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
                updateAppUI();
            }

            base.OnShown(e);
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoggedInUser.Post(PostTextBox.Text);
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("No premmision to post on Facebook");
            }
            catch(StringNullOrEmptyException nullOrEmptyExeption)
            {
                MessageBox.Show(nullOrEmptyExeption.Message);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            loginToFacebook();
            updateAppUI();
        }

        private void updateAppUI()
        {
            m_LoggedInUser = new LoggedInUserData(m_LoginResult);
            enableProperties();
            populateUI();
        }

        private void loginToFacebook()
        {
            m_LoginResult = FacebookService.Login("289617575566669",
                "user_birthday",
                "user_friends",
                "user_photos",
                "user_posts");
        }

        private void enableProperties()
        {
            PostButton.Enabled = true;
            PostMessageButton.Enabled = true;
        }

        private void populateUI()
        {
            FacebookObjectCollection<User> friends = m_LoggedInUser.FetchFriends();
            FacebookObjectCollection<Album> albums = m_LoggedInUser.FetchAlbums();

            ProfilePictureBox.Load(m_LoggedInUser.FetchProfilePicture());

            foreach (User friend in friends)
            {
                FriendsListBox.Items.Add(friend);
                if(friend.Birthday == DateTime.Today.ToString())
                {
                    FriendsListBox.Items.Add(friend);
                }
            }

            foreach(Album album in albums)
            {
                AlbumsComboBox.Items.Add(new AlbumWrapper (album));
            }

            UserNameLabel.Text = string.Format("Hi, {0}", m_LoginResult.LoggedInUser.FirstName);
            addBirthdayMesages();
        }

        private void addBirthdayMesages()
        {
            MessageComboBox.Items.Add("Mazal Tov!!! :) ");
            MessageComboBox.Items.Add("happy birthday!!! wish you the best. I love you, have fun today :) ");
            MessageComboBox.Items.Add("Have a fabulous day filled with all the good things you love in life! ");
            MessageComboBox.Items.Add("I wish you all the happiness your heart can hold. Have a wonderful day. ");
            MessageComboBox.Items.Add("wishing you happy birhday, filled with love, joy and happiness.");
        }
        private void PostMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoggedInUser.SendBirthdayMessage(FriendsComboBox.SelectedItem as User, MessageTextBox.Text, AddPhotoCheckBox.Checked);
            }
            catch(FacebookOAuthException )
            {
                MessageBox.Show("No premmision to send message.");

            }
            catch(Exception exeption)
            {
                MessageBox.Show(exeption.Message);

            }
         
        }

        private void MakeCollageButton_Click(object sender, EventArgs e)
        {
             makeCollage((AlbumsComboBox.SelectedItem as AlbumWrapper).GetAlbum());
        }

        private void makeCollage(Album i_Album)
        {
            try
            {
                List<string> photoURLForCollage = m_LoggedInUser.FetchPhotosForCollage(i_Album);
                TopLeftPictureBox.Load(photoURLForCollage[0]);
                TopRightPictureBox.Load(photoURLForCollage[1]);
                BottomLeftPictureBox.Load(photoURLForCollage[2]);
                BottomRightPictureBox.Load(photoURLForCollage[3]);

                TopLeftPictureBox.Tag = photoURLForCollage[0];
                TopRightPictureBox.Tag = photoURLForCollage[1];
                BottomLeftPictureBox.Tag = photoURLForCollage[2];
                BottomRightPictureBox.Tag = photoURLForCollage[3];

                TopLeftPictureBox.Enabled = true;
                TopRightPictureBox.Enabled = true;
                BottomRightPictureBox.Enabled = true;
                BottomLeftPictureBox.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   

        private void BottomLeftPictureBox_Click(object sender, EventArgs e)
        {
            changePhoto(BottomLeftPictureBox);
        }

        private void BottomRightPictureBox_Click(object sender, EventArgs e)
        {
            changePhoto(sender as PictureBox);

        }

        private void TopLeftPictureBox_Click(object sender, EventArgs e)
        {
            changePhoto(sender as PictureBox);

        }

        private void TopRightPictureBox_Click(object sender, EventArgs e)
        {
            changePhoto(sender as PictureBox);
        }

        private void changePhoto(PictureBox i_PictureBoxToUpdate)
        {
            try
            {
                List<string> AllExistingURLs = getAllExistingURLs();
                string newPhotoURL = m_LoggedInUser.FetchNewPhotoURL((AlbumsComboBox.SelectedItem as AlbumWrapper).GetAlbum(), AllExistingURLs);
                i_PictureBoxToUpdate.Load(newPhotoURL);
                i_PictureBoxToUpdate.Tag = newPhotoURL;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<string> getAllExistingURLs()
        {
            List<string> allExistingURLs = new List<string>();
            allExistingURLs.Add(TopLeftPictureBox.Tag.ToString());
            allExistingURLs.Add(TopRightPictureBox.Tag.ToString());
            allExistingURLs.Add(BottomLeftPictureBox.Tag.ToString());
            allExistingURLs.Add(BottomRightPictureBox.Tag.ToString());
            return allExistingURLs;
        }

        private void MessageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageTextBox.Text = MessageComboBox.SelectedItem.ToString();
        }

        private void AlbumsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeCollageButton.Enabled = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_AppSettings.LastWindowLocation = Location;
            r_AppSettings.LastWindowSize = Size;
            r_AppSettings.RememberUser = RememberMeCheckBox.Checked;
            if (r_AppSettings.RememberUser)
            {
                r_AppSettings.LastAccessToken = m_LoginResult == null ? null : m_LoginResult.AccessToken;
            }
            else
            {
                r_AppSettings.LastAccessToken = null;
            }
            try
            {
                r_AppSettings.SaveToFile();
            }
            catch (Exception )
            {
                MessageBox.Show("A problem occured with saving To File");
            }
        }
    }
}
