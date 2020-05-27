using CustomEventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Proyectog15WF;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Controllers
{
    public class UserController
    {
        List<User> users = new List<User>();
        AppForm view;
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        public UserController(Form view)
        {
            this.view = view as AppForm;
            this.view.LoginButtonClicked += OnLoginButtonClicked;
            this.view.UserChecked += OnUserChecked;
            this.view.RegisterButtonClicked += OnRegisterButtonClicked;
            this.view.Checkusernameregister += OncheckUsernameregister;
            this.view.Searching += OnSearchTextChanged;
            this.view.Sendingplaylist += OnShowSongPlaylist;
            this.view.Userselectedplaylist += OnRemovePlaylist;
            this.view.Changingpassword += OnChangingpassword;
            this.view.Addplaylist += OnAddMusicPlaylist;
            this.view.Addvideoplaylist += OnAddVideoPlaylist;
            this.view.Userrequest += OnUserRequest;
            this.view.SendingplaylistVideo += OnShowSongPlaylistVideo;
            this.view.Userifosend += OnRecivingUserchanges;
            this.view.Artistifosend += OnArtistModeUserchanges;
            DeserializeData();
        }

        public void SerializeData()
        {
            try
            {
                FileStream FS = new FileStream("Users.Bin", FileMode.Create, FileAccess.Write, FileShare.None);
                binaryFormatter.Serialize(FS, users);
                FS.Close();
            }
            catch
            {
               
            }
        }

        public void DeserializeData()
        {
            
            try
            {
                FileStream FS = new FileStream("Users.bin", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                users =(List<User>)binaryFormatter.Deserialize(FS);
                FS.Close();
               
            }
            catch
            {
               
            }
        }


        public bool OnLoginButtonClicked(object sender, LoginEventArgs e)
        {

            User result = null;
            result = users.Where(t =>
               t.Username.ToUpper().Contains(e.UsernameText.ToUpper()) && (t.Password.ToUpper().Contains(e.PasswordText.ToUpper()))).FirstOrDefault();
            if (result is null)
            {
                return false;
            }
            else
            {
                return result.CheckCredentials(e.UsernameText, e.PasswordText);
            }

        }

        public void OnUserChecked(object sender, LoginEventArgs e)
        {
            User user = null;
            user = users.Where(t =>
               t.Username.ToUpper().Contains(e.UsernameText.ToUpper()) && (t.Password.ToUpper().Contains(e.PasswordText.ToUpper()))).FirstOrDefault();


        }
        public bool OnRegisterButtonClicked(object sender, RegisterEventArgs e)
        {
            users.Add(new User(e.Usernametext, e.Nametext, e.Lastnametext, e.Email, e.Passwordtext));
            SerializeData();
            return true;
            

        }
        public string OncheckUsernameregister(object sender, RegisterEventArgs e)
        {
            string result = null;
            foreach (User user in users)
            {
                if (user.Username == e.Usernametext)
                {
                    result = user.Username;
                }

            }
            return result;

        }
        public void OnSearchTextChanged(object sender, SearchUserEventArgs e)
        {
            List<User> resultUsers = new List<User>();
            List<string> resultString = new List<string>();
            resultUsers = users.Where(t =>
               t.Username.ToUpper().Contains(e.SearchText.ToUpper()))
           .ToList();
            if (resultUsers.Count > 0)
            {
                resultString.Add("-----Usuarios encontrados-----");
                foreach (User s in resultUsers)
                    resultString.Add(s.ToString());
            }
            view.UpdateResults(resultString);
        }

        public List<PlaylistSong> OnShowSongPlaylist(object sender, GetUserPlaylistEventsArgs e)
        {
            foreach (User usuario in users)
            {
                if (usuario.Username.ToUpper() == e.ActualLoggedUsername.ToUpper())
                {
                    return usuario.GetPlaylistSongs();
                }
            }
            return new List<PlaylistSong>() { new PlaylistSong("Sin Playlist") };
        }
        public List<PlaylistVideo> OnShowSongPlaylistVideo(object sender, GetUserPlaylistEventsArgs e)
        {
            foreach (User usuario in users)
            {
                if (usuario.Username.ToUpper() == e.ActualLoggedUsername.ToUpper())
                {
                    return usuario.GetPlaylistVideo();
                }
            }
            return new List<PlaylistVideo>() { new PlaylistVideo("Sin Playlist") };
        }

        public User OnUserRequest(object sender, LoginEventArgs e)
        {
            foreach (User usuario in users)
            {
                if (usuario.Username.ToUpper() == e.UsernameText.ToUpper())
                {
                    return usuario;
                }
            }
            return null;
        }

        public void OnAddMusicPlaylist(object sender, GetUserPlaylistEventsArgs e)
        {
            foreach (User usuario in users)
            {
                if (usuario.Username.ToUpper() == e.ActualLoggedUsername.ToUpper())
                {
                    usuario.AddMusicPlaylist(e.PlaylistNameText);
                }
            }
            SerializeData();
        }

        public void OnAddVideoPlaylist(object sender, GetUserPlaylistEventsArgs e)
        {
            foreach (User usuario in users)
            {
                if (usuario.Username.ToUpper() == e.ActualLoggedUsername.ToUpper())
                {
                    usuario.AddVideoPlaylist(e.PlaylistNameText);
                }
            }
            SerializeData();
        }

        public bool OnRemovePlaylist(object sender, GetUserPlaylistEventsArgs e)
        {
            foreach (User usuario in users)
            {
                if (usuario.Username.ToUpper() == e.ActualLoggedUsername.ToUpper())
                {
                    usuario.RemoveMusicPlaylist(e.ActualPlaylistSelected);
                    return false; // Elimina la playlist
                }
            }
            SerializeData();
            return true; //no elimina nada
        }
        public bool OnChangingpassword(object sender, ChangePasswordEventArgs e)
        {
            foreach (User user in users)
            {
                if (user.Username == e.Usertext)
                {
                    if (user.Password == e.Passwordtext)
                    {
                        user.Password = e.NewPasswordtext;
                        SerializeData();
                        return true;
                    }
                }
            }
            SerializeData();
            return false;
        }
        public void OnRecivingUserchanges(object sender, SendingtypeaccountEventArgs e)
        {
            foreach (User user in users)
            {
                if (user.Username == e.Usernametext)
                {
                    user.Edad = e.Agetext;
                    user.Privacidad = e.Privacidad;
                    user.Tipodeusuario = e.Typeaccount;
                    user.Genero = e.Genero;
                }
            }
            SerializeData();
        }
        public void OnArtistModeUserchanges(object sender, SendingArtistInfo e)
        {
            foreach (User user in users)
            {
                if (user.Username == e.Usernametext)
                {
                    user.Artist = e.ArtistText;
                   
                }
            }
            SerializeData();
        }
    }
}   