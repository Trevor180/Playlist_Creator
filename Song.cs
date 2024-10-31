using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WootenT_Playlist
{
    internal class Song
    {

        //Making constructor
        public Song(string title, string artist)
        {
            //Instances
            this.Title = title;
            this.Artist = artist;

        
        }

        //Making properties
        public string Title { get; set; }
        public string Artist { get; set; }

        //For deleting song
        public override string ToString()
        {

            return $"{Artist} - {Title}";

        }


    }
}
