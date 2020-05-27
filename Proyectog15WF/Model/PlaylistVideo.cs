using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PlaylistVideo
    {
        List<Video> videos; // Quizas hacer una lista de objetos Song
        List<Video> random; // Quizas hacer una lista de objetos Song
        List<bool> preferences;
        string name;

        public PlaylistVideo(string playlistname)
        {
            this.videos = new List<Video>();
            this.random = new List<Video>();
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
        public List<Video> GetPlaylistAllVideos()
        {
            return videos;
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

        public bool AddSong(Video video)
        {
            foreach (Video value in videos)
            {
                if (value.VideoName == video.VideoName)
                {
                    return false; // no agrega la cancion porque ya está
                }
            }

            videos.Add(video);
            return true; // si agrego la cancion
        }

        public bool RemoveSong(Video video)
        {
            foreach (Video value in videos)
            {
                if (value.VideoName == video.VideoName)
                {
                    videos.Remove(video);
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

        public List<Video> RandomPlaylistOrder()
        {
            random.Clear();
            int counter = videos.Count();

            foreach (Video value in this.videos)
            {
                random.Add(videos[RandomNumber(1, counter + 1)]);
                counter--;
            }
            return random; // devualve una mezcla de canciones de esta playlist
        }
    }
}


