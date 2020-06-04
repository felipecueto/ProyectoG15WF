using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    [Serializable()]
    public class User
    {
        string username;
        string password;
        string name;
        string lastname;
        string mail;
        List<PlaylistSong> musicplaylist;
        List<PlaylistVideo> videoplaylist;
        List<PlaylistSong> followedPlaylistSongs;
        List<PlaylistVideo> followedPlaylistVideo;
        List<User> followingUsers;
        List<User> followedUsers;
        string edad = "";
        string privacidad = "Publico";
        string tipodeusuario = "Free";
        string genero = "None";
        string artist = "";
        string imagePast = "";

        public User()
        {

        }

        public User(string username, string name, string lastname, string email, string password)
            : this()

        {
            this.username = username;
            this.name = name;
            this.password = password;
            this.mail = email;
            this.lastname = lastname;
            this.musicplaylist = new List<PlaylistSong>();
            this.videoplaylist = new List<PlaylistVideo>();
            this.followedPlaylistSongs = new List<PlaylistSong>();
            this.followedPlaylistVideo = new List<PlaylistVideo>();
            this.followingUsers = new List<User>();
            this.followedUsers = new List<User>();
            AddMusicPlaylist("Musica Favorita");
            AddVideoPlaylist("Videos Favoritos");
        }

        public string Name { get => name; set => name = value; }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Privacidad { get => privacidad; set => privacidad = value; }
        public string Tipodeusuario { get => tipodeusuario; set => tipodeusuario = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Artist { get => artist; set => artist = value; }
        public List<PlaylistSong> Playlistsong { get => musicplaylist; set => musicplaylist = value; }
        public List<PlaylistVideo> Playlistvideo { get => videoplaylist; set => videoplaylist = value; }
        public string ImagePast { get => imagePast; set => imagePast = value; }

        public bool CheckCredentials(string username, string pass)
        {
            if (this.Username.Equals(username) && this.Password.Equals(pass))
                return true;
            return false;
        }
        public override string ToString()
        {
            return this.Username;
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
            this.musicplaylist.Add(new PlaylistSong(playlistname));
            return true; // Se agrega la playlist
        }
        public bool AddFollowedMusicPlaylist(PlaylistSong selectedplaylist)
        {
            if (followedPlaylistSongs != null)
            {
                foreach (PlaylistSong playlist in this.followedPlaylistSongs)
                {
                    if (playlist.GetPlaylistName() == selectedplaylist.GetPlaylistName())
                    {
                        return false; // No se agrego la playlist
                    }
                }
            }
            this.followedPlaylistSongs.Add(selectedplaylist);
            return true; // Se agrega la playlist
        }

        public bool RemoveMusicPlaylist(string playlistname)
        {
            foreach (PlaylistSong playlist in this.musicplaylist)
            {
                if (playlist.GetPlaylistName() == playlistname)
                {
                    this.musicplaylist.Remove(playlist);
                    return true; //elimina la playlist
                }
            }
            return false; //No elimina nada
        }
        public bool RemoveFollowedMusicPlaylist(string playlistname)
        {
            foreach (PlaylistSong playlist in this.followedPlaylistSongs)
            {
                if (playlist.GetPlaylistName() == playlistname)
                {
                    this.followedPlaylistSongs.Remove(playlist);
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
            this.videoplaylist.Add(new PlaylistVideo(playlistname));
            return true; // Se agrega la playlist
        }

        public bool AddFollowedVideoPlaylist(PlaylistVideo selectedplaylist)
        {
            if (this.followedPlaylistSongs != null)
            {
                foreach (PlaylistVideo playlist in this.followedPlaylistVideo)
                {
                    if (playlist.GetPlaylistName() == selectedplaylist.GetPlaylistName())
                    {
                        return false; // No se agrego la playlist
                    }
                }
            }
            this.followedPlaylistVideo.Add(selectedplaylist);
            return true; // Se agrega la playlist
        }

        public void RemoveVideoPlaylist(string playlistname)
        {
            foreach (PlaylistVideo playlist in this.videoplaylist)
            {
                if (playlist.GetPlaylistName() == playlistname)
                {
                    this.videoplaylist.Remove(playlist);
                    break;
                }
            }
        }

        public void RemoveFollowedVideoPlaylist(string playlistname)
        {
            foreach (PlaylistVideo playlist in this.followedPlaylistVideo)
            {
                if (playlist.GetPlaylistName() == playlistname)
                {
                    this.followedPlaylistVideo.Remove(playlist);
                    break;
                }
            }
        }

        public List<PlaylistSong> GetPlaylistSongs()
        {
            return this.musicplaylist;
        }
        public List<PlaylistVideo> GetPlaylistVideo()
        {
            return this.videoplaylist;
        }
        public List<PlaylistSong> GetFollowedPlaylistSongs()
        {
            return this.followedPlaylistSongs;
        }
        public List<PlaylistVideo> GetFollowedPlaylistVideo()
        {
            return this.followedPlaylistVideo;
        }
        //

        // Followers

        public bool AddFollowed(User followuser)
        {
            if (this.followedUsers != null)
            {
                foreach (User followeduser in this.followedUsers)
                {
                    if (followuser.username == followeduser.username)
                    {
                        return false;
                    }
                }
            }
            this.followedUsers.Add(followuser);
            return true;
        }

        public void RemoveFollowed(string followed)
        {
            foreach (User followeduser in this.followedUsers)
            {
                if (followed == followeduser.username)
                {
                    this.followedUsers.Remove(followeduser);
                    break;
                }
            }
        }

        public List<User> GetFollowedUsers()
        {
            return this.followedUsers;
        }

        // Following

        public bool AddFollowing(User following)
        {
            if (this.followingUsers != null)
            {
                foreach (User followeduser in this.followingUsers)
                {
                    if (following.username.ToUpper() == followeduser.username.ToUpper())
                    {
                        return false;
                    }
                }
            }
            this.followingUsers.Add(following);
            return true;
        }

        public void RemoveFollowing(string followed)
        {
            foreach (User followeduser in this.followingUsers)
            {
                if (followed.ToUpper() == followeduser.username.ToUpper())
                {
                    this.followingUsers.Remove(followeduser);
                    break;
                }
            }
        }

        public List<User> GetFollowingUsers()
        {
            return this.followingUsers;
        }

        // 

    }
}