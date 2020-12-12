﻿namespace SuperShopMainV1._00
{
    partial class LoagingScreenFlashCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoagingScreenFlashCard));
            this.loadscreenpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loadpanelmain = new System.Windows.Forms.Panel();
            this.loadpanlesecond = new System.Windows.Forms.Panel();
            this.loadtimer = new System.Windows.Forms.Timer(this.components);
            this.loadscreenwelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadscreenpanel
            // 
            this.loadscreenpanel.BackColor = System.Drawing.Color.Transparent;
            this.loadscreenpanel.BackgroundImage = global::SuperShopMainV1._00.Properties.Resources.shoplogo1;
            this.loadscreenpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadscreenpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadscreenpanel.Location = new System.Drawing.Point(0, 0);
            this.loadscreenpanel.MaximumSize = new System.Drawing.Size(529, 113);
            this.loadscreenpanel.MinimumSize = new System.Drawing.Size(529, 113);
            this.loadscreenpanel.Name = "loadscreenpanel";
            this.loadscreenpanel.Size = new System.Drawing.Size(529, 113);
            this.loadscreenpanel.TabIndex = 0;
            this.loadscreenpanel.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version 1.00";
            // 
            // loadpanelmain
            // 
            this.loadpanelmain.BackColor = System.Drawing.Color.Transparent;
            this.loadpanelmain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadpanelmain.Location = new System.Drawing.Point(0, 285);
            this.loadpanelmain.Name = "loadpanelmain";
            this.loadpanelmain.Size = new System.Drawing.Size(529, 10);
            this.loadpanelmain.TabIndex = 2;
            // 
            // loadpanlesecond
            // 
            this.loadpanlesecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.loadpanlesecond.Location = new System.Drawing.Point(0, 285);
            this.loadpanlesecond.Name = "loadpanlesecond";
            this.loadpanlesecond.Size = new System.Drawing.Size(26, 10);
            this.loadpanlesecond.TabIndex = 3;
            // 
            // loadtimer
            // 
            this.loadtimer.Enabled = true;
            this.loadtimer.Interval = 15;
            this.loadtimer.Tick += new System.EventHandler(this.loadtimer_Tick);
            // 
            // loadscreenwelcome
            // 
            this.loadscreenwelcome.AutoSize = true;
            this.loadscreenwelcome.BackColor = System.Drawing.Color.Transparent;
            this.loadscreenwelcome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadscreenwelcome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadscreenwelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadscreenwelcome.Location = new System.Drawing.Point(170, 156);
            this.loadscreenwelcome.Name = "loadscreenwelcome";
            this.loadscreenwelcome.Size = new System.Drawing.Size(183, 41);
            this.loadscreenwelcome.TabIndex = 4;
            this.loadscreenwelcome.Text = "WELCOME";
            // 
            // LoagingScreenFlashCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperShopMainV1._00.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 295);
            this.Controls.Add(this.loadscreenwelcome);
            this.Controls.Add(this.loadpanlesecond);
            this.Controls.Add(this.loadpanelmain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadscreenpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(529, 295);
            this.MinimumSize = new System.Drawing.Size(529, 295);
            this.Name = "LoagingScreenFlashCard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoagingScreenFlashCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loadscreenpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel loadpanelmain;
        private System.Windows.Forms.Panel loadpanlesecond;
        private System.Windows.Forms.Timer loadtimer;
        private System.Windows.Forms.Label loadscreenwelcome;
    }
}