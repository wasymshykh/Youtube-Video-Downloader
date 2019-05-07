using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;
using YoutubeExplode.Models;

namespace YTDownloader
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string _url = "";
        private string _url_id = "";
        private string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private Video v_data;
        private YoutubeClient v_client;
        private IReadOnlyList<VideoStreamInfo> _videos;

        private void btn_get_Click(object sender, EventArgs e)
        {
            this._url = txt_url.Text;
            try
            {
                this._url_id = YoutubeClient.ParseVideoId(this._url);

                lbl_msg.Visible = false;
                txt_url.Enabled = false;
                btn_get.BackColor = Color.Gray;
                btn_get.Enabled = false;

                getVideoData();

            } catch(Exception)
            {
                lbl_msg.BackColor = Color.DarkRed;
                lbl_msg.Visible = true;
                lbl_msg.Text = "Please enter valid url";
                progress_get.Value = 100;
            }
            
        }

        private async void getVideoData()
        {
            progress_get.Value = 10;
            this.v_client = new YoutubeClient();

            v_data = await this.v_client.GetVideoAsync(this._url_id);
            progress_get.Value = 30;

            var v_steam = await this.v_client.GetVideoMediaStreamInfosAsync(this._url_id);
            progress_get.Value = 50;

            picture_thumbnail.Load(v_data.Thumbnails.HighResUrl);
            picture_thumbnail.Visible = true;

            progress_get.Value = 80;
            lbl_title.Text = v_data.Title;
            lbl_title.Visible = true;
            lbl_author.Text = v_data.Author;
            lbl_author.Visible = true;
            picture_avatar.Visible = true;
            lbl_duration.Text = $"{v_data.Duration.Hours.ToString("00")}:{v_data.Duration.Minutes.ToString("00")}:{v_data.Duration.Seconds.ToString("00")}";
            lbl_duration.Visible = true;
            progress_get.Value = 90;

            this._videos = v_steam.Video;
            foreach(var v in this._videos)
            {
                combo_quality.Items.Add($"{v.VideoQualityLabel}_{v.Container}");
            }
            btn_download.Visible = true;
            progress_get.Value = 100;

            this.Height = 420;
            btn_get.Visible = false;
            btn_get.Enabled = true;
            btn_reset.Visible = true;
        }

        

        private void MainWindow_Load(object sender, EventArgs e)
        {
            txt_path.Text = this._path;
            initialWindowStage();
        }

        private void initialWindowStage()
        {
            this.Height = 220;

            txt_url.Enabled = true;

            btn_get.Visible = true;
            btn_get.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));

            btn_reset.Visible = false;
            btn_download.Visible = false;

            progress_get.Value = 0;
            progress_download.Value = 0;

            picture_thumbnail.Visible = false;
            picture_avatar.Visible = false;

            lbl_d_complete.Visible = false;
            lbl_title.Visible = false;
            lbl_author.Visible = false;
            lbl_duration.Visible = false;
            lbl_msg.Visible = false;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                this._path = fbd.SelectedPath;
                txt_path.Text = this._path;
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if(combo_quality.SelectedItem != null)
            {
                string[] quality_combo = combo_quality.SelectedItem.ToString().Split('_');

                var video = this._videos.Where(s => (s.VideoQualityLabel == quality_combo[0] && s.Container.ToString() == quality_combo[1])).First();

                lbl_d_complete.Visible = false;
                btn_download.Enabled = false;
                btn_download.BackColor = Color.Gray;
                downloadVideo(video);
            } else
            {
                lbl_d_complete.Visible = true;
                lbl_d_complete.BackColor = Color.DarkRed;
                lbl_d_complete.Text = "Please select quality!";
            }
        }

        private async void downloadVideo(VideoStreamInfo video)
        {
            try
            {
                string extension = video.Container.GetFileExtension();

                using (var progress = new Progressive(this, progress_download, lbl_d_complete))
                {
                    await this.v_client.DownloadMediaStreamAsync(video, $"{txt_path.Text}\\{v_data.Id}.{extension}", progress);
                }

                btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(33)))));
                btn_download.Enabled = true;

            }
            catch (Exception)
            {
                lbl_d_complete.Visible = true;
                lbl_d_complete.BackColor = Color.DarkRed;
                lbl_d_complete.Text = "Unable to save, change directory!";
            }
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            initialWindowStage();
        }
    }

    class Progressive : IProgress<double>, IDisposable
    {
        private ProgressBar progress_download;
        private Label lbl_d_complete;
        private Form ff;

        public Progressive(Form ff, ProgressBar progress_download, Label lbl_d_complete)
        {
            this.ff = ff;
            this.progress_download = progress_download;
            this.lbl_d_complete = lbl_d_complete;
        }

        public void Report(double progress)
        {
            ThreadJump.SetValue(ff, progress_download, progress*100);
        }

        public void Dispose()
        {
            lbl_d_complete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(33)))));
            lbl_d_complete.Visible = true;
            lbl_d_complete.Text = "Successfully downloaded!";
        }
    }

    // Class for modifying windows form component [progress bar] value from thread other than it's created.
    public static class ThreadJump
    {
        delegate void SetValueDelegate(Form f, ProgressBar ctrl, double progress);

        public static void SetValue(Form f, ProgressBar ctrl, double progress)
        {
            if (ctrl.InvokeRequired)
            {
                SetValueDelegate d = new SetValueDelegate(SetValue);
                f.Invoke(d, new object[] { f, ctrl, progress });
            }
            else
            {
                ctrl.Value = (int)progress;
            }
        }
    }
}
