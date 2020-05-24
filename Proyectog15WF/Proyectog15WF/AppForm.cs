
using CustomEventArgs;
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

namespace Proyectog15WF
{

    public partial class AppForm : Form
    {
        int resultCounter = 0;
        string namevideo = "";
        string namesong = "";
        string nameuser = ""; //ESTE ES EL NO,BRE DEL USUARIO
        public delegate bool LoginEventHandler(object source, LoginEventArgs args);
        public event LoginEventHandler LoginButtonClicked;
        public event EventHandler<LoginEventArgs> UserChecked;
        public delegate bool RegisterEventHandler(object source, RegisterEventArgs args);
        public event RegisterEventHandler RegisterButtonClicked;
        public delegate string CheckusernameEventHandler(object source, RegisterEventArgs args);
        public event CheckusernameEventHandler Checkusernameregister;
        public event EventHandler<SearchUserEventArgs> Searching;
        public event EventHandler<SearchingSongorVideo> Searchingnamevideoorsong;

        public delegate string SelectedVideoEventHandler(object source, SelectVideoEventArgs args);
        public event SelectedVideoEventHandler Reproducevideo;
        public delegate string SelectedSongEventHandler(object source, SelectSongEventArgs args);
        public event SelectedSongEventHandler Reproducesong;

        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();
        string userlog = "";
        string namelog = "";
        string lastNameLog = "";
        string mailLog = "";

        public AppForm()
        {

            InitializeComponent();
            panels.Add("StartPanel", StartPanel);
            panels.Add("Registerpanel", RegisterPanel);
            panels.Add("LoginPanel", LoginPanel);
            panels.Add("Mainpanel", MainPanel);


        }

        private void HideSubPanel()
        {
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
            this.Close();
        }

    
        private void RegistrateButton_Click(object sender, EventArgs e)
        {
            StartPanel.SendToBack();
            RegisterPanel.BringToFront();
            RegisterPanel.Visible = true;

        }

        private void BackButtonLogin_Click(object sender, EventArgs e)
        {
            LoginPanel.SendToBack();
            StartPanel.BringToFront();
            LoginPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartPanel.SendToBack();
            LoginPanel.BringToFront();
            loginViewInvalidCredentialsAlert.ResetText();
            loginViewInvalidCredentialsAlert.Visible = false;
            SaveLogin.ResumeLayout();
            LoginPanel.Visible = true;
        }

        private void BackRegisterButton_Click(object sender, EventArgs e)
        {
            RegisterPanel.SendToBack();
            StartPanel.BringToFront();
            RegisterPanel.Visible = false;
        }

    
        private void OnLoginButtonClicked(string username, string pass)
        {
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

                    //if (gender=="hombre")
                    {
                        // GeneroComboBox.SelectedIndex = 0;//(Hombre0,mujer1,otro2)
                    }
                    //else
                    {
                        GeneroComboBox.SelectedIndex = 3;
                    }
                    bool TypeAcount = false;

                    if (TypeAcount)
                    {
                        TipoDeCuentaCombobox.SelectedIndex = 1;
                        //ArtisteModeButton.Visible = true;
                    }
                    else
                    {
                        TipoDeCuentaCombobox.SelectedIndex = 0;
                        //ArtisteModeButton.Visible = false;
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
                stackPanels.Add(panels["StartPanel"]);
                MainPanel.Visible = true;
                MainPanel.BringToFront();

                //ShowLastPanel();
            }
        }

        public void Onregisteredbutooncliked(string Name, string Lastname, string Username, string Mailuser, string Passworduser)
        {
            if (RegisterButtonClicked != null)
            {
                bool result = RegisterButtonClicked(this, new RegisterEventArgs() { Usernametext = Username, Passwordtext = Passworduser });
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
            userlog = username;
            OnLoginButtonClicked(username, pass);

        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            string nameInputuser = null;
            namelog = nameInputuser;
            string lastNameInputuser = null;
            lastNameLog = lastNameInputuser;
            string usernameInputuser = null;
            string mailInputuser = null;
            mailLog = mailInputuser;
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
            //MainScreenPanel.Visible = false;
            SearchMediapanel.Visible = false;
            SearchArtistPanel.Visible = false;
            SearchMainPanel.Visible = true;
            SearchUserPanel.Visible = true;

        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
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
            ReproduccionMainPanel.Visible = false;
            MainScreenPanel.Visible = true;
            SearchMainPanel.Visible = false;
            PlaylistMainPanel.Visible = false;
            ArtistModeMainPanel.Visible = false;
            ProfileMainPanel.Visible = false;

        }

        private void ProfileButton_Click_1(object sender, EventArgs e)
        {
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
            stackPanels.RemoveAt(stackPanels.Count - 1);
            ShowLastPanel();
        }

        private void SearchUserPaneltextbox_TextChanged(object sender, EventArgs e)
        {
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
            //MainScreenPanel.Visible = false;
            SubFiltersPanel.Visible = false;
            SearchUserPanel.Visible = false;
            SearchArtistPanel.Visible = false;
            SearchMainPanel.Visible = true;
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
            UploadVideoPanel.Visible = false;
            SongUploadPanel.Visible = true;
            ArtistModeMainPanel.Visible = true;
            AlbumArtistPanel.Visible = false;
            CancionSubidaConExito.Visible = false;
            
           
        }

        private void FiltersButton_Click(object sender, EventArgs e)
        {
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
            Button button = (Button)sender;
            FilterONlable.ResetText();
            FilterONlable.Text = button.Text;
        }

        private void ArtistSeachButton_Click(object sender, EventArgs e)
        {
            // MainScreenPanel.Visible = false;
            SearchUserPanel.Visible = false;
            SearchMediapanel.Visible = false;
            SearchArtistPanel.Visible = true;
            SearchMainPanel.Visible = true;

        }

        private void MySongplaylistButton_Click(object sender, EventArgs e)
        {
            PlaylistMySongPanel.Visible = true;
            MasEsuchadaPanel.Visible = false;
            FollowPlaylistSongPanel.Visible = false;
            SongsInMyPlaylistPanel.Visible = false;
            if (SubMyPlaylistPanel.Visible)
            {
                SubMyPlaylistPanel.Visible = false;
            }
            else
            {
                SubMyPlaylistPanel.Visible = true;
                MySongsListBox.Items.Add("--Favorites Songs--"); // con esto accedo al listbox de playlistsong y obtengo las playlist
                MySongsListBox.Items.Add(nameuser); //Aqui esta el nombre del usuario (lo puse aqui para comprobar si esta tomando el usuario cada vez que hago log in
            }
        }

        private void FollowingPlaylist_Click(object sender, EventArgs e)
        {
            FollowPlaylistSongPanel.Visible = true;
            PlaylistMySongPanel.Visible = false;
        }

        private void MostLisentSonButton_Click(object sender, EventArgs e)
        {
            MasEsuchadaPanel.Visible = true;
            FollowPlaylistSongPanel.Visible = false;
            PlaylistMySongPanel.Visible = false;
        }

        private void SongButton_Click(object sender, EventArgs e)
        {
            PlaylistMainPanel.Visible = true;
            PlaylistSongPanel.Visible = true;
            PlaylistVideoPanel.Visible = false;
            PlaylistMySongPanel.Visible = false;
            FollowPlaylistSongPanel.Visible = false;
            MasEsuchadaPanel.Visible = false;
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            PlaylistSongPanel.Visible = false;
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
            VideoMyPlaylistPanel.Visible = true;
            VideoFollowPanel.Visible = false;
            MasVistosPanel.Visible = false;
            if (SubVideoPlaylistPanel.Visible)
            {
                SubVideoPlaylistPanel.Visible = false;
            }
            else
            {
                SubVideoPlaylistPanel.Visible = true;
            }
        }

        private void UploadVideoButton_Click(object sender, EventArgs e)
        {
            ArtistModeMainPanel.Visible = true;
            UploadVideoPanel.Visible = true;
            SongUploadPanel.Visible = false;
            AlbumArtistPanel.Visible = false;
        }

        private void DescripcionVideo_Click(object sender, EventArgs e)
        {

        }

        private void SongAlbumButton_Click(object sender, EventArgs e)
        {
            SongsAlbumPanel.Visible = true;
            VideoAlbumPanel.Visible = false;
        }

        private void VideosAlbumButton_Click(object sender, EventArgs e)
        {
            SongsAlbumPanel.Visible = false;
            VideoAlbumPanel.Visible = true;
        }

        private void AlbumButton_Click(object sender, EventArgs e)
        {
            AlbumArtistPanel.Visible = true;
            ArtistModeMainPanel.Visible = true;
            UploadVideoPanel.Visible = false;
            SongUploadPanel.Visible = false;
            SongsAlbumPanel.Visible = false;
            VideoAlbumPanel.Visible = false;
        }


        private void MasVistoButton_Click(object sender, EventArgs e)
        {
            MasVistosPanel.Visible = true;
            VideoMyPlaylistPanel.Visible = false;
            VideoFollowPanel.Visible = false;
        }

        private void FolloweVideoButton_Click(object sender, EventArgs e)
        {
            VideoFollowPanel.Visible = true;
            MasVistosPanel.Visible = false;
            VideoMyPlaylistPanel.Visible = false;
        }

        private void EditeProfilebutton_Click(object sender, EventArgs e)
        {
            ProfileMainPanel.Visible = true;
            EditeProfilePanel.Visible = true;
            CambiarContraseñaPanel.Visible = false;
            CuentaPanel.Visible = false;
            MiInformacionPanel.Visible = false;

        }

        private void InfoProfileButton_Click(object sender, EventArgs e)
        {
            ProfileMainPanel.Visible = true;
            EditeProfilePanel.Visible = false;
            MiInformacionPanel.Visible = true;
            UserNameInfoInput.Text = userlog;
            SeguidoresPanel.Visible = false;
            SeguidosPanel.Visible = false;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            CambiarContraseñaPanel.Visible = true;
            CuentaPanel.Visible = false;

        }

    
        private void CuentaButton_Click(object sender, EventArgs e)
        {
            CambiarContraseñaPanel.Visible = false;
            CuentaPanel.Visible = true;
            InfomacionCuentaCambiadaLabel.Visible = false;
            ShowUserInfo();
        }
        private void CambiarFotoButton_Click(object sender, EventArgs e)
        {
            CambiarContraseñaPanel.Visible = false;
            CuentaPanel.Visible = false;
        }

        private void TipoDeCuentaCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GeneroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AceptarCambioCuenta_Click(object sender, EventArgs e)
        {
            string typeAccounte = this.TipoDeCuentaCombobox.SelectedItem.ToString();
            InfomacionCuentaCambiadaLabel.Visible = true;
            if (typeAccounte == "Premium")
            {
                //ArtisteModeButton.Visible = true;
            }
            else
            {
                //ArtisteModeButton.Visible = false;
            }
            string GenderAccounte = this.GeneroComboBox.SelectedItem.ToString();
            string ageAcctounte = this.EdadCuentaInput.SelectedText;
        }
        private void ShowUserInfo()
        {
            NombreCuentaImput.Text = namelog;
            ApellidoCuentaInput.Text = lastNameLog;
            UsuarioCuentaInput.Text = userlog;
            MailCuentaInput.Text = mailLog;
            EdadCuentaInput.Text = null;
        }

        private void FollowersButton_Click(object sender, EventArgs e)
        {
            SeguidoresPanel.Visible = true;
            SeguidosPanel.Visible = false;
        }

        private void FollowButton_Click(object sender, EventArgs e)
        {
            SeguidoresPanel.Visible = false;
            SeguidosPanel.Visible = true;
        }

        private void UsuarioCuentaInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {

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
        }

        private void QueueButton_Click(object sender, EventArgs e)
        {
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

            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        //Profile---------------------------------------------------------------------------------------------------//
        
        //Cambio contraseña:
        private void ChangePasswordAcepted(object sender, EventArgs e)
        {
            string pass = ContraseñaActualInput.Text;
            string newpass = NuevaContraseñainput.Text;

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
            string videoName = VideoNombreTextBox.Text;
            string videoCategoria = VideoCategoriaTextbox.Text;
            string videoGender = VideoGeneroTextBox.Text;
            string videoDescripcion = VideoDescripcionTextBox.Text;
            string videoResolucion = ResolucionVideo.Text;
            string videoEtudio = VideoEstudiTextbox.Text;

            bool exist = false;

            if (exist)
            {
                ErrorVideo.Visible = true;
            }
            else
            {
                VideoSubidoConExito.Visible = true; //Mensaje Video subido 
            }
        }

        // Subir cancion
        private void SubiCancionButton_Click(object sender, EventArgs e)
        {
            string songName = SongNameInput.Text;
            string songCategoria = SongCategoriaInput.Text;
            string songGender = SongGenderInput.Text;
            string songDiscorafia = SongDiscografiaInput.Text;
            string songLetra = SongLetraInput.Text;
            string songEtudio =SongStudioInput.Text;

            bool exist = false;

            if (exist)
            {
                //Falta error
            }
            else
            {
               CancionSubidaConExito.Visible = true; //Mensaje Video subido 
            }
        }

        //Playlist------------------------------------------------------------------------------------------------/

        //Videos
        private void MyVideoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FollowVideoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VideosMasVistos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPlaylistVideoButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteVideoPlaylistButton_Click(object sender, EventArgs e)
        {

        }

        //Canciones
        private void MySongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FollowPlaylistSongListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MasEscuchadaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPlaylistButton_Click(object sender, EventArgs e)
        {

        }

        private void DeletePlaylistButton_Click(object sender, EventArgs e)
        {

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

        private void VerCancionesEnMisPlaylistButton_Click(object sender, EventArgs e)
        {
            SongsInMyPlaylistPanel.Visible = true;
        }
        private void BackMyPlaylistSong_Click(object sender, EventArgs e)
        {
            SongsInMyPlaylistPanel.Visible = false;
        }
        private void SongInMyPlaylistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }    
}
