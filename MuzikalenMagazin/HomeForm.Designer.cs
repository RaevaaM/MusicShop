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
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnGallery = new System.Windows.Forms.Button();
            this.btnStyles = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.aboutUs1 = new MuzikalenMagazin.AboutUs();
            this.contacts1 = new MuzikalenMagazin.Contacts();
            this.styles1 = new MuzikalenMagazin.Styles();
            this.galery1 = new MuzikalenMagazin.Galery();
            this.panelMenu.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnAboutUs);
            this.panelMenu.Controls.Add(this.btnLogIn);
            this.panelMenu.Controls.Add(this.btnContacts);
            this.panelMenu.Controls.Add(this.btnGallery);
            this.panelMenu.Controls.Add(this.btnStyles);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Location = new System.Drawing.Point(353, 1);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 409);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAboutUs.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.Location = new System.Drawing.Point(2, 226);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(150, 68);
            this.btnAboutUs.TabIndex = 5;
            this.btnAboutUs.Text = "За нас";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnLogIn.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(2, 291);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(150, 116);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Вход";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnContacts.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacts.Location = new System.Drawing.Point(0, 175);
            this.btnContacts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(150, 56);
            this.btnContacts.TabIndex = 3;
            this.btnContacts.Text = "Контакти";
            this.btnContacts.UseVisualStyleBackColor = false;
            // 
            // btnGallery
            // 
            this.btnGallery.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGallery.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGallery.Location = new System.Drawing.Point(0, 119);
            this.btnGallery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGallery.Name = "btnGallery";
            this.btnGallery.Size = new System.Drawing.Size(150, 58);
            this.btnGallery.TabIndex = 2;
            this.btnGallery.Text = "Галерия";
            this.btnGallery.UseVisualStyleBackColor = false;
            // 
            // btnStyles
            // 
            this.btnStyles.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnStyles.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStyles.Location = new System.Drawing.Point(0, 62);
            this.btnStyles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStyles.Name = "btnStyles";
            this.btnStyles.Size = new System.Drawing.Size(150, 61);
            this.btnStyles.TabIndex = 1;
            this.btnStyles.Text = "Стилове";
            this.btnStyles.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnHome.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 64);
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
            this.homePanel.Location = new System.Drawing.Point(1, 1);
            this.homePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(358, 407);
            this.homePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "SONATA!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 66);
            this.label2.TabIndex = 2;
            this.label2.Text = "  Тук ще намерите различни \r\nстилове музика и много песни!";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(62, 110);
            this.lblHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(237, 46);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Добре дошли в";
            // 
            // aboutUs1
            // 
            this.aboutUs1.BackColor = System.Drawing.Color.PeachPuff;
            this.aboutUs1.Location = new System.Drawing.Point(2, 1);
            this.aboutUs1.Name = "aboutUs1";
            this.aboutUs1.Size = new System.Drawing.Size(357, 409);
            this.aboutUs1.TabIndex = 1;
            // 
            // contacts1
            // 
            this.contacts1.BackColor = System.Drawing.Color.PeachPuff;
            this.contacts1.Location = new System.Drawing.Point(2, 1);
            this.contacts1.Margin = new System.Windows.Forms.Padding(2);
            this.contacts1.Name = "contacts1";
            this.contacts1.Size = new System.Drawing.Size(357, 409);
            this.contacts1.TabIndex = 2;
            // 
            // styles1
            // 
            this.styles1.BackColor = System.Drawing.Color.PeachPuff;
            this.styles1.Location = new System.Drawing.Point(2, 1);
            this.styles1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.styles1.Name = "styles1";
            this.styles1.Size = new System.Drawing.Size(357, 409);
            this.styles1.TabIndex = 3;
            // 
            // galery1
            // 
            this.galery1.BackColor = System.Drawing.Color.PeachPuff;
            this.galery1.Location = new System.Drawing.Point(2, 1);
            this.galery1.Margin = new System.Windows.Forms.Padding(2);
            this.galery1.Name = "galery1";
            this.galery1.Size = new System.Drawing.Size(357, 409);
            this.galery1.TabIndex = 4;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 407);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.galery1);
            this.Controls.Add(this.styles1);
            this.Controls.Add(this.contacts1);
            this.Controls.Add(this.aboutUs1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panelMenu.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnGallery;
        private System.Windows.Forms.Button btnStyles;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHome;
        private AboutUs aboutUs1;
        private Contacts contacts1;
        private Styles styles1;
        private Galery galery1;
    }
}