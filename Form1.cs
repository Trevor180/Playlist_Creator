using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WootenT_Playlist
{
    public partial class Form1 : Form
    {
        //Making these global so the whole app can use them
        PlayList playlist = new PlayList();
        //Song object
        Song song;

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closing the application
            //Or ALT + X
            this.Close();
        }

 
        private void addButton_Click(object sender, EventArgs e)
        {
            //Also you can press Enter to use 
            try
            {   
                //Making sure user enters both fields
                if ((songTextBox.Text != "") && (artistTextBox.Text != ""))
                {
                    
                    //Making new song object
                    song = new Song(songTextBox.Text, artistTextBox.Text);

                    //Adding song to playlist
                    playlist.AddSong(song);

                    //Adding the song
                    songPlaylistListBox.Items.Add(song);
                }
                else
                {
                    //Shows if user enters 1 or no fields
                    MessageBox.Show("Please enter information for all fields.");
               
                }
            }
            catch
            {
                //If something random happens
                MessageBox.Show("An error has occurred");
            
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Making sure something is selected
                if (songPlaylistListBox.SelectedIndex != -1)
                {
                    //Using a cast operator to convert the selected item
                    //To a song object
                    Song selectedSong = (Song)songPlaylistListBox.SelectedItem;

                    //Deleting song from playlist
                    playlist.DeleteSong(selectedSong);

                    //Removing selected song from list
                    songPlaylistListBox.Items.Remove(selectedSong); 
                }
               
              

            }
            catch
            {
                MessageBox.Show("An error has occurred.");

            }
        }
    }
}
