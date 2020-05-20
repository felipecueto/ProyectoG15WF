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
            this.StartPanel = new System.Windows.Forms.Panel();
            this.EXITbutton = new System.Windows.Forms.Button();
            this.RegisterPanel = new System.Windows.Forms.Panel();
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.loginViewInvalidCredentialsAlert = new System.Windows.Forms.Label();
            this.SaveLogin = new System.Windows.Forms.CheckBox();
            this.BackButtonLogin = new System.Windows.Forms.Button();
            this.InicioLoginButton = new System.Windows.Forms.Button();
            this.PasswordInPutLogin = new System.Windows.Forms.TextBox();
            this.UsernameInPutLogin = new System.Windows.Forms.TextBox();
            this.IniciarseccionLabelLogin = new System.Windows.Forms.Label();
            this.PasswordUsernameLabelLogin = new System.Windows.Forms.Label();
            this.UsernameLabelLogin = new System.Windows.Forms.Label();
            this.SOPTLOGO = new System.Windows.Forms.Label();
            this.FLIXLOGO = new System.Windows.Forms.Label();
            this.IniciarSeccionStartAppButton = new System.Windows.Forms.Button();
            this.RegistrateButton = new System.Windows.Forms.Button();
            this.StartPanel.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartPanel.Controls.Add(this.RegisterPanel);
            this.StartPanel.Controls.Add(this.LoginPanel);
            this.StartPanel.Controls.Add(this.SOPTLOGO);
            this.StartPanel.Controls.Add(this.FLIXLOGO);
            this.StartPanel.Controls.Add(this.IniciarSeccionStartAppButton);
            this.StartPanel.Controls.Add(this.RegistrateButton);
            this.StartPanel.Controls.Add(this.EXITbutton);
            this.StartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartPanel.Location = new System.Drawing.Point(0, 0);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(1002, 712);
            this.StartPanel.TabIndex = 0;
            this.StartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StartPanel_Paint);
            // 
            // EXITbutton
            // 
            this.EXITbutton.AutoSize = true;
            this.EXITbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EXITbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EXITbutton.ForeColor = System.Drawing.Color.Red;
            this.EXITbutton.Location = new System.Drawing.Point(0, 0);
            this.EXITbutton.Name = "EXITbutton";
            this.EXITbutton.Size = new System.Drawing.Size(30, 30);
            this.EXITbutton.TabIndex = 2;
            this.EXITbutton.Text = "X";
            this.EXITbutton.UseVisualStyleBackColor = true;
            this.EXITbutton.Click += new System.EventHandler(this.EXITbutton_Click);
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.RegisterPanel.Size = new System.Drawing.Size(1002, 712);
            this.RegisterPanel.TabIndex = 1;
            this.RegisterPanel.Visible = false;
            // 
            // Registerbutton
            // 
            this.Registerbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registerbutton.ForeColor = System.Drawing.Color.Yellow;
            this.Registerbutton.Location = new System.Drawing.Point(440, 558);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(138, 47);
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
            this.PasswordInputRegister.Size = new System.Drawing.Size(184, 23);
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
            this.MailInputRegister.Size = new System.Drawing.Size(184, 23);
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
            this.UsernameInputRegister.Size = new System.Drawing.Size(184, 23);
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
            this.LastNameInputRegister.Size = new System.Drawing.Size(184, 23);
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
            this.nameInputRegister.Size = new System.Drawing.Size(184, 23);
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
            this.RegistrateLabel.Location = new System.Drawing.Point(433, 125);
            this.RegistrateLabel.Name = "RegistrateLabel";
            this.RegistrateLabel.Size = new System.Drawing.Size(289, 53);
            this.RegistrateLabel.TabIndex = 0;
            this.RegistrateLabel.Text = "Registrate Gratis";
            this.RegistrateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackRegisterButton
            // 
            this.BackRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackRegisterButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.BackRegisterButton.Location = new System.Drawing.Point(0, 3);
            this.BackRegisterButton.Name = "BackRegisterButton";
            this.BackRegisterButton.Size = new System.Drawing.Size(38, 32);
            this.BackRegisterButton.TabIndex = 13;
            this.BackRegisterButton.Text = "<";
            this.BackRegisterButton.UseVisualStyleBackColor = true;
            this.BackRegisterButton.Click += new System.EventHandler(this.BackRegisterButton_Click);
            // 
            // LoginPanel
            // 
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
            this.LoginPanel.Size = new System.Drawing.Size(1002, 712);
            this.LoginPanel.TabIndex = 14;
            this.LoginPanel.Visible = false;
            // 
            // loginViewInvalidCredentialsAlert
            // 
            this.loginViewInvalidCredentialsAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginViewInvalidCredentialsAlert.BackColor = System.Drawing.Color.Black;
            this.loginViewInvalidCredentialsAlert.ForeColor = System.Drawing.Color.Red;
            this.loginViewInvalidCredentialsAlert.Location = new System.Drawing.Point(469, 412);
            this.loginViewInvalidCredentialsAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginViewInvalidCredentialsAlert.Name = "loginViewInvalidCredentialsAlert";
            this.loginViewInvalidCredentialsAlert.Size = new System.Drawing.Size(235, 20);
            this.loginViewInvalidCredentialsAlert.TabIndex = 8;
            this.loginViewInvalidCredentialsAlert.Text = "**Credencial de usuario invalida";
            this.loginViewInvalidCredentialsAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginViewInvalidCredentialsAlert.Visible = false;
            // 
            // SaveLogin
            // 
            this.SaveLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLogin.ForeColor = System.Drawing.Color.Red;
            this.SaveLogin.Location = new System.Drawing.Point(473, 447);
            this.SaveLogin.Name = "SaveLogin";
            this.SaveLogin.Size = new System.Drawing.Size(259, 28);
            this.SaveLogin.TabIndex = 7;
            this.SaveLogin.Text = "Mantener Inicio de seccion";
            this.SaveLogin.UseVisualStyleBackColor = true;
            // 
            // BackButtonLogin
            // 
            this.BackButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButtonLogin.ForeColor = System.Drawing.Color.Red;
            this.BackButtonLogin.Location = new System.Drawing.Point(10, 12);
            this.BackButtonLogin.Name = "BackButtonLogin";
            this.BackButtonLogin.Size = new System.Drawing.Size(56, 43);
            this.BackButtonLogin.TabIndex = 6;
            this.BackButtonLogin.Text = "<";
            this.BackButtonLogin.UseVisualStyleBackColor = true;
            this.BackButtonLogin.Click += new System.EventHandler(this.BackButtonLogin_Click);
            // 
            // InicioLoginButton
            // 
            this.InicioLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InicioLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InicioLoginButton.ForeColor = System.Drawing.Color.DarkRed;
            this.InicioLoginButton.Location = new System.Drawing.Point(473, 499);
            this.InicioLoginButton.Name = "InicioLoginButton";
            this.InicioLoginButton.Size = new System.Drawing.Size(202, 50);
            this.InicioLoginButton.TabIndex = 5;
            this.InicioLoginButton.Text = "Iniciar Seccion";
            this.InicioLoginButton.UseVisualStyleBackColor = true;
            this.InicioLoginButton.Click += new System.EventHandler(this.InicioLoginButton_Click);
            // 
            // PasswordInPutLogin
            // 
            this.PasswordInPutLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordInPutLogin.BackColor = System.Drawing.SystemColors.Menu;
            this.PasswordInPutLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInPutLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordInPutLogin.Location = new System.Drawing.Point(473, 376);
            this.PasswordInPutLogin.Name = "PasswordInPutLogin";
            this.PasswordInPutLogin.PasswordChar = '*';
            this.PasswordInPutLogin.Size = new System.Drawing.Size(259, 19);
            this.PasswordInPutLogin.TabIndex = 4;
            // 
            // UsernameInPutLogin
            // 
            this.UsernameInPutLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameInPutLogin.BackColor = System.Drawing.SystemColors.Menu;
            this.UsernameInPutLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameInPutLogin.Location = new System.Drawing.Point(473, 286);
            this.UsernameInPutLogin.Name = "UsernameInPutLogin";
            this.UsernameInPutLogin.Size = new System.Drawing.Size(259, 19);
            this.UsernameInPutLogin.TabIndex = 3;
            // 
            // IniciarseccionLabelLogin
            // 
            this.IniciarseccionLabelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IniciarseccionLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarseccionLabelLogin.ForeColor = System.Drawing.Color.Red;
            this.IniciarseccionLabelLogin.Location = new System.Drawing.Point(335, 136);
            this.IniciarseccionLabelLogin.Name = "IniciarseccionLabelLogin";
            this.IniciarseccionLabelLogin.Size = new System.Drawing.Size(397, 70);
            this.IniciarseccionLabelLogin.TabIndex = 2;
            this.IniciarseccionLabelLogin.Text = "Inicar Seccion";
            this.IniciarseccionLabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IniciarseccionLabelLogin.Click += new System.EventHandler(this.IniciarseccionLabelLogin_Click_1);
            // 
            // PasswordUsernameLabelLogin
            // 
            this.PasswordUsernameLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordUsernameLabelLogin.ForeColor = System.Drawing.Color.Red;
            this.PasswordUsernameLabelLogin.Location = new System.Drawing.Point(330, 362);
            this.PasswordUsernameLabelLogin.Name = "PasswordUsernameLabelLogin";
            this.PasswordUsernameLabelLogin.Size = new System.Drawing.Size(137, 45);
            this.PasswordUsernameLabelLogin.TabIndex = 1;
            this.PasswordUsernameLabelLogin.Text = "Contraseña";
            this.PasswordUsernameLabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameLabelLogin
            // 
            this.UsernameLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabelLogin.ForeColor = System.Drawing.Color.Red;
            this.UsernameLabelLogin.Location = new System.Drawing.Point(330, 278);
            this.UsernameLabelLogin.Name = "UsernameLabelLogin";
            this.UsernameLabelLogin.Size = new System.Drawing.Size(102, 33);
            this.UsernameLabelLogin.TabIndex = 0;
            this.UsernameLabelLogin.Text = "Usuario";
            this.UsernameLabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SOPTLOGO
            // 
            this.SOPTLOGO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SOPTLOGO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SOPTLOGO.Font = new System.Drawing.Font("Castellar", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOPTLOGO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SOPTLOGO.Location = new System.Drawing.Point(358, 158);
            this.SOPTLOGO.Name = "SOPTLOGO";
            this.SOPTLOGO.Size = new System.Drawing.Size(128, 48);
            this.SOPTLOGO.TabIndex = 0;
            this.SOPTLOGO.Text = "SPOT";
            this.SOPTLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SOPTLOGO.Click += new System.EventHandler(this.SOPTLOGO_Click);
            // 
            // FLIXLOGO
            // 
            this.FLIXLOGO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLIXLOGO.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLIXLOGO.ForeColor = System.Drawing.Color.Red;
            this.FLIXLOGO.Location = new System.Drawing.Point(538, 226);
            this.FLIXLOGO.Name = "FLIXLOGO";
            this.FLIXLOGO.Size = new System.Drawing.Size(101, 47);
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
            this.IniciarSeccionStartAppButton.Location = new System.Drawing.Point(306, 351);
            this.IniciarSeccionStartAppButton.Name = "IniciarSeccionStartAppButton";
            this.IniciarSeccionStartAppButton.Size = new System.Drawing.Size(333, 34);
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
            this.RegistrateButton.Location = new System.Drawing.Point(298, 447);
            this.RegistrateButton.Name = "RegistrateButton";
            this.RegistrateButton.Size = new System.Drawing.Size(341, 46);
            this.RegistrateButton.TabIndex = 1;
            this.RegistrateButton.Text = "Registrate";
            this.RegistrateButton.UseVisualStyleBackColor = true;
            this.RegistrateButton.Click += new System.EventHandler(this.RegistrateButton_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.StartPanel);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "AppForm";
            this.Text = " ";
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
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
        private System.Windows.Forms.Button EXITbutton;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.CheckBox SaveLogin;
        private System.Windows.Forms.Button BackButtonLogin;
        private System.Windows.Forms.Button InicioLoginButton;
        private System.Windows.Forms.TextBox PasswordInPutLogin;
        private System.Windows.Forms.TextBox UsernameInPutLogin;
        private System.Windows.Forms.Label IniciarseccionLabelLogin;
        private System.Windows.Forms.Label PasswordUsernameLabelLogin;
        private System.Windows.Forms.Label UsernameLabelLogin;
        private System.Windows.Forms.Label loginViewInvalidCredentialsAlert;
    }
}

