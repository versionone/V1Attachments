using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Win32;
using VersionOne.SDK.ObjectModel;

namespace V1Attachments
{
	public class Helper
	{
		public static void OpenDetailPage(string id)
		{
			Process.Start(GetDefaultBrowserPath(), Global.Instance.Get.GetByID<BaseAsset>(id).URL);
		}

		public static string GetDefaultBrowserPath()
		{
			return ((string)Registry.ClassesRoot.OpenSubKey(@"htmlfile\shell\open\command", false).GetValue(null, null)).Split('"')[1];
		}
	}
}
