namespace money_tracker
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSetting = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPlots = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonList = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonQuit = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonHome = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ButtonRefresh);
            this.panel1.Controls.Add(this.ButtonSetting);
            this.panel1.Controls.Add(this.ButtonPlots);
            this.panel1.Controls.Add(this.ButtonList);
            this.panel1.Controls.Add(this.ButtonQuit);
            this.panel1.Controls.Add(this.ButtonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 864);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRefresh.ForeColor = System.Drawing.Color.White;
            this.ButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRefresh.Image")));
            this.ButtonRefresh.ImageSize = new System.Drawing.Size(40, 35);
            this.ButtonRefresh.Location = new System.Drawing.Point(50, 580);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(62, 55);
            this.ButtonRefresh.TabIndex = 3;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonSetting
            // 
            this.ButtonSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSetting.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSetting.ForeColor = System.Drawing.Color.White;
            this.ButtonSetting.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSetting.Image")));
            this.ButtonSetting.Location = new System.Drawing.Point(15, 480);
            this.ButtonSetting.Name = "ButtonSetting";
            this.ButtonSetting.Size = new System.Drawing.Size(100, 70);
            this.ButtonSetting.TabIndex = 2;
            this.ButtonSetting.Text = "Settings";
            this.ButtonSetting.Click += new System.EventHandler(this.ButtonSetting_Click);
            // 
            // ButtonPlots
            // 
            this.ButtonPlots.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPlots.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPlots.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonPlots.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonPlots.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlots.ForeColor = System.Drawing.Color.White;
            this.ButtonPlots.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPlots.Image")));
            this.ButtonPlots.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonPlots.Location = new System.Drawing.Point(15, 280);
            this.ButtonPlots.Name = "ButtonPlots";
            this.ButtonPlots.Size = new System.Drawing.Size(100, 70);
            this.ButtonPlots.TabIndex = 1;
            this.ButtonPlots.Text = "Plots";
            this.ButtonPlots.Click += new System.EventHandler(this.ButtonPlots_Click);
            // 
            // ButtonList
            // 
            this.ButtonList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonList.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonList.ForeColor = System.Drawing.Color.White;
            this.ButtonList.Image = ((System.Drawing.Image)(resources.GetObject("ButtonList.Image")));
            this.ButtonList.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonList.Location = new System.Drawing.Point(15, 380);
            this.ButtonList.Name = "ButtonList";
            this.ButtonList.Size = new System.Drawing.Size(100, 70);
            this.ButtonList.TabIndex = 0;
            this.ButtonList.Text = "List";
            this.ButtonList.Click += new System.EventHandler(this.ButtonList_Click);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonQuit.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuit.ForeColor = System.Drawing.Color.White;
            this.ButtonQuit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonQuit.Image")));
            this.ButtonQuit.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonQuit.Location = new System.Drawing.Point(22, 739);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(94, 78);
            this.ButtonQuit.TabIndex = 0;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonHome.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.White;
            this.ButtonHome.Image = ((System.Drawing.Image)(resources.GetObject("ButtonHome.Image")));
            this.ButtonHome.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonHome.Location = new System.Drawing.Point(15, 180);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(100, 70);
            this.ButtonHome.TabIndex = 0;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(133, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1342, 864);
            this.panelContainer.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1475, 864);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button ButtonQuit;
        private Guna.UI2.WinForms.Guna2Button ButtonHome;
        private Guna.UI2.WinForms.Guna2Button ButtonList;
        private Guna.UI2.WinForms.Guna2Button ButtonPlots;
        private Guna.UI2.WinForms.Guna2Button ButtonSetting;
        private Guna.UI2.WinForms.Guna2Button ButtonRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

