using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        string username;
        string password;
        string name;
        string lastname;
        string mail;
        List<PlaylistSong> musicplaylist;
        List<PlaylistVideo> videoplaylist;


        public User()
        {

        }

        public User(string username, string name,string lastname, string email, string password)
            : this()

        {
            this.username = username;
            this.name = name;
            this.password = password;
            this.mail = email;
            this.lastname = lastname;
            this.musicplaylist = new List<PlaylistSong>();
            this.videoplaylist = new List<PlaylistVideo>();
            AddMusicPlaylist("Musica Favorita");
            AddVideoPlaylist("Videos Favoritos");
        }

        public string Name { get => name; set => name = value; }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Lastname { get => lastname; set => lastname = value; }

        public bool CheckCredentials(string username, string pass)
        {
            if (this.Username.Equals(username) && this.Password.Equals(pass))
                return true;
            return false;
        }
        public override string ToString()
        {
            return "Usuario: " + this.Username + " ";
        }

        //Playlist Methods
        public bool AddMusicPlaylist(string playlistname)
        {
            foreach (PlaylistSong playlist in this.musicplaylist)
            {
                if (playlist.GetPlaylistName() == playlistname)
                {
                    return false; // No se agrego la playlist
                }
            }
            musicplaylist.Add(new PlaylistSong(playlistname));
            return true; // Se agrega la playlist
        }

        public bool RemoveMusicPlaylist(string playlistname)
        {
            foreach (PlaylistSong playlist in this.musicplaylist)
            {
                if (playlist.GetPlaylistName() == playlistname)
                {
                    musicplaylist.Remove(playlist);
                    return true; //elimina la playlist
                }
            }
            return false; //No elimina nada
        }

        public bool AddVideoPlaylist(string playlistname)
        {
            foreach (PlaylistVideo playlist in this.videoplaylist)
            {
                if (playlist.GetPlaylistName() == playlistname)
                {
                    return false; // No se agrego la playlist
                }
            }
            videoplaylist.Add(new PlaylistVideo(playlistname));
            return true; // Se agrega la playlist
        }

        public void RemoveVideoPlaylist(string playlistname)
        {
            foreach (PlaylistVideo playlist in this.videoplaylist)
            {
                if (playlist.GetPlaylistName() == playlistname)
                {
                    videoplaylist.Remove(playlist);
                }
            }
        }

        public List<PlaylistSong> GetPlaylistSongs()
        {
            return this.musicplaylist;
        }
        //

    }
}