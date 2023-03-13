namespace MuzikalenMagazin
{
    partial class DataOperationsAdmin2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbStyle = new System.Windows.Forms.TextBox();
            this.tbSinger = new System.Windows.Forms.TextBox();
            this.tbSong = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelSt = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.LinkLabel();
            this.labelHelloA = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StyleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkSongs = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnClear.Location = new System.Drawing.Point(639, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDeleteAll.Location = new System.Drawing.Point(533, 415);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteAll.TabIndex = 30;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDelete.Location = new System.Drawing.Point(432, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 35);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnUpdate.Location = new System.Drawing.Point(330, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 35);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAdd.Location = new System.Drawing.Point(220, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 35);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbStyle
            // 
            this.tbStyle.Location = new System.Drawing.Point(114, 294);
            this.tbStyle.Name = "tbStyle";
            this.tbStyle.Size = new System.Drawing.Size(147, 20);
            this.tbStyle.TabIndex = 26;
            // 
            // tbSinger
            // 
            this.tbSinger.Location = new System.Drawing.Point(127, 243);
            this.tbSinger.Name = "tbSinger";
            this.tbSinger.Size = new System.Drawing.Size(134, 20);
            this.tbSinger.TabIndex = 25;
            // 
            // tbSong
            // 
            this.tbSong.Location = new System.Drawing.Point(114, 196);
            this.tbSong.Name = "tbSong";
            this.tbSong.Size = new System.Drawing.Size(147, 20);
            this.tbSong.TabIndex = 24;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(96, 153);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 23;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRate.Location = new System.Drawing.Point(43, 286);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(63, 28);
            this.labelRate.TabIndex = 22;
            this.labelRate.Text = "Rate:";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDesc.Location = new System.Drawing.Point(43, 235);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(72, 28);
            this.labelDesc.TabIndex = 21;
            this.labelDesc.Text = "Descr:";
            // 
            // labelSt
            // 
            this.labelSt.AutoSize = true;
            this.labelSt.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSt.Location = new System.Drawing.Point(43, 188);
            this.labelSt.Name = "labelSt";
            this.labelSt.Size = new System.Drawing.Size(67, 28);
            this.labelSt.TabIndex = 20;
            this.labelSt.Text = "Style:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(43, 145);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(47, 28);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "ID:";
            // 
            // backHome
            // 
            this.backHome.AutoSize = true;
            this.backHome.Location = new System.Drawing.Point(15, 452);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(75, 13);
            this.backHome.TabIndex = 18;
            this.backHome.TabStop = true;
            this.backHome.Text = "<- Back to site";
            this.backHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backHome_LinkClicked);
            // 
            // labelHelloA
            // 
            this.labelHelloA.AutoSize = true;
            this.labelHelloA.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelloA.Location = new System.Drawing.Point(275, 47);
            this.labelHelloA.Name = "labelHelloA";
            this.labelHelloA.Size = new System.Drawing.Size(204, 36);
            this.labelHelloA.TabIndex = 17;
            this.labelHelloA.Text = "Здравей, Admin!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StyleName,
            this.Descr,
            this.Rate});
            this.dataGridView1.Location = new System.Drawing.Point(281, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 275);
            this.dataGridView1.TabIndex = 16;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // StyleName
            // 
            this.StyleName.HeaderText = "Style Name";
            this.StyleName.Name = "StyleName";
            // 
            // Descr
            // 
            this.Descr.HeaderText = "Description";
            this.Descr.Name = "Descr";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // linkSongs
            // 
            this.linkSongs.AutoSize = true;
            this.linkSongs.Location = new System.Drawing.Point(15, 426);
            this.linkSongs.Name = "linkSongs";
            this.linkSongs.Size = new System.Drawing.Size(89, 13);
            this.linkSongs.TabIndex = 32;
            this.linkSongs.TabStop = true;
            this.linkSongs.Text = "<- To songs table";
            this.linkSongs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSongs_LinkClicked);
            // 
            // DataOperationsAdmin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.linkSongs);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbStyle);
            this.Controls.Add(this.tbSinger);
            this.Controls.Add(this.tbSong);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelSt);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.labelHelloA);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataOperationsAdmin2";
            this.Size = new System.Drawing.Size(742, 476);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbStyle;
        private System.Windows.Forms.TextBox tbSinger;
        private System.Windows.Forms.TextBox tbSong;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelSt;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.LinkLabel backHome;
        private System.Windows.Forms.Label labelHelloA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StyleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.LinkLabel linkSongs;
    }
}
