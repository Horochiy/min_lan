using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace min_lan
{
	class Http
	{
		public BackgroundWorker worker;

		// Конструктор
		public Http(BackgroundWorker backgroundWorker)
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
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			worker.ReportProgress(0);
		}

		// Отправка POST-запроса
		public static string Post(string adress, NameValueCollection values)
		{
			WebClient client = new WebClient();

			byte[] response = client.UploadValues(adress, values);

			return Encoding.Default.GetString(response);
		}
	}
}
