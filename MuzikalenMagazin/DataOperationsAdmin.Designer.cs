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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backHome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Style,
            this.SongName,
            this.SongURL});
            this.dataGridView1.Location = new System.Drawing.Point(43, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelHelloA
            // 
            this.labelHelloA.AutoSize = true;
            this.labelHelloA.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelloA.Location = new System.Drawing.Point(169, 46);
            this.labelHelloA.Name = "labelHelloA";
            this.labelHelloA.Size = new System.Drawing.Size(204, 36);
            this.labelHelloA.TabIndex = 1;
            this.labelHelloA.Text = "Здравей, Admin!";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Style
            // 
            this.Style.HeaderText = "Style";
            this.Style.Name = "Style";
            // 
            // SongName
            // 
            this.SongName.HeaderText = "Song Name";
            this.SongName.Name = "SongName";
            // 
            // SongURL
            // 
            this.SongURL.HeaderText = "Song URL";
            this.SongURL.Name = "SongURL";
            // 
            // backHome
            // 
            this.backHome.AutoSize = true;
            this.backHome.Location = new System.Drawing.Point(431, 425);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(112, 13);
            this.backHome.TabIndex = 2;
            this.backHome.TabStop = true;
            this.backHome.Text = "<- Начална страница";
            this.backHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backHome_LinkClicked);
            // 
            // DataOperationsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.labelHelloA);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataOperationsAdmin";
            this.Text = "DataOperationsAdmin";
            this.Load += new System.EventHandler(this.DataOperationsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelHelloA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongURL;
        private System.Windows.Forms.LinkLabel backHome;
    }
}