namespace GRA
{
    partial class FormZmianaProfilu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZmianaProfilu));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectProfile = new System.Windows.Forms.ComboBox();
            this.buttonAktywujProfil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz Profil Gracza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSelectProfile
            // 
            this.comboBoxSelectProfile.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSelectProfile.FormattingEnabled = true;
            this.comboBoxSelectProfile.Location = new System.Drawing.Point(12, 31);
            this.comboBoxSelectProfile.Name = "comboBoxSelectProfile";
            this.comboBoxSelectProfile.Size = new System.Drawing.Size(274, 30);
            this.comboBoxSelectProfile.TabIndex = 1;
            // 
            // buttonAktywujProfil
            // 
            this.buttonAktywujProfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAktywujProfil.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktywujProfil.Location = new System.Drawing.Point(0, 229);
            this.buttonAktywujProfil.Name = "buttonAktywujProfil";
            this.buttonAktywujProfil.Size = new System.Drawing.Size(298, 43);
            this.buttonAktywujProfil.TabIndex = 2;
            this.buttonAktywujProfil.Text = "Aktywuj Profil";
            this.buttonAktywujProfil.UseVisualStyleBackColor = true;
            this.buttonAktywujProfil.Click += new System.EventHandler(this.buttonAktywujProfil_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 11.25F);
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 145);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormZmianaProfilu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAktywujProfil);
            this.Controls.Add(this.comboBoxSelectProfile);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormZmianaProfilu";
            this.Text = "Zmiana Profilu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectProfile;
        private System.Windows.Forms.Button buttonAktywujProfil;
        private System.Windows.Forms.Label label2;
    }
}