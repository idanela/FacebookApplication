using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class LoggedInUserData
    {
        LoginResult m_LoginResult;
        User m_loggedInUser;

        public LoggedInUserData(LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            m_loggedInUser = m_LoginResult.LoggedInUser;
        }

        public FacebookObjectCollection<User> FetchFriends()
        {
            return m_loggedInUser.Friends;
        }

        public FacebookObjectCollection<Album> FetchAlbums()
        {

            return m_loggedInUser.Albums;
        }

        public string FetchProfilePicture()
        {
            return m_loggedInUser.PictureNormalURL;
        }

        public void Post(string i_Text)
        {
            if (!string.IsNullOrEmpty(i_Text))
            {
                m_loggedInUser.PostStatus(i_Text);
            }
            else
            {
                throw new StringNullOrEmptyException("Write text to post.");
            }
        }

        public void SendBirthdayMessage(User i_Friend, string i_Msg, bool i_AddPhoto)
        {
            if (!string.IsNullOrEmpty(i_Msg))
            {
                if (i_Friend != null)
                {
                    if (i_AddPhoto)
                    {
                        string photoURL = getMostLikedPictureTogether(i_Friend);

                        if (photoURL != null)
                        {
                            m_loggedInUser.PostStatus(
                           i_StatusText: i_Msg,
                           i_TaggedFriendIDs: i_Friend.Id,
                           i_PictureURL: photoURL);
                        }
                        else
                        {
                            throw new StringNullOrEmptyException("Couldn't find a photo of you toghter.");
                        }
                    }
                    else
                    {
                        m_loggedInUser.PostStatus(
                            i_StatusText: i_Msg,
                            i_TaggedFriendIDs: i_Friend.Id);
                    }
                }
                else
                {
                    throw new NullReferenceException("Choose a friend to send message to.");
                }
            }
            else
            {
                throw new StringNullOrEmptyException("Write text to send.");
            }
        }

        private string getMostLikedPictureTogether(User i_Friend)
        {
            Photo mostLikedPhoto = null;
            FacebookObjectCollection<Album> albums = m_loggedInUser.Albums;

            foreach (Album album in albums)
            {
                FacebookObjectCollection<Photo> allPhotosInAlbum = album.Photos;
                foreach (Photo photo in allPhotosInAlbum)
                {
                    foreach (PhotoTag tag in photo.Tags)
                    {
                        if (tag.User.Id == i_Friend.Id)
                        {
                            if (mostLikedPhoto != null)
                            {
                                if (mostLikedPhoto.LikedBy.Count < photo.LikedBy.Count)
                                {
                                    mostLikedPhoto = photo;
                                }
                            }
                            else
                            {
                                mostLikedPhoto = photo;
                            }

                            break;
                        }
                    }

                }
            }

            return mostLikedPhoto.PictureNormalURL;
        }


        public List<string> FetchPhotosForCollage(Album i_Album)
        {
            List<string> photosURLForCollage = new List<string>(4);
            if (i_Album.Count < 4)
            {
                throw new Exception("You don't have enough pictures to make a collage in this album, choose another album.");
            }
            else
            {
                photosURLForCollage.Add(i_Album.Photos[0].PictureNormalURL);
                photosURLForCollage.Add(i_Album.Photos[1].PictureNormalURL);
                photosURLForCollage.Add(i_Album.Photos[2].PictureNormalURL);
                photosURLForCollage.Add(i_Album.Photos[3].PictureNormalURL);
            }

            return photosURLForCollage;
        }

        public string FetchNewPhotoURL(Album i_Album, List<string> i_ExistingURL)
        {
            bool URLNotExsists = false;
            string photoURL = string.Empty;
            FacebookObjectCollection<Photo> photos = i_Album.Photos;
            if (i_Album.Photos.Count <= 4)
            {
                throw new StringNullOrEmptyException("There are no more picture in this album.");
            }
            else
            {
                int indexOfPhoto = 0; ;
                Random rand = new Random();
                while (!URLNotExsists)
                {
                    indexOfPhoto = rand.Next(0, i_Album.Photos.Count - 1);
                    URLNotExsists = !i_ExistingURL.Contains(i_Album.Photos[indexOfPhoto].PictureNormalURL);
                }

                photoURL = i_Album.Photos[indexOfPhoto].PictureNormalURL;
                //}
                //foreach (Photo photo in photos)
                //{
                //    isURLExsists = i_ExistingURL.Contains(photo.PictureNormalURL);
                //    if (!isURLExsists)
                //    {
                //        photoURL = photo.PictureNormalURL;
                //        break;
                //    }
                //}

                //if(photoURL == string.Empty)
                //{
                //    throw new StringNullOrEmptyException("There are no more picture in this album.");
                //}
            }

                return photoURL;
            
        }
    }
}
