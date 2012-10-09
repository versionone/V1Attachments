using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using VersionOne.SDK.ObjectModel;
using VersionOne.SDK.ObjectModel.Filters;

namespace V1Attachments
{
	public partial class SearchForm : Form
	{
		private const int MaximumRecentSearchItems = 10;

		private Thread _worker;

		private Entity _selectedEntity;
		public Entity SelectedEntity { get { return _selectedEntity; } }

		private bool HasSelectedEntity { get { return listItems.SelectedItems.Count == 1; } }

		public SearchForm()
		{
			InitializeComponent();

			UpdateRecentSearches();
			UpdateButtonState();
		}

		private void UpdateRecentSearches()
		{
			AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
			IList<string> items = Global.Config.RecentSearches;
			string[] list = new string[items.Count];
			items.CopyTo(list, 0);
			auto.AddRange(list);

			txtSearch.AutoCompleteCustomSource = auto;
			txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}

		private void UpdateButtonState()
		{
			btnOk.Enabled = HasSelectedEntity;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (HasSelectedEntity)
			{
				_selectedEntity = Global.Instance.Get.GetByID<Entity>((string) listItems.SelectedItems[0].Tag);
				Close();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (txtSearch.Enabled)
			{
				btnSearch.Tag = btnSearch.Text;
				btnSearch.Text = "Cancel";
				txtSearch.Enabled = false;

				Config.UpdateRecentList(Global.Config.RecentSearches, txtSearch.Text, MaximumRecentSearchItems);

				UpdateRecentSearches();

				listItems.Items.Clear();

				_worker = new Thread(DoSearch);
				_worker.Start();
			}
			else
			{
				CancelAndWait();
				SearchCompleted();
			}
		}

		private delegate void ResultDelegate(string name, string displayid, string id, bool closed, string type);
		private void AddResult(string name, string displayid, string id, bool closed, string type)
		{
			if (InvokeRequired)
			{
				BeginInvoke(new ResultDelegate(AddResult), name, displayid, id, closed, type);
				return;
			}
			ListViewItem item = new ListViewItem(new string[] {name, displayid}, type);
			if (closed)
				item.Font = new Font(item.Font, FontStyle.Strikeout);
			item.Tag = id;
			listItems.Items.Add(item);
		}

		private delegate void CompletedDelegate();
		private void SearchCompleted()
		{
			if (InvokeRequired)
			{
				Invoke(new CompletedDelegate(SearchCompleted));
				return;
			}
			txtSearch.Enabled = true;
			btnSearch.Text = (string)btnSearch.Tag;
		}

		private bool _cancelled = false;
		private void DoSearch()
		{
			BaseAssetFilter filter = new BaseAssetFilter();
			filter.Find.SearchString = txtSearch.Text;
			foreach (BaseAsset asset in Global.Instance.Get.BaseAssets(filter))
			{
				if (_cancelled)
					break;
				string displayid = asset is ProjectAsset ? ((ProjectAsset) asset).DisplayID : string.Empty;
				AddResult(asset.Name, displayid, asset.ID, asset.IsClosed, asset.GetType().Name);
			}
			if (!_cancelled)
				SearchCompleted();
			_cancelled = false;
		}

		private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CancelAndWait();
		}

		private void CancelAndWait()
		{
			_cancelled = true;
			if (_worker != null)
			{
				_worker.Join();
				_worker = null;
			}
		}

		private void listItems_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateButtonState();
		}

		private void listItems_DoubleClick(object sender, EventArgs e)
		{
			Helper.OpenDetailPage((string) listItems.SelectedItems[0].Tag);
		}
	}
}