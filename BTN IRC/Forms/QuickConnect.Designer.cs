namespace BTN_IRC.Forms
{
    partial class QuickConnect
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
            this.ServerLabel = new MetroFramework.Controls.MetroLabel();
            this.ServerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NickLabel = new MetroFramework.Controls.MetroLabel();
            this.NickTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ChannelLabel = new MetroFramework.Controls.MetroLabel();
            this.ChannelsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ConnectButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(33, 82);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(51, 19);
            this.ServerLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Server:";
            this.ServerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ServerLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ServerTextBox
            // 
            // 
            // 
            // 
            this.ServerTextBox.CustomButton.Image = null;
            this.ServerTextBox.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.ServerTextBox.CustomButton.Name = "";
            this.ServerTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ServerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ServerTextBox.CustomButton.TabIndex = 1;
            this.ServerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ServerTextBox.CustomButton.UseSelectable = true;
            this.ServerTextBox.CustomButton.Visible = false;
            this.ServerTextBox.Lines = new string[0];
            this.ServerTextBox.Location = new System.Drawing.Point(90, 82);
            this.ServerTextBox.MaxLength = 32767;
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.PasswordChar = '\0';
            this.ServerTextBox.PromptText = "Irc.ThePlaceToChat.net";
            this.ServerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServerTextBox.SelectedText = "";
            this.ServerTextBox.SelectionLength = 0;
            this.ServerTextBox.SelectionStart = 0;
            this.ServerTextBox.ShortcutsEnabled = true;
            this.ServerTextBox.Size = new System.Drawing.Size(335, 23);
            this.ServerTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.ServerTextBox.TabIndex = 1;
            this.ServerTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ServerTextBox.UseSelectable = true;
            this.ServerTextBox.WaterMark = "Irc.ThePlaceToChat.net";
            this.ServerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ServerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NickLabel
            // 
            this.NickLabel.AutoSize = true;
            this.NickLabel.Location = new System.Drawing.Point(47, 112);
            this.NickLabel.Name = "NickLabel";
            this.NickLabel.Size = new System.Drawing.Size(37, 19);
            this.NickLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.NickLabel.TabIndex = 0;
            this.NickLabel.Text = "Nick:";
            this.NickLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.NickLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NickLabel.Click += new System.EventHandler(this.NickLabel_Click);
            // 
            // NickTextBox
            // 
            // 
            // 
            // 
            this.NickTextBox.CustomButton.Image = null;
            this.NickTextBox.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.NickTextBox.CustomButton.Name = "";
            this.NickTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NickTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NickTextBox.CustomButton.TabIndex = 1;
            this.NickTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NickTextBox.CustomButton.UseSelectable = true;
            this.NickTextBox.CustomButton.Visible = false;
            this.NickTextBox.Lines = new string[0];
            this.NickTextBox.Location = new System.Drawing.Point(90, 111);
            this.NickTextBox.MaxLength = 20;
            this.NickTextBox.Name = "NickTextBox";
            this.NickTextBox.PasswordChar = '\0';
            this.NickTextBox.PromptText = "CoolDude";
            this.NickTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NickTextBox.SelectedText = "";
            this.NickTextBox.SelectionLength = 0;
            this.NickTextBox.SelectionStart = 0;
            this.NickTextBox.ShortcutsEnabled = true;
            this.NickTextBox.Size = new System.Drawing.Size(335, 23);
            this.NickTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.NickTextBox.TabIndex = 2;
            this.NickTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NickTextBox.UseSelectable = true;
            this.NickTextBox.WaterMark = "CoolDude";
            this.NickTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NickTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Location = new System.Drawing.Point(15, 140);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(72, 19);
            this.ChannelLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChannelLabel.TabIndex = 0;
            this.ChannelLabel.Text = "Channel(s):";
            this.ChannelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ChannelLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ChannelsTextBox
            // 
            // 
            // 
            // 
            this.ChannelsTextBox.CustomButton.Image = null;
            this.ChannelsTextBox.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.ChannelsTextBox.CustomButton.Name = "";
            this.ChannelsTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ChannelsTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChannelsTextBox.CustomButton.TabIndex = 1;
            this.ChannelsTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChannelsTextBox.CustomButton.UseSelectable = true;
            this.ChannelsTextBox.CustomButton.Visible = false;
            this.ChannelsTextBox.Lines = new string[0];
            this.ChannelsTextBox.Location = new System.Drawing.Point(90, 140);
            this.ChannelsTextBox.MaxLength = 32767;
            this.ChannelsTextBox.Name = "ChannelsTextBox";
            this.ChannelsTextBox.PasswordChar = '\0';
            this.ChannelsTextBox.PromptText = "#Lobby,#Support";
            this.ChannelsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChannelsTextBox.SelectedText = "";
            this.ChannelsTextBox.SelectionLength = 0;
            this.ChannelsTextBox.SelectionStart = 0;
            this.ChannelsTextBox.ShortcutsEnabled = true;
            this.ChannelsTextBox.Size = new System.Drawing.Size(335, 23);
            this.ChannelsTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChannelsTextBox.TabIndex = 3;
            this.ChannelsTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ChannelsTextBox.UseSelectable = true;
            this.ChannelsTextBox.WaterMark = "#Lobby,#Support";
            this.ChannelsTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ChannelsTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(350, 169);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ConnectButton.UseSelectable = true;
            // 
            // QuickConnect
            // 
            this.AcceptButton = this.ConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 208);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ChannelsTextBox);
            this.Controls.Add(this.ChannelLabel);
            this.Controls.Add(this.NickTextBox);
            this.Controls.Add(this.NickLabel);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.ServerLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 208);
            this.MinimumSize = new System.Drawing.Size(442, 208);
            this.Name = "QuickConnect";
            this.Text = "QuickConnect";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.QuickConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ServerLabel;
        private MetroFramework.Controls.MetroTextBox ServerTextBox;
        private MetroFramework.Controls.MetroLabel NickLabel;
        private MetroFramework.Controls.MetroTextBox NickTextBox;
        private MetroFramework.Controls.MetroLabel ChannelLabel;
        private MetroFramework.Controls.MetroTextBox ChannelsTextBox;
        private MetroFramework.Controls.MetroButton ConnectButton;
    }
}