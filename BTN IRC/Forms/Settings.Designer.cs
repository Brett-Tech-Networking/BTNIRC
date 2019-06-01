namespace BTN_IRC.Forms
{
    partial class Settings
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
            this.Tabs = new MetroFramework.Controls.MetroTabControl();
            this.Main = new MetroFramework.Controls.MetroTabPage();
            this.CloseServersOnExit = new MetroFramework.Controls.MetroCheckBox();
            this.AutoRejoinKick = new MetroFramework.Controls.MetroCheckBox();
            this.WhoisOnQurey = new MetroFramework.Controls.MetroCheckBox();
            this.AutoJoinInvite = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox7 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox8 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox9 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox10 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox11 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox12 = new MetroFramework.Controls.MetroCheckBox();
            this.Language = new MetroFramework.Controls.MetroComboBox();
            this.Display = new MetroFramework.Controls.MetroTabPage();
            this.ShowEmojiTray = new MetroFramework.Controls.MetroCheckBox();
            this.ShowColorWheel = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox13 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox14 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox15 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox16 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox17 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox18 = new MetroFramework.Controls.MetroCheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tabs.SuspendLayout();
            this.Main.SuspendLayout();
            this.Display.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Main);
            this.Tabs.Controls.Add(this.Display);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(20, 60);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(700, 356);
            this.Tabs.Style = MetroFramework.MetroColorStyle.Red;
            this.Tabs.TabIndex = 1;
            this.Tabs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tabs.UseSelectable = true;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.Language);
            this.Main.Controls.Add(this.metroCheckBox12);
            this.Main.Controls.Add(this.metroCheckBox11);
            this.Main.Controls.Add(this.metroCheckBox6);
            this.Main.Controls.Add(this.metroCheckBox10);
            this.Main.Controls.Add(this.metroCheckBox5);
            this.Main.Controls.Add(this.metroCheckBox9);
            this.Main.Controls.Add(this.AutoJoinInvite);
            this.Main.Controls.Add(this.metroCheckBox8);
            this.Main.Controls.Add(this.WhoisOnQurey);
            this.Main.Controls.Add(this.metroCheckBox7);
            this.Main.Controls.Add(this.AutoRejoinKick);
            this.Main.Controls.Add(this.CloseServersOnExit);
            this.Main.HorizontalScrollbarBarColor = true;
            this.Main.HorizontalScrollbarHighlightOnWheel = false;
            this.Main.HorizontalScrollbarSize = 10;
            this.Main.Location = new System.Drawing.Point(4, 38);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(692, 314);
            this.Main.Style = MetroFramework.MetroColorStyle.Red;
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Main.VerticalScrollbarBarColor = true;
            this.Main.VerticalScrollbarHighlightOnWheel = false;
            this.Main.VerticalScrollbarSize = 10;
            // 
            // CloseServersOnExit
            // 
            this.CloseServersOnExit.AutoSize = true;
            this.CloseServersOnExit.Location = new System.Drawing.Point(41, 29);
            this.CloseServersOnExit.Name = "CloseServersOnExit";
            this.CloseServersOnExit.Size = new System.Drawing.Size(170, 15);
            this.CloseServersOnExit.Style = MetroFramework.MetroColorStyle.Red;
            this.CloseServersOnExit.TabIndex = 2;
            this.CloseServersOnExit.Text = "Ask To Close Servers On Exit";
            this.CloseServersOnExit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CloseServersOnExit.UseSelectable = true;
            // 
            // AutoRejoinKick
            // 
            this.AutoRejoinKick.AutoSize = true;
            this.AutoRejoinKick.Location = new System.Drawing.Point(41, 50);
            this.AutoRejoinKick.Name = "AutoRejoinKick";
            this.AutoRejoinKick.Size = new System.Drawing.Size(176, 15);
            this.AutoRejoinKick.Style = MetroFramework.MetroColorStyle.Red;
            this.AutoRejoinKick.TabIndex = 2;
            this.AutoRejoinKick.Text = "Auto Rejoin Channel On Kick";
            this.AutoRejoinKick.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutoRejoinKick.UseSelectable = true;
            // 
            // WhoisOnQurey
            // 
            this.WhoisOnQurey.AutoSize = true;
            this.WhoisOnQurey.Location = new System.Drawing.Point(41, 71);
            this.WhoisOnQurey.Name = "WhoisOnQurey";
            this.WhoisOnQurey.Size = new System.Drawing.Size(154, 15);
            this.WhoisOnQurey.Style = MetroFramework.MetroColorStyle.Red;
            this.WhoisOnQurey.TabIndex = 2;
            this.WhoisOnQurey.Text = "Preform Whois on Query";
            this.WhoisOnQurey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WhoisOnQurey.UseSelectable = true;
            // 
            // AutoJoinInvite
            // 
            this.AutoJoinInvite.AutoSize = true;
            this.AutoJoinInvite.Location = new System.Drawing.Point(41, 92);
            this.AutoJoinInvite.Name = "AutoJoinInvite";
            this.AutoJoinInvite.Size = new System.Drawing.Size(171, 15);
            this.AutoJoinInvite.Style = MetroFramework.MetroColorStyle.Red;
            this.AutoJoinInvite.TabIndex = 2;
            this.AutoJoinInvite.Text = "Auto Join Chennel On Invite";
            this.AutoJoinInvite.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutoJoinInvite.UseSelectable = true;
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.AutoSize = true;
            this.metroCheckBox5.Location = new System.Drawing.Point(41, 113);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox5.TabIndex = 2;
            this.metroCheckBox5.Text = "metroCheckBox1";
            this.metroCheckBox5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox5.UseSelectable = true;
            // 
            // metroCheckBox6
            // 
            this.metroCheckBox6.AutoSize = true;
            this.metroCheckBox6.Location = new System.Drawing.Point(41, 134);
            this.metroCheckBox6.Name = "metroCheckBox6";
            this.metroCheckBox6.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox6.TabIndex = 2;
            this.metroCheckBox6.Text = "metroCheckBox1";
            this.metroCheckBox6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox6.UseSelectable = true;
            // 
            // metroCheckBox7
            // 
            this.metroCheckBox7.AutoSize = true;
            this.metroCheckBox7.Location = new System.Drawing.Point(41, 152);
            this.metroCheckBox7.Name = "metroCheckBox7";
            this.metroCheckBox7.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox7.TabIndex = 2;
            this.metroCheckBox7.Text = "metroCheckBox1";
            this.metroCheckBox7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox7.UseSelectable = true;
            // 
            // metroCheckBox8
            // 
            this.metroCheckBox8.AutoSize = true;
            this.metroCheckBox8.Location = new System.Drawing.Point(41, 173);
            this.metroCheckBox8.Name = "metroCheckBox8";
            this.metroCheckBox8.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox8.TabIndex = 2;
            this.metroCheckBox8.Text = "metroCheckBox1";
            this.metroCheckBox8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox8.UseSelectable = true;
            // 
            // metroCheckBox9
            // 
            this.metroCheckBox9.AutoSize = true;
            this.metroCheckBox9.Location = new System.Drawing.Point(41, 194);
            this.metroCheckBox9.Name = "metroCheckBox9";
            this.metroCheckBox9.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox9.TabIndex = 2;
            this.metroCheckBox9.Text = "metroCheckBox1";
            this.metroCheckBox9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox9.UseSelectable = true;
            // 
            // metroCheckBox10
            // 
            this.metroCheckBox10.AutoSize = true;
            this.metroCheckBox10.Location = new System.Drawing.Point(41, 215);
            this.metroCheckBox10.Name = "metroCheckBox10";
            this.metroCheckBox10.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox10.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox10.TabIndex = 2;
            this.metroCheckBox10.Text = "metroCheckBox1";
            this.metroCheckBox10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox10.UseSelectable = true;
            // 
            // metroCheckBox11
            // 
            this.metroCheckBox11.AutoSize = true;
            this.metroCheckBox11.Location = new System.Drawing.Point(41, 236);
            this.metroCheckBox11.Name = "metroCheckBox11";
            this.metroCheckBox11.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox11.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox11.TabIndex = 2;
            this.metroCheckBox11.Text = "metroCheckBox1";
            this.metroCheckBox11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox11.UseSelectable = true;
            // 
            // metroCheckBox12
            // 
            this.metroCheckBox12.AutoSize = true;
            this.metroCheckBox12.Location = new System.Drawing.Point(41, 257);
            this.metroCheckBox12.Name = "metroCheckBox12";
            this.metroCheckBox12.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox12.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox12.TabIndex = 2;
            this.metroCheckBox12.Text = "metroCheckBox1";
            this.metroCheckBox12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox12.UseSelectable = true;
            // 
            // Language
            // 
            this.Language.FormattingEnabled = true;
            this.Language.ItemHeight = 23;
            this.Language.Location = new System.Drawing.Point(41, 289);
            this.Language.Name = "Language";
            this.Language.PromptText = "Choose Language";
            this.Language.Size = new System.Drawing.Size(218, 29);
            this.Language.TabIndex = 3;
            this.Language.UseSelectable = true;
            // 
            // Display
            // 
            this.Display.Controls.Add(this.statusStrip1);
            this.Display.Controls.Add(this.metroCheckBox18);
            this.Display.Controls.Add(this.metroCheckBox17);
            this.Display.Controls.Add(this.metroCheckBox13);
            this.Display.Controls.Add(this.metroCheckBox16);
            this.Display.Controls.Add(this.metroCheckBox4);
            this.Display.Controls.Add(this.metroCheckBox15);
            this.Display.Controls.Add(this.metroCheckBox3);
            this.Display.Controls.Add(this.metroCheckBox14);
            this.Display.Controls.Add(this.ShowColorWheel);
            this.Display.Controls.Add(this.ShowEmojiTray);
            this.Display.HorizontalScrollbarBarColor = true;
            this.Display.HorizontalScrollbarHighlightOnWheel = false;
            this.Display.HorizontalScrollbarSize = 10;
            this.Display.Location = new System.Drawing.Point(4, 38);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(692, 314);
            this.Display.Style = MetroFramework.MetroColorStyle.Red;
            this.Display.TabIndex = 1;
            this.Display.Text = "Display";
            this.Display.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Display.VerticalScrollbarBarColor = true;
            this.Display.VerticalScrollbarHighlightOnWheel = false;
            this.Display.VerticalScrollbarSize = 10;
            // 
            // ShowEmojiTray
            // 
            this.ShowEmojiTray.AutoSize = true;
            this.ShowEmojiTray.Location = new System.Drawing.Point(51, 36);
            this.ShowEmojiTray.Name = "ShowEmojiTray";
            this.ShowEmojiTray.Size = new System.Drawing.Size(110, 15);
            this.ShowEmojiTray.Style = MetroFramework.MetroColorStyle.Red;
            this.ShowEmojiTray.TabIndex = 2;
            this.ShowEmojiTray.Text = "Show Emoji Tray";
            this.ShowEmojiTray.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ShowEmojiTray.UseSelectable = true;
            // 
            // ShowColorWheel
            // 
            this.ShowColorWheel.AutoSize = true;
            this.ShowColorWheel.Location = new System.Drawing.Point(51, 57);
            this.ShowColorWheel.Name = "ShowColorWheel";
            this.ShowColorWheel.Size = new System.Drawing.Size(120, 15);
            this.ShowColorWheel.Style = MetroFramework.MetroColorStyle.Red;
            this.ShowColorWheel.TabIndex = 2;
            this.ShowColorWheel.Text = "Show Color Wheel";
            this.ShowColorWheel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ShowColorWheel.UseSelectable = true;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Location = new System.Drawing.Point(51, 78);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(138, 15);
            this.metroCheckBox3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox3.TabIndex = 2;
            this.metroCheckBox3.Text = "Host Mode (Nick List)";
            this.metroCheckBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox3.UseSelectable = true;
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Location = new System.Drawing.Point(51, 99);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox4.TabIndex = 2;
            this.metroCheckBox4.Text = "metroCheckBox1";
            this.metroCheckBox4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox4.UseSelectable = true;
            // 
            // metroCheckBox13
            // 
            this.metroCheckBox13.AutoSize = true;
            this.metroCheckBox13.Location = new System.Drawing.Point(51, 120);
            this.metroCheckBox13.Name = "metroCheckBox13";
            this.metroCheckBox13.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox13.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox13.TabIndex = 2;
            this.metroCheckBox13.Text = "metroCheckBox1";
            this.metroCheckBox13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox13.UseSelectable = true;
            // 
            // metroCheckBox14
            // 
            this.metroCheckBox14.AutoSize = true;
            this.metroCheckBox14.Location = new System.Drawing.Point(51, 138);
            this.metroCheckBox14.Name = "metroCheckBox14";
            this.metroCheckBox14.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox14.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox14.TabIndex = 2;
            this.metroCheckBox14.Text = "metroCheckBox1";
            this.metroCheckBox14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox14.UseSelectable = true;
            // 
            // metroCheckBox15
            // 
            this.metroCheckBox15.AutoSize = true;
            this.metroCheckBox15.Location = new System.Drawing.Point(51, 159);
            this.metroCheckBox15.Name = "metroCheckBox15";
            this.metroCheckBox15.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox15.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox15.TabIndex = 2;
            this.metroCheckBox15.Text = "metroCheckBox1";
            this.metroCheckBox15.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox15.UseSelectable = true;
            // 
            // metroCheckBox16
            // 
            this.metroCheckBox16.AutoSize = true;
            this.metroCheckBox16.Location = new System.Drawing.Point(51, 180);
            this.metroCheckBox16.Name = "metroCheckBox16";
            this.metroCheckBox16.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox16.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox16.TabIndex = 2;
            this.metroCheckBox16.Text = "metroCheckBox1";
            this.metroCheckBox16.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox16.UseSelectable = true;
            // 
            // metroCheckBox17
            // 
            this.metroCheckBox17.AutoSize = true;
            this.metroCheckBox17.Location = new System.Drawing.Point(51, 201);
            this.metroCheckBox17.Name = "metroCheckBox17";
            this.metroCheckBox17.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox17.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox17.TabIndex = 2;
            this.metroCheckBox17.Text = "metroCheckBox1";
            this.metroCheckBox17.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox17.UseSelectable = true;
            // 
            // metroCheckBox18
            // 
            this.metroCheckBox18.AutoSize = true;
            this.metroCheckBox18.Location = new System.Drawing.Point(51, 222);
            this.metroCheckBox18.Name = "metroCheckBox18";
            this.metroCheckBox18.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox18.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox18.TabIndex = 2;
            this.metroCheckBox18.Text = "metroCheckBox1";
            this.metroCheckBox18.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox18.UseSelectable = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(692, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 436);
            this.Controls.Add(this.Tabs);
            this.Name = "Settings";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Tabs.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.Display.ResumeLayout(false);
            this.Display.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tabs;
        private MetroFramework.Controls.MetroTabPage Main;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox12;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox11;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox10;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox5;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox9;
        private MetroFramework.Controls.MetroCheckBox AutoJoinInvite;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox8;
        private MetroFramework.Controls.MetroCheckBox WhoisOnQurey;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox7;
        private MetroFramework.Controls.MetroCheckBox AutoRejoinKick;
        private MetroFramework.Controls.MetroCheckBox CloseServersOnExit;
        private MetroFramework.Controls.MetroComboBox Language;
        private MetroFramework.Controls.MetroTabPage Display;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox18;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox17;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox13;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox16;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox15;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox14;
        private MetroFramework.Controls.MetroCheckBox ShowColorWheel;
        private MetroFramework.Controls.MetroCheckBox ShowEmojiTray;
    }
}