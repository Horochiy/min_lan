using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace min_lan
{
	static class Hasher
	{
		// Вычисление MD5 хэша строки
		public static string GetMD5(string s)
		{
			MD5 md5 = MD5.Create();

			byte[] byteString = new UTF8Encoding().GetBytes(s);
			byte[] hash = md5.ComputeHash(byteString);

			return HashConverter(hash);
		}

		// Вычисление SHA256 хэша файла
		public static string GetSHA256(FileInfo file)
		{
			SHA256 sha256 = SHA256.Create();

			FileStream fileStream = file.Open(FileMode.Open);
			fileStream.Position = 0;
			byte[] hash = sha256.ComputeHash(fileStream);
			fileStream.Close();

			return HashConverter(hash);
		}

		// Приведение хэша к стандартному виду
		private static string HashConverter(byte[] hashValue)
		{
			return BitConverter.ToString(hashValue).Replace("-", "").ToLower();
		}
	}
}
