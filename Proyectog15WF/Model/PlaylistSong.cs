using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PlaylistSong
    {
        List<Song> songs;
        List<Song> random;
        List<bool> preferences;
        string name;

        public PlaylistSong(string playlistname)
        {
            this.songs = new List<Song>();
            this.random = new List<Song>();
            this.preferences = new List<bool>() { false, false }; //privacy, download
            this.name = playlistname;
        }

        // Get
        public bool GetPlaylistPrivacy()
        {
            return preferences[0];
        }
        public bool GetPlaylistDownload()
        {
            return preferences[1];
        }
        public string GetPlaylistName()
        {
            return name;
        }
        public List<Song> GetPlaylistAllSongs()
        {
            return songs;
        }
        //

        public bool ChangePrivacy(bool input)
        {
            if (preferences[0] == true)
            {
                preferences[0] = false; // queda privada
                return false;
            }
            if (preferences[0] == false)
            {
                preferences[0] = true; // queda publica
                return true;
            }
            return false; // no paso nada por defecto setea la playlist a privada
        }

        public bool DownloadPlaylist(string premium) // ver si se cambia la variable premium
        {
            if (premium == "Premium")
            {
                if (preferences[0] == true)
                {
                    preferences[0] = false; // queda privada
                    return false;
                }
                if (preferences[0] == false)
                {
                    preferences[0] = true; // queda publica
                    return true;
                }
                return false;
            }
            else
            {
                return false; // no pasa nada por defecto no descarga la playlist
            }
        }

        public void AddSong(Song song)
        {
            bool flag = false;
            foreach (Song value in this.songs)
            {
                if (value.Namesong == song.Namesong)
                {
                    flag = true;
                    // no agrega la cancion porque ya está
                }
            }
            if (flag == false)
            {
                songs.Add(song);
            }
            // si agrego la cancion
        }

        public bool RemoveSong(Song song)
        {
            foreach (Song value in songs)
            {
                if (value.Namesong == song.Namesong)
                {
                    songs.Remove(song);
                    return true; // La cancion es eliminada
                }
            }
            return false; // La cancion no fue encontrada
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max); // Devuelve un numero random
        }

        public List<Song> RandomPlaylistOrder()
        {
            random.Clear();
            int counter = songs.Count();

            foreach (Song value in this.songs)
            {
                random.Add(songs[RandomNumber(1, counter + 1)]);
                counter--;
            }
            return random; // devualve una mezcla de canciones de esta playlist
        }
    }
}
