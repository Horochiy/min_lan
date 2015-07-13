using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace min_lan
{
    class FileDownloader
    {
        public BackgroundWorker worker;
        
        // Конструктор
        public FileDownloader(BackgroundWorker backgroundWorker)
        {
            worker = backgroundWorker;
        }
        
        // Загрузка файла
        public void DownloadFile(string adress, string path)
        {
            WebClient downloader = new WebClient();
            downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(downloader_DownloadFileCompleted);
            try
            {
                downloader.DownloadFileAsync(new Uri(adress), path);
                while (downloader.IsBusy) 
                    Application.DoEvents();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            worker.ReportProgress(0);
            //MessageBox.Show("Downloaded!");
        }
    }
}
