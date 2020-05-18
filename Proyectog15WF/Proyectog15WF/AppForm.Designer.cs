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
            this.StartAppPANEL = new System.Windows.Forms.Panel();
            this.LoginRegisterPanel = new System.Windows.Forms.Panel();
            this.SOPTLOGO = new System.Windows.Forms.Label();
            this.Loginbuttom = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FLIXLOGO = new System.Windows.Forms.Label();
            this.StartAppPANEL.SuspendLayout();
            this.LoginRegisterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartAppPANEL
            // 
            this.StartAppPANEL.AccessibleName = "StartApp";
            this.StartAppPANEL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartAppPANEL.Controls.Add(this.LoginRegisterPanel);
            this.StartAppPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartAppPANEL.Location = new System.Drawing.Point(0, 0);
            this.StartAppPANEL.Name = "StartAppPANEL";
            this.StartAppPANEL.Size = new System.Drawing.Size(800, 450);
            this.StartAppPANEL.TabIndex = 1;
            this.StartAppPANEL.Paint += new System.Windows.Forms.PaintEventHandler(this.StartApp_Paint);
            // 
            // LoginRegisterPanel
            // 
            this.LoginRegisterPanel.Controls.Add(this.FLIXLOGO);
            this.LoginRegisterPanel.Controls.Add(this.SOPTLOGO);
            this.LoginRegisterPanel.Controls.Add(this.CloseButton);
            this.LoginRegisterPanel.Controls.Add(this.RegisterButton);
            this.LoginRegisterPanel.Controls.Add(this.Loginbuttom);
            this.LoginRegisterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginRegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginRegisterPanel.Name = "LoginRegisterPanel";
            this.LoginRegisterPanel.Size = new System.Drawing.Size(800, 450);
            this.LoginRegisterPanel.TabIndex = 1;
            this.LoginRegisterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginRegisterPanel_Paint);
            // 
            // SOPTLOGO
            // 
            this.SOPTLOGO.AutoSize = true;
            this.SOPTLOGO.BackColor = System.Drawing.SystemColors.ControlText;
            this.SOPTLOGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOPTLOGO.ForeColor = System.Drawing.Color.SeaGreen;
            this.SOPTLOGO.Location = new System.Drawing.Point(268, 35);
            this.SOPTLOGO.Name = "SOPTLOGO";
            this.SOPTLOGO.Size = new System.Drawing.Size(129, 46);
            this.SOPTLOGO.TabIndex = 0;
            this.SOPTLOGO.Text = "SPOT";
            this.SOPTLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SOPTLOGO.Click += new System.EventHandler(this.label2_Click);
            // 
            // Loginbuttom
            // 
            this.Loginbuttom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Loginbuttom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbuttom.ForeColor = System.Drawing.Color.Red;
            this.Loginbuttom.Location = new System.Drawing.Point(325, 176);
            this.Loginbuttom.Name = "Loginbuttom";
            this.Loginbuttom.Size = new System.Drawing.Size(157, 52);
            this.Loginbuttom.TabIndex = 0;
            this.Loginbuttom.Text = "Inicar Seccion";
            this.Loginbuttom.UseVisualStyleBackColor = true;
            this.Loginbuttom.Click += new System.EventHandler(this.Loginbuttom_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RegisterButton.Location = new System.Drawing.Point(325, 272);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(157, 48);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Registrate";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(0, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(44, 39);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // FLIXLOGO
            // 
            this.FLIXLOGO.AutoSize = true;
            this.FLIXLOGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLIXLOGO.ForeColor = System.Drawing.Color.Red;
            this.FLIXLOGO.Location = new System.Drawing.Point(403, 35);
            this.FLIXLOGO.Name = "FLIXLOGO";
            this.FLIXLOGO.Size = new System.Drawing.Size(103, 46);
            this.FLIXLOGO.TabIndex = 3;
            this.FLIXLOGO.Text = "FLIX";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartAppPANEL);
            this.Name = "AppForm";
            this.Text = " ";
            this.StartAppPANEL.ResumeLayout(false);
            this.LoginRegisterPanel.ResumeLayout(false);
            this.LoginRegisterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel StartAppPANEL;
        private System.Windows.Forms.Label SOPTLOGO;
        private System.Windows.Forms.Panel LoginRegisterPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button Loginbuttom;
        private System.Windows.Forms.Label FLIXLOGO;
    }
}

