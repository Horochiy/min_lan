using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace min_lan
{
    class FileChecker
    {
        public string gameDir;
        
        private const string librariesAdress = "https://libraries.minecraft.net/";
        private const string updateAdress = "http://getfile.esy.es/minecraft";

        public BackgroundWorker worker;

        string[]
            libraries = 
            {
                @"argo\argo\2.25_fixed\argo-2.25_fixed.jar",
                @"com\google\code\gson\gson\2.2.2\gson-2.2.2.jar",
                @"com\google\guava\guava\14.0\guava-14.0.jar",
                @"com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar",
                @"com\paulscode\codecwav\20101023\codecwav-20101023.jar",
                @"com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar",
                @"com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar",
                @"com\paulscode\soundsystem\20120107\soundsystem-20120107.jar",
                @"commons-io\commons-io\2.4\commons-io-2.4.jar",
                @"lzma\lzma\0.0.1\lzma-0.0.1.jar",
                @"net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar",
                @"net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar",
                @"net\minecraft\launchwrapper\1.8\launchwrapper-1.8.jar",
                @"net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar",
                @"org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar",
                @"org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar",
                @"org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar",
                @"org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar",
                @"org\ow2\asm\asm-all\4.1\asm-all-4.1.jar"
                //@"org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar",
                //@"org\scala-lang\scala-library\2.10.2\scala-library-2.10.2.jar",
                //@"net\minecraftforge\minecraftforge\9.11.1.1345\minecraftforge-9.11.1.1345.jar",
                //@"optifine\OptiFine\1.6.4_HD_U_D1\OptiFine-1.6.4_HD_U_D1.jar"
            },
            natives = 
            {
                @"net\java\jinput\jinput-platform\2.0.5\jinput-platform-2.0.5-natives-windows.jar",
                @"org\lwjgl\lwjgl\lwjgl-platform\2.9.0\lwjgl-platform-2.9.0-natives-windows.jar"
            };
        
        // Конструктор
        public FileChecker(BackgroundWorker backgroundWorker, string dir)
        {
            worker = backgroundWorker;
            gameDir = dir;
        }

        // Проверка всех файлов
        public void CheckAllFiles(string version)
        {
            string path = "", adress = "";
            
            // Проверка библиотек
            string[] files = libraries.Concat(natives).ToArray();
            Parallel.ForEach
                (
                    files, fileName =>
                    {
                        path = gameDir + "\\libraries\\" + fileName;
                        adress = librariesAdress + fileName.Replace("\\", "/");
                        CheckFile(path, adress);
                    }
                );

            // Проверка файла версии
            path = gameDir + @"\versions\" + version + "\\" + version + ".jar";
            adress = updateAdress + "/" + version + "/" + version + ".jar";
            CheckFile(path, adress);
        }
        
        // Проверка файла на наличие и соответствие
        private void CheckFile(string path, string adress)
        {
            FileDownloader downloader = new FileDownloader(worker);
            
            FileInfo file = new FileInfo(path);
            DirectoryInfo directory = file.Directory;
            
            if (directory.Exists)
                if (file.Exists)
                {
                    string hash = GetHashString(file);

                    // TODO сравнение хэша с хранящимся на сервере
                    if (hash != hash)
                        downloader.DownloadFile(adress, path);
                    else
                        worker.ReportProgress(0);
                }
                else
                    downloader.DownloadFile(adress, path);
            else
            {
                directory.Create();
                downloader.DownloadFile(adress, path);
            }
        }
        
        // Вычисление SHA256 хэша файла и возврат его в строковом представлении
        private string GetHashString(FileInfo file)
        {
            SHA256 sha256 = SHA256Managed.Create();
            FileStream fileStream = file.Open(FileMode.Open);
            fileStream.Position = 0;
            byte[] hashValue = sha256.ComputeHash(fileStream);
            fileStream.Close();

            return BitConverter.ToString(hashValue).Replace("-", "");
        }
    }
}
