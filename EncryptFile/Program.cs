using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EncryptFile
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			string arg = args.Length == 0 ? null : args[0];
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(arg));
		}
	}
}
