using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco.VideoConverter;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        string[] array1;
        string currentPath = @"C:\";
        string jpgPath = @"C:\VideoPlayer\VideoThumbnail";
        int volume = 50;

        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            Directory.CreateDirectory(@"C:\VideoPlayer\");
            axWindowsMediaPlayer1.settings.volume = volume;
        }

        private void fillFileExplorer()
        {
            try
            {
                WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");
                WMPLib.IWMPMedia media;

                if (listBoxDirectory.SelectedItems.Count > 0)
                    textBoxPath.Text = listBoxDirectory.SelectedItem.ToString();
                array1 = Directory.GetFiles(textBoxPath.Text);
                listViewFiles.Items.Clear();
                imageList.Images.Clear();
                int index = 0;
                foreach (string name in array1)
                {
                    if (File.Exists(name))
                    {
                        if (Path.GetExtension(name) == ".mp4" || Path.GetExtension(name) == ".wmv")
                        {
                            FFMpegConverter ffmpeg = new NReco.VideoConverter.FFMpegConverter();
                            string filename = Path.GetFileNameWithoutExtension(name);
                            ListViewItem row = new ListViewItem(name);
                            string imagePath = jpgPath + index + ".jpg";
                            ffmpeg.GetVideoThumbnail(name, imagePath);
                            if (File.Exists(imagePath))
                            {
                                imageList.Images.Add(Image.FromFile(imagePath));
                                row.ImageIndex = index;
                            }
                            listViewFiles.Items.Add(row);
                            media = axWindowsMediaPlayer1.newMedia(name);
                            playlist.appendItem(media);
                            axWindowsMediaPlayer1.currentPlaylist = playlist;

                            index++;
                        }
                    }
                }
                if (listBoxDirectory.SelectedItems.Count > 0)
                    textBoxPath.Text = listBoxDirectory.SelectedItem.ToString();
                array1 = Directory.GetDirectories(textBoxPath.Text);
                listBoxDirectory.Items.Clear();
                foreach (string name in array1)
                {
                    if (Directory.Exists(name))
                    {
                        listBoxDirectory.Items.Add(name);
                    }
                }
                buttonVideoPlay.Image = Properties.Resources.playerPause;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd w zmianie folderu!");
            }
        }

        private void buttonDirectoryBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBoxPath.Text = fbd.SelectedPath;
                    buttonDirectoryGo_Click(sender, e);
                }
            }
        }

        private void buttonDirectoryReset_Click(object sender, EventArgs e)
        {
            try
            {
                currentPath = @"C:\";
                textBoxPath.Text = @"C:\";
                fillFileExplorer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd w resetowaniu ścieżki!");
            }
        }

        private void buttonDirectoryGo_Click(object sender, EventArgs e)
        {
            try
            {
                currentPath = textBoxPath.Text;
                fillFileExplorer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd w podaniu ścieżki!");
            }
        }

        private void buttonExplorerOpenWindowsExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(textBoxPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błędna ścieżka!");
            }
        }

        private void listBoxDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillFileExplorer();
        }

        private void listViewFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                listViewFiles.Clear();
                listViewFiles.Dispose();
                imageList.Dispose();
                DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\VideoPlayer\");
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    file.Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd w czyszczeniu folderu!");
            }
        }

        private void listViewFiles_DoubleClick(object sender, EventArgs e)
        {
            if (listViewFiles.Items.Count > 0 && listViewFiles.SelectedItems.Count > 0)
            {
                int index = listViewFiles.SelectedItems[0].Index;
                string fileName = listViewFiles.SelectedItems[0].Text;
                var tagFile = TagLib.File.Create(fileName);
                //axWindowsMediaPlayer1.URL = fileName;
                trackBarVideoLength.Value = 0;
                TimeSpan maxLength = tagFile.Properties.Duration;
                trackBarVideoLength.Maximum = (int)maxLength.TotalSeconds;
                WMPLib.IWMPMedia media = axWindowsMediaPlayer1.currentPlaylist.get_Item(index);
                axWindowsMediaPlayer1.Ctlcontrols.playItem(media);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (trackBarVideoLength.Value >= trackBarVideoLength.Maximum)
                buttonVideoStop_Click(sender, e);

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                string fileName = axWindowsMediaPlayer1.currentMedia.sourceURL;
                var tagFile = TagLib.File.Create(fileName);
                trackBarVideoLength.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                TimeSpan videoCurrentLength = TimeSpan.FromSeconds(trackBarVideoLength.Value);
                TimeSpan videoMaxLength = tagFile.Properties.Duration;
                string lengthInfo = "[" + videoCurrentLength.ToString(@"mm\:ss") + " / " + videoMaxLength.ToString(@"mm\:ss") + "] ";
                
                toolStripStatusLabel1.Text = Path.GetFileName(fileName) + " - " + lengthInfo;

                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    buttonVideoPlay.Image = Properties.Resources.playerPause;
                else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused || axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                    buttonVideoPlay.Image = Properties.Resources.playerPlay;
            }
        }

        private void trackBarVideoLength_Scroll(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBarVideoLength.Value;
        }

        private void buttonVideoPlay_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                buttonVideoPlay.Image = Properties.Resources.playerPlay;
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused || axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                buttonVideoPlay.Image = Properties.Resources.playerPause;
            }
        }

        private void buttonVideoPrev_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        private void buttonVideoNext_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void buttonVideoStop_Click(object sender, EventArgs e)
        {
            trackBarVideoLength.Value = 0;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            buttonVideoPlay.Image = Properties.Resources.playerPlay;
        }

        private void trackBarVideoVolume_Scroll(object sender, EventArgs e)
        {
            volume = trackBarVideoVolume.Value;
            axWindowsMediaPlayer1.settings.volume = volume;
        }
    }
}
