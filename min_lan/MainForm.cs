using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace min_lan
{
    public partial class MainFrom : Form
    {
        /*
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int removeFontResourceEx(string lpszFilename, int fl, IntPtr pdv);
        */

        SettingsForm settings = new SettingsForm();
        Launcher launcher = new Launcher();

        const string dataFile = "savedata.inc";
        
        string updateSite = "http://getfile.esy.es/minecraft";

        // Конструктор
        public MainFrom()
        {
            InitializeComponent();
        }

        // Загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            // Считывание сохранённых данных
            ReadData(launcher.gameDir + "\\" + dataFile);

            usernameBox.Text = launcher.username;
            passwordBox.Text = launcher.password;

            /* checkfile(@"http://getfile.esy.es/minecraft/creep2.ttf", gameDir + "\\" + "creep2.ttf");
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile(gameDir + "\\" + "creep2.ttf");
            passwordBox.Font = new Font(pfc.Families[0], 16, FontStyle.Regular*/
            // checkfile(@"http://getfile.esy.es/minecraft/ForgeOptiFine 1.6.4/ForgeOptiFine 1.6.4.jar", @"C:\Users\vladislav\AppData\Roaming\.minecraft\versions\ForgeOptiFine 1.6.4\ForgeOptiFine 1.6.4.jar");
            // checkfile(@"http://getfile.esy.es/minecraft/ForgeOptiFine 1.6.4/ForgeOptiFine 1.6.4.jar", @"%appdata%\.minecraft\versions\ForgeOptiFine 1.6.4\ForgeOptiFine 1.6.4.jar");
        }
        
        // Поддержка перемещения окна
        public void MoveVindow(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        // Кнопка "Закрыть"
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close_alt;
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Кнопка "Свернуть"
        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.Image = Properties.Resources.minimize_alt;
        }
        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.Image = Properties.Resources.minimize;
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Кнопка "Перейти на сайт"
        private void internetButton_MouseEnter(object sender, EventArgs e)
        {
            internetButton.Image = Properties.Resources.internet_alt;
        }
        private void internetButton_MouseLeave(object sender, EventArgs e)
        {
            internetButton.Image = Properties.Resources.internet;
        }
        private void internetButton_Click(object sender, EventArgs e)
        {
            Process.Start("http://dementia.esy.es/");
        }

        // Кнопка "Настройки"
        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.Image = Properties.Resources.settings_alt;
        }
        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.Image = Properties.Resources.settings;
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings.Show();
        }

        // Поле ввода логина
        private void usernameBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (usernameBox.Text == launcher.username)
                usernameBox.Text = "";
        }

        // Поле ввода пароля
        private void passwordBox_Click(object sender, EventArgs e)
        {
            passwordBox.Text = "";
        }
        
        // Кнопка запуска
        private void startButton_Click(object sender, EventArgs e)
        {
            SwitchFields();
            
            switch (serverBox.SelectedIndex)
            {
                case 0:
                case 1:
                    launcher.version = "ForgeOptiFine 1.6.4";
                    launcher.server = "localhost";
                    break;
            }

            if (settings.memory != "")
                launcher.memory = settings.memory;

            SaveData(launcher.gameDir + "\\" + dataFile);

            // TODO Авторизация

            
            // Отображение индикатора загрузки
            loadBar.Visible = true;
            webBrowser.Height = 392;
            loadBar.Value = loadBar.Minimum;

            // Проверка файлов
            backgroundWorker.RunWorkerAsync();
            while (backgroundWorker.IsBusy)
                Application.DoEvents();

            // Скрытие индикатора загрузки
            loadBar.Value = loadBar.Maximum;
            webBrowser.Height = 422;
            loadBar.Visible = false;

            launcher.Launch();
            
            SwitchFields();

            if (IsRunning()) this.Hide();
            timer.Start();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            FileChecker checker = new FileChecker(worker, launcher.gameDir);
            checker.CheckAllFiles(launcher.version);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadBar.PerformStep();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("Completed!");
        }

        private void SwitchFields()
        {
            startButton.Enabled = !startButton.Enabled;
            usernameBox.Enabled = !usernameBox.Enabled;
            passwordBox.Enabled = !passwordBox.Enabled;
            serverBox.Enabled = !serverBox.Enabled;
        }

        private bool IsRunning()
        {
            return Process.GetProcessesByName("javaw").Length > 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!IsRunning())
            {
                this.Show();
                timer.Stop();
            }
        }

        // Что это???
        /* public static void unzip(string f1, string f2)
        {
            Folder df = new Shell().NameSpace(f1);

            Folder ds = new Shell().NameSpace(f2);

            ds.CopyHere(df.Items(), 20);
        } */

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void ReadData(string path)
        {
            if (File.Exists(path))
            {
                string[] data = File.ReadAllLines(path);

                for (int i = 0; i < 4; i++)
                    data[i] = Base64Decode(data[i]);

                launcher.username = data[0];
                launcher.password = data[1];
                serverBox.SelectedIndex = int.Parse(data[2]);
                launcher.memory = data[3];
            }
            else
            {
                File.Create(path);

                launcher.username = "Логин";
                launcher.password = "Пароль";
                serverBox.SelectedIndex = 0;
                launcher.memory = "1024";
            }
        }
        private void SaveData(string path)
        {
            string[] data = 
                {
                    Base64Encode(usernameBox.Text),
                    Base64Encode(passwordBox.Text),
                    Base64Encode(serverBox.SelectedIndex.ToString()),
                    Base64Encode(launcher.memory)
                };

            File.WriteAllLines(path, data);
        }
    }
}