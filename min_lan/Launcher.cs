using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace min_lan
{
	class Launcher
	{
		private const string clientFolder = ".minecraft";
		
		public string gameDir, username, password, session, version, server, memory;

		// Конструктор
		public Launcher()
		{
			gameDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + clientFolder;
			session = "null";
			memory = "1024";
		}

		// Определение пути к javaw.exe
		private string GetJavaPath()
		{
			const string javaKey = @"SOFTWARE\JavaSoft\Java Runtime Environment";
			string javaFolder = "";

			try
			{
				RegistryKey baseKey =
					RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(javaKey);
				string currentVersion = baseKey.GetValue("CurrentVersion").ToString();
				RegistryKey homeKey = baseKey.OpenSubKey(currentVersion);
				javaFolder = homeKey.GetValue("JavaHome").ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Java не установлена, либо установлена неправильно!");
				Environment.Exit(0);
			}

			return javaFolder + "\\bin\\javaw.exe";
		}

		// Запуск клиента
		public void Launch()
		{
			string javaPath = GetJavaPath();
			
			string[] 
				classpath = 
				{
					@"{0}\versions\" + version + "\\" + version + ".jar",
					
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
					@"org\ow2\asm\asm-all\4.1\asm-all-4.1.jar",
					
					@"org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar",
					@"org\scala-lang\scala-library\2.10.2\scala-library-2.10.2.jar",
					@"net\minecraftforge\minecraftforge\9.11.1.1345\minecraftforge-9.11.1.1345.jar",
					
					@"optifine\OptiFine\1.6.4_HD_U_D1\OptiFine-1.6.4_HD_U_D1.jar"
				},
				javaArguments = 
				{
					"-Xmx" + memory + "M",
					"-Djava.library.path=\"" + gameDir + "\\versions\\" + version + "\\natives\"",
					"-cp \"" + string.Format(string.Join(";{0}{1}", classpath), gameDir, "\\libraries\\") + "\"",
					"-Dfml.ignoreInvalidMinecraftCertificates=true",
					"-Dfml.ignorePatchDiscrepancies=true"
				},
				minecraftArguments = 
				{
					"--username \"" + username + "\"",
					"--session " + session,
					"--version \"" + version + "\"",
					"--gameDir \"" + gameDir + "\"",
					"--assetsDir \"" + gameDir + "\\assets\\virtual\\legacy\"",
					"--tweakClass cpw.mods.fml.common.launcher.FMLTweaker",
					"--server " + server
				};

			string arguments =
				string.Join(" ", javaArguments) + 
				" net.minecraft.launchwrapper.Launch " +
				string.Join(" ", minecraftArguments);

			ProcessStartInfo minecraftStartInfo = new ProcessStartInfo(javaPath, arguments);
			Process.Start(minecraftStartInfo);
		}
	}
}
