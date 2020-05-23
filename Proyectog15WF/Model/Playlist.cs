using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Playlist
    {
        List<string> songs; // Quizas hacer una lista de objetos Song
        List<string> random; // Quizas hacer una lista de objetos Song
        List<bool> preferences;
        string name;


        // Dictionary<string, List<string>> followedplaylist = new Dictionary<string, List<string>>(); aplicar en user
        //private Dictionary<int, string> queuelist; aplicar en user

        // string lastPlayed;aplicar en user
        // string nowPlaying;aplicar en user

        public Playlist(string playlistname)
        {
            this.songs = new List<string>();
            this.random = new List<string>();
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
        public List<string> GetPlaylistAllSongs()
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

        public bool AddSong(string songname)
        {
            foreach (string value in songs)
            {
                if (value == songname)
                {
                    return false; // no agrega la cancion porque ya está
                }
            }

            songs.Add(songname);
            return true; // si agrego la cancion
        }

        public bool RemoveSong(string songname)
        {
            foreach (string value in songs)
            {
                if (value == songname)
                {
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

        public List<string> RandomPlaylistOrder()
        {
            random.Clear();
            int counter = songs.Count();

            foreach (string value in this.songs)
            {
                random.Add(songs[RandomNumber(1, counter + 1)]);
                counter--;
            }
            return random; // devualve una mezcla de canciones de esta playlist
        }
    }
}
