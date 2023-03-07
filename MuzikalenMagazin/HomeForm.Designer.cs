namespace MuzikalenMagazin
{
    partial class HomeForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnGallery = new System.Windows.Forms.Button();
            this.btnStyles = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnSignUp);
            this.panelMenu.Controls.Add(this.btnLogIn);
            this.panelMenu.Controls.Add(this.btnContacts);
            this.panelMenu.Controls.Add(this.btnGallery);
            this.panelMenu.Controls.Add(this.btnStyles);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Location = new System.Drawing.Point(471, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 503);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSignUp.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(0, 389);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(200, 114);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Регистрация";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnLogIn.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(0, 280);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(200, 115);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Вход";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnContacts.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacts.Location = new System.Drawing.Point(0, 215);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(200, 69);
            this.btnContacts.TabIndex = 3;
            this.btnContacts.Text = "Контакти";
            this.btnContacts.UseVisualStyleBackColor = false;
            // 
            // btnGallery
            // 
            this.btnGallery.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGallery.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGallery.Location = new System.Drawing.Point(0, 147);
            this.btnGallery.Name = "btnGallery";
            this.btnGallery.Size = new System.Drawing.Size(200, 71);
            this.btnGallery.TabIndex = 2;
            this.btnGallery.Text = "Галерия";
            this.btnGallery.UseVisualStyleBackColor = false;
            // 
            // btnStyles
            // 
            this.btnStyles.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnStyles.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStyles.Location = new System.Drawing.Point(0, 76);
            this.btnStyles.Name = "btnStyles";
            this.btnStyles.Size = new System.Drawing.Size(200, 75);
            this.btnStyles.TabIndex = 1;
            this.btnStyles.Text = "Стилове";
            this.btnStyles.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnHome.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 79);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Начало";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.PeachPuff;
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Controls.Add(this.label2);
            this.homePanel.Controls.Add(this.lblHome);
            this.homePanel.Location = new System.Drawing.Point(0, 1);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(476, 503);
            this.homePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "SONATA!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 80);
            this.label2.TabIndex = 2;
            this.label2.Text = "  Тук ще намерите различни \r\nстилове музика и много песни!";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(83, 136);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(292, 56);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Добре дошли в";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 502);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.panelMenu);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panelMenu.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnGallery;
        private System.Windows.Forms.Button btnStyles;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHome;
    }
}