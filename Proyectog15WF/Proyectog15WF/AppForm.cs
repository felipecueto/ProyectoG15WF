
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
        public delegate bool LoginEventHandler(object source, LoginEventArgs args);
        public event LoginEventHandler LoginButtonClicked;
        public event EventHandler<LoginEventArgs> UserChecked;
        public delegate bool RegisterEventHandler(object source, RegisterEventArgs args);
        public event RegisterEventHandler RegisterButtonClicked;
        public delegate string CheckusernameEventHandler(object source, RegisterEventArgs args);
        public event CheckusernameEventHandler Checkusernameregister;
        public event EventHandler<SearchUserEventArgs> Searching;
        public event EventHandler<SearchingSongorVideo> Searchingnamevideoorsong;


        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();

        public AppForm()
        {

            InitializeComponent();
            panels.Add("StartPanel", StartPanel);
            panels.Add("Registerpanel", RegisterPanel);
            panels.Add("LoginPanel", LoginPanel);
            panels.Add("Mainpanel", MainPanel);


        }

        private void coustomdesing()
        {


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
        private void loginViewButton_Click(object sender, EventArgs e)
        {

        }

        private void SOPTLOGO_Click(object sender, EventArgs e)
        {

        }

        private void EXITbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartPanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void IniciarseccionLabelLogin_Click(object sender, EventArgs e)
        {

        }

        private void IniciarseccionLabelLogin_Click_1(object sender, EventArgs e)
        {

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
            OnLoginButtonClicked(username, pass);

        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
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

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {

        }

        private void ArtistModeButton_Click(object sender, EventArgs e)
        {

        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {


        }

        private void UserSeachButton_Click(object sender, EventArgs e)
        {
            //MainScreenPanel.Visible = false;
            SearchMediapanel.Visible = false;
            SearchArtistPanel.Visible = false;
            SearchMainPanel.Visible = true;
            SearchUserPanel.Visible = true;
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            ShowSubPanel(SubSerchPanel);
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
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            stackPanels.RemoveAt(stackPanels.Count-1);
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
            if (SubMyPlaylistPanel.Visible)
            {
                SubMyPlaylistPanel.Visible = false;
            }
            else
            {
                SubMyPlaylistPanel.Visible = true;
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

        }

        private void InfoProfileButton_Click(object sender, EventArgs e)
        {
            ProfileMainPanel.Visible = true;
            EditeProfilePanel.Visible = false;
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
        }

        private void PrivacidadButton_Click(object sender, EventArgs e)
        {
            CambiarContraseñaPanel.Visible = false;
           CuentaPanel.Visible = false;
        }

        private void CambiarFotoButton_Click(object sender, EventArgs e)
        {
            CambiarContraseñaPanel.Visible = false;
            CuentaPanel.Visible = false;
        }

       
    }
}
