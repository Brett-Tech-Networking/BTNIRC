namespace BTN_IRC
{
    partial class BTNIRC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTNIRC));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("#lobby");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quickConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mangentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Channel = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.AddList = new MetroFramework.Controls.MetroButton();
            this.ChannelFav = new MetroFramework.Controls.MetroListView();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.PM = new MetroFramework.Controls.MetroButton();
            this.Whois = new MetroFramework.Controls.MetroButton();
            this.Ban = new MetroFramework.Controls.MetroButton();
            this.Kick = new MetroFramework.Controls.MetroButton();
            this.MessageBox = new MetroFramework.Controls.MetroTextBox();
            this.SendMessage = new MetroFramework.Controls.MetroButton();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickConnectToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1542, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quickConnectToolStripMenuItem
            // 
            this.quickConnectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quickConnectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quickConnectToolStripMenuItem.Image")));
            this.quickConnectToolStripMenuItem.Name = "quickConnectToolStripMenuItem";
            this.quickConnectToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.quickConnectToolStripMenuItem.Text = "Quick Connect";
            this.quickConnectToolStripMenuItem.Click += new System.EventHandler(this.QuickConnectToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themesToolStripMenuItem});
            this.themeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.themeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("themeToolStripMenuItem.Image")));
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.themeToolStripMenuItem.Text = "View";
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limeToolStripMenuItem1,
            this.blueToolStripMenuItem1,
            this.redToolStripMenuItem1,
            this.pinkToolStripMenuItem1,
            this.mangentaToolStripMenuItem,
            this.orangeToolStripMenuItem1});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // limeToolStripMenuItem1
            // 
            this.limeToolStripMenuItem1.Name = "limeToolStripMenuItem1";
            this.limeToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.limeToolStripMenuItem1.Text = "Lime";
            this.limeToolStripMenuItem1.Click += new System.EventHandler(this.LimeToolStripMenuItem1_Click);
            // 
            // blueToolStripMenuItem1
            // 
            this.blueToolStripMenuItem1.Name = "blueToolStripMenuItem1";
            this.blueToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.blueToolStripMenuItem1.Text = "Blue";
            this.blueToolStripMenuItem1.Click += new System.EventHandler(this.BlueToolStripMenuItem1_Click);
            // 
            // redToolStripMenuItem1
            // 
            this.redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            this.redToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.redToolStripMenuItem1.Text = "Red";
            this.redToolStripMenuItem1.Click += new System.EventHandler(this.RedToolStripMenuItem1_Click);
            // 
            // pinkToolStripMenuItem1
            // 
            this.pinkToolStripMenuItem1.Name = "pinkToolStripMenuItem1";
            this.pinkToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.pinkToolStripMenuItem1.Text = "Pink";
            this.pinkToolStripMenuItem1.Click += new System.EventHandler(this.PinkToolStripMenuItem1_Click);
            // 
            // mangentaToolStripMenuItem
            // 
            this.mangentaToolStripMenuItem.Name = "mangentaToolStripMenuItem";
            this.mangentaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mangentaToolStripMenuItem.Text = "Mangenta";
            this.mangentaToolStripMenuItem.Click += new System.EventHandler(this.MangentaToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem1
            // 
            this.orangeToolStripMenuItem1.Name = "orangeToolStripMenuItem1";
            this.orangeToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.orangeToolStripMenuItem1.Text = "Orange";
            this.orangeToolStripMenuItem1.Click += new System.EventHandler(this.OrangeToolStripMenuItem1_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Channel);
            this.metroTabControl1.Location = new System.Drawing.Point(164, 91);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1229, 650);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Channel
            // 
            this.Channel.HorizontalScrollbarBarColor = true;
            this.Channel.HorizontalScrollbarHighlightOnWheel = false;
            this.Channel.HorizontalScrollbarSize = 10;
            this.Channel.Location = new System.Drawing.Point(4, 38);
            this.Channel.Name = "Channel";
            this.Channel.Size = new System.Drawing.Size(1221, 608);
            this.Channel.Style = MetroFramework.MetroColorStyle.Lime;
            this.Channel.TabIndex = 0;
            this.Channel.Text = "#lobby";
            this.Channel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Channel.VerticalScrollbarBarColor = true;
            this.Channel.VerticalScrollbarHighlightOnWheel = false;
            this.Channel.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.AddList);
            this.metroPanel1.Controls.Add(this.ChannelFav);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 84);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(138, 696);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // AddList
            // 
            this.AddList.Location = new System.Drawing.Point(16, 663);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(75, 23);
            this.AddList.Style = MetroFramework.MetroColorStyle.Lime;
            this.AddList.TabIndex = 3;
            this.AddList.Text = "Add";
            this.AddList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AddList.UseSelectable = true;
            this.AddList.UseStyleColors = true;
            this.AddList.Click += new System.EventHandler(this.AddList_Click);
            // 
            // ChannelFav
            // 
            this.ChannelFav.AllowSorting = true;
            this.ChannelFav.BackColor = System.Drawing.Color.Black;
            this.ChannelFav.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChannelFav.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ChannelFav.ForeColor = System.Drawing.Color.Red;
            this.ChannelFav.FullRowSelect = true;
            this.ChannelFav.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.ChannelFav.Location = new System.Drawing.Point(0, 0);
            this.ChannelFav.Name = "ChannelFav";
            this.ChannelFav.OwnerDraw = true;
            this.ChannelFav.Size = new System.Drawing.Size(121, 696);
            this.ChannelFav.Style = MetroFramework.MetroColorStyle.Red;
            this.ChannelFav.TabIndex = 2;
            this.ChannelFav.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ChannelFav.UseCompatibleStateImageBehavior = false;
            this.ChannelFav.UseSelectable = true;
            this.ChannelFav.UseStyleColors = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.PM);
            this.metroPanel2.Controls.Add(this.Whois);
            this.metroPanel2.Controls.Add(this.Ban);
            this.metroPanel2.Controls.Add(this.Kick);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(1395, 84);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(167, 696);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // PM
            // 
            this.PM.Location = new System.Drawing.Point(29, 663);
            this.PM.Name = "PM";
            this.PM.Size = new System.Drawing.Size(104, 23);
            this.PM.Style = MetroFramework.MetroColorStyle.Yellow;
            this.PM.TabIndex = 2;
            this.PM.Text = "PM";
            this.PM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PM.UseSelectable = true;
            this.PM.UseStyleColors = true;
            // 
            // Whois
            // 
            this.Whois.Location = new System.Drawing.Point(29, 634);
            this.Whois.Name = "Whois";
            this.Whois.Size = new System.Drawing.Size(104, 23);
            this.Whois.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Whois.TabIndex = 2;
            this.Whois.Text = "Whois";
            this.Whois.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Whois.UseSelectable = true;
            this.Whois.UseStyleColors = true;
            // 
            // Ban
            // 
            this.Ban.Location = new System.Drawing.Point(29, 606);
            this.Ban.Name = "Ban";
            this.Ban.Size = new System.Drawing.Size(104, 23);
            this.Ban.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Ban.TabIndex = 2;
            this.Ban.Text = "Ban";
            this.Ban.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Ban.UseSelectable = true;
            this.Ban.UseStyleColors = true;
            // 
            // Kick
            // 
            this.Kick.Location = new System.Drawing.Point(29, 577);
            this.Kick.Name = "Kick";
            this.Kick.Size = new System.Drawing.Size(104, 23);
            this.Kick.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Kick.TabIndex = 2;
            this.Kick.Text = "Kick";
            this.Kick.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Kick.UseSelectable = true;
            this.Kick.UseStyleColors = true;
            this.Kick.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.MessageBox.CustomButton.Image = null;
            this.MessageBox.CustomButton.Location = new System.Drawing.Point(1060, 1);
            this.MessageBox.CustomButton.Name = "";
            this.MessageBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MessageBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MessageBox.CustomButton.TabIndex = 1;
            this.MessageBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MessageBox.CustomButton.UseSelectable = true;
            this.MessageBox.CustomButton.Visible = false;
            this.MessageBox.Lines = new string[0];
            this.MessageBox.Location = new System.Drawing.Point(219, 747);
            this.MessageBox.MaxLength = 32767;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.PasswordChar = '\0';
            this.MessageBox.PromptText = "Enter Text";
            this.MessageBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MessageBox.SelectedText = "";
            this.MessageBox.SelectionLength = 0;
            this.MessageBox.SelectionStart = 0;
            this.MessageBox.ShortcutsEnabled = true;
            this.MessageBox.Size = new System.Drawing.Size(1082, 23);
            this.MessageBox.Style = MetroFramework.MetroColorStyle.Red;
            this.MessageBox.TabIndex = 5;
            this.MessageBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MessageBox.UseSelectable = true;
            this.MessageBox.UseStyleColors = true;
            this.MessageBox.WaterMark = "Enter Text";
            this.MessageBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MessageBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(1305, 745);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(59, 27);
            this.SendMessage.Style = MetroFramework.MetroColorStyle.Red;
            this.SendMessage.TabIndex = 6;
            this.SendMessage.Text = "SEND";
            this.SendMessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SendMessage.UseSelectable = true;
            this.SendMessage.UseStyleColors = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::BTN_IRC.Properties.Resources.Smile;
            this.button1.Location = new System.Drawing.Point(171, 743);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 27);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BTNIRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 800);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BTNIRC";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "BTN IRC";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quickConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mangentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Channel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroListView ChannelFav;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton PM;
        private MetroFramework.Controls.MetroButton Whois;
        private MetroFramework.Controls.MetroButton Ban;
        private MetroFramework.Controls.MetroButton Kick;
        private MetroFramework.Controls.MetroButton AddList;
        private MetroFramework.Controls.MetroTextBox MessageBox;
        private MetroFramework.Controls.MetroButton SendMessage;
        private System.Windows.Forms.Button button1;
    }
}

