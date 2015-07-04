namespace min_lan
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.serverBox = new System.Windows.Forms.ComboBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.loadBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.passwordPicture = new System.Windows.Forms.PictureBox();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            this.internetButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.passwordBox.Location = new System.Drawing.Point(320, 470);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(175, 30);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.Text = "Пароль";
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.loginBox.Location = new System.Drawing.Point(48, 471);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(194, 30);
            this.loginBox.TabIndex = 0;
            this.loginBox.Text = "Логин";
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            // 
            // serverBox
            // 
            this.serverBox.BackColor = System.Drawing.SystemColors.Window;
            this.serverBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.serverBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.serverBox.FormattingEnabled = true;
            this.serverBox.Items.AddRange(new object[] {
            "Server",
            "Test",
            "D.E.M.E.N.T.I.A."});
            this.serverBox.Location = new System.Drawing.Point(12, 12);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(207, 30);
            this.serverBox.TabIndex = 3;
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.BackColor = System.Drawing.Color.Transparent;
            this.serverLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.serverLabel.Location = new System.Drawing.Point(225, 15);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(140, 22);
            this.serverLabel.TabIndex = 7;
            this.serverLabel.Text = "Выбор сервера";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 42);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(828, 422);
            this.webBrowser1.TabIndex = 4;
            // 
            // loadBar
            // 
            this.loadBar.BackColor = System.Drawing.SystemColors.Window;
            this.loadBar.Location = new System.Drawing.Point(0, 434);
            this.loadBar.Name = "loadBar";
            this.loadBar.Size = new System.Drawing.Size(828, 30);
            this.loadBar.TabIndex = 12;
            this.loadBar.Visible = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Window;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.startButton.Location = new System.Drawing.Point(622, 470);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(194, 30);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Войти";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // passwordPicture
            // 
            this.passwordPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordPicture.Image = global::min_lan.Properties.Resources.password;
            this.passwordPicture.Location = new System.Drawing.Point(284, 471);
            this.passwordPicture.Name = "passwordPicture";
            this.passwordPicture.Size = new System.Drawing.Size(30, 30);
            this.passwordPicture.TabIndex = 19;
            this.passwordPicture.TabStop = false;
            // 
            // loginPicture
            // 
            this.loginPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPicture.Image = global::min_lan.Properties.Resources.login;
            this.loginPicture.Location = new System.Drawing.Point(12, 470);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(30, 30);
            this.loginPicture.TabIndex = 18;
            this.loginPicture.TabStop = false;
            // 
            // internetButton
            // 
            this.internetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.internetButton.Image = global::min_lan.Properties.Resources.internet;
            this.internetButton.Location = new System.Drawing.Point(586, 470);
            this.internetButton.Name = "internetButton";
            this.internetButton.Size = new System.Drawing.Size(30, 30);
            this.internetButton.TabIndex = 17;
            this.internetButton.TabStop = false;
            this.internetButton.Click += new System.EventHandler(this.pictureBox5_Click);
            this.internetButton.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            this.internetButton.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.Image = global::min_lan.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(783, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(46, 30);
            this.closeButton.TabIndex = 15;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.pictureBox3_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Image = global::min_lan.Properties.Resources.minimize;
            this.minimizeButton.Location = new System.Drawing.Point(737, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(46, 30);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizeButton.TabIndex = 14;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.pictureBox2_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeBox_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeBox_MouseLeave);
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Image = global::min_lan.Properties.Resources.settings;
            this.settingsButton.Location = new System.Drawing.Point(550, 471);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(30, 30);
            this.settingsButton.TabIndex = 13;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.pictureBox1_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.settingsButton.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(828, 512);
            this.Controls.Add(this.passwordPicture);
            this.Controls.Add(this.loginPicture);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.internetButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.loadBar);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.passwordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D.E.M.E.N.T.I.A.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveVindow);
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.ComboBox serverBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ProgressBar loadBar;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox internetButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox loginPicture;
        private System.Windows.Forms.PictureBox passwordPicture;
    }
}

