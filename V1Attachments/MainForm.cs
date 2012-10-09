using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using VersionOne.SDK.ObjectModel;
using VersionOne.SDK.ObjectModel.Filters;

namespace V1Attachments
{
	public partial class MainForm : Form
	{
		private const int MaximumRememberedItems = 10;
		private const int MaximumRememberedMessages = 10;
		private const int MaximumVisibleMessageLength = 32;

		public MainForm(string file)
		{
			InitializeComponent();

			if (IsValidFile(file))
				SelectedFilename = file;

			UpdateButtonState();
			UpdateRecentItems();
			UpdateRecentMessages();
		}

		private string SelectedEntityID { get { if (lblSelectedItem.Tag == null) return null; return (AssetID)lblSelectedItem.Tag; } }
		private string SelectedFilename { get { return txtFilename.Text; } set { txtFilename.Text = value; } }
		private string Message { get { return txtMessage.Text; } set { txtMessage.Text = value; } }
		private string TitleText { get { return txtTitle.Text; } set { txtTitle.Text = value; } }

		private bool HasSelection { get { return SelectedEntityID != null; } }
		private bool HasFilename { get { return !string.IsNullOrEmpty(SelectedFilename); } }
		private bool HasMessage { get { return !string.IsNullOrEmpty(Message); } }
		private bool HasTitle { get { return !string.IsNullOrEmpty(TitleText); } }

		private static bool IsValidFile(string fileName)
		{
			return !string.IsNullOrEmpty(fileName) && System.IO.File.Exists(fileName);
		}

		private Image GetEntityImage(BaseAsset entity)
		{
			return iconList.Images[entity.GetType().Name];
		}

		private void UpdateButtonState()
		{
			btnOkNew.Enabled = btnOk.Enabled = IsValidFile(SelectedFilename) && HasSelection && HasTitle;

			if (!HasSelection)
				lblStatus.Text = "Please select an item to attach file to.";
			else if (!IsValidFile(SelectedFilename))
				lblStatus.Text = "Please select a file to attach.";
			else if (!HasTitle)
				lblStatus.Text = "Please enter a title for this attachment.";
			else if (btnOkNew.Enabled && !HasMessage)
				lblStatus.Text = "Ready to attach file. (Optional description is empty)";
			else if (btnOkNew.Enabled)
				lblStatus.Text = "Ready to attach file.";
		}

		private void UpdateSelectedEntity(string id)
		{
			if (!string.IsNullOrEmpty(id))
			{
				BaseAsset entity = Global.Instance.Get.GetByID<BaseAsset>(id);
				if (entity != null)
				{
					lblSelectedItem.Text = entity.Name;
					lblSelectedItem.Image = GetEntityImage(entity);
					lblSelectedItem.Tag = entity.ID;
					if (entity.IsClosed)
						lblSelectedItem.Font = new Font(lblSelectedItem.Font, FontStyle.Strikeout);
					lblSelectedItem.Visible = true;
				}
				else
					lblSelectedItem.Visible = false;
			}
			else
				lblSelectedItem.Visible = false;

			UpdateButtonState();
		}

		private void UpdateRecentItems()
		{
			btnRecentItems.DropDownItems.Clear();
			IList<string> items = Global.Config.RecentItems;
			int max = Math.Min(items.Count, MaximumRememberedItems);
			for (int i = 0; i < max; i++)
			{
				string recentItem = items[i];
				BaseAsset entity = Global.Instance.Get.GetByID<BaseAsset>(recentItem);
				if (entity != null)
				{
					ToolStripItem item = btnRecentItems.DropDownItems.Add(entity.Name);
					item.Image = GetEntityImage(entity);
					if (entity.IsClosed)
						item.Font = new Font(item.Font, FontStyle.Strikeout);
					item.Tag = recentItem;
					item.Click += RecentItem_ItemClick;
				}
			}

			if (btnRecentItems.DropDownItems.Count == 0)
				btnRecentItems.Enabled = false;
		}

		private void UpdateRecentMessages()
		{
			btnRecentMessages.DropDownItems.Clear();
			IList<string> messages = Global.Config.RecentMessages;
			int max = Math.Min(messages.Count, MaximumRememberedMessages);
			for (int i = 0; i < max;i++)
			{
				string message = messages[i];
				string fullmessage = message;
				if (message.Length > MaximumVisibleMessageLength)
					message = message.Substring(0, MaximumVisibleMessageLength) + "...";
				ToolStripItem item = btnRecentMessages.DropDownItems.Add(message);
				item.ToolTipText = fullmessage;
				item.Tag = i;
				item.Click += RecentMessage_Click;
			}
			if (btnRecentMessages.DropDownItems.Count == 0)
				btnRecentMessages.Enabled = false;
		}

		private void RecentItem_ItemClick(object sender, EventArgs e)
		{
			string id = ((string)((ToolStripItem)sender).Tag);
			UpdateSelectedEntity(id);
		}

		private void RecentMessage_Click(object sender, EventArgs e)
		{
			int index = ((int) ((ToolStripItem) sender).Tag);
			Message = Global.Config.RecentMessages[index];
		}

		private void lblSelectedItem_Click(object sender, EventArgs e)
		{
			Helper.OpenDetailPage((AssetID)lblSelectedItem.Tag);
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (HasFilename)
				openFileDialog.FileName = SelectedFilename;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				SelectedFilename = openFileDialog.FileName;
				UpdateButtonState();
			}
		}

		private void btnConfig_Click(object sender, EventArgs e)
		{
			new ConfigForm().ShowDialog(this);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (ExecuteUpload())
				Close();
		}

		private bool ExecuteUpload()
		{
			if (HasSelection && HasTitle && HasFilename)
			{
				BaseAsset asset = Global.Instance.Get.GetByID<BaseAsset>(SelectedEntityID);
				FileInfo info = new FileInfo(SelectedFilename);
				using (Stream stream = info.OpenRead())
				{
					Attachment attachment = asset.CreateAttachment(TitleText, info.Name, stream);
					if (HasMessage)
					{
						attachment.Description = Message;
						attachment.Save();
					}
				}
				return true;
			}
			return false;
		}

		private void btnOKNew_Click(object sender, EventArgs e)
		{
			ExecuteUpload();
			SyncRecents();
			UpdateRecentItems();
			UpdateRecentMessages();
			SelectedFilename = TitleText = Message = string.Empty;
			UpdateButtonState();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			SearchForm form = new SearchForm();
			if (form.ShowDialog(this) == DialogResult.OK)
				UpdateSelectedEntity(form.SelectedEntity.ID);
		}

		private void txtFilename_TextChanged(object sender, EventArgs e)
		{
			UpdateButtonState();
		}

		private void txtTitle_TextChanged(object sender, EventArgs e)
		{
			UpdateButtonState();
		}

		private void txtMessage_TextChanged(object sender, EventArgs e)
		{
			UpdateButtonState();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SyncRecents();
		}

		private void SyncRecents()
		{
			if (HasMessage)
				Config.UpdateRecentList(Global.Config.RecentMessages, Message, MaximumRememberedMessages);

			if (HasSelection)
				Config.UpdateRecentList(Global.Config.RecentItems, SelectedEntityID, MaximumRememberedItems);
		}
	}
}