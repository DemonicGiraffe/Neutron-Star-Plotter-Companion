﻿namespace NeutronStarPlotterCompanion
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Open = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Next_Data = new System.Windows.Forms.Button();
            this.previous_Data = new System.Windows.Forms.Button();
            this.Discord = new System.Windows.Forms.Button();
            this.Twitter = new System.Windows.Forms.Button();
            this.Youtube = new System.Windows.Forms.Button();
            this.Twitch = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Jumps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Open.ForeColor = System.Drawing.Color.White;
            this.Open.Location = new System.Drawing.Point(258, 7);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 0;
            this.Open.Text = "Browse";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(571, 202);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Next_Data
            // 
            this.Next_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Next_Data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next_Data.ForeColor = System.Drawing.Color.White;
            this.Next_Data.Location = new System.Drawing.Point(89, 243);
            this.Next_Data.Name = "Next_Data";
            this.Next_Data.Size = new System.Drawing.Size(75, 23);
            this.Next_Data.TabIndex = 3;
            this.Next_Data.Text = "Next";
            this.Next_Data.UseVisualStyleBackColor = false;
            this.Next_Data.Click += new System.EventHandler(this.Next_Data_Click);
            // 
            // previous_Data
            // 
            this.previous_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.previous_Data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previous_Data.ForeColor = System.Drawing.Color.White;
            this.previous_Data.Location = new System.Drawing.Point(8, 243);
            this.previous_Data.Name = "previous_Data";
            this.previous_Data.Size = new System.Drawing.Size(75, 23);
            this.previous_Data.TabIndex = 4;
            this.previous_Data.Text = "Previous";
            this.previous_Data.UseVisualStyleBackColor = false;
            this.previous_Data.Click += new System.EventHandler(this.previous_Data_Click);
            // 
            // Discord
            // 
            this.Discord.BackgroundImage = global::NeutronStarPlotterCompanion.Properties.Resources.Discord_new_logo;
            this.Discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Discord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Discord.Location = new System.Drawing.Point(559, 255);
            this.Discord.Name = "Discord";
            this.Discord.Size = new System.Drawing.Size(24, 24);
            this.Discord.TabIndex = 8;
            this.Discord.UseVisualStyleBackColor = true;
            this.Discord.Click += new System.EventHandler(this.Discord_Click);
            // 
            // Twitter
            // 
            this.Twitter.BackgroundImage = global::NeutronStarPlotterCompanion.Properties.Resources.twitter_PNG9;
            this.Twitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Twitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Twitter.Location = new System.Drawing.Point(529, 256);
            this.Twitter.Name = "Twitter";
            this.Twitter.Size = new System.Drawing.Size(24, 24);
            this.Twitter.TabIndex = 7;
            this.Twitter.UseVisualStyleBackColor = true;
            this.Twitter.Click += new System.EventHandler(this.Twitter_Click);
            // 
            // Youtube
            // 
            this.Youtube.BackgroundImage = global::NeutronStarPlotterCompanion.Properties.Resources.YouTube_icon_full_color;
            this.Youtube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Youtube.Location = new System.Drawing.Point(499, 256);
            this.Youtube.Name = "Youtube";
            this.Youtube.Size = new System.Drawing.Size(24, 24);
            this.Youtube.TabIndex = 6;
            this.Youtube.UseVisualStyleBackColor = true;
            this.Youtube.Click += new System.EventHandler(this.Youtube_Click);
            // 
            // Twitch
            // 
            this.Twitch.BackgroundImage = global::NeutronStarPlotterCompanion.Properties.Resources.twitch_logo_4931D91F85_seeklogo_com;
            this.Twitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Twitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Twitch.Location = new System.Drawing.Point(469, 256);
            this.Twitch.Name = "Twitch";
            this.Twitch.Size = new System.Drawing.Size(24, 24);
            this.Twitch.TabIndex = 5;
            this.Twitch.UseVisualStyleBackColor = true;
            this.Twitch.Click += new System.EventHandler(this.Twitch_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Orange;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(360, 240);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(223, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Credit to CMDR Spansh for powering this tool!";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Jumps
            // 
            this.Jumps.AutoSize = true;
            this.Jumps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jumps.ForeColor = System.Drawing.Color.Silver;
            this.Jumps.Location = new System.Drawing.Point(444, 7);
            this.Jumps.Name = "Jumps";
            this.Jumps.Size = new System.Drawing.Size(0, 20);
            this.Jumps.TabIndex = 10;
            this.Jumps.Click += new System.EventHandler(this.Jumps_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(339, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jumps Remaining:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(236, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(63, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 15);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Ready";
            this.textBox1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(13, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(5, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Developed by TheDemonicGiraffe 2020";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(206, 259);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(257, 20);
            this.textBox2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(595, 282);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jumps);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Discord);
            this.Controls.Add(this.Twitter);
            this.Controls.Add(this.Youtube);
            this.Controls.Add(this.Twitch);
            this.Controls.Add(this.previous_Data);
            this.Controls.Add(this.Next_Data);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Open);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Neutron-Star Plotter Companion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Next_Data;
        private System.Windows.Forms.Button previous_Data;
        private System.Windows.Forms.Button Twitch;
        private System.Windows.Forms.Button Youtube;
        private System.Windows.Forms.Button Twitter;
        private System.Windows.Forms.Button Discord;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Jumps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

