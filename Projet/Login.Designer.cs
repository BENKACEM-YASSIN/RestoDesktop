namespace Projet
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.mdp = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbtn = new MetroFramework.Controls.MetroTile();
            this.signup = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // username
            // 
            // 
            // 
            // 
            this.username.CustomButton.Image = null;
            this.username.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.username.CustomButton.Name = "";
            this.username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username.CustomButton.TabIndex = 1;
            this.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username.CustomButton.UseSelectable = true;
            this.username.CustomButton.Visible = false;
            this.username.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.username.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.username.Lines = new string[0];
            this.username.Location = new System.Drawing.Point(48, 201);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.ShortcutsEnabled = true;
            this.username.Size = new System.Drawing.Size(222, 23);
            this.username.TabIndex = 0;
            this.username.UseSelectable = true;
            this.username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mdp
            // 
            // 
            // 
            // 
            this.mdp.CustomButton.Image = null;
            this.mdp.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.mdp.CustomButton.Name = "";
            this.mdp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mdp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mdp.CustomButton.TabIndex = 1;
            this.mdp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mdp.CustomButton.UseSelectable = true;
            this.mdp.CustomButton.Visible = false;
            this.mdp.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mdp.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mdp.Lines = new string[0];
            this.mdp.Location = new System.Drawing.Point(48, 269);
            this.mdp.MaxLength = 32767;
            this.mdp.Name = "mdp";
            this.mdp.PasswordChar = '*';
            this.mdp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mdp.SelectedText = "";
            this.mdp.SelectionLength = 0;
            this.mdp.SelectionStart = 0;
            this.mdp.ShortcutsEnabled = true;
            this.mdp.Size = new System.Drawing.Size(222, 23);
            this.mdp.TabIndex = 2;
            this.mdp.UseSelectable = true;
            this.mdp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mdp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mdp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mdp_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // loginbtn
            // 
            this.loginbtn.ActiveControl = null;
            this.loginbtn.Location = new System.Drawing.Point(69, 318);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(165, 49);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Connecter";
            this.loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("loginbtn.TileImage")));
            this.loginbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginbtn.UseSelectable = true;
            this.loginbtn.UseTileImage = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // signup
            // 
            this.signup.ActiveControl = null;
            this.signup.Location = new System.Drawing.Point(69, 373);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(165, 49);
            this.signup.TabIndex = 7;
            this.signup.Text = "S\'inscrire";
            this.signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signup.TileImage = ((System.Drawing.Image)(resources.GetObject("signup.TileImage")));
            this.signup.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signup.UseSelectable = true;
            this.signup.UseTileImage = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 467);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.username);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox username;
        private MetroFramework.Controls.MetroTextBox mdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile loginbtn;
        private MetroFramework.Controls.MetroTile signup;
    }
}