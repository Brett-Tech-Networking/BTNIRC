namespace BTN_IRC.Forms
{
    partial class ChanelFavAdd
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
            this.Channelnsert = new MetroFramework.Controls.MetroTextBox();
            this.AddToFav = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Channelnsert
            // 
            // 
            // 
            // 
            this.Channelnsert.CustomButton.Image = null;
            this.Channelnsert.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.Channelnsert.CustomButton.Name = "";
            this.Channelnsert.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Channelnsert.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Channelnsert.CustomButton.TabIndex = 1;
            this.Channelnsert.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Channelnsert.CustomButton.UseSelectable = true;
            this.Channelnsert.CustomButton.Visible = false;
            this.Channelnsert.Lines = new string[0];
            this.Channelnsert.Location = new System.Drawing.Point(37, 69);
            this.Channelnsert.MaxLength = 32767;
            this.Channelnsert.Name = "Channelnsert";
            this.Channelnsert.PasswordChar = '\0';
            this.Channelnsert.PromptText = "#lobby";
            this.Channelnsert.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Channelnsert.SelectedText = "";
            this.Channelnsert.SelectionLength = 0;
            this.Channelnsert.SelectionStart = 0;
            this.Channelnsert.ShortcutsEnabled = true;
            this.Channelnsert.Size = new System.Drawing.Size(215, 23);
            this.Channelnsert.Style = MetroFramework.MetroColorStyle.Red;
            this.Channelnsert.TabIndex = 0;
            this.Channelnsert.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Channelnsert.UseSelectable = true;
            this.Channelnsert.WaterMark = "#lobby";
            this.Channelnsert.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Channelnsert.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddToFav
            // 
            this.AddToFav.Location = new System.Drawing.Point(261, 98);
            this.AddToFav.Name = "AddToFav";
            this.AddToFav.Size = new System.Drawing.Size(75, 23);
            this.AddToFav.Style = MetroFramework.MetroColorStyle.Red;
            this.AddToFav.TabIndex = 1;
            this.AddToFav.Text = "Add";
            this.AddToFav.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AddToFav.UseSelectable = true;
            this.AddToFav.Click += new System.EventHandler(this.AddToFav_Click);
            // 
            // ChanelFavAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 144);
            this.Controls.Add(this.AddToFav);
            this.Controls.Add(this.Channelnsert);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChanelFavAdd";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Add A Favorite Channel";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChanelFavAdd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Channelnsert;
        private MetroFramework.Controls.MetroButton AddToFav;
    }
}