
namespace VideoPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxExplorer = new System.Windows.Forms.GroupBox();
            this.groupBoxDirectories = new System.Windows.Forms.GroupBox();
            this.listBoxDirectory = new System.Windows.Forms.ListBox();
            this.groupBoxDirectory = new System.Windows.Forms.GroupBox();
            this.buttonExplorerOpenWindowsExplorer = new System.Windows.Forms.Button();
            this.buttonDirectoryBrowse = new System.Windows.Forms.Button();
            this.buttonDirectoryGo = new System.Windows.Forms.Button();
            this.buttonDirectoryReset = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonVideoPlay = new System.Windows.Forms.Button();
            this.buttonVideoNext = new System.Windows.Forms.Button();
            this.buttonVideoPrev = new System.Windows.Forms.Button();
            this.buttonVideoStop = new System.Windows.Forms.Button();
            this.trackBarVideoLength = new System.Windows.Forms.TrackBar();
            this.buttonVideoVolume = new System.Windows.Forms.Button();
            this.trackBarVideoVolume = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBoxExplorer.SuspendLayout();
            this.groupBoxDirectories.SuspendLayout();
            this.groupBoxDirectory.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideoLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideoVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxExplorer
            // 
            this.groupBoxExplorer.Controls.Add(this.groupBoxDirectories);
            this.groupBoxExplorer.Controls.Add(this.groupBoxDirectory);
            this.groupBoxExplorer.Location = new System.Drawing.Point(5, 4);
            this.groupBoxExplorer.Name = "groupBoxExplorer";
            this.groupBoxExplorer.Size = new System.Drawing.Size(791, 154);
            this.groupBoxExplorer.TabIndex = 13;
            this.groupBoxExplorer.TabStop = false;
            this.groupBoxExplorer.Text = "Eksplorator plików";
            // 
            // groupBoxDirectories
            // 
            this.groupBoxDirectories.Controls.Add(this.listBoxDirectory);
            this.groupBoxDirectories.Location = new System.Drawing.Point(266, 16);
            this.groupBoxDirectories.Name = "groupBoxDirectories";
            this.groupBoxDirectories.Size = new System.Drawing.Size(519, 132);
            this.groupBoxDirectories.TabIndex = 2;
            this.groupBoxDirectories.TabStop = false;
            this.groupBoxDirectories.Text = "Foldery";
            // 
            // listBoxDirectory
            // 
            this.listBoxDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDirectory.FormattingEnabled = true;
            this.listBoxDirectory.Location = new System.Drawing.Point(3, 16);
            this.listBoxDirectory.Name = "listBoxDirectory";
            this.listBoxDirectory.Size = new System.Drawing.Size(513, 113);
            this.listBoxDirectory.TabIndex = 0;
            this.listBoxDirectory.SelectedIndexChanged += new System.EventHandler(this.listBoxDirectory_SelectedIndexChanged);
            // 
            // groupBoxDirectory
            // 
            this.groupBoxDirectory.Controls.Add(this.buttonExplorerOpenWindowsExplorer);
            this.groupBoxDirectory.Controls.Add(this.buttonDirectoryBrowse);
            this.groupBoxDirectory.Controls.Add(this.buttonDirectoryGo);
            this.groupBoxDirectory.Controls.Add(this.buttonDirectoryReset);
            this.groupBoxDirectory.Controls.Add(this.textBoxPath);
            this.groupBoxDirectory.Location = new System.Drawing.Point(6, 16);
            this.groupBoxDirectory.Name = "groupBoxDirectory";
            this.groupBoxDirectory.Size = new System.Drawing.Size(254, 132);
            this.groupBoxDirectory.TabIndex = 1;
            this.groupBoxDirectory.TabStop = false;
            this.groupBoxDirectory.Text = "Ścieżka";
            // 
            // buttonExplorerOpenWindowsExplorer
            // 
            this.buttonExplorerOpenWindowsExplorer.Location = new System.Drawing.Point(3, 101);
            this.buttonExplorerOpenWindowsExplorer.Name = "buttonExplorerOpenWindowsExplorer";
            this.buttonExplorerOpenWindowsExplorer.Size = new System.Drawing.Size(248, 23);
            this.buttonExplorerOpenWindowsExplorer.TabIndex = 5;
            this.buttonExplorerOpenWindowsExplorer.Text = "Otwórz folder w eksploratorze Windows";
            this.buttonExplorerOpenWindowsExplorer.UseVisualStyleBackColor = true;
            this.buttonExplorerOpenWindowsExplorer.Click += new System.EventHandler(this.buttonExplorerOpenWindowsExplorer_Click);
            // 
            // buttonDirectoryBrowse
            // 
            this.buttonDirectoryBrowse.Location = new System.Drawing.Point(131, 42);
            this.buttonDirectoryBrowse.Name = "buttonDirectoryBrowse";
            this.buttonDirectoryBrowse.Size = new System.Drawing.Size(120, 24);
            this.buttonDirectoryBrowse.TabIndex = 3;
            this.buttonDirectoryBrowse.Text = "Wybierz folder...";
            this.buttonDirectoryBrowse.UseVisualStyleBackColor = true;
            this.buttonDirectoryBrowse.Click += new System.EventHandler(this.buttonDirectoryBrowse_Click);
            // 
            // buttonDirectoryGo
            // 
            this.buttonDirectoryGo.Location = new System.Drawing.Point(3, 71);
            this.buttonDirectoryGo.Name = "buttonDirectoryGo";
            this.buttonDirectoryGo.Size = new System.Drawing.Size(248, 24);
            this.buttonDirectoryGo.TabIndex = 2;
            this.buttonDirectoryGo.Text = "Przejdź do podanej ścieżki";
            this.buttonDirectoryGo.UseVisualStyleBackColor = true;
            this.buttonDirectoryGo.Click += new System.EventHandler(this.buttonDirectoryGo_Click);
            // 
            // buttonDirectoryReset
            // 
            this.buttonDirectoryReset.Location = new System.Drawing.Point(3, 41);
            this.buttonDirectoryReset.Name = "buttonDirectoryReset";
            this.buttonDirectoryReset.Size = new System.Drawing.Size(120, 24);
            this.buttonDirectoryReset.TabIndex = 1;
            this.buttonDirectoryReset.Text = "Reset do C:/";
            this.buttonDirectoryReset.UseVisualStyleBackColor = true;
            this.buttonDirectoryReset.Click += new System.EventHandler(this.buttonDirectoryReset_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPath.Location = new System.Drawing.Point(3, 16);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(248, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.listViewFiles);
            this.groupBoxFiles.Location = new System.Drawing.Point(5, 158);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(260, 380);
            this.groupBoxFiles.TabIndex = 3;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Pliki";
            // 
            // listViewFiles
            // 
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.LargeImageList = this.imageList;
            this.listViewFiles.Location = new System.Drawing.Point(3, 16);
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(254, 361);
            this.listViewFiles.SmallImageList = this.imageList;
            this.listViewFiles.TabIndex = 1;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Tile;
            this.listViewFiles.SelectedIndexChanged += new System.EventHandler(this.listViewFiles_SelectedIndexChanged);
            this.listViewFiles.DoubleClick += new System.EventHandler(this.listViewFiles_DoubleClick);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(100, 60);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(225, 17);
            this.toolStripStatusLabel1.Text = "Nic nie jest odtwarzane w tym momencie";
            // 
            // buttonVideoPlay
            // 
            this.buttonVideoPlay.Image = global::VideoPlayer.Properties.Resources.playerPlay;
            this.buttonVideoPlay.Location = new System.Drawing.Point(453, 506);
            this.buttonVideoPlay.Name = "buttonVideoPlay";
            this.buttonVideoPlay.Size = new System.Drawing.Size(36, 36);
            this.buttonVideoPlay.TabIndex = 18;
            this.buttonVideoPlay.UseVisualStyleBackColor = true;
            this.buttonVideoPlay.Click += new System.EventHandler(this.buttonVideoPlay_Click);
            // 
            // buttonVideoNext
            // 
            this.buttonVideoNext.Image = global::VideoPlayer.Properties.Resources.playerNext;
            this.buttonVideoNext.Location = new System.Drawing.Point(495, 506);
            this.buttonVideoNext.Name = "buttonVideoNext";
            this.buttonVideoNext.Size = new System.Drawing.Size(36, 36);
            this.buttonVideoNext.TabIndex = 18;
            this.buttonVideoNext.UseVisualStyleBackColor = true;
            this.buttonVideoNext.Click += new System.EventHandler(this.buttonVideoNext_Click);
            // 
            // buttonVideoPrev
            // 
            this.buttonVideoPrev.Image = global::VideoPlayer.Properties.Resources.playerPrev;
            this.buttonVideoPrev.Location = new System.Drawing.Point(411, 506);
            this.buttonVideoPrev.Name = "buttonVideoPrev";
            this.buttonVideoPrev.Size = new System.Drawing.Size(36, 36);
            this.buttonVideoPrev.TabIndex = 18;
            this.buttonVideoPrev.UseVisualStyleBackColor = true;
            this.buttonVideoPrev.Click += new System.EventHandler(this.buttonVideoPrev_Click);
            // 
            // buttonVideoStop
            // 
            this.buttonVideoStop.Image = global::VideoPlayer.Properties.Resources.playerStop;
            this.buttonVideoStop.Location = new System.Drawing.Point(537, 506);
            this.buttonVideoStop.Name = "buttonVideoStop";
            this.buttonVideoStop.Size = new System.Drawing.Size(36, 36);
            this.buttonVideoStop.TabIndex = 18;
            this.buttonVideoStop.UseVisualStyleBackColor = true;
            this.buttonVideoStop.Click += new System.EventHandler(this.buttonVideoStop_Click);
            // 
            // trackBarVideoLength
            // 
            this.trackBarVideoLength.Location = new System.Drawing.Point(271, 474);
            this.trackBarVideoLength.Name = "trackBarVideoLength";
            this.trackBarVideoLength.Size = new System.Drawing.Size(525, 45);
            this.trackBarVideoLength.TabIndex = 19;
            this.trackBarVideoLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVideoLength.Scroll += new System.EventHandler(this.trackBarVideoLength_Scroll);
            // 
            // buttonVideoVolume
            // 
            this.buttonVideoVolume.Enabled = false;
            this.buttonVideoVolume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVideoVolume.Image = global::VideoPlayer.Properties.Resources.volume;
            this.buttonVideoVolume.Location = new System.Drawing.Point(631, 506);
            this.buttonVideoVolume.Name = "buttonVideoVolume";
            this.buttonVideoVolume.Size = new System.Drawing.Size(36, 36);
            this.buttonVideoVolume.TabIndex = 18;
            this.buttonVideoVolume.UseVisualStyleBackColor = true;
            // 
            // trackBarVideoVolume
            // 
            this.trackBarVideoVolume.Location = new System.Drawing.Point(673, 502);
            this.trackBarVideoVolume.Maximum = 100;
            this.trackBarVideoVolume.Name = "trackBarVideoVolume";
            this.trackBarVideoVolume.Size = new System.Drawing.Size(123, 45);
            this.trackBarVideoVolume.TabIndex = 20;
            this.trackBarVideoVolume.TickFrequency = 10;
            this.trackBarVideoVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarVideoVolume.Value = 50;
            this.trackBarVideoVolume.Scroll += new System.EventHandler(this.trackBarVideoVolume_Scroll);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(271, 174);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(525, 296);
            this.axWindowsMediaPlayer1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 567);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonVideoPrev);
            this.Controls.Add(this.buttonVideoPlay);
            this.Controls.Add(this.buttonVideoNext);
            this.Controls.Add(this.buttonVideoStop);
            this.Controls.Add(this.buttonVideoVolume);
            this.Controls.Add(this.trackBarVideoVolume);
            this.Controls.Add(this.trackBarVideoLength);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.groupBoxFiles);
            this.Controls.Add(this.groupBoxExplorer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Odtwarzacz wideo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBoxExplorer.ResumeLayout(false);
            this.groupBoxDirectories.ResumeLayout(false);
            this.groupBoxDirectory.ResumeLayout(false);
            this.groupBoxDirectory.PerformLayout();
            this.groupBoxFiles.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideoLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideoVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxExplorer;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.GroupBox groupBoxDirectories;
        private System.Windows.Forms.ListBox listBoxDirectory;
        private System.Windows.Forms.GroupBox groupBoxDirectory;
        private System.Windows.Forms.Button buttonDirectoryBrowse;
        private System.Windows.Forms.Button buttonDirectoryGo;
        private System.Windows.Forms.Button buttonDirectoryReset;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonExplorerOpenWindowsExplorer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonVideoPlay;
        private System.Windows.Forms.Button buttonVideoNext;
        private System.Windows.Forms.Button buttonVideoPrev;
        private System.Windows.Forms.Button buttonVideoStop;
        private System.Windows.Forms.TrackBar trackBarVideoLength;
        private System.Windows.Forms.Button buttonVideoVolume;
        private System.Windows.Forms.TrackBar trackBarVideoVolume;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timer;
    }
}

