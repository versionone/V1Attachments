using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace V1Attachments
{
	static class Program
	{
		private static NameValueCollection _commandline;
		public static NameValueCollection CommandLine
		{
			get
			{
				if (_commandline == null)
				{
					_commandline = new NameValueCollection();
					ParseCommandLine(Environment.GetCommandLineArgs(), _commandline);
				}
				return _commandline;
			}
		}

		private static readonly char[] _CommandLineDelims = { ':', '=' };
		private static readonly string _CommandLineStartChar = "/-";
		private static void ParseCommandLine(string[] args, NameValueCollection namevalues)
		{
			for (int a = 1; a < args.Length; ++a)
			{
				string arg = args[a];
				if (_CommandLineStartChar.IndexOf(arg[0]) >= 0)
				{
					int i = arg.IndexOfAny(_CommandLineDelims, 1);
					if (i == -1)
						namevalues.Add(arg.Substring(1), string.Empty);
					else
						namevalues.Add(arg.Substring(1, i - 1), arg.Substring(i + 1));
				}
				else
					namevalues.Add(null, arg);
			}
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(CommandLine[null]));
		}
	}
}