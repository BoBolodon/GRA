namespace GRA
{
    partial class FormMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonScore = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonComingSoon = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AktywnyProfil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mute = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(127, 305);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 50);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Wyście";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInfo.Location = new System.Drawing.Point(127, 249);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(150, 50);
            this.buttonInfo.TabIndex = 1;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonScore
            // 
            this.buttonScore.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonScore.Location = new System.Drawing.Point(127, 137);
            this.buttonScore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(150, 50);
            this.buttonScore.TabIndex = 2;
            this.buttonScore.Text = "Wyniki";
            this.buttonScore.UseVisualStyleBackColor = true;
            this.buttonScore.Click += new System.EventHandler(this.buttonScore_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonProfile.Location = new System.Drawing.Point(12, 440);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(100, 30);
            this.buttonProfile.TabIndex = 3;
            this.buttonProfile.Text = "Dodaj Profil";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonComingSoon
            // 
            this.buttonComingSoon.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonComingSoon.Location = new System.Drawing.Point(127, 193);
            this.buttonComingSoon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonComingSoon.Name = "buttonComingSoon";
            this.buttonComingSoon.Size = new System.Drawing.Size(150, 50);
            this.buttonComingSoon.TabIndex = 4;
            this.buttonComingSoon.Text = "Nadchodzące";
            this.buttonComingSoon.UseVisualStyleBackColor = true;
            this.buttonComingSoon.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlay.Location = new System.Drawing.Point(127, 81);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(150, 50);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Graj";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(296, 440);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zmień Profil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AktywnyProfil
            // 
            this.AktywnyProfil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AktywnyProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AktywnyProfil.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AktywnyProfil.Location = new System.Drawing.Point(118, 440);
            this.AktywnyProfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AktywnyProfil.Name = "AktywnyProfil";
            this.AktywnyProfil.Size = new System.Drawing.Size(172, 30);
            this.AktywnyProfil.TabIndex = 7;
            this.AktywnyProfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(118, 416);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aktywny Profil Gracza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mute
            // 
            this.Mute.Image = ((System.Drawing.Image)(resources.GetObject("Mute.Image")));
            this.Mute.Location = new System.Drawing.Point(367, 12);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(29, 27);
            this.Mute.TabIndex = 9;
            this.Mute.TabStop = false;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 479);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AktywnyProfil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonComingSoon);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormMenu";
            this.Text = "Goń Serek";
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonScore;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonComingSoon;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AktywnyProfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Mute;
    }
}

