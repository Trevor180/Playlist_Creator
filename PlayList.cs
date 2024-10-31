using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WootenT_Playlist
{
    internal class PlayList
    {
        //Making song list
        List<Song> playlist = new List<Song>();

        //Adding song method
        //To add song objects to playlists
        public void AddSong(Song song)
        {
            //Adding songs to the playlist
            playlist.Add(song);

        }


        //Deleting song method
        public void DeleteSong(Song song)
        {
            //Deleting songs from the playlist
            playlist.Remove(song);


        }

    }
}
