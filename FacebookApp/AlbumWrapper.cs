using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace FacebookAppUI
{
    public class AlbumWrapper
    {
        private Album m_Album;

        public  AlbumWrapper(Album i_Album)
        {
            m_Album = i_Album;
        }

        public Album GetAlbum()
        {
            return m_Album;
        }

        public override string ToString()
        {
            return m_Album.Name;
        }
    }
}
