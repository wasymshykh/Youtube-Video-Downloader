namespace YTDownloader
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btn_get = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.progress_get = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture_thumbnail = new System.Windows.Forms.PictureBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.combo_quality = new System.Windows.Forms.ComboBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.picture_avatar = new System.Windows.Forms.PictureBox();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.progress_download = new System.Windows.Forms.ProgressBar();
            this.lbl_d_complete = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_thumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_get
            // 
            this.btn_get.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.btn_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_get.ForeColor = System.Drawing.Color.White;
            this.btn_get.Location = new System.Drawing.Point(402, 109);
            this.btn_get.Margin = new System.Windows.Forms.Padding(0);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(100, 30);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = false;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // txt_url
            // 
            this.txt_url.AutoCompleteCustomSource.AddRange(new string[] {
            "http://www.youtube.com/?v=",
            "https://www.youtube.com/?v="});
            this.txt_url.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_url.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_url.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txt_url.Location = new System.Drawing.Point(62, 110);
            this.txt_url.Margin = new System.Windows.Forms.Padding(0);
            this.txt_url.Multiline = true;
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(340, 28);
            this.txt_url.TabIndex = 2;
            this.txt_url.Text = "https://www.youtube.com/watch?v=6TWJaFD6R2s";
            // 
            // progress_get
            // 
            this.progress_get.BackColor = System.Drawing.Color.White;
            this.progress_get.Location = new System.Drawing.Point(62, 140);
            this.progress_get.Name = "progress_get";
            this.progress_get.Size = new System.Drawing.Size(440, 10);
            this.progress_get.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YTDownloader.Properties.Resources.ytdownloader;
            this.pictureBox1.Location = new System.Drawing.Point(120, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 64);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // picture_thumbnail
            // 
            this.picture_thumbnail.Location = new System.Drawing.Point(50, 189);
            this.picture_thumbnail.Name = "picture_thumbnail";
            this.picture_thumbnail.Size = new System.Drawing.Size(144, 146);
            this.picture_thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_thumbnail.TabIndex = 6;
            this.picture_thumbnail.TabStop = false;
            // 
            // btn_download
            // 
            this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(33)))));
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.ForeColor = System.Drawing.Color.White;
            this.btn_download.Location = new System.Drawing.Point(391, 272);
            this.btn_download.Margin = new System.Windows.Forms.Padding(0);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(120, 26);
            this.btn_download.TabIndex = 7;
            this.btn_download.Text = "Start Download";
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // combo_quality
            // 
            this.combo_quality.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_quality.FormattingEnabled = true;
            this.combo_quality.Location = new System.Drawing.Point(218, 274);
            this.combo_quality.Name = "combo_quality";
            this.combo_quality.Size = new System.Drawing.Size(170, 23);
            this.combo_quality.TabIndex = 8;
            this.combo_quality.Text = "Select Quality";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_title.Location = new System.Drawing.Point(200, 189);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(292, 15);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "Mike Perry - Inside the Lines ft. Casso (Official Video)";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_duration.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.ForeColor = System.Drawing.Color.White;
            this.lbl_duration.Location = new System.Drawing.Point(447, 216);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.lbl_duration.Size = new System.Drawing.Size(75, 19);
            this.lbl_duration.TabIndex = 10;
            this.lbl_duration.Text = "00:07:14";
            // 
            // picture_avatar
            // 
            this.picture_avatar.BackColor = System.Drawing.Color.Transparent;
            this.picture_avatar.BackgroundImage = global::YTDownloader.Properties.Resources.authorimg;
            this.picture_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_avatar.Location = new System.Drawing.Point(205, 211);
            this.picture_avatar.Name = "picture_avatar";
            this.picture_avatar.Size = new System.Drawing.Size(28, 28);
            this.picture_avatar.TabIndex = 11;
            this.picture_avatar.TabStop = false;
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_author.Location = new System.Drawing.Point(237, 218);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(70, 15);
            this.lbl_author.TabIndex = 9;
            this.lbl_author.Text = "Monstercat";
            // 
            // lbl_msg
            // 
            this.lbl_msg.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.White;
            this.lbl_msg.Location = new System.Drawing.Point(59, 156);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(443, 20);
            this.lbl_msg.TabIndex = 9;
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_msg.Visible = false;
            // 
            // txt_path
            // 
            this.txt_path.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.Location = new System.Drawing.Point(203, 244);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(232, 22);
            this.txt_path.TabIndex = 12;
            this.txt_path.Text = "C:\\Users\\WasymSheikh\\Desktop";
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.Gray;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Location = new System.Drawing.Point(435, 243);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(0);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(90, 24);
            this.btn_browse.TabIndex = 7;
            this.btn_browse.Text = "Browse..";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // progress_download
            // 
            this.progress_download.BackColor = System.Drawing.Color.White;
            this.progress_download.Location = new System.Drawing.Point(218, 301);
            this.progress_download.Name = "progress_download";
            this.progress_download.Size = new System.Drawing.Size(293, 10);
            this.progress_download.TabIndex = 4;
            // 
            // lbl_d_complete
            // 
            this.lbl_d_complete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(33)))));
            this.lbl_d_complete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_d_complete.ForeColor = System.Drawing.Color.White;
            this.lbl_d_complete.Location = new System.Drawing.Point(215, 315);
            this.lbl_d_complete.Name = "lbl_d_complete";
            this.lbl_d_complete.Size = new System.Drawing.Size(296, 20);
            this.lbl_d_complete.TabIndex = 9;
            this.lbl_d_complete.Text = "Download Successfully Completed!";
            this.lbl_d_complete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_d_complete.Visible = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(402, 109);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 30);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.picture_avatar);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbl_d_complete);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.combo_quality);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.picture_thumbnail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progress_download);
            this.Controls.Add(this.progress_get);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_get);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_thumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.ProgressBar progress_get;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.PictureBox picture_thumbnail;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.ComboBox combo_quality;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox picture_avatar;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.ProgressBar progress_download;
        private System.Windows.Forms.Label lbl_d_complete;
        private System.Windows.Forms.Button btn_reset;
    }
}

