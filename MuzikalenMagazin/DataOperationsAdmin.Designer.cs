namespace MuzikalenMagazin
{
    partial class DataOperationsAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelHelloA = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.LinkLabel();
            this.labelID = new System.Windows.Forms.Label();
            this.labelSong = new System.Windows.Forms.Label();
            this.labelSinger = new System.Windows.Forms.Label();
            this.labelStyle = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongSinger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbSong = new System.Windows.Forms.TextBox();
            this.tbSinger = new System.Windows.Forms.TextBox();
            this.tbStyle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelSongsData = new System.Windows.Forms.Panel();
            this.linkStyles = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSongsData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SongName,
            this.SongSinger,
            this.Style});
            this.dataGridView1.Location = new System.Drawing.Point(285, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelHelloA
            // 
            this.labelHelloA.AutoSize = true;
            this.labelHelloA.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelloA.Location = new System.Drawing.Point(265, 53);
            this.labelHelloA.Name = "labelHelloA";
            this.labelHelloA.Size = new System.Drawing.Size(204, 36);
            this.labelHelloA.TabIndex = 1;
            this.labelHelloA.Text = "Здравей, Admin!";
            // 
            // backHome
            // 
            this.backHome.AutoSize = true;
            this.backHome.Location = new System.Drawing.Point(11, 451);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(75, 13);
            this.backHome.TabIndex = 2;
            this.backHome.TabStop = true;
            this.backHome.Text = "<- Back to site";
            this.backHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backHome_LinkClicked);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(33, 159);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(47, 28);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID:";
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSong.Location = new System.Drawing.Point(33, 202);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(65, 28);
            this.labelSong.TabIndex = 4;
            this.labelSong.Text = "Song:";
            // 
            // labelSinger
            // 
            this.labelSinger.AutoSize = true;
            this.labelSinger.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSinger.Location = new System.Drawing.Point(33, 249);
            this.labelSinger.Name = "labelSinger";
            this.labelSinger.Size = new System.Drawing.Size(78, 28);
            this.labelSinger.TabIndex = 5;
            this.labelSinger.Text = "Singer:";
            // 
            // labelStyle
            // 
            this.labelStyle.AutoSize = true;
            this.labelStyle.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStyle.Location = new System.Drawing.Point(33, 300);
            this.labelStyle.Name = "labelStyle";
            this.labelStyle.Size = new System.Drawing.Size(67, 28);
            this.labelStyle.TabIndex = 6;
            this.labelStyle.Text = "Style:";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // SongName
            // 
            this.SongName.HeaderText = "Song Name";
            this.SongName.Name = "SongName";
            // 
            // SongSinger
            // 
            this.SongSinger.HeaderText = "Singer";
            this.SongSinger.Name = "SongSinger";
            // 
            // Style
            // 
            this.Style.HeaderText = "Style";
            this.Style.Name = "Style";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(86, 167);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 7;
            // 
            // tbSong
            // 
            this.tbSong.Location = new System.Drawing.Point(104, 210);
            this.tbSong.Name = "tbSong";
            this.tbSong.Size = new System.Drawing.Size(147, 20);
            this.tbSong.TabIndex = 8;
            // 
            // tbSinger
            // 
            this.tbSinger.Location = new System.Drawing.Point(117, 257);
            this.tbSinger.Name = "tbSinger";
            this.tbSinger.Size = new System.Drawing.Size(134, 20);
            this.tbSinger.TabIndex = 9;
            // 
            // tbStyle
            // 
            this.tbStyle.Location = new System.Drawing.Point(104, 308);
            this.tbStyle.Name = "tbStyle";
            this.tbStyle.Size = new System.Drawing.Size(147, 20);
            this.tbStyle.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAdd.Location = new System.Drawing.Point(210, 429);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnUpdate.Location = new System.Drawing.Point(320, 429);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 35);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDelete.Location = new System.Drawing.Point(422, 429);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 35);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDeleteAll.Location = new System.Drawing.Point(523, 429);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteAll.TabIndex = 14;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnClear.Location = new System.Drawing.Point(629, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // panelSongsData
            // 
            this.panelSongsData.Controls.Add(this.linkStyles);
            this.panelSongsData.Controls.Add(this.btnClear);
            this.panelSongsData.Controls.Add(this.btnDeleteAll);
            this.panelSongsData.Controls.Add(this.btnDelete);
            this.panelSongsData.Controls.Add(this.btnUpdate);
            this.panelSongsData.Controls.Add(this.btnAdd);
            this.panelSongsData.Controls.Add(this.tbStyle);
            this.panelSongsData.Controls.Add(this.tbSinger);
            this.panelSongsData.Controls.Add(this.tbSong);
            this.panelSongsData.Controls.Add(this.tbID);
            this.panelSongsData.Controls.Add(this.labelStyle);
            this.panelSongsData.Controls.Add(this.labelSinger);
            this.panelSongsData.Controls.Add(this.labelSong);
            this.panelSongsData.Controls.Add(this.labelID);
            this.panelSongsData.Controls.Add(this.backHome);
            this.panelSongsData.Controls.Add(this.labelHelloA);
            this.panelSongsData.Controls.Add(this.dataGridView1);
            this.panelSongsData.Location = new System.Drawing.Point(0, 0);
            this.panelSongsData.Name = "panelSongsData";
            this.panelSongsData.Size = new System.Drawing.Size(742, 476);
            this.panelSongsData.TabIndex = 16;
            // 
            // linkStyles
            // 
            this.linkStyles.AutoSize = true;
            this.linkStyles.Location = new System.Drawing.Point(642, 9);
            this.linkStyles.Name = "linkStyles";
            this.linkStyles.Size = new System.Drawing.Size(87, 13);
            this.linkStyles.TabIndex = 16;
            this.linkStyles.TabStop = true;
            this.linkStyles.Text = "To styles table ->";
            this.linkStyles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStyles_LinkClicked);
            // 
            // DataOperationsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(742, 473);
            this.Controls.Add(this.panelSongsData);
            this.Name = "DataOperationsAdmin";
            this.Text = "DataOperationsAdmin";
            this.Load += new System.EventHandler(this.DataOperationsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSongsData.ResumeLayout(false);
            this.panelSongsData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelHelloA;
        private System.Windows.Forms.LinkLabel backHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongSinger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.Label labelSinger;
        private System.Windows.Forms.Label labelStyle;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbSong;
        private System.Windows.Forms.TextBox tbSinger;
        private System.Windows.Forms.TextBox tbStyle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelSongsData;
        private System.Windows.Forms.LinkLabel linkStyles;
    }
}