using Class.Marshall;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.WinForms
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private AppDomainSetup _ads = null;
		private AppDomain _ad = null;

		private void btnListLoadedAsemblies_Click(object sender, EventArgs e)
		{
			rtbOutput.Clear();
			ListLoadedAssemblies();
		}

		private void ListLoadedAssemblies()
		{
			rtbOutput.AppendText("Application Domain     .Net Runtime Version  Assembly Version  Assembly\n");
			rtbOutput.AppendText("---------------------  --------------------  ----------------  -----------------------------------\n");

			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				int index1 = assembly.FullName.IndexOf(@"Version=") + 8;
				int index2 = assembly.FullName.IndexOf(@"Culture=");
				string aVersion = assembly.FullName.Substring(index1, index2 - index1 - 2);
			
				rtbOutput.AppendText(string.Format("{0, -21}  {1,-20}  {2,-16}  {3}\n", AppDomain.CurrentDomain.FriendlyName, assembly.ImageRuntimeVersion, aVersion, assembly.ManifestModule));
			}

			if (_ad != null)
			{
				foreach (Assembly assembly in _ad.GetAssemblies())
				{
					int index1 = assembly.FullName.IndexOf(@"Version=") + 8;
					int index2 = assembly.FullName.IndexOf(@"Culture=");
					string aVersion = assembly.FullName.Substring(index1, index2 - index1 - 2);

					rtbOutput.AppendText(string.Format("{0, -21}  {1,-20}  {2,-16}  {3}\n", _ad.FriendlyName, assembly.ImageRuntimeVersion, aVersion, assembly.ManifestModule));
				}
			}

		}

		private void btnV1_Click(object sender, EventArgs e)
		{
			InvokeMethod("Class.Library.v1.dll", "Class.Library.v1.Demo");
		}

		private void btnV2_Click(object sender, EventArgs e)
		{
			InvokeMethod("Class.Library.v2.dll", "Class.Library.v2.Demo");
		}

		private void InvokeMethod(string Assembly, string TypeName)
		{
			try
			{
				_ads = new AppDomainSetup();
				_ad = AppDomain.CreateDomain("My Demo Domain", null, _ads);

				string _filePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, Assembly);

				IMarshall dll = (IMarshall)_ad.CreateInstanceFromAndUnwrap(_filePath, TypeName);

				string _data = dll.FetchData();

				rtbOutput.Clear();
				ListLoadedAssemblies();

				rtbOutput.AppendText("\n" + _data);
			}
			finally
			{
				AppDomain.Unload(_ad);
				_ad = null;
				_ads = null;
			}
		}
	}
}
