namespace GRA
{
    partial class FormProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfil));
            this.textBoxNewProfileName = new System.Windows.Forms.TextBox();
            this.buttonCreateProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNewProfileName
            // 
            this.textBoxNewProfileName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNewProfileName.Location = new System.Drawing.Point(12, 33);
            this.textBoxNewProfileName.Name = "textBoxNewProfileName";
            this.textBoxNewProfileName.Size = new System.Drawing.Size(318, 28);
            this.textBoxNewProfileName.TabIndex = 0;
            this.textBoxNewProfileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCreateProfile
            // 
            this.buttonCreateProfile.AutoSize = true;
            this.buttonCreateProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCreateProfile.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateProfile.Location = new System.Drawing.Point(0, 195);
            this.buttonCreateProfile.Name = "buttonCreateProfile";
            this.buttonCreateProfile.Size = new System.Drawing.Size(342, 43);
            this.buttonCreateProfile.TabIndex = 1;
            this.buttonCreateProfile.Text = "Stwórz profil";
            this.buttonCreateProfile.UseVisualStyleBackColor = true;
            this.buttonCreateProfile.Click += new System.EventHandler(this.buttonCreateProfile_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(342, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz nazwę dla nowego profilu gracza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(318, 106);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profil gracza będzie wykorzystywany przy zapisywaniu wyników osiągniętych w grze." +
    " Po nacisnięciu przycisku stwórz profil gracza zostanie utworzony i będzie dostę" +
    "pny w polu wyboru.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(342, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateProfile);
            this.Controls.Add(this.textBoxNewProfileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProfil";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewProfileName;
        private System.Windows.Forms.Button buttonCreateProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}