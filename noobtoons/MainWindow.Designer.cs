// This is the ugly forms delagating madness that normally gets modified by 
// the VS.NET forms builder. 
// Copyright (C) 2008  Puyan Lotfi
// plotfi@gmail.com
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

namespace noobtoons {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.info_tab_view = new System.Windows.Forms.TabControl();
            this.media_library_tab = new System.Windows.Forms.TabPage();
            this.playlist__control_panel = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.previous_button = new System.Windows.Forms.ToolStripButton();
            this.play_button = new System.Windows.Forms.ToolStripButton();
            this.playpause_button = new System.Windows.Forms.ToolStripButton();
            this.stop_button = new System.Windows.Forms.ToolStripButton();
            this.next_button = new System.Windows.Forms.ToolStripButton();
            this.volume_slider = new System.Windows.Forms.TrackBar();
            this.playlist_view = new System.Windows.Forms.ListView();
            this.track = new System.Windows.Forms.ColumnHeader();
            this.title = new System.Windows.Forms.ColumnHeader();
            this.album = new System.Windows.Forms.ColumnHeader();
            this.artist = new System.Windows.Forms.ColumnHeader();
            this.codec = new System.Windows.Forms.ColumnHeader();
            this.path = new System.Windows.Forms.ColumnHeader();
            this.seek_slider = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.info_tab_view.SuspendLayout();
            this.media_library_tab.SuspendLayout();
            this.playlist__control_panel.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seek_slider)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(968, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // filesToolStripMenuItem1
            // 
            this.filesToolStripMenuItem1.Name = "filesToolStripMenuItem1";
            this.filesToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.filesToolStripMenuItem1.Text = "Files";
            this.filesToolStripMenuItem1.Click += new System.EventHandler(this.filesToolStripMenuItem1_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.info_tab_view);
            this.splitContainer1.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.playlist__control_panel);
            this.splitContainer1.Size = new System.Drawing.Size(968, 504);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // info_tab_view
            // 
            this.info_tab_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.info_tab_view.Controls.Add(this.media_library_tab);
            this.info_tab_view.Location = new System.Drawing.Point(12, 8);
            this.info_tab_view.Name = "info_tab_view";
            this.info_tab_view.SelectedIndex = 0;
            this.info_tab_view.Size = new System.Drawing.Size(307, 486);
            this.info_tab_view.TabIndex = 5;
            this.info_tab_view.SelectedIndexChanged += new System.EventHandler(this.info_tab_view_SelectedIndexChanged);
            // 
            // media_library_tab
            // 
            this.media_library_tab.Controls.Add(this.webBrowser1);
            this.media_library_tab.Location = new System.Drawing.Point(4, 22);
            this.media_library_tab.Name = "media_library_tab";
            this.media_library_tab.Padding = new System.Windows.Forms.Padding(3);
            this.media_library_tab.Size = new System.Drawing.Size(299, 460);
            this.media_library_tab.TabIndex = 0;
            this.media_library_tab.Text = "Media Library";
            this.media_library_tab.UseVisualStyleBackColor = true;
            // 
            // playlist__control_panel
            // 
            this.playlist__control_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.playlist__control_panel.Controls.Add(this.splitContainer2);
            this.playlist__control_panel.Controls.Add(this.playlist_view);
            this.playlist__control_panel.Location = new System.Drawing.Point(3, 8);
            this.playlist__control_panel.Name = "playlist__control_panel";
            this.playlist__control_panel.Size = new System.Drawing.Size(627, 486);
            this.playlist__control_panel.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(4, 444);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.volume_slider);
            this.splitContainer2.Size = new System.Drawing.Size(620, 38);
            this.splitContainer2.SplitterDistance = 439;
            this.splitContainer2.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previous_button,
            this.play_button,
            this.playpause_button,
            this.stop_button,
            this.next_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(439, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // previous_button
            // 
            this.previous_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.previous_button.Image = ((System.Drawing.Image)(resources.GetObject("previous_button.Image")));
            this.previous_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(23, 29);
            this.previous_button.Text = "Previous";
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // play_button
            // 
            this.play_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.play_button.Image = ((System.Drawing.Image)(resources.GetObject("play_button.Image")));
            this.play_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(23, 29);
            this.play_button.Text = "Play";
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // playpause_button
            // 
            this.playpause_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playpause_button.Image = ((System.Drawing.Image)(resources.GetObject("playpause_button.Image")));
            this.playpause_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playpause_button.Name = "playpause_button";
            this.playpause_button.Size = new System.Drawing.Size(23, 29);
            this.playpause_button.Text = "Pause";
            this.playpause_button.Click += new System.EventHandler(this.playpause_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stop_button.Image = ((System.Drawing.Image)(resources.GetObject("stop_button.Image")));
            this.stop_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(23, 29);
            this.stop_button.Text = "Stop";
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // next_button
            // 
            this.next_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.next_button.Image = ((System.Drawing.Image)(resources.GetObject("next_button.Image")));
            this.next_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(23, 29);
            this.next_button.Text = "Next";
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // volume_slider
            // 
            this.volume_slider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.volume_slider.AutoSize = false;
            this.volume_slider.Location = new System.Drawing.Point(3, 3);
            this.volume_slider.Maximum = 100;
            this.volume_slider.Name = "volume_slider";
            this.volume_slider.Size = new System.Drawing.Size(171, 32);
            this.volume_slider.TabIndex = 11;
            this.volume_slider.Scroll += new System.EventHandler(this.volume_slider_Scroll);
            // 
            // playlist_view
            // 
            this.playlist_view.AllowColumnReorder = true;
            this.playlist_view.AllowDrop = true;
            this.playlist_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.playlist_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.track,
            this.title,
            this.album,
            this.artist,
            this.codec,
            this.path});
            this.playlist_view.FullRowSelect = true;
            this.playlist_view.HideSelection = false;
            this.playlist_view.Location = new System.Drawing.Point(4, 3);
            this.playlist_view.Name = "playlist_view";
            this.playlist_view.Size = new System.Drawing.Size(620, 435);
            this.playlist_view.TabIndex = 10;
            this.playlist_view.UseCompatibleStateImageBehavior = false;
            this.playlist_view.View = System.Windows.Forms.View.Details;
            this.playlist_view.DoubleClick += new System.EventHandler(this.play_button_Click);
            // 
            // track
            // 
            this.track.Text = "Track #";
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 120;
            // 
            // album
            // 
            this.album.Text = "Album";
            this.album.Width = 100;
            // 
            // artist
            // 
            this.artist.Text = "Artist";
            this.artist.Width = 80;
            // 
            // codec
            // 
            this.codec.Text = "Type";
            // 
            // path
            // 
            this.path.Text = "Path";
            // 
            // seek_slider
            // 
            this.seek_slider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.seek_slider.AutoSize = false;
            this.seek_slider.Location = new System.Drawing.Point(609, 528);
            this.seek_slider.Maximum = 10000;
            this.seek_slider.Name = "seek_slider";
            this.seek_slider.Size = new System.Drawing.Size(341, 22);
            this.seek_slider.TabIndex = 12;
            this.seek_slider.Scroll += new System.EventHandler(this.seek_slider_Scroll);
            this.seek_slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.seek_slider_MouseDown);
            this.seek_slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.seek_slider_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(293, 454);
            this.webBrowser1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 550);
            this.Controls.Add(this.seek_slider);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "MainWindow";
            this.Text = "noob toons";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.info_tab_view.ResumeLayout(false);
            this.media_library_tab.ResumeLayout(false);
            this.playlist__control_panel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seek_slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl info_tab_view;
        private System.Windows.Forms.TabPage media_library_tab;
        private System.Windows.Forms.Panel playlist__control_panel;
        private System.Windows.Forms.ListView playlist_view;
        private System.Windows.Forms.ColumnHeader track;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader album;
        private System.Windows.Forms.ColumnHeader artist;
        private System.Windows.Forms.ColumnHeader codec;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.TrackBar volume_slider;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton previous_button;
        private System.Windows.Forms.ToolStripButton play_button;
        private System.Windows.Forms.ToolStripButton playpause_button;
        private System.Windows.Forms.ToolStripButton stop_button;
        private System.Windows.Forms.ToolStripButton next_button;
        private System.Windows.Forms.TrackBar seek_slider;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

