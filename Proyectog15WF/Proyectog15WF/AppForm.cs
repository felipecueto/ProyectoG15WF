
using CustomEventArgs;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyectog15WF
{

    public partial class AppForm : Form
    {
        int resultCounter = 0;
        string namevideo = "";
        string namesong = "";
        string nameuser = ""; //ESTE ES EL NO,BRE DEL USUARIO
        bool buttonClickdelete = false;
        Song variablecancion = null; //CANCION SELECCIONADA
        Video variablevideo = null;
        List<Song> cancionesdelusuario = new List<Song>(); //LISTA DE CANCIONES DEL USUARIO
        List<Video> videosdelusuario = new List<Video>();
        public delegate bool LoginEventHandler(object source, LoginEventArgs args);
        public event LoginEventHandler LoginButtonClicked;
        public event EventHandler<LoginEventArgs> UserChecked;
        public delegate bool RegisterEventHandler(object source, RegisterEventArgs args);
        public event RegisterEventHandler RegisterButtonClicked;
        public delegate string CheckusernameEventHandler(object source, RegisterEventArgs args);
        public event CheckusernameEventHandler Checkusernameregister;
        public event EventHandler<SearchUserEventArgs> Searching;
        public event EventHandler<SearchingSongorVideo> Searchingnamevideoorsong;
        public delegate User LoginReturnUserEventHandler(object source, LoginEventArgs args);
        public event LoginReturnUserEventHandler Userrequest;

        // Eventos playlist
        public delegate List<PlaylistSong> SendingPlaylistHandler(object source, GetUserPlaylistEventsArgs args);
        public event SendingPlaylistHandler Sendingplaylist;
        public event SendingPlaylistHandler Sendingfollowedplaylist;
        public delegate List<PlaylistVideo> SendingPlaylistVideoHandler(object source, GetUserPlaylistEventsArgs args);
        public event SendingPlaylistVideoHandler SendingplaylistVideo;
        public event SendingPlaylistVideoHandler Sendingfollowedplaylistvideo;
        public event EventHandler<GetUserPlaylistEventsArgs> Addvideoplaylist;
        public delegate bool SendingActualPlaylistHandler(object source, GetUserPlaylistEventsArgs args);
        public event SendingActualPlaylistHandler Userselectedplaylist;
        public event SendingActualPlaylistHandler Userselectedvideoplaylist;
        public event EventHandler<GetUserPlaylistEventsArgs> Addplaylist;
        public event EventHandler<GetUserPlaylistEventsArgs> Followmusicplaylist;
        public event EventHandler<GetUserPlaylistEventsArgs> Followvideoplaylist;

        //Evnetos de reproduccion
        public delegate string SelectedVideoEventHandler(object source, SelectVideoEventArgs args);
        public event SelectedVideoEventHandler Reproducevideo;
        public delegate string SelectedSongEventHandler(object source, SelectSongEventArgs args);
        public event SelectedSongEventHandler Reproducesong;

        //Evento cambiar contraseña
        public delegate bool ChangepasswordEvnetHandler(object source, ChangePasswordEventArgs args);
        public event ChangepasswordEvnetHandler Changingpassword;
        //Evento para agregar cacnion a la playlist
        public delegate Song ReceiveSongEventHandler(object source, ReturnsongEventArgs args);
        public event ReceiveSongEventHandler Recivingsong;
        //Evento agregar video
        public delegate Video ReciveVideoEventHandler(object source, ReturnVideoEventArgs args);
        public event ReciveVideoEventHandler Recivingvideo;
        //Evento para enviar cambios del usuario
        public event EventHandler<SendingtypeaccountEventArgs> Userifosend;
        //Evento para envar Artista
        public event EventHandler<SendingArtistInfo> Artistifosend;
        //Evento´para serializar
        public event EventHandler<EventArgs> Serialize;
        //Evento para llamar al artista
        public delegate string TypeartistEventHandler(object source, LoginEventArgs args);
        public event TypeartistEventHandler Artistwithcaracteristics;
        //Evento para mandar la cancion
        public event EventHandler<SendingsongcaracteristicsEventArgs> Songcaracteristics;
        //Evento para mandar el video
        public event EventHandler<SendingvideocaracteristicsEventArgs> Videocaracteristics;
        //Evento para recibir la lista de canciones
        public delegate List<string> SongsEventHandler(object source, SendingSongsEventArgs args);
        public event SongsEventHandler Totalitsofsongs;
        // ver si existe la cancion
        public delegate bool VerfysongEventHandler(object source,SongsExistEventsArtgs args);
        public event VerfysongEventHandler verfyedsong;
        //Ver si el video existe
        public delegate bool VerfyvideoEventHandler(object source, VideosExistEventsArtgs args);
        public event VerfyvideoEventHandler verifyVideoExist;

        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();
        User actuallogeduser = null;
        bool prim = false;


        public AppForm()
        {

            InitializeComponent();
            panels.Add("StartPanel", StartPanel);
            panels.Add("Registerpanel", RegisterPanel);
            panels.Add("LoginPanel", LoginPanel);
            panels.Add("Mainpanel", MainPanel);
        }

        public void SerializeData()
        {
            if (Serialize != null)
            {
                Serialize(this, new EventArgs() { });
            }
        }
        private void HideSubPanel()

        {
            SerializeData();
            if (SubArtistPanel.Visible == true)
            {
                SubArtistPanel.Visible = false;
            }
            if (SubPlaylistPanel.Visible == true)
            {
                SubPlaylistPanel.Visible = false;
            }
            if (SubProfilePanel.Visible == true)
            {
                SubProfilePanel.Visible = false;
            }
            if (SubSerchPanel.Visible == true)
            {
                SubSerchPanel.Visible = false;
            }
        }
        private void ShowSubPanel(Panel submenu)
        {
            SerializeData();

            if (submenu.Visible == false)
            {
                HideSubPanel();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void EXITbutton_Click(object sender, EventArgs e)
        {
            SerializeData();
            this.Close();
        }


        private void RegistrateButton_Click(object sender, EventArgs e)
        {


            StartPanel.SendToBack();
            RegisterPanel.BringToFront();
            RegisterPanel.Visible = true;
            SerializeData();

        }

        private void BackButtonLogin_Click(object sender, EventArgs e)
        {

            SerializeData();
            LoginPanel.SendToBack();
            StartPanel.BringToFront();
            LoginPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerializeData();
            StartPanel.SendToBack();
            LoginPanel.BringToFront();
            loginViewInvalidCredentialsAlert.ResetText();
            loginViewInvalidCredentialsAlert.Visible = false;
            SaveLogin.ResumeLayout();
            LoginPanel.Visible = true;
        }

        private void BackRegisterButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            RegisterPanel.SendToBack();
            StartPanel.BringToFront();
            RegisterPanel.Visible = false;
        }


        private void OnLoginButtonClicked(string username, string pass)
        {
            SerializeData();
            if (LoginButtonClicked != null)
            {
                bool result = LoginButtonClicked(this, new LoginEventArgs() { UsernameText = username, PasswordText = pass });
                if (!result)
                {
                    UsernameInPutLogin.ResetText();
                    PasswordInPutLogin.ResetText();
                    loginViewInvalidCredentialsAlert.Text = "Credenciales invalidas";
                    loginViewInvalidCredentialsAlert.Visible = true;
                }
                else
                {
                    if (Userrequest != null)
                    {
                        actuallogeduser = Userrequest(this, new LoginEventArgs() { UsernameText = username });
                    }
                    {
                        string variable = actuallogeduser.Genero;
                        if (variable == "Hombre")
                        {
                            GeneroComboBox.SelectedIndex = 0;
                        }
                        if (variable == "Mujer")
                        {

                            GeneroComboBox.SelectedIndex = 1;
                        }
                        if (variable == "Otro")
                        {

                            GeneroComboBox.SelectedIndex = 2;
                        }
                        if (variable == "None")
                        {

                            GeneroComboBox.SelectedIndex = 3;
                        }
                    }

                    if (actuallogeduser.Artist != null)
                    {
                        VeryfyArtistPanel.Visible = false;
                        //prim = true;
                    }
                    else
                    {
                        VeryfyArtistPanel.Visible = true;
                        //prim = false;
                    }

                    if (actuallogeduser.Tipodeusuario.ToUpper() == "PREMIUM")
                    {
                        TipoDeCuentaCombobox.SelectedIndex = 1;
                        prim = true;
                    }
                    else
                    {
                        prim = false;
                        TipoDeCuentaCombobox.SelectedIndex = 0;
                        NotPrimiumLabelArtist.Visible = true;
                        TipoArtistacomboBox1.Visible = false;
                        TipodeArtistaModeLabel.Visible = false;
                        TipoArtistaButton.Visible = false;

                    }
                    if (actuallogeduser.Privacidad == "Privado")
                    {
                        PrivacidadInputCuenta.SelectedIndex = 1;
                    }
                    if (actuallogeduser.Privacidad == "Publico")
                    {
                        PrivacidadInputCuenta.SelectedIndex = 0;
                    }

                    NombreCuentaImput.Text = actuallogeduser.Name;
                    ApellidoCuentaInput.Text = actuallogeduser.Lastname;
                    UsuarioCuentaInput.Text = actuallogeduser.Username;
                    MailCuentaInput.Text = actuallogeduser.Mail;

                    if (actuallogeduser.Edad != "")
                    {
                        EdadCuentaInput.Text = actuallogeduser.Edad;
                        EdadCuentaInput.ReadOnly = true;
                    }
                    else
                    {
                        EdadCuentaInput.Text = null;
                        EdadCuentaInput.ReadOnly = false;
                    }

                    loginViewInvalidCredentialsAlert.ResetText();
                    loginViewInvalidCredentialsAlert.Visible = false;
                    OnUserChecked(username, pass);

                }
            }
        }
        private void OnUserChecked(string username, string password)
        {
            if (UserChecked != null)
            {
                UserChecked(this, new LoginEventArgs() { UsernameText = username, PasswordText = password });
                UsernameInPutLogin.ResetText();
                PasswordInPutLogin.ResetText();
                nameuser = username; //AQUI OBTENGO EL USUARIO QUE HACE LOGIN
                if (Userrequest != null)
                {
                    actuallogeduser = Userrequest(this, new LoginEventArgs() { UsernameText = username });
                }
                stackPanels.Add(panels["StartPanel"]);
                MainPanel.Visible = true;
                MainPanel.BringToFront();

                //ShowLastPanel();
            }
        }

        public void Onregisteredbutooncliked(string Name, string Lastname, string Username, string Mailuser, string Passworduser)
        {
            SerializeData();
            if (RegisterButtonClicked != null)
            {
                bool result = RegisterButtonClicked(this, new RegisterEventArgs() { Usernametext = Username, Passwordtext = Passworduser, Nametext = Name, Lastnametext = Lastname, Email = Mailuser });
                if (result)
                {
                    nameInputRegister.ResetText();
                    LastNameInputRegister.ResetText();
                    UsernameInputRegister.ResetText();
                    MailInputRegister.ResetText();
                    PasswordInputRegister.ResetText();
                    stackPanels.Add(panels["StartPanel"]);
                    ShowLastPanel();
                }
            }

        }
        private void ShowLastPanel()
        {
            SerializeData();
            foreach (Panel panel in panels.Values)
            {
                if (panel != stackPanels.Last())
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }
        }

        private void InicioLoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameInPutLogin.Text;
            string pass = PasswordInPutLogin.Text;
            SerializeData();
            OnLoginButtonClicked(username, pass);

        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            SerializeData();
            string nameInputuser = null;

            string lastNameInputuser = null;

            string usernameInputuser = null;
            string mailInputuser = null;

            string passwordInputUser = null;
            int count = 0;
            if (count == 0)
            {
                nameInputuser = nameInputRegister.Text;
                if (nameInputuser == "")
                {
                    MessageBox.Show("Nombre incorrecto");
                }
                else
                {
                    count++;
                }
                lastNameInputuser = LastNameInputRegister.Text;
                if (lastNameInputuser == "")
                {
                    MessageBox.Show("Apellido incorrecto");
                }
                else
                {
                    count++;
                }
                usernameInputuser = UsernameInputRegister.Text;
                if (usernameInputuser == "")
                {
                    MessageBox.Show("Nombre usuario incorrecto");
                }
                else if (OncheckUsernameregister(usernameInputuser) != null)
                {
                    MessageBox.Show("Ya existe este nombre de usuario");
                }
                else
                {
                    count++;
                }

                mailInputuser = MailInputRegister.Text;
                if (mailInputuser == "")
                {
                    MessageBox.Show("Mail incorrecto");
                }
                else
                {
                    count++;
                }

                passwordInputUser = PasswordInputRegister.Text;
                if (passwordInputUser == "" | passwordInputUser.Length < 8)
                {
                    MessageBox.Show("Su contraseña debe ser de largo 8 o mas");

                }
                else
                {
                    count++;
                }
                if (count == 5)
                {
                    Onregisteredbutooncliked(nameInputuser, lastNameInputuser, usernameInputuser, mailInputuser, passwordInputUser);
                    MessageBox.Show("Gracias por unirte a SpotFlix" + " " + usernameInputuser);
                    count = 0;
                }



            }



        }
        public string OncheckUsernameregister(string Username)
        {
            SerializeData();
            string check = null;
            if (Checkusernameregister != null)
            {
                if (Username == Checkusernameregister(this, new RegisterEventArgs() { Usernametext = Username }))
                {
                    check += Username;
                }
                else
                {
                    check = null;
                }
            }
            return check;

        }


        private void UserSeachButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            //MainScreenPanel.Visible = false;
            SearchMediapanel.Visible = false;
            SearchArtistPanel.Visible = false;
            SearchMainPanel.Visible = true;
            SearchUserPanel.Visible = true;
            SeguirPlaylistPanel.Visible = false;

        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            SerializeData();
            ShowSubPanel(SubSerchPanel);
            ReproduccionMainPanel.Visible = false;
            PlaylistMainPanel.Visible = false;
            ArtistModeMainPanel.Visible = false;
            ProfileMainPanel.Visible = false;

            if (SearchMainPanel.Visible)
            {
                MainScreenPanel.Visible = true;
                SearchUserPanel.Visible = false;
                SearchMediapanel.Visible = false;
                SearchArtistPanel.Visible = false;
                SearchMainPanel.Visible = false;
            }
            else
            {
                //SearchMainPanel.Visible = true;
                //SearchMediapanel.Visible = true;
                // SearchUserPanel.Visible = false;
                //ArtistSearchPanel.Visible = false;
                //SearchMediapanel.Visible = false;
            }
        }

        private void PlayListButton_Click_1(object sender, EventArgs e)
        {
            SerializeData();
            ShowSubPanel(SubPlaylistPanel);
            MainScreenPanel.Visible = true;
            SearchMainPanel.Visible = false;
            ArtistModeMainPanel.Visible = false;
            ProfileMainPanel.Visible = false;
            ReproduccionMainPanel.Visible = false;
            if (PlaylistMainPanel.Visible)
            {
                PlaylistMainPanel.Visible = false;
            }
            else
            {
                PlaylistMainPanel.Visible = false;
            }

        }

        private void ArtisteModeButton_Click(object sender, EventArgs e)
        {
            ShowSubPanel(SubArtistPanel);
            SerializeData();

            if (!prim)
            {
                VeryfyArtistPanel.Visible = true;
            }

            ReproduccionMainPanel.Visible = false;
            MainScreenPanel.Visible = true;
            SearchMainPanel.Visible = false;
            PlaylistMainPanel.Visible = false;
            ArtistModeMainPanel.Visible = false;
            ProfileMainPanel.Visible = false;

        }

        private void ProfileButton_Click_1(object sender, EventArgs e)
        {
            SerializeData();
            ShowSubPanel(SubProfilePanel);
            MainScreenPanel.Visible = true;
            SearchMainPanel.Visible = false;
            PlaylistMainPanel.Visible = false;
            ArtistModeMainPanel.Visible = false;
            ProfileMainPanel.Visible = false;
            ReproduccionMainPanel.Visible = false;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            //stackPanels.RemoveAt(stackPanels.Count - 1);
            // ShowLastPanel();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            SerializeData();
            MainPanel.Visible = false;
            SubArtistPanel.Visible = false;
            SubPlaylistPanel.Visible = false;
            SubProfilePanel.Visible = false;
            SubSerchPanel.Visible = false;
            MainScreenPanel.Visible = true;
            SearchMainPanel.Visible = false;
            PlaylistMainPanel.Visible = false;
            ArtistModeMainPanel.Visible = false;
            ProfileMainPanel.Visible = false;
            ReproduccionMainPanel.Visible = false;
        }

        private void SearchUserPaneltextbox_TextChanged(object sender, EventArgs e)
        {
            SerializeData();
            string searchtext = SearchUserPaneltextbox.Text;
            List<string> results = new List<string>();
            if (searchtext.Length >= 3)
            {
                CleanSearch();
                Noresult();
                if (Searching != null)
                {
                    Searching(this, new SearchUserEventArgs() { SearchText = searchtext });
                }

            }
        }
        private void Noresult()
        {
            SerializeData();
            SearchUserPanelResultlistusers.Items.Add("No results for search criteria");
        }
        private void CleanSearch()
        {
            resultCounter = 0;
            SearchUserPanelResultlistusers.Items.Clear();
        }
        public void UpdateResults(List<string> results)
        {
            if (results.Count > 0)
            {
                foreach (string result in results)
                {
                    if (resultCounter <= 50)
                    {
                        if (SearchUserPanelResultlistusers.Items.Count > 0 && SearchUserPanelResultlistusers.Items[0].Equals("No results for search criteria"))
                        {
                            SearchUserPanelResultlistusers.Items.Add(result);
                            SearchUserPanelResultlistusers.Items.RemoveAt(0);
                        }
                        else
                            SearchUserPanelResultlistusers.Items.Add(result);
                        resultCounter++;
                    }
                }
            }
        }

        private void MediaSeachButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            SubFiltersPanel.Visible = false;
            SearchUserPanel.Visible = false;
            SearchArtistPanel.Visible = false;
            SearchMainPanel.Visible = true;
            SubMediaSearchPanel.Visible = false;
            if (SearchMediapanel.Visible)
            {
                SearchMediapanel.Visible = true;
                FilterONlable.ResetText();
            }
            else
            {
                SearchMediapanel.Visible = true;
            }
        }
        private void Noresultsongorvideo()
        {
            SearchMediapanellistBox.Items.Add("No results for search criteria");
        }
        private void CleanSearchsongorvideo()
        {
            resultCounter = 0;
            SearchMediapanellistBox.Items.Clear();
        }

        private void SearchMediatextBox_TextChanged(object sender, EventArgs e)
        {
            SerializeData();
            string searchtext = SearchMediatextBox.Text;
            List<string> results = new List<string>();
            if (searchtext.Length >= 1)
            {
                Noresultsongorvideo();
                CleanSearchsongorvideo();
                if (Searchingnamevideoorsong != null)
                {
                    Searchingnamevideoorsong(this, new SearchingSongorVideo() { SearchTextSongVideo = searchtext });
                }

            }
        }
        public void UpdateResultsvideoandsong(List<string> results)
        {
            SerializeData();
            if (results.Count > 0)
            {
                foreach (string result in results)
                {
                    if (resultCounter <= 50)
                    {
                        if (SearchMediapanellistBox.Items.Count > 0 && SearchMediapanellistBox.Items[0].Equals("No results for search criteria"))
                        {
                            SearchMediapanellistBox.Items.Add(result);
                            SearchMediapanellistBox.Items.RemoveAt(0);
                        }
                        else
                            SearchMediapanellistBox.Items.Add(result);
                        resultCounter++;
                    }
                }
            }
        }

        private void UploadSongButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            UploadVideoPanel.Visible = false;
            SongUploadPanel.Visible = true;
            ArtistModeMainPanel.Visible = true;
            AlbumArtistPanel.Visible = false;
            CancionSubidaConExito.Visible = false;
            SongCategoriaInput.ResetText();
            SongGenderInput.ResetText();
            SongDiscografiaInput.ResetText();
            SongLetraInput.ResetText(); 
            SongStudioInput.ResetText();
            CancionSubidaConExito.Visible = false;

        }

        private void FiltersButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            FilterONlable.ResetText();
            if (SubFiltersPanel.Visible)
            {
                SubFiltersPanel.Visible = false;
            }
            else
            {
                SubFiltersPanel.Visible = true;
            }
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            Button button = (Button)sender;
            FilterONlable.ResetText();
            FilterONlable.Text = button.Text;
        }

        private void ArtistSeachButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            // MainScreenPanel.Visible = false;
            SearchUserPanel.Visible = false;
            SearchMediapanel.Visible = false;
            SearchArtistPanel.Visible = true;
            SearchMainPanel.Visible = true;

        }

        private void MySongplaylistButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            MySongsListBox.Items.Clear();
            PlaylistMySongPanel.Visible = true;
            MasEsuchadaPanel.Visible = false;
            FollowPlaylistSongPanel.Visible = false;
            SongsInMyPlaylistPanel.Visible = false;
            SongSeguidasPlaylistPanel.Visible = false;
            CrearSongPlaylistPanel.Visible = false;
            if (SubMyPlaylistPanel.Visible)
            {
                SubMyPlaylistPanel.Visible = false;
            }
            else
            {
                SubMyPlaylistPanel.Visible = true;
                foreach (PlaylistSong playlist in OnReciveUsernamePlaylist())
                {
                    if (!MySongsListBox.Items.Contains(playlist.GetPlaylistName()))
                    {
                        MySongsListBox.Items.Add(playlist.GetPlaylistName());// con esto accedo al listbox de playlistsong y obtengo las playlist
                    }
                }
            }
        }

        public List<PlaylistSong> OnReciveUsernamePlaylist()
        {
            if (Sendingplaylist != null)
            {
                List<PlaylistSong> Userplaylist = Sendingplaylist(this, new GetUserPlaylistEventsArgs() { ActualLoggedUsername = nameuser });
                return Userplaylist;
            }
            return null;
        }
        public List<PlaylistVideo> OnReciveUsernamePlaylistVideo()
        {
            if (Sendingplaylist != null)
            {
                List<PlaylistVideo> Userplaylist = SendingplaylistVideo(this, new GetUserPlaylistEventsArgs() { ActualLoggedUsername = nameuser });
                return Userplaylist;
            }
            return null;
        }

        public List<PlaylistSong> OnReciveUsernameFollowedPlaylist()
        {
            if (Sendingplaylist != null)
            {
                List<PlaylistSong> Userplaylist = Sendingfollowedplaylist(this, new GetUserPlaylistEventsArgs() { ActualLoggedUsername = nameuser });
                return Userplaylist;
            }
            return null;
        }
        public List<PlaylistVideo> OnReciveUsernameFollowedPlaylistVideo()
        {
            if (Sendingplaylist != null)
            {
                List<PlaylistVideo> Userplaylist = Sendingfollowedplaylistvideo(this, new GetUserPlaylistEventsArgs() { ActualLoggedUsername = nameuser });
                return Userplaylist;
            }
            return null;
        }


        private void FollowingPlaylist_Click(object sender, EventArgs e)
        {
            SerializeData();
            FollowPlaylistSongPanel.Visible = true;
            PlaylistMySongPanel.Visible = false;
            CrearSongPlaylistPanel.Visible = false;
            SubMyPlaylistPanel.Visible = false;

            foreach (PlaylistSong playlist in OnReciveUsernameFollowedPlaylist())
            {
                if (!FollowPlaylistSongListBox.Items.Contains(playlist.GetPlaylistName()))
                {
                    FollowPlaylistSongListBox.Items.Add(playlist.GetPlaylistName());// con esto accedo al listbox de playlistsong y obtengo las playlist
                }
            }
        }

        private void MostLisentSonButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            MasEsuchadaPanel.Visible = true;
            FollowPlaylistSongPanel.Visible = false;
            PlaylistMySongPanel.Visible = false;
            CrearSongPlaylistPanel.Visible = false;
            SubMyPlaylistPanel.Visible = false;
        }

        private void SongButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            PlaylistMainPanel.Visible = true;
            PlaylistSongPanel.Visible = true;
            PlaylistVideoPanel.Visible = false;
            PlaylistMySongPanel.Visible = false;
            FollowPlaylistSongPanel.Visible = false;
            MasEsuchadaPanel.Visible = false;
            SubMyPlaylistPanel.Visible = false;



        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            PlaylistSongPanel.Visible = false;
            SubVideoPlaylistPanel.Visible = false;
            PlaylistMainPanel.Visible = true;
            PlaylistVideoPanel.Visible = true;
            VideoFollowPanel.Visible = false;
            MasVistosPanel.Visible = false;
            VideoMyPlaylistPanel.Visible = false;
            VideoSubidoConExito.Visible = false;
            ErrorVideo.Visible = false;
        }

        private void MyVideoPlaylistButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            MyVideoListBox.Items.Clear();
            VideoMyPlaylistPanel.Visible = true;
            VideoFollowPanel.Visible = false;
            MasVistosPanel.Visible = false;
            MyVideoPlaylistPanel.Visible = false;
            CrearVideoPlaylistpanel.Visible = false;
            if (SubVideoPlaylistPanel.Visible)
            {
                SubVideoPlaylistPanel.Visible = false;
            }
            else
            {
                SubVideoPlaylistPanel.Visible = true;
                foreach (PlaylistVideo playlist in OnReciveUsernamePlaylistVideo())
                {
                    if (!MyVideoListBox.Items.Contains(playlist.GetPlaylistName()))
                    {
                        MyVideoListBox.Items.Add(playlist.GetPlaylistName());// con esto accedo al listbox de playlistsong y obtengo las playlist
                    }
                }
            }
        }

        private void UploadVideoButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            ArtistModeMainPanel.Visible = true;
            UploadVideoPanel.Visible = true;
            SongUploadPanel.Visible = false;
            AlbumArtistPanel.Visible = false;
            VideoSubidoConExito.Visible = false;
            VideoCategoriaTextbox.ResetText();
            VideoGeneroTextBox.ResetText();
            ResolucionTextBox.ResetText();
            VideoEstudiTextbox.ResetText();
            VideoDescripcionTextBox.ResetText();

        }

        private void SongAlbumButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            SongsAlbumPanel.Visible = true;
            VideoAlbumPanel.Visible = false;
            if (Totalitsofsongs != null)
            {
                List<string> listasdelartista = Totalitsofsongs(this, new SendingSongsEventArgs() { Sendinguser = nameuser });
                foreach (string songs in listasdelartista)
                {
                    AlbumCanciones.Items.Add(songs);
                }

            }



        }

        private void VideosAlbumButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            SongsAlbumPanel.Visible = false;
            VideoAlbumPanel.Visible = true;
        }

        private void AlbumButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            AlbumArtistPanel.Visible = true;
            ArtistModeMainPanel.Visible = true;
            UploadVideoPanel.Visible = false;
            SongUploadPanel.Visible = false;
            SongsAlbumPanel.Visible = false;
            VideoAlbumPanel.Visible = false;
        }


        private void MasVistoButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            MasVistosPanel.Visible = true;
            VideoMyPlaylistPanel.Visible = false;
            VideoFollowPanel.Visible = false;
            MyVideoPlaylistPanel.Visible = false;
            SubVideoPlaylistPanel.Visible = false;
        }

        private void FolloweVideoButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            VideoFollowPanel.Visible = true;
            MasVistosPanel.Visible = false;
            VideoMyPlaylistPanel.Visible = false;
            MyVideoPlaylistPanel.Visible = false;
            VideosInFollowingPlaylistPanel.Visible = false;
            SubVideoPlaylistPanel.Visible = false;
            foreach (PlaylistVideo playlist in OnReciveUsernameFollowedPlaylistVideo())
            {
                if (!FollowVideoListBox.Items.Contains(playlist.GetPlaylistName()))
                {
                    FollowVideoListBox.Items.Add(playlist.GetPlaylistName());// con esto accedo al listbox de playlistsong y obtengo las playlist
                }
            }
        }

        private void EditeProfilebutton_Click(object sender, EventArgs e)
        {
            SerializeData();
            ProfileMainPanel.Visible = true;
            EditeProfilePanel.Visible = true;
            CambiarContraseñaPanel.Visible = false;
            CuentaPanel.Visible = false;
            MiInformacionPanel.Visible = false;

        }

        private void InfoProfileButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            ProfileMainPanel.Visible = true;
            EditeProfilePanel.Visible = false;
            MiInformacionPanel.Visible = true;
            UserNameInfoInput.Text = nameuser;
            SeguidoresPanel.Visible = false;
            SeguidosPanel.Visible = false;
            ImagePanel.Visible = false;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            CambiarContraseñaPanel.Visible = true;
            CuentaPanel.Visible = false;
            ImagePanel.Visible = false;

        }


        private void CuentaButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            CambiarContraseñaPanel.Visible = false;
            CuentaPanel.Visible = true;
            InfomacionCuentaCambiadaLabel.Visible = false;
            ImagePanel.Visible = false;
        }
        private void CambiarFotoButton_Click(object sender, EventArgs e)
        {
            CambiarContraseñaPanel.Visible = false;
            CuentaPanel.Visible = false;
            ImagePanel.Visible = true;
            SerializeData();
        }

        private void TipoDeCuentaCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GeneroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AceptarCambioCuenta_Click(object sender, EventArgs e)
        {
            string typeAccounte = Convert.ToString(this.TipoDeCuentaCombobox.SelectedItem);
            string GenderAccounte = Convert.ToString(this.GeneroComboBox.SelectedItem);
            string ageAcctounte = Convert.ToString(this.EdadCuentaInput.Text);
            string privacidad = Convert.ToString(this.PrivacidadInputCuenta.SelectedItem);

            if (Userifosend != null)
            {
                Userifosend(this, new SendingtypeaccountEventArgs() { Usernametext = nameuser, Typeaccount = typeAccounte, Genero = GenderAccounte, Agetext = ageAcctounte, Privacidad = privacidad });
            }
            InfomacionCuentaCambiadaLabel.Visible = true;

            if (ageAcctounte != "")
            {
                EdadCuentaInput.ReadOnly = true;
            }

            if (typeAccounte == "Premium")
            {
                VeryfyArtistPanel.Visible = true;
                NotPrimiumLabelArtist.Visible = false;
                TipoArtistacomboBox1.Visible = true;
                TipoArtistacomboBox1.SelectedIndex = 0;
                TipodeArtistaModeLabel.Visible = true;
                TipoArtistaButton.Visible = true;
                prim = true;
            }
            else
            {
                VeryfyArtistPanel.Visible = true;
                NotPrimiumLabelArtist.Visible = true;
                TipoArtistacomboBox1.Visible = false;
                TipodeArtistaModeLabel.Visible = false;
                TipoArtistaButton.Visible = false;
            }
            SerializeData();

        }


        private void FollowersButton_Click(object sender, EventArgs e)
        {
            SeguidoresPanel.Visible = true;
            SeguidosPanel.Visible = false;
            SerializeData();
        }

        private void FollowButton_Click(object sender, EventArgs e)
        {
            SeguidoresPanel.Visible = false;
            SeguidosPanel.Visible = true;
            SerializeData();
        }

        private void PlayButton_Click_1(object sender, EventArgs e)
        {
            CalificacionComboBox.SelectedIndex = 0;

            if (ReproduccionMainPanel.Visible)
            {
                ReproduccionMainPanel.Visible = false;

            }
            else
            {
                ReproduccionMainPanel.Visible = true;
                if (namesong != "" && namevideo == "")
                {
                    axWindowsMediaPlayer1.URL = namesong;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    namesong = "";
                    namevideo = "";



                }
                else if (namesong == "" && namevideo != "")
                {
                    axWindowsMediaPlayer1.URL = namevideo;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    namesong = "";
                    namevideo = "";

                }

            }
            SerializeData();
        }

        private void QueueButton_Click(object sender, EventArgs e)
        {
            SerializeData();
            if (QueuePanel.Visible)
            {
                QueuePanel.Visible = false;
            }
            else
            {
                QueuePanel.Visible = true;

            }
        }

        private void SearchMediapanellistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerializeData();
            if (Reproducevideo != null)
            {
                if (!SearchMediapanellistBox.SelectedItem.Equals("No results for search criteria"))
                {


                    namevideo = Reproducevideo(this, new SelectVideoEventArgs() { Selectedvideo = Convert.ToString(SearchMediapanellistBox.SelectedItem) });



                }
            }
            if (Reproducesong != null)
            {
                if (!SearchMediapanellistBox.SelectedItem.Equals("No results for search criteria"))
                {
                    namesong = Reproducesong(this, new SelectSongEventArgs() { Selectedsong = Convert.ToString(SearchMediapanellistBox.SelectedItem) });


                }

            }
            if (Recivingsong != null)
            {
                if (!SearchMediapanellistBox.SelectedItem.Equals("No results for search criteria"))
                {
                    variablecancion = Recivingsong(this, new ReturnsongEventArgs() { Verifysonginsongofuser = Convert.ToString(SearchMediapanellistBox.SelectedItem) });
                    cancionesdelusuario.Add(variablecancion);


                }

            }
            if (Recivingvideo != null)
            {
                if (!SearchMediapanellistBox.SelectedItem.Equals("No results for search criteria"))
                {
                    variablevideo = Recivingvideo(this, new ReturnVideoEventArgs() { Verifyvideoinvideoofuser = Convert.ToString(SearchMediapanellistBox.SelectedItem) });
                    videosdelusuario.Add(variablevideo);
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        //Profile---------------------------------------------------------------------------------------------------//

        //Cambio contraseña:
        private void ChangePasswordAcepted(object sender, EventArgs e)
        {
            SerializeData();
            string pass = ContraseñaActualInput.Text;
            string newpass = NuevaContraseñainput.Text;
            if (Changingpassword != null)
            {
                bool result = Changingpassword(this, new ChangePasswordEventArgs() { Usertext = nameuser, Passwordtext = pass, NewPasswordtext = newpass });
                if (result)
                {
                    MessageBox.Show("Contraseña cambiada");
                }
                else
                {
                    MessageBox.Show("Error al escribir la contraseña");
                }
            }

        }

        //Mi Informacion
        private void SeguidosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DejarDeSeguirButton1_Click(object sender, EventArgs e)
        {

        }

        private void SeguidoreslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Modo Artista ----------------------------------------------------------------------------------//
        //AlbumVideo
        private void VideoAlbumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }
        //AlbumCancion
        private void AlbumCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Subir Video
        private void SubirVideoButton_Click(object sender, EventArgs e)
        {
            string videoCategoria = null;
            string videoGender = null;
            string videoDescripcion = null;
            string videoResolucion = null;
            string videoEtudio = null;
            string path;
            string videoName;
            int count = 0;
            videoCategoria = VideoCategoriaTextbox.Text;
            if (videoCategoria == "")
            {
                MessageBox.Show("Falta campo categoria");
            }
            else
            {
                count++;
            }
            videoGender = VideoGeneroTextBox.Text;
            if (videoGender == "")
            {
                MessageBox.Show("Falta campo Genero");
            }
            else
            {
                count++;
            }
            videoDescripcion = VideoDescripcionTextBox.Text;
            if (videoDescripcion == "")
            {
                MessageBox.Show("Falta campo descripcion");
            }
            else
            {
                count++;
            }
            videoResolucion = ResolucionTextBox.Text;
            if (videoResolucion == "")
            {
                MessageBox.Show("Falta campo Resolucion");
            }
            else
            {
                count++;
            }
            videoEtudio = VideoEstudiTextbox.Text;
            if (videoEtudio == "")
            {
                MessageBox.Show("Falta campo estudio");

            }
            else
            {
                count++;
            }
            if (count == 5)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Selecione elvideo";
                openFileDialog.Filter = "Video file (*.MP4; *.WEBM;*AVI; *.MPG; *.H264;*.MOV;*.WMV;)| *.MP4; *.WEBM;*AVI; *.MPG; *.H264;*.MOV;*.WMV;";

                bool exist = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    videoName = openFileDialog.SafeFileName;
                    path = openFileDialog.FileName;

                    if (verifyVideoExist != null)
                    {
                        exist = verifyVideoExist(this, new VideosExistEventsArtgs() {VideoNameText = videoName });
                    }
                    if (exist)
                    {
                        MessageBox.Show("Esta video ya existe");
                    }
                    else
                    {
                        String[] separator = { " " };
                        string user_typeartist = Artistwithcaracteristics(this, new LoginEventArgs() { UsernameText = nameuser });
                        String[] username_typeartist = user_typeartist.Split(separator, StringSplitOptions.RemoveEmptyEntries);//[0] nombre(real) del usuario, [1] tipo de artista, [2] genero, [3] edad
                        if (Videocaracteristics != null)
                        {
                            Videocaracteristics(this, new SendingvideocaracteristicsEventArgs() { Videoname = videoName, Genero = videoGender, Categoria = videoCategoria, Actor = username_typeartist[0], Director = username_typeartist[0], Estudio = videoEtudio, Descripcion = videoDescripcion, Sexo = username_typeartist[2], Edad = username_typeartist[3], Resolution = videoResolucion, path = path });
                            MessageBox.Show("Video subido con exito");
                            VideoCategoriaTextbox.ResetText();
                            VideoGeneroTextBox.ResetText();
                            ResolucionTextBox.ResetText();
                            VideoEstudiTextbox.ResetText();
                            VideoDescripcionTextBox.ResetText();
                        }
                    }
                }
                SerializeData();
            }

        }

        // Subir cancion
        private void SubiCancionButton_Click(object sender, EventArgs e)
        {
            string songCategoria = null;
            string songGender = null;
            string songDiscorafia = null;
            string songLetra = null;
            string songEtudio = null;
            string path;
            string songName;
            int count = 0;

            songCategoria = SongCategoriaInput.Text;

            if (songCategoria == "")
            {
                MessageBox.Show("Falta campo categoria");
            }
            else
            {
                count++;
            }
            songGender = SongGenderInput.Text;
            if (songGender == "")
            {
                MessageBox.Show("Falta campo genero");
            }
            else
            {
                count++;
            }
            songDiscorafia = SongDiscografiaInput.Text;
            if (songDiscorafia == "")
            {
                MessageBox.Show("Falta campo discografia");
            }
            else
            {
                count++;
            }
            songLetra = SongLetraInput.Text;
            if (songLetra == "")
            {
                MessageBox.Show("Falta campo letra");
            }
            else
            {
                count++;
            }
            songEtudio = SongStudioInput.Text;
            if (songEtudio == "")
            {
                MessageBox.Show("Falta campo estudio");
            }
            else
            {
                count++;
            }
            if (count == 5)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Selecione la cancion";
                openFileDialog.Filter = "Song file (*.MP3; *.mp3;)|*.MP3; *.mp3";
                bool exist = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    songName = openFileDialog.SafeFileName;
                    if (verfyedsong != null)
                    {
                        exist = verfyedsong(this, new SongsExistEventsArtgs() {SongName=songName });
                    }
                    if (exist)
                    {
                        MessageBox.Show("Esta cancion ya existe");
                        SongCategoriaInput.ResetText();
                        SongGenderInput.ResetText();
                        SongDiscografiaInput.ResetText();
                        SongLetraInput.ResetText();
                        SongStudioInput.ResetText();
                    }
                    else
                    { 
                        path = openFileDialog.FileName;
                        String[] separator = { " " };
                        string user_typeartist = Artistwithcaracteristics(this, new LoginEventArgs() { UsernameText = nameuser });
                        String[] username_typeartist = user_typeartist.Split(separator, StringSplitOptions.RemoveEmptyEntries); //[0] nombre(real) del usuario, [1] tipo de artista, [2] genero, [3] edad
                        if (Songcaracteristics != null)
                        {
                            try
                            {
                                Songcaracteristics(this, new SendingsongcaracteristicsEventArgs() { Nombrecancion = songName, Genero = songGender, Compositor = username_typeartist[0], Discografia = songDiscorafia, Estudio = songEtudio, Letra = songLetra, Sexo = username_typeartist[2], Edad = username_typeartist[3], Categoria = songCategoria, path = path });
                                MessageBox.Show("Cancion subida con exito");
                                SongCategoriaInput.ResetText();
                                SongGenderInput.ResetText();
                                SongDiscografiaInput.ResetText();
                                SongLetraInput.ResetText();
                                SongStudioInput.ResetText();
                            }
                            catch
                            {
                                MessageBox.Show("Te faltan datos por rellenar en tu cuenta");
                            }
                        }
                    }
                }
            }


 
                SerializeData();
            
        }
        //Playlist------------------------------------------------------------------------------------------------/

        //Videos
        private void MyVideoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MisVideoMyPlaylist.Items.Clear();
            string playlist_seleccionada = Convert.ToString(MyVideoListBox.SelectedItem);

            foreach (PlaylistVideo playlist in OnReciveUsernamePlaylistVideo())
            {
                if (playlist.GetPlaylistName() == playlist_seleccionada)
                {
                    foreach (Video videos in playlist.GetPlaylistAllVideos())
                    {
                        MisVideoMyPlaylist.Items.Add(videos.VideoName);
                    }
                }
            }
            SerializeData();
        }

        private void FollowVideoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideosInFollowingPlaylistListbox.Items.Clear();
            string playlist_seleccionada = Convert.ToString(FollowVideoListBox.SelectedItem);

            foreach (PlaylistVideo playlist in OnReciveUsernameFollowedPlaylistVideo())
            {
                if (playlist.GetPlaylistName() == playlist_seleccionada)
                {
                    foreach (Video videos in playlist.GetPlaylistAllVideos())
                    {
                        VideosInFollowingPlaylistListbox.Items.Add(videos.VideoName);
                    }
                }
            }
        }

        private void VideosMasVistos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPlaylistVideoButton_Click(object sender, EventArgs e)
        {
            Errorplaylistvideo.Visible = false;
            NombrePlaylistExiste.Visible = false;
            VideoPlaylistCreadaConExitoLabel.Visible = false;
            CrearVideoPlaylistpanel.Visible = true;
            SerializeData();

        }


        private void DeleteVideoPlaylistButton_Click(object sender, EventArgs e)
        {
            buttonClickdelete = true;
            string playlist_seleccionada = Convert.ToString(MyVideoListBox.SelectedItem);
            if (Userselectedvideoplaylist != null)
            {

                if (Userselectedvideoplaylist(this, new GetUserPlaylistEventsArgs { ActualPlaylistSelected = playlist_seleccionada, ActualLoggedUsername = nameuser }) && buttonClickdelete)
                {
                    MyVideoListBox.Items.Remove(playlist_seleccionada);
                }
            }
        }

        //Canciones
        private void MySongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SongInMyPlaylistListBox.Items.Clear();
            string playlist_seleccionada = Convert.ToString(MySongsListBox.SelectedItem);

            foreach (PlaylistSong playlist in OnReciveUsernamePlaylist())
            {
                if (playlist.GetPlaylistName() == playlist_seleccionada)
                {
                    foreach (Song canciones in playlist.GetPlaylistAllSongs())
                    {
                        SongInMyPlaylistListBox.Items.Add(canciones.Namesong);
                    }
                }
            }
            SerializeData();
        }

        private void FollowPlaylistSongListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SongsInFollowPlaylistListBox.Items.Clear();
            string playlist_seleccionada = Convert.ToString(FollowPlaylistSongListBox.SelectedItem);

            foreach (PlaylistSong playlist in OnReciveUsernameFollowedPlaylist())
            {
                if (playlist.GetPlaylistName() == playlist_seleccionada)
                {
                    foreach (Song song in playlist.GetPlaylistAllSongs())
                    {
                        SongsInFollowPlaylistListBox.Items.Add(song.Namesong);
                    }
                }
            }
        }

        private void MasEscuchadaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPlaylistButton_Click(object sender, EventArgs e)
        {
            CrearSongPlaylistPanel.Visible = true;
            ErrorCuentaPrivadaPlaylistSong.Visible = false;
            ErrorExisteSongPlaylisteNombre.Visible = false;
            PlaylistSongCreada.Visible = false;
            SerializeData();
        }

        private void DeletePlaylistButton_Click(object sender, EventArgs e)
        {
            buttonClickdelete = true;
            string playlist_seleccionada = Convert.ToString(MySongsListBox.SelectedItem);
            if (Userselectedplaylist != null)
            {

                if (Userselectedplaylist(this, new GetUserPlaylistEventsArgs { ActualPlaylistSelected = playlist_seleccionada, ActualLoggedUsername = nameuser }) && buttonClickdelete)
                {
                    MySongsListBox.Items.Remove(playlist_seleccionada);
                }
            }
            SerializeData();
        }

        private void VerCancionesEnMisPlaylistButton_Click(object sender, EventArgs e)
        {
            SongsInMyPlaylistPanel.Visible = true;
            SerializeData();
        }
        private void BackMyPlaylistSong_Click(object sender, EventArgs e)
        {
            SongsInMyPlaylistPanel.Visible = false;
            SerializeData();
        }

        private void SongInMyPlaylistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerCancionesPlaylistSeguidas_Click(object sender, EventArgs e)
        {
            SongSeguidasPlaylistPanel.Visible = true;
            SerializeData();
        }

        private void BackPlaylistSeguidas_Click(object sender, EventArgs e)
        {
            SongSeguidasPlaylistPanel.Visible = false;
            SerializeData();
        }

        private void SongsInFollowPlaylistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSongMyPlaylists_Click(object sender, EventArgs e)
        {

        }

        private void BorrarCancionMyplaylist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void CrearSongPlaylistButton_Click(object sender, EventArgs e)
        {
            string nameplaylist = PlaylistSongNameInput.Text;
            string privacidad = Convert.ToString(NewSongPrivacidadComboBox.SelectedItem);
            bool UserNotPublic = false;
            bool NamePlaylistExist = false;
            if (Addplaylist != null)
            {
                Addplaylist(this, new GetUserPlaylistEventsArgs() { PlaylistNameText = nameplaylist, ActualLoggedUsername = nameuser }); //le estoy mandado a usercontroller el nombre de la playlist
            }
            if (UserNotPublic)
            {
                ErrorCuentaPrivadaPlaylistSong.Visible = true;
            }
            if (NamePlaylistExist)
            {
                ErrorExisteSongPlaylisteNombre.Visible = true;
            }
            else
            {
                PlaylistSongCreada.Visible = true;
            }
            SerializeData();
        }

        //Search-----------------------------------------------------------------------------------------------------//

        private void SearchUserPanelResultlistusers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchArtistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        //Reproducion------------------------------------------------------------------------------------------------//
        private void CalsificacionButton_Click(object sender, EventArgs e)
        {
            string qual = CalificacionComboBox.SelectedItem.ToString();
        }

        private void VideoInMyplaylistButton_Click(object sender, EventArgs e)
        {
            MyVideoPlaylistPanel.Visible = true;
        }

        private void BackMyVideoPlaylistButton_Click(object sender, EventArgs e)
        {
            MyVideoPlaylistPanel.Visible = false;
        }

        private void CrearVideoPlaylist_Click(object sender, EventArgs e)
        {

            string nameVideo = NombreVideoPlalistInput.Text;
            string privacidad = Convert.ToString(PrivacidadVideoPlaylist.SelectedItem);

            bool UserNotPublic = false;
            bool NamePlaylistExist = false;

            if (Addvideoplaylist != null)
            {
                Addvideoplaylist(this, new GetUserPlaylistEventsArgs() { PlaylistNameText = nameVideo, ActualLoggedUsername = nameuser }); //le estoy mandado a usercontroller el nombre de la playlist
            }

            if (UserNotPublic)
            {
                Errorplaylistvideo.Visible = true;
            }
            if (NamePlaylistExist)
            {
                NombrePlaylistExiste.Visible = true;
            }
            else
            {
                VideoPlaylistCreadaConExitoLabel.Visible = true;
            }
            SerializeData();

        }

        private void BackFollowingPlaylist_Click(object sender, EventArgs e)
        {
            VideosInFollowingPlaylistPanel.Visible = false;
            SerializeData();
        }

        private void VideosInFollowingPlaylistButton_Click(object sender, EventArgs e)
        {
            VideosInFollowingPlaylistPanel.Visible = true;
            SerializeData();
        }

        private void VideosInFollowingPlaylistListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MisVideoMyPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMediaButton_Click(object sender, EventArgs e)
        {

        }

        //Este metodo es para que apareca el panel del playlist

        private void AddToPlaylistButton_Click(object sender, EventArgs e)
        {
            if (SubMediaSearchPanel.Visible)
            {
                SubMediaSearchPanel.Visible = false;
            }
            else
            {
                SubMediaSearchPanel.Visible = true;

                foreach (PlaylistVideo playlist in OnReciveUsernamePlaylistVideo())
                {
                    if (!PlaylistListBoxAdd.Items.Contains(playlist.GetPlaylistName()))
                    {
                        PlaylistListBoxAdd.Items.Add(playlist.GetPlaylistName());// con esto accedo al listbox de playlistsong y obtengo las playlist
                    }
                }

                foreach (PlaylistSong playlist in OnReciveUsernamePlaylist())
                {
                    if (!PlaylistListBoxAdd.Items.Contains(playlist.GetPlaylistName()))
                    {
                        PlaylistListBoxAdd.Items.Add(playlist.GetPlaylistName());// con esto accedo al listbox de playlistsong y obtengo las playlist
                    }
                }
            }
            SerializeData();
        }

        private void PlaylistListBoxAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool botonparaagregaralaplaylist = false; //boton que agrega a la playlist
        private void AgregarMediaPlaylistButton_Click(object sender, EventArgs e)
        {
            botonparaagregaralaplaylist = true;
            if (!PlaylistListBoxAdd.SelectedItem.Equals("No results for search criteria") && botonparaagregaralaplaylist)
            {
                bool songflag = false;
                bool videoflag = false;
                try
                {
                    List<PlaylistSong> playlistSong = OnReciveUsernamePlaylist();

                    foreach (PlaylistSong cancionesinplaylistsong in playlistSong)
                    {
                        if (cancionesinplaylistsong.GetPlaylistName() == Convert.ToString(PlaylistListBoxAdd.SelectedItem))
                        {
                            foreach (Song song in cancionesdelusuario)
                            {
                                if (Convert.ToString(SearchMediapanellistBox.SelectedItem).Contains(song.Namesong))
                                {
                                    cancionesinplaylistsong.AddSong(song);
                                    botonparaagregaralaplaylist = false;
                                    MessageBox.Show("Cancion Agregado");
                                    cancionesdelusuario.Clear();
                                }
                            }
                        }
                    }
                }
                catch
                {
                    songflag = true;
                }
                try
                {
                    List<PlaylistVideo> playlistVideo = OnReciveUsernamePlaylistVideo();

                    foreach (PlaylistVideo cancionesinplaylistvideo in playlistVideo)
                    {
                        if (cancionesinplaylistvideo.GetPlaylistName() == Convert.ToString(PlaylistListBoxAdd.SelectedItem))
                        {
                            foreach (Video video in videosdelusuario)
                            {
                                if (Convert.ToString(SearchMediapanellistBox.SelectedItem).Contains(video.VideoName))
                                {
                                    cancionesinplaylistvideo.AddVideo(video);
                                    botonparaagregaralaplaylist = false;
                                    MessageBox.Show("Video Agregado");
                                    videosdelusuario.Clear();
                                }
                            }
                        }
                    }
                }
                catch
                {
                    videoflag = true;
                }

                if (videoflag == true && songflag == true)
                {
                    MessageBox.Show("No se pueden agregar canciones o videos a playlist que no son de su tipo");
                }

            }
            SerializeData();
        }
        //Buscar Usuario--------------------------------------------------------------------------------------------------//

        private void FollowUserButton_Click(object sender, EventArgs e)
        {

        }

        public List<PlaylistSong> OnReciveUsernamePlaylist(string selecteduser)
        {
            if (Sendingplaylist != null)
            {
                List<PlaylistSong> Userplaylist = Sendingplaylist(this, new GetUserPlaylistEventsArgs() { ActualLoggedUsername = selecteduser });
                return Userplaylist;
            }
            return null;
        }
        public List<PlaylistVideo> OnReciveUsernamePlaylistVideo(string selecteduser)
        {
            if (Sendingplaylist != null)
            {
                List<PlaylistVideo> Userplaylist = SendingplaylistVideo(this, new GetUserPlaylistEventsArgs() { ActualLoggedUsername = selecteduser });
                return Userplaylist;
            }
            return null;
        }

        private void PlaylistsUserSearchButton_Click(object sender, EventArgs e)
        {

            string selecteduser = Convert.ToString(SearchUserPanelResultlistusers.SelectedItem);

            foreach (PlaylistSong playlist in OnReciveUsernamePlaylist(selecteduser))
            {
                if (!SearchUserPlaylistListbox.Items.Contains(playlist.GetPlaylistName()))
                {
                    SearchUserPlaylistListbox.Items.Add(playlist.GetPlaylistName());// con esto accedo al listbox de playlistsong y obtengo las playlist
                }
            }
            foreach (PlaylistVideo playlist in OnReciveUsernamePlaylistVideo(selecteduser))
            {
                if (!SearchUserPlaylistListbox.Items.Contains(playlist.GetPlaylistName()))
                {
                    SearchUserPlaylistListbox.Items.Add(playlist.GetPlaylistName());// con esto accedo al listbox de playlistsong y obtengo las playlist
                }
            }
            if (SeguirPlaylistPanel.Visible)
            {
                SeguirPlaylistPanel.Visible = false;
            }
            else
            {
                SeguirPlaylistPanel.Visible = true;
            }
            SerializeData();
        }

        private void SearchUserPlaylistListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FollowPlyalistButton_Click(object sender, EventArgs e)
        {
            string selecteduser = Convert.ToString(SearchUserPanelResultlistusers.SelectedItem);
            string selectedplaylist = Convert.ToString(SearchUserPlaylistListbox.SelectedItem);
            Followmusicplaylist(this, new GetUserPlaylistEventsArgs() { ActualLoggedUsername = nameuser, ActualPlaylistSelected = selectedplaylist, ActualUsernameSelected = selecteduser });

            Followvideoplaylist(this, new GetUserPlaylistEventsArgs() { ActualLoggedUsername = nameuser, ActualPlaylistSelected = selectedplaylist, ActualUsernameSelected = selecteduser });

        }

        private void TipoArtistaButton_Click(object sender, EventArgs e)
        {
            string artist = this.TipoArtistacomboBox1.SelectedItem.ToString();


            if (Artistifosend != null)
            {
                Artistifosend(this, new SendingArtistInfo() { Usernametext = nameuser, ArtistText = artist });
            }
            VeryfyArtistPanel.Visible = false;
            SerializeData();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione la imagen";
            openFileDialog.Filter = "Image file (*.jpg; *.jpeg;*.bmp;)|*.jpg; *.jpeg;*.bmp;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = image;
            }
        }

        private void VolumenTrackBar1_Scroll(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.settings.volume = VolumenTrackBar1.Value;
        }


        //----------------------------------------------------------Botones Nuevos--------------------------------------------------------//
        private void DejarSeguirVideoPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void DejarSeguirCancionbutton_Click(object sender, EventArgs e)
        {

        }

        private void Album_Click(object sender, EventArgs e)
        {

        }

        private void AlbumSearchArtistListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FollowArtist_Click(object sender, EventArgs e)
        {

        }
    }
}