using System.Collections.Specialized;
using System.Windows.Forms;

namespace min_lan
{
	static class Authentication
	{
		public static string LogIn(string username, string password)
		{
			string session = "";

			NameValueCollection userData = new NameValueCollection();
			userData["username"] = username;
			userData["password"] = Hasher.GetMD5(Hasher.GetMD5(password));

			string response = Http.Post("", userData);

			if (response == "error")
				MessageBox.Show("Ошибка аутенфикации");
			else if (response == "badpass")
				MessageBox.Show("Неверный логин или пароль!");
			else
				session = response;

			return session;
		}
	}
}
