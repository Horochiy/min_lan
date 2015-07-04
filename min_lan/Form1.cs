using Shell32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace min_lan
{
    public partial class Form1 : Form
    {
        
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int removeFontResourceEx(string lpszFilename, int fl, IntPtr pdv);
        static string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string path = appData + @"\.minecraft\savedata.inc";
        Form2 secondForm = new Form2();

        int mem;
        string game = ".minecraft";
        string server = "ForgeOptiFine 1.6.4";
        const string ip = "127.0.0.1";
        string updateSite = "http://getfile.esy.es/minecraft";

        public static void unzip(string f1, string f2)
        {
            Folder df = new Shell().NameSpace(f1);

            Folder ds = new Shell().NameSpace(f2);

            ds.CopyHere(df.Items(), 20);
        }

        private void checknative(string dir, string lib)
        {
            try
            {
                chekdir(dir);
                // System.IO.File.Move(lib + ".jar", lib + ".zip");
                // unzip(lib + ".zip", dir);
                //  System.IO.File.Move(lib + ".zip", lib + ".jar");
                //  if (System.IO.Directory.Exists(dir + "\\META-INF"))
                //  {
                //     System.IO.Directory.Delete(dir + "\\META-INF", true);
                //  }
            }
            catch (Exception e)
            {

            }
        }

        private void natives(string natives, string vers)
        {
            string waylib = appData + "\\" + game + "\\libraries\\";
            string url, way = appData + "\\" + game + "\\";
            string dir, file;
            switch (natives)
            {
                case "jinput-platform-2.0.5-natives-windows":
                    dir = waylib + "net\\java\\jinput\\jinput-platform\\2.0.5\\";
                    chekdir(dir);
                    file = dir + "jinput-platform-2.0.5-natives-windows.jar";
                    url = "https://libraries.minecraft.net/net/java/jinput/jinput-platform/2.0.5/jinput-platform-2.0.5-natives-windows.jar";
                    checkfile(url, file);
                    checknative(vers, dir + "jinput-platform-2.0.5-natives-windows");
                    break;
                case "lwjgl-platform-2.9.0-natives-windows":
                    dir = waylib + "org\\lwjgl\\lwjgl\\lwjgl-platform\\2.9.0\\";
                    chekdir(dir);
                    file = dir + "lwjgl-platform-2.9.0-natives-windows.jar";
                    url = "https://libraries.minecraft.net/org/lwjgl/lwjgl/lwjgl-platform/2.9.0/lwjgl-platform-2.9.0-natives-windows.jar";
                    checkfile(url, file);
                    checknative(vers, dir + "lwjgl-platform-2.9.0-natives-windows");
                    break;
            }
        }

        private void core(string vers)
        {

            string url, way = appData + "\\" + game + "\\";

            chekdir(way + "versions\\" + server + @"\");
            string f = way + "versions\\" + server + @"\" + server + @".jar";
            url = updateSite + "/" + server + "/ForgeOptiFine 1.6.4.jar";
            checkfile(url, f);
        }

        private void checkfile(string url, string file)
        {
            // if (!System.IO.File.Exists(file))
            // {
                webclient(url, file);
            // }
        }
        private void webclient(string url, string path)
        {
            System.Net.WebClient Downloader = new System.Net.WebClient();
            Downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            try
            {
                Downloader.DownloadFileAsync(new Uri(url), path);
                while (Downloader.IsBusy) { Application.DoEvents(); }
            }
            catch (Exception e) 
            { 
                MessageBox.Show(e.ToString()); 
            }
        }

        int firstbar;
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (firstbar > 2)
                loadBar.Value = loadBar.Value + 10;
            firstbar++;
        }

        private void chekdir(string dir)
        {
            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.DirectoryInfo direct = new System.IO.DirectoryInfo(dir);
                direct.Create();
            }
        }

        private void lib(string library)
        {
            string dir;
            string waylib = appData + "\\" + game + "\\libraries\\";
            string url, file;

            switch (library)
            {
                case "jopt-simple-4.5":
                    dir = waylib + "net\\sf\\jopt-simple\\jopt-simple\\4.5\\";
                    chekdir(dir);
                    file = dir + "jopt-simple-4.5.jar";
                    url = "https://libraries.minecraft.net/net/sf/jopt-simple/jopt-simple/4.5/jopt-simple-4.5.jar";
                    checkfile(url, file);
                    break;
                case "codecjorbis-20101023":
                    dir = waylib + "com\\paulscode\\codecjorbis\\20101023\\";
                    chekdir(dir);
                    file = dir + "codecjorbis-20101023.jar";
                    url = "https://libraries.minecraft.net/com/paulscode/codecjorbis/20101023/codecjorbis-20101023.jar";
                    checkfile(url, file);
                    break;
                case "codecwav-20101023":
                    dir = waylib + "com\\paulscode\\codecwav\\20101023\\";
                    chekdir(dir);
                    file = dir + "codecwav-20101023.jar";
                    url = "https://libraries.minecraft.net/com/paulscode/codecwav/20101023/codecwav-20101023.jar";
                    checkfile(url, file);
                    break;
                case "libraryjavasound-20101123":
                    dir = waylib + "com\\paulscode\\libraryjavasound\\20101123\\";
                    chekdir(dir);
                    file = dir + "libraryjavasound-20101123.jar";
                    url = "https://libraries.minecraft.net/com/paulscode/libraryjavasound/20101123/libraryjavasound-20101123.jar";
                    checkfile(url, file);
                    break;
                case "librarylwjglopenal-20100824":
                    dir = waylib + "com\\paulscode\\librarylwjglopenal\\20100824\\";
                    chekdir(dir);
                    file = dir + "librarylwjglopenal-20100824.jar";
                    url = "https://libraries.minecraft.net/com/paulscode/librarylwjglopenal/20100824/librarylwjglopenal-20100824.jar";
                    checkfile(url, file);
                    break;
                case "soundsystem-20120107":
                    dir = waylib + "com\\paulscode\\soundsystem\\20120107\\";
                    chekdir(dir);
                    file = dir + "soundsystem-20120107.jar";
                    url = "https://libraries.minecraft.net/com/paulscode/soundsystem/20120107/soundsystem-20120107.jar";
                    checkfile(url, file);
                    break;


                case "commons-lang3-3.1":
                    dir = waylib + "org\\apache\\commons\\commons-lang3\\3.1\\";
                    chekdir(dir);
                    file = dir + "commons-lang3-3.1.jar";
                    url = "https://libraries.minecraft.net/org/apache/commons/commons-lang3/3.1/commons-lang3-3.1.jar";
                    checkfile(url, file);
                    break;
                case "commons-io-2.4":
                    dir = waylib + "commons-io\\commons-io\\2.4\\";
                    chekdir(dir);
                    file = dir + "commons-io-2.4.jar";
                    url = "https://libraries.minecraft.net/commons-io/commons-io/2.4/commons-io-2.4.jar";
                    checkfile(url, file);
                    break;
                case "jinput-2.0.5":
                    dir = waylib + "net\\java\\jinput\\jinput\\2.0.5\\";
                    chekdir(dir);
                    file = dir + "jinput-2.0.5.jar";
                    url = "https://libraries.minecraft.net/net/java/jinput/jinput/2.0.5/jinput-2.0.5.jar";
                    checkfile(url, file);
                    break;
                case "jutils-1.0.0":
                    dir = waylib + "net\\java\\jutils\\jutils\\1.0.0\\";
                    chekdir(dir);
                    file = dir + "jutils-1.0.0.jar";
                    url = "https://libraries.minecraft.net/net/java/jutils/jutils/1.0.0/jutils-1.0.0.jar";
                    checkfile(url, file);
                    break;



                case "argo-2.25_fixed":
                    dir = waylib + "argo\\argo\\2.25_fixed\\";
                    chekdir(dir);
                    file = dir + "argo-2.25_fixed.jar";
                    url = "https://libraries.minecraft.net/argo/argo/2.25_fixed/argo-2.25_fixed.jar";
                    checkfile(url, file);
                    break;
                case "bcprov-jdk15on-1.47":
                    dir = waylib + "org\\bouncycastle\\bcprov-jdk15on\\1.47\\";
                    chekdir(dir);
                    file = dir + "bcprov-jdk15on-1.47.jar";
                    url = "https://libraries.minecraft.net/org/bouncycastle/bcprov-jdk15on/1.47/bcprov-jdk15on-1.47.jar";
                    checkfile(url, file);
                    break;
                case "gson-2.2.2":
                    dir = waylib + "com\\google\\code\\gson\\gson\\2.2.2\\";
                    chekdir(dir);
                    file = dir + "gson-2.2.2.jar";
                    url = "https://libraries.minecraft.net/com/google/code/gson/gson/2.2.2/gson-2.2.2.jar";
                    checkfile(url, file);
                    break;
                case "guava-14.0":
                    dir = waylib + "com\\google\\guava\\guava\\14.0\\";
                    chekdir(dir);
                    file = dir + "guava-14.0.jar";
                    url = "https://libraries.minecraft.net/com/google/guava/guava/14.0/guava-14.0.jar";
                    checkfile(url, file);
                    break;
                case "lwjgl-2.9.0":
                    dir = waylib + "org\\lwjgl\\lwjgl\\lwjgl\\2.9.0\\";
                    chekdir(dir);
                    file = dir + "lwjgl-2.9.0.jar";
                    url = "https://libraries.minecraft.net/org/lwjgl/lwjgl/lwjgl/2.9.0/lwjgl-2.9.0.jar";
                    checkfile(url, file);
                    break;
                case "lwjgl_util-2.9.0":
                    dir = waylib + "org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.0\\";
                    chekdir(dir);
                    file = dir + "lwjgl_util-2.9.0.jar";
                    url = "https://libraries.minecraft.net/org/lwjgl/lwjgl/lwjgl_util/2.9.0/lwjgl_util-2.9.0.jar";
                    checkfile(url, file);
                    break;
            }
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void ReadFile()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(path);

                for (int i = 0; i < 3; i++)
                    lines[i] = Base64Decode(lines[i]);

                int.TryParse(lines[0], out mem);
                loginBox.Text = lines[1];
                passwordBox.Text = lines[2];
            }
            catch (Exception ex)
            {
                mem = 1024;
            }
        }
        private void WriteFile()
        {
            try
            {
                if (secondForm.memory != 0)
                {
                    mem = secondForm.memory;
                }

                Encoding enc = Encoding.UTF32;

                string[] lines = new string[3];

                lines[2] = passwordBox.Text;

                lines[0] = Base64Encode(mem.ToString());
                lines[1] = Base64Encode(loginBox.Text);
                lines[2] = Base64Encode(passwordBox.Text);
                System.IO.File.WriteAllLines(path, lines);
            }
            catch (Exception ex)
            {
                System.IO.File.Create(path);
                WriteFile();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serverBox.SelectedIndex = 0;
            checkfile(@"http://getfile.esy.es/minecraft/creep2.ttf", appData + "\\" + game + "\\" + "creep2.ttf");
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile(appData + "\\" + game + "\\" + "creep2.ttf");
            passwordBox.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //    checkfile(@"http://getfile.esy.es/minecraft/ForgeOptiFine 1.6.4/ForgeOptiFine 1.6.4.jar", @"C:\Users\vladislav\AppData\Roaming\.minecraft\versions\ForgeOptiFine 1.6.4\ForgeOptiFine 1.6.4.jar");
            //    checkfile(@"http://getfile.esy.es/minecraft/ForgeOptiFine 1.6.4/ForgeOptiFine 1.6.4.jar", @"%appdata%\.minecraft\versions\ForgeOptiFine 1.6.4\ForgeOptiFine 1.6.4.jar");

            webBrowser1.Navigate("http://dementia.esy.es/");
            ReadFile();
        }

        public void MoveVindow(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("http://");
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            secondForm.Show();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void internetButton_Click(object sender, EventArgs e)
        {
            Process.Start("http://dementia.esy.es/");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            loadBar.Visible = true;
            webBrowser1.Height = 402;
            string way = "%appdata%\\" + game + "\\";
            WriteFile();
            loadBar.Value = 0;
            loadBar.Maximum = 190;
            //проверка файлов
            lib("jopt-simple-4.5");
            lib("codecjorbis-20101023");
            lib("codecwav-20101023");
            lib("libraryjavasound-20101123");
            lib("librarylwjglopenal-20100824");
            lib("soundsystem-20120107");
            lib("argo-2.25_fixed");
            lib("bcprov-jdk15on-1.47");
            lib("guava-14.0");
            lib("commons-lang3-3.1");
            lib("commons-io-2.4");
            lib("jinput-2.0.5");
            lib("jutils-1.0.0");
            lib("gson-2.2.2");
            lib("lwjgl-2.9.0");
            lib("lwjgl_util-2.9.0");
            core("1.6.4");
            natives("jinput-platform-2.0.5-natives-windows", way + "versions\\1.6.4\\natives");
            natives("lwjgl-platform-2.9.0-natives-windows", way + "versions\\1.6.4\\natives");
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            Process.Start("javaw", @" -Xmx" + mem + "M  -Djava.library.path=" + "\"" + @"%appdata%\.minecraft\versions\ForgeOptiFine 1.6.4\natives" + "\"" + @" -cp " + "\"" + @"%appdata%\.minecraft\libraries\optifine\OptiFine\1.6.4_HD_U_D1\optifine-1.6.4_HD_U_D1.jar;%appdata%\.minecraft\libraries\net\minecraftforge\minecraftforge\9.11.1.1345\minecraftforge-9.11.1.1345.jar;%appdata%\.minecraft\libraries\net\minecraft\launchwrapper\1.8\launchwrapper-1.8.jar;%appdata%\.minecraft\libraries\org\ow2\asm\asm-all\4.1\asm-all-4.1.jar;%appdata%\.minecraft\libraries\org\scala-lang\scala-library\2.10.2\scala-library-2.10.2.jar;%appdata%\.minecraft\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar;%appdata%\.minecraft\libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;%appdata%\.minecraft\libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;%appdata%\.minecraft\libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;%appdata%\.minecraft\libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;%appdata%\.minecraft\libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;%appdata%\.minecraft\libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;%appdata%\.minecraft\libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;%appdata%\.minecraft\libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;%appdata%\.minecraft\libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;%appdata%\.minecraft\libraries\com\google\guava\guava\14.0\guava-14.0.jar;%appdata%\.minecraft\libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;%appdata%\.minecraft\libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;%appdata%\.minecraft\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;%appdata%\.minecraft\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;%appdata%\.minecraft\libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;%appdata%\.minecraft\libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;%appdata%\.minecraft\libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;%appdata%\.minecraft\versions\ForgeOptiFine 1.6.4\ForgeOptiFine 1.6.4.jar" + "\"" + @" -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true net.minecraft.launchwrapper.Launch --username " + "\"" + loginBox.Text + "\"" + @" --session " + "\"" + @"5555" + "\"" + @" --version " + "\"" + @"OptifIne" + "\"" + @" --gameDir " + "\"" + @"%appdata%\.minecraft" + "\"" + @" --assetsDir " + "\"" + @"%appdata%\.minecraft\assets\virtual\legacy" + "\"" + @" --tweakClass cpw.mods.fml.common.launcher.FMLTweaker --server " + ip);

            loadBar.Value = 190;
            loadBar.Visible = false;
            if (IsRunning()) this.Hide();
            timer1.Enabled = true;
        }

        bool login;
        private void loginBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!login)
            {
                login = true;
                loginBox.Text = "";
            }
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.Image = Properties.Resources.minimize_alt;
        }

        private bool IsRunning()
        {
            return Process.GetProcessesByName("javaw").Length > 0;
        }
        
        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.Image = Properties.Resources.minimize;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!IsRunning())
            {
                this.Show();
                timer1.Enabled = false;
            }
        }

        private void internetButton_MouseEnter(object sender, EventArgs e)
        {
            internetButton.Image = Properties.Resources.internet_alt;
        }

        private void internetButton_MouseLeave(object sender, EventArgs e)
        {
            internetButton.Image = Properties.Resources.internet;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close_alt;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close;
        }

        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.Image = Properties.Resources.settings_alt;
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.Image = Properties.Resources.settings;
        }
    }
}