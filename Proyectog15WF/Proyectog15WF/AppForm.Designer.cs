namespace Proyectog15WF
{
    partial class AppForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.StartPanel = new System.Windows.Forms.Panel();
            this.CloseAppStart = new BWCMM.MZButtonWindows();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.CloseAppLogIn = new BWCMM.MZButtonWindows();
            this.BackButtonLogin = new System.Windows.Forms.Button();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.CloseAppRegister = new BWCMM.MZButtonWindows();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.PasswordInputRegister = new System.Windows.Forms.TextBox();
            this.MailInputRegister = new System.Windows.Forms.TextBox();
            this.UsernameInputRegister = new System.Windows.Forms.TextBox();
            this.LastNameInputRegister = new System.Windows.Forms.TextBox();
            this.nameInputRegister = new System.Windows.Forms.TextBox();
            this.PasswordLabelRegister = new System.Windows.Forms.Label();
            this.MailLabelRegister = new System.Windows.Forms.Label();
            this.UserLabelRegister = new System.Windows.Forms.Label();
            this.LastNameLabelRegister = new System.Windows.Forms.Label();
            this.NameLabelRegister = new System.Windows.Forms.Label();
            this.RegistrateLabel = new System.Windows.Forms.Label();
            this.BackRegisterButton = new System.Windows.Forms.Button();
            this.SOPTLOGO = new System.Windows.Forms.Label();
            this.FLIXLOGO = new System.Windows.Forms.Label();
            this.IniciarSeccionStartAppButton = new System.Windows.Forms.Button();
            this.RegistrateButton = new System.Windows.Forms.Button();
            this.UsernameLabelLogin = new System.Windows.Forms.Label();
            this.PasswordUsernameLabelLogin = new System.Windows.Forms.Label();
            this.IniciarseccionLabelLogin = new System.Windows.Forms.Label();
            this.UsernameInPutLogin = new System.Windows.Forms.TextBox();
            this.PasswordInPutLogin = new System.Windows.Forms.TextBox();
            this.InicioLoginButton = new System.Windows.Forms.Button();
            this.SaveLogin = new System.Windows.Forms.CheckBox();
            this.loginViewInvalidCredentialsAlert = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SideMainPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SubSerchPanel = new System.Windows.Forms.Panel();
            this.UserSeachButton = new System.Windows.Forms.Button();
            this.ArtistSeachButton = new System.Windows.Forms.Button();
            this.MediaSeachButton = new System.Windows.Forms.Button();
            this.PlaylistButton = new System.Windows.Forms.Button();
            this.SubPlaylistPanel = new System.Windows.Forms.Panel();
            this.SongButton = new System.Windows.Forms.Button();
            this.VideoButton = new System.Windows.Forms.Button();
            this.ArtistModeButton = new System.Windows.Forms.Button();
            this.SubArtistPanel = new System.Windows.Forms.Panel();
            this.UploadSongButton = new System.Windows.Forms.Button();
            this.UploadVideoButton = new System.Windows.Forms.Button();
            this.AlbumButton = new System.Windows.Forms.Button();
            this.Profilebutton = new System.Windows.Forms.Button();
            this.SubProfilePanel = new System.Windows.Forms.Panel();
            this.EditeProfilebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ReproduccionPanel = new System.Windows.Forms.Panel();
            this.MainScreenPanel = new System.Windows.Forms.Panel();
            this.MinimizarButton = new BWCMM.MZButtonWindows();
            this.MaximizarButton = new BWCMM.MZButtonWindows();
            this.CloseButtonMain = new BWCMM.MZButtonWindows();
            this.StartPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SideMainPanel.SuspendLayout();
            this.SubSerchPanel.SuspendLayout();
            this.SubPlaylistPanel.SuspendLayout();
            this.SubArtistPanel.SuspendLayout();
            this.SubProfilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartPanel.Controls.Add(this.MainPanel);
            this.StartPanel.Controls.Add(this.LoginPanel);
            this.StartPanel.Controls.Add(this.RegisterPanel);
            this.StartPanel.Controls.Add(this.SOPTLOGO);
            this.StartPanel.Controls.Add(this.FLIXLOGO);
            this.StartPanel.Controls.Add(this.IniciarSeccionStartAppButton);
            this.StartPanel.Controls.Add(this.RegistrateButton);
            this.StartPanel.Controls.Add(this.CloseAppStart);
            this.StartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartPanel.Location = new System.Drawing.Point(0, 0);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(1024, 768);
            this.StartPanel.TabIndex = 0;
            this.StartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StartPanel_Paint);
            // 
            // CloseAppStart
            // 
            this.CloseAppStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseAppStart.BackgroundImage")));
            this.CloseAppStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseAppStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAppStart.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.CloseAppStart.Location = new System.Drawing.Point(984, 0);
            this.CloseAppStart.Name = "CloseAppStart";
            this.CloseAppStart.ParentControl = this;
            this.CloseAppStart.Size = new System.Drawing.Size(40, 24);
            this.CloseAppStart.TabIndex = 14;
            this.CloseAppStart.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.CloseAppLogIn);
            this.LoginPanel.Controls.Add(this.loginViewInvalidCredentialsAlert);
            this.LoginPanel.Controls.Add(this.SaveLogin);
            this.LoginPanel.Controls.Add(this.BackButtonLogin);
            this.LoginPanel.Controls.Add(this.InicioLoginButton);
            this.LoginPanel.Controls.Add(this.PasswordInPutLogin);
            this.LoginPanel.Controls.Add(this.UsernameInPutLogin);
            this.LoginPanel.Controls.Add(this.IniciarseccionLabelLogin);
            this.LoginPanel.Controls.Add(this.PasswordUsernameLabelLogin);
            this.LoginPanel.Controls.Add(this.UsernameLabelLogin);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1024, 768);
            this.LoginPanel.TabIndex = 14;
            this.LoginPanel.Visible = false;
            // 
            // CloseAppLogIn
            // 
            this.CloseAppLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseAppLogIn.BackgroundImage")));
            this.CloseAppLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseAppLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAppLogIn.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.CloseAppLogIn.Location = new System.Drawing.Point(984, 0);
            this.CloseAppLogIn.Name = "CloseAppLogIn";
            this.CloseAppLogIn.ParentControl = this;
            this.CloseAppLogIn.Size = new System.Drawing.Size(40, 24);
            this.CloseAppLogIn.TabIndex = 9;
            this.CloseAppLogIn.TipoButton = BWCMM.MZButtonWindows.ModeButton.Null;
            // 
            // BackButtonLogin
            // 
            this.BackButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButtonLogin.ForeColor = System.Drawing.Color.Red;
            this.BackButtonLogin.Location = new System.Drawing.Point(12, 12);
            this.BackButtonLogin.Name = "BackButtonLogin";
            this.BackButtonLogin.Size = new System.Drawing.Size(50, 50);
            this.BackButtonLogin.TabIndex = 6;
            this.BackButtonLogin.Text = "<";
            this.BackButtonLogin.UseVisualStyleBackColor = true;
            this.BackButtonLogin.Click += new System.EventHandler(this.BackButtonLogin_Click);
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegisterPanel.Controls.Add(this.CloseAppRegister);
            this.RegisterPanel.Controls.Add(this.Registerbutton);
            this.RegisterPanel.Controls.Add(this.PasswordInputRegister);
            this.RegisterPanel.Controls.Add(this.MailInputRegister);
            this.RegisterPanel.Controls.Add(this.UsernameInputRegister);
            this.RegisterPanel.Controls.Add(this.LastNameInputRegister);
            this.RegisterPanel.Controls.Add(this.nameInputRegister);
            this.RegisterPanel.Controls.Add(this.PasswordLabelRegister);
            this.RegisterPanel.Controls.Add(this.MailLabelRegister);
            this.RegisterPanel.Controls.Add(this.UserLabelRegister);
            this.RegisterPanel.Controls.Add(this.LastNameLabelRegister);
            this.RegisterPanel.Controls.Add(this.NameLabelRegister);
            this.RegisterPanel.Controls.Add(this.RegistrateLabel);
            this.RegisterPanel.Controls.Add(this.BackRegisterButton);
            this.RegisterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(1024, 768);
            this.RegisterPanel.TabIndex = 1;
            this.RegisterPanel.Visible = false;
            // 
            // CloseAppRegister
            // 
            this.CloseAppRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseAppRegister.BackgroundImage")));
            this.CloseAppRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseAppRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAppRegister.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.CloseAppRegister.Location = new System.Drawing.Point(984, 0);
            this.CloseAppRegister.Name = "CloseAppRegister";
            this.CloseAppRegister.ParentControl = this;
            this.CloseAppRegister.Size = new System.Drawing.Size(40, 24);
            this.CloseAppRegister.TabIndex = 16;
            this.CloseAppRegister.TipoButton = BWCMM.MZButtonWindows.ModeButton.Null;
            // 
            // Registerbutton
            // 
            this.Registerbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registerbutton.ForeColor = System.Drawing.Color.Yellow;
            this.Registerbutton.Location = new System.Drawing.Point(501, 550);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(160, 47);
            this.Registerbutton.TabIndex = 12;
            this.Registerbutton.Text = "Registrate";
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // PasswordInputRegister
            // 
            this.PasswordInputRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordInputRegister.BackColor = System.Drawing.SystemColors.Menu;
            this.PasswordInputRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInputRegister.Location = new System.Drawing.Point(546, 489);
            this.PasswordInputRegister.Name = "PasswordInputRegister";
            this.PasswordInputRegister.PasswordChar = '*';
            this.PasswordInputRegister.Size = new System.Drawing.Size(206, 23);
            this.PasswordInputRegister.TabIndex = 11;
            // 
            // MailInputRegister
            // 
            this.MailInputRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailInputRegister.BackColor = System.Drawing.SystemColors.Menu;
            this.MailInputRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MailInputRegister.Location = new System.Drawing.Point(546, 437);
            this.MailInputRegister.Name = "MailInputRegister";
            this.MailInputRegister.Size = new System.Drawing.Size(206, 23);
            this.MailInputRegister.TabIndex = 10;
            // 
            // UsernameInputRegister
            // 
            this.UsernameInputRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameInputRegister.BackColor = System.Drawing.SystemColors.Menu;
            this.UsernameInputRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameInputRegister.Location = new System.Drawing.Point(546, 382);
            this.UsernameInputRegister.Name = "UsernameInputRegister";
            this.UsernameInputRegister.Size = new System.Drawing.Size(206, 23);
            this.UsernameInputRegister.TabIndex = 9;
            // 
            // LastNameInputRegister
            // 
            this.LastNameInputRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameInputRegister.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LastNameInputRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameInputRegister.Location = new System.Drawing.Point(546, 328);
            this.LastNameInputRegister.Name = "LastNameInputRegister";
            this.LastNameInputRegister.Size = new System.Drawing.Size(206, 23);
            this.LastNameInputRegister.TabIndex = 8;
            // 
            // nameInputRegister
            // 
            this.nameInputRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameInputRegister.BackColor = System.Drawing.SystemColors.Menu;
            this.nameInputRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInputRegister.Location = new System.Drawing.Point(546, 274);
            this.nameInputRegister.Name = "nameInputRegister";
            this.nameInputRegister.Size = new System.Drawing.Size(206, 23);
            this.nameInputRegister.TabIndex = 7;
            // 
            // PasswordLabelRegister
            // 
            this.PasswordLabelRegister.ForeColor = System.Drawing.Color.ForestGreen;
            this.PasswordLabelRegister.Location = new System.Drawing.Point(344, 489);
            this.PasswordLabelRegister.Name = "PasswordLabelRegister";
            this.PasswordLabelRegister.Size = new System.Drawing.Size(171, 38);
            this.PasswordLabelRegister.TabIndex = 6;
            this.PasswordLabelRegister.Text = "Contraseña";
            // 
            // MailLabelRegister
            // 
            this.MailLabelRegister.ForeColor = System.Drawing.Color.ForestGreen;
            this.MailLabelRegister.Location = new System.Drawing.Point(347, 437);
            this.MailLabelRegister.Name = "MailLabelRegister";
            this.MailLabelRegister.Size = new System.Drawing.Size(72, 38);
            this.MailLabelRegister.TabIndex = 5;
            this.MailLabelRegister.Text = "Mail";
            // 
            // UserLabelRegister
            // 
            this.UserLabelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabelRegister.ForeColor = System.Drawing.Color.ForestGreen;
            this.UserLabelRegister.Location = new System.Drawing.Point(345, 384);
            this.UserLabelRegister.Name = "UserLabelRegister";
            this.UserLabelRegister.Size = new System.Drawing.Size(108, 34);
            this.UserLabelRegister.TabIndex = 4;
            this.UserLabelRegister.Text = "Usuario";
            // 
            // LastNameLabelRegister
            // 
            this.LastNameLabelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabelRegister.ForeColor = System.Drawing.Color.ForestGreen;
            this.LastNameLabelRegister.Location = new System.Drawing.Point(348, 330);
            this.LastNameLabelRegister.Name = "LastNameLabelRegister";
            this.LastNameLabelRegister.Size = new System.Drawing.Size(111, 34);
            this.LastNameLabelRegister.TabIndex = 3;
            this.LastNameLabelRegister.Text = "Apellido";
            // 
            // NameLabelRegister
            // 
            this.NameLabelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabelRegister.ForeColor = System.Drawing.Color.ForestGreen;
            this.NameLabelRegister.Location = new System.Drawing.Point(345, 276);
            this.NameLabelRegister.Name = "NameLabelRegister";
            this.NameLabelRegister.Size = new System.Drawing.Size(110, 34);
            this.NameLabelRegister.TabIndex = 2;
            this.NameLabelRegister.Text = "Nombre";
            // 
            // RegistrateLabel
            // 
            this.RegistrateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrateLabel.ForeColor = System.Drawing.Color.Green;
            this.RegistrateLabel.Location = new System.Drawing.Point(394, 158);
            this.RegistrateLabel.Name = "RegistrateLabel";
            this.RegistrateLabel.Size = new System.Drawing.Size(311, 53);
            this.RegistrateLabel.TabIndex = 0;
            this.RegistrateLabel.Text = "Registrate Gratis";
            this.RegistrateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackRegisterButton
            // 
            this.BackRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackRegisterButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.BackRegisterButton.Location = new System.Drawing.Point(12, 12);
            this.BackRegisterButton.Name = "BackRegisterButton";
            this.BackRegisterButton.Size = new System.Drawing.Size(50, 50);
            this.BackRegisterButton.TabIndex = 13;
            this.BackRegisterButton.Text = "<";
            this.BackRegisterButton.UseVisualStyleBackColor = true;
            this.BackRegisterButton.Click += new System.EventHandler(this.BackRegisterButton_Click);
            // 
            // SOPTLOGO
            // 
            this.SOPTLOGO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SOPTLOGO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SOPTLOGO.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOPTLOGO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SOPTLOGO.Location = new System.Drawing.Point(298, 157);
            this.SOPTLOGO.Name = "SOPTLOGO";
            this.SOPTLOGO.Size = new System.Drawing.Size(234, 89);
            this.SOPTLOGO.TabIndex = 0;
            this.SOPTLOGO.Text = "SPOT";
            this.SOPTLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SOPTLOGO.Click += new System.EventHandler(this.SOPTLOGO_Click);
            // 
            // FLIXLOGO
            // 
            this.FLIXLOGO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLIXLOGO.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLIXLOGO.ForeColor = System.Drawing.Color.Red;
            this.FLIXLOGO.Location = new System.Drawing.Point(538, 238);
            this.FLIXLOGO.Name = "FLIXLOGO";
            this.FLIXLOGO.Size = new System.Drawing.Size(224, 109);
            this.FLIXLOGO.TabIndex = 1;
            this.FLIXLOGO.Text = "FLIX";
            this.FLIXLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IniciarSeccionStartAppButton
            // 
            this.IniciarSeccionStartAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IniciarSeccionStartAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IniciarSeccionStartAppButton.ForeColor = System.Drawing.Color.Red;
            this.IniciarSeccionStartAppButton.Location = new System.Drawing.Point(450, 374);
            this.IniciarSeccionStartAppButton.Name = "IniciarSeccionStartAppButton";
            this.IniciarSeccionStartAppButton.Size = new System.Drawing.Size(162, 77);
            this.IniciarSeccionStartAppButton.TabIndex = 15;
            this.IniciarSeccionStartAppButton.Text = "Inicar Seccion";
            this.IniciarSeccionStartAppButton.UseVisualStyleBackColor = true;
            this.IniciarSeccionStartAppButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrateButton
            // 
            this.RegistrateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegistrateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrateButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.RegistrateButton.Location = new System.Drawing.Point(450, 457);
            this.RegistrateButton.Name = "RegistrateButton";
            this.RegistrateButton.Size = new System.Drawing.Size(162, 77);
            this.RegistrateButton.TabIndex = 1;
            this.RegistrateButton.Text = "Registrate";
            this.RegistrateButton.UseVisualStyleBackColor = true;
            this.RegistrateButton.Click += new System.EventHandler(this.RegistrateButton_Click);
            // 
            // UsernameLabelLogin
            // 
            this.UsernameLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabelLogin.ForeColor = System.Drawing.Color.Red;
            this.UsernameLabelLogin.Location = new System.Drawing.Point(301, 318);
            this.UsernameLabelLogin.Name = "UsernameLabelLogin";
            this.UsernameLabelLogin.Size = new System.Drawing.Size(102, 33);
            this.UsernameLabelLogin.TabIndex = 0;
            this.UsernameLabelLogin.Text = "Usuario";
            this.UsernameLabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordUsernameLabelLogin
            // 
            this.PasswordUsernameLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordUsernameLabelLogin.ForeColor = System.Drawing.Color.Red;
            this.PasswordUsernameLabelLogin.Location = new System.Drawing.Point(266, 397);
            this.PasswordUsernameLabelLogin.Name = "PasswordUsernameLabelLogin";
            this.PasswordUsernameLabelLogin.Size = new System.Drawing.Size(137, 45);
            this.PasswordUsernameLabelLogin.TabIndex = 1;
            this.PasswordUsernameLabelLogin.Text = "Contraseña";
            this.PasswordUsernameLabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IniciarseccionLabelLogin
            // 
            this.IniciarseccionLabelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IniciarseccionLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarseccionLabelLogin.ForeColor = System.Drawing.Color.Red;
            this.IniciarseccionLabelLogin.Location = new System.Drawing.Point(416, 176);
            this.IniciarseccionLabelLogin.Name = "IniciarseccionLabelLogin";
            this.IniciarseccionLabelLogin.Size = new System.Drawing.Size(281, 70);
            this.IniciarseccionLabelLogin.TabIndex = 2;
            this.IniciarseccionLabelLogin.Text = "Inicar Seccion";
            this.IniciarseccionLabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IniciarseccionLabelLogin.Click += new System.EventHandler(this.IniciarseccionLabelLogin_Click_1);
            // 
            // UsernameInPutLogin
            // 
            this.UsernameInPutLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameInPutLogin.BackColor = System.Drawing.SystemColors.Menu;
            this.UsernameInPutLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameInPutLogin.Location = new System.Drawing.Point(416, 326);
            this.UsernameInPutLogin.Name = "UsernameInPutLogin";
            this.UsernameInPutLogin.Size = new System.Drawing.Size(281, 19);
            this.UsernameInPutLogin.TabIndex = 3;
            // 
            // PasswordInPutLogin
            // 
            this.PasswordInPutLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordInPutLogin.BackColor = System.Drawing.SystemColors.Menu;
            this.PasswordInPutLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInPutLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordInPutLogin.Location = new System.Drawing.Point(416, 411);
            this.PasswordInPutLogin.Name = "PasswordInPutLogin";
            this.PasswordInPutLogin.PasswordChar = '*';
            this.PasswordInPutLogin.Size = new System.Drawing.Size(281, 19);
            this.PasswordInPutLogin.TabIndex = 4;
            // 
            // InicioLoginButton
            // 
            this.InicioLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InicioLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InicioLoginButton.ForeColor = System.Drawing.Color.DarkRed;
            this.InicioLoginButton.Location = new System.Drawing.Point(440, 591);
            this.InicioLoginButton.Name = "InicioLoginButton";
            this.InicioLoginButton.Size = new System.Drawing.Size(224, 50);
            this.InicioLoginButton.TabIndex = 5;
            this.InicioLoginButton.Text = "Iniciar Seccion";
            this.InicioLoginButton.UseVisualStyleBackColor = true;
            this.InicioLoginButton.Click += new System.EventHandler(this.InicioLoginButton_Click);
            // 
            // SaveLogin
            // 
            this.SaveLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLogin.ForeColor = System.Drawing.Color.Red;
            this.SaveLogin.Location = new System.Drawing.Point(416, 518);
            this.SaveLogin.Name = "SaveLogin";
            this.SaveLogin.Size = new System.Drawing.Size(281, 28);
            this.SaveLogin.TabIndex = 7;
            this.SaveLogin.Text = "Mantener Inicio de seccion";
            this.SaveLogin.UseVisualStyleBackColor = true;
            // 
            // loginViewInvalidCredentialsAlert
            // 
            this.loginViewInvalidCredentialsAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginViewInvalidCredentialsAlert.BackColor = System.Drawing.Color.Black;
            this.loginViewInvalidCredentialsAlert.ForeColor = System.Drawing.Color.Red;
            this.loginViewInvalidCredentialsAlert.Location = new System.Drawing.Point(412, 489);
            this.loginViewInvalidCredentialsAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginViewInvalidCredentialsAlert.Name = "loginViewInvalidCredentialsAlert";
            this.loginViewInvalidCredentialsAlert.Size = new System.Drawing.Size(257, 20);
            this.loginViewInvalidCredentialsAlert.TabIndex = 8;
            this.loginViewInvalidCredentialsAlert.Text = "**Credencial de usuario invalida";
            this.loginViewInvalidCredentialsAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginViewInvalidCredentialsAlert.Visible = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainPanel.Controls.Add(this.CloseButtonMain);
            this.MainPanel.Controls.Add(this.MaximizarButton);
            this.MainPanel.Controls.Add(this.MinimizarButton);
            this.MainPanel.Controls.Add(this.MainScreenPanel);
            this.MainPanel.Controls.Add(this.ReproduccionPanel);
            this.MainPanel.Controls.Add(this.SideMainPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1024, 768);
            this.MainPanel.TabIndex = 10;
            this.MainPanel.Visible = false;
            // 
            // SideMainPanel
            // 
            this.SideMainPanel.AutoScroll = true;
            this.SideMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SideMainPanel.Controls.Add(this.SubProfilePanel);
            this.SideMainPanel.Controls.Add(this.Profilebutton);
            this.SideMainPanel.Controls.Add(this.SubArtistPanel);
            this.SideMainPanel.Controls.Add(this.ArtistModeButton);
            this.SideMainPanel.Controls.Add(this.SubPlaylistPanel);
            this.SideMainPanel.Controls.Add(this.PlaylistButton);
            this.SideMainPanel.Controls.Add(this.SubSerchPanel);
            this.SideMainPanel.Controls.Add(this.SearchButton);
            this.SideMainPanel.Controls.Add(this.LogoPanel);
            this.SideMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMainPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMainPanel.Name = "SideMainPanel";
            this.SideMainPanel.Size = new System.Drawing.Size(300, 768);
            this.SideMainPanel.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(298, 100);
            this.LogoPanel.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchButton.Location = new System.Drawing.Point(0, 100);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.SearchButton.Size = new System.Drawing.Size(298, 45);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Buscar";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SubSerchPanel
            // 
            this.SubSerchPanel.Controls.Add(this.MediaSeachButton);
            this.SubSerchPanel.Controls.Add(this.ArtistSeachButton);
            this.SubSerchPanel.Controls.Add(this.UserSeachButton);
            this.SubSerchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubSerchPanel.Location = new System.Drawing.Point(0, 145);
            this.SubSerchPanel.Name = "SubSerchPanel";
            this.SubSerchPanel.Size = new System.Drawing.Size(298, 120);
            this.SubSerchPanel.TabIndex = 2;
            this.SubSerchPanel.Visible = false;
            // 
            // UserSeachButton
            // 
            this.UserSeachButton.BackColor = System.Drawing.Color.Maroon;
            this.UserSeachButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserSeachButton.FlatAppearance.BorderSize = 0;
            this.UserSeachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSeachButton.Location = new System.Drawing.Point(0, 0);
            this.UserSeachButton.Name = "UserSeachButton";
            this.UserSeachButton.Size = new System.Drawing.Size(298, 40);
            this.UserSeachButton.TabIndex = 0;
            this.UserSeachButton.Text = "Usuario";
            this.UserSeachButton.UseVisualStyleBackColor = false;
            // 
            // ArtistSeachButton
            // 
            this.ArtistSeachButton.BackColor = System.Drawing.Color.Maroon;
            this.ArtistSeachButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ArtistSeachButton.FlatAppearance.BorderSize = 0;
            this.ArtistSeachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtistSeachButton.Location = new System.Drawing.Point(0, 40);
            this.ArtistSeachButton.Name = "ArtistSeachButton";
            this.ArtistSeachButton.Size = new System.Drawing.Size(298, 40);
            this.ArtistSeachButton.TabIndex = 1;
            this.ArtistSeachButton.Text = "Artista";
            this.ArtistSeachButton.UseVisualStyleBackColor = false;
            // 
            // MediaSeachButton
            // 
            this.MediaSeachButton.BackColor = System.Drawing.Color.Maroon;
            this.MediaSeachButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MediaSeachButton.FlatAppearance.BorderSize = 0;
            this.MediaSeachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediaSeachButton.Location = new System.Drawing.Point(0, 80);
            this.MediaSeachButton.Name = "MediaSeachButton";
            this.MediaSeachButton.Size = new System.Drawing.Size(298, 40);
            this.MediaSeachButton.TabIndex = 2;
            this.MediaSeachButton.Text = "Media";
            this.MediaSeachButton.UseVisualStyleBackColor = false;
            // 
            // PlaylistButton
            // 
            this.PlaylistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlaylistButton.Location = new System.Drawing.Point(0, 265);
            this.PlaylistButton.Name = "PlaylistButton";
            this.PlaylistButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.PlaylistButton.Size = new System.Drawing.Size(298, 45);
            this.PlaylistButton.TabIndex = 3;
            this.PlaylistButton.Text = "Playlist";
            this.PlaylistButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlaylistButton.UseVisualStyleBackColor = true;
            this.PlaylistButton.Click += new System.EventHandler(this.PlaylistButton_Click);
            // 
            // SubPlaylistPanel
            // 
            this.SubPlaylistPanel.Controls.Add(this.VideoButton);
            this.SubPlaylistPanel.Controls.Add(this.SongButton);
            this.SubPlaylistPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPlaylistPanel.Location = new System.Drawing.Point(0, 310);
            this.SubPlaylistPanel.Name = "SubPlaylistPanel";
            this.SubPlaylistPanel.Size = new System.Drawing.Size(298, 80);
            this.SubPlaylistPanel.TabIndex = 4;
            this.SubPlaylistPanel.Visible = false;
            // 
            // SongButton
            // 
            this.SongButton.BackColor = System.Drawing.Color.LightCoral;
            this.SongButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SongButton.FlatAppearance.BorderSize = 0;
            this.SongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SongButton.Location = new System.Drawing.Point(0, 0);
            this.SongButton.Name = "SongButton";
            this.SongButton.Size = new System.Drawing.Size(298, 40);
            this.SongButton.TabIndex = 0;
            this.SongButton.Text = "Canciones";
            this.SongButton.UseVisualStyleBackColor = false;
            // 
            // VideoButton
            // 
            this.VideoButton.BackColor = System.Drawing.Color.LightCoral;
            this.VideoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VideoButton.FlatAppearance.BorderSize = 0;
            this.VideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VideoButton.Location = new System.Drawing.Point(0, 40);
            this.VideoButton.Name = "VideoButton";
            this.VideoButton.Size = new System.Drawing.Size(298, 40);
            this.VideoButton.TabIndex = 1;
            this.VideoButton.Text = "Videos";
            this.VideoButton.UseVisualStyleBackColor = false;
            // 
            // ArtistModeButton
            // 
            this.ArtistModeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ArtistModeButton.Location = new System.Drawing.Point(0, 390);
            this.ArtistModeButton.Name = "ArtistModeButton";
            this.ArtistModeButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ArtistModeButton.Size = new System.Drawing.Size(298, 45);
            this.ArtistModeButton.TabIndex = 1;
            this.ArtistModeButton.Text = "ArtistMode";
            this.ArtistModeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArtistModeButton.UseVisualStyleBackColor = true;
            this.ArtistModeButton.Click += new System.EventHandler(this.ArtistModeButton_Click);
            // 
            // SubArtistPanel
            // 
            this.SubArtistPanel.Controls.Add(this.AlbumButton);
            this.SubArtistPanel.Controls.Add(this.UploadVideoButton);
            this.SubArtistPanel.Controls.Add(this.UploadSongButton);
            this.SubArtistPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubArtistPanel.Location = new System.Drawing.Point(0, 435);
            this.SubArtistPanel.Name = "SubArtistPanel";
            this.SubArtistPanel.Size = new System.Drawing.Size(298, 120);
            this.SubArtistPanel.TabIndex = 5;
            this.SubArtistPanel.Visible = false;
            // 
            // UploadSongButton
            // 
            this.UploadSongButton.BackColor = System.Drawing.Color.Yellow;
            this.UploadSongButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UploadSongButton.FlatAppearance.BorderSize = 0;
            this.UploadSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadSongButton.Location = new System.Drawing.Point(0, 0);
            this.UploadSongButton.Name = "UploadSongButton";
            this.UploadSongButton.Size = new System.Drawing.Size(298, 40);
            this.UploadSongButton.TabIndex = 0;
            this.UploadSongButton.Text = "Subir Cancion";
            this.UploadSongButton.UseVisualStyleBackColor = false;
            // 
            // UploadVideoButton
            // 
            this.UploadVideoButton.BackColor = System.Drawing.Color.Yellow;
            this.UploadVideoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UploadVideoButton.FlatAppearance.BorderSize = 0;
            this.UploadVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadVideoButton.Location = new System.Drawing.Point(0, 40);
            this.UploadVideoButton.Name = "UploadVideoButton";
            this.UploadVideoButton.Size = new System.Drawing.Size(298, 40);
            this.UploadVideoButton.TabIndex = 1;
            this.UploadVideoButton.Text = "Subir Video";
            this.UploadVideoButton.UseVisualStyleBackColor = false;
            // 
            // AlbumButton
            // 
            this.AlbumButton.BackColor = System.Drawing.Color.Yellow;
            this.AlbumButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlbumButton.FlatAppearance.BorderSize = 0;
            this.AlbumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumButton.Location = new System.Drawing.Point(0, 80);
            this.AlbumButton.Name = "AlbumButton";
            this.AlbumButton.Size = new System.Drawing.Size(298, 40);
            this.AlbumButton.TabIndex = 2;
            this.AlbumButton.Text = "Album";
            this.AlbumButton.UseVisualStyleBackColor = false;
            // 
            // Profilebutton
            // 
            this.Profilebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profilebutton.Location = new System.Drawing.Point(0, 555);
            this.Profilebutton.Name = "Profilebutton";
            this.Profilebutton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Profilebutton.Size = new System.Drawing.Size(298, 45);
            this.Profilebutton.TabIndex = 6;
            this.Profilebutton.Text = "Perfil";
            this.Profilebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profilebutton.UseVisualStyleBackColor = true;
            this.Profilebutton.Click += new System.EventHandler(this.Profilebutton_Click);
            // 
            // SubProfilePanel
            // 
            this.SubProfilePanel.Controls.Add(this.button1);
            this.SubProfilePanel.Controls.Add(this.EditeProfilebutton);
            this.SubProfilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubProfilePanel.Location = new System.Drawing.Point(0, 600);
            this.SubProfilePanel.Name = "SubProfilePanel";
            this.SubProfilePanel.Size = new System.Drawing.Size(298, 80);
            this.SubProfilePanel.TabIndex = 7;
            this.SubProfilePanel.Visible = false;
            // 
            // EditeProfilebutton
            // 
            this.EditeProfilebutton.BackColor = System.Drawing.Color.Lime;
            this.EditeProfilebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditeProfilebutton.FlatAppearance.BorderSize = 0;
            this.EditeProfilebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditeProfilebutton.Location = new System.Drawing.Point(0, 0);
            this.EditeProfilebutton.Name = "EditeProfilebutton";
            this.EditeProfilebutton.Size = new System.Drawing.Size(298, 40);
            this.EditeProfilebutton.TabIndex = 0;
            this.EditeProfilebutton.Text = "Editar";
            this.EditeProfilebutton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mi Informacion";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ReproduccionPanel
            // 
            this.ReproduccionPanel.BackColor = System.Drawing.Color.Red;
            this.ReproduccionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReproduccionPanel.Location = new System.Drawing.Point(300, 683);
            this.ReproduccionPanel.Name = "ReproduccionPanel";
            this.ReproduccionPanel.Size = new System.Drawing.Size(724, 85);
            this.ReproduccionPanel.TabIndex = 1;
            // 
            // MainScreenPanel
            // 
            this.MainScreenPanel.BackColor = System.Drawing.Color.Teal;
            this.MainScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainScreenPanel.Location = new System.Drawing.Point(300, 0);
            this.MainScreenPanel.Name = "MainScreenPanel";
            this.MainScreenPanel.Size = new System.Drawing.Size(724, 683);
            this.MainScreenPanel.TabIndex = 2;
            // 
            // MinimizarButton
            // 
            this.MinimizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimizarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizarButton.BackgroundImage")));
            this.MinimizarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarButton.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.MinimizarButton.Location = new System.Drawing.Point(904, 0);
            this.MinimizarButton.Name = "MinimizarButton";
            this.MinimizarButton.ParentControl = this;
            this.MinimizarButton.Size = new System.Drawing.Size(40, 24);
            this.MinimizarButton.TabIndex = 4;
            this.MinimizarButton.TipoButton = BWCMM.MZButtonWindows.ModeButton.Minimize;
            // 
            // MaximizarButton
            // 
            this.MaximizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizarButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaximizarButton.BackgroundImage")));
            this.MaximizarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MaximizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizarButton.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.MaximizarButton.Location = new System.Drawing.Point(944, 0);
            this.MaximizarButton.Name = "MaximizarButton";
            this.MaximizarButton.ParentControl = this;
            this.MaximizarButton.Size = new System.Drawing.Size(40, 24);
            this.MaximizarButton.TabIndex = 5;
            this.MaximizarButton.TipoButton = BWCMM.MZButtonWindows.ModeButton.Maximize;
            // 
            // CloseButtonMain
            // 
            this.CloseButtonMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButtonMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButtonMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButtonMain.BackgroundImage")));
            this.CloseButtonMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButtonMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButtonMain.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows;
            this.CloseButtonMain.Location = new System.Drawing.Point(984, 0);
            this.CloseButtonMain.Name = "CloseButtonMain";
            this.CloseButtonMain.ParentControl = this;
            this.CloseButtonMain.Size = new System.Drawing.Size(40, 24);
            this.CloseButtonMain.TabIndex = 3;
            this.CloseButtonMain.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.StartPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "AppForm";
            this.Text = " ";
            this.StartPanel.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.SideMainPanel.ResumeLayout(false);
            this.SubSerchPanel.ResumeLayout(false);
            this.SubPlaylistPanel.ResumeLayout(false);
            this.SubArtistPanel.ResumeLayout(false);
            this.SubProfilePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Label FLIXLOGO;
        private System.Windows.Forms.Label SOPTLOGO;
        private System.Windows.Forms.Button RegistrateButton;
        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Label LastNameLabelRegister;
        private System.Windows.Forms.Label NameLabelRegister;
        private System.Windows.Forms.Label RegistrateLabel;
        private System.Windows.Forms.Label PasswordLabelRegister;
        private System.Windows.Forms.Label MailLabelRegister;
        private System.Windows.Forms.Label UserLabelRegister;
        private System.Windows.Forms.TextBox UsernameInputRegister;
        private System.Windows.Forms.TextBox LastNameInputRegister;
        private System.Windows.Forms.TextBox nameInputRegister;
        private System.Windows.Forms.TextBox PasswordInputRegister;
        private System.Windows.Forms.TextBox MailInputRegister;
        private System.Windows.Forms.Button BackRegisterButton;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Button IniciarSeccionStartAppButton;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button BackButtonLogin;
        private BWCMM.MZButtonWindows CloseAppStart;
        private BWCMM.MZButtonWindows CloseAppLogIn;
        private BWCMM.MZButtonWindows CloseAppRegister;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SideMainPanel;
        private System.Windows.Forms.Panel SubProfilePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EditeProfilebutton;
        private System.Windows.Forms.Button Profilebutton;
        private System.Windows.Forms.Panel SubArtistPanel;
        private System.Windows.Forms.Button AlbumButton;
        private System.Windows.Forms.Button UploadVideoButton;
        private System.Windows.Forms.Button UploadSongButton;
        private System.Windows.Forms.Button ArtistModeButton;
        private System.Windows.Forms.Panel SubPlaylistPanel;
        private System.Windows.Forms.Button VideoButton;
        private System.Windows.Forms.Button SongButton;
        private System.Windows.Forms.Button PlaylistButton;
        private System.Windows.Forms.Panel SubSerchPanel;
        private System.Windows.Forms.Button MediaSeachButton;
        private System.Windows.Forms.Button ArtistSeachButton;
        private System.Windows.Forms.Button UserSeachButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label loginViewInvalidCredentialsAlert;
        private System.Windows.Forms.CheckBox SaveLogin;
        private System.Windows.Forms.Button InicioLoginButton;
        private System.Windows.Forms.TextBox PasswordInPutLogin;
        private System.Windows.Forms.TextBox UsernameInPutLogin;
        private System.Windows.Forms.Label IniciarseccionLabelLogin;
        private System.Windows.Forms.Label PasswordUsernameLabelLogin;
        private System.Windows.Forms.Label UsernameLabelLogin;
        private System.Windows.Forms.Panel MainScreenPanel;
        private System.Windows.Forms.Panel ReproduccionPanel;
        private BWCMM.MZButtonWindows CloseButtonMain;
        private BWCMM.MZButtonWindows MaximizarButton;
        private BWCMM.MZButtonWindows MinimizarButton;
    }
}

