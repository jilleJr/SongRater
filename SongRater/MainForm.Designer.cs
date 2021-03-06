namespace SongRater
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.button1 = new System.Windows.Forms.Button();
			this.songPage1 = new SongRater.SongPage();
			this.button2 = new System.Windows.Forms.Button();
			this.songPage2 = new SongRater.SongPage();
			this.scoreListBox = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.repeatButtonLowest = new SongRater.RepeatButton();
			this.repeatButtonHighest = new SongRater.RepeatButton();
			this.repeatButtonRandom = new SongRater.RepeatButton();
			this.songGraph1 = new SongRater.SongGraph();
			this.folderTextBox1 = new SongRater.FolderTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Folder";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(3, 43);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			this.splitContainer1.Panel1.Controls.Add(this.songPage1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.button2);
			this.splitContainer1.Panel2.Controls.Add(this.songPage2);
			this.splitContainer1.Size = new System.Drawing.Size(290, 74);
			this.splitContainer1.SplitterDistance = 142;
			this.splitContainer1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(0, 51);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Upvote";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// songPage1
			// 
			this.songPage1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.songPage1.Location = new System.Drawing.Point(0, 0);
			this.songPage1.Name = "songPage1";
			this.songPage1.Size = new System.Drawing.Size(142, 74);
			this.songPage1.Song = null;
			this.songPage1.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(0, 51);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(145, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Upvote";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// songPage2
			// 
			this.songPage2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.songPage2.Location = new System.Drawing.Point(0, 0);
			this.songPage2.Name = "songPage2";
			this.songPage2.Size = new System.Drawing.Size(144, 74);
			this.songPage2.Song = null;
			this.songPage2.TabIndex = 0;
			// 
			// scoreListBox
			// 
			this.scoreListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.scoreListBox.FormattingEnabled = true;
			this.scoreListBox.IntegralHeight = false;
			this.scoreListBox.Location = new System.Drawing.Point(3, 16);
			this.scoreListBox.Name = "scoreListBox";
			this.scoreListBox.Size = new System.Drawing.Size(294, 289);
			this.scoreListBox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Current standings";
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(12, 12);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.repeatButtonLowest);
			this.splitContainer2.Panel1.Controls.Add(this.repeatButtonHighest);
			this.splitContainer2.Panel1.Controls.Add(this.repeatButtonRandom);
			this.splitContainer2.Panel1.Controls.Add(this.songGraph1);
			this.splitContainer2.Panel1.Controls.Add(this.folderTextBox1);
			this.splitContainer2.Panel1.Controls.Add(this.label1);
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.scoreListBox);
			this.splitContainer2.Panel2.Controls.Add(this.label2);
			this.splitContainer2.Size = new System.Drawing.Size(594, 305);
			this.splitContainer2.SplitterDistance = 293;
			this.splitContainer2.TabIndex = 7;
			// 
			// repeatButtonLowest
			// 
			this.repeatButtonLowest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.repeatButtonLowest.Enabled = false;
			this.repeatButtonLowest.Interval = System.TimeSpan.Parse("00:00:00.0100000");
			this.repeatButtonLowest.Location = new System.Drawing.Point(2, 123);
			this.repeatButtonLowest.Name = "repeatButtonLowest";
			this.repeatButtonLowest.Size = new System.Drawing.Size(93, 23);
			this.repeatButtonLowest.TabIndex = 6;
			this.repeatButtonLowest.Text = "Spam lowest";
			this.repeatButtonLowest.UseVisualStyleBackColor = true;
			this.repeatButtonLowest.Depressed += new System.EventHandler(this.repeatButtonLowest_Depressed);
			// 
			// repeatButtonHighest
			// 
			this.repeatButtonHighest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.repeatButtonHighest.Enabled = false;
			this.repeatButtonHighest.Interval = System.TimeSpan.Parse("00:00:00.0100000");
			this.repeatButtonHighest.Location = new System.Drawing.Point(101, 123);
			this.repeatButtonHighest.Name = "repeatButtonHighest";
			this.repeatButtonHighest.Size = new System.Drawing.Size(93, 23);
			this.repeatButtonHighest.TabIndex = 5;
			this.repeatButtonHighest.Text = "Spam highest";
			this.repeatButtonHighest.UseVisualStyleBackColor = true;
			this.repeatButtonHighest.Depressed += new System.EventHandler(this.repeatButtonHighest_Depressed);
			// 
			// repeatButtonRandom
			// 
			this.repeatButtonRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.repeatButtonRandom.Enabled = false;
			this.repeatButtonRandom.Interval = System.TimeSpan.Parse("00:00:00.0100000");
			this.repeatButtonRandom.Location = new System.Drawing.Point(200, 123);
			this.repeatButtonRandom.Name = "repeatButtonRandom";
			this.repeatButtonRandom.Size = new System.Drawing.Size(93, 23);
			this.repeatButtonRandom.TabIndex = 4;
			this.repeatButtonRandom.Text = "Spam random";
			this.repeatButtonRandom.UseVisualStyleBackColor = true;
			this.repeatButtonRandom.Depressed += new System.EventHandler(this.repeatButtonRandom_Depressed);
			// 
			// songGraph1
			// 
			this.songGraph1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.songGraph1.BackColor = System.Drawing.SystemColors.Window;
			this.songGraph1.Location = new System.Drawing.Point(3, 150);
			this.songGraph1.Name = "songGraph1";
			this.songGraph1.Size = new System.Drawing.Size(287, 155);
			this.songGraph1.TabIndex = 3;
			// 
			// folderTextBox1
			// 
			this.folderTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.folderTextBox1.Location = new System.Drawing.Point(0, 16);
			this.folderTextBox1.Name = "folderTextBox1";
			this.folderTextBox1.Size = new System.Drawing.Size(293, 21);
			this.folderTextBox1.TabIndex = 0;
			this.folderTextBox1.SelectedPathChanged += new System.EventHandler(this.folderTextBox1_SelectedPathChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 329);
			this.Controls.Add(this.splitContainer2);
			this.DoubleBuffered = true;
			this.MinimumSize = new System.Drawing.Size(634, 368);
			this.Name = "MainForm";
			this.Text = "Song Rater";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private FolderTextBox folderTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private SongPage songPage1;
		private SongPage songPage2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox scoreListBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private SongGraph songGraph1;
		private RepeatButton repeatButtonRandom;
		private RepeatButton repeatButtonHighest;
		private RepeatButton repeatButtonLowest;
	}
}

